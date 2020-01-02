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
    public partial class HOME : Form
    {
        MySqlConnection myConn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=jahid");
        MySqlCommand CmdDbs;
        public HOME()
        {
            InitializeComponent();
            signup_panel.Visible = false;
        }
        private void reset_button_Click(object sender, EventArgs e)
        {
            reset_login();
        }
        void reset_login()
        {
            IDNo.Text = "";
            Password.Text = "";
            IDNo.Text = IDNo.Name;
            Password.Text = Password.Name;
            Password.UseSystemPasswordChar = false;
            IDNo.ForeColor = Color.DarkGray;
            Password.ForeColor = Color.DarkGray;
        }
        private void signup_button_Click(object sender, EventArgs e)
        {
            welcome_pictureBox.Visible = false;
            signup_panel.Visible = true;
        }
        void reset_signup()
        {
            FirstName.Text = "";
            LastName.Text = "";
            User_Name.Text = "";
            Pass_Word.Text = "";
            Confirm_Password.Text = "";
            Email.Text = "";
            MobileNo.Text = "";
            PermanentAddress.Text = "";
            PresentAddress.Text = "";
            ID_No.Text = "";
            Position.Text = "";
            date_of_birth_pick.Text = "";

            FirstName.Text = FirstName.Name;
            LastName.Text = LastName.Name;
            User_Name.Text = "UserName";
            Pass_Word.Text = "PassWord";
            Confirm_Password.Text = "ConfirmPassword";
            Pass_Word.UseSystemPasswordChar = false;
            Confirm_Password.UseSystemPasswordChar = false; 
            Email.Text = Email.Name;
            MobileNo.Text = MobileNo.Name;
            PermanentAddress.Text = PermanentAddress.Name;
            PresentAddress.Text = PresentAddress.Name;
            ID_No.Text = "IDNo";
            Position.Text = Position.Name;

            FirstName.ForeColor = Color.DarkGray;
            LastName.ForeColor = Color.DarkGray;
            User_Name.ForeColor = Color.DarkGray;
            Pass_Word.ForeColor = Color.DarkGray;
            Confirm_Password.ForeColor = Color.DarkGray;
            Email.ForeColor = Color.DarkGray;
            MobileNo.ForeColor = Color.DarkGray;
            PermanentAddress.ForeColor = Color.DarkGray;
            PresentAddress.ForeColor = Color.DarkGray;
            ID_No.ForeColor = Color.DarkGray;
            Position.ForeColor = Color.DarkGray;

            signup_pictureBox.Image = Properties.Resources.uploadimage;
            ImgLoc = "";
            male_radioButton.Checked = false;
            female_radioButton.Checked = false;
            others_radioButton.Checked = false;
        }
        private void reset_reg_button_Click(object sender, EventArgs e)
        {
            reset_signup();
        }
        string ImgLoc = "";
        private void upload_image_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG FIles(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImgLoc = dialog.FileName.ToString();
                signup_pictureBox.ImageLocation = ImgLoc;
            }
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
        string Query,tId;
        private void signup_reg_button_Click(object sender, EventArgs e)
        {
            if (signup_comboBox.Text == "STUDENT")
            {
                Query = "insert into coaching_management.student (FirstName,LastName,UserName,Password,ConfirmPassword,Email,Mobile_No,Date_of_Birth,Image,Gender,Type,ID,Position,Permanent_Address,Present_Address) values ('" + this.FirstName.Text + "','" + this.LastName.Text + "', '" + this.User_Name.Text + "', '" + this.Pass_Word.Text + "', '" + this.Confirm_Password.Text + "', '" + this.Email.Text + "','" + this.MobileNo.Text + "','" + this.date_of_birth_pick.Text + "', @IMG , '" + Gender + "', '" + this.signup_comboBox.Text + "', '" + this.ID_No.Text + "','" + this.Position.Text + "', '" + this.PermanentAddress.Text + "', '" + this.PresentAddress.Text + "'); ";
            }
            else if(signup_comboBox.Text == "TEACHER")
            {
                Query = "insert into coaching_management.teacher (FirstName,LastName,UserName,Password,ConfirmPassword,Email,Mobile_No,Date_of_Birth,Image,Gender,Type,ID,Position,Permanent_Address,Present_Address) values ('" + this.FirstName.Text + "','" + this.LastName.Text + "', '" + this.User_Name.Text + "', '" + this.Pass_Word.Text + "', '" + this.Confirm_Password.Text + "', '" + this.Email.Text + "','" + this.MobileNo.Text + "','" + this.date_of_birth_pick.Text + "', @IMG , '" + Gender + "', '" + this.signup_comboBox.Text + "', '" + this.ID_No.Text + "','" + this.Position.Text + "', '" + this.PermanentAddress.Text + "', '" + this.PresentAddress.Text + "'); ";
            }
            if (ImgLoc == "" || signup_comboBox.Text == "" || Gender == "" || FirstName.Text == "First Name" || LastName.Text == "Last Name" || User_Name.Text == "UserName" || Pass_Word.Text == "Password" || Confirm_Password.Text == "Confirm Password" || Email.Text == "E-mail" || MobileNo.Text == "Mobile No" || PermanentAddress.Text == "Permanent Address" || PresentAddress.Text == "Present Address" || ID_No.Text == "ID No" || Position.Text == "Position")
            {
                MessageBox.Show("Fillup all information...");
            }
            else {
                byte[] imgbt = null;
                FileStream fstream = new FileStream(ImgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imgbt = br.ReadBytes((int)fstream.Length);
                
                
                if (Pass_Word.Text != Confirm_Password.Text)
                {
                    MessageBox.Show("Password doesn't match...");
                }
                else
                {
                    CmdDbs = new MySqlCommand(Query, myConn);
                    MySqlDataReader myReader;
                    try
                    {
                        myConn.Open();
                        CmdDbs.Parameters.Add(new MySqlParameter("@IMG", imgbt));
                        myReader = CmdDbs.ExecuteReader();
                        while (myReader.Read())
                        {
                            byte[] imgg = (byte[])(myReader["Image"]);
                            if (imgg == null)
                            { signup_pictureBox.Image = null; }
                            else
                            {
                                MemoryStream ms = new MemoryStream(imgg);
                                signup_pictureBox.Image = Image.FromStream(ms);
                            }
                        }
                        MessageBox.Show("Successfully SignUp...");
                        
                        myConn.Close();
                    }
                    catch (Exception ex)
                    {
                        myConn.Close();
                        MessageBox.Show(ex.Message);
                    }
                    if (signup_comboBox.Text == "TEACHER")
                        {
                            string query = "INSERT INTO coaching_management.course (teacher_id,image) VALUES ('" + this.ID_No.Text + "',@IMG); ; ";
                            CmdDbs = new MySqlCommand(query, myConn);
                            try
                            {
                                myConn.Open();
                            CmdDbs.Parameters.Add(new MySqlParameter("@IMG", imgbt));
                            myReader = CmdDbs.ExecuteReader();
                                while (myReader.Read())
                                {
                                byte[] imgg = (byte[])(myReader["image"]);
                                if (imgg == null)
                                { signup_pictureBox.Image = null; }
                                else
                                {
                                    MemoryStream ms = new MemoryStream(imgg);
                                    signup_pictureBox.Image = Image.FromStream(ms);
                                }
                            }
                            }
                            catch (Exception)
                            {}
                        }
                    if (signup_comboBox.Text == "STUDENT")
                    {
                        string query = "INSERT INTO coaching_management.course_register_student_details (student_id,image) VALUES ('" + this.ID_No.Text + "',@IMG); ; ";
                        CmdDbs = new MySqlCommand(query, myConn);
                        try
                        {
                            myConn.Open();
                            CmdDbs.Parameters.Add(new MySqlParameter("@IMG", imgbt));
                            myReader = CmdDbs.ExecuteReader();
                            while (myReader.Read())
                            {
                                byte[] imgg = (byte[])(myReader["image"]);
                                if (imgg == null)
                                { signup_pictureBox.Image = null; }
                                else
                                {
                                    MemoryStream ms = new MemoryStream(imgg);
                                    signup_pictureBox.Image = Image.FromStream(ms);
                                }
                            }
                        }
                        catch (Exception)
                        { }
                    }










                    reset_signup();
                    signup_panel.Visible = false;
                    welcome_pictureBox.Visible = true;



                }
            }
        }
        public String Gender;
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
        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox txtbx = (TextBox)sender;
            if (txtbx.Text == txtbx.Name || txtbx.Text == "PassWord" || txtbx.Text == "UserName" || txtbx.Text == "ConfirmPassword" || txtbx.Text == "IDNo")
            {
                txtbx.Text = "";
                if(txtbx == Password || txtbx == Pass_Word || txtbx == Confirm_Password)
                {
                    txtbx.UseSystemPasswordChar = true;
                }
                    txtbx.ForeColor = Color.Black;
            }
        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox txtbx = (TextBox)sender;
            if (txtbx.Text.Length == 0)
            {
                if (txtbx == Password || txtbx == Pass_Word || txtbx == Confirm_Password)
                {
                    txtbx.UseSystemPasswordChar = false;
                }
                txtbx.Text = txtbx.Name;
                if(txtbx == User_Name) { txtbx.Text = "UserName"; }
                if (txtbx == Pass_Word) { txtbx.Text = "PassWord"; }
                if (txtbx == Confirm_Password) { txtbx.Text = "ConfirmPassword"; }
                if (txtbx == ID_No) { txtbx.Text = "IDNo"; }

                txtbx.ForeColor = Color.DarkGray;
            }
        }
        string qry;
        int f = 0;
        Student stOb = new Student();
        Teacher tcOb = new Teacher();
        void login()
        {
            if (login_comboBox.Text == "STUDENT")
            {
                qry = "select * from coaching_management.student where Type = '" + this.login_comboBox.Text + "' And ID = '" + this.IDNo.Text + "' And Password = '" + this.Password.Text + "';";
                f = 0;
            }
            else if (login_comboBox.Text == "TEACHER")
            {
                qry = "select * from coaching_management.teacher where Type = '" + this.login_comboBox.Text + "' And ID = '" + this.IDNo.Text + "' And Password = '" + this.Password.Text + "';";
                f = 1;
            }
            else if (login_comboBox.Text == "ADMIN")
            {
                qry = "select * from coaching_management.admin where Type = '" + this.login_comboBox.Text + "' And ID = '" + this.IDNo.Text + "' And password = '" + this.Password.Text + "';";
                f = 2;
                
            }
            if (login_comboBox.Text == "" || IDNo.Text == "" || Password.Text == "" || IDNo.Text == "UserName" || Password.Text == "Password")
            {
                MessageBox.Show("Fillup your all information...");
            }
            
            else
            {
                try
                {
                    CmdDbs = new MySqlCommand(qry, myConn);
                    MySqlDataReader myReader;
                    myConn.Open();
                    myReader = CmdDbs.ExecuteReader();
                    int count = 0;
                    while (myReader.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 1)
                    {
                        if(f==0)
                        {
                            stOb.Show();
                            Hide();
                            stOb.profile_show(this.IDNo.Text);
                        }
                        else if(f == 1)
                        {
                            tcOb.Show();
                            Hide();
                            tcOb.profile_show(this.IDNo.Text);
                        }
                        else if (f == 2)
                        {
                            Hide();
                            Admin admin = new Admin();
                            admin.ShowDialog();
                            reset_login();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong credentials...");
                    }
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    myConn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            login();
        }
        private void password_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }

        private void MobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != '.')
            {
                e.Handled = true;
            }
        }
    }
}
