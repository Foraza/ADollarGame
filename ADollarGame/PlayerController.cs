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

        public void setScore(double score)
        {
            player.Score = score;
        }

        public void gameOver()
        {
            player.EndTime = DateTime.Now.TimeOfDay;
            DAO.insert(player);
        }
    }
}
