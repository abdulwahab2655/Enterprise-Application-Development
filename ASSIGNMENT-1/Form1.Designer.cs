namespace EAD_Assignment_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxFname = new TextBox();
            textBoxLname = new TextBox();
            labelFname = new Label();
            labelLname = new Label();
            labelSubject = new Label();
            button1 = new Button();
            resultLabel = new Label();
            label1 = new Label();
            checkBoxPrerequisite = new CheckBox();
            textBoxMulti = new TextBox();
            SuspendLayout();
            // 
            // textBoxFname
            // 
            textBoxFname.BackColor = SystemColors.ButtonFace;
            textBoxFname.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFname.ForeColor = SystemColors.ActiveCaptionText;
            textBoxFname.Location = new Point(192, 105);
            textBoxFname.Margin = new Padding(4, 3, 4, 3);
            textBoxFname.Name = "textBoxFname";
            textBoxFname.Size = new Size(290, 30);
            textBoxFname.TabIndex = 1;
            textBoxFname.TextChanged += textBoxFname_TextChanged;
            // 
            // textBoxLname
            // 
            textBoxLname.BackColor = SystemColors.ButtonFace;
            textBoxLname.ForeColor = SystemColors.ActiveCaptionText;
            textBoxLname.Location = new Point(192, 159);
            textBoxLname.Margin = new Padding(4, 3, 4, 3);
            textBoxLname.Name = "textBoxLname";
            textBoxLname.Size = new Size(290, 30);
            textBoxLname.TabIndex = 2;
            textBoxLname.TextChanged += textBoxLname_TextChanged;
            // 
            // labelFname
            // 
            labelFname.AutoSize = true;
            labelFname.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFname.ForeColor = SystemColors.HighlightText;
            labelFname.Location = new Point(15, 100);
            labelFname.Margin = new Padding(4, 0, 4, 0);
            labelFname.Name = "labelFname";
            labelFname.Size = new Size(120, 28);
            labelFname.TabIndex = 3;
            labelFname.Text = "First Name:";
            labelFname.Click += labelFname_Click;
            // 
            // labelLname
            // 
            labelLname.AutoSize = true;
            labelLname.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLname.ForeColor = SystemColors.HighlightText;
            labelLname.Location = new Point(15, 154);
            labelLname.Margin = new Padding(4, 0, 4, 0);
            labelLname.Name = "labelLname";
            labelLname.Size = new Size(117, 28);
            labelLname.TabIndex = 4;
            labelLname.Text = "Last Name:";
            labelLname.Click += labelLname_Click;
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSubject.ForeColor = SystemColors.HighlightText;
            labelSubject.Location = new Point(15, 213);
            labelSubject.Margin = new Padding(4, 0, 4, 0);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(150, 28);
            labelSubject.TabIndex = 6;
            labelSubject.Text = "Select Course: ";
            labelSubject.Click += labelSubject_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(440, 413);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Padding = new Padding(4);
            button1.Size = new Size(102, 45);
            button1.TabIndex = 8;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.BackColor = Color.WhiteSmoke;
            resultLabel.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            resultLabel.ForeColor = Color.SteelBlue;
            resultLabel.Location = new Point(12, 355);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 25);
            resultLabel.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(132, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(11, 12, 11, 12);
            label1.Size = new Size(326, 62);
            label1.TabIndex = 11;
            label1.Text = "REGISTRATION FORM";
            // 
            // checkBoxPrerequisite
            // 
            checkBoxPrerequisite.AutoSize = true;
            checkBoxPrerequisite.BackColor = SystemColors.ActiveCaption;
            checkBoxPrerequisite.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxPrerequisite.Location = new Point(190, 302);
            checkBoxPrerequisite.Margin = new Padding(4, 3, 4, 3);
            checkBoxPrerequisite.Name = "checkBoxPrerequisite";
            checkBoxPrerequisite.Padding = new Padding(4, 6, 4, 6);
            checkBoxPrerequisite.Size = new Size(197, 39);
            checkBoxPrerequisite.TabIndex = 7;
            checkBoxPrerequisite.Text = "Prerequisite Clear   ";
            checkBoxPrerequisite.UseVisualStyleBackColor = false;
            checkBoxPrerequisite.CheckedChanged += checkBoxPrerequisite_CheckedChanged;
            // 
            // textBoxMulti
            // 
            textBoxMulti.Location = new Point(190, 216);
            textBoxMulti.Multiline = true;
            textBoxMulti.Name = "textBoxMulti";
            textBoxMulti.Size = new Size(292, 63);
            textBoxMulti.TabIndex = 12;
            textBoxMulti.TextChanged += textBoxMulti_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(609, 509);
            Controls.Add(textBoxMulti);
            Controls.Add(label1);
            Controls.Add(resultLabel);
            Controls.Add(button1);
            Controls.Add(checkBoxPrerequisite);
            Controls.Add(labelSubject);
            Controls.Add(labelLname);
            Controls.Add(labelFname);
            Controls.Add(textBoxLname);
            Controls.Add(textBoxFname);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "Form1";
            Text = "STUDENT REGISTRATION FORM";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxFname;
        private TextBox textBoxLname;
        private Label labelFname;
        private Label labelLname;
        private Label labelSubject;
        private Button button1;
        private Label resultLabel;
        private Label label1;
        private CheckBox checkBoxPrerequisite;
        private TextBox textBoxMulti;
    }
}