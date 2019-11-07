using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace Database_entry
{
    public partial class Form1 : Form
    {

        //Data Source=HARIHARAN-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True

       // string connectStr = "Data Source=HARIHARAN-PC\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

     public SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=BrianTestDatabase;Integrated Security=True");

        

    //   public string imgLocation = "";
        

        public Form1()
        {
            InitializeComponent();
            conn.Open();

        }

 

    


        private void btnQuit_Click(object sender, System.EventArgs e)
        {
        
             System.Environment.Exit(1);

        }

        private void btnUpload_Click(object sender, System.EventArgs e)
        {
        
               try
            {
                
               // int PeopleID = int.Parse(TxtPeopleID.Text);          

                string SQLquery = "INSERT INTO People(PeopleID, Fname, Lname, City, State) VALUES("+txtPeopleID.Text+",'"+txtFname.Text+"','"+txtLname.Text+"','"+txtCity.Text+"','"+txtState.Text +"'"+ ")";


                SqlCommand Command = new SqlCommand(SQLquery, conn);

                SqlCommand Command2;


                if (radioBtnYes.Checked)
                {

                    string SQLquery2 = "INSERT INTO Employee(EmployeeID, Dept, PeopleID ) VALUES(" + txtEmployeeID.Text + ",'" + txtDept.Text + "','" + txtPeopleID.Text +"'" + ")";


                    Command2 = new SqlCommand(SQLquery2, conn);

                    int x = Command2.ExecuteNonQuery();

                   MessageBox.Show(x.ToString() + " record(s) saved. ");


                }


               
              int x2 = Command.ExecuteNonQuery();
              
             MessageBox.Show(x2.ToString() + " record(s) saved. ");

             
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnVerify_Click(object sender, System.EventArgs e)
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

       
    


    }
}

