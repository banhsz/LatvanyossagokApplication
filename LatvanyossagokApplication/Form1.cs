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
        List<Varos> varosok;
        List<Latvanyossag> latvanyossagok;
        MySqlConnection conn;
        public formNevezetesseg()
        {
            InitializeComponent();
            varosok = new List<Varos>();
            latvanyossagok = new List<Latvanyossag>();

            conn = new MySqlConnection("server = localhost; database = latvanyossagokdb; uid = root; pwd = ;");
            conn.Open();
            varosokFrissites();
            latvanyossagokFrissites();
            this.FormClosed += (sender, args) =>
            {
                if (conn != null)
                {
                    conn.Close();
                }
            };
        }

        public void varosokFrissites()
        {
            //1
            //listbox törlődik
            //lista törlődik
            //a nevezetességek comboBox törlődik
            //2
            //lista feltöltődik az adatb alapján
            //listbox feltöltődik az adatb alapján
            //a városok comboBox feltöltődik az adatb alapján 
            //a módosításnál a városok comboBox feltöltődik az adatb alapján

            //1
            varosok = new List<Varos>();
            listBoxVarosok.Items.Clear();
            comboBoxLatvanyossagVaros.Items.Clear();
            comboBoxVarosModosit.Items.Clear();

            string sql = @"
            SELECT `id`, `nev`, `lakossag`
            FROM varosok
            ";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    int lakossag = reader.GetInt32("lakossag");

                    var Varos = new Varos(id, nev, lakossag);
                    //2
                    listBoxVarosok.Items.Add(Varos.ToString());
                    varosok.Add(Varos);
                    comboBoxLatvanyossagVaros.Items.Add(Varos.Nev);
                    comboBoxVarosModosit.Items.Add(Varos.Nev);
                }
            }

        }
        public void latvanyossagokFrissites()
        {
            //1
            //lista törlődik
            //2 régi
            //lista feltöltődik az adatb alapján
            //2 új
            //lista feltöltődik a kiválasztott város alapján

            //1
            latvanyossagok = new List<Latvanyossag>();
            listBoxLatvanyossagok.Items.Clear();

            string sql = @"
            SELECT `id`, `nev`, `leiras`, `ar`, `varos_id` 
            FROM `latvanyossagok`
            ";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    string leiras = reader.GetString("leiras");
                    int ar = reader.GetInt32("ar");
                    int varosId = reader.GetInt32("varos_id");

                    Latvanyossag latv = new Latvanyossag(id, nev, leiras, ar, varosId);
                    //2 régi
                    //listBoxLatvanyossagok.Items.Add(latv.ToString());
                    latvanyossagok.Add(latv);
                }
            }

            //2 új
            if (listBoxVarosok.SelectedIndex >= 0)
            {
                listBoxLatvanyossagok.Items.Clear();
                int seged = varosok[listBoxVarosok.SelectedIndex].Id;
                for (int i = 0; i < latvanyossagok.Count; i++)
                {
                    if (latvanyossagok[i].VarosId == seged)
                    {
                        listBoxLatvanyossagok.Items.Add(latvanyossagok[i].ToString());
                    }
                }
            }

        }


        public void VarosBeszuras(String varosNeve, int lakossag)
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
                MessageBox.Show(String.Format("Sikeres adatbevitel!\n{0}\n{1}", varosNeve, lakossag), "Sikeres művelet");
                varosokFrissites();

            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                MessageBox.Show("Ilyen város már létezik az adatbázisban!", "Hiba");
            }
        }
        public void VarosTorles(int varosid)
        {
            string sql = @"
            DELETE FROM varosok
            WHERE id = @id
            ";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@id", varosid);
            comm.ExecuteNonQuery();
        }
        public void VarosUpdate(int id, string nev, int lakossag)
        {
            string sql = @"
            UPDATE varosok
            SET
            nev = @nev,
            lakossag = @lakossag
            WHERE id = @id
            ";
            //UPDATE `varosok` SET `id`=[value-1],`nev`=[value-2],`lakossag`=[value-3] WHERE 1
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@id", id);
            comm.Parameters.AddWithValue("@nev", nev);
            comm.Parameters.AddWithValue("@lakossag", lakossag);
            comm.ExecuteNonQuery();
            varosokFrissites();
        }

        public void LatvanyossagsBeszuras(string lNeve, string lLeiras, int lAr, string lVaros)
        {

            string sql = @"
            INSERT INTO `latvanyossagok`(`nev`, `leiras`, `ar`, `varos_id`)
            VALUES (@nev,@leiras,@ar,@varos)
            ";
            //INSERT INTO `latvanyossagok`(`id`, `nev`, `leiras`, `ar`, `varos_id`) VALUES ([value-1],[value-2],[value-3],[value-4],[value-5])
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@nev", lNeve);
            comm.Parameters.AddWithValue("@leiras", lLeiras);
            comm.Parameters.AddWithValue("@ar", lAr);
            int varosid = -1;
            for (int i = 0; i < varosok.Count; i++)
            {
                if (varosok[i].Nev == lVaros)
                {
                    varosid = varosok[i].Id;
                }
            }
            comm.Parameters.AddWithValue("@varos", varosid);

            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show(String.Format("Sikeres adatbevitel!\n{0}\n{1}\n{2}\n{3}", lNeve, lLeiras, lAr, lVaros), "Sikeres művelet");
                latvanyossagokFrissites();

            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                MessageBox.Show("Sikertelen adatfelvétel!", "Hiba");
            }
        }
        public void LatvanyossagTorles(int lId)
        {
            string sql = @"
            DELETE FROM latvanyossagok
            WHERE id = @id
            ";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@id", lId);
            comm.ExecuteNonQuery();
        }
        public void LatvanyossagUpdate(int id,string nev,string leiras,int ar,int varosId)
        {
            string sql = @"
            UPDATE latvanyossagok
            SET
            nev = @nev,
            leiras = @leiras,
            ar = @ar,
            varos_id = @varosId
            WHERE id = @id
            ";
            //UPDATE `latvanyossagok` SET `id`=[value-1],`nev`=[value-2],`leiras`=[value-3],`ar`=[value-4],`varos_id`=[value-5] WHERE 1
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@id", id);
            comm.Parameters.AddWithValue("@nev", nev);
            comm.Parameters.AddWithValue("@leiras", leiras);
            comm.Parameters.AddWithValue("@ar", ar);
            comm.Parameters.AddWithValue("@varosId", varosId);
            comm.ExecuteNonQuery();
            latvanyossagokFrissites();
        }


        private void buttonVarosFelvetele_Click(object sender, EventArgs e)
        {
            if (textBoxVarosNeve.Text=="" || !(numericUpDownLakossag.Value > 0))
            {
                MessageBox.Show("Érvényes adatokat adj meg!", "Hiba");
            }
            else
            {
                VarosBeszuras(textBoxVarosNeve.Text,Convert.ToInt32(numericUpDownLakossag.Value));
            }
        }
        private void buttonLatvanyossagFelvetele_Click(object sender, EventArgs e)
        {
            if (textBoxLatvanyossagNeve.Text == "" || textBoxLatvanyossagLeiras.Text=="" || !(numericUpDownLatvanyossagAr.Value >= 0) || comboBoxLatvanyossagVaros.Text=="")
            {
                MessageBox.Show("Érvényes adatokat adj meg! Válassz ki várost is!", "Hiba");
            }
            else
            {
                LatvanyossagsBeszuras(textBoxLatvanyossagNeve.Text, textBoxLatvanyossagLeiras.Text,Convert.ToInt32(numericUpDownLatvanyossagAr.Value),comboBoxLatvanyossagVaros.Text);
            }
        }
        private void buttonVarosTorlese_Click(object sender, EventArgs e)
        {
            if (listBoxVarosok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva város", "Hiba");
            }
            else
            {
                int seged = varosok[listBoxVarosok.SelectedIndex].Id;
                int i = 0;
                bool van = false;
                while (!van && i<latvanyossagok.Count)
                {
                    if (latvanyossagok[i].VarosId==seged)
                    {
                        van = true;
                    }
                    i++;
                }
                if (van)
                {
                    MessageBox.Show("Ehhez a vásorhoz még van felvéve nevezetesség!","Hiba");
                }
                else
                {
                    VarosTorles(seged);
                    MessageBox.Show("Sikeres város törlés!","Siker");
                    varosokFrissites();
                }
            }
        }
        private void buttonLatvanyossagTorlese_Click(object sender, EventArgs e)
        {
            if (listBoxLatvanyossagok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva város", "Hiba");
            }
            else
            {
                //a listában hanyadik város látványosságát kell törölni?
                int hanyadikVaros = listBoxVarosok.SelectedIndex;
                //ennek a varosnak mi az adatbazis id-je?
                int varosId = varosok[listBoxVarosok.SelectedIndex].Id;

                //Ennek a városnak HANYADIK látványosságát kell törölni?
                //0 az első
                int hanyadikLatvanyossag = listBoxLatvanyossagok.SelectedIndex;
                //MessageBox.Show(String.Format("A {0} id-jű város , {1}. nevezetességét kell törölni",varosId,hanyadikLatvanyossag));

                //Most bejárjuk a látványosság listát (db = -1 kezdőértékkel), és ha találunk egy látványosságot aminek
                //a város id-je egyezik a varosID-vel. akkor a db-hoz hozzáadunk egyet.
                //ha a db egyenlő a hanyadikLatvanyossag változóval. akkor amelyik látványosságon éppen vagyunk (i) azt kell kitörölni. annak id-je 
                //alapján.
                int db = -1;
                bool megvan = false;
                int i = 0;
                while (!megvan)
                {
                    if (latvanyossagok[i].VarosId == varosId)
                    {
                        db++;
                        if (db == hanyadikLatvanyossag)
                        {
                            megvan = true;
                        }
                    }
                    if (!megvan)
                    {
                        i++;
                    }
                }
                //MessageBox.Show(String.Format("{0}", latvanyossagok[i].Id));

                LatvanyossagTorles(latvanyossagok[i].Id);
                MessageBox.Show("Sikeres látványosság törlés!", "Siker");
                latvanyossagokFrissites();
            }
        }

        private void listBoxVarosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxVarosok.SelectedIndex >= 0)
            {
                //látványosságok betöltése a listába
                listBoxLatvanyossagok.Items.Clear();
                int seged = varosok[listBoxVarosok.SelectedIndex].Id;
                for (int i = 0; i < latvanyossagok.Count; i++)
                {
                    if (latvanyossagok[i].VarosId == seged)
                    {
                        listBoxLatvanyossagok.Items.Add(latvanyossagok[i].ToString());
                    }
                }

                //város adatok betöltése a formba
                //hanyadik város van kiválasztva a listában?
                int hanyadikVaros = listBoxVarosok.SelectedIndex;

                textBoxVarosModosit.Text = varosok[hanyadikVaros].Nev;
                numericUpDownLakossagModosit.Value = varosok[hanyadikVaros].Lakossag;

            }
            else
            {
                textBoxVarosModosit.Text = "";
                numericUpDownLakossagModosit.Value = 0;
            }
        }
        private void listBoxLatvanyossagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLatvanyossagok.SelectedIndex>=0)
            {
                //látványosságok adatok betöltése a formba
                //a listában hanyadik város látványosságát kell törölni?
                int hanyadikVaros = listBoxVarosok.SelectedIndex;
                //ennek a varosnak mi az adatbazis id-je?
                int varosId = varosok[listBoxVarosok.SelectedIndex].Id;

                //Ennek a városnak HANYADIK látványosságát kell törölni?
                //0 az első
                int hanyadikLatvanyossag = listBoxLatvanyossagok.SelectedIndex;
                //MessageBox.Show(String.Format("A {0} id-jű város , {1}. nevezetességét kell törölni",varosId,hanyadikLatvanyossag));

                //Most bejárjuk a látványosság listát (db = -1 kezdőértékkel), és ha találunk egy látványosságot aminek
                //a város id-je egyezik a varosID-vel. akkor a db-hoz hozzáadunk egyet.
                //ha a db egyenlő a hanyadikLatvanyossag változóval. akkor amelyik látványosságon éppen vagyunk (i) azt kell kitörölni. annak id-je 
                //alapján.
                int db = -1;
                bool megvan = false;
                int i = 0;
                while (!megvan)
                {
                    if (latvanyossagok[i].VarosId == varosId)
                    {
                        db++;
                        if (db == hanyadikLatvanyossag)
                        {
                            megvan = true;
                        }
                    }
                    if (!megvan)
                    {
                        i++;
                    }
                }
                //MessageBox.Show(String.Format("{0}", latvanyossagok[i].Id));
                textBoxLatvanyossagModosit.Text=latvanyossagok[i].Nev;
                textBoxLeirasModosit.Text = latvanyossagok[i].Leiras;
                numericUpDownArModosit.Value = latvanyossagok[i].Ar;
                comboBoxVarosModosit.Text = varosok[listBoxVarosok.SelectedIndex].Nev;
            }
            else
            {
                textBoxLatvanyossagModosit.Text = "";
                textBoxLeirasModosit.Text = "";
                numericUpDownArModosit.Value = 0;
                comboBoxVarosModosit.Text = "";
            }
        }

        private void buttonVarosModosit_Click(object sender, EventArgs e)
        {
            if (listBoxVarosok.SelectedIndex == -1)
            {
                MessageBox.Show("Válaszd ki a listából a várost!", "Hiba");
            }
            else
            { 
                if (textBoxVarosModosit.Text == "" || !(numericUpDownLakossagModosit.Value > 0))
                {
                    MessageBox.Show("Érvényes adatokat adj meg!", "Hiba");
                }
                else
                {
                    //a listában hanyadik város látványosságát kell törölni?
                    int hanyadikVaros = listBoxVarosok.SelectedIndex;
                    //ennek a varosnak mi az adatbazis id-je?
                    int varosId = varosok[listBoxVarosok.SelectedIndex].Id;
                    VarosUpdate(varosId, textBoxVarosModosit.Text, Convert.ToInt32(numericUpDownLakossagModosit.Value));
                    MessageBox.Show("Város módosítása sikeres!","Siker");
                }
            }
    }
        private void buttonLatvanyossagModosit_Click(object sender, EventArgs e)
        {
            if (listBoxLatvanyossagok.SelectedIndex == -1)
            {
                MessageBox.Show("Válaszd ki a listából a nevezetességet!", "Hiba");
            }
            else
            {
                if (textBoxLatvanyossagModosit.Text == "" || textBoxLeirasModosit.Text == "" || !(numericUpDownArModosit.Value >= 0) || comboBoxVarosModosit.Text == "")
                {
                    MessageBox.Show("Érvényes adatokat adj meg! Válassz ki várost is és nevezetességet is!", "Hiba");
                }
                else
                {
                    //a listában hanyadik város látványosságát kell törölni?
                    int hanyadikVaros = listBoxVarosok.SelectedIndex;
                    //ennek a varosnak mi az adatbazis id-je?
                    int varosId = varosok[listBoxVarosok.SelectedIndex].Id;

                    //Ennek a városnak HANYADIK látványosságát kell törölni?
                    //0 az első
                    int hanyadikLatvanyossag = listBoxLatvanyossagok.SelectedIndex;
                    //MessageBox.Show(String.Format("A {0} id-jű város , {1}. nevezetességét kell törölni",varosId,hanyadikLatvanyossag));

                    //Most bejárjuk a látványosság listát (db = -1 kezdőértékkel), és ha találunk egy látványosságot aminek
                    //a város id-je egyezik a varosID-vel. akkor a db-hoz hozzáadunk egyet.
                    //ha a db egyenlő a hanyadikLatvanyossag változóval. akkor amelyik látványosságon éppen vagyunk (i) azt kell kitörölni. annak id-je 
                    //alapján.
                    int db = -1;
                    bool megvan = false;
                    int i = 0;
                    while (!megvan)
                    {
                        if (latvanyossagok[i].VarosId == varosId)
                        {
                            db++;
                            if (db == hanyadikLatvanyossag)
                            {
                                megvan = true;
                            }
                        }
                        if (!megvan)
                        {
                            i++;
                        }
                    }
                    //MessageBox.Show(String.Format("{0}", latvanyossagok[i].Id));
                    int varosIdhelp = varosok[comboBoxVarosModosit.SelectedIndex].Id;
                    LatvanyossagUpdate(latvanyossagok[i].Id, textBoxLatvanyossagModosit.Text, textBoxLeirasModosit.Text, Convert.ToInt32(numericUpDownArModosit.Value), varosIdhelp);
                    MessageBox.Show("Nevezetesség módosítása sikeres!","Siker");

                }
            }
        }
    }
}
