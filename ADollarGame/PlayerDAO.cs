using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ADollarGame
{
    class PlayerDAO
    {
        private MySqlConnection conn = DBConnection.getConnection();
        private CultureInfo us = new CultureInfo("en-US");

        public List<PlayerModel> findAll()
        {
            List<PlayerModel> players = new List<PlayerModel>();
            conn.Open();

            string sql = "SELECT * FROM players";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            PlayerModel aux = new PlayerModel();
            while (dr.Read())
            {
                aux.Id = dr.GetInt32("id");
                aux.Nickname = dr.GetString("nickname");
                aux.Score = dr.GetDouble("score");
                aux.StartTime = dr.GetTimeSpan("start_time");
                aux.EndTime = dr.GetTimeSpan("end_time");

                players.Add(aux);
            }

            dr.Close();
            conn.Close();
            return players;
        }

        public PlayerModel find(int id)
        {
            conn.Open();

            string sql = $"SELECT * FROM players WHERE id = {id}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            PlayerModel aux = new PlayerModel();
            dr.Read();

            aux.Id = dr.GetInt32("id");
            aux.Nickname = dr.GetString("nickname");
            aux.Score = dr.GetDouble("score");
            aux.StartTime = dr.GetTimeSpan("start_time");
            aux.EndTime = dr.GetTimeSpan("end_time");

            dr.Close();
            conn.Close();
            return aux;
        }

        public void insert(PlayerModel player)
        {
            
            conn.Open();

            //string sql = "INSERT INTO players (nickname, score, start_time, end_time,played_time) VALUES ("
               // + "'" + nickname + "',"
               // + score.ToString("n", us) + ","
               // + "'" + startTime + "',"
               // + "'" + endTime + "')";

            string sql = $"INSERT INTO players (nickname, score, start_time, end_time,played_time) " +
                         $"VALUES ('{player.Nickname}',{player.Score.ToString("n", us)},'{player.StartTime}','{player.EndTime}',timediff(end_time,start_time))";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void update(int id, string nickname = null, double score = 0, TimeSpan? startTime = null, TimeSpan? endTime = null)
        {
            conn.Open();

            string sql = $"SELECT * FROM players WHERE id ={id}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            
            nickname = nickname ?? dr.GetString("nickname");
            score = score > 0 ? score : dr.GetDouble("score");
            startTime = startTime ?? dr.GetTimeSpan("start_time");
            endTime = endTime ?? dr.GetTimeSpan("end_time");
            
            dr.Close();

            //sql = "UPDATE players SET "
            // + "nickname = '" + nickname + "',"
            //+ "score = " + score.ToString("n", us) + ","
            //+ "start_time = '" + startTime + "',"
            //+ "end_time = '" + endTime + "'"
            //+ " WHERE id = " + id;

            sql = $"UPDATE players SET nickname = '{nickname}'" +
                  $"score = {score.ToString("n", us)}" +
                  $"start_time ='{startTime}'" +
                  $"end_time = {endTime}" +
                  $"WHERE id = {id}";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void remove(int id)
        {
            conn.Open();

            string sql = $"DELETE FROM players WHERE id = {id}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public List<PlayerModel> ranking()
        {
            List<PlayerModel> rankings = new List<PlayerModel>();
            conn.Open();
            string sql = $"SELECT * from players " +
                $"where nickname<> ''" +
                $"and score<> ''" +
                $"and start_time<> ''" +
                $"and end_time<> ''" +
                $"and played_time<> ''" +
                $"order by score desc, played_time";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            PlayerModel aux = new PlayerModel();

            while (dr.Read())
            {
                aux.Id = dr.GetInt32("id");
                aux.Nickname = dr.GetString("nickname");
                aux.Score = dr.GetDouble("score");
                aux.StartTime = dr.GetTimeSpan("start_time");
                aux.EndTime = dr.GetTimeSpan("end_time");
                aux.PlayedTime = dr.GetTimeSpan("played_time");

                rankings.Add(aux);
            }
            dr.Close();
            conn.Close();
            return rankings;
        }
        
    }
}
