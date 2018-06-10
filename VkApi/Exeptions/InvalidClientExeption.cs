using System;
using System.Runtime.Serialization;

#pragma warning disable IDE1006

namespace VkApi.Exeptions
{
    [Serializable()]
    public class InvalidClientExeption : Exception, ISerializable
    {
        public string error { get; set; }
        public string error_description { get; set; }


        public InvalidClientExeption() : base() { }
        public InvalidClientExeption(string message) : base(message) { }
        public InvalidClientExeption(string message, System.Exception inner) : base(message, inner) { }
        public InvalidClientExeption(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public InvalidClientExeption(string message, string error, string error_description) : base(message)
        {
            this.error = error;
            this.error_description = error_description;
        }
    }

}
