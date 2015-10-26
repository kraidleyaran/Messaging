using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging
{
    public class Message
    {
        public Message(string receiver, MessageAction action, string property)
        {
            Action = action;
            Receiver = receiver;
            Property = property;
        }

        public Message(string receiver, MessageAction action, string property, string value, PropType propType)
        {
            Action = action;
            Receiver = receiver;
            Property = property;
            PropType = propType;
            Value = value;
        }

        public MessageAction Action;
        public string Receiver;
        public string Property;
        public PropType PropType;
        public string Value;
        
    }
}
