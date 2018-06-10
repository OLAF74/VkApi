using System.Collections.Generic;

#pragma warning disable IDE1006, CS1591

namespace VkApi.Models
{
   public class dApiError
    {
        public Error error { get; set; }
        public class RequestParam
        {
            public string key { get; set; }
            public string value { get; set; }
        }

        public class Error
        {
            public int error_code { get; set; }
            public string error_msg { get; set; }
            public List<RequestParam> request_params { get; set; }
        }
    }
}
