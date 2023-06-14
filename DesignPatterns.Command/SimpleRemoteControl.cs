using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command
{
    public class SimpleRemoteControl
    {
        ICommand slot; // only one button

        public SimpleRemoteControl()
        {
            
        }

        public void SetCommand(ICommand command)
        {
            this.slot = command;
        }
        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}