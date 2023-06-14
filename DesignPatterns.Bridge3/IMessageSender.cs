using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Bridge3
{
    public interface IMessageSender
    {
        void SendMessage(string message);
    }
}