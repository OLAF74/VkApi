using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using VkApi.Models;
using System;
using VkApi.Methods;

namespace VkApi
{
    /// <summary>
    /// Работа непосредственно с сервером Вк
    /// </summary>
    public class Net
    {
        /// <summary>
        /// Версия API Вк
        /// </summary>
        public const string API_VERSION = "5.78";


        /// <summary>
        /// Id вашего приложения. 
        /// Сечас стоит id оффициального приложения Вк для Android
        /// </summary>
        public const string CLIENT_ID = "2274003";


        /// <summary>
        /// Secret вашего приложения. 
        /// Сечас стоит secret оффициального приложения Вк для Android
        /// </summary>
        public const string CLIENT_SECRET = "hHbZxrka2uZ6jB1inYsH";


        /// <summary>
        /// User-Agent необходимый для правильной работы обхода закрытого API
        /// </summary>
        public const string USER_AGENT = "VKAndroidApp/4.13.1-1206";


        /// <summary>
        /// Метод осуществляет запросы к серверу Вк
        /// </summary>
        /// <typeparam name="T">Класс, в который будет десереализирован ответ</typeparam>
        /// <param name="method">Название метода, к которому следует обратится</param>
        /// <param name="parameters">Коллекция параметров для запроса</param>
        /// <param name="access_token">Ваш access_token, если необходимо</param>
        /// <returns></returns>
        public static async Task<T> Request<T>(string method, NameValueCollection parameters = null, string access_token = null) where T : class
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    if (parameters is null)
                        parameters = new NameValueCollection();
                    if (access_token != null)
                        parameters["access_token"] = access_token;

                    parameters["v"] = API_VERSION;
                    parameters["lang"] = Thread.CurrentThread.CurrentUICulture.ToString();

                    web.Headers.Add("User-Agent", USER_AGENT);
                    string response = Encoding.UTF8.GetString(await web.UploadValuesTaskAsync($"https://api.vk.com/method/{method}", parameters));


                    //Console.WriteLine(response);


                    return JsonConvert.DeserializeObject<T>(response);
                }
                catch (WebException ex)
                {
                    using (Stream stream = ((HttpWebResponse)ex.Response).GetResponseStream())
                    {
                        string response = new StreamReader(stream, Encoding.UTF8).ReadToEnd();
                        return JsonConvert.DeserializeObject<T>(response);
                    }

                }
            }

        }


        /// <summary>
        /// [Системное] Метод для авторизации
        /// </summary>
        /// <param name="login">E-mail или номер телефона</param>
        /// <param name="password">Пароль</param>
        /// <param name="scope">Разрешения для приложения</param>
        /// <param name="captcha_key">Ввод пользователя</param>
        /// <param name="captcha_sid">captcha_sid который вернул сервер</param>
        /// <returns></returns>
        public static async Task<object> getToken(string login, string password, Scope scope = Scope.all, string captcha_key = null, string captcha_sid = null)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    webClient.Encoding = Encoding.UTF8;
                    webClient.BaseAddress = "https://oauth.vk.com/";
                    webClient.Headers.Add("user-agent", USER_AGENT);
                    webClient.QueryString.Add(new NameValueCollection()
                    {
                        ["grant_type"] = "password",
                        ["client_id"] = CLIENT_ID,
                        ["client_secret"] = CLIENT_SECRET,
                        ["username"] = WebUtility.UrlEncode(login),
                        ["password"] = WebUtility.UrlEncode(password),
                        ["scope"] = ((int)scope).ToString(),
                        ["v"] = API_VERSION,
                        ["2fa_supported"] = "0"
                    });


                    if (captcha_key != null & captcha_sid != null)
                    {
                        webClient.QueryString.Set("captcha_key", captcha_key);
                        webClient.QueryString.Set("captcha_sid", captcha_sid);
                    }

                    return JsonConvert.DeserializeObject<dAuthSuccess>(await webClient.DownloadStringTaskAsync("token"));
                }
            }
            catch (WebException ex)
            {
                using (Stream stream = ((HttpWebResponse)ex.Response).GetResponseStream())
                {
                    string response = new StreamReader(stream, Encoding.UTF8).ReadToEnd();
                    return JsonConvert.DeserializeObject<dAuthError>(response);
                }
            }

        }
    }
}
