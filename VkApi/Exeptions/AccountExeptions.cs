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


            public UserAlreadyBlacklisted() : base() { }
            public UserAlreadyBlacklisted(string message) : base(message) { }
            public UserAlreadyBlacklisted(string message, System.Exception inner) : base(message, inner) { }
            public UserAlreadyBlacklisted(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public UserAlreadyBlacklisted(string message, int error_code, string error_description) : base(message)
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


            public UserAlreadyRemovedFromBlacklist() : base() { }
            public UserAlreadyRemovedFromBlacklist(string message) : base(message) { }
            public UserAlreadyRemovedFromBlacklist(string message, System.Exception inner) : base(message, inner) { }
            public UserAlreadyRemovedFromBlacklist(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public UserAlreadyRemovedFromBlacklist(string message, int error_code, string error_description) : base(message)
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


            public UnknownAccountMethodError() : base() { }
            public UnknownAccountMethodError(string message) : base(message) { }
            public UnknownAccountMethodError(string message, System.Exception inner) : base(message, inner) { }
            public UnknownAccountMethodError(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public UnknownAccountMethodError(string message, int error_code, string error_description) : base(message)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

    }
}
