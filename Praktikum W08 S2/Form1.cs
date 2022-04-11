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

        public void Form1_Load_1(object sender, EventArgs e)
        {
            sqlConnect.Open();
            DataTable dtTeam = new DataTable();
            DataTable dtTeam2 = new DataTable();
            sqlQuery = "SELECT team_name as 'Nama Tim', manager_name as 'Nama Manager', player_name as 'Nama Captain' FROM manager, team, player WHERE team.manager_id = manager.manager_id and player.player_id = team.manager_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            sqlAdapter.Fill(dtTeam2);
            cBoxTimHome.DataSource = dtTeam;
            cBoxTimHome.DisplayMember = "Nama Tim";
            cBoxTimHome.ValueMember = "Nama Manager";

            cBoxTimLawan.DataSource = dtTeam2;
            cBoxTimLawan.DisplayMember = "Nama Tim";
            cBoxTimLawan.ValueMember = "Nama Manager";
        }
        public void cBoxTimHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = cBoxTimHome.SelectedIndex;
            DataSet dtset = new DataSet();
            sqlQuery = "SELECT team_name as 'Nama Tim', manager_name as 'Nama Manager', player_name as 'Nama Captain', concat(home_stadium, ', ', city) as 'Nama Stadium', capacity as 'Jumlah Kapasitas' FROM manager, team, player WHERE team.manager_id = manager.manager_id and player.player_id = team.captain_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtset);
            lblNamaManager1.Text = dtset.Tables[0].Rows[SelectedIndex]["Nama Manager"].ToString();
            lblNamaCaptain1.Text = dtset.Tables[0].Rows[SelectedIndex]["Nama Captain"].ToString();
            lblNamaStadium.Text = dtset.Tables[0].Rows[SelectedIndex]["Nama Stadium"].ToString();
            lblJumlahCapacity.Text = dtset.Tables[0].Rows[SelectedIndex]["Jumlah Kapasitas"].ToString();
        }

        private void cBoxTimLawan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = cBoxTimLawan.SelectedIndex;
            DataSet dtset = new DataSet();
            sqlQuery = "SELECT team_name as 'Nama Tim', manager_name as 'Nama Manager', player_name as 'Nama Captain', concat(home_stadium, ', ', city) as 'Nama Stadium', capacity as 'Jumlah Kapasitas' FROM manager, team, player WHERE team.manager_id = manager.manager_id and player.player_id = team.captain_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtset);
            lblNamaManager2.Text = dtset.Tables[0].Rows[SelectedIndex]["Nama Manager"].ToString();
            lblNamaCaptain2.Text = dtset.Tables[0].Rows[SelectedIndex]["Nama Captain"].ToString();
        }
    }
}
