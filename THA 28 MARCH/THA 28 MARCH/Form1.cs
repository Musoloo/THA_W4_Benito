using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_28_MARCH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Team>teams = new List<Team>(); 

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Team team1 = new Team("Manchester United", "England", "Manchester");
            Team team2 = new Team("Liverpool", "England", "Liverpool");
            Team team3 = new Team("Intermilan", "Italy", "Milan");
            teams.Add(team1);
            teams.Add(team2);
            teams.Add(team3);
            foreach (Team team in teams)
            {
                if (!comboBox1.Items.Contains(team.teamCountry))
                {
                    comboBox1.Items.Add(team.teamCountry);
                }
            }
            team1.pemain.Add(new Player("01", "David De Gea", "Goalkeeper"));
            team1.pemain.Add(new Player("29", "Aaron Wan-Bissaka", "Defender"));
            team1.pemain.Add(new Player("05", "Harry Maguire", "Defender"));
            team1.pemain.Add(new Player("02", "Victor Lindelof", "Defender"));
            team1.pemain.Add(new Player("23", "Luke Shaw", "Defender"));
            team1.pemain.Add(new Player("17", "Fred", "Midfielder"));
            team1.pemain.Add(new Player("39", "Scott McTominay", "Midfielder"));
            team1.pemain.Add(new Player("18", "Bruno Fernandes", "Midfielder"));
            team1.pemain.Add(new Player("06", "Paul Pogba", "Midfielder"));
            team1.pemain.Add(new Player("10", "Marcus Rashford", "Forward"));
            team1.pemain.Add(new Player("07", "Edinson Cavani", "Forward"));

            team2.pemain.Add(new Player("01", "Alisson Becker", "Goalkeeper"));
            team2.pemain.Add(new Player("66", "Trent Alexander-Arnold", "Defender"));
            team2.pemain.Add(new Player("26", "Andrew Robertson", "Defender"));
            team2.pemain.Add(new Player("04", "Virgil van Dijk", "Defender"));
            team2.pemain.Add(new Player("32", "Joel Matip", "Defender"));
            team2.pemain.Add(new Player("03", "Fabinho", "Midfielder"));
            team2.pemain.Add(new Player("06", "Thiago Alcantara", "Midfielder"));
            team2.pemain.Add(new Player("14", "Jordan Henderson", "Midfielder"));
            team2.pemain.Add(new Player("10", "Sadio Mane", "Forward"));
            team2.pemain.Add(new Player("11", "Mohamed Salah", "Forward"));
            team2.pemain.Add(new Player("09", "Roberto Firmino", "Forward"));

            team3.pemain.Add(new Player("01", "Samir Handanovic", "Goalkeeper"));
            team3.pemain.Add(new Player("37", "Milan Skriniar", "Defender"));
            team3.pemain.Add(new Player("06", "Stefan de Vrij", "Defender"));
            team3.pemain.Add(new Player("95", "Alessandro Bastoni", "Defender"));
            team3.pemain.Add(new Player("02", "Achraf Hakimi", "Defender"));
            team3.pemain.Add(new Player("23", "Nicolo Barella", "Midfielder"));
            team3.pemain.Add(new Player("77", "Marcelo Brozovic", "Midfielder"));
            team3.pemain.Add(new Player("24", "Christian Eriksen", "Midfielder"));
            team3.pemain.Add(new Player("14", "Ivan Perisic", "Forward"));
            team3.pemain.Add(new Player("09", "Romelu Lukaku", "Forward"));
            team3.pemain.Add(new Player("10", "Lautaro Martinez", "Forward"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textbox_teamname.Text==""|| textbox_teamcountry.Text==""||textbox_teamcity.Text=="")
            {
                MessageBox.Show("Fill in the blanks!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                comboBox1.Items.Clear();
                Team team = new Team(textbox_teamname.Text,textbox_teamcountry.Text,textbox_teamcity.Text);
                teams.Add(team);
                foreach(Team tim in teams)
                {
                    if (!comboBox1.Items.Contains(tim.teamCountry))
                    {
                        comboBox1.Items.Add(tim.teamCountry);  

                    }
                    
                }
            }    
            

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            foreach (Team team in teams)
            {
             
                    if (comboBox1.SelectedItem.ToString() == team.teamCountry)
                    {
                        comboBox2.Items.Add(team.teamName);
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool jitt = false;
            if (comboBox3.Text == "" || textbox_playername.Text == "" || textbox_playernumber.Text == "")
            {
                MessageBox.Show("Fill in the blanks!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox2.Text=="")
                {
                    MessageBox.Show("Select Team!");
                }
                else
                {
                    foreach(Team team in teams)
                    {
                        if (team.teamName == comboBox2.Text)
                        {
                            foreach (Player benito in team.pemain)
                            {

                                if (benito.playerNum == textbox_playernumber.Text)
                                {
                                    jitt = true;

                                }


                            }
                            if (jitt == true)
                            {
                                MessageBox.Show("Re-Input!");
                            }
                            else
                                team.pemain.Add(new Player
                                {
                                    playerNum = textbox_playernumber.Text,
                                    playerName = textbox_playername.Text,
                                    playerPos = comboBox3.Text,
                                });
                                


                        }

                    }
                }
            }

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Team team in teams)
            {
                if (team.teamName.ToLower() == comboBox2.Text.ToLower())
                {
                    foreach (Player benito in team.pemain)
                    {
                        listBox1.Items.Add(($"({benito.playerNum}) {benito.playerName}, {benito.playerPos}"));
                        listBox1.Sorted = true;
                    }
                    break;
                }
               
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count <=11)
            {
                MessageBox.Show("Player cannot be less than 11 players!");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           






        }








        }
    }

