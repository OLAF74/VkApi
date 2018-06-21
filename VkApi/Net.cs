using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using VkApi.Models;
using System;
using VkApi.Exeptions;
using System.Linq;

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
        public const string API_VERSION = "5.80";

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
        /// <returns></returns>
        public static async Task<T> Request<T>(string method, NameValueCollection parameters = null) where T : class
        {
            string response = string.Empty;

            using (WebClient web = new WebClient())
            {
                try
                {
                    if (parameters is null)
                        parameters = new NameValueCollection();

                    Log.Append(string.Format("REQUEST:::method: '{0}' parameters: '{1}'", method, string.Join(",", parameters.AllKeys.Select(key => string.Format("{0}={1}", key, parameters[key])))));

                    if (Data.access_token != null)
                        parameters["access_token"] = Data.access_token;


                    parameters["v"] = API_VERSION;
                    parameters["lang"] = Thread.CurrentThread.CurrentUICulture.ToString();

                    web.Headers.Add("User-Agent", USER_AGENT);

                    response = Encoding.UTF8.GetString(await web.UploadValuesTaskAsync($"https://api.vk.com/method/{method}", parameters));


                }
                catch (WebException ex)
                {
                    using (Stream stream = ((HttpWebResponse)ex.Response).GetResponseStream())
                        response = new StreamReader(stream, Encoding.UTF8).ReadToEnd();


                }
            }

            dynamic responseClass = JsonConvert.DeserializeObject<T>(response);

            if (responseClass.error != null)
            {
                Log.Append(string.Format("REQUEST:::ERROR   method: '{0}'  error_code: '{1}'  error_description: '{2}'", method, responseClass.error.error_code, responseClass.error.error_msg));

                switch (responseClass.error.error_code)
                {
                    case 1:
                        throw new CommonExeptions.UnknownApiError(responseClass.error.error_code, responseClass.error.error_msg);
                    case 2:
                        throw new CommonExeptions.AppDisabled(responseClass.error.error_code, responseClass.error.error_msg);
                    case 3:
                        throw new CommonExeptions.UnknownMethod(responseClass.error.error_code, responseClass.error.error_msg);
                    case 4:
                        throw new CommonExeptions.WrongSignature(responseClass.error.error_code, responseClass.error.error_msg);
                    case 5:
                        throw new CommonExeptions.AuthError(responseClass.error.error_code, responseClass.error.error_msg);
                    case 6:
                        throw new CommonExeptions.TooMuchRequests(responseClass.error.error_code, responseClass.error.error_msg);
                    case 7:
                        throw new CommonExeptions.NoPermissionsToPerformThisAction(responseClass.error.error_code, responseClass.error.error_msg);
                    case 8:
                        throw new CommonExeptions.InvalidRequest(responseClass.error.error_code, responseClass.error.error_msg);
                    case 9:
                        throw new CommonExeptions.TooManySimilarActions(responseClass.error.error_code, responseClass.error.error_msg);
                    case 10:
                        throw new CommonExeptions.InternalServerError(responseClass.error.error_code, responseClass.error.error_msg);
                    case 11:
                        throw new CommonExeptions.TestModeAppEnabled(responseClass.error.error_code, responseClass.error.error_msg);
                    case 14:
                        throw new CommonExeptions.CaptchaNeeded(responseClass.error.error_code, responseClass.error.error_msg);
                    case 15:
                        throw new CommonExeptions.AccessDenied(responseClass.error.error_code, responseClass.error.error_msg);
                    case 16:
                        throw new CommonExeptions.OnlyHTTPSAllowed(responseClass.error.error_code, responseClass.error.error_msg);
                    case 17:
                        throw new CommonExeptions.ValidationNeeded(responseClass.error.error_code, responseClass.error.error_msg);
                    case 18:
                        throw new CommonExeptions.PageDeletedOrBanned(responseClass.error.error_code, responseClass.error.error_msg);
                    case 20:
                        throw new CommonExeptions.ProhibitedForNonStandaloneApp(responseClass.error.error_code, responseClass.error.error_msg);
                    case 21:
                        throw new CommonExeptions.OnlyForStandaloneApp(responseClass.error.error_code, responseClass.error.error_msg);
                    case 23:
                        throw new CommonExeptions.MethodDisabled(responseClass.error.error_code, responseClass.error.error_msg);
                    case 24:
                        throw new CommonExeptions.ConfirmationRequired(responseClass.error.error_code, responseClass.error.error_msg);
                    case 27:
                        throw new CommonExeptions.CommunityAccessKeyInvalid(responseClass.error.error_code, responseClass.error.error_msg);
                    case 28:
                        throw new CommonExeptions.ApplicationAccessKeyInvalid(responseClass.error.error_code, responseClass.error.error_msg);
                    case 29:
                        throw new CommonExeptions.MethodInvocationLimitReached(responseClass.error.error_code, responseClass.error.error_msg);
                    case 100:
                        throw new CommonExeptions.ParameterMissedOrIncorrect(responseClass.error.error_code, responseClass.error.error_msg);
                    case 101:
                        throw new CommonExeptions.InvalidAppID(responseClass.error.error_code, responseClass.error.error_msg);
                    case 113:
                        throw new CommonExeptions.InvalidUserId(responseClass.error.error_code, responseClass.error.error_msg);
                    case 150:
                        throw new CommonExeptions.InvalidTimestamp(responseClass.error.error_code, responseClass.error.error_msg);
                    case 200:
                        throw new CommonExeptions.AlbumAccessDenied(responseClass.error.error_code, responseClass.error.error_msg);
                    case 201:
                        throw new CommonExeptions.AudioAccessDenied(responseClass.error.error_code, responseClass.error.error_msg);
                    case 203:
                        throw new CommonExeptions.GroupAccessDenied(responseClass.error.error_code, responseClass.error.error_msg);
                    case 300:
                        throw new CommonExeptions.AlbumIsFull(responseClass.error.error_code, responseClass.error.error_msg); ;
                    case 500:
                        throw new CommonExeptions.VoiceTranslationsDisabled(responseClass.error.error_code, responseClass.error.error_msg);
                    case 600:
                        throw new CommonExeptions.AdvertisingCabinetAccessDenied(responseClass.error.error_code, responseClass.error.error_msg);
                    case 603:
                        throw new CommonExeptions.AdvertisingCabinetErrorOccurred(responseClass.error.error_code, responseClass.error.error_msg);
                }
            }
            else
                Log.Append("REQUEST:::OK");
            return responseClass;
        }

        [Obsolete("DEBUG ONLY")]
        public static async Task<string> Request(string method, NameValueCollection parameters = null)
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    if (parameters is null)
                        parameters = new NameValueCollection();

                    parameters["access_token"] = Data.access_token;
                    parameters["v"] = API_VERSION;
                    parameters["lang"] = Thread.CurrentThread.CurrentUICulture.ToString();

                    web.Headers.Add("User-Agent", USER_AGENT);
                    string response = Encoding.UTF8.GetString(await web.UploadValuesTaskAsync($"https://api.vk.com/method/{method}", parameters));


                    //Console.WriteLine(response);


                    return response;
                }
                catch (WebException ex)
                {
                    using (Stream stream = ((HttpWebResponse)ex.Response).GetResponseStream())
                    {
                        string response = new StreamReader(stream, Encoding.UTF8).ReadToEnd();
                        return response;
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
        public static async Task<dAuth.Authorize> getToken(string login, string password, Scope scope = Scope.all, string captcha_key = null, string captcha_sid = null)
        {
            string response = string.Empty;

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


                    Log.Append("REQUEST:::getToken");

                    response = await webClient.DownloadStringTaskAsync("token");
                }
            }
            catch (WebException ex)
            {
                using (Stream stream = ((HttpWebResponse)ex.Response).GetResponseStream())
                    response = new StreamReader(stream, Encoding.UTF8).ReadToEnd();
            }

            return JsonConvert.DeserializeObject<dAuth.Authorize>(response);
        }
    }
}
