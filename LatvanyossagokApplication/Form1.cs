using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace LatvanyossagokApplication
{
    public partial class formNevezetesseg : Form
    {
        MySqlConnection conn;
        public formNevezetesseg()
        {
            InitializeComponent();
            conn = new MySqlConnection("server = localhost; database = latvanyossagokdb; uid = root; pwd = ;");
            conn.Open();

            this.FormClosed += (sender, args) =>
            {
                if (conn != null)
                {
                    conn.Close();
                }
            };
        }
        void AdatBeszuras(String varosNeve,int lakossag)
        {

            string sql = @"
            INSERT INTO varosok(nev,lakossag)
            VALUES (@nev,@lakossag)
            ";
            //INSERT INTO `varosok`(`id`, `nev`, `lakossag`) VALUES ([value-1],[value-2],[value-3])
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@nev", varosNeve);
            comm.Parameters.AddWithValue("@lakossag", lakossag);

            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show(String.Format("Sikeres adatbevitel!\n{0}\n{1}",varosNeve,lakossag),"Sikeres művelet");

            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                MessageBox.Show("Ilyen város már létezik az adatbázisban!","Hiba");
            }
        }
        private void buttonVarosFelvetele_Click(object sender, EventArgs e)
        {
            if (textBoxVarosNeve.Text=="" || !(numericUpDownLakossag.Value > 0))
            {
                MessageBox.Show("Érvényes adatokat adj meg!", "Hiba");
            }
            else
            {
                AdatBeszuras(textBoxVarosNeve.Text,Convert.ToInt32(numericUpDownLakossag.Value));
            }
        }
    }
}
