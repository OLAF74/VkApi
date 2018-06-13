#pragma warning disable IDE1006, CS1591

namespace VkApi.Models
{
    public class dStatus
    {
        public class Get
        {
            public Response response { get; set; }
            public dApiError.Error error { get; set; }

            public class Response
            {
                public string text { get; set; }
                public Audio audio { get; set; }
            }

            public class Audio
            {
                public int id { get; set; }
                public int owner_id { get; set; }
                public string artist { get; set; }
                public string title { get; set; }
                public int duration { get; set; }
                public int date { get; set; }
                public string url { get; set; }
                public int lyrics_id { get; set; }
                public int genre_id { get; set; }
                public bool is_hq { get; set; }
            }
        }

        public class Set
        {
            public int response { get; set; }
            public dApiError.Error error { get; set; }
        }
    }
}
