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
    public partial class Student : Form
    {
        MySqlConnection myConn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=jahid");
        MySqlCommand cmd;
        public Student()
        {
            InitializeComponent();
            add_dbs_to_comboBox();
            
            check_registration();
            check_withdraw();
        }
        string student_ID;
        public void profile_show(string id)
        {
            student_ID = id;
            string qry = "select * from coaching_management.student where ID = '" + id + "'; ";
            cmd = new MySqlCommand(qry, myConn);
            MySqlDataReader myreader;
            try
            {

                myConn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
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
                    { pictureBox_profile_image.Image = null; }
                    else
                    {
                        MemoryStream ms = new MemoryStream(imgg);
                        pictureBox_profile_image.Image = Image.FromStream(ms);
                    }
                }

                myConn.Close();
            }


            catch (Exception ex)
            {
                myConn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        string course_qryy;
       
        private void studentLogout(object sender, EventArgs e)
        {
            Hide();
            HOME home = new HOME();
            home.ShowDialog();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = ColorTranslator.FromHtml("DimGray");
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = ColorTranslator.FromHtml("");
        }
        string qry;
        void add_dbs_to_comboBox()
        {
            myConn.Open();
            qry = "SELECT course_title FROM coaching_management.course;";
            using (var cmd = new MySqlCommand(qry, myConn))
            {
                using (var myreader = cmd.ExecuteReader())
                {
                    while (myreader.Read())
                    {
                         select_course_comboBox.Items.Add(myreader.GetString("course_title"));
                    } 
                }
            }
            myConn.Close();
        }
        void withdraw_dbs_to_comboBox()
        {
            myConn.Open();
            qry = "SELECT course_title FROM coaching_management.course_register_student_details where student_id = '" + student_ID+"';";
            using (var cmd = new MySqlCommand(qry, myConn))
            {
                using (var myreader = cmd.ExecuteReader())
                {
                    while (myreader.Read())
                    {
                        withdraw_select_course_comboBox.Items.Add(myreader.GetString("course_title"));
                    }
                }
            }
            myConn.Close();
        }

        int cnt = 0;
        string sqlQry, courseTitle;

        private void register_crs_button_Click_1(object sender, EventArgs e)
        {
                sqlQry = "update coaching_management.course_register_student_details set course_title='" + this.select_course_comboBox.Text + "',course_code='" + this.CourseCode.Text + "', course_teacher_id='" + this.TeacherID.Text + "', course_duration='" + this.CourseDuration.Text + "', course_description='" + this.CourseDescription.Text + "' where student_id='" + this.ID_No.Text + "';";

                try
                {
                    cmd = new MySqlCommand(sqlQry, myConn);
                    MySqlDataReader myReader;
                    myConn.Open();
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Successfuly register your course...");
                    while (myReader.Read())
                    { }
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    myConn.Close();
                    MessageBox.Show(ex.Message);
                }
            

    }

        
        string reg,widraw, course_code, teacher_id, course_duration, course_description;

        private void student_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            withdraw_dbs_to_comboBox();
        }

        private void withdraw_crs_button_Click(object sender, EventArgs e)
        {
            sqlQry = "UPDATE coaching_management.course_register_student_details SET course_title = '', course_code = '', course_teacher_id = '', course_duration = '', course_description = '' WHERE (student_id = '" + student_ID + "');";
            try
            {
                cmd = new MySqlCommand(sqlQry, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Successfuly Withdraw your course...");
                while (myReader.Read())
                { }
                myConn.Close();
            }
            catch (Exception ex)
            {
                myConn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void select_course_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string qry = "select course_code,teacher_id,course_duration,course_description from coaching_management.course where course_title = '" + select_course_comboBox.Text + "'; ";
            cmd = new MySqlCommand(qry, myConn);
            MySqlDataReader myreader;
            try
            {

                myConn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    course_code = myreader.GetString("course_code");
                    teacher_id = myreader.GetString("teacher_id");
                    course_duration = myreader.GetString("course_duration");
                    course_description = myreader.GetString("course_description");

                }
                myConn.Close();
                CourseCode.Text = course_code;
                TeacherID.Text = teacher_id;
                CourseDuration.Text = course_duration;
                CourseDescription.Text = course_description;

            }
            catch (Exception ex)
            {
                myConn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void withdraw_select_course_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qry = "select course_code,course_teacher_id,course_duration,course_description from coaching_management.course_register_student_details where course_title = '" + withdraw_select_course_comboBox.Text + "'; ";
            cmd = new MySqlCommand(qry, myConn);
            MySqlDataReader myreader;
            try
            {

                myConn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    course_code = myreader.GetString("course_code");
                    teacher_id = myreader.GetString("course_teacher_id");
                    course_duration = myreader.GetString("course_duration");
                    course_description = myreader.GetString("course_description");

                }
                myConn.Close();
                withdraw_course_code.Text = course_code;
                withdraw_teacherId.Text = teacher_id;
                withdraw_course_duration.Text = course_duration;
                withdraw_course_description.Text = course_description;

            }
            catch (Exception ex)
            {
                myConn.Close();
                MessageBox.Show(ex.Message);
            }
        }


        public void check_registration()
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
                    reg = myReader.GetString("registration");

                }

                myConn.Close();
            }
            catch (Exception)
            {
                myConn.Close();
            }
            if(reg == "OPEN")
            {
                reg_label.Text = "Registration Is Open";
            }
            else if(reg == "CLOSE")
            {
                reg_label.Text = "Registration Is Close";
                select_course_comboBox.Enabled = false;
                CourseCode.Enabled = false;
                TeacherID.Enabled = false;
                CourseDuration.Enabled = false;
                CourseDescription.Enabled = false;
                register_crs_button.Enabled = false;
            }
        }

        public void check_withdraw()
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
                    widraw = myReader.GetString("withdraw");
                }

                myConn.Close();
            }
            catch (Exception)
            {
                myConn.Close();
            }
            if (widraw == "OPEN")
            {
                widraw_label.Text = "Withdraw Is Open";
            }
            else if (widraw == "CLOSE")
            {
                widraw_label.Text = "Withdraw Is Close";
                withdraw_select_course_comboBox.Enabled = false;
                withdraw_course_code.Enabled = false;
                withdraw_teacherId.Enabled = false;
                withdraw_course_duration.Enabled = false;
                withdraw_course_description.Enabled = false;
                withdraw_crs_button.Enabled = false;
            }
        }
    }
}
