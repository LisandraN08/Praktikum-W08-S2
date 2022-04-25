using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum_W08_S2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public static DataTable dtTeam = new DataTable();
        public static DataTable dtTeam2 = new DataTable(); 
        public static DataTable dtset = new DataTable();
        public static DataTable dtset1 = new DataTable();
        public static DataTable dataMatch = new DataTable();
        public static DataTable matchResult = new DataTable();
        public void Form1_Load_1(object sender, EventArgs e)
        {
            sqlConnect.Open();

            sqlQuery = "SELECT t.team_id as 'ID Team', t.team_name as 'Nama Tim', m.manager_name as 'Nama Manager', p.player_name as 'Nama Captain' FROM manager m, team t, player p WHERE t.manager_id = m.manager_id and p.player_id = t.captain_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            sqlAdapter.Fill(dtTeam2);
            cBoxTimHome.DataSource = dtTeam;
            cBoxTimHome.DisplayMember = "Nama Tim";
            cBoxTimHome.ValueMember = "ID Team";
            cBoxTimLawan.DataSource = dtTeam2;
            cBoxTimLawan.DisplayMember = "Nama Tim";
            cBoxTimLawan.ValueMember = "ID Team";
        }
        public void cBoxTimHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = cBoxTimHome.SelectedIndex;
            sqlQuery = "SELECT team_name as 'Nama Tim', manager_name as 'Nama Manager', player_name as 'Nama Captain', concat(home_stadium, ', ', city) as 'Nama Stadium', capacity as 'Jumlah Kapasitas' FROM manager, team, player WHERE team.manager_id = manager.manager_id and player.player_id = team.captain_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtset);
            lblNamaManager1.Text = dtset.Rows[SelectedIndex]["Nama Manager"].ToString();
            lblNamaCaptain1.Text = dtset.Rows[SelectedIndex]["Nama Captain"].ToString();
            lblNamaStadium.Text = dtset.Rows[SelectedIndex]["Nama Stadium"].ToString();
            lblJumlahCapacity.Text = dtset.Rows[SelectedIndex]["Jumlah Kapasitas"].ToString();
        }

        private void cBoxTimLawan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = cBoxTimLawan.SelectedIndex;
            sqlQuery = "SELECT team_name as 'Nama Tim', manager_name as 'Nama Manager', player_name as 'Nama Captain', concat(home_stadium, ', ', city) as 'Nama Stadium', capacity as 'Jumlah Kapasitas' FROM manager, team, player WHERE team.manager_id = manager.manager_id and player.player_id = team.captain_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtset1);
            lblNamaManager2.Text = dtset1.Rows[SelectedIndex]["Nama Manager"].ToString();
            lblNamaCaptain2.Text = dtset1.Rows[SelectedIndex]["Nama Captain"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataMatch.Clear();
            matchResult.Clear();
            sqlQuery = "select date_format(`match`.match_date, '%d %M %Y') as 'match_date', concat(`match`.goal_home,' - ', `match`.goal_away) as 'skor', d.match_id as 'match_id', d.`minute` as 'minute', d.team_id as 'team_id', d.player_id as 'player_id', d.`type` as 'type', d.`delete` as 'delete' from dmatch d, `match`, team t, team t1 where d.match_id =`match`.match_id and t.team_id =`match`.team_home and t1.team_id =`match`.team_away and `match`.team_home = '"+ cBoxTimHome.SelectedValue.ToString() + "' and `match`.team_away = '" + cBoxTimLawan.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataMatch);
            if (dataMatch.Rows.Count > 0)
            {
                lblNamaTanggal.Text = dataMatch.Rows[0]["match_date"].ToString();
                lblJumlahSkor.Text = dataMatch.Rows[0]["skor"].ToString();
            }
            else
            {
                lblNamaTanggal.Text = "";
                lblJumlahSkor.Text = "";
            }
            sqlQuery = "select d.`minute` as 'minute', if ((d.team_id = '" + cBoxTimHome.SelectedValue.ToString() + "' and d.type != 'GW') or(d.team_id = '" + cBoxTimLawan.SelectedValue.ToString() + "' and d.type = 'GW') , p.player_name,' ') as 'Player Name 1', if ((d.team_id = '" + cBoxTimHome.SelectedValue.ToString() + "' and d.type != 'GW') or(d.team_id = '" + cBoxTimLawan.SelectedValue.ToString() + "' and d.type = 'GW') , if (d.type = 'CY','YELLOW CARD',if (d.type = 'CR', 'RED CARD',if (d.type = 'GO', 'GOAL',if (d.type = 'GP','GOAL PENALTY',if (d.type = 'GW', 'OWN GOAL','PENALTY MISS'))))),' ') as 'Tipe 1', if ((d.team_id = '" + cBoxTimLawan.SelectedValue.ToString() + "' and d.type != 'GW') OR(d.team_id = '" + cBoxTimHome.SelectedValue.ToString() + "' and d.type = 'GW'), p.player_name,' ') as 'Player Name 2', if ((d.team_id = '" + cBoxTimLawan.SelectedValue.ToString() + "' and d.type != 'GW') OR(d.team_id = '" + cBoxTimHome.SelectedValue.ToString() + "' and d.type = 'GW'),if (d.type = 'CY','YELLOW CARD',if (d.type = 'CR', 'RED CARD',if (d.type = 'GO', 'GOAL',if (d.type = 'GP','GOAL PENALTY',if (d.type = 'GW', 'OWN GOAL','PENALTY MISS'))))),' ') as 'Type 2' from dmatch d, `match`, team t, team t1, player p where p.player_id = d.player_id and d.match_id =`match`.match_id and t.team_id =`match`.team_home and t1.team_id =`match`.team_away and `match`.team_home = '" + cBoxTimHome.SelectedValue.ToString() + "' and `match`.team_away = '" + cBoxTimLawan.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(matchResult);
            dataGridMatch.DataSource = matchResult;
        }
    }
}
