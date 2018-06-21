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
            });

            if (response.error != null)
                switch (response.error.error_code)
                {
                    case 15:
                        throw new AccountExeptions.UserAlreadyBlacklisted( response.error.error_code,  response.error.error_msg );

                    default:
                        throw new AccountExeptions.UnknownAccountMethodError ( response.error.error_code, response.error.error_msg );

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
            });

            if (response.error != null)
                switch (response.error.error_code)
                {
                    case 15:
                        throw new AccountExeptions.UserAlreadyRemovedFromBlacklist(response.error.error_code, response.error.error_msg);

                    default:
                        throw new AccountExeptions.UnknownAccountMethodError(response.error.error_code, response.error.error_msg);

                }


            return Convert.ToBoolean(response.response);
        }

        /// <summary>
        /// Помечает текущего пользователя как offline (только в текущем приложении).
        /// </summary>
        /// <returns>После успешного выполнения возвращает true.</returns>
        public async Task<bool> SetOffline()
        {
            var response = await Net.Request<dAccount.SetOffline>("account.setOffline");

            return Convert.ToBoolean(response.response);
        }

        /// <summary>
        /// Помечает текущего пользователя как online на 5 минут.
        /// </summary>
        /// <returns>После успешного выполнения возвращает true.</returns>
        public async Task<bool> SetOnline()
        {
            var response = await Net.Request<dAccount.SetOnline>("account.setOnline");

            return Convert.ToBoolean(response.response);
        }

        /// <summary>
        /// Позволяет сменить пароль пользователя после успешного восстановления доступа к аккаунту через СМС, используя метод Auth.Restore.
        /// </summary>
        /// <param name="restore_sid">Идентификатор сессии, полученный при восстановлении доступа используя метод auth.restore. (В случае если пароль меняется сразу после восстановления доступа)</param>
        /// <param name="change_password_hash">Хэш, полученный при успешной OAuth авторизации по коду полученному по СМС (В случае если пароль меняется сразу после восстановления доступа)</param>
        /// <param name="old_password">Текущий пароль пользователя.</param>
        /// <param name="new_password">Новый пароль, который будет установлен в качестве текущего. </param>
        /// <returns></returns>
        public async Task<dAccount.ChangePassword> ChangePassword(string restore_sid, string change_password_hash, string old_password, string new_password)
        {
            var response = await Net.Request<dAccount.ChangePassword>("account.changePassword", new System.Collections.Specialized.NameValueCollection
            {
                ["restore_sid"] = restore_sid,
                ["change_password_hash"] = change_password_hash,
                ["old_password"] = old_password,
                ["new_password"] = new_password
            });


            return null;
        }
    }
}
