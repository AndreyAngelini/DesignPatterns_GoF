using System;

namespace Command
{
    public class Invoker
    {
        private Command _command;
        public void SetCommand( Command command)
        {
            this._command = command;
        }
        public void ExecuteCommand(Command command)
        {
            this._command.Execute();
        }
    }
}
