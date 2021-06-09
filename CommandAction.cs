using System;

namespace WinCommandActions
{
    [Serializable]
    internal class CommandAction
    {
        public string Title = "Empty Action";
        public string Command = "hello computer";

        public string Filename = "";

        public CommandAction Copy()
        {
            return new CommandAction {Title = Title, Command = Command, Filename = Filename};
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
