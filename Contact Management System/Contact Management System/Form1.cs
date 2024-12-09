using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using MySql.Data.MySqlClient;
using PdfDocument = iText.Layout.Document;
using System.Data;
using System.Diagnostics;
using OfficeOpenXml;
using System.IO;
using System.Reflection.Metadata;

namespace Contact_Management_System
{
    public partial class Form1 : Form
    {
        MySqlConnection connect = new MySqlConnection("SERVER=LOCALHOST;DATABASE=mydb ;UID=root ;PASSWORD=blueharvey28");
        public Form1()
        {
            InitializeComponent();
        }

        private void ViewDataBtn_Click(object sender, EventArgs e)
        {
            viewGridData();
        }
        void viewGridData()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM contacttable", connect);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ClearTextBox()
        {
            firstNameTxt.Clear();
            midNameTxt.Clear();
            lastNameTxt.Clear();
            contactTxt.Clear();
            emailTxt.Clear();
            statusTxt.Clear();
            citizenTxt.Clear();
            regNoTxt.Clear();
        }
        private void instertBtn_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(" insert into contacttable(RegNo,FirstName,MiddleName,LastName,ContactNo,Email,Address,Citizenship) values(" + regNoTxt.Text + ",'" + firstNameTxt.Text + "','" + midNameTxt.Text + "','" + lastNameTxt.Text + "'," + contactTxt.Text + ",'" + emailTxt.Text + "','" + statusTxt.Text + "','" + citizenTxt.Text + "')", connect);
                DataSet ds = new DataSet();

                da.Fill(ds);

                MessageBox.Show("Added Successfully!");

                viewGridData();

                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input: Can't Insert.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string update = " update contacttable set RegNo =" + regNoTxt.Text + ",FirstName ='" + firstNameTxt.Text + "', MiddleName='" + midNameTxt.Text + "',LastName= '" + lastNameTxt.Text + "',ContactNo=" + contactTxt.Text + ", Email='" + emailTxt.Text + "',Address='" + statusTxt.Text + "',Citizenship='" + citizenTxt.Text + "' where SortNo=" + dataGridView1.SelectedRows[0].Cells[0].Value + " ";
                MySqlDataAdapter da = new MySqlDataAdapter(update, connect);
                DataSet ds = new DataSet();

                da.Fill(ds);

                MessageBox.Show("Updated Successfully!");

                viewGridData();

                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong: Can't Update.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string delete = "delete from contacttable where RegNo=" + deleteBox.Text + " ";
                MySqlDataAdapter da = new MySqlDataAdapter(delete, connect);
                DataSet ds = new DataSet();

                da.Fill(ds);

                MessageBox.Show("Deleted Successfully!");

                viewGridData();

                ClearTextBox();
                deleteBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong: Can't Delete.");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            viewGridData();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Save Excel File"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("Contacts");

                        for (int col = 0; col < dataGridView1.Columns.Count; col++)
                        {
                            worksheet.Cells[1, col + 1].Value = dataGridView1.Columns[col].HeaderText;
                        }

                        for (int row = 0; row < dataGridView1.Rows.Count; row++)
                        {
                            if (!dataGridView1.Rows[row].IsNewRow)
                            {
                                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                                {
                                    worksheet.Cells[row + 2, col + 1].Value = dataGridView1.Rows[row].Cells[col].Value?.ToString();
                                }
                            }
                        }
                        FileInfo fi = new FileInfo(filePath);
                        package.SaveAs(fi);
                    }

                    MessageBox.Show("Data exported successfully to Excel!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchQuery = searchBox.Text.Trim();


            if (string.IsNullOrEmpty(searchQuery))
            {
                viewGridData();
            }
            else
            {
                SearchData(searchQuery);
            }

        }
        void SearchData(string searchQuery)
        {
            try
            {
                string query = "SELECT * FROM contacttable WHERE FirstName LIKE @searchQuery OR LastName LIKE @searchQuery";
                MySqlDataAdapter da = new MySqlDataAdapter(query, connect);
                da.SelectCommand.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                DataSet ds = new DataSet();

                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
