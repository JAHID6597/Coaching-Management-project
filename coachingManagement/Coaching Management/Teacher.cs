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
    public partial class Teacher : Form
    {
        MySqlConnection myConn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=jahid");
        MySqlCommand cmd;
        string ID;
        public Teacher()
        {
            InitializeComponent();
            register_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            register_dataGridView.EnableHeadersVisualStyles = false;
            marks_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            marks_dataGridView.EnableHeadersVisualStyles = false;
        }
        int f = 0;
        public void profile_show(string id)
        {
            string qry = "select * from coaching_management.teacher where ID = '" + id + "'; ";
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
                    if (gndr == "Male")
                    {
                        radioButtonmale.Checked = true;
                    }
                    else if (gndr == "Female")
                    {
                        radioButtonfemale.Checked = true;
                    }
                    else if (gndr == "Others")
                    {
                        radioButtonothers.Checked = true;
                    }
                    permanent_address.Text = permanent_add;
                    present_address.Text = present_add;
                    ID_No.Text = Id;
                    ID = Id;
                    f++;
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

        private void logout_button_Click(object sender, EventArgs e)
        {
            Hide();
            HOME home = new HOME();
            home.ShowDialog();
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = ColorTranslator.FromHtml("");
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = ColorTranslator.FromHtml("DimGray");
        }
        string sqlQr;
        public void register_stdnt_dataGridview()
        {
            sqlQr = "select *from coaching_management.course_register_student_details where course_teacher_id ='" + ID + "';";
            using (MySqlDataAdapter adpter1 = new MySqlDataAdapter(sqlQr, myConn))
            {

                DataSet dataset1 = new DataSet();

                adpter1.Fill(dataset1);

                register_dataGridView.DataSource = dataset1.Tables[0];

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)register_dataGridView.Columns["Image"];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                adpter1.Dispose();
            }
            myConn.Close();
        }

        private void teacher_tabPage_dataGridview(object sender, EventArgs e)
        {
            register_stdnt_dataGridview();
            show_marks_dataGridview();
        }
        string sqry;
        void show_marks_dataGridview()
        {
            sqry = "select student_id,image,marks,grade,gpa from coaching_management.course_register_student_details where course_teacher_id ='" + ID_No.Text + "';";
            using (MySqlDataAdapter adpter1 = new MySqlDataAdapter(sqry, myConn))
            {

                DataSet dataset1 = new DataSet();

                adpter1.Fill(dataset1);

                marks_dataGridView.DataSource = dataset1.Tables[0];

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)marks_dataGridView.Columns["image"];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                adpter1.Dispose();
            }
            myConn.Close();
        }
        private void textbox_enter(object sender, EventArgs e)
        {
            TextBox txtbx = (TextBox)sender;
            if (txtbx.Text == txtbx.Name || txtbx.Text == "Search by UserName or IDNo")
            {
                txtbx.Text = "";
                txtbx.ForeColor = Color.Black;
            }
        }

        private void textbox_leave(object sender, EventArgs e)
        {
            TextBox txtbx = (TextBox)sender;
            if (txtbx.Text.Length == 0)
            {
                if (txtbx == search_textBox)
                {
                    txtbx.Text = "Search by UserName or IDNo";
                }
                txtbx.Text = txtbx.Name;
                if (txtbx == search_textBox)
                {
                    txtbx.Text = "Search by UserName or IDNo";
                }
                txtbx.ForeColor = Color.DarkGray;
            }
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            (register_dataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("ID LIKE '%{0}%' or UserName LIKE '%{0}%'", search_textBox.Text, search_textBox.Text);
        }
        string sqlQry, stdntID;
        double MARKS;
        void add_marks()
        {
            sqlQry = "select student_id from coaching_management.course_register_student_details where student_id='" + this.StudentID.Text + "';'";
            try
            {
                cmd = new MySqlCommand(sqlQry, myConn);
                MySqlDataReader myReader;
                myConn.Open();

                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    stdntID = myReader.GetString("student_id");
                }

                myConn.Close();
            }
            catch (Exception)
            {
                myConn.Close();
            }
            if (stdntID == StudentID.Text)
            {
                sqlQry = "update coaching_management.course_register_student_details set marks='" + this.Marks.Text + "',grade='" + this.Grade.Text + "',gpa='" + this.GPA.Text + "' where student_id='" + this.StudentID.Text + "';";

                try
                {
                    cmd = new MySqlCommand(sqlQry, myConn);
                    MySqlDataReader myReader;
                    myConn.Open();
                    myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    { }
                    MessageBox.Show("Successfully added Marks...");
                    reset_marks();
                    myConn.Close();
                }
                catch (Exception)
                { myConn.Close(); }
            }
            else
            {
                MessageBox.Show("ID is not Match...");
            }
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            if(StudentID.Text == "" || Marks.Text == "")
            {
                MessageBox.Show("Fillup all the information...");
            }
            else
            {
                add_marks();
                show_marks_dataGridview();
            }
        }

        private void Marks_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && Marks.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            reset_marks();
        }
        void reset_marks()
        {
            StudentID.Text = "";
            Marks.Text = "";
            Grade.Text = "";
            GPA.Text = "";
        }

        private void Marks_TextChanged(object sender, EventArgs e)
        {
            if(Marks.Text.Length == 0)
            {
                Marks.Text = "";
                Grade.Text = "";
                GPA.Text = "";
            }
            else if (Marks.Text.Length != 0)
            {
                MARKS = Convert.ToDouble(Marks.Text);
                if (MARKS >= 0 && MARKS <= 32)
                {
                    Grade.Text = "F";
                    GPA.Text = "0.00";
                }
                else if (MARKS >= 33 && MARKS <= 39)
                {
                    Grade.Text = "D";
                    GPA.Text = "1.00";
                }
                else if (MARKS >= 40 && MARKS <= 49)
                {
                    Grade.Text = "C";
                    GPA.Text = "2.00";
                }
                else if (MARKS >= 50 && MARKS <= 59)
                {
                    Grade.Text = "B";
                    GPA.Text = "3.00";
                }
                else if (MARKS >= 60 && MARKS <= 69)
                {
                    Grade.Text = "A-";
                    GPA.Text = "4.00";
                }
                else if (MARKS >= 70 && MARKS <= 79)
                {
                    Grade.Text = "A";
                    GPA.Text = "4.50";
                }
                else if (MARKS >= 80 && MARKS <= 100)
                {
                    Grade.Text = "A+";
                    GPA.Text = "5.00";
                }
                else
                {
                    MessageBox.Show("Error Marks...");
                    Marks.Text = "";
                    Grade.Text = "";
                    GPA.Text = "";
                }
            }
        }
    }
}

