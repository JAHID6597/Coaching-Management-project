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
using System.IO;

namespace Coaching_Management
{
    public partial class Admin : Form
    {
        MySqlConnection myConn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=jahid");
        MySqlCommand cmd;

        public Admin()
        {
            InitializeComponent();
            course_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            course_dataGridView.EnableHeadersVisualStyles = false;
            remove_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            remove_dataGridView.EnableHeadersVisualStyles = false;
            Details_data_GridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            Details_data_GridView.EnableHeadersVisualStyles = false;
            refresh();
            remove_refresh();
            show_course_data();
            rdio_btn_active();
        }
        string sqlQry;
        void refresh()
        {
            if (show_type_comboBox.Text == "TEACHER")
            {
                sqlQry = "select *from coaching_management.teacher";
            }
            else
            {
                sqlQry = "select *from coaching_management.student";
            }
            using (MySqlDataAdapter adpter = new MySqlDataAdapter(sqlQry, myConn))
            {

                DataSet dataset = new DataSet();

                adpter.Fill(dataset);

                Details_data_GridView.DataSource = dataset.Tables[0];

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)Details_data_GridView.Columns["Image"];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                adpter.Dispose();
            }
            myConn.Close();
        }
        string ImgLoc = "";
        private void upload_image_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG FIles(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImgLoc = dialog.FileName.ToString();
                details_pictureBox.ImageLocation = ImgLoc;
            }

        }
        private void button_mouse_enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = ColorTranslator.FromHtml("DimGray");
        }

        private void button_mouse_leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = ColorTranslator.FromHtml("");
        }

        private void textbox_enter(object sender, EventArgs e)
        {
            TextBox txtbx = (TextBox)sender;
            if (txtbx.Text == txtbx.Name || txtbx.Text == "Search by UserName or IDNo" || txtbx.Text == "Remove by UserName or IDNo")
            {
                txtbx.Text = "";
                if (txtbx == PassWord || txtbx == ConfirmPassword)
                {
                    txtbx.UseSystemPasswordChar = true;
                }
                txtbx.ForeColor = Color.Black;
            }
        }

        private void textbox_leave(object sender, EventArgs e)
        {
            TextBox txtbx = (TextBox)sender;
            if (txtbx.Text.Length == 0)
            {
                if (txtbx == PassWord || txtbx == ConfirmPassword)
                {
                    txtbx.UseSystemPasswordChar = false;
                }
                txtbx.Text = txtbx.Name;
                if (txtbx == search_textBox)
                {
                    txtbx.Text = "Search by UserName or IDNo";
                }
                if (txtbx == remove_textBox)
                {
                    txtbx.Text = "Remove by UserName or IDNo";
                }
                txtbx.ForeColor = Color.DarkGray;
            }
        }

        private void search_type_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }
        int f = 0;
        private void show_button_Click(object sender, EventArgs e)
        {
            if (search_type_comboBox.Text == "")
            {
                MessageBox.Show("Select your type...");
            }
            else
            {
                if (search_type_comboBox.Text == "TEACHER")
                {
                    sqlQry = "select *from coaching_management.teacher where UserName='" + search_textBox.Text + "' or ID='" + search_textBox.Text + "';";

                }
                else if (search_type_comboBox.Text == "STUDENT")
                {
                    sqlQry = "select *from coaching_management.student where UserName='" + search_textBox.Text + "' or ID='" + search_textBox.Text + "';";

                }

                cmd = new MySqlCommand(sqlQry, myConn);
                MySqlDataReader myreader;
                try
                {

                    myConn.Open();
                    myreader = cmd.ExecuteReader();
                    while (myreader.Read())
                    {
                        f++;
                        string firstname = myreader.GetString("FirstName");
                        string lastname = myreader.GetString("LastName");
                        string username = myreader.GetString("UserName");
                        string pass = myreader.GetString("Password");
                        string confirmpass = myreader.GetString("ConfirmPassword");
                        string email = myreader.GetString("Email");
                        string mobile_no = myreader.GetInt32("Mobile_No").ToString();
                        string DOB = myreader.GetString("Date_of_Birth");
                        string gndr = myreader.GetString("Gender");
                        string permanent_add = myreader.GetString("Permanent_Address");
                        string present_add = myreader.GetString("Present_Address");
                        string Id = myreader.GetString("ID");
                        string position = myreader.GetString("Position");

                        first_name.Text = firstname;
                        last_name.Text = lastname;
                        User_Name.Text = username;
                        Pass_Word.Text = pass;
                        Confirm_Password.Text = confirmpass;
                        e_mail.Text = email;
                        mobile__no.Text = mobile_no;
                        D_O_B.Text = DOB;
                        if (gndr == "Male") { radioButtonmale.Checked = true; }
                        else if (gndr == "Female") { radioButtonfemale.Checked = true; }
                        else if (gndr == "Others") { radioButtonothers.Checked = true; }
                        permanent_address.Text = permanent_add;
                        present_address.Text = present_add;
                        ID_No.Text = Id;
                        posi_tion.Text = position;

                        byte[] imgg = (byte[])(myreader["Image"]);
                        if (imgg == null)
                        { pictureBox_search_image.Image = null; }
                        else
                        {
                            MemoryStream ms = new MemoryStream(imgg);
                            pictureBox_search_image.Image = Image.FromStream(ms);
                        }
                    }
                    if (f == 0)
                        MessageBox.Show("No results find...");
                    f = 0;
                    myConn.Close();
                }


                catch (Exception ex)
                {
                    myConn.Close();
                    MessageBox.Show(ex.Message);
                }

            }
        }

        void remove_refresh()
        {
            if (delete_type_comboBox.Text == "TEACHER")
            {
                sqlQry = "select *from coaching_management.teacher";
            }
            else
            {
                sqlQry = "select *from coaching_management.student";
            }
            using (MySqlDataAdapter adpter1 = new MySqlDataAdapter(sqlQry, myConn))
            {

                DataSet dataset1 = new DataSet();

                adpter1.Fill(dataset1);

                remove_dataGridView.DataSource = dataset1.Tables[0];

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)remove_dataGridView.Columns["Image"];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                adpter1.Dispose();
            }
            myConn.Close();
        }
        string Query, Gender;
        private void added_button_Click(object sender, EventArgs e)
        {
            if (type_comboBox.Text == "STUDENT")
            {
                Query = "insert into coaching_management.student (FirstName,LastName,UserName,Password,ConfirmPassword,Email,Mobile_No,Date_of_Birth,Image,Gender,Type,ID,Position,Permanent_Address,Present_Address) values ('" + this.FirstName.Text + "','" + this.LastName.Text + "', '" + this.UserName.Text + "', '" + this.PassWord.Text + "', '" + this.ConfirmPassword.Text + "', '" + this.Email.Text + "','" + this.MobileNo.Text + "','" + this.date_of_birth_pick.Text + "', @IMG , '" + Gender + "', '" + this.type_comboBox.Text + "', '" + this.IDNo.Text + "','" + this.Position.Text + "', '" + this.PermanentAddress.Text + "', '" + this.PresentAddress.Text + "'); ";
            }
            else if (type_comboBox.Text == "TEACHER")
            {
                Query = "insert into coaching_management.teacher (FirstName,LastName,UserName,Password,ConfirmPassword,Email,Mobile_No,Date_of_Birth,Image,Gender,Type,ID,Position,Permanent_Address,Present_Address) values ('" + this.FirstName.Text + "','" + this.LastName.Text + "', '" + this.UserName.Text + "', '" + this.PassWord.Text + "', '" + this.ConfirmPassword.Text + "', '" + this.Email.Text + "','" + this.MobileNo.Text + "','" + this.date_of_birth_pick.Text + "', @IMG , '" + Gender + "', '" + this.type_comboBox.Text + "', '" + this.IDNo.Text + "','" + this.Position.Text + "', '" + this.PermanentAddress.Text + "', '" + this.PresentAddress.Text + "'); ";
            }
            if (ImgLoc == "" || type_comboBox.Text == "" || Gender == "" || FirstName.Text == "First Name" || LastName.Text == "Last Name" || UserName.Text == "UserName" || PassWord.Text == "Password" || ConfirmPassword.Text == "Confirm Password" || Email.Text == "E-mail" || MobileNo.Text == "Mobile No" || PermanentAddress.Text == "Permanent Address" || PresentAddress.Text == "Present Address" || IDNo.Text == "ID No" || Position.Text == "Position")
            {
                MessageBox.Show("Fillup all information...");
            }
            else
            {
                byte[] imgbt = null;
                FileStream fstream = new FileStream(ImgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imgbt = br.ReadBytes((int)fstream.Length);


                if (PassWord.Text != ConfirmPassword.Text)
                {
                    MessageBox.Show("Password doesn't match...");
                }
                else
                {
                    cmd = new MySqlCommand(Query, myConn);
                    MySqlDataReader myReader;
                    try
                    {
                        myConn.Open();
                        cmd.Parameters.Add(new MySqlParameter("@IMG", imgbt));
                        myReader = cmd.ExecuteReader();
                        while (myReader.Read())
                        {
                            byte[] imgg = (byte[])(myReader["Image"]);
                            if (imgg == null)
                            { details_pictureBox.Image = null; }
                            else
                            {
                                MemoryStream ms = new MemoryStream(imgg);
                                details_pictureBox.Image = Image.FromStream(ms);
                            }
                        }
                        MessageBox.Show("Successfully Added...");
                        myConn.Close();
                    }
                    catch (Exception)
                    { myConn.Close(); }

                    if (type_comboBox.Text == "TEACHER")
                        {
                            string query = "INSERT INTO coaching_management.course (teacher_id,image) VALUES ('" + this.IDNo.Text + "',@IMG); ; ";
                            cmd = new MySqlCommand(query, myConn);
                           
                        try
                            {
                                myConn.Open();
                                cmd.Parameters.Add(new MySqlParameter("@IMG", imgbt));
                                myReader = cmd.ExecuteReader();
                                while (myReader.Read())
                                {
                                    byte[] imgg = (byte[])(myReader["image"]);
                                    if (imgg == null)
                                    { details_pictureBox.Image = null; }
                                    else
                                    {
                                        MemoryStream ms = new MemoryStream(imgg);
                                        details_pictureBox.Image = Image.FromStream(ms);
                                    }
                                }
                            myConn.Close();
                        }
                            catch (Exception)
                            { myConn.Close(); }
                        }
                        if (type_comboBox.Text == "STUDENT")
                        {
                            string query = "INSERT INTO coaching_management.course_register_student_details (student_id,image) VALUES ('" + this.IDNo.Text + "',@IMG); ; ";
                            cmd = new MySqlCommand(query, myConn);
                            try
                            {
                                myConn.Open();
                                cmd.Parameters.Add(new MySqlParameter("@IMG", imgbt));
                                myReader = cmd.ExecuteReader();
                                while (myReader.Read())
                                {
                                    byte[] imgg = (byte[])(myReader["image"]);
                                    if (imgg == null)
                                    { details_pictureBox.Image = null; }
                                    else
                                    {
                                        MemoryStream ms = new MemoryStream(imgg);
                                        details_pictureBox.Image = Image.FromStream(ms);
                                    }
                                }
                            myConn.Close();
                        }
                            catch (Exception)
                            { myConn.Close(); }
                        }

                        
                        reset_details();
                        myConn.Close();
                    
                    refresh();
                }
            }
        }

        private void male_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void female_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void others_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Others";
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (type_comboBox.Text == "TEACHER")
            {
                sqlQry = "update coaching_management.teacher set FirstName='" + this.FirstName.Text + "',LastName='" + this.LastName.Text + "', UserName='" + this.UserName.Text + "', Password='" + this.PassWord.Text + "', ConfirmPassword='" + this.ConfirmPassword.Text + "', Email='" + this.Email.Text + "',Mobile_No='" + this.MobileNo.Text + "',Date_of_Birth='" + this.date_of_birth_pick.Text + "',Image= @IMG , Gender='" + Gender + "', Type='" + this.type_comboBox.Text + "', ID='" + this.IDNo.Text + "',Position='" + this.Position.Text + "', Permanent_Address='" + this.PermanentAddress.Text + "', Present_Address='" + this.PresentAddress.Text + "' where ID='" + this.IDNo.Text + "'; ";
            }
            else if (type_comboBox.Text == "STUDENT")
            {
                sqlQry = "update coaching_management.student set FirstName='" + this.FirstName.Text + "',LastName='" + this.LastName.Text + "', UserName='" + this.UserName.Text + "', Password='" + this.PassWord.Text + "', ConfirmPassword='" + this.ConfirmPassword.Text + "', Email='" + this.Email.Text + "',Mobile_No='" + this.MobileNo.Text + "',Date_of_Birth='" + this.date_of_birth_pick.Text + "',Image= @IMG , Gender='" + Gender + "', Type='" + this.type_comboBox.Text + "', ID='" + this.IDNo.Text + "',Position='" + this.Position.Text + "', Permanent_Address='" + this.PermanentAddress.Text + "', Present_Address='" + this.PresentAddress.Text + "' where ID='" + this.IDNo.Text + "'; ";
            }

            if (ImgLoc == "" || type_comboBox.Text == "" || Gender == "" || FirstName.Text == "First Name" || LastName.Text == "Last Name" || UserName.Text == "UserName" || PassWord.Text == "Password" || ConfirmPassword.Text == "Confirm Password" || Email.Text == "E-mail" || MobileNo.Text == "Mobile No" || PermanentAddress.Text == "Permanent Address" || PresentAddress.Text == "Present Address" || IDNo.Text == "ID No" || Position.Text == "Position")
            {
                MessageBox.Show("Fillup all information...");
            }
            else
            {
                byte[] imgbt = null;
                FileStream fstream = new FileStream(ImgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imgbt = br.ReadBytes((int)fstream.Length);


                if (PassWord.Text != ConfirmPassword.Text)
                {
                    MessageBox.Show("Password doesn't match...");
                }
                else
                {

                    try
                    {
                        cmd = new MySqlCommand(sqlQry, myConn);
                        MySqlDataReader myReader;
                        myConn.Open();
                        cmd.Parameters.Add(new MySqlParameter("@IMG", imgbt));
                        myReader = cmd.ExecuteReader();
                        while (myReader.Read())
                        {
                            string pp = myReader.GetString("ID");
                            byte[] imgg = (byte[])(myReader["Image"]);
                            if (imgg == null)
                            { details_pictureBox.Image = null; }
                            else
                            {
                                MemoryStream ms = new MemoryStream(imgg);
                                details_pictureBox.Image = Image.FromStream(ms);
                            }
                        }
                        myConn.Close();
                    }
                    catch (Exception)
                    {}
                    if (type_comboBox.Text == "TEACHER")
                    {
                        string query = "UPDATE coaching_management.course set image=@IMG;";
                        cmd = new MySqlCommand(query, myConn);
                        MySqlDataReader myReader;
                        try
                        {
                            myConn.Open();
                            cmd.Parameters.Add(new MySqlParameter("@IMG", imgbt));
                            myReader = cmd.ExecuteReader();
                            while (myReader.Read())
                            {
                                byte[] imgg = (byte[])(myReader["image"]);
                                if (imgg == null)
                                { details_pictureBox.Image = null; }
                                else
                                {
                                    MemoryStream ms = new MemoryStream(imgg);
                                    details_pictureBox.Image = Image.FromStream(ms);
                                }
                            }
                            myConn.Close();
                        }
                        catch (Exception)
                        { myConn.Close(); }
                    }
                    if (type_comboBox.Text == "STUDENT")
                    {
                        string query = "UPDATE coaching_management.course_register_student_details set image=@IMG ";
                        cmd = new MySqlCommand(query, myConn);
                        MySqlDataReader myReader;
                        try
                        {
                            myConn.Open();
                            cmd.Parameters.Add(new MySqlParameter("@IMG", imgbt));
                            myReader = cmd.ExecuteReader();
                            while (myReader.Read())
                            {
                                byte[] imgg = (byte[])(myReader["image"]);
                                if (imgg == null)
                                { details_pictureBox.Image = null; }
                                else
                                {
                                    MemoryStream ms = new MemoryStream(imgg);
                                    details_pictureBox.Image = Image.FromStream(ms);
                                }
                            }
                            myConn.Close();
                        }
                        catch (Exception)
                        { myConn.Close(); }
                    }
                    refresh();
                }
            }
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            if (delete_type_comboBox.Text == "TEACHER")
            {
                sqlQry = "delete from coaching_management.teacher where UserName='" + remove_textBox.Text + "' or ID='" + remove_textBox.Text + "';";

            }
            else if (delete_type_comboBox.Text == "STUDENT")
            {
                sqlQry = "delete from coaching_management.student where UserName='" + remove_textBox.Text + "' or ID='" + remove_textBox.Text + "';";

            }

            cmd = new MySqlCommand(sqlQry, myConn);
            MySqlDataReader myreader;
            try
            {
                myConn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    refresh();
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                myConn.Close();
            }
            remove_refresh();

            if (delete_type_comboBox.Text == "TEACHER")
            {
                sqlQry = "delete from coaching_management.course where teacher_id='" + remove_textBox.Text + "';";

            }
            else if (delete_type_comboBox.Text == "STUDENT")
            {
                sqlQry = "delete from coaching_management.course_register_student_details where student_id='" + remove_textBox.Text + "';";

            }
            cmd = new MySqlCommand(sqlQry, myConn);
            try
            {
                myConn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {}
                myConn.Close();
            }
            catch (Exception ex)
            {
                myConn.Close();
            }







        }
        void reset_details()
        {
            FirstName.Text = "";
            LastName.Text = "";
            UserName.Text = "";
            PassWord.Text = "";
            ConfirmPassword.Text = "";
            Email.Text = "";
            MobileNo.Text = "";
            PermanentAddress.Text = "";
            PresentAddress.Text = "";
            IDNo.Text = "";
            Position.Text = "";
            date_of_birth_pick.Text = "";

            FirstName.Text = FirstName.Name;
            LastName.Text = LastName.Name;
            UserName.Text = "UserName";
            PassWord.Text = "PassWord";
            ConfirmPassword.Text = "ConfirmPassword";
            PassWord.UseSystemPasswordChar = false;
            ConfirmPassword.UseSystemPasswordChar = false;
            Email.Text = Email.Name;
            MobileNo.Text = MobileNo.Name;
            PermanentAddress.Text = PermanentAddress.Name;
            PresentAddress.Text = PresentAddress.Name;
            IDNo.Text = IDNo.Name;
            Position.Text = Position.Name;

            FirstName.ForeColor = Color.DarkGray;
            LastName.ForeColor = Color.DarkGray;
            UserName.ForeColor = Color.DarkGray;
            PassWord.ForeColor = Color.DarkGray;
            ConfirmPassword.ForeColor = Color.DarkGray;
            Email.ForeColor = Color.DarkGray;
            MobileNo.ForeColor = Color.DarkGray;
            PermanentAddress.ForeColor = Color.DarkGray;
            PresentAddress.ForeColor = Color.DarkGray;
            IDNo.ForeColor = Color.DarkGray;
            Position.ForeColor = Color.DarkGray;

            details_pictureBox.Image = Properties.Resources.uploadimage;
            ImgLoc = "";
            male_radioButton.Checked = false;
            female_radioButton.Checked = false;
            others_radioButton.Checked = false;
        }
        private void reset_button_Click(object sender, EventArgs e)
        {
            reset_details();
        }
        private void delete_type_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            remove_refresh();
        }
        private void adminLogout(object sender, EventArgs e)
        {
            Hide();
            HOME home = new HOME();
            home.ShowDialog();
        }
        string course_qryy;
        public void show_course_data()
        {
            course_qryy = "SELECT* FROM coaching_management.course;";
            using (MySqlDataAdapter madpter = new MySqlDataAdapter(course_qryy, myConn))
            {

                DataSet mdataset = new DataSet();

                madpter.Fill(mdataset);

                course_dataGridView.DataSource = mdataset.Tables[0];

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)course_dataGridView.Columns["Image"];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                madpter.Dispose();
            }
            myConn.Close();

        }
        void reset_course()
        {
            CourseTitle.Text = "";
            CourseCode.Text = "";
            TeacherID.Text = "";
            CourseDuration.Text = "";
            CourseDescription.Text = "";

            CourseTitle.Text = CourseTitle.Name;
            CourseCode.Text = CourseCode.Name;
            TeacherID.Text = TeacherID.Name;
            CourseDuration.Text = CourseDuration.Name;
            CourseDescription.Text = CourseDescription.Name;

            CourseTitle.ForeColor = Color.DarkGray;
            CourseCode.ForeColor = Color.DarkGray;
            TeacherID.ForeColor = Color.DarkGray;
            CourseDuration.ForeColor = Color.DarkGray;
            CourseDescription.ForeColor = Color.DarkGray;
        }
        private void reset_course_button_Click(object sender, EventArgs e)
        {
            reset_course();
        }
        string sqry;
        private void Add_crs_button_Click(object sender, EventArgs e)
        {
            if (CourseTitle.Text == "" || CourseCode.Text == "" || TeacherID.Text == "" || CourseDuration.Text == "" || CourseDescription.Text == "")
            {
                MessageBox.Show("Fillup all information...");
            }
            else
            {
                sqry = "update coaching_management.course set course_title = '" + this.CourseTitle.Text + "', course_code = '" + this.CourseCode.Text + "' ,teacher_id = '" + this.TeacherID.Text + "', course_duration = '" + this.CourseDuration.Text + "' , course_description = '" + this.CourseDescription.Text + "' where teacher_id='" + this.TeacherID.Text + "';";
                cmd = new MySqlCommand(sqry, myConn);
                MySqlDataReader myReader;
                try
                {
                    myConn.Open();
                    myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        show_course_data();
                    }
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    myConn.Close();
                    MessageBox.Show(ex.Message);
                }
                show_course_data();
                reset_course();
            }
        }
        string cheked,active, withdraw_active,withdraw;
        public void rdio_btn_active()
        {
            sqlQry = "select registration from coaching_management.admin;";
            try
            {
                cmd = new MySqlCommand(sqlQry, myConn);
                MySqlDataReader myReader;
                myConn.Open();

                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    active = myReader.GetString("registration");
                }

                myConn.Close();
            }
            catch (Exception)
            {
                myConn.Close();
            }
            if (active == "OPEN")
            {
                add_open_radioButton.Checked = true;
                add_close_radioButton.Checked = false;
            }
            else if (active == "CLOSE")
            {
                add_open_radioButton.Checked = false;
                add_close_radioButton.Checked = true;
            }
        }

        public void withdraw_rdio_btn_active()
        {
            sqlQry = "select withdraw from coaching_management.admin;";
            try
            {
                cmd = new MySqlCommand(sqlQry, myConn);
                MySqlDataReader myReader;
                myConn.Open();

                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    withdraw = myReader.GetString("withdraw");
                }

                myConn.Close();
            }
            catch (Exception)
            {
                myConn.Close();
            }
            if (withdraw == "OPEN")
            {
                withdraw_open_radioButton.Checked = true;
                withdraw_close_radioButton.Checked = false;
            }
            else if (withdraw == "CLOSE")
            {
                withdraw_open_radioButton.Checked = false;
                withdraw_close_radioButton.Checked = true;
            }
        }

        private void AdminTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdio_btn_active();
            withdraw_rdio_btn_active();
            show_course_data();
        }
        int ff;
        private void withdraw_open_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            withdraw_active = "OPEN";
            ff = 2;
            course_reg();
        }

        private void withdraw_close_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            withdraw_active = "CLOSE";
            ff = 2;
            course_reg();
        }

        private void open_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            cheked = "OPEN";
            ff = 1;
            course_reg();
        }
        private void close_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            cheked = "CLOSE";
            ff = 1;
            course_reg();
        }
        string queRy;
        void course_reg()
        {
            
            if (ff == 1)
            {
                queRy = "update coaching_management.admin set registration ='" + cheked + "';";
            }
            else if(ff == 2)
            {
                queRy = "update coaching_management.admin set withdraw ='" + withdraw_active + "';";
            }
            try
            {
                cmd = new MySqlCommand(queRy, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {}
                myConn.Close();
            }
            catch (Exception)
            {
                myConn.Close();
            }
        }
    }
}
    
