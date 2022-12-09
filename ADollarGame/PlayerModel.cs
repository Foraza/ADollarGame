using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADollarGame
{
    class PlayerModel
    {
        private int id;
        private string nickname;
        private double score;
        private TimeSpan startTime;
        private TimeSpan endTime;
        private TimeSpan playedTime;

        public int Id { get; set; }

        public string Nickname { get; set; }

        public double Score { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public TimeSpan PlayedTime { get; set; }
    }
}
