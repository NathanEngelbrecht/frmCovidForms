
namespace frmForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCovidVaccine = new System.Windows.Forms.ComboBox();
            this.cbHadCovid = new System.Windows.Forms.ComboBox();
            this.cbBloodTypes = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.txtRef_Dr = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.lblHadVovid = new System.Windows.Forms.Label();
            this.lblCovidVaccine = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblRefDr = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtMedical_Aid = new System.Windows.Forms.TextBox();
            this.txtID_Number = new System.Windows.Forms.TextBox();
            this.lblMedicalAid = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblAdd_Patient = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.cbPriOrPub = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtHospital_Name = new System.Windows.Forms.TextBox();
            this.txtHospitalAddress = new System.Windows.Forms.Label();
            this.PriOrPub = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.Label();
            this.txtHospitalName = new System.Windows.Forms.Label();
            this.btn2Submit = new System.Windows.Forms.Button();
            this.lblGeneralInfo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblOutput = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblPatientInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(97, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(182, 37);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Covid Vaccine";
            this.lblHeading.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbCovidVaccine);
            this.panel1.Controls.Add(this.cbHadCovid);
            this.panel1.Controls.Add(this.cbBloodTypes);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtAllergies);
            this.panel1.Controls.Add(this.txtRef_Dr);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblAllergies);
            this.panel1.Controls.Add(this.lblHadVovid);
            this.panel1.Controls.Add(this.lblCovidVaccine);
            this.panel1.Controls.Add(this.lblBloodType);
            this.panel1.Controls.Add(this.lblRefDr);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblSurname);
            this.panel1.Controls.Add(this.txtMedical_Aid);
            this.panel1.Controls.Add(this.txtID_Number);
            this.panel1.Controls.Add(this.lblMedicalAid);
            this.panel1.Controls.Add(this.lblIDNumber);
            this.panel1.Controls.Add(this.lblAdd_Patient);
            this.panel1.Location = new System.Drawing.Point(39, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 491);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // cbCovidVaccine
            // 
            this.cbCovidVaccine.FormattingEnabled = true;
            this.cbCovidVaccine.Items.AddRange(new object[] {
            "India",
            "Chinese",
            "British"});
            this.cbCovidVaccine.Location = new System.Drawing.Point(177, 367);
            this.cbCovidVaccine.Name = "cbCovidVaccine";
            this.cbCovidVaccine.Size = new System.Drawing.Size(146, 23);
            this.cbCovidVaccine.TabIndex = 27;
            // 
            // cbHadCovid
            // 
            this.cbHadCovid.FormattingEnabled = true;
            this.cbHadCovid.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbHadCovid.Location = new System.Drawing.Point(177, 328);
            this.cbHadCovid.Name = "cbHadCovid";
            this.cbHadCovid.Size = new System.Drawing.Size(146, 23);
            this.cbHadCovid.TabIndex = 26;
            // 
            // cbBloodTypes
            // 
            this.cbBloodTypes.FormattingEnabled = true;
            this.cbBloodTypes.Items.AddRange(new object[] {
            "A",
            "B",
            "O"});
            this.cbBloodTypes.Location = new System.Drawing.Point(177, 251);
            this.cbBloodTypes.Name = "cbBloodTypes";
            this.cbBloodTypes.Size = new System.Drawing.Size(146, 23);
            this.cbBloodTypes.TabIndex = 25;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(248, 416);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 26);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAllergies
            // 
            this.txtAllergies.Location = new System.Drawing.Point(177, 289);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(146, 23);
            this.txtAllergies.TabIndex = 18;
            this.txtAllergies.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtRef_Dr
            // 
            this.txtRef_Dr.Location = new System.Drawing.Point(177, 212);
            this.txtRef_Dr.Name = "txtRef_Dr";
            this.txtRef_Dr.Size = new System.Drawing.Size(146, 23);
            this.txtRef_Dr.TabIndex = 16;
            this.txtRef_Dr.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(177, 173);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(146, 23);
            this.txtSurname.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(177, 137);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 23);
            this.txtName.TabIndex = 14;
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Location = new System.Drawing.Point(11, 297);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(55, 15);
            this.lblAllergies.TabIndex = 13;
            this.lblAllergies.Text = "Allergies:";
            // 
            // lblHadVovid
            // 
            this.lblHadVovid.AutoSize = true;
            this.lblHadVovid.Location = new System.Drawing.Point(11, 336);
            this.lblHadVovid.Name = "lblHadVovid";
            this.lblHadVovid.Size = new System.Drawing.Size(66, 15);
            this.lblHadVovid.TabIndex = 12;
            this.lblHadVovid.Text = "Had Covid:";
            // 
            // lblCovidVaccine
            // 
            this.lblCovidVaccine.AutoSize = true;
            this.lblCovidVaccine.Location = new System.Drawing.Point(11, 375);
            this.lblCovidVaccine.Name = "lblCovidVaccine";
            this.lblCovidVaccine.Size = new System.Drawing.Size(81, 15);
            this.lblCovidVaccine.TabIndex = 11;
            this.lblCovidVaccine.Text = "Covid Vaccine";
            this.lblCovidVaccine.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(11, 259);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(68, 15);
            this.lblBloodType.TabIndex = 10;
            this.lblBloodType.Text = "Blood Type:";
            // 
            // lblRefDr
            // 
            this.lblRefDr.AutoSize = true;
            this.lblRefDr.Location = new System.Drawing.Point(11, 220);
            this.lblRefDr.Name = "lblRefDr";
            this.lblRefDr.Size = new System.Drawing.Size(69, 15);
            this.lblRefDr.TabIndex = 9;
            this.lblRefDr.Text = "Refering Dr.";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 150);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 15);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name: ";
            this.lblName.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(11, 181);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(60, 15);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Surname: ";
            // 
            // txtMedical_Aid
            // 
            this.txtMedical_Aid.Location = new System.Drawing.Point(177, 99);
            this.txtMedical_Aid.Name = "txtMedical_Aid";
            this.txtMedical_Aid.Size = new System.Drawing.Size(146, 23);
            this.txtMedical_Aid.TabIndex = 6;
            // 
            // txtID_Number
            // 
            this.txtID_Number.Location = new System.Drawing.Point(177, 63);
            this.txtID_Number.Name = "txtID_Number";
            this.txtID_Number.Size = new System.Drawing.Size(146, 23);
            this.txtID_Number.TabIndex = 5;
            this.txtID_Number.TextChanged += new System.EventHandler(this.txtID_Number_TextChanged);
            // 
            // lblMedicalAid
            // 
            this.lblMedicalAid.AutoSize = true;
            this.lblMedicalAid.Location = new System.Drawing.Point(12, 107);
            this.lblMedicalAid.Name = "lblMedicalAid";
            this.lblMedicalAid.Size = new System.Drawing.Size(73, 15);
            this.lblMedicalAid.TabIndex = 3;
            this.lblMedicalAid.Text = "Medical Aid:";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(12, 71);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(68, 15);
            this.lblIDNumber.TabIndex = 2;
            this.lblIDNumber.Text = "ID Number:";
            // 
            // lblAdd_Patient
            // 
            this.lblAdd_Patient.AutoSize = true;
            this.lblAdd_Patient.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdd_Patient.Location = new System.Drawing.Point(12, 17);
            this.lblAdd_Patient.Name = "lblAdd_Patient";
            this.lblAdd_Patient.Size = new System.Drawing.Size(152, 37);
            this.lblAdd_Patient.TabIndex = 1;
            this.lblAdd_Patient.Text = "Patient Info";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbProvince);
            this.panel2.Controls.Add(this.cbPriOrPub);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtHospital_Name);
            this.panel2.Controls.Add(this.txtHospitalAddress);
            this.panel2.Controls.Add(this.PriOrPub);
            this.panel2.Controls.Add(this.txtProvince);
            this.panel2.Controls.Add(this.txtHospitalName);
            this.panel2.Controls.Add(this.btn2Submit);
            this.panel2.Controls.Add(this.lblGeneralInfo);
            this.panel2.Location = new System.Drawing.Point(39, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 491);
            this.panel2.TabIndex = 3;
            // 
            // cbProvince
            // 
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Items.AddRange(new object[] {
            "Eastern Cape",
            "Western Cape",
            "Freestate",
            "Gauteng",
            "Kwazulu Natal",
            "Northern Cape",
            "Northern Province",
            "North West",
            "Limpopo"});
            this.cbProvince.Location = new System.Drawing.Point(162, 231);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(146, 23);
            this.cbProvince.TabIndex = 31;
            // 
            // cbPriOrPub
            // 
            this.cbPriOrPub.FormattingEnabled = true;
            this.cbPriOrPub.Items.AddRange(new object[] {
            "Private",
            "Public"});
            this.cbPriOrPub.Location = new System.Drawing.Point(162, 187);
            this.cbPriOrPub.Name = "cbPriOrPub";
            this.cbPriOrPub.Size = new System.Drawing.Size(146, 23);
            this.cbPriOrPub.TabIndex = 30;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(162, 142);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(146, 23);
            this.txtAddress.TabIndex = 29;
            // 
            // txtHospital_Name
            // 
            this.txtHospital_Name.Location = new System.Drawing.Point(162, 96);
            this.txtHospital_Name.Name = "txtHospital_Name";
            this.txtHospital_Name.Size = new System.Drawing.Size(146, 23);
            this.txtHospital_Name.TabIndex = 25;
            // 
            // txtHospitalAddress
            // 
            this.txtHospitalAddress.AutoSize = true;
            this.txtHospitalAddress.Location = new System.Drawing.Point(37, 145);
            this.txtHospitalAddress.Name = "txtHospitalAddress";
            this.txtHospitalAddress.Size = new System.Drawing.Size(52, 15);
            this.txtHospitalAddress.TabIndex = 28;
            this.txtHospitalAddress.Text = "Address:";
            // 
            // PriOrPub
            // 
            this.PriOrPub.AutoSize = true;
            this.PriOrPub.Location = new System.Drawing.Point(37, 190);
            this.PriOrPub.Name = "PriOrPub";
            this.PriOrPub.Size = new System.Drawing.Size(96, 15);
            this.PriOrPub.TabIndex = 27;
            this.PriOrPub.Text = "Private or Public:";
            // 
            // txtProvince
            // 
            this.txtProvince.AutoSize = true;
            this.txtProvince.Location = new System.Drawing.Point(37, 234);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(53, 15);
            this.txtProvince.TabIndex = 26;
            this.txtProvince.Text = "Province";
            this.txtProvince.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtHospitalName
            // 
            this.txtHospitalName.AutoSize = true;
            this.txtHospitalName.Location = new System.Drawing.Point(37, 99);
            this.txtHospitalName.Name = "txtHospitalName";
            this.txtHospitalName.Size = new System.Drawing.Size(89, 15);
            this.txtHospitalName.TabIndex = 25;
            this.txtHospitalName.Text = "Hospital Name:";
            // 
            // btn2Submit
            // 
            this.btn2Submit.Location = new System.Drawing.Point(233, 419);
            this.btn2Submit.Name = "btn2Submit";
            this.btn2Submit.Size = new System.Drawing.Size(75, 23);
            this.btn2Submit.TabIndex = 25;
            this.btn2Submit.Text = "Submit";
            this.btn2Submit.UseVisualStyleBackColor = true;
            this.btn2Submit.Click += new System.EventHandler(this.btn2Submit_Click);
            // 
            // lblGeneralInfo
            // 
            this.lblGeneralInfo.AutoSize = true;
            this.lblGeneralInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGeneralInfo.Location = new System.Drawing.Point(37, 17);
            this.lblGeneralInfo.Name = "lblGeneralInfo";
            this.lblGeneralInfo.Size = new System.Drawing.Size(169, 37);
            this.lblGeneralInfo.TabIndex = 0;
            this.lblGeneralInfo.Text = "Hospital Info";
            this.lblGeneralInfo.Click += new System.EventHandler(this.lblGeneralInfo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblOutput);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.lblPatientInfo);
            this.panel3.Location = new System.Drawing.Point(39, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 491);
            this.panel3.TabIndex = 25;
            this.panel3.Visible = false;
            // 
            // lblOutput
            // 
            this.lblOutput.FormattingEnabled = true;
            this.lblOutput.ItemHeight = 15;
            this.lblOutput.Location = new System.Drawing.Point(0, 71);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(369, 334);
            this.lblOutput.TabIndex = 27;
            this.lblOutput.SelectedIndexChanged += new System.EventHandler(this.lblOutput_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(280, 420);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblPatientInfo
            // 
            this.lblPatientInfo.AutoSize = true;
            this.lblPatientInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPatientInfo.Location = new System.Drawing.Point(0, 17);
            this.lblPatientInfo.Name = "lblPatientInfo";
            this.lblPatientInfo.Size = new System.Drawing.Size(96, 37);
            this.lblPatientInfo.TabIndex = 1;
            this.lblPatientInfo.Text = "Report";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 572);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.Label lblHadVovid;
        private System.Windows.Forms.Label lblCovidVaccine;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblRefDr;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtMedical_Aid;
        private System.Windows.Forms.TextBox txtID_Number;
        private System.Windows.Forms.Label lblMedicalAid;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblAdd_Patient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.TextBox txtRef_Dr;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGeneralInfo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.ComboBox cbPriOrPub;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtHospital_Name;
        private System.Windows.Forms.Label txtHospitalAddress;
        private System.Windows.Forms.Label PriOrPub;
        private System.Windows.Forms.Label txtProvince;
        private System.Windows.Forms.Label txtHospitalName;
        private System.Windows.Forms.Button btn2Submit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblPatientInfo;
        private System.Windows.Forms.ComboBox cbCovidVaccine;
        private System.Windows.Forms.ComboBox cbHadCovid;
        private System.Windows.Forms.ComboBox cbBloodTypes;
        private System.Windows.Forms.ListBox lblOutput;
    }
}

