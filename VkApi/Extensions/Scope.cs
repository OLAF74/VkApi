using System;
using System.Collections.Generic;

namespace VkApi
{
    /// <summary>
    /// Права доступа для приложения
    /// </summary>
    [Flags]
    public enum Scope
    {
        /// <summary>
        /// Предоставляет сразу все права доступа
        /// </summary>
        all = notify + friends + photos + audio + video + stories + pages + left_menu + status + notes + messages + wall + ads + offline + docs + groups + notifications + stats + email + market,

        //140492255
        /// <summary>
        /// Пользователь разрешил отправлять ему уведомления(для flash/iframe-приложений).
        /// </summary>
        notify = 1,

        /// <summary>
        /// Доступ к друзьям.
        /// </summary>
        friends = 2,

        /// <summary>
        /// Доступ к фотографиям.
        /// </summary>
        photos = 4,

        /// <summary>
        /// Доступ к аудиозаписям.
        /// </summary>
        audio = 8,

        /// <summary>
        /// Доступ к видеозаписям.
        /// </summary>
        video = 16,

        /// <summary>
        /// Доступ к историям.
        /// </summary>
        stories = 64,

        /// <summary>
        /// Доступ к wiki-страницам.
        /// </summary>
        pages = 128,

        /// <summary>
        /// Добавление ссылки на приложение в меню слева(на сайте).
        /// Актуально только для сайта, но вдруг это вам понадобится ;)
        /// </summary>
        [Obsolete]
        left_menu = 256,

        /// <summary>
        /// Доступ к статусу пользователя.
        /// </summary>
        status = 1024,

        /// <summary>
        /// Доступ к заметкам пользователя.
        /// </summary>
        notes = 2048,

        /// <summary>
        /// Доступ к расширенным методам работы с сообщениями.
        /// </summary>
        messages = 4096,

        /// <summary>
        /// Доступ к обычным и расширенным методам работы со стеной.
        /// </summary>
        wall = 8192,

        /// <summary>
        /// Доступ к расширенным методам работы с рекламным API.
        /// </summary>
        ads = 32768,

        /// <summary>
        /// Доступ к API в любое время.
        /// </summary>
        offline = 65536,

        /// <summary>
        /// Доступ к документам.
        /// </summary>
        docs = 131072,

        /// <summary>
        /// Доступ к группам пользователя.
        /// </summary>
        groups = 262144,

        /// <summary>
        /// Доступ к оповещениям об ответах пользователю.
        /// </summary>
        notifications = 524288,

        /// <summary>
        /// Доступ к статистике групп и приложений пользователя, администратором которых он является.
        /// </summary>
        stats = 1048576,

        /// <summary>
        /// Доступ к email пользователя.
        /// </summary>
        email = 4194304,

        /// <summary>
        /// Доступ к товарам.
        /// </summary>
        market = 134217728
    }


    public static class EnumExtensions
    {
        /// <summary>
        /// Возвращает флаги досутпа приложения из битовой маски. Пример использования: ((Scope)3).GetFlags()
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static IEnumerable<Enum> GetFlags(this Enum input)
        {
            foreach (Enum value in Enum.GetValues(input.GetType()))
                if (input.HasFlag(value))
                    yield return value;
        }
    }

   
}