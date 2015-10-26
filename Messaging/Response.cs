namespace Messaging
{
    public class Response
    {
        public Response(bool status, string property, string value, PropType propType, string receiver)
        {
            Status = status;
            Value = value;
            Receiver = receiver;
            Property = property;
            PropType = propType;
        }

        public bool Status;
        public string Property;
        public string Value;
        public PropType PropType;
        public string Receiver;
    }
}