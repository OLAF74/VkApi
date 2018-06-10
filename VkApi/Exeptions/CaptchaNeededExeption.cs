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


        public CaptchaNeededExeption() : base() { }
        public CaptchaNeededExeption(string message) : base(message) { }
        public CaptchaNeededExeption(string message, System.Exception inner) : base(message, inner) { }
        public CaptchaNeededExeption(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public CaptchaNeededExeption(string message, string captcha_sid, string captcha_img) : base(message)
        {
            this.captcha_sid = captcha_sid;
            this.captcha_img = captcha_img;
        }
    }
}
