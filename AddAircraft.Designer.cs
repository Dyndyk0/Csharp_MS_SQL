namespace BD1
{
    partial class AddAircraft
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductionDate = new System.Windows.Forms.DateTimePicker();
            this.Model = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MonthlyExpenses = new System.Windows.Forms.TextBox();
            this.NumberSeats = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ввод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Модель";
            // 
            // ProductionDate
            // 
            this.ProductionDate.Location = new System.Drawing.Point(121, 38);
            this.ProductionDate.Name = "ProductionDate";
            this.ProductionDate.Size = new System.Drawing.Size(137, 20);
            this.ProductionDate.TabIndex = 4;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(121, 12);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(137, 20);
            this.Model.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата производства";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Расходы за месяц";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Колличество мест";
            // 
            // MonthlyExpenses
            // 
            this.MonthlyExpenses.Location = new System.Drawing.Point(121, 64);
            this.MonthlyExpenses.Name = "MonthlyExpenses";
            this.MonthlyExpenses.Size = new System.Drawing.Size(137, 20);
            this.MonthlyExpenses.TabIndex = 13;
            // 
            // NumberSeats
            // 
            this.NumberSeats.Location = new System.Drawing.Point(121, 90);
            this.NumberSeats.Name = "NumberSeats";
            this.NumberSeats.Size = new System.Drawing.Size(137, 20);
            this.NumberSeats.TabIndex = 14;
            // 
            // AddAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 202);
            this.Controls.Add(this.NumberSeats);
            this.Controls.Add(this.MonthlyExpenses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.ProductionDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAircraft";
            this.Text = "AddAircraft";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ProductionDate;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MonthlyExpenses;
        private System.Windows.Forms.TextBox NumberSeats;
    }
}