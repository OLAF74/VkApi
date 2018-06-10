#pragma warning disable IDE1006

namespace VkApi.Models
{
    class dAuthError
    {
        public string error { get; set; }
        public string captcha_sid { get; set; }
        public string error_description { get; set; }
        public string captcha_img { get; set; }
        public string redirect_uri { get; set; }
        public string validation_type { get; set; }
        public string phone_mask { get; set; }
    }
}
