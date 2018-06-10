using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApi.Models
{
    class dAuth
    {

        public class dRefreshToken
        {
            public Response response { get; set; }

            public class Response
            {
                public string token { get; set; }
            }
        }




    }
}
