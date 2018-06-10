using System.Collections.Generic;


#pragma warning disable IDE1006


namespace VkApi.Models
{
   public class dAudio
    {

        public class Get
        {
            public Response response { get; set; }
            public dApiError.Error error { get; set; }

            public class Thumb
            {
                public string photo_34 { get; set; }
                public string photo_68 { get; set; }
                public string photo_135 { get; set; }
                public string photo_270 { get; set; }
                public string photo_300 { get; set; }
                public string photo_600 { get; set; }
                public int width { get; set; }
                public int height { get; set; }
            }

            public class Album
            {
                public int id { get; set; }
                public int owner_id { get; set; }
                public string title { get; set; }
                public string access_key { get; set; }
                public Thumb thumb { get; set; }
            }

            public class Item
            {
                public int id { get; set; }
                public int owner_id { get; set; }
                public string artist { get; set; }
                public string title { get; set; }
                public int duration { get; set; }
                public int date { get; set; }
                public string url { get; set; }
                public int genre_id { get; set; }
                public bool is_licensed { get; set; }
                public bool is_hq { get; set; }
                public int track_genre_id { get; set; }
                public string access_key { get; set; }
                public Album album { get; set; }
                public int? lyrics_id { get; set; }
                public int? content_restricted { get; set; }
                public int? no_search { get; set; }
            }

            public class Response
            {
                public int count { get; set; }
                public List<Item> items { get; set; }
            }

     
              
        }


    }
}
