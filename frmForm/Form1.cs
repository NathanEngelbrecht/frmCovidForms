using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmForm
{
    public partial class Form1 : Form
    {
        capture cp = new capture();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            cp.setID(txtID_Number.Text);
            cp.setName(txtName.Text);
            cp.setSurname(txtSurname.Text);
            cp.setMedicalAid(txtMedical_Aid.Text);
            cp.setRefDr(txtRef_Dr.Text);
            cp.setBloodType(cbBloodTypes.SelectedItem.ToString());
            cp.setAllergies(txtAllergies.Text);
            cp.setHadCovid(cbHadCovid.SelectedItem.ToString());
            cp.setCovidVaccine(cbHadCovid.SelectedItem.ToString());
            panel1.Hide();
            panel3.Show();
            addingList();
        }

        private void txtID_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2Submit_Click(object sender, EventArgs e)
        {
            cp.setHospName(txtHospital_Name.Text);
            cp.setHospAddress(txtAddress.Text);
            cp.setHospType(cbPriOrPub.SelectedItem.ToString());
            cp.setHospProvice(cbProvince.SelectedItem.ToString());
            panel2.Hide();
            panel1.Show();
            
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void lblOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addingList()
        {
            //adding items to the LISTBOX
            lblOutput.Items.Clear();

            string strTemp;

            strTemp = String.Format("Hospital Info: ");
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format(""); // Blank Space
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format("Name: " + cp.getHospName());
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format("Address: " + cp.getHospAddress());
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format("Type: " + cp.getHospType());
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format("Province: " + cp.getHospProvince());
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format(""); // Blank Space
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format("Patient Info: ");
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format(""); // Blank Space
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format("ID: " + cp.getID());
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format("Medical Aid: " + cp.getMedicalAid());
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format("Name: " + cp.getName());
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format("Surname: " + cp.getSurname());
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format("Referring doctor: " + cp.getRefDr());
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format("BloodType: " + cp.getBloodType());
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format("Allergies: " + cp.getAllergies());
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format("Had Covid: " + cp.getHadCovid());
            lblOutput.Items.Add(strTemp);

            strTemp = String.Format("Vaccine to Receive: " + cp.getCovidVaccine());
            lblOutput.Items.Add(strTemp);

        }

        private void lblGeneralInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
