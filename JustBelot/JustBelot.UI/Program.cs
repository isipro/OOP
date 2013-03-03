using JustBelot.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustBelot.IvanAI;

namespace JustBelot.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPlayer player = new HumanPlayer();

            List<IPlayer> players = new List<IPlayer>();

            players.Add(new HumanPlayer());
            players.Add(new Player());
            players.Add(new Player());
            players.Add(new Player());

            foreach (var player in players)
            {
                player.PlayedCard();
            }

            //player.PlayedCard();
            //player = new Player();
            //player.PlayedCard();
        }
    }
}
