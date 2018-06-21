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
        /// <summary>
        /// Инициализирует библиотеку.
        /// </summary>
        public Vk()
        {
            Initialization();
        }

        /// <summary>
        /// Инициализирует библиотеку с помощью access_token
        /// </summary>
        /// <param name="access_token"></param>
        public Vk(string access_token)
        {
            Data.Set(access_token, 0, 0);
            Initialization();
        }

        private void Initialization()
        {
            Account = new Account();
            Ads = new Ads();
            Apps = new Apps();
            AppWidgets = new AppWidgets();
            Audio = new Audio();
            Auth = new Auth();
            Board = new Board();
            Database = new Database();
            Docs = new Docs();
            Fave = new Fave();
            Friends = new Friends();
            Gifts = new Gifts();
            Groups = new Groups();
            Likes = new Likes();
            Market = new Market();
            Messages = new Messages();
            Newsfeed = new Newsfeed();
            Notes = new Notes();
            Notifications = new Notifications();
            Other = new Other();
            Pages = new Pages();
            Photos = new Photos();
            Places = new Places();
            Polls = new Polls();
            Search = new Search();
            Stats = new Stats();
            Status = new Status();
            Storage = new Storage();
            Stories = new Stories();
            Streaming = new Streaming();
            Users = new Users();
            Utils = new Utils();
            Video = new Video();
            Wall = new Wall();
            Widgets = new Widgets();
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
