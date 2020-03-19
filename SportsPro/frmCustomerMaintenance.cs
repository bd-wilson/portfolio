using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SportsPro
{
    
    public partial class frmCustomerMaintenance : Form
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TechSupport;Integrated Security=True";
        //This is a snapshot of your database that is instantiated when the form class is created (instantiated into an object)
        TechSupportDataSet db = new TechSupportDataSet(); 


        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        
       private void frmCustomerMaintenance_Load(object sender, EventArgs e)
        {
            PopulateCustomerCollection();

            cboCustSelectMenu.ValueMember = "CustomerID";
            cboCustSelectMenu.DisplayMember = "CustomerName";
          
        }



       class ComboBoxItem
       {
           public string DisplayText { get; set; }
           public object Value { get; set; }

           public override string ToString()
           {
               return DisplayText;
           }
       }
        
        
    private void PopulateCustomerCollection()
    {
        //Populate the Customers combobox (dropdownlist)
        var customersQuery = from a in db.Customers
                             orderby a.Name ascending //sort by name, ascending
                             select a; //Mimics SELECT * FROM Customers, or get everything from the customers table

        if (customersQuery.Any()) //ALWAYS do this! Checks to see if the query returned anything
        {
            foreach (var customer in customersQuery) //Loop through each record in the query results
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem(); 

                comboBoxItem.DisplayText = customer.Name; //Text to display to user on UI
                comboBoxItem.Value = customer.CustomerID; //Integer value being stored as an object for easy casting back to integer later

                cboCustSelectMenu.Items.Add(comboBoxItem); //Add item to combo box
            }
        }
       // cboCustSelectMenu.DataSource = customerList;
        
            }


    private void cboCustSelectMenu_SelectedIndexChanged(object sender, EventArgs e)
    {
        ComboBoxItem comboBoxItemSelected = (ComboBoxItem)cboCustSelectMenu.SelectedItem; //Cast the combobox item back to the type we created

        int customerIDSelected = (int)comboBoxItemSelected.Value; //Cast whatever index the user selected as an integer

        lblCustomerID.Text = customerIDSelected.ToString();

    }

    private void btnSelectCustomer_Click(object sender, EventArgs e)
    {   
        
        ComboBoxItem selectedCustomer = (ComboBoxItem)cboCustSelectMenu.SelectedItem; //Dim selectedCustomer as Customer = CType(cboCustomers.SelectedItem, Customer)

        int selectedCustomerID = (int)selectedCustomer.Value; //VB: Dim customerID as Integer = selectedCustomer.CustomerID

        var query = from a in db.Customers
                    where a.CustomerID == selectedCustomerID
                    select a; //VB: Dim query = from ...

        if (query.Any()) //You must do this or else risk a runtime error
        {
            lblCustomerID.Text = query.FirstOrDefault().CustomerID.ToString();
            txtName.Text = query.FirstOrDefault().Name.ToString();
            txtAddress.Text = query.FirstOrDefault().Address.ToString();
            txtCity.Text = query.FirstOrDefault().City.ToString();
            txtState.Text = query.FirstOrDefault().State.ToString();
            txtZip.Text = query.FirstOrDefault().ZipCode.ToString();
            txtPhone.Text = query.FirstOrDefault().Phone.ToString();
            txtEmail.Text = query.FirstOrDefault().Email.ToString();
        }
    }

    private void btnSubmitCustChanges_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "p_UpdateCustomer_u";
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
