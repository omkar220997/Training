using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace CSNullBasic
{
    internal class MessagePopulator
    {
        public static void Populate(Message message)
        {
            message.GetType().InvokeMember("From", BindingFlags.Instance | BindingFlags.Public|
                    BindingFlags.SetProperty , Type.DefaultBinder, message, new[] { "Jason(set using reflection)" });
        }
    }
}
