using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace read_text_file_into_array_of_objects
{
    public partial class NewPlayer : Form
    {
        Player thisPlayer = new Player(); //create an identifier of type Player (doesn't contain anything yet)
        List<Player> players = new List<Player>(); //create an identifier for a list of players

        public NewPlayer()
        {
            InitializeComponent();
            readFileToList(); //read contents of file to a list so that when we write to it we aren't starting at element 0
        }

      

        private void imgAvatar1_Click(object sender, EventArgs e)
        {
            thisPlayer.Avatar = imgAvatar1.Image;
        }

        private void imgAvatar2_Click(object sender, EventArgs e)
        {
            thisPlayer.Avatar = imgAvatar2.Image;
        }

        private void btnWriteToBinaryFile_Click(object sender, EventArgs e)
        {
            thisPlayer.Name = txtName.Text;
            thisPlayer.Password = txtPassword.Text; //this wouldn't be there in reality as the user doesn't write the score
            players.Add(thisPlayer); //add the current player object to the list
            thisPlayer = new Player();
            Stream sw;
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                sw = File.OpenWrite("Players.bin"); //using openwrite will append to the file rather than overwriting
                bf.Serialize(sw, players);
                sw.Close();
            }
            catch (SerializationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            readFileToList();
        }

        private void readFileToList()
        {
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                sr = File.OpenRead("Players.bin");
                players = (List<Player>)bf.Deserialize(sr);
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool foundFlag = false;
            foreach(Player player in players)
            {
                if (player.Name == txtName.Text && player.Password==txtPassword.Text)
                {
                    foundFlag = true;
                    thisPlayer = player; 
                    MessageBox.Show("Login successful");
                }
            }

            if (foundFlag == false)
                MessageBox.Show("User does not exist");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
