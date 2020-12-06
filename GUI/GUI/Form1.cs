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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            prepareTextBoxes();
            prepareComboBoxes();
        }

        private void prepareTextBoxes()
        {
            string[] suggestionsArray = { "SAS", "Fly540", "Alaska Airlines", "StarPeru" }; //iš db ims
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(suggestionsArray);
            avialinijatextBox.AutoCompleteCustomSource = collection;
        }

        private void prepareComboBoxes()
        {
            string[] suggestionsArray = new string[] { "Ekonominė", "Verslo", "Premium", "Pirma"};
            klaseComboBox.Items.AddRange(suggestionsArray);
            Controls.Add(klaseComboBox);
        }

        private void ieskotiButton_Click(object sender, EventArgs e)
        {

        }
    }
}
