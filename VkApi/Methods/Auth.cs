using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VkApi.Models;

namespace VkApi.Methods
{
    /// <summary>
    /// Методы для работы с авторизацией. 
    /// </summary>
    public class Auth
    {
        /// <summary>
        /// Строка ответа от google, нужна для работы метода Auth.refreshToken().
        /// <para>Если при использовании Auth.refreshToken() у вас не работают методы закрытого api, то скорее всего нужно заменить эту строку на новую.</para>
        /// </summary>
        public const string GOOGLE_PARAMS =
         "X-subtype=841415684880" +
         "&X-X-subscription=841415684880" +
         "&X-X-subtype=841415684880" +
         "&X-app_ver=1206" +
         "&X-kid=|ID|3|" +
         "&X-osv=27" +
         "&X-sig=AdCQpsh4plfflLkR4DnIneJMKlnYZvCJIkTuFIdkuzJM39Pj3Tq4rh1L02sjibmc0DKnUNRQwHeX3Pkf31V2JaQYUHUvWwp2cilkWqn-yWK2I3BR17z4UbC2RHNoOIapRYuejYjxKS3BIJmf5ARj6tvfxI8vdez-UFEBosQMIYPN6esTEueI0FI3e4sGq6dPyZCUXCX3RupaNhLYhDmGcRXE1Kz3auYOjHBk1ima3iMVhdCvBp-ncvck6O9SEPcSHBelb26resm46xQDpg0T2nvN84QJekru3WT7mA6clidcGMMk0WxDFcQmRxDnPXyJ7DaUhx0vX0D_oS3OAkajxg" +
         "&X-cliv=iid-9877000" +
         "&X-gmsv=11975940" +
         "&X-pub2=MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAtq3Bo6ht1fSQ_kXh3RNuc5OTImzjWqy4t8RYCZoKOg37wbB5p7vuPNZ82mPCZg2OMqNQLjw65N-u9EF4YgCbKZ2cc-xnG9UASYj7hfZSRPiyO2v60LoKcj14aHW2984HavgRqDkgGiUNJ_kISLxE1SbIZkWBxzl_BijHnmrctdwTmfhvmQVybvnZm9wxVYywb1Y2TT1RvJ6Pb10aaShWBh8jVknW4qVkm8u2ii5V48Ecb3rh1UOlw7YV6i-ecbzbHZ8wWZj3xCtz9Dc9raNunwWNZwW-5BDxUSUSFmcaUTo-oH1hWSgESYKwzh4bmqXuhktDW5q-KBZ1YoZzTjcTZQIDAQAB" +
         "&X-X-kid=|ID|3|" +
         "&X-appid=crVi-1DkV2Q" +
         "&X-scope=GCM" +
         "&X-subscription=841415684880" +
         "&X-app_ver_name=4.13.1" +
         "&app=com.vkontakte.android" +
         "&sender=841415684880" +
         "&device=3781894437258746134" +
         "&cert=48761eef50ee53afc4cc9c5f10e6bde7f8f5b82f" +
         "&app_ver=1206" +
         "&info=E-ByMiZUlJkfUO6eTSP7b7XIcAEcFBY" +
         "&gcm_ver=11975940";



        /// <summary>
        /// Обход ограничений на закрытое API
        /// </summary>
        /// <returns></returns>
        public async Task<string> refreshToken()
        {
            using (WebClient web = new WebClient())
            {
                web.Headers.Add("Authorization", "AidLogin 3781894437258746134:780828568266626499");
                web.Headers.Add("app", "com.vkontakte.android");
                web.Headers.Add("Gcm-ver", "11975940");
                web.Headers.Add("Gcm-cert", "48761eef50ee53afc4cc9c5f10e6bde7f8f5b82f");
                web.Headers.Add("User-Agent", "Android-GCM/1.5");
                web.Headers.Add("content-type", "application/x-www-form-urlencoded");

                string receipt = (await web.UploadStringTaskAsync("https://android.clients.google.com/c2dm/register3", GOOGLE_PARAMS)).Substring(13);

                web.Headers.Clear();

                var values = new NameValueCollection
                {
                    ["v"] = Net.API_VERSION,
                    ["receipt"] = receipt,
                    ["access_token"] = Data.access_token
                };

                web.Headers.Add("User-Agent", Net.USER_AGENT);

                var response = JsonConvert.DeserializeObject<dAuth.dRefreshToken>(Encoding.Default.GetString(await web.UploadValuesTaskAsync("https://api.vk.com/method/auth.refreshToken", values)));
                return response.response.token;
            }
        }
    }
}
