using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VkApi.Exeptions
{
    class AuthExeptions
    {

        [Serializable()]
        public class InvalidPhoneNumber : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected InvalidPhoneNumber(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public InvalidPhoneNumber(int error_code, string error_description) : base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }


        [Serializable()]
        public class PhoneAlreadyRegistered : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected PhoneAlreadyRegistered(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public PhoneAlreadyRegistered(int error_code, string error_description) : base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }


        [Serializable()]
        public class ProcessingTryLater : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected ProcessingTryLater(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public ProcessingTryLater(int error_code, string error_description) : base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

    }
}
