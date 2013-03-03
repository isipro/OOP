using JustBelot.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JustBelot.IvanAI
{
    public class Player : IPlayer
    {
        public string Name
        {
            get { return "Ivan Bot"; }
        }

        public void PlayedCard()
        {
            Console.WriteLine("Ivan played a card");
        }
    }
}
