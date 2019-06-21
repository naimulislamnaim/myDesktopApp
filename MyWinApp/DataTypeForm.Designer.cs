namespace MyWinApp
{
    partial class DataTypeForm
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
            this.ShowButton = new System.Windows.Forms.Button();
            this.ConversionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ShowNameButton = new System.Windows.Forms.Button();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(535, 84);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 0;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ConversionButton
            // 
            this.ConversionButton.Location = new System.Drawing.Point(535, 129);
            this.ConversionButton.Name = "ConversionButton";
            this.ConversionButton.Size = new System.Drawing.Size(75, 23);
            this.ConversionButton.TabIndex = 1;
            this.ConversionButton.Text = "Conversion";
            this.ConversionButton.UseVisualStyleBackColor = true;
            this.ConversionButton.Click += new System.EventHandler(this.ConversionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(138, 72);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // ShowNameButton
            // 
            this.ShowNameButton.Location = new System.Drawing.Point(163, 170);
            this.ShowNameButton.Name = "ShowNameButton";
            this.ShowNameButton.Size = new System.Drawing.Size(75, 23);
            this.ShowNameButton.TabIndex = 4;
            this.ShowNameButton.Text = "Show Name";
            this.ShowNameButton.UseVisualStyleBackColor = true;
            this.ShowNameButton.Click += new System.EventHandler(this.ShowNameButton_Click);
            // 
            // itemComboBox
            // 
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Items.AddRange(new object[] {
            "Pen",
            "Pencil"});
            this.itemComboBox.Location = new System.Drawing.Point(138, 110);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(121, 21);
            this.itemComboBox.TabIndex = 5;
            // 
            // DataTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.ShowNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConversionButton);
            this.Controls.Add(this.ShowButton);
            this.Name = "DataTypeForm";
            this.Text = "Data Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button ConversionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button ShowNameButton;
        private System.Windows.Forms.ComboBox itemComboBox;
    }
}