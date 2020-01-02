namespace Coaching_Management
{
    partial class Student
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
            this.student_tabControl = new System.Windows.Forms.TabControl();
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
            this.add_course = new System.Windows.Forms.TabPage();
            this.addCourse_groupBox = new System.Windows.Forms.GroupBox();
            this.select_course_comboBox = new System.Windows.Forms.ComboBox();
            this.duration_label = new System.Windows.Forms.Label();
            this.CourseDuration = new System.Windows.Forms.TextBox();
            this.register_crs_button = new System.Windows.Forms.Button();
            this.description_label = new System.Windows.Forms.Label();
            this.CourseDescription = new System.Windows.Forms.TextBox();
            this.teacherId_label = new System.Windows.Forms.Label();
            this.courseCode_label = new System.Windows.Forms.Label();
            this.courseSelection_label = new System.Windows.Forms.Label();
            this.TeacherID = new System.Windows.Forms.TextBox();
            this.CourseCode = new System.Windows.Forms.TextBox();
            this.reg_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.withdrawCourse = new System.Windows.Forms.TabPage();
            this.widraw_label = new System.Windows.Forms.Label();
            this.withdraw_crs_groupBox = new System.Windows.Forms.GroupBox();
            this.withdraw_select_course_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.withdraw_course_duration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.withdraw_crs_button = new System.Windows.Forms.Button();
            this.withdraw_course_description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.withdraw_teacherId = new System.Windows.Forms.TextBox();
            this.withdraw_course_code = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.student_tabControl.SuspendLayout();
            this.Profile.SuspendLayout();
            this.gndr_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile_image)).BeginInit();
            this.add_course.SuspendLayout();
            this.addCourse_groupBox.SuspendLayout();
            this.withdrawCourse.SuspendLayout();
            this.withdraw_crs_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // student_tabControl
            // 
            this.student_tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.student_tabControl.Controls.Add(this.Profile);
            this.student_tabControl.Controls.Add(this.add_course);
            this.student_tabControl.Controls.Add(this.withdrawCourse);
            this.student_tabControl.ItemSize = new System.Drawing.Size(95, 30);
            this.student_tabControl.Location = new System.Drawing.Point(0, 0);
            this.student_tabControl.Name = "student_tabControl";
            this.student_tabControl.SelectedIndex = 0;
            this.student_tabControl.Size = new System.Drawing.Size(1353, 773);
            this.student_tabControl.TabIndex = 1;
            this.student_tabControl.SelectedIndexChanged += new System.EventHandler(this.student_tabControl_SelectedIndexChanged);
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
            this.logout_button1.Location = new System.Drawing.Point(1209, 6);
            this.logout_button1.Name = "logout_button1";
            this.logout_button1.Size = new System.Drawing.Size(128, 38);
            this.logout_button1.TabIndex = 76;
            this.logout_button1.Text = "Logout";
            this.logout_button1.UseVisualStyleBackColor = false;
            this.logout_button1.Click += new System.EventHandler(this.studentLogout);
            this.logout_button1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.logout_button1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idlabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.idlabel.Location = new System.Drawing.Point(81, 555);
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
            this.presentaddresslabel.Location = new System.Drawing.Point(81, 491);
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
            this.permanentaddresslabel.Location = new System.Drawing.Point(81, 407);
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
            this.positionlabel.Location = new System.Drawing.Point(81, 599);
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
            this.passwordlabel.Location = new System.Drawing.Point(81, 163);
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
            this.usernamelabel.Location = new System.Drawing.Point(81, 123);
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
            this.lastnamelabel.Location = new System.Drawing.Point(81, 81);
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
            this.mobilenolabel.Location = new System.Drawing.Point(81, 296);
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
            this.emaillabel.Location = new System.Drawing.Point(81, 251);
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
            this.confirmpasswordlabel.Location = new System.Drawing.Point(81, 206);
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
            this.firstnamelabel.Location = new System.Drawing.Point(82, 34);
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
            this.D_O_B.Location = new System.Drawing.Point(368, 342);
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
            this.gndr_groupBox.Location = new System.Drawing.Point(1042, 418);
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
            this.pictureBox_profile_image.Location = new System.Drawing.Point(1042, 81);
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
            this.present_address.Location = new System.Drawing.Point(366, 471);
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
            this.permanent_address.Location = new System.Drawing.Point(368, 386);
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
            this.e_mail.Location = new System.Drawing.Point(368, 251);
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
            this.posi_tion.Location = new System.Drawing.Point(366, 601);
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
            this.ID_No.Location = new System.Drawing.Point(366, 560);
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
            this.mobile__no.Location = new System.Drawing.Point(368, 296);
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
            this.Confirm_Password.Location = new System.Drawing.Point(368, 206);
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
            this.Pass_Word.Location = new System.Drawing.Point(368, 163);
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
            this.User_Name.Location = new System.Drawing.Point(368, 123);
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
            this.last_name.Location = new System.Drawing.Point(368, 81);
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
            this.label2.Location = new System.Drawing.Point(82, 342);
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
            this.first_name.Location = new System.Drawing.Point(368, 38);
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            this.first_name.Size = new System.Drawing.Size(541, 32);
            this.first_name.TabIndex = 50;
            this.first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add_course
            // 
            this.add_course.BackColor = System.Drawing.Color.Black;
            this.add_course.Controls.Add(this.addCourse_groupBox);
            this.add_course.Controls.Add(this.reg_label);
            this.add_course.Controls.Add(this.button1);
            this.add_course.Location = new System.Drawing.Point(4, 34);
            this.add_course.Name = "add_course";
            this.add_course.Size = new System.Drawing.Size(1345, 735);
            this.add_course.TabIndex = 1;
            this.add_course.Text = "   Add Course   ";
            // 
            // addCourse_groupBox
            // 
            this.addCourse_groupBox.Controls.Add(this.select_course_comboBox);
            this.addCourse_groupBox.Controls.Add(this.duration_label);
            this.addCourse_groupBox.Controls.Add(this.CourseDuration);
            this.addCourse_groupBox.Controls.Add(this.register_crs_button);
            this.addCourse_groupBox.Controls.Add(this.description_label);
            this.addCourse_groupBox.Controls.Add(this.CourseDescription);
            this.addCourse_groupBox.Controls.Add(this.teacherId_label);
            this.addCourse_groupBox.Controls.Add(this.courseCode_label);
            this.addCourse_groupBox.Controls.Add(this.courseSelection_label);
            this.addCourse_groupBox.Controls.Add(this.TeacherID);
            this.addCourse_groupBox.Controls.Add(this.CourseCode);
            this.addCourse_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourse_groupBox.ForeColor = System.Drawing.Color.White;
            this.addCourse_groupBox.Location = new System.Drawing.Point(189, 186);
            this.addCourse_groupBox.Name = "addCourse_groupBox";
            this.addCourse_groupBox.Size = new System.Drawing.Size(976, 499);
            this.addCourse_groupBox.TabIndex = 83;
            this.addCourse_groupBox.TabStop = false;
            this.addCourse_groupBox.Text = "Add Course";
            // 
            // select_course_comboBox
            // 
            this.select_course_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_course_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_course_comboBox.FormattingEnabled = true;
            this.select_course_comboBox.Location = new System.Drawing.Point(252, 77);
            this.select_course_comboBox.Name = "select_course_comboBox";
            this.select_course_comboBox.Size = new System.Drawing.Size(689, 33);
            this.select_course_comboBox.TabIndex = 91;
            this.select_course_comboBox.SelectedIndexChanged += new System.EventHandler(this.select_course_comboBox_SelectedIndexChanged_1);
            // 
            // duration_label
            // 
            this.duration_label.AutoSize = true;
            this.duration_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.duration_label.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.duration_label.Location = new System.Drawing.Point(11, 235);
            this.duration_label.Name = "duration_label";
            this.duration_label.Size = new System.Drawing.Size(203, 32);
            this.duration_label.TabIndex = 90;
            this.duration_label.Text = "Course Duration";
            // 
            // CourseDuration
            // 
            this.CourseDuration.BackColor = System.Drawing.Color.White;
            this.CourseDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseDuration.ForeColor = System.Drawing.Color.Black;
            this.CourseDuration.Location = new System.Drawing.Point(252, 234);
            this.CourseDuration.Name = "CourseDuration";
            this.CourseDuration.ReadOnly = true;
            this.CourseDuration.Size = new System.Drawing.Size(689, 32);
            this.CourseDuration.TabIndex = 89;
            this.CourseDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // register_crs_button
            // 
            this.register_crs_button.BackColor = System.Drawing.Color.Black;
            this.register_crs_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.register_crs_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_crs_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_crs_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register_crs_button.Location = new System.Drawing.Point(813, 406);
            this.register_crs_button.Name = "register_crs_button";
            this.register_crs_button.Size = new System.Drawing.Size(128, 38);
            this.register_crs_button.TabIndex = 80;
            this.register_crs_button.Text = "Register";
            this.register_crs_button.UseVisualStyleBackColor = false;
            this.register_crs_button.Click += new System.EventHandler(this.register_crs_button_Click_1);
            this.register_crs_button.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.register_crs_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.description_label.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.description_label.Location = new System.Drawing.Point(9, 312);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(233, 32);
            this.description_label.TabIndex = 88;
            this.description_label.Text = "Course Description";
            // 
            // CourseDescription
            // 
            this.CourseDescription.BackColor = System.Drawing.Color.White;
            this.CourseDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseDescription.ForeColor = System.Drawing.Color.Black;
            this.CourseDescription.Location = new System.Drawing.Point(252, 291);
            this.CourseDescription.Multiline = true;
            this.CourseDescription.Name = "CourseDescription";
            this.CourseDescription.ReadOnly = true;
            this.CourseDescription.Size = new System.Drawing.Size(689, 78);
            this.CourseDescription.TabIndex = 87;
            this.CourseDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teacherId_label
            // 
            this.teacherId_label.AutoSize = true;
            this.teacherId_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teacherId_label.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherId_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.teacherId_label.Location = new System.Drawing.Point(11, 180);
            this.teacherId_label.Name = "teacherId_label";
            this.teacherId_label.Size = new System.Drawing.Size(132, 32);
            this.teacherId_label.TabIndex = 86;
            this.teacherId_label.Text = "Teacher Id";
            // 
            // courseCode_label
            // 
            this.courseCode_label.AutoSize = true;
            this.courseCode_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.courseCode_label.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCode_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.courseCode_label.Location = new System.Drawing.Point(11, 128);
            this.courseCode_label.Name = "courseCode_label";
            this.courseCode_label.Size = new System.Drawing.Size(159, 32);
            this.courseCode_label.TabIndex = 85;
            this.courseCode_label.Text = "Course Code";
            // 
            // courseSelection_label
            // 
            this.courseSelection_label.AutoSize = true;
            this.courseSelection_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.courseSelection_label.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseSelection_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.courseSelection_label.Location = new System.Drawing.Point(12, 71);
            this.courseSelection_label.Name = "courseSelection_label";
            this.courseSelection_label.Size = new System.Drawing.Size(168, 32);
            this.courseSelection_label.TabIndex = 84;
            this.courseSelection_label.Text = "Select Course";
            // 
            // TeacherID
            // 
            this.TeacherID.BackColor = System.Drawing.Color.White;
            this.TeacherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherID.ForeColor = System.Drawing.Color.Black;
            this.TeacherID.Location = new System.Drawing.Point(252, 179);
            this.TeacherID.Name = "TeacherID";
            this.TeacherID.ReadOnly = true;
            this.TeacherID.Size = new System.Drawing.Size(689, 32);
            this.TeacherID.TabIndex = 83;
            this.TeacherID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CourseCode
            // 
            this.CourseCode.BackColor = System.Drawing.Color.White;
            this.CourseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseCode.ForeColor = System.Drawing.Color.Black;
            this.CourseCode.Location = new System.Drawing.Point(252, 127);
            this.CourseCode.Name = "CourseCode";
            this.CourseCode.ReadOnly = true;
            this.CourseCode.Size = new System.Drawing.Size(689, 32);
            this.CourseCode.TabIndex = 82;
            this.CourseCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reg_label
            // 
            this.reg_label.AutoSize = true;
            this.reg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_label.ForeColor = System.Drawing.Color.White;
            this.reg_label.Location = new System.Drawing.Point(355, 71);
            this.reg_label.Name = "reg_label";
            this.reg_label.Size = new System.Drawing.Size(0, 69);
            this.reg_label.TabIndex = 82;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 38);
            this.button1.TabIndex = 70;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.studentLogout);
            this.button1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // withdrawCourse
            // 
            this.withdrawCourse.BackColor = System.Drawing.Color.Black;
            this.withdrawCourse.Controls.Add(this.widraw_label);
            this.withdrawCourse.Controls.Add(this.withdraw_crs_groupBox);
            this.withdrawCourse.Controls.Add(this.button2);
            this.withdrawCourse.Location = new System.Drawing.Point(4, 34);
            this.withdrawCourse.Name = "withdrawCourse";
            this.withdrawCourse.Size = new System.Drawing.Size(1345, 735);
            this.withdrawCourse.TabIndex = 2;
            this.withdrawCourse.Text = " Withdraw Course ";
            // 
            // widraw_label
            // 
            this.widraw_label.AutoSize = true;
            this.widraw_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widraw_label.ForeColor = System.Drawing.Color.White;
            this.widraw_label.Location = new System.Drawing.Point(355, 71);
            this.widraw_label.Name = "widraw_label";
            this.widraw_label.Size = new System.Drawing.Size(0, 69);
            this.widraw_label.TabIndex = 87;
            // 
            // withdraw_crs_groupBox
            // 
            this.withdraw_crs_groupBox.Controls.Add(this.withdraw_select_course_comboBox);
            this.withdraw_crs_groupBox.Controls.Add(this.label1);
            this.withdraw_crs_groupBox.Controls.Add(this.withdraw_course_duration);
            this.withdraw_crs_groupBox.Controls.Add(this.label3);
            this.withdraw_crs_groupBox.Controls.Add(this.withdraw_crs_button);
            this.withdraw_crs_groupBox.Controls.Add(this.withdraw_course_description);
            this.withdraw_crs_groupBox.Controls.Add(this.label4);
            this.withdraw_crs_groupBox.Controls.Add(this.label5);
            this.withdraw_crs_groupBox.Controls.Add(this.label6);
            this.withdraw_crs_groupBox.Controls.Add(this.withdraw_teacherId);
            this.withdraw_crs_groupBox.Controls.Add(this.withdraw_course_code);
            this.withdraw_crs_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw_crs_groupBox.ForeColor = System.Drawing.Color.White;
            this.withdraw_crs_groupBox.Location = new System.Drawing.Point(189, 186);
            this.withdraw_crs_groupBox.Name = "withdraw_crs_groupBox";
            this.withdraw_crs_groupBox.Size = new System.Drawing.Size(976, 499);
            this.withdraw_crs_groupBox.TabIndex = 86;
            this.withdraw_crs_groupBox.TabStop = false;
            this.withdraw_crs_groupBox.Text = "Withdraw Course";
            // 
            // withdraw_select_course_comboBox
            // 
            this.withdraw_select_course_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.withdraw_select_course_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw_select_course_comboBox.FormattingEnabled = true;
            this.withdraw_select_course_comboBox.Location = new System.Drawing.Point(255, 76);
            this.withdraw_select_course_comboBox.Name = "withdraw_select_course_comboBox";
            this.withdraw_select_course_comboBox.Size = new System.Drawing.Size(689, 33);
            this.withdraw_select_course_comboBox.TabIndex = 91;
            this.withdraw_select_course_comboBox.SelectedIndexChanged += new System.EventHandler(this.withdraw_select_course_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(14, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 90;
            this.label1.Text = "Course Duration";
            // 
            // withdraw_course_duration
            // 
            this.withdraw_course_duration.BackColor = System.Drawing.Color.White;
            this.withdraw_course_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw_course_duration.ForeColor = System.Drawing.Color.Black;
            this.withdraw_course_duration.Location = new System.Drawing.Point(255, 233);
            this.withdraw_course_duration.Name = "withdraw_course_duration";
            this.withdraw_course_duration.ReadOnly = true;
            this.withdraw_course_duration.Size = new System.Drawing.Size(689, 32);
            this.withdraw_course_duration.TabIndex = 89;
            this.withdraw_course_duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 32);
            this.label3.TabIndex = 88;
            this.label3.Text = "Course Description";
            // 
            // withdraw_crs_button
            // 
            this.withdraw_crs_button.BackColor = System.Drawing.Color.Black;
            this.withdraw_crs_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.withdraw_crs_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdraw_crs_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw_crs_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.withdraw_crs_button.Location = new System.Drawing.Point(818, 407);
            this.withdraw_crs_button.Name = "withdraw_crs_button";
            this.withdraw_crs_button.Size = new System.Drawing.Size(128, 38);
            this.withdraw_crs_button.TabIndex = 80;
            this.withdraw_crs_button.Text = "Withdraw";
            this.withdraw_crs_button.UseVisualStyleBackColor = false;
            this.withdraw_crs_button.Click += new System.EventHandler(this.withdraw_crs_button_Click);
            // 
            // withdraw_course_description
            // 
            this.withdraw_course_description.BackColor = System.Drawing.Color.White;
            this.withdraw_course_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw_course_description.ForeColor = System.Drawing.Color.Black;
            this.withdraw_course_description.Location = new System.Drawing.Point(255, 290);
            this.withdraw_course_description.Multiline = true;
            this.withdraw_course_description.Name = "withdraw_course_description";
            this.withdraw_course_description.ReadOnly = true;
            this.withdraw_course_description.Size = new System.Drawing.Size(689, 78);
            this.withdraw_course_description.TabIndex = 87;
            this.withdraw_course_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(14, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 32);
            this.label4.TabIndex = 86;
            this.label4.Text = "Teacher Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(14, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 32);
            this.label5.TabIndex = 85;
            this.label5.Text = "Course Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(15, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 32);
            this.label6.TabIndex = 84;
            this.label6.Text = "Select Course";
            // 
            // withdraw_teacherId
            // 
            this.withdraw_teacherId.BackColor = System.Drawing.Color.White;
            this.withdraw_teacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw_teacherId.ForeColor = System.Drawing.Color.Black;
            this.withdraw_teacherId.Location = new System.Drawing.Point(255, 178);
            this.withdraw_teacherId.Name = "withdraw_teacherId";
            this.withdraw_teacherId.ReadOnly = true;
            this.withdraw_teacherId.Size = new System.Drawing.Size(689, 32);
            this.withdraw_teacherId.TabIndex = 83;
            this.withdraw_teacherId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // withdraw_course_code
            // 
            this.withdraw_course_code.BackColor = System.Drawing.Color.White;
            this.withdraw_course_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw_course_code.ForeColor = System.Drawing.Color.Black;
            this.withdraw_course_code.Location = new System.Drawing.Point(255, 126);
            this.withdraw_course_code.Name = "withdraw_course_code";
            this.withdraw_course_code.ReadOnly = true;
            this.withdraw_course_code.Size = new System.Drawing.Size(689, 32);
            this.withdraw_course_code.TabIndex = 82;
            this.withdraw_course_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 38);
            this.button2.TabIndex = 71;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.studentLogout);
            this.button2.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1353, 773);
            this.Controls.Add(this.student_tabControl);
            this.MaximizeBox = false;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.student_tabControl.ResumeLayout(false);
            this.Profile.ResumeLayout(false);
            this.Profile.PerformLayout();
            this.gndr_groupBox.ResumeLayout(false);
            this.gndr_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile_image)).EndInit();
            this.add_course.ResumeLayout(false);
            this.add_course.PerformLayout();
            this.addCourse_groupBox.ResumeLayout(false);
            this.addCourse_groupBox.PerformLayout();
            this.withdrawCourse.ResumeLayout(false);
            this.withdrawCourse.PerformLayout();
            this.withdraw_crs_groupBox.ResumeLayout(false);
            this.withdraw_crs_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl student_tabControl;
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
        private System.Windows.Forms.Button logout_button1;
        private System.Windows.Forms.TabPage add_course;
        private System.Windows.Forms.Button register_crs_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label reg_label;
        private System.Windows.Forms.GroupBox addCourse_groupBox;
        private System.Windows.Forms.ComboBox select_course_comboBox;
        private System.Windows.Forms.Label duration_label;
        private System.Windows.Forms.TextBox CourseDuration;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.TextBox CourseDescription;
        private System.Windows.Forms.Label teacherId_label;
        private System.Windows.Forms.Label courseCode_label;
        private System.Windows.Forms.Label courseSelection_label;
        private System.Windows.Forms.TextBox TeacherID;
        private System.Windows.Forms.TextBox CourseCode;
        private System.Windows.Forms.TabPage withdrawCourse;
        private System.Windows.Forms.GroupBox withdraw_crs_groupBox;
        private System.Windows.Forms.ComboBox withdraw_select_course_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox withdraw_course_duration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button withdraw_crs_button;
        private System.Windows.Forms.TextBox withdraw_course_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox withdraw_teacherId;
        private System.Windows.Forms.TextBox withdraw_course_code;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label widraw_label;
    }
}