using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkApi.Models;

namespace VkApi.Methods
{
    public class Audio
    {
        private readonly string access_token;
        private readonly int user_id;
        private readonly int expires_in;

        public Audio(Vk vk)
        {
            access_token = vk.getToken();
            user_id = vk.getUID();
            expires_in = vk.getTokenExpires();
        }

      
    }
}
