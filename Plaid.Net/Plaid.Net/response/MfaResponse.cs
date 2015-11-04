using Newtonsoft.Json;

namespace Plaid.Net.response
{
//@JsonTypeInfo(  
//        use         = JsonTypeInfo.Id.NAME,  
//        include     = JsonTypeInfo.As.PROPERTY,  
//        property    = "type")  
//@JsonSubTypes({  
//        @Type(value = MfaResponse.DeviceChoiceMfaResponse.class,    name = MfaResponse.DEVICE),  
//        @Type(value = MfaResponse.DeviceListMfaResponse.class,      name = MfaResponse.LIST),
//        @Type(value = MfaResponse.QuestionsMfaResponse.class,       name = MfaResponse.QUESTIONS),
//        @Type(value = MfaResponse.SelectionsMfaResponse.class,		name = MfaResponse.SELECTIONS)})

    //public abstract class MfaResponse : PlaidUserResponse
    //{

    //    public static string Device = "device";
    //    public static string List = "list";
    //    public static string Questions = "questions";
    //    public static string Selections = "selections";

    //    protected string Type;

    //    public abstract string GetType();

    //    public class DeviceChoiceMfaResponse : MfaResponse
    //    {

    //        [JsonProperty("mfa")] private Message _deviceChoiceSentMessage;

    //        public Message GetDeviceChoiceSentMessage()
    //        {
    //            return _deviceChoiceSentMessage;
    //        }

    //        public void SetDeviceChoiceSentMessage(Message deviceChoiceSentMessage)
    //        {
    //            _deviceChoiceSentMessage = deviceChoiceSentMessage;
    //        }

    //        public override string GetType()
    //        {
    //            return Device;
    //        }
    //    }

    //    public class QuestionsMfaResponse : MfaResponse
    //    {

    //        [JsonProperty("mfa")] private Question[] _questions;

    //        public Question[] GetQuestions()
    //        {
    //            return _questions;
    //        }

    //        public void SetQuestions(Question[] questions)
    //        {
    //            _questions = questions;
    //        }

    //        public override string GetType()
    //        {
    //            return Questions;
    //        }
    //    }

    //    public class SelectionsMfaResponse : MfaResponse
    //    {

    //        [JsonProperty("mfa")] private Selection[] _selections;

    //        public Selection[] GetSelections()
    //        {
    //            return _selections;
    //        }

    //        public void SetSelections(Selection[] selections)
    //        {
    //            _selections = selections;
    //        }

    //        public override string GetType()
    //        {
    //            return Selections;
    //        }
    //    }

    //    public class DeviceListMfaResponse : MfaResponse
    //    {

    //        [JsonProperty("mfa")] private DeviceType[] _deviceTypes;

    //        public DeviceType[] GetDeviceTypes()
    //        {
    //            return _deviceTypes;
    //        }

    //        public void SetDeviceTypes(DeviceType[] deviceTypes)
    //        {
    //            _deviceTypes = deviceTypes;
    //        }

    //        public override string GetType()
    //        {
    //            return List;
    //        }
    //    }

    //    public class Message
    //    {

    //        private string _message;

    //        public string GetMessage()
    //        {
    //            return _message;
    //        }

    //        public void SetMessage(string message)
    //        {
    //            _message = message;
    //        }
    //    }

    //    public class Question
    //    {
    //        private string _question;

    //        public string GetQuestion()
    //        {
    //            return _question;
    //        }

    //        public void SetQuestion(string question)
    //        {
    //            _question = question;
    //        }
    //    }

    //    public class Selection
    //    {

    //        private string _question;
    //        private string[] _answers;

    //        public string[] GetAnswers()
    //        {
    //            return _answers;
    //        }

    //        public string GetQuestion()
    //        {
    //            return _question;
    //        }

    //        public void SetAnswers(string[] answers)
    //        {
    //            _answers = answers;
    //        }

    //        public void SetQuestion(string question)
    //        {
    //            _question = question;
    //        }
    //    }

    //    public class DeviceType
    //    {

    //        private string _mask;
    //        private string _type;

    //        public string GetMask()
    //        {
    //            return _mask;
    //        }

    //        public void SetMask(string mask)
    //        {
    //            _mask = mask;
    //        }

    //        public string GetType()
    //        {
    //            return _type;
    //        }

    //        public void SetType(string type)
    //        {
    //            _type = type;
    //        }
    //    }
    //}
}
