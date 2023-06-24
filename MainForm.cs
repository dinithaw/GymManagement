using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GymManagement
{
    public partial class GMS : Form
    {
        public GMS()
        {
            InitializeComponent();
          
            dashboardControl1.BringToFront();
            dashboardbtn.BackColor = ColorTranslator.FromHtml("#E8290B");
        }

        // x (close button)
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // minimizing button
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        // dashboard button
        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            dashboardControl1.BringToFront();
            NavTitle.Text = "DashBoard";
     
        }

        // add members button
        private void addmembersbtn_Click(object sender, EventArgs e)
        {
            addMemberControl1.BringToFront();
            NavTitle.Text = "Add Members";
        }

        // add equipment button
        private void AddEquipmentsbtn_Click(object sender, EventArgs e)
        {
            addEquipmentsControl1.BringToFront();
            NavTitle.Text = "Add Equipments";
        }

        // view members button
        private void ViewMembersBtn_Click(object sender, EventArgs e)
        {
            viewMembers1.BringToFront();
            NavTitle.Text = "View Members";
        }

        // view equipments button
        private void ViewEquipmentBtn_Click(object sender, EventArgs e)
        {
            viewEquipmentControls1.BringToFront();
            NavTitle.Text = "View Equipments";
        }

        //edit members button
        private void RemoveMemberBtn_Click(object sender, EventArgs e)
        {
            addstaff1.BringToFront();
            NavTitle.Text = "Add Staff";
        }

        //gym staff button
        private void GymStaffRecord_Click(object sender, EventArgs e)
        {
            gymStaffControls1.BringToFront();
            NavTitle.Text = "Gym Staff";
        }


        // on load GMS form or application
        private void GMS_Load(object sender, EventArgs e)
        {
            namelabel.Text = "Welcome back " + username;
        }

        string username = LoginPage.User;
        string usertype = LoginPage.usertype;


        // jump into admin settings
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(usertype == "Admin")
            {
                AdminSettings ads = new AdminSettings();
                ads.Show();
            }
            else if(usertype == "User")
            {
                MessageBox.Show("Only Admins Can Login this page, Please Login As Admin", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            this.Hide();
            lp.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
