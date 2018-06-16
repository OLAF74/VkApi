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
                switch (responseClass.error.error_code)
                {
                    case 1:
                        throw new CommonExeptions.UnknownApiExeption();
                    case 2:
                        throw new CommonExeptions.AppDisabled();
                    case 3:
                        throw new CommonExeptions.UnknownMethod();
                    case 4:
                        throw new CommonExeptions.WrongSignature();
                    case 5:
                        throw new CommonExeptions.AuthError();
                    case 6:
                        throw new CommonExeptions.TooMuchRequests();
                    case 7:
                        throw new CommonExeptions.NoPermissionsToPerformThisAction();
                    case 8:
                        throw new CommonExeptions.InvalidRequest();
                    case 9:
                        throw new CommonExeptions.TooManySimilarActions();
                    case 10:
                        throw new CommonExeptions.InternalServerError();
                    case 11:
                        throw new CommonExeptions.TestModeAppEnabled();
                    case 14:
                        throw new CommonExeptions.CaptchaNeeded();
                    case 15:
                        throw new CommonExeptions.AccessDenied();
                    case 16:
                        throw new CommonExeptions.OnlyHTTPSAllowed();
                    case 17:
                        throw new CommonExeptions.ValidationNeeded();
                    case 18:
                        throw new CommonExeptions.PageDeletedOrBanned();
                    case 20:
                        throw new CommonExeptions.ProhibitedForNonStandaloneApp();
                    case 21:
                        throw new CommonExeptions.OnlyForStandaloneApp();
                    case 23:
                        throw new CommonExeptions.MethodDisabled();
                    case 24:
                        throw new CommonExeptions.ConfirmationRequired();
                    case 27:
                        throw new CommonExeptions.CommunityAccessKeyInvalid();
                    case 28:
                        throw new CommonExeptions.ApplicationAccessKeyInvalid();
                    case 29:
                        throw new CommonExeptions.MethodInvocationLimitReached();
                    case 100:
                        throw new CommonExeptions.ParameterMissedOrIncorrect();
                    case 101:
                        throw new CommonExeptions.InvalidAppID();
                    case 113:
                        throw new CommonExeptions.InvalidUserId();
                    case 150:
                        throw new CommonExeptions.InvalidTimestamp();
                    case 200:
                        throw new CommonExeptions.AlbumAccessDenied();
                    case 201:
                        throw new CommonExeptions.AudioAccessDenied();
                    case 203:
                        throw new CommonExeptions.GroupAccessDenied();
                    case 300:
                        throw new CommonExeptions.AlbumIsFull();
                    case 500:
                        throw new CommonExeptions.VoiceTranslationsDisabled();
                    case 600:
                        throw new CommonExeptions.AdvertisingCabinetAccessDenied();
                    case 603:
                        throw new CommonExeptions.AdvertisingCabinetErrorOccurred();
                }
            }

            return responseClass;
        }


        /// <summary>
        /// Метод осуществляет запросы к серверу Вк. Возвращает строку ответа для дальнейшего создания класса объекта.
        /// </summary>
        /// <param name="method">Название метода, к которому следует обратится</param>
        /// <param name="parameters">Коллекция параметров для запроса</param>
        /// <returns></returns>
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
