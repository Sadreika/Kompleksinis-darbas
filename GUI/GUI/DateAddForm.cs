using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class DateAddForm : Form
    {
        public List<Dates> DateList = new List<Dates>();
        public DateAddForm()
        {
            InitializeComponent();
            FillDateListdataGridViewWithDates();
        }

        private void FillDateListdataGridViewWithDates()
        {    
            DataTable data = new DataTable();
            data.Columns.Add("Departure date");
            data.Columns.Add("Arrival date");

            foreach(Dates date in DateList)
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
    }
}
