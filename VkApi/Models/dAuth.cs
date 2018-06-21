using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApi.Models
{
    public class dAuth
    {

        public class dRefreshToken
        {
            public Response response { get; set; }

            public class Response
            {
                public string token { get; set; }
            }
        }


        public class Authorize
        {
            public string access_token { get; set; }
            public int expires_in { get; set; }
            public int user_id { get; set; }

            public string error { get; set; }
            public string captcha_sid { get; set; }
            public string error_description { get; set; }
            public string captcha_img { get; set; }
            public string redirect_uri { get; set; }
            public string validation_type { get; set; }
            public string phone_mask { get; set; }
        }

        public class CheckPhone
        {
            public int response { get; set; }
            public dApiError.Error error { get; set; }
        }


    }
}
