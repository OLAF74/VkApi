using System;
using System.Runtime.Serialization;

#pragma warning disable IDE1006

namespace VkApi.Exeptions
{
    [Serializable()]
    public class CaptchaNeededExeption : Exception, ISerializable
    {
        public string captcha_sid { get; set; }
        public string captcha_img { get; set; }
        public string error { get; set; }

        protected CaptchaNeededExeption(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public CaptchaNeededExeption(string error, string captcha_sid, string captcha_img) : base(error)
        {
            this.captcha_sid = captcha_sid;
            this.captcha_img = captcha_img;
            this.error = error;
        }
    }
}
