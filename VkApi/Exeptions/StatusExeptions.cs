using System;
using System.Runtime.Serialization;

namespace VkApi.Exeptions
{
    class StatusExeptions
    {
        [Serializable()]
        public class AudioToStatusDisabled : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            public AudioToStatusDisabled() : base() { }
            public AudioToStatusDisabled(string message) : base(message) { }
            public AudioToStatusDisabled(string message, System.Exception inner) : base(message, inner) { }
            public AudioToStatusDisabled(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AudioToStatusDisabled(string message, string error, string error_description) : base(message)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

    }
}
