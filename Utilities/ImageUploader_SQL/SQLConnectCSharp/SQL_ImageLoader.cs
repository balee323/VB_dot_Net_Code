using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace SQLConnectCSharp
{
    public partial class Form1 : Form
    {

        //Data Source=HARIHARAN-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True

       // string connectStr = "Data Source=HARIHARAN-PC\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

  //   public SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=BrianTestDatabase;Integrated Security=True");

        public SqlConnection conn = new SqlConnection("server=\\SBSDEV1;Initial Catalog=BrianTestDatabase;Integrated Security=True");

       public string imgLocation = "";
        

        public Form1()
        {
            InitializeComponent();
            conn.Open();
            
       
          //  MessageBox.Show("hHide");


        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                OpenFileDialog open = new OpenFileDialog();

                open.Filter = "JPG Files (*.jpg)|*.jpg";
                open.Title = "Select jpg image file";

                open.ShowDialog();
                imgLocation = open.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);


                //int PeopleID = int.Parse(TxtPeopleID.Text);          

                string SQLquery = "INSERT INTO ProfilePictures(ImageID, PeopleID, image) VALUES(" +"'" +TxtImageID.Text+"','"+TxtPeopleID.Text+"',@img)";
                SqlCommand Command = new SqlCommand(SQLquery, conn);
                Command.Parameters.AddWithValue("@img", img);
                int x = Command.ExecuteNonQuery();

                MessageBox.Show(x.ToString() + " record(s) saved. ");

             
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("connection Open");

            }
            else
            {
                conn.Open();
            }


        }

        private void TxtImageID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            TxtImageID.Text = null;
            TxtPeopleID.Text = null;

            pictureBox1.Image = null;

        }


    }
}
