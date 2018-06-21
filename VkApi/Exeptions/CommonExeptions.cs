using System;
using System.Runtime.Serialization;

namespace VkApi.Exeptions
{
    public class CommonExeptions
    {
        [Serializable()]
        public class UnknownApiError : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected UnknownApiError(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public UnknownApiError(int error_code, string error_description) : base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class AppDisabled : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected AppDisabled(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AppDisabled(int error_code, string error_description) : base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }


        [Serializable()]
        public class UnknownMethod : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected UnknownMethod(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public UnknownMethod(int error_code, string error_description) : base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class WrongSignature : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected WrongSignature(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public WrongSignature( int error_code, string error_description) : base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class AuthError : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected AuthError(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AuthError( int error_code, string error_description) : base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class TooMuchRequests : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected TooMuchRequests(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public TooMuchRequests( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class NoPermissionsToPerformThisAction : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected NoPermissionsToPerformThisAction(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public NoPermissionsToPerformThisAction( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class InvalidRequest : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected InvalidRequest(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public InvalidRequest( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class TooManySimilarActions : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected TooManySimilarActions(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public TooManySimilarActions( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class InternalServerError : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected InternalServerError(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public InternalServerError( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class TestModeAppEnabled : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected TestModeAppEnabled(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public TestModeAppEnabled( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class CaptchaNeeded : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected CaptchaNeeded(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public CaptchaNeeded( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class AccessDenied : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected AccessDenied(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AccessDenied( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class OnlyHTTPSAllowed : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected OnlyHTTPSAllowed(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public OnlyHTTPSAllowed( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class ValidationNeeded : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected ValidationNeeded(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public ValidationNeeded( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class PageDeletedOrBanned : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected PageDeletedOrBanned(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public PageDeletedOrBanned( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class ProhibitedForNonStandaloneApp : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected ProhibitedForNonStandaloneApp(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public ProhibitedForNonStandaloneApp( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class OnlyForStandaloneApp : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected OnlyForStandaloneApp(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public OnlyForStandaloneApp( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class MethodDisabled : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected MethodDisabled(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public MethodDisabled( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class ConfirmationRequired : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected ConfirmationRequired(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public ConfirmationRequired( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class CommunityAccessKeyInvalid : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected CommunityAccessKeyInvalid(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public CommunityAccessKeyInvalid( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class ApplicationAccessKeyInvalid : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected ApplicationAccessKeyInvalid(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public ApplicationAccessKeyInvalid( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class MethodInvocationLimitReached : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected MethodInvocationLimitReached(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public MethodInvocationLimitReached( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class ParameterMissedOrIncorrect : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected ParameterMissedOrIncorrect(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public ParameterMissedOrIncorrect( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class InvalidAppID : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected InvalidAppID(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public InvalidAppID( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class InvalidUserId : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected InvalidUserId(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public InvalidUserId( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class InvalidTimestamp : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected InvalidTimestamp(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public InvalidTimestamp( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class AlbumAccessDenied : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected AlbumAccessDenied(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AlbumAccessDenied( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class AudioAccessDenied : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected AudioAccessDenied(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AudioAccessDenied( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class GroupAccessDenied : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected GroupAccessDenied(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public GroupAccessDenied( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class AlbumIsFull : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected AlbumIsFull(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AlbumIsFull( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class VoiceTranslationsDisabled : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected VoiceTranslationsDisabled(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public VoiceTranslationsDisabled( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class AdvertisingCabinetAccessDenied : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected AdvertisingCabinetAccessDenied(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AdvertisingCabinetAccessDenied( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class AdvertisingCabinetErrorOccurred : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            protected AdvertisingCabinetErrorOccurred(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AdvertisingCabinetErrorOccurred( int error_code, string error_description) :  base(error_description)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }
    }
}
