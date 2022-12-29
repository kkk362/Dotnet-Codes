using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_2
{
    class Ex3
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine(player.PlayerId);// 10001
            player.PlayerId = 101;
            player.PlayerName = "Raj";
            Console.WriteLine("PlayerId={0} PlayerName={1}",player.PlayerId,player.PlayerName);
        }
     }
  internal  class Player
    {
     private   int playerId=10001;
      private  string playername;
        public int PlayerId
        {
            get
            {
                return playerId;
            }
            set
            {

                playerId = value;

            }
        }
        public string PlayerName
        {
            get
            {
                return playername;
            }
            set
            {
                playername = value;
            }
        }
    }
}
