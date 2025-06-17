namespace BD1
{
    partial class EditTicket
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
            this.label6 = new System.Windows.Forms.Label();
            this.FlightID = new System.Windows.Forms.ComboBox();
            this.PassengerID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TicketType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TicketPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Seat = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Seat)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Цена билета";
            // 
            // FlightID
            // 
            this.FlightID.FormattingEnabled = true;
            this.FlightID.Location = new System.Drawing.Point(86, 6);
            this.FlightID.Name = "FlightID";
            this.FlightID.Size = new System.Drawing.Size(317, 21);
            this.FlightID.TabIndex = 40;
            // 
            // PassengerID
            // 
            this.PassengerID.FormattingEnabled = true;
            this.PassengerID.Location = new System.Drawing.Point(86, 32);
            this.PassengerID.Name = "PassengerID";
            this.PassengerID.Size = new System.Drawing.Size(317, 21);
            this.PassengerID.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Пассажир";
            // 
            // TicketType
            // 
            this.TicketType.Location = new System.Drawing.Point(86, 85);
            this.TicketType.Name = "TicketType";
            this.TicketType.Size = new System.Drawing.Size(317, 20);
            this.TicketType.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Место";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Тип билета";
            // 
            // TicketPrice
            // 
            this.TicketPrice.Location = new System.Drawing.Point(86, 59);
            this.TicketPrice.Name = "TicketPrice";
            this.TicketPrice.Size = new System.Drawing.Size(317, 20);
            this.TicketPrice.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Рейс";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 59);
            this.button1.TabIndex = 30;
            this.button1.Text = "Ввод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Seat
            // 
            this.Seat.Location = new System.Drawing.Point(86, 111);
            this.Seat.Name = "Seat";
            this.Seat.Size = new System.Drawing.Size(317, 20);
            this.Seat.TabIndex = 43;
            // 
            // EditTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 209);
            this.Controls.Add(this.Seat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FlightID);
            this.Controls.Add(this.PassengerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TicketType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TicketPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "EditTicket";
            this.Text = "EditTicket";
            ((System.ComponentModel.ISupportInitialize)(this.Seat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FlightID;
        private System.Windows.Forms.ComboBox PassengerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TicketType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TicketPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown Seat;
    }
}