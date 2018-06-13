using System;
using System.Threading.Tasks;
using VkApi.Exeptions;
using VkApi.Models;

namespace VkApi.Methods
{
    /// <summary>
    /// Методы для работы со статусом. 
    /// </summary>
    public class Status
    {
        /// <summary>
        /// Получает текст статуса пользователя или сообщества.
        /// </summary>
        /// <param name="user_id">Идентификатор пользователя или сообщества, информацию о статусе которого нужно получить.</param>
        /// <param name="group_id">Идентификатор сообщества, статус которого необходимо получить.</param>
        /// <returns>
        /// В случае успеха возвращает объект, у которого в поле text содержится текст статуса пользователя или сообщества. 
        /// Если у пользователя включена трансляция играющей музыки в статус и в данный момент воспроизводится аудиозапись, то также будет возвращен объект audio.
        /// </returns>
        public async Task<dStatus.Get> Get(int user_id = 0, int group_id = 0)
        {
            var response = await Net.Request<dStatus.Get>("status.get", new System.Collections.Specialized.NameValueCollection
            {
                ["user_id"] = user_id.ToString(),
                ["group_id"] = group_id.ToString()
            });

            if (response.error != null)
                throw new CommonExeption.CommonApiExeption { error_code = response.error.error_code, error_description = response.error.error_msg };

            return response;
        }

        /// <summary>
        /// Устанавливает новый статус текущему пользователю или сообществу.
        /// </summary>
        /// <param name="text">Текст нового статуса.</param>
        /// <param name="group_id">Идентификатор сообщества, в котором будет установлен статус. По умолчанию статус устанавливается текущему пользователю.</param>
        /// <returns>В случае успешной установки или очистки статуса возвращает true.</returns>
        public async Task<bool> Set(string text, int group_id = 0)
        {
            var response = await Net.Request<dStatus.Set>("status.set", new System.Collections.Specialized.NameValueCollection
            {
                ["text"] = text,
                ["group_id"] = group_id.ToString()
            });

            if (response.error != null)
            {
                switch (response.error.error_code)
                {
                    case 221:
                        throw new StatusExeptions.AudioToStatusDisabled { error_code = response.error.error_code, error_description = response.error.error_msg };

                    default:
                        throw new CommonExeption.CommonApiExeption { error_code = response.error.error_code, error_description = response.error.error_msg };
                }
            }

            return Convert.ToBoolean(response.response);
        }
    }
}
