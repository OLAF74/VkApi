#pragma warning disable IDE1006

namespace VkApi.Models
{
    class dAuthSuccess
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public int user_id { get; set; }
    }
}
