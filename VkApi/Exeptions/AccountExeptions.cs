using System;
using System.Runtime.Serialization;

#pragma warning disable IDE1006, CS1591

namespace VkApi.Exeptions
{
    class AccountExeptions
    {
        [Serializable()]
        public class UserAlreadyBlacklisted : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }

            protected UserAlreadyBlacklisted(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public UserAlreadyBlacklisted(int error_code, string error_description) : base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class UserAlreadyRemovedFromBlacklist : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected UserAlreadyRemovedFromBlacklist(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public UserAlreadyRemovedFromBlacklist(int error_code, string error_description) : base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class UnknownAccountMethodError : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected UnknownAccountMethodError(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public UnknownAccountMethodError(int error_code, string error_description) : base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

    }
}
