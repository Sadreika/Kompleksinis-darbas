
using System;

namespace GUI
{
    partial class DateAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.isvykimoDataLabel = new System.Windows.Forms.Label();
            this.atvykimoDataLabel = new System.Windows.Forms.Label();
            this.isvykimoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.atvykimoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isRt = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.dateListdataGridView = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.IsvykimoDataWarningLabel = new System.Windows.Forms.Label();
            this.atvykimoDataWarningLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dateListdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // isvykimoDataLabel
            // 
            this.isvykimoDataLabel.AutoSize = true;
            this.isvykimoDataLabel.Location = new System.Drawing.Point(26, 31);
            this.isvykimoDataLabel.Name = "isvykimoDataLabel";
            this.isvykimoDataLabel.Size = new System.Drawing.Size(93, 17);
            this.isvykimoDataLabel.TabIndex = 0;
            this.isvykimoDataLabel.Text = "Išvykimo data";
            // 
            // atvykimoDataLabel
            // 
            this.atvykimoDataLabel.AutoSize = true;
            this.atvykimoDataLabel.Location = new System.Drawing.Point(26, 84);
            this.atvykimoDataLabel.Name = "atvykimoDataLabel";
            this.atvykimoDataLabel.Size = new System.Drawing.Size(96, 17);
            this.atvykimoDataLabel.TabIndex = 1;
            this.atvykimoDataLabel.Text = "Atvykimo data";
            // 
            // isvykimoDateTimePicker
            // 
            this.isvykimoDateTimePicker.Location = new System.Drawing.Point(191, 31);
            this.isvykimoDateTimePicker.MinDate = new System.DateTime(2020, 12, 23, 15, 58, 49, 149);
            this.isvykimoDateTimePicker.Name = "isvykimoDateTimePicker";
            this.isvykimoDateTimePicker.Size = new System.Drawing.Size(248, 22);
            this.isvykimoDateTimePicker.TabIndex = 2;
            this.isvykimoDateTimePicker.Value = new System.DateTime(2020, 12, 23, 15, 58, 49, 149);
            // 
            // atvykimoDateTimePicker
            // 
            this.atvykimoDateTimePicker.Enabled = false;
            this.atvykimoDateTimePicker.Location = new System.Drawing.Point(191, 84);
            this.atvykimoDateTimePicker.MinDate = new System.DateTime(2020, 12, 23, 15, 58, 49, 150);
            this.atvykimoDateTimePicker.Name = "atvykimoDateTimePicker";
            this.atvykimoDateTimePicker.Size = new System.Drawing.Size(248, 22);
            this.atvykimoDateTimePicker.TabIndex = 3;
            this.atvykimoDateTimePicker.Value = new System.DateTime(2020, 12, 23, 15, 58, 49, 150);
            // 
            // isRt
            // 
            this.isRt.AutoSize = true;
            this.isRt.Location = new System.Drawing.Point(29, 133);
            this.isRt.Name = "isRt";
            this.isRt.Size = new System.Drawing.Size(130, 21);
            this.isRt.TabIndex = 4;
            this.isRt.Text = "Dvipusė kelionė";
            this.isRt.UseVisualStyleBackColor = true;
            this.isRt.CheckedChanged += new System.EventHandler(this.DvipuseKelioneCheckBox_CheckedChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(191, 131);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Pridėti";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dateListdataGridView
            // 
            this.dateListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dateListdataGridView.Location = new System.Drawing.Point(29, 189);
            this.dateListdataGridView.Name = "dateListdataGridView";
            this.dateListdataGridView.RowHeadersWidth = 51;
            this.dateListdataGridView.RowTemplate.Height = 24;
            this.dateListdataGridView.Size = new System.Drawing.Size(436, 407);
            this.dateListdataGridView.TabIndex = 6;
            this.dateListdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DateListdataGridView_CellClick);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(364, 131);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Pašalinti";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // IsvykimoDataWarningLabel
            // 
            this.IsvykimoDataWarningLabel.AutoSize = true;
            this.IsvykimoDataWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.IsvykimoDataWarningLabel.Location = new System.Drawing.Point(450, 31);
            this.IsvykimoDataWarningLabel.Name = "IsvykimoDataWarningLabel";
            this.IsvykimoDataWarningLabel.Size = new System.Drawing.Size(11, 17);
            this.IsvykimoDataWarningLabel.TabIndex = 8;
            this.IsvykimoDataWarningLabel.Text = "!";
            this.IsvykimoDataWarningLabel.Visible = false;
            // 
            // atvykimoDataWarningLabel
            // 
            this.atvykimoDataWarningLabel.AutoSize = true;
            this.atvykimoDataWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.atvykimoDataWarningLabel.Location = new System.Drawing.Point(450, 89);
            this.atvykimoDataWarningLabel.Name = "atvykimoDataWarningLabel";
            this.atvykimoDataWarningLabel.Size = new System.Drawing.Size(11, 17);
            this.atvykimoDataWarningLabel.TabIndex = 9;
            this.atvykimoDataWarningLabel.Text = "!";
            this.atvykimoDataWarningLabel.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(210, 602);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Išsaugoti";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DateAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 632);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.atvykimoDataWarningLabel);
            this.Controls.Add(this.IsvykimoDataWarningLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.dateListdataGridView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.isRt);
            this.Controls.Add(this.atvykimoDateTimePicker);
            this.Controls.Add(this.isvykimoDateTimePicker);
            this.Controls.Add(this.atvykimoDataLabel);
            this.Controls.Add(this.isvykimoDataLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DateAddForm";
            this.Text = "Laikų pridėjimo langas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DateAddForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dateListdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isvykimoDataLabel;
        private System.Windows.Forms.Label atvykimoDataLabel;
        private System.Windows.Forms.DateTimePicker isvykimoDateTimePicker;
        private System.Windows.Forms.DateTimePicker atvykimoDateTimePicker;
        private System.Windows.Forms.CheckBox isRt;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dateListdataGridView;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label IsvykimoDataWarningLabel;
        private System.Windows.Forms.Label atvykimoDataWarningLabel;
        private System.Windows.Forms.Button saveButton;
    }
}