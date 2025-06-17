namespace BD1
{
    partial class EditFlight
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
            this.LandingPlace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlaceOfDeparture = new System.Windows.Forms.TextBox();
            this.DepartureDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PilotID = new System.Windows.Forms.ComboBox();
            this.AircraftID = new System.Windows.Forms.ComboBox();
            this.LandingDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LandingPlace
            // 
            this.LandingPlace.Location = new System.Drawing.Point(121, 91);
            this.LandingPlace.Name = "LandingPlace";
            this.LandingPlace.Size = new System.Drawing.Size(137, 20);
            this.LandingPlace.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Время посадки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Время вылета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Куда";
            // 
            // PlaceOfDeparture
            // 
            this.PlaceOfDeparture.Location = new System.Drawing.Point(121, 65);
            this.PlaceOfDeparture.Name = "PlaceOfDeparture";
            this.PlaceOfDeparture.Size = new System.Drawing.Size(137, 20);
            this.PlaceOfDeparture.TabIndex = 18;
            // 
            // DepartureDate
            // 
            this.DepartureDate.Location = new System.Drawing.Point(121, 117);
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.Size = new System.Drawing.Size(137, 20);
            this.DepartureDate.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Самолёт";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 59);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ввод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Пилот";
            // 
            // PilotID
            // 
            this.PilotID.FormattingEnabled = true;
            this.PilotID.Location = new System.Drawing.Point(121, 38);
            this.PilotID.Name = "PilotID";
            this.PilotID.Size = new System.Drawing.Size(137, 21);
            this.PilotID.TabIndex = 26;
            // 
            // AircraftID
            // 
            this.AircraftID.FormattingEnabled = true;
            this.AircraftID.Location = new System.Drawing.Point(121, 12);
            this.AircraftID.Name = "AircraftID";
            this.AircraftID.Size = new System.Drawing.Size(137, 21);
            this.AircraftID.TabIndex = 27;
            // 
            // LandingDate
            // 
            this.LandingDate.Location = new System.Drawing.Point(121, 143);
            this.LandingDate.Name = "LandingDate";
            this.LandingDate.Size = new System.Drawing.Size(137, 20);
            this.LandingDate.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Откуда";
            // 
            // EditFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 240);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LandingDate);
            this.Controls.Add(this.AircraftID);
            this.Controls.Add(this.PilotID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LandingPlace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlaceOfDeparture);
            this.Controls.Add(this.DepartureDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "EditFlight";
            this.Text = "Flight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LandingPlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlaceOfDeparture;
        private System.Windows.Forms.DateTimePicker DepartureDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PilotID;
        private System.Windows.Forms.ComboBox AircraftID;
        private System.Windows.Forms.DateTimePicker LandingDate;
        private System.Windows.Forms.Label label6;
    }
}