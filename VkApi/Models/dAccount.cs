using System.Collections.Generic;

#pragma warning disable IDE1006, CS1591

namespace VkApi.Models
{
    public class dAccount
    {
        public class Ban
        {
            public int response { get; set; }
            public dApiError.Error error { get; set; }
        }

        public class Unban
        {
            public int response { get; set; }
            public dApiError.Error error { get; set; }
        }

        public class SetOffline
        {
            public int response { get; set; }
            public dApiError.Error error { get; set; }
        }

        public class SetOnline
        {
            public int response { get; set; }
            public dApiError.Error error { get; set; }
        }

        public class ChangePassword
        {
            public Response response { get; set; }

            public class Response
            {
                public string token { get; set; }
            }
        }

    }
}
