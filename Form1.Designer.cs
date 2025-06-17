namespace BD1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.IDview = new System.Windows.Forms.CheckBox();
            this.DgvAircraft = new System.Windows.Forms.DataGridView();
            this.DgvPilot = new System.Windows.Forms.DataGridView();
            this.DgvFlight = new System.Windows.Forms.DataGridView();
            this.DgvPassenger = new System.Windows.Forms.DataGridView();
            this.DgvTicket = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAircraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPilot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPassenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // IDview
            // 
            this.IDview.AutoSize = true;
            this.IDview.Location = new System.Drawing.Point(777, 531);
            this.IDview.Name = "IDview";
            this.IDview.Size = new System.Drawing.Size(89, 17);
            this.IDview.TabIndex = 2;
            this.IDview.Text = "Показать ID";
            this.IDview.UseVisualStyleBackColor = true;
            this.IDview.CheckedChanged += new System.EventHandler(this.IDview_CheckedChanged);
            // 
            // DgvAircraft
            // 
            this.DgvAircraft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAircraft.Location = new System.Drawing.Point(10, 27);
            this.DgvAircraft.Name = "DgvAircraft";
            this.DgvAircraft.Size = new System.Drawing.Size(443, 191);
            this.DgvAircraft.TabIndex = 3;
            this.DgvAircraft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgvAircraft_MouseDown);
            // 
            // DgvPilot
            // 
            this.DgvPilot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPilot.Location = new System.Drawing.Point(459, 27);
            this.DgvPilot.Name = "DgvPilot";
            this.DgvPilot.Size = new System.Drawing.Size(443, 191);
            this.DgvPilot.TabIndex = 4;
            this.DgvPilot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgvPilot_MouseDown);
            // 
            // DgvFlight
            // 
            this.DgvFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFlight.Location = new System.Drawing.Point(359, 237);
            this.DgvFlight.Name = "DgvFlight";
            this.DgvFlight.Size = new System.Drawing.Size(643, 191);
            this.DgvFlight.TabIndex = 5;
            this.DgvFlight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgvFlight_MouseDown);
            this.DgvFlight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DgvFlight_MouseUp);
            // 
            // DgvPassenger
            // 
            this.DgvPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPassenger.Location = new System.Drawing.Point(10, 237);
            this.DgvPassenger.Name = "DgvPassenger";
            this.DgvPassenger.Size = new System.Drawing.Size(343, 191);
            this.DgvPassenger.TabIndex = 6;
            this.DgvPassenger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgvPassenger_MouseDown);
            // 
            // DgvTicket
            // 
            this.DgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTicket.Location = new System.Drawing.Point(10, 447);
            this.DgvTicket.Name = "DgvTicket";
            this.DgvTicket.Size = new System.Drawing.Size(761, 192);
            this.DgvTicket.TabIndex = 7;
            this.DgvTicket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgvTicket_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Самолётики";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пилотики";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пассажирики";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Рейсики";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Билетики";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(777, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 78);
            this.button1.TabIndex = 13;
            this.button1.Text = "Создать отчётик";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 644);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvTicket);
            this.Controls.Add(this.DgvPassenger);
            this.Controls.Add(this.DgvFlight);
            this.Controls.Add(this.DgvPilot);
            this.Controls.Add(this.DgvAircraft);
            this.Controls.Add(this.IDview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAircraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPilot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPassenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox IDview;
        private System.Windows.Forms.DataGridView DgvAircraft;
        private System.Windows.Forms.DataGridView DgvPilot;
        private System.Windows.Forms.DataGridView DgvFlight;
        private System.Windows.Forms.DataGridView DgvPassenger;
        private System.Windows.Forms.DataGridView DgvTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

