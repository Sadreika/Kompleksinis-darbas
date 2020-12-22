using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using StarPeru;

namespace GUI
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=FlightsDatabase;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            prepareTextBoxes();
            prepareComboBoxes();
            FillDataGridViewWithFlights();
        }

        private void prepareTextBoxes()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Airline FROM [FlightsDatabase].[dbo].[Airlines]", connection);
            
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            List<string> suggestionsList = data.Rows.OfType<DataRow>().Select(x => x.Field<string>("Airline")).ToList();
            
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(suggestionsList.ToArray());
            avialinijatextBox.AutoCompleteCustomSource = collection;

            connection.Close();
        }

        private void prepareComboBoxes()
        {
            string[] suggestionsArray = new string[] { "Ekonominė", "Verslo", "Premium", "Pirma" };
            klaseComboBox.Items.AddRange(suggestionsArray);
            Controls.Add(klaseComboBox);
        }

        private void ieskotiButton_Click(object sender, EventArgs e)
        {
            string origin = isvykimoOroUostastextBox.Text.ToUpper();
            string destination = atvykimoOroUostastextBox.Text.ToUpper();
            DateTime departureDate = isvykimoDataDateTimePicker.Value;
            DateTime arrivalDate = atvykimoDataDateTimePicker.Value;
            string flightClass = klaseComboBox.Text;
            switch (flightClass)
            {
                case "Ekonominė":
                    flightClass = "E";
                    break;
                case "Verslo":
                    flightClass = "B";
                    break;
                case "Premium":
                    flightClass = "P";
                    break;
                case "Pirma":
                    flightClass = "F";
                    break;
                default:
                    break;
            }
            bool isRt = isRtCheckBox.Checked;
            string searchCriteria = FormAndGiveSearchCriteriaToCrawler(origin, destination, departureDate, arrivalDate, flightClass, isRt);
            //StarPeru.Program.StartStarPeruFromGUI(searchCriteria);
            ShowMessage();
            surinktiDuomenysdataGridView.Update();
            surinktiDuomenysdataGridView.Refresh();
        }
        private void ShowMessage()
        {
            string message = "Paieška baigta";
            string caption = "Pranešimas";
            var result = MessageBox.Show(message, caption,MessageBoxButtons.OK);
        }
        private void FillDataGridViewWithFlights()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [FlightsDatabase].[dbo].[StarPeru]", connection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            surinktiDuomenysdataGridView.DataSource = data;
            connection.Close();
        }
        private string FormAndGiveSearchCriteriaToCrawler(string origin, string destination, DateTime departureDate, DateTime arrivalDate, string flightClass, bool isRt)
        {
            string isRtString = isRt ? "R" : "O";
            return origin + "|" + destination + "|" +
                departureDate.Year + "|" + departureDate.Month + "|" + departureDate.Day + "|" +
                arrivalDate.Year + "|" + arrivalDate.Month + "|" + arrivalDate.Day + "|" +
                flightClass + "|" + isRtString;
        }
    }
}
