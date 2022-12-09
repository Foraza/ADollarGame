using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADollarGame
{
    public class PlayerController
    {
        private PlayerDAO DAO = new PlayerDAO();
        private PlayerModel player = new PlayerModel();

        public void startGame(PlayerModel player) 
        {
            this.player = player;
        }

        public double getScore()
        {
            return player.Score;
        }

        public void updateScore(int i)
        {
            if (i <= 4)
            {
                player.Score += 0.01;
                Console.WriteLine(player.Score);

            }else if(i > 4 && i < 10)
            {
                player.Score += 0.03;

            }else if(i >= 10 && i < 15)
            {
                player.Score += 0.06;

            }
            else
            {
                player.Score += 0.5;
            }
        }

        public void gameOver()
        {
            player.EndTime = DateTime.Now.TimeOfDay;
            DAO.insert(player);
        }

        public List<PlayerModel> getAllPlayers()
        {
            return DAO.ranking();
        }
    }
}
