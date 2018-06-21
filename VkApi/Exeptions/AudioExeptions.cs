using System;
using System.Runtime.Serialization;

namespace VkApi.Exeptions
{
    public class AudioExeptions
    {
        [Serializable()]
        public class TokenConfirmationRequired : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }

            protected TokenConfirmationRequired(SerializationInfo info, StreamingContext context) { }
            public TokenConfirmationRequired(int error_code, string error_description) : base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class ContentBlocked : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }

            protected ContentBlocked(SerializationInfo info, StreamingContext context) { }
            public ContentBlocked(int error_code, string error_description) : base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }
    }
}
