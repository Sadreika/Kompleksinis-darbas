namespace GUI
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;
    public partial class DateAddForm : Form
    {
        public List<Dates> DateList = new List<Dates>();
        private MainForm Mainform { get; set; }
        private int SelectedRow { get; set; }
        public DateAddForm(MainForm mainform)
        {
            InitializeComponent();
            this.Mainform = mainform;
            mainform.Enabled = false;
            FillDateList();
            FillDateListdataGridViewWithDates();
        }
        public void FillDateList()
        {
            DateList.AddRange(Mainform.DateList);
        }
        private void FillDateListdataGridViewWithDates()
        {
            DataTable data = new DataTable();
            data.Columns.Add("Departure date");
            data.Columns.Add("Arrival date");

            foreach (Dates date in DateList)
            {
                data.Rows.Add(date.departureDate, date.arrivalDate);
            }

            dateListdataGridView.DataSource = data;
            dateListdataGridView.Columns[0].Width = 145;
            dateListdataGridView.Columns[1].Width = 145;
        }
        private void DvipuseKelioneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isRt.Checked)
            {
                atvykimoDateTimePicker.Enabled = true;
            }
            else
            {
                atvykimoDateTimePicker.Enabled = false;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            IsvykimoDataWarningLabel.Visible = false;
            atvykimoDataWarningLabel.Visible = false;
            if (isRt.Checked)
            {
                if (isvykimoDateTimePicker.Value >= atvykimoDateTimePicker.Value)
                {
                    IsvykimoDataWarningLabel.Visible = true;
                    atvykimoDataWarningLabel.Visible = true;
                }
                else
                {
                    Dates dates = new Dates(isvykimoDateTimePicker.Value, atvykimoDateTimePicker.Value);
                    DateList.Add(dates);
                }
            }
            else
            {
                Dates dates = new Dates(isvykimoDateTimePicker.Value);
                DateList.Add(dates);
            }
            FillDateListdataGridViewWithDates();
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateList.RemoveAt(SelectedRow);
                FillDateListdataGridViewWithDates();
            }
            catch
            {
                string message = "Pasirinkite eilutę, kurią norite pašalinti";
                string caption = "Pranešimas";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
        }
        private void DateListdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dateListdataGridView.Rows[e.RowIndex];
                SelectedRow = row.Index;
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Mainform.Enabled = true;
            Mainform.FillDateList(DateList);
            this.Close();
        }
        private void DateAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mainform.Enabled = true;
        }
    }
}
