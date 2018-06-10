using System;
using System.Runtime.Serialization;

#pragma warning disable IDE1006

namespace VkApi.Exeptions
{
    [Serializable()]
    public class ValidationNeededExeption : Exception, ISerializable
    {
        public string validation_type { get; set; }
        public string phone_mask { get; set; }


        public ValidationNeededExeption() : base() { }
        public ValidationNeededExeption(string message) : base(message) { }
        public ValidationNeededExeption(string message, System.Exception inner) : base(message, inner) { }
        public ValidationNeededExeption(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public ValidationNeededExeption(string message, string validation_type, string phone_mask) : base(message)
        {
            this.validation_type = validation_type;
            this.phone_mask = phone_mask;
        }
    }
}
