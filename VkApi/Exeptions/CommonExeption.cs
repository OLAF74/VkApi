using System;
using System.Runtime.Serialization;

namespace VkApi.Exeptions
{
    class CommonExeption
    {
        [Serializable()]
        public class CommonApiExeption : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            public CommonApiExeption() : base() { }
            public CommonApiExeption(string message) : base(message) { }
            public CommonApiExeption(string message, System.Exception inner) : base(message, inner) { }
            public CommonApiExeption(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public CommonApiExeption(string message, int error_code, string error_description) : base(message)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }
    }
}
