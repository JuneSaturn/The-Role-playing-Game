using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Role_playing_Game
{
    internal class ObjectDefinitions
    {

        public struct Definitions
        {
            public string name;
            public uint addr;

            public void a(out int a)
            {
                a = 12;
            }
        }

    }

    internal class Noxville
    {
        public delegate void Callback_Click();

        public delegate void Movement();
        public delegate void Stipulate();
    }
}
