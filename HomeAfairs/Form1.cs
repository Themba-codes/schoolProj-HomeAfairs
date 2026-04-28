using HomeAfairs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HomeAfairs
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private CitizenProfile currentProfile;
        private void btnValidate_Click(object sender, EventArgs e)
        {

            string name = nameText.Text.Trim();
            string id = idText.Text.Trim();
            

            //ensure namme and ID are filled in
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Enter a valid name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Enter a valid ID number.");
                return;
            }

            if (citizenshipCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your citizenship");
                return;
            }

            string citizenship = citizenshipCombo.SelectedItem.ToString();


            //create a citizen profile
            currentProfile = new CitizenProfile(name, id, citizenship);

            //validate id based on returned value
            string result = currentProfile.ValidateID();

            //update ID validation text
            IdValidationText.Text = result;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //ensure user has entered details before showing summary
            if (currentProfile == null)
            {
                MessageBox.Show("Please enter your details first.");
                return;
            }

            string validation = currentProfile.ValidateID();

            DateTime now = DateTime.Now;

            string profile = $"==== DIGITAL CITIZEN SUMMARY ====\r\n" +
                             $"Name: {currentProfile.FullName}\r\n" +
                             $"ID Number: {currentProfile.IDNumber}\r\n" +
                             $"Age: {currentProfile.Age}\r\n" +
                             $"Citizenship: {currentProfile.CitizenshipStatus}\r\n" +
                             $"Validation: {validation}\r\n" +
                             $"Processed at: Home Affairs Digital Desk\r\n" +
                             $"Timestamp: {now.ToString("yyyy/MM/dd HH:mm:ss")}";

            resultsText.Text = profile;
        }

        private void resultsText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
