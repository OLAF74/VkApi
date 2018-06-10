using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VkApi.Exeptions;
using VkApi.Methods;
using VkApi.Models;

namespace VkApi
{
    /// <summary>
    /// Обертка для работы с API
    /// </summary>
    public class Vk
    {
        private readonly string access_token;
        private readonly int user_id;
        private readonly int expires_in;

        /// <summary>
        /// Инициализирует библиотеку с помощью логина и пароля
        /// </summary>
        /// <param name="login">E-mail или номер телефона</param>
        /// <param name="password">Пароль</param>
        /// <param name="scope">Разрешения для приложения</param>
        public Vk(string login, string password, Auth.Scope scope = Auth.Scope.all)
        {
            var Task = Net.getToken(login, password, scope);
            Task.Wait();
            object response = Task.Result;

            switch (response)
            {
                case dAuthError err:
                    switch (err.error)
                    {
                        case "need_captcha":
                            throw new CaptchaNeededExeption { captcha_img = err.captcha_img, captcha_sid = err.captcha_sid };
                        case "invalid_client":
                            throw new InvalidClientExeption { error = err.error, error_description = err.error_description };
                        case "need_validation":
                            throw new ValidationNeededExeption { validation_type = err.validation_type, phone_mask = err.phone_mask };
                    }
                    break;
                case dAuthSuccess suc:
                    access_token = suc.access_token;
                    user_id = suc.user_id;
                    expires_in = suc.expires_in;
                    Initialization();
                    break;
            }
        }


        /// <summary>
        /// Инициализирует библиотеку с помощью логина и пароля
        /// Используется, если нужно подтвердить каптчу
        /// </summary>
        /// <param name="login">E-mail или номер телефона</param>
        /// <param name="password">Пароль</param>
        /// <param name="scope">Разрешения для приложения</param>
        /// <param name="captcha_key">Текст, который ввел пользователь</param>
        /// <param name="captcha_sid">Полученный идентификатор</param>
        public Vk(string login, string password, string captcha_key, string captcha_sid, Auth.Scope scope = Auth.Scope.all)
        {
            var Task = Net.getToken(login, password, scope, captcha_key, captcha_sid);
            Task.Wait();
            object response = Task.Result;

            switch (response)
            {
                case dAuthError err:
                    switch (err.error)
                    {
                        case "need_captcha":
                            throw new CaptchaNeededExeption { captcha_img = err.captcha_img, captcha_sid = err.captcha_sid };
                        case "invalid_client":
                            throw new InvalidClientExeption { error = err.error, error_description = err.error_description };
                        case "need_validation":
                            throw new ValidationNeededExeption { validation_type = err.validation_type, phone_mask = err.phone_mask };
                    }
                    break;
                case dAuthSuccess suc:
                    access_token = suc.access_token;
                    user_id = suc.user_id;
                    expires_in = suc.expires_in;
                    Initialization();
                    break;
            }
        }


        /// <summary>
        /// Инициализирует библиотеку с помощью access_token
        /// </summary>
        /// <param name="access_token"></param>
        public Vk(string access_token)
        {
            this.access_token = access_token;
            Initialization();
        }


        private void Initialization()
        {
            Account = new Account(this);
            Ads = new Ads(this);
            Apps = new Apps(this);
            AppWidgets = new AppWidgets(this);
            Audio = new Audio(this);
            Auth = new Auth(this);
            Board = new Board(this);
            Database = new Database(this);
            Docs = new Docs(this);
            Fave = new Fave(this);
            Friends = new Friends(this);
            Gifts = new Gifts(this);
            Groups = new Groups(this);
            Likes = new Likes(this);
            Market = new Market(this);
            Messages = new Messages(this);
            Newsfeed = new Newsfeed(this);
            Notes = new Notes(this);
            Notifications = new Notifications(this);
            Other = new Other(this);
            Pages = new Pages(this);
            Photos = new Photos(this);
            Places = new Places(this);
            Polls = new Polls(this);
            Search = new Search(this);
            Stats = new Stats(this);
            Status = new Status(this);
            Storage = new Storage(this);
            Stories = new Stories(this);
            Streaming = new Streaming(this);
            Users = new Users(this);
            Utils = new Utils(this);
            Video = new Video(this);
            Wall = new Wall(this);
            Widgets = new Widgets(this);
        }


        /// <summary>
        /// Возвращает access_token
        /// </summary>
        /// <returns></returns>
        public string getToken()
        {
            return access_token;
        }


        /// <summary>
        /// Возвращает user_id
        /// </summary>
        /// <returns></returns>
        public int getUID()
        {
            return user_id;
        }


