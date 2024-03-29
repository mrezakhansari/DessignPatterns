﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Bridge3
{
    public class ShortMessage : AbstractMessage
    {
        public ShortMessage(IMessageSender messageSender)
        {
            // initialize the super class message sender variable
            this.messageSender = messageSender;
        }
        public override void SendMessage(string message)
        {
            if (message.Length <= 10)
            {
                messageSender.SendMessage(message);
            }
            else
            {
                Console.WriteLine("Unable to send the message as length > 10 characters");
            }
        }
    }
}