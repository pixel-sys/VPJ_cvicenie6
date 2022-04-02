namespace cvicenie6
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("5555;543");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "ett",
            "3535"}, -1);
            this.radioButton_F = new System.Windows.Forms.RadioButton();
            this.radioButton_C = new System.Windows.Forms.RadioButton();
            this.textBox_step = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_jednotka = new System.Windows.Forms.GroupBox();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView_prevody = new System.Windows.Forms.ListView();
            this.col_teplota1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_teplota2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_convert = new System.Windows.Forms.Button();
            this.groupBox_jednotka.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_F
            // 
            this.radioButton_F.AutoSize = true;
            this.radioButton_F.Checked = true;
            this.radioButton_F.Location = new System.Drawing.Point(6, 21);
            this.radioButton_F.Name = "radioButton_F";
            this.radioButton_F.Size = new System.Drawing.Size(40, 20);
            this.radioButton_F.TabIndex = 0;
            this.radioButton_F.TabStop = true;
            this.radioButton_F.Text = "°F";
            this.radioButton_F.UseVisualStyleBackColor = true;
            // 
            // radioButton_C
            // 
            this.radioButton_C.AutoSize = true;
            this.radioButton_C.Location = new System.Drawing.Point(69, 21);
            this.radioButton_C.Name = "radioButton_C";
            this.radioButton_C.Size = new System.Drawing.Size(41, 20);
            this.radioButton_C.TabIndex = 1;
            this.radioButton_C.Text = "°C";
            this.radioButton_C.UseVisualStyleBackColor = true;
            // 
            // textBox_step
            // 
            this.textBox_step.Location = new System.Drawing.Point(38, 106);
            this.textBox_step.Name = "textBox_step";
            this.textBox_step.Size = new System.Drawing.Size(100, 22);
            this.textBox_step.TabIndex = 2;
            this.textBox_step.Text = "1";
            this.textBox_step.TextChanged += new System.EventHandler(this.textBox_step_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "krok";
            // 
            // groupBox_jednotka
            // 
            this.groupBox_jednotka.Controls.Add(this.radioButton_F);
            this.groupBox_jednotka.Controls.Add(this.radioButton_C);
            this.groupBox_jednotka.Location = new System.Drawing.Point(32, 24);
            this.groupBox_jednotka.Name = "groupBox_jednotka";
            this.groupBox_jednotka.Size = new System.Drawing.Size(130, 59);
            this.groupBox_jednotka.TabIndex = 4;
            this.groupBox_jednotka.TabStop = false;
            this.groupBox_jednotka.Text = "vstupna jednotka";
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(303, 106);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(100, 22);
            this.textBox_max.TabIndex = 5;
            this.textBox_max.Text = "10";
            this.textBox_max.TextChanged += new System.EventHandler(this.textBox_max_TextChanged);
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(172, 106);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(100, 22);
            this.textBox_min.TabIndex = 6;
            this.textBox_min.Text = "1";
            this.textBox_min.TextChanged += new System.EventHandler(this.textBox_min_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max";
            // 
            // listView_prevody
            // 
            this.listView_prevody.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_prevody.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_teplota1,
            this.col_teplota2});
            this.listView_prevody.HideSelection = false;
            this.listView_prevody.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView_prevody.Location = new System.Drawing.Point(38, 143);
            this.listView_prevody.Name = "listView_prevody";
            this.listView_prevody.Size = new System.Drawing.Size(181, 276);
            this.listView_prevody.TabIndex = 9;
            this.listView_prevody.UseCompatibleStateImageBehavior = false;
            this.listView_prevody.View = System.Windows.Forms.View.Details;
            // 
            // col_teplota1
            // 
            this.col_teplota1.Text = "Fahrenheit";
            // 
            // col_teplota2
            // 
            this.col_teplota2.Text = "Celsius";
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(168, 60);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(75, 23);
            this.button_convert.TabIndex = 10;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.listView_prevody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.groupBox_jednotka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_step);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_jednotka.ResumeLayout(false);
            this.groupBox_jednotka.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_F;
        private System.Windows.Forms.RadioButton radioButton_C;
        private System.Windows.Forms.TextBox textBox_step;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_jednotka;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView_prevody;
        private System.Windows.Forms.ColumnHeader col_teplota1;
        private System.Windows.Forms.ColumnHeader col_teplota2;
        private System.Windows.Forms.Button button_convert;
    }
}

