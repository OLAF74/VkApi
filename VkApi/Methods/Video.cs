using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApi.Methods
{
    public class Video
    {
        private readonly string access_token;
        private readonly int user_id;
        private readonly int expires_in;

        public Video(Vk vk)
        {
            access_token = vk.getToken();
            user_id = vk.getUID();
            expires_in = vk.getTokenExpires();
        }
    }
}
