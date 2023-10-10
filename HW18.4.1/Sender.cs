using HW18._4._1.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18._4._1
{
    class Sender
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public async void Run()
        {
            _command.Run();
        }
    }
}