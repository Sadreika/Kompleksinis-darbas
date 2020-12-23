using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using StarPeru;

namespace GUI
{
    public partial class MainForm : Form
    {
        private string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=FlightsDatabase;Integrated Security=True";
        public MainForm()
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

            if(isSearchCriteriaCorrect(origin, destination, departureDate, arrivalDate, flightClass, isRt))
            {
                string searchCriteria = FormAndGiveSearchCriteriaToCrawler(origin, destination, departureDate, arrivalDate, flightClass, isRt);
                //StarPeru.Program.StartStarPeruFromGUI(searchCriteria);
                ShowMessage();
                surinktiDuomenysdataGridView.Update();
                surinktiDuomenysdataGridView.Refresh();
            }
            else
            {
                EmptyFieldMessage();
            }
        }
        private bool isSearchCriteriaCorrect(string origin, string destination, DateTime departureDate, DateTime arrivalDate, string flightClass, bool isRt)
        {
            bool isCorrect = true;
            TimeSpan ts = new TimeSpan(23, 59, 59);
            departureDate = departureDate.Date + ts;
            arrivalDate = arrivalDate.Date + ts;

            isvykimoOroUostasWarning.Visible = false;
            atvykimoOroUostasWarning.Visible = false;
            isvykimoDataWarning.Visible = false;
            atvykimoDataWarning.Visible = false;

            if (origin == "")
            {
                isCorrect = false;
                isvykimoOroUostasWarning.Visible = true;
            }
            if (destination == "")
            {
                isCorrect = false;
                atvykimoOroUostasWarning.Visible = true;
            }  
            if(isRt)
            {
                if(departureDate >= arrivalDate)
                {
                    isCorrect = false;
                    isvykimoDataWarning.Visible = true;
                    atvykimoDataWarning.Visible = true;
                }
            }
            return isCorrect;
        }
        private void ShowMessage()
        {
            string message = "Paieška baigta";
            string caption = "Pranešimas";
            var result = MessageBox.Show(message, caption,MessageBoxButtons.OK);
        }
        private void EmptyFieldMessage()
        {
            string message = "Paieškos kriterijai užpildyti neteisingai";
            string caption = "Klaidos pranešimas";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
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
        private void isRtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(isRtCheckBox.Checked)
            {
                atvykimoDataDateTimePicker.Enabled = true;
            }
            else
            {
                atvykimoDataDateTimePicker.Enabled = false;
            }
        }

        private void pridetiButton_Click(object sender, EventArgs e)
        {
            DateAddForm dateAddForm = new DateAddForm();
            dateAddForm.Show();
        }
    }
}