        /// <summary>
        /// Возвращает expires_in
        /// </summary>
        /// <returns></returns>
        public int getTokenExpires()
        {
            return expires_in;
        }

        /// <summary>
        /// Методы для работы с аккаунтом.
        /// </summary>
        public Account Account { get; private set; }

        /// <summary>
        /// API для работы с рекламным кабинетом.
        /// </summary>
        public Ads Ads { get; private set; }

        /// <summary>
        /// Методы для работы с приложениями.
        /// </summary>
        public Apps Apps { get; private set; }

        /// <summary>
        /// Методы для работы с виджетами в приложениях.(?)
        /// </summary>
        public AppWidgets AppWidgets { get; private set; }

        /// <summary>
        /// Методы для работы с аудиозаписями. 
        /// </summary>
        public Audio Audio { get; private set; }

        /// <summary>
        /// Методы для работы с авторизацией. 
        /// </summary>
        public Auth Auth { get; private set; }

        /// <summary>
        /// Методы для работы с обсуждениями. 
        /// </summary>
        public Board Board { get; private set; }

        /// <summary>
        /// Методы для работы с базой данных учебных заведений. 
        /// </summary>
        public Database Database { get; private set; }

        /// <summary>
        /// Методы для работы с документами. 
        /// </summary>
        public Docs Docs { get; private set; }

        /// <summary>
        /// Методы для работы с закладками. 
        /// </summary>
        public Fave Fave { get; private set; }

        /// <summary>
        /// Методы для работы с друзьями. 
        /// </summary>
        public Friends Friends { get; private set; }

        /// <summary>
        /// Методы для работы с подарками. 
        /// </summary>
        public Gifts Gifts { get; private set; }

        /// <summary>
        /// Методы для работы с группами. 
        /// </summary>
        public Groups Groups { get; private set; }

        /// <summary>
        /// Методы для работы с отметками «Мне нравится». 
        /// </summary>
        public Likes Likes { get; private set; }

        /// <summary>
        /// Методы для работы с с товарами в сообществах. 
        /// </summary>
        public Market Market { get; private set; }

        /// <summary>
        /// Методы для работы с личными сообщениями. 
        /// </summary>
        public Messages Messages { get; private set; }

        /// <summary>
        /// Методы для работы с новостной лентой пользователя. 
        /// </summary>
        public Newsfeed Newsfeed { get; private set; }

        /// <summary>
        /// Методы для работы с заметками.
        /// </summary>
        public Notes Notes { get; private set; }

        /// <summary>
        /// Методы для работы с уведомлениями
        /// </summary>
        public Notifications Notifications { get; private set; }

        /// <summary>
        /// Различные методы 
        /// </summary>
        public Other Other { get; private set; }

        /// <summary>
        /// Методы для работы с вики-страницами. 
        /// </summary>
        public Pages Pages { get; private set; }

        /// <summary>
        /// Методы для работы с фотографиями. 
        /// </summary>
        public Photos Photos { get; private set; }

        /// <summary>
        /// Методы для работы с местами. 
        /// </summary>
        public Places Places { get; private set; }

        /// <summary>
        /// Методы для работы с опросами. 
        /// </summary>
        public Polls Polls { get; private set; }

        /// <summary>
        /// Методы для работы с поиском. 
        /// </summary>
        public Search Search { get; private set; }

        /// <summary>
        /// Методы для работы с авторизацией. 
        /// </summary>
        public Stats Stats { get; private set; }

        /// <summary>
        /// Методы для работы со статистикой. 
        /// </summary>
        public Status Status { get; private set; }

        /// <summary>
        /// Методы для работы с переменными в приложении. 
        /// </summary>
        public Storage Storage { get; private set; }

        /// <summary>
        /// Методы для работы с историями. 
        /// </summary>
        public Stories Stories { get; private set; }

        /// <summary>
        /// Методы для работы со Stream API. 
        /// </summary>
        public Streaming Streaming { get; private set; }

        /// <summary>
        /// Методы для работы с пользователями. 
        /// </summary>
        public Users Users { get; private set; }

        /// <summary>
        /// Служебные методы.
        /// </summary>
        public Utils Utils { get; private set; }

        /// <summary>
        /// Методы для работы с видео. 
        /// </summary>
        public Video Video { get; private set; }

        /// <summary>
        /// Методы для работы с записями на стене.
        /// </summary>
        public Wall Wall { get; private set; }

        /// <summary>
        /// Методы для работы с виджетами на внешних сайтах.
        /// </summary>
        public Widgets Widgets { get; private set; }

    }
}
