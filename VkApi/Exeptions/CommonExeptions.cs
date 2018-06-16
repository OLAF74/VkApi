using System;
using System.Runtime.Serialization;

namespace VkApi.Exeptions
{
    class CommonExeptions
    {
        [Serializable()]
        public class UnknownApiExeption : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            public UnknownApiExeption() : base() { }
            public UnknownApiExeption(string message) : base(message) { }
            public UnknownApiExeption(string message, System.Exception inner) : base(message, inner) { }
            public UnknownApiExeption(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public UnknownApiExeption(string message, int error_code, string error_description) : base(message)
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


            public AppDisabled() : base() { }
            public AppDisabled(string message) : base(message) { }
            public AppDisabled(string message, System.Exception inner) : base(message, inner) { }
            public AppDisabled(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AppDisabled(string message, int error_code, string error_description) : base(message)
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


            public UnknownMethod() : base() { }
            public UnknownMethod(string message) : base(message) { }
            public UnknownMethod(string message, System.Exception inner) : base(message, inner) { }
            public UnknownMethod(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public UnknownMethod(string message, int error_code, string error_description) : base(message)
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


            public WrongSignature() : base() { }
            public WrongSignature(string message) : base(message) { }
            public WrongSignature(string message, System.Exception inner) : base(message, inner) { }
            public WrongSignature(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public WrongSignature(string message, int error_code, string error_description) : base(message)
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


            public AuthError() : base() { }
            public AuthError(string message) : base(message) { }
            public AuthError(string message, System.Exception inner) : base(message, inner) { }
            public AuthError(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AuthError(string message, int error_code, string error_description) : base(message)
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


            public TooMuchRequests() : base() { }
            public TooMuchRequests(string message) : base(message) { }
            public TooMuchRequests(string message, System.Exception inner) : base(message, inner) { }
            public TooMuchRequests(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public TooMuchRequests(string message, int error_code, string error_description) : base(message)
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


            public NoPermissionsToPerformThisAction() : base() { }
            public NoPermissionsToPerformThisAction(string message) : base(message) { }
            public NoPermissionsToPerformThisAction(string message, System.Exception inner) : base(message, inner) { }
            public NoPermissionsToPerformThisAction(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public NoPermissionsToPerformThisAction(string message, int error_code, string error_description) : base(message)
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


            public InvalidRequest() : base() { }
            public InvalidRequest(string message) : base(message) { }
            public InvalidRequest(string message, System.Exception inner) : base(message, inner) { }
            public InvalidRequest(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public InvalidRequest(string message, int error_code, string error_description) : base(message)
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


            public TooManySimilarActions() : base() { }
            public TooManySimilarActions(string message) : base(message) { }
            public TooManySimilarActions(string message, System.Exception inner) : base(message, inner) { }
            public TooManySimilarActions(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public TooManySimilarActions(string message, int error_code, string error_description) : base(message)
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


            public InternalServerError() : base() { }
            public InternalServerError(string message) : base(message) { }
            public InternalServerError(string message, System.Exception inner) : base(message, inner) { }
            public InternalServerError(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public InternalServerError(string message, int error_code, string error_description) : base(message)
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


            public TestModeAppEnabled() : base() { }
            public TestModeAppEnabled(string message) : base(message) { }
            public TestModeAppEnabled(string message, System.Exception inner) : base(message, inner) { }
            public TestModeAppEnabled(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public TestModeAppEnabled(string message, int error_code, string error_description) : base(message)
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


            public CaptchaNeeded() : base() { }
            public CaptchaNeeded(string message) : base(message) { }
            public CaptchaNeeded(string message, System.Exception inner) : base(message, inner) { }
            public CaptchaNeeded(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public CaptchaNeeded(string message, int error_code, string error_description) : base(message)
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


            public AccessDenied() : base() { }
            public AccessDenied(string message) : base(message) { }
            public AccessDenied(string message, System.Exception inner) : base(message, inner) { }
            public AccessDenied(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AccessDenied(string message, int error_code, string error_description) : base(message)
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


            public OnlyHTTPSAllowed() : base() { }
            public OnlyHTTPSAllowed(string message) : base(message) { }
            public OnlyHTTPSAllowed(string message, System.Exception inner) : base(message, inner) { }
            public OnlyHTTPSAllowed(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public OnlyHTTPSAllowed(string message, int error_code, string error_description) : base(message)
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


            public ValidationNeeded() : base() { }
            public ValidationNeeded(string message) : base(message) { }
            public ValidationNeeded(string message, System.Exception inner) : base(message, inner) { }
            public ValidationNeeded(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public ValidationNeeded(string message, int error_code, string error_description) : base(message)
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


            public PageDeletedOrBanned() : base() { }
            public PageDeletedOrBanned(string message) : base(message) { }
            public PageDeletedOrBanned(string message, System.Exception inner) : base(message, inner) { }
            public PageDeletedOrBanned(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public PageDeletedOrBanned(string message, int error_code, string error_description) : base(message)
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


            public ProhibitedForNonStandaloneApp() : base() { }
            public ProhibitedForNonStandaloneApp(string message) : base(message) { }
            public ProhibitedForNonStandaloneApp(string message, System.Exception inner) : base(message, inner) { }
            public ProhibitedForNonStandaloneApp(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public ProhibitedForNonStandaloneApp(string message, int error_code, string error_description) : base(message)
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


            public OnlyForStandaloneApp() : base() { }
            public OnlyForStandaloneApp(string message) : base(message) { }
            public OnlyForStandaloneApp(string message, System.Exception inner) : base(message, inner) { }
            public OnlyForStandaloneApp(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public OnlyForStandaloneApp(string message, int error_code, string error_description) : base(message)
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


            public MethodDisabled() : base() { }
            public MethodDisabled(string message) : base(message) { }
            public MethodDisabled(string message, System.Exception inner) : base(message, inner) { }
            public MethodDisabled(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public MethodDisabled(string message, int error_code, string error_description) : base(message)
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


            public ConfirmationRequired() : base() { }
            public ConfirmationRequired(string message) : base(message) { }
            public ConfirmationRequired(string message, System.Exception inner) : base(message, inner) { }
            public ConfirmationRequired(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public ConfirmationRequired(string message, int error_code, string error_description) : base(message)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }

        [Serializable()]
        public class CommunityAccessKeyInvalid  : Exception, ISerializable
        {
            public int error_code { get; set; }
            public string error_description { get; set; }


            public CommunityAccessKeyInvalid() : base() { }
            public CommunityAccessKeyInvalid(string message) : base(message) { }
            public CommunityAccessKeyInvalid(string message, System.Exception inner) : base(message, inner) { }
            public CommunityAccessKeyInvalid(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public CommunityAccessKeyInvalid(string message, int error_code, string error_description) : base(message)
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


            public ApplicationAccessKeyInvalid() : base() { }
            public ApplicationAccessKeyInvalid(string message) : base(message) { }
            public ApplicationAccessKeyInvalid(string message, System.Exception inner) : base(message, inner) { }
            public ApplicationAccessKeyInvalid(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public ApplicationAccessKeyInvalid(string message, int error_code, string error_description) : base(message)
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


            public MethodInvocationLimitReached() : base() { }
            public MethodInvocationLimitReached(string message) : base(message) { }
            public MethodInvocationLimitReached(string message, System.Exception inner) : base(message, inner) { }
            public MethodInvocationLimitReached(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public MethodInvocationLimitReached(string message, int error_code, string error_description) : base(message)
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


            public ParameterMissedOrIncorrect() : base() { }
            public ParameterMissedOrIncorrect(string message) : base(message) { }
            public ParameterMissedOrIncorrect(string message, System.Exception inner) : base(message, inner) { }
            public ParameterMissedOrIncorrect(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public ParameterMissedOrIncorrect(string message, int error_code, string error_description) : base(message)
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


            public InvalidAppID() : base() { }
            public InvalidAppID(string message) : base(message) { }
            public InvalidAppID(string message, System.Exception inner) : base(message, inner) { }
            public InvalidAppID(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public InvalidAppID(string message, int error_code, string error_description) : base(message)
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


            public InvalidUserId() : base() { }
            public InvalidUserId(string message) : base(message) { }
            public InvalidUserId(string message, System.Exception inner) : base(message, inner) { }
            public InvalidUserId(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public InvalidUserId(string message, int error_code, string error_description) : base(message)
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


            public InvalidTimestamp() : base() { }
            public InvalidTimestamp(string message) : base(message) { }
            public InvalidTimestamp(string message, System.Exception inner) : base(message, inner) { }
            public InvalidTimestamp(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public InvalidTimestamp(string message, int error_code, string error_description) : base(message)
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


            public AlbumAccessDenied() : base() { }
            public AlbumAccessDenied(string message) : base(message) { }
            public AlbumAccessDenied(string message, System.Exception inner) : base(message, inner) { }
            public AlbumAccessDenied(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AlbumAccessDenied(string message, int error_code, string error_description) : base(message)
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


            public AudioAccessDenied() : base() { }
            public AudioAccessDenied(string message) : base(message) { }
            public AudioAccessDenied(string message, System.Exception inner) : base(message, inner) { }
            public AudioAccessDenied(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AudioAccessDenied(string message, int error_code, string error_description) : base(message)
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


            public GroupAccessDenied() : base() { }
            public GroupAccessDenied(string message) : base(message) { }
            public GroupAccessDenied(string message, System.Exception inner) : base(message, inner) { }
            public GroupAccessDenied(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public GroupAccessDenied(string message, int error_code, string error_description) : base(message)
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


            public AlbumIsFull() : base() { }
            public AlbumIsFull(string message) : base(message) { }
            public AlbumIsFull(string message, System.Exception inner) : base(message, inner) { }
            public AlbumIsFull(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AlbumIsFull(string message, int error_code, string error_description) : base(message)
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


            public VoiceTranslationsDisabled() : base() { }
            public VoiceTranslationsDisabled(string message) : base(message) { }
            public VoiceTranslationsDisabled(string message, System.Exception inner) : base(message, inner) { }
            public VoiceTranslationsDisabled(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public VoiceTranslationsDisabled(string message, int error_code, string error_description) : base(message)
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


            public AdvertisingCabinetAccessDenied() : base() { }
            public AdvertisingCabinetAccessDenied(string message) : base(message) { }
            public AdvertisingCabinetAccessDenied(string message, System.Exception inner) : base(message, inner) { }
            public AdvertisingCabinetAccessDenied(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AdvertisingCabinetAccessDenied(string message, int error_code, string error_description) : base(message)
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


            public AdvertisingCabinetErrorOccurred() : base() { }
            public AdvertisingCabinetErrorOccurred(string message) : base(message) { }
            public AdvertisingCabinetErrorOccurred(string message, System.Exception inner) : base(message, inner) { }
            public AdvertisingCabinetErrorOccurred(SerializationInfo info, StreamingContext context) : base(info, context) { }
            public AdvertisingCabinetErrorOccurred(string message, int error_code, string error_description) : base(message)
            {
                this.error_code = error_code;
                this.error_description = error_description;
            }
        }
    }
}
