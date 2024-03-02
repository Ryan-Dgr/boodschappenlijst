using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using domain_boodschappen.Business;

namespace domain_boodschappen.Persistence
{
    internal class mapper
    {
        string _connectionstring;

        public void addBoodschap(boodschap boodschap)
        {
            string mysql;
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            mysql = "INSERT INTO `boodschappen`.`tblboodschappen` (Product, aantal, extra) VALUES (@Product, @aantal, @extra)";
            MySqlCommand cmd = new MySqlCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@Product", boodschap.Product);
            cmd.Parameters.AddWithValue("@aantal", boodschap.Aantal);
            cmd.Parameters.AddWithValue("@extra", boodschap.Extra);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<boodschap> GetBoodschappen()
        {
            List<boodschap> lijst = new List<boodschap>();
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from tblboodschappen", conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.HasRows)
            {
                while(rdr.Read())
                {
                    boodschap boodschap = new boodschap(Convert.ToInt16(rdr["idBoodschappen"]), Convert.ToString(rdr["product"]), Convert.ToInt16(rdr["aantal"]), Convert.ToString(rdr["extra"]));
                    lijst.Add(boodschap);
                }
            }
            conn.Close();
            return lijst;
        }


        public mapper()
        {
            _connectionstring = "server=localhost;user=root;database=boodschappen;port=3306;password=64313";
        }
    }
}
