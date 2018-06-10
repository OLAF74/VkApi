using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkApi.Models;
using VkApi.Exeptions;

namespace VkApi.Methods
{
    public class Account
    {
        private readonly string access_token;
        private readonly int user_id;
        private readonly int expires_in;

        public Account(Vk vk)
        {
            access_token = vk.getToken();
            user_id = vk.getUID();
            expires_in = vk.getTokenExpires();
        }


        /// <summary>
        /// Добавляет пользователя или группу в черный список.
        /// </summary>
        /// <param name="owner_id">идентификатор пользователя или сообщества, которое будет добавлено в черный список.</param>
        /// <returns>После успешного выполнения возвращает true.</returns>
        public async Task<bool> Ban(int owner_id)
        {
            var response = await Net.Request<dAccount.Ban>("account.ban", new System.Collections.Specialized.NameValueCollection
            {
                ["owner_id"] = owner_id.ToString()
            }, access_token);

            if (response.error.error_code != 0)//response.error.error_code == 15 | response.error.error_code == 100
                switch (response.error.error_code)
                {
                    case 15:
                        throw new AccountExeptions.UserAlreadyBlacklisted { error_code = response.error.error_code, error_description = response.error.error_msg };

                    default:
                        throw new AccountExeptions.UnknownAccountMethodError { error_code = response.error.error_code, error_description = response.error.error_msg };

                }
            return Convert.ToBoolean(response.response);
        }

        /// <summary>
        /// Удаляет пользователя или группу из черного списка.
        /// </summary>
        /// <param name="owner_id">идентификатор пользователя или группы, которого нужно удалить из черного списка.</param>
        /// <returns>После успешного выполнения возвращает true.</returns>
        public async Task<bool> Unban(int owner_id)
        {
            var response = await Net.Request<dAccount.Unban>("account.unban", new System.Collections.Specialized.NameValueCollection
            {
                ["owner_id"] = owner_id.ToString()
            }, access_token);

            if (response.error.error_code != 0)
                switch (response.error.error_code)
                {
                    case 15:
                        throw new AccountExeptions.UserAlreadyRemovedFromBlacklist { error_code = response.error.error_code, error_description = response.error.error_msg };

                    default:
                        throw new AccountExeptions.UnknownAccountMethodError { error_code = response.error.error_code, error_description = response.error.error_msg };

                }


            return Convert.ToBoolean(response.response);
        }

        /// <summary>
        /// Помечает текущего пользователя как offline (только в текущем приложении).
        /// </summary>
        /// <returns>После успешного выполнения возвращает true.</returns>
        public async Task<bool> SetOffline()
        {
            var response = await Net.Request<dAccount.SetOffline>("account.setOffline", access_token: access_token);

            return Convert.ToBoolean(response.response);
        }

        /// <summary>
        /// Помечает текущего пользователя как online на 5 минут.
        /// </summary>
        /// <returns>После успешного выполнения возвращает true.</returns>
        public async Task<bool> SetOnline()
        {
            var response = await Net.Request<dAccount.SetOnline>("account.setOnline", access_token: access_token);

            return Convert.ToBoolean(response.response);
        }


    }
}
