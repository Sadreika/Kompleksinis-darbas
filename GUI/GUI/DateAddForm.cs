using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DateAddForm : Form
    {
        public List<Dates> DateList = new List<Dates>();
        public DateAddForm()
        {
            InitializeComponent();
        }

        private void dvipuseKelioneCheckBox_CheckedChanged(object sender, EventArgs e)
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

        private void addButton_Click(object sender, EventArgs e)
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

                }
            }
        }
    }
}
