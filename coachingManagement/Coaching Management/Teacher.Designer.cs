namespace Coaching_Management
{
    partial class Teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.teacher_tabControl = new System.Windows.Forms.TabControl();
            this.Profile = new System.Windows.Forms.TabPage();
            this.logout_button1 = new System.Windows.Forms.Button();
            this.idlabel = new System.Windows.Forms.Label();
            this.presentaddresslabel = new System.Windows.Forms.Label();
            this.permanentaddresslabel = new System.Windows.Forms.Label();
            this.positionlabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.mobilenolabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.confirmpasswordlabel = new System.Windows.Forms.Label();
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.D_O_B = new System.Windows.Forms.TextBox();
            this.gndr_groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonfemale = new System.Windows.Forms.RadioButton();
            this.radioButtonmale = new System.Windows.Forms.RadioButton();
            this.radioButtonothers = new System.Windows.Forms.RadioButton();
            this.pictureBox_profile_image = new System.Windows.Forms.PictureBox();
            this.present_address = new System.Windows.Forms.TextBox();
            this.permanent_address = new System.Windows.Forms.TextBox();
            this.e_mail = new System.Windows.Forms.TextBox();
            this.posi_tion = new System.Windows.Forms.TextBox();
            this.ID_No = new System.Windows.Forms.TextBox();
            this.mobile__no = new System.Windows.Forms.TextBox();
            this.Confirm_Password = new System.Windows.Forms.TextBox();
            this.Pass_Word = new System.Windows.Forms.TextBox();
            this.User_Name = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.Course = new System.Windows.Forms.TabPage();
            this.register_dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.addMarks = new System.Windows.Forms.TabPage();
            this.logout_addMarks_button = new System.Windows.Forms.Button();
            this.grade_label = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.gpa_label = new System.Windows.Forms.Label();
            this.marks_label = new System.Windows.Forms.Label();
            this.GPA = new System.Windows.Forms.TextBox();
            this.Marks = new System.Windows.Forms.TextBox();
            this.std_id_label = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.marks_dataGridView = new System.Windows.Forms.DataGridView();
            this.teacher_tabControl.SuspendLayout();
            this.Profile.SuspendLayout();
            this.gndr_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile_image)).BeginInit();
            this.Course.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.register_dataGridView)).BeginInit();
            this.addMarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marks_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teacher_tabControl
            // 
            this.teacher_tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.teacher_tabControl.Controls.Add(this.Profile);
            this.teacher_tabControl.Controls.Add(this.Course);
            this.teacher_tabControl.Controls.Add(this.addMarks);
            this.teacher_tabControl.ItemSize = new System.Drawing.Size(95, 30);
            this.teacher_tabControl.Location = new System.Drawing.Point(0, 0);
            this.teacher_tabControl.Name = "teacher_tabControl";
            this.teacher_tabControl.SelectedIndex = 0;
            this.teacher_tabControl.Size = new System.Drawing.Size(1353, 773);
            this.teacher_tabControl.TabIndex = 0;
            this.teacher_tabControl.SelectedIndexChanged += new System.EventHandler(this.teacher_tabPage_dataGridview);
            // 
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.Color.Black;
            this.Profile.Controls.Add(this.logout_button1);
            this.Profile.Controls.Add(this.idlabel);
            this.Profile.Controls.Add(this.presentaddresslabel);
            this.Profile.Controls.Add(this.permanentaddresslabel);
            this.Profile.Controls.Add(this.positionlabel);
            this.Profile.Controls.Add(this.passwordlabel);
            this.Profile.Controls.Add(this.usernamelabel);
            this.Profile.Controls.Add(this.lastnamelabel);
            this.Profile.Controls.Add(this.mobilenolabel);
            this.Profile.Controls.Add(this.emaillabel);
            this.Profile.Controls.Add(this.confirmpasswordlabel);
            this.Profile.Controls.Add(this.firstnamelabel);
            this.Profile.Controls.Add(this.D_O_B);
            this.Profile.Controls.Add(this.gndr_groupBox);
            this.Profile.Controls.Add(this.pictureBox_profile_image);
            this.Profile.Controls.Add(this.present_address);
            this.Profile.Controls.Add(this.permanent_address);
            this.Profile.Controls.Add(this.e_mail);
            this.Profile.Controls.Add(this.posi_tion);
            this.Profile.Controls.Add(this.ID_No);
            this.Profile.Controls.Add(this.mobile__no);
            this.Profile.Controls.Add(this.Confirm_Password);
            this.Profile.Controls.Add(this.Pass_Word);
            this.Profile.Controls.Add(this.User_Name);
            this.Profile.Controls.Add(this.last_name);
            this.Profile.Controls.Add(this.label2);
            this.Profile.Controls.Add(this.first_name);
            this.Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile.Location = new System.Drawing.Point(4, 34);
            this.Profile.Name = "Profile";
            this.Profile.Padding = new System.Windows.Forms.Padding(3);
            this.Profile.Size = new System.Drawing.Size(1345, 735);
            this.Profile.TabIndex = 0;
            this.Profile.Text = "       Profile       ";
            // 
            // logout_button1
            // 
            this.logout_button1.BackColor = System.Drawing.Color.Black;
            this.logout_button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logout_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logout_button1.Location = new System.Drawing.Point(1199, 15);
            this.logout_button1.Name = "logout_button1";
            this.logout_button1.Size = new System.Drawing.Size(128, 38);
            this.logout_button1.TabIndex = 78;
            this.logout_button1.Text = "Logout";
            this.logout_button1.UseVisualStyleBackColor = false;
            this.logout_button1.Click += new System.EventHandler(this.logout_button_Click);
            this.logout_button1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.logout_button1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idlabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.idlabel.Location = new System.Drawing.Point(81, 589);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(94, 38);
            this.idlabel.TabIndex = 74;
            this.idlabel.Text = "ID No";
            // 
            // presentaddresslabel
            // 
            this.presentaddresslabel.AutoSize = true;
            this.presentaddresslabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.presentaddresslabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentaddresslabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.presentaddresslabel.Location = new System.Drawing.Point(81, 526);
            this.presentaddresslabel.Name = "presentaddresslabel";
            this.presentaddresslabel.Size = new System.Drawing.Size(227, 38);
            this.presentaddresslabel.TabIndex = 73;
            this.presentaddresslabel.Text = "Present Address";
            // 
            // permanentaddresslabel
            // 
            this.permanentaddresslabel.AutoSize = true;
            this.permanentaddresslabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.permanentaddresslabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permanentaddresslabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.permanentaddresslabel.Location = new System.Drawing.Point(80, 442);
            this.permanentaddresslabel.Name = "permanentaddresslabel";
            this.permanentaddresslabel.Size = new System.Drawing.Size(272, 38);
            this.permanentaddresslabel.TabIndex = 75;
            this.permanentaddresslabel.Text = "Permanent Address";
            // 
            // positionlabel
            // 
            this.positionlabel.AutoSize = true;
            this.positionlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.positionlabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.positionlabel.Location = new System.Drawing.Point(81, 633);
            this.positionlabel.Name = "positionlabel";
            this.positionlabel.Size = new System.Drawing.Size(123, 38);
            this.positionlabel.TabIndex = 72;
            this.positionlabel.Text = "Position";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordlabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordlabel.Location = new System.Drawing.Point(81, 198);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(139, 38);
            this.passwordlabel.TabIndex = 71;
            this.passwordlabel.Text = "Password";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usernamelabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernamelabel.Location = new System.Drawing.Point(81, 158);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(161, 38);
            this.usernamelabel.TabIndex = 70;
            this.usernamelabel.Text = "User Name";
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.AutoSize = true;
            this.lastnamelabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lastnamelabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnamelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastnamelabel.Location = new System.Drawing.Point(81, 116);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(155, 38);
            this.lastnamelabel.TabIndex = 69;
            this.lastnamelabel.Text = "Last Name";
            // 
            // mobilenolabel
            // 
            this.mobilenolabel.AutoSize = true;
            this.mobilenolabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mobilenolabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilenolabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mobilenolabel.Location = new System.Drawing.Point(81, 331);
            this.mobilenolabel.Name = "mobilenolabel";
            this.mobilenolabel.Size = new System.Drawing.Size(156, 38);
            this.mobilenolabel.TabIndex = 68;
            this.mobilenolabel.Text = "Mobile No";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emaillabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emaillabel.Location = new System.Drawing.Point(81, 286);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(89, 38);
            this.emaillabel.TabIndex = 66;
            this.emaillabel.Text = "Email";
            // 
            // confirmpasswordlabel
            // 
            this.confirmpasswordlabel.AutoSize = true;
            this.confirmpasswordlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confirmpasswordlabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasswordlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmpasswordlabel.Location = new System.Drawing.Point(81, 241);
            this.confirmpasswordlabel.Name = "confirmpasswordlabel";
            this.confirmpasswordlabel.Size = new System.Drawing.Size(254, 38);
            this.confirmpasswordlabel.TabIndex = 67;
            this.confirmpasswordlabel.Text = "Confirm Password";
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstnamelabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnamelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstnamelabel.Location = new System.Drawing.Point(82, 69);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(160, 38);
            this.firstnamelabel.TabIndex = 65;
            this.firstnamelabel.Text = "First Name";
            // 
            // D_O_B
            // 
            this.D_O_B.BackColor = System.Drawing.Color.White;
            this.D_O_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_O_B.ForeColor = System.Drawing.Color.Black;
            this.D_O_B.Location = new System.Drawing.Point(368, 377);
            this.D_O_B.Name = "D_O_B";
            this.D_O_B.ReadOnly = true;
            this.D_O_B.Size = new System.Drawing.Size(541, 32);
            this.D_O_B.TabIndex = 64;
            this.D_O_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gndr_groupBox
            // 
            this.gndr_groupBox.Controls.Add(this.radioButtonfemale);
            this.gndr_groupBox.Controls.Add(this.radioButtonmale);
            this.gndr_groupBox.Controls.Add(this.radioButtonothers);
            this.gndr_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gndr_groupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gndr_groupBox.Location = new System.Drawing.Point(1052, 448);
            this.gndr_groupBox.Name = "gndr_groupBox";
            this.gndr_groupBox.Size = new System.Drawing.Size(220, 202);
            this.gndr_groupBox.TabIndex = 61;
            this.gndr_groupBox.TabStop = false;
            this.gndr_groupBox.Text = "Gender";
            // 
            // radioButtonfemale
            // 
            this.radioButtonfemale.AutoSize = true;
            this.radioButtonfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonfemale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonfemale.Location = new System.Drawing.Point(62, 94);
            this.radioButtonfemale.Name = "radioButtonfemale";
            this.radioButtonfemale.Size = new System.Drawing.Size(122, 33);
            this.radioButtonfemale.TabIndex = 1;
            this.radioButtonfemale.TabStop = true;
            this.radioButtonfemale.Text = "Female";
            this.radioButtonfemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonmale
            // 
            this.radioButtonmale.AutoSize = true;
            this.radioButtonmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonmale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonmale.Location = new System.Drawing.Point(62, 50);
            this.radioButtonmale.Name = "radioButtonmale";
            this.radioButtonmale.Size = new System.Drawing.Size(91, 33);
            this.radioButtonmale.TabIndex = 0;
            this.radioButtonmale.TabStop = true;
            this.radioButtonmale.Text = "Male";
            this.radioButtonmale.UseVisualStyleBackColor = true;
            // 
            // radioButtonothers
            // 
            this.radioButtonothers.AutoSize = true;
            this.radioButtonothers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonothers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonothers.Location = new System.Drawing.Point(62, 136);
            this.radioButtonothers.Name = "radioButtonothers";
            this.radioButtonothers.Size = new System.Drawing.Size(112, 33);
            this.radioButtonothers.TabIndex = 2;
            this.radioButtonothers.TabStop = true;
            this.radioButtonothers.Text = "Others";
            this.radioButtonothers.UseVisualStyleBackColor = true;
            // 
            // pictureBox_profile_image
            // 
            this.pictureBox_profile_image.BackColor = System.Drawing.Color.Bisque;
            this.pictureBox_profile_image.Image = global::Coaching_Management.Properties.Resources.uploadimage;
            this.pictureBox_profile_image.Location = new System.Drawing.Point(1052, 111);
            this.pictureBox_profile_image.Name = "pictureBox_profile_image";
            this.pictureBox_profile_image.Size = new System.Drawing.Size(220, 217);
            this.pictureBox_profile_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_profile_image.TabIndex = 52;
            this.pictureBox_profile_image.TabStop = false;
            // 
            // present_address
            // 
            this.present_address.BackColor = System.Drawing.Color.White;
            this.present_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.present_address.ForeColor = System.Drawing.Color.Black;
            this.present_address.Location = new System.Drawing.Point(368, 506);
            this.present_address.Multiline = true;
            this.present_address.Name = "present_address";
            this.present_address.ReadOnly = true;
            this.present_address.Size = new System.Drawing.Size(541, 76);
            this.present_address.TabIndex = 60;
            this.present_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // permanent_address
            // 
            this.permanent_address.BackColor = System.Drawing.Color.White;
            this.permanent_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permanent_address.ForeColor = System.Drawing.Color.Black;
            this.permanent_address.Location = new System.Drawing.Point(368, 421);
            this.permanent_address.Multiline = true;
            this.permanent_address.Name = "permanent_address";
            this.permanent_address.ReadOnly = true;
            this.permanent_address.Size = new System.Drawing.Size(541, 77);
            this.permanent_address.TabIndex = 59;
            this.permanent_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // e_mail
            // 
            this.e_mail.BackColor = System.Drawing.Color.White;
            this.e_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_mail.ForeColor = System.Drawing.Color.Black;
            this.e_mail.Location = new System.Drawing.Point(368, 286);
            this.e_mail.Name = "e_mail";
            this.e_mail.ReadOnly = true;
            this.e_mail.Size = new System.Drawing.Size(541, 32);
            this.e_mail.TabIndex = 57;
            this.e_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // posi_tion
            // 
            this.posi_tion.BackColor = System.Drawing.Color.White;
            this.posi_tion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F);
            this.posi_tion.ForeColor = System.Drawing.Color.Black;
            this.posi_tion.Location = new System.Drawing.Point(368, 635);
            this.posi_tion.Name = "posi_tion";
            this.posi_tion.ReadOnly = true;
            this.posi_tion.Size = new System.Drawing.Size(541, 32);
            this.posi_tion.TabIndex = 63;
            this.posi_tion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ID_No
            // 
            this.ID_No.BackColor = System.Drawing.Color.White;
            this.ID_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F);
            this.ID_No.ForeColor = System.Drawing.Color.Black;
            this.ID_No.Location = new System.Drawing.Point(368, 594);
            this.ID_No.Name = "ID_No";
            this.ID_No.ReadOnly = true;
            this.ID_No.Size = new System.Drawing.Size(541, 32);
            this.ID_No.TabIndex = 62;
            this.ID_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mobile__no
            // 
            this.mobile__no.BackColor = System.Drawing.Color.White;
            this.mobile__no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile__no.ForeColor = System.Drawing.Color.Black;
            this.mobile__no.Location = new System.Drawing.Point(368, 331);
            this.mobile__no.Name = "mobile__no";
            this.mobile__no.ReadOnly = true;
            this.mobile__no.Size = new System.Drawing.Size(541, 32);
            this.mobile__no.TabIndex = 58;
            this.mobile__no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Confirm_Password
            // 
            this.Confirm_Password.BackColor = System.Drawing.Color.White;
            this.Confirm_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_Password.ForeColor = System.Drawing.Color.Black;
            this.Confirm_Password.Location = new System.Drawing.Point(368, 241);
            this.Confirm_Password.Name = "Confirm_Password";
            this.Confirm_Password.ReadOnly = true;
            this.Confirm_Password.Size = new System.Drawing.Size(541, 32);
            this.Confirm_Password.TabIndex = 56;
            this.Confirm_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pass_Word
            // 
            this.Pass_Word.BackColor = System.Drawing.Color.White;
            this.Pass_Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_Word.ForeColor = System.Drawing.Color.Black;
            this.Pass_Word.Location = new System.Drawing.Point(368, 198);
            this.Pass_Word.Name = "Pass_Word";
            this.Pass_Word.ReadOnly = true;
            this.Pass_Word.Size = new System.Drawing.Size(541, 32);
            this.Pass_Word.TabIndex = 55;
            this.Pass_Word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // User_Name
            // 
            this.User_Name.BackColor = System.Drawing.Color.White;
            this.User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name.ForeColor = System.Drawing.Color.Black;
            this.User_Name.Location = new System.Drawing.Point(368, 158);
            this.User_Name.Name = "User_Name";
            this.User_Name.ReadOnly = true;
            this.User_Name.Size = new System.Drawing.Size(541, 32);
            this.User_Name.TabIndex = 53;
            this.User_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // last_name
            // 
            this.last_name.BackColor = System.Drawing.Color.White;
            this.last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name.ForeColor = System.Drawing.Color.Black;
            this.last_name.Location = new System.Drawing.Point(368, 116);
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            this.last_name.Size = new System.Drawing.Size(541, 32);
            this.last_name.TabIndex = 51;
            this.last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(82, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 38);
            this.label2.TabIndex = 54;
            this.label2.Text = "Date of Birth";
            // 
            // first_name
            // 
            this.first_name.BackColor = System.Drawing.Color.White;
            this.first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name.ForeColor = System.Drawing.Color.Black;
            this.first_name.Location = new System.Drawing.Point(368, 73);
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            this.first_name.Size = new System.Drawing.Size(541, 32);
            this.first_name.TabIndex = 50;
            this.first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Course
            // 
            this.Course.BackColor = System.Drawing.Color.Black;
            this.Course.Controls.Add(this.register_dataGridView);
            this.Course.Controls.Add(this.button1);
            this.Course.Controls.Add(this.search_textBox);
            this.Course.Location = new System.Drawing.Point(4, 34);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(1345, 735);
            this.Course.TabIndex = 1;
            this.Course.Text = "  Register Student  ";
            // 
            // register_dataGridView
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.register_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.register_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.register_dataGridView.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.register_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.register_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.register_dataGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.register_dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_dataGridView.Location = new System.Drawing.Point(3, 49);
            this.register_dataGridView.Name = "register_dataGridView";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.register_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.register_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.register_dataGridView.RowTemplate.Height = 50;
            this.register_dataGridView.Size = new System.Drawing.Size(1334, 678);
            this.register_dataGridView.TabIndex = 80;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1209, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 38);
            this.button1.TabIndex = 79;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.logout_button_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // search_textBox
            // 
            this.search_textBox.BackColor = System.Drawing.Color.White;
            this.search_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textBox.ForeColor = System.Drawing.Color.DarkGray;
            this.search_textBox.Location = new System.Drawing.Point(3, 5);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(1200, 38);
            this.search_textBox.TabIndex = 19;
            this.search_textBox.Text = "Search by UserName or IDNo";
            this.search_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search_textBox.TextChanged += new System.EventHandler(this.search_textBox_TextChanged);
            this.search_textBox.Enter += new System.EventHandler(this.textbox_enter);
            this.search_textBox.Leave += new System.EventHandler(this.textbox_leave);
            // 
            // addMarks
            // 
            this.addMarks.BackColor = System.Drawing.Color.Black;
            this.addMarks.Controls.Add(this.logout_addMarks_button);
            this.addMarks.Controls.Add(this.grade_label);
            this.addMarks.Controls.Add(this.Grade);
            this.addMarks.Controls.Add(this.add_button);
            this.addMarks.Controls.Add(this.reset_btn);
            this.addMarks.Controls.Add(this.gpa_label);
            this.addMarks.Controls.Add(this.marks_label);
            this.addMarks.Controls.Add(this.GPA);
            this.addMarks.Controls.Add(this.Marks);
            this.addMarks.Controls.Add(this.std_id_label);
            this.addMarks.Controls.Add(this.StudentID);
            this.addMarks.Controls.Add(this.marks_dataGridView);
            this.addMarks.Location = new System.Drawing.Point(4, 34);
            this.addMarks.Name = "addMarks";
            this.addMarks.Size = new System.Drawing.Size(1345, 735);
            this.addMarks.TabIndex = 2;
            this.addMarks.Text = "   Add Marks   ";
            // 
            // logout_addMarks_button
            // 
            this.logout_addMarks_button.BackColor = System.Drawing.Color.Black;
            this.logout_addMarks_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logout_addMarks_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_addMarks_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_addMarks_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logout_addMarks_button.Location = new System.Drawing.Point(8, 5);
            this.logout_addMarks_button.Name = "logout_addMarks_button";
            this.logout_addMarks_button.Size = new System.Drawing.Size(128, 38);
            this.logout_addMarks_button.TabIndex = 91;
            this.logout_addMarks_button.Text = "Logout";
            this.logout_addMarks_button.UseVisualStyleBackColor = false;
            this.logout_addMarks_button.Click += new System.EventHandler(this.logout_button_Click);
            this.logout_addMarks_button.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.logout_addMarks_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // grade_label
            // 
            this.grade_label.AutoSize = true;
            this.grade_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grade_label.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade_label.Location = new System.Drawing.Point(49, 280);
            this.grade_label.Name = "grade_label";
            this.grade_label.Size = new System.Drawing.Size(95, 38);
            this.grade_label.TabIndex = 90;
            this.grade_label.Text = "Grade";
            // 
            // Grade
            // 
            this.Grade.BackColor = System.Drawing.Color.White;
            this.Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grade.ForeColor = System.Drawing.Color.Black;
            this.Grade.Location = new System.Drawing.Point(244, 286);
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Size = new System.Drawing.Size(541, 32);
            this.Grade.TabIndex = 89;
            this.Grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.Black;
            this.add_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_button.Location = new System.Drawing.Point(523, 418);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(128, 38);
            this.add_button.TabIndex = 88;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            this.add_button.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.add_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Black;
            this.reset_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reset_btn.Location = new System.Drawing.Point(657, 418);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(128, 38);
            this.reset_btn.TabIndex = 88;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            this.reset_btn.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.reset_btn.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // gpa_label
            // 
            this.gpa_label.AutoSize = true;
            this.gpa_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpa_label.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpa_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpa_label.Location = new System.Drawing.Point(49, 341);
            this.gpa_label.Name = "gpa_label";
            this.gpa_label.Size = new System.Drawing.Size(72, 38);
            this.gpa_label.TabIndex = 87;
            this.gpa_label.Text = "GPA";
            // 
            // marks_label
            // 
            this.marks_label.AutoSize = true;
            this.marks_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.marks_label.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marks_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.marks_label.Location = new System.Drawing.Point(49, 220);
            this.marks_label.Name = "marks_label";
            this.marks_label.Size = new System.Drawing.Size(98, 38);
            this.marks_label.TabIndex = 86;
            this.marks_label.Text = "Marks";
            // 
            // GPA
            // 
            this.GPA.BackColor = System.Drawing.Color.White;
            this.GPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPA.ForeColor = System.Drawing.Color.Black;
            this.GPA.Location = new System.Drawing.Point(244, 347);
            this.GPA.Name = "GPA";
            this.GPA.ReadOnly = true;
            this.GPA.Size = new System.Drawing.Size(541, 32);
            this.GPA.TabIndex = 85;
            this.GPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Marks
            // 
            this.Marks.BackColor = System.Drawing.Color.White;
            this.Marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marks.ForeColor = System.Drawing.Color.Black;
            this.Marks.Location = new System.Drawing.Point(244, 222);
            this.Marks.Name = "Marks";
            this.Marks.Size = new System.Drawing.Size(541, 32);
            this.Marks.TabIndex = 84;
            this.Marks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Marks.TextChanged += new System.EventHandler(this.Marks_TextChanged);
            this.Marks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Marks_KeyPress);
            // 
            // std_id_label
            // 
            this.std_id_label.AutoSize = true;
            this.std_id_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.std_id_label.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_id_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.std_id_label.Location = new System.Drawing.Point(51, 156);
            this.std_id_label.Name = "std_id_label";
            this.std_id_label.Size = new System.Drawing.Size(158, 38);
            this.std_id_label.TabIndex = 83;
            this.std_id_label.Text = "Student ID";
            // 
            // StudentID
            // 
            this.StudentID.BackColor = System.Drawing.Color.White;
            this.StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F);
            this.StudentID.ForeColor = System.Drawing.Color.Black;
            this.StudentID.Location = new System.Drawing.Point(244, 161);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(541, 32);
            this.StudentID.TabIndex = 82;
            this.StudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // marks_dataGridView
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.marks_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.marks_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.marks_dataGridView.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.marks_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.marks_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.marks_dataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.marks_dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.marks_dataGridView.Location = new System.Drawing.Point(845, 3);
            this.marks_dataGridView.Name = "marks_dataGridView";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.marks_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.marks_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.marks_dataGridView.RowTemplate.Height = 50;
            this.marks_dataGridView.Size = new System.Drawing.Size(495, 729);
            this.marks_dataGridView.TabIndex = 81;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1353, 773);
            this.Controls.Add(this.teacher_tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.teacher_tabControl.ResumeLayout(false);
            this.Profile.ResumeLayout(false);
            this.Profile.PerformLayout();
            this.gndr_groupBox.ResumeLayout(false);
            this.gndr_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile_image)).EndInit();
            this.Course.ResumeLayout(false);
            this.Course.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.register_dataGridView)).EndInit();
            this.addMarks.ResumeLayout(false);
            this.addMarks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marks_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl teacher_tabControl;
        private System.Windows.Forms.TabPage Profile;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label presentaddresslabel;
        private System.Windows.Forms.Label permanentaddresslabel;
        private System.Windows.Forms.Label positionlabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label lastnamelabel;
        private System.Windows.Forms.Label mobilenolabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label confirmpasswordlabel;
        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.TextBox D_O_B;
        private System.Windows.Forms.GroupBox gndr_groupBox;
        private System.Windows.Forms.RadioButton radioButtonfemale;
        private System.Windows.Forms.RadioButton radioButtonmale;
        private System.Windows.Forms.RadioButton radioButtonothers;
        private System.Windows.Forms.PictureBox pictureBox_profile_image;
        private System.Windows.Forms.TextBox present_address;
        private System.Windows.Forms.TextBox permanent_address;
        private System.Windows.Forms.TextBox e_mail;
        private System.Windows.Forms.TextBox posi_tion;
        private System.Windows.Forms.TextBox ID_No;
        private System.Windows.Forms.TextBox mobile__no;
        private System.Windows.Forms.TextBox Confirm_Password;
        private System.Windows.Forms.TextBox Pass_Word;
        private System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TabPage Course;
        private System.Windows.Forms.Button logout_button1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.DataGridView register_dataGridView;
        private System.Windows.Forms.TabPage addMarks;
        private System.Windows.Forms.DataGridView marks_dataGridView;
        private System.Windows.Forms.Label gpa_label;
        private System.Windows.Forms.Label marks_label;
        private System.Windows.Forms.TextBox GPA;
        private System.Windows.Forms.TextBox Marks;
        private System.Windows.Forms.Label std_id_label;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Label grade_label;
        private System.Windows.Forms.TextBox Grade;
        private System.Windows.Forms.Button logout_addMarks_button;
    }
}