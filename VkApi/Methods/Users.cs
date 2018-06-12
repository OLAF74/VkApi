using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkApi.Exeptions;
using VkApi.Models;

namespace VkApi.Methods
{
    public class Users
    {
        public async Task<dUsers.Get> Get(List<string> user_ids, string fields, string name_case)
        {
            if (user_ids is null)
                user_ids = new List<string>() { Data.user_id.ToString()};

            
            var response = await Net.Request<dUsers.Get>("users.get", new System.Collections.Specialized.NameValueCollection
            {
                ["user_ids"] = string.Join(",", user_ids),
                ["fields"] = fields,
                ["name_case"] = "nom"
            });

            if (response.error.error_code != 0)//response.error.error_code == 15 | response.error.error_code == 100
                throw new AccountExeptions.UserAlreadyRemovedFromBlacklist { error_code = response.error.error_code, error_description = response.error.error_msg };

            return response;
        }

    }
}
