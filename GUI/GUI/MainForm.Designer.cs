
using System;

namespace GUI
{
    partial class MainForm
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
            this.ieskotiButton = new System.Windows.Forms.Button();
            this.avialinijaLabel = new System.Windows.Forms.Label();
            this.isvykimoOroUostasLabel = new System.Windows.Forms.Label();
            this.atvykimoOroUostasLabel = new System.Windows.Forms.Label();
            this.klaseLabel = new System.Windows.Forms.Label();
            this.IsvykimoDataLabel = new System.Windows.Forms.Label();
            this.AtvykimoDataLabel = new System.Windows.Forms.Label();
            this.avialinijatextBox = new System.Windows.Forms.TextBox();
            this.isvykimoOroUostastextBox = new System.Windows.Forms.TextBox();
            this.atvykimoOroUostastextBox = new System.Windows.Forms.TextBox();
            this.isRtCheckBox = new System.Windows.Forms.CheckBox();
            this.surinktiDuomenysdataGridView = new System.Windows.Forms.DataGridView();
            this.klaseComboBox = new System.Windows.Forms.ComboBox();
            this.pridetiButton = new System.Windows.Forms.Button();
            this.isvykimoDataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.atvykimoDataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isvykimoOroUostasWarning = new System.Windows.Forms.Label();
            this.atvykimoOroUostasWarning = new System.Windows.Forms.Label();
            this.isvykimoDataWarning = new System.Windows.Forms.Label();
            this.atvykimoDataWarning = new System.Windows.Forms.Label();
            this.visiAvialinijosSkrydziaiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.surinktiDuomenysdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ieskotiButton
            // 
            this.ieskotiButton.Location = new System.Drawing.Point(1194, 53);
            this.ieskotiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ieskotiButton.Name = "ieskotiButton";
            this.ieskotiButton.Size = new System.Drawing.Size(136, 30);
            this.ieskotiButton.TabIndex = 0;
            this.ieskotiButton.Text = "Ieškoti";
            this.ieskotiButton.UseVisualStyleBackColor = true;
            this.ieskotiButton.Click += new System.EventHandler(this.ieskotiButton_Click);
            // 
            // avialinijaLabel
            // 
            this.avialinijaLabel.AutoSize = true;
            this.avialinijaLabel.Location = new System.Drawing.Point(25, 22);
            this.avialinijaLabel.Name = "avialinijaLabel";
            this.avialinijaLabel.Size = new System.Drawing.Size(63, 17);
            this.avialinijaLabel.TabIndex = 1;
            this.avialinijaLabel.Text = "Avialinija";
            // 
            // isvykimoOroUostasLabel
            // 
            this.isvykimoOroUostasLabel.AutoSize = true;
            this.isvykimoOroUostasLabel.Location = new System.Drawing.Point(298, 19);
            this.isvykimoOroUostasLabel.Name = "isvykimoOroUostasLabel";
            this.isvykimoOroUostasLabel.Size = new System.Drawing.Size(132, 17);
            this.isvykimoOroUostasLabel.TabIndex = 2;
            this.isvykimoOroUostasLabel.Text = "Išvykimo oro uostas";
            // 
            // atvykimoOroUostasLabel
            // 
            this.atvykimoOroUostasLabel.AutoSize = true;
            this.atvykimoOroUostasLabel.Location = new System.Drawing.Point(298, 61);
            this.atvykimoOroUostasLabel.Name = "atvykimoOroUostasLabel";
            this.atvykimoOroUostasLabel.Size = new System.Drawing.Size(135, 17);
            this.atvykimoOroUostasLabel.TabIndex = 3;
            this.atvykimoOroUostasLabel.Text = "Atvykimo oro uostas";
            // 
            // klaseLabel
            // 
            this.klaseLabel.AutoSize = true;
            this.klaseLabel.Location = new System.Drawing.Point(993, 23);
            this.klaseLabel.Name = "klaseLabel";
            this.klaseLabel.Size = new System.Drawing.Size(43, 17);
            this.klaseLabel.TabIndex = 4;
            this.klaseLabel.Text = "Klasė";
            // 
            // IsvykimoDataLabel
            // 
            this.IsvykimoDataLabel.AutoSize = true;
            this.IsvykimoDataLabel.Location = new System.Drawing.Point(571, 19);
            this.IsvykimoDataLabel.Name = "IsvykimoDataLabel";
            this.IsvykimoDataLabel.Size = new System.Drawing.Size(93, 17);
            this.IsvykimoDataLabel.TabIndex = 5;
            this.IsvykimoDataLabel.Text = "Išvykimo data";
            // 
            // AtvykimoDataLabel
            // 
            this.AtvykimoDataLabel.AutoSize = true;
            this.AtvykimoDataLabel.Location = new System.Drawing.Point(569, 61);
            this.AtvykimoDataLabel.Name = "AtvykimoDataLabel";
            this.AtvykimoDataLabel.Size = new System.Drawing.Size(96, 17);
            this.AtvykimoDataLabel.TabIndex = 6;
            this.AtvykimoDataLabel.Text = "Atvykimo data";
            // 
            // avialinijatextBox
            // 
            this.avialinijatextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.avialinijatextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.avialinijatextBox.Location = new System.Drawing.Point(111, 19);
            this.avialinijatextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avialinijatextBox.Name = "avialinijatextBox";
            this.avialinijatextBox.Size = new System.Drawing.Size(161, 22);
            this.avialinijatextBox.TabIndex = 9;
            this.avialinijatextBox.Text = "Įveskite norimą avialiniją";
            // 
            // isvykimoOroUostastextBox
            // 
            this.isvykimoOroUostastextBox.Location = new System.Drawing.Point(443, 19);
            this.isvykimoOroUostastextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isvykimoOroUostastextBox.MaxLength = 3;
            this.isvykimoOroUostastextBox.Name = "isvykimoOroUostastextBox";
            this.isvykimoOroUostastextBox.Size = new System.Drawing.Size(100, 22);
            this.isvykimoOroUostastextBox.TabIndex = 10;
            // 
            // atvykimoOroUostastextBox
            // 
            this.atvykimoOroUostastextBox.Location = new System.Drawing.Point(443, 61);
            this.atvykimoOroUostastextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.atvykimoOroUostastextBox.MaxLength = 3;
            this.atvykimoOroUostastextBox.Name = "atvykimoOroUostastextBox";
            this.atvykimoOroUostastextBox.Size = new System.Drawing.Size(100, 22);
            this.atvykimoOroUostastextBox.TabIndex = 11;
            // 
            // isRtCheckBox
            // 
            this.isRtCheckBox.AutoSize = true;
            this.isRtCheckBox.Location = new System.Drawing.Point(1194, 21);
            this.isRtCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isRtCheckBox.Name = "isRtCheckBox";
            this.isRtCheckBox.Size = new System.Drawing.Size(130, 21);
            this.isRtCheckBox.TabIndex = 14;
            this.isRtCheckBox.Text = "Dvipusė kelionė";
            this.isRtCheckBox.UseVisualStyleBackColor = true;
            this.isRtCheckBox.CheckedChanged += new System.EventHandler(this.isRtCheckBox_CheckedChanged);
            // 
            // surinktiDuomenysdataGridView
            // 
            this.surinktiDuomenysdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.surinktiDuomenysdataGridView.Location = new System.Drawing.Point(12, 109);
            this.surinktiDuomenysdataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surinktiDuomenysdataGridView.Name = "surinktiDuomenysdataGridView";
            this.surinktiDuomenysdataGridView.RowHeadersWidth = 51;
            this.surinktiDuomenysdataGridView.RowTemplate.Height = 24;
            this.surinktiDuomenysdataGridView.Size = new System.Drawing.Size(1318, 601);
            this.surinktiDuomenysdataGridView.TabIndex = 15;
            // 
            // klaseComboBox
            // 
            this.klaseComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.klaseComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.klaseComboBox.FormattingEnabled = true;
            this.klaseComboBox.Location = new System.Drawing.Point(1044, 20);
            this.klaseComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.klaseComboBox.Name = "klaseComboBox";
            this.klaseComboBox.Size = new System.Drawing.Size(100, 24);
            this.klaseComboBox.TabIndex = 16;
            this.klaseComboBox.Text = "Ekonominė";
            // 
            // pridetiButton
            // 
            this.pridetiButton.Location = new System.Drawing.Point(997, 55);
            this.pridetiButton.Margin = new System.Windows.Forms.Padding(4);
            this.pridetiButton.Name = "pridetiButton";
            this.pridetiButton.Size = new System.Drawing.Size(148, 30);
            this.pridetiButton.TabIndex = 17;
            this.pridetiButton.Text = "Pridėti datas";
            this.pridetiButton.UseVisualStyleBackColor = true;
            this.pridetiButton.Click += new System.EventHandler(this.pridetiButton_Click);
            // 
            // isvykimoDataDateTimePicker
            // 
            this.isvykimoDataDateTimePicker.Location = new System.Drawing.Point(689, 19);
            this.isvykimoDataDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.isvykimoDataDateTimePicker.MinDate = new System.DateTime(2020, 12, 22, 17, 15, 46, 44);
            this.isvykimoDataDateTimePicker.Name = "isvykimoDataDateTimePicker";
            this.isvykimoDataDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.isvykimoDataDateTimePicker.TabIndex = 19;
            this.isvykimoDataDateTimePicker.Value = new System.DateTime(2020, 12, 22, 17, 15, 46, 44);
            // 
            // atvykimoDataDateTimePicker
            // 
            this.atvykimoDataDateTimePicker.Enabled = false;
            this.atvykimoDataDateTimePicker.Location = new System.Drawing.Point(689, 61);
            this.atvykimoDataDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.atvykimoDataDateTimePicker.MinDate = new System.DateTime(2020, 12, 22, 17, 15, 46, 48);
            this.atvykimoDataDateTimePicker.Name = "atvykimoDataDateTimePicker";
            this.atvykimoDataDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.atvykimoDataDateTimePicker.TabIndex = 20;
            this.atvykimoDataDateTimePicker.Value = new System.DateTime(2020, 12, 22, 17, 15, 46, 48);
            // 
            // isvykimoOroUostasWarning
            // 
            this.isvykimoOroUostasWarning.AutoSize = true;
            this.isvykimoOroUostasWarning.ForeColor = System.Drawing.Color.Red;
            this.isvykimoOroUostasWarning.Location = new System.Drawing.Point(549, 22);
            this.isvykimoOroUostasWarning.Name = "isvykimoOroUostasWarning";
            this.isvykimoOroUostasWarning.Size = new System.Drawing.Size(11, 17);
            this.isvykimoOroUostasWarning.TabIndex = 21;
            this.isvykimoOroUostasWarning.Text = "!";
            this.isvykimoOroUostasWarning.Visible = false;
            // 
            // atvykimoOroUostasWarning
            // 
            this.atvykimoOroUostasWarning.AutoSize = true;
            this.atvykimoOroUostasWarning.ForeColor = System.Drawing.Color.Red;
            this.atvykimoOroUostasWarning.Location = new System.Drawing.Point(549, 61);
            this.atvykimoOroUostasWarning.Name = "atvykimoOroUostasWarning";
            this.atvykimoOroUostasWarning.Size = new System.Drawing.Size(11, 17);
            this.atvykimoOroUostasWarning.TabIndex = 22;
            this.atvykimoOroUostasWarning.Text = "!";
            this.atvykimoOroUostasWarning.Visible = false;
            // 
            // isvykimoDataWarning
            // 
            this.isvykimoDataWarning.AutoSize = true;
            this.isvykimoDataWarning.ForeColor = System.Drawing.Color.Red;
            this.isvykimoDataWarning.Location = new System.Drawing.Point(961, 20);
            this.isvykimoDataWarning.Name = "isvykimoDataWarning";
            this.isvykimoDataWarning.Size = new System.Drawing.Size(11, 17);
            this.isvykimoDataWarning.TabIndex = 23;
            this.isvykimoDataWarning.Text = "!";
            this.isvykimoDataWarning.Visible = false;
            // 
            // atvykimoDataWarning
            // 
            this.atvykimoDataWarning.AutoSize = true;
            this.atvykimoDataWarning.ForeColor = System.Drawing.Color.Red;
            this.atvykimoDataWarning.Location = new System.Drawing.Point(961, 61);
            this.atvykimoDataWarning.Name = "atvykimoDataWarning";
            this.atvykimoDataWarning.Size = new System.Drawing.Size(11, 17);
            this.atvykimoDataWarning.TabIndex = 24;
            this.atvykimoDataWarning.Text = "!";
            this.atvykimoDataWarning.Visible = false;
            // 
            // visiAvialinijosSkrydziaiButton
            // 
            this.visiAvialinijosSkrydziaiButton.Location = new System.Drawing.Point(28, 57);
            this.visiAvialinijosSkrydziaiButton.Name = "visiAvialinijosSkrydziaiButton";
            this.visiAvialinijosSkrydziaiButton.Size = new System.Drawing.Size(244, 30);
            this.visiAvialinijosSkrydziaiButton.TabIndex = 25;
            this.visiAvialinijosSkrydziaiButton.Text = "Visi avialinijos skrydžiai";
            this.visiAvialinijosSkrydziaiButton.UseVisualStyleBackColor = true;
            this.visiAvialinijosSkrydziaiButton.Click += new System.EventHandler(this.VisiAvialinijosSkrydziaiButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 756);
            this.Controls.Add(this.visiAvialinijosSkrydziaiButton);
            this.Controls.Add(this.atvykimoDataWarning);
            this.Controls.Add(this.isvykimoDataWarning);
            this.Controls.Add(this.atvykimoOroUostasWarning);
            this.Controls.Add(this.isvykimoOroUostasWarning);
            this.Controls.Add(this.atvykimoDataDateTimePicker);
            this.Controls.Add(this.isvykimoDataDateTimePicker);
            this.Controls.Add(this.pridetiButton);
            this.Controls.Add(this.klaseComboBox);
            this.Controls.Add(this.surinktiDuomenysdataGridView);
            this.Controls.Add(this.isRtCheckBox);
            this.Controls.Add(this.atvykimoOroUostastextBox);
            this.Controls.Add(this.isvykimoOroUostastextBox);
            this.Controls.Add(this.avialinijatextBox);
            this.Controls.Add(this.AtvykimoDataLabel);
            this.Controls.Add(this.IsvykimoDataLabel);
            this.Controls.Add(this.klaseLabel);
            this.Controls.Add(this.atvykimoOroUostasLabel);
            this.Controls.Add(this.isvykimoOroUostasLabel);
            this.Controls.Add(this.avialinijaLabel);
            this.Controls.Add(this.ieskotiButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Skrydžių paieška";
            ((System.ComponentModel.ISupportInitialize)(this.surinktiDuomenysdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ieskotiButton;
        private System.Windows.Forms.Label avialinijaLabel;
        private System.Windows.Forms.Label isvykimoOroUostasLabel;
        private System.Windows.Forms.Label atvykimoOroUostasLabel;
        private System.Windows.Forms.Label klaseLabel;
        private System.Windows.Forms.Label IsvykimoDataLabel;
        private System.Windows.Forms.Label AtvykimoDataLabel;
        private System.Windows.Forms.TextBox avialinijatextBox;
        private System.Windows.Forms.TextBox isvykimoOroUostastextBox;
        private System.Windows.Forms.TextBox atvykimoOroUostastextBox;
        private System.Windows.Forms.CheckBox isRtCheckBox;
        private System.Windows.Forms.DataGridView surinktiDuomenysdataGridView;
        private System.Windows.Forms.ComboBox klaseComboBox;
        private System.Windows.Forms.Button pridetiButton;
        private System.Windows.Forms.DateTimePicker isvykimoDataDateTimePicker;
        private System.Windows.Forms.DateTimePicker atvykimoDataDateTimePicker;
        private System.Windows.Forms.Label isvykimoOroUostasWarning;
        private System.Windows.Forms.Label atvykimoOroUostasWarning;
        private System.Windows.Forms.Label isvykimoDataWarning;
        private System.Windows.Forms.Label atvykimoDataWarning;
        private System.Windows.Forms.Button visiAvialinijosSkrydziaiButton;
    }
}

