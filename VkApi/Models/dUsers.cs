using System;
using System.Collections.Generic;

#pragma warning disable IDE1006, CS1591


namespace VkApi.Models
{

    public class dUsers
    {

        public class Get
        {
            public List<Response> response { get; set; }
            public dApiError.Error error { get; set; }

            public class City
            {
                public int id { get; set; }
                public string title { get; set; }
            }

            public class Country
            {
                public int id { get; set; }
                public string title { get; set; }
            }

            public class LastSeen
            {
                public int time { get; set; }
                public int platform { get; set; }
            }

            public class Photo
            {
                public int id { get; set; }
                public int album_id { get; set; }
                public int owner_id { get; set; }
                public string photo_75 { get; set; }
                public string photo_130 { get; set; }
                public string photo_604 { get; set; }
                public string photo_807 { get; set; }
                public int width { get; set; }
                public int height { get; set; }
                public string text { get; set; }
                public int date { get; set; }
                public int post_id { get; set; }
            }

            public class Crop
            {
                public double x { get; set; }
                public double y { get; set; }
                public double x2 { get; set; }
                public double y2 { get; set; }
            }

            public class Rect
            {
                public double x { get; set; }
                public double y { get; set; }
                public double x2 { get; set; }
                public double y2 { get; set; }
            }

            public class CropPhoto
            {
                public Photo photo { get; set; }
                public Crop crop { get; set; }
                public Rect rect { get; set; }
            }

            public class Occupation
            {
                public string type { get; set; }
                public double id { get; set; }
                public string name { get; set; }
            }

            public class Personal
            {
                public List<string> langs { get; set; }
                public int people_main { get; set; }
            }

            public class School
            {
                public string id { get; set; }
                public int country { get; set; }
                public int city { get; set; }
                public string name { get; set; }
                public string @class { get; set; }
            }

            public class Response
            {
                public int id { get; set; }
                public string first_name { get; set; }
                public string last_name { get; set; }
                public int sex { get; set; }
                public string nickname { get; set; }
                public string domain { get; set; }
                public string screen_name { get; set; }
                public string bdate { get; set; }
                public City city { get; set; }
                public Country country { get; set; }
                public int timezone { get; set; }
                public string photo_50 { get; set; }
                public string photo_100 { get; set; }
                public string photo_200 { get; set; }
                public string photo_max { get; set; }
                public string photo_200_orig { get; set; }
                public string photo_max_orig { get; set; }
                public string photo_id { get; set; }
                public int has_photo { get; set; }
                public int has_mobile { get; set; }
                public int is_friend { get; set; }
                public int friend_status { get; set; }
                public int online { get; set; }
                public int wall_comments { get; set; }
                public int can_post { get; set; }
                public int can_see_all_posts { get; set; }
                public int can_see_audio { get; set; }
                public int can_write_private_message { get; set; }
                public int can_send_friend_request { get; set; }
                public string mobile_phone { get; set; }
                public string home_phone { get; set; }
                public string site { get; set; }
                public string status { get; set; }
                public LastSeen last_seen { get; set; }
                public CropPhoto crop_photo { get; set; }
                public int verified { get; set; }
                public int followers_count { get; set; }
                public int blacklisted { get; set; }
                public int blacklisted_by_me { get; set; }
                public int is_favorite { get; set; }
                public int is_hidden_from_feed { get; set; }
                public int common_count { get; set; }
                public Occupation occupation { get; set; }
                public List<object> career { get; set; }
                public List<object> military { get; set; }
                public int university { get; set; }
                public string university_name { get; set; }
                public int faculty { get; set; }
                public string faculty_name { get; set; }
                public int graduation { get; set; }
                public string home_town { get; set; }
                public int relation { get; set; }
                public Personal personal { get; set; }
                public string interests { get; set; }
                public string music { get; set; }
                public string activities { get; set; }
                public string movies { get; set; }
                public string tv { get; set; }
                public string books { get; set; }
                public string games { get; set; }
                public List<object> universities { get; set; }
                public List<School> schools { get; set; }
                public string about { get; set; }
                public List<object> relatives { get; set; }
                public string quotes { get; set; }
            }
        }







    }
}
