using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApi
{
    /// <summary>
    /// Хранилище различных даггых
    /// </summary>
    public class Data
    {
        /// <summary>
        /// Аключ доступа
        /// </summary>
        public static string access_token { get; private set; }

        /// <summary>
        /// id текущего пользователя
        /// </summary>
        public static int user_id { get; private set; }

        /// <summary>
        /// Срок действия ключа доступа
        /// </summary>
        public static int expires_in { get; private set; }

        /// <summary>
        /// Присваивает значение.
        /// </summary>
        public static void Set(string access_token, int user_id, int expires_in)
        {
            Data.access_token = access_token;
            Data.user_id = user_id;
            Data.expires_in = expires_in;
        }

    }
}
