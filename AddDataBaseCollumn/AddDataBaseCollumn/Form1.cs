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

namespace AddDataBaseCollumn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            using (SqlConnection sqlConnection = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master"))
            {
                sqlConnection.Open();                

                SqlCommand sqlCommand = new SqlCommand("create database SaleTov", sqlConnection);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                sqlConnection.Close();
            }

            using (SqlConnection sqlConnection = new SqlConnection("Server=localhost;Integrated security=SSPI;database=SaleTov"))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("create table Buyer(id int primary key,firstName nvarchar(MAX),middleName nvarchar(MAX))", sqlConnection);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "create table Seller(id int primary key,firstName nvarchar(MAX), middleName nvarchar(MAX))";

                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                

                sqlCommand.CommandText = "create table Sale(id int primary key,idBuyer int not null,idSeller int not null, Summ int,dateSale dateTime, foreign key(idBuyer) references Buyer(id), foreign key(idSeller) references Seller(id))";                

                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                sqlCommand.CommandText = "INSERT INTO Buyer(id, firstName, middleName) Values (1,'Vasi','Tasi')";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "INSERT INTO Buyer(id, firstName, middleName) Values (2,'Nurj','Kase')";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "INSERT INTO Buyer(id, firstName, middleName) Values (3,'Ali','Ken')";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = "INSERT INTO Seller(id, firstName, middleName) Values (1,'Mol','Nur')";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "INSERT INTO Seller(id, firstName, middleName) Values (2,'sta','Kit')";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "INSERT INTO Seller(id, firstName, middleName) Values (3,'Olz','Bar')";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = "INSERT INTO Sale(id, idBuyer, idSeller, Summ, dateSale) Values (1, 1, 2, 3000, getdate())";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "INSERT INTO Sale(id, idBuyer, idSeller, Summ, dateSale) Values (2, 3, 2, 4000, getdate())";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "INSERT INTO Sale(id, idBuyer, idSeller, Summ, dateSale) Values (3, 2, 1, 5000, getdate())";
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonShowTable_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Server=localhost;Integrated security=SSPI;database=SaleTov"))
            {
                string command = "select * from ";
                string tableSeller = "Seller", tableSele = "Sale", tableBuyer = "Buyer";

                sqlConnection.Open();

                if (comboBox1.Text.ToString() == tableSeller)
                {
                    SqlCommand sqlCommand = new SqlCommand(command + tableSeller, sqlConnection);

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        List<string[]> data = new List<string[]>();

                        dataGridView.Rows.Clear();
                        dataGridView.BringToFront();

                        while (sqlDataReader.Read())
                        {
                            data.Add(new string[3]);
                            data[data.Count - 1][0] = sqlDataReader[0].ToString();
                            data[data.Count - 1][1] = sqlDataReader[1].ToString();
                            data[data.Count - 1][2] = sqlDataReader[2].ToString();
                        }

                        foreach (string[] s in data)
                            dataGridView.Rows.Add(s);
                    }
                }

                else if (comboBox1.Text.ToString() == tableSele)
                {
                    SqlCommand sqlCommand = new SqlCommand(command + tableSele, sqlConnection);

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        dataGridView1.BringToFront();
                        dataGridView1.Rows.Clear();

                        List<string[]> data = new List<string[]>();

                        while (sqlDataReader.Read())
                        {
                            data.Add(new string[5]);
                            data[data.Count - 1][0] = sqlDataReader[0].ToString();
                            data[data.Count - 1][1] = sqlDataReader[1].ToString();
                            data[data.Count - 1][2] = sqlDataReader[2].ToString();
                            data[data.Count - 1][3] = sqlDataReader[3].ToString();
                            data[data.Count - 1][4] = sqlDataReader[4].ToString();
                        }

                        foreach (string[] s in data)
                            dataGridView1.Rows.Add(s);
                    }
                }

                else if (comboBox1.Text.ToString() == tableBuyer)
                {
                    SqlCommand sqlCommand = new SqlCommand(command + tableBuyer, sqlConnection);

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        List<string[]> data = new List<string[]>();

                        dataGridView.Rows.Clear();
                        dataGridView.BringToFront();

                        while (sqlDataReader.Read())
                        {
                            data.Add(new string[3]);
                            data[data.Count - 1][0] = sqlDataReader[0].ToString();
                            data[data.Count - 1][1] = sqlDataReader[1].ToString();
                            data[data.Count - 1][2] = sqlDataReader[2].ToString();
                        }

                        foreach (string[] s in data)
                            dataGridView.Rows.Add(s);
                    }
                }

                sqlConnection.Close();
            }
        }
    }
}
