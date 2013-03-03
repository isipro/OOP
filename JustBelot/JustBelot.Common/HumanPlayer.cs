using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBelot.Common
{
    public class HumanPlayer : IPlayer
    {

        private bool isLocal = true;

        public bool IsLocal
        {
            get { return isLocal; }

        }

        public string Name
        {
            get { return "Human Player"; }
        }

        public void PlayedCard()
        {
            Console.WriteLine("played a card");
        }
    }
}
