using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Don't forget this or none of this will work, ever.

namespace SportsPro
{
    public partial class frmCustomerInput : Form
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TechSupport;Integrated Security=True";

        public frmCustomerInput()
        {
            InitializeComponent();
        }

        private void btnInsertCustomer_Click(object sender, EventArgs e)
        {
            
            //Simple input validation
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtAddress.Text) && !string.IsNullOrWhiteSpace(txtCity.Text) &&
                !string.IsNullOrWhiteSpace(txtState.Text) && !string.IsNullOrWhiteSpace(txtZip.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !string.IsNullOrWhiteSpace(txtPhone.Text)) //Checks to see if user actually entered something in textbox before proceeding
            {
                //Do our DB operation here
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "p_InsertCustomer_i";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Name", txtName.Text)); //Param name must match param name from stored procedure
                    cmd.Parameters.Add(new SqlParameter("@Address", txtAddress.Text));
                    cmd.Parameters.Add(new SqlParameter("@City", txtCity.Text));
                    cmd.Parameters.Add(new SqlParameter("@State", txtState.Text));
                    cmd.Parameters.Add(new SqlParameter("@Zip", txtZip.Text));
                    cmd.Parameters.Add(new SqlParameter("@Email", txtEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@Phone", txtPhone.Text));

                connection.Open();//Must open your connection or this will fail
                cmd.ExecuteNonQuery(); //Execute your statement here - is nonquery because it's a stored procedure and we don't care about any return values

                int t = cmd.ExecuteNonQuery();
                if (t != 0)
                {
                    MessageBox.Show("Data entered successfully into database.");
                }
                connection.Close();

            }

            else
            {
                MessageBox.Show("One or more fields are empty. Please fill out all fields.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


 
        }


    }
}
