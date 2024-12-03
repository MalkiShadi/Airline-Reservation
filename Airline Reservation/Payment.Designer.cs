namespace Airline_Reservation
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.acc = new System.Windows.Forms.TextBox();
            this.mm = new System.Windows.Forms.TextBox();
            this.yyyy = new System.Windows.Forms.TextBox();
            this.cvv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.bookingbtn = new System.Windows.Forms.Button();
            this.flightbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // acc
            // 
            this.acc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.acc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc.Location = new System.Drawing.Point(268, 122);
            this.acc.MaxLength = 35;
            this.acc.MinimumSize = new System.Drawing.Size(6, 0);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(282, 19);
            this.acc.TabIndex = 0;
            this.acc.Text = "     ACC NO";
            // 
            // mm
            // 
            this.mm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mm.Location = new System.Drawing.Point(268, 163);
            this.mm.MaxLength = 2;
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(127, 19);
            this.mm.TabIndex = 1;
            this.mm.Text = "     MM";
            // 
            // yyyy
            // 
            this.yyyy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yyyy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yyyy.Location = new System.Drawing.Point(418, 163);
            this.yyyy.MaxLength = 4;
            this.yyyy.Name = "yyyy";
            this.yyyy.Size = new System.Drawing.Size(132, 19);
            this.yyyy.TabIndex = 2;
            this.yyyy.Text = "    YYYY";
            // 
            // cvv
            // 
            this.cvv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cvv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvv.Location = new System.Drawing.Point(268, 204);
            this.cvv.MaxLength = 3;
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(107, 19);
            this.cvv.TabIndex = 3;
            this.cvv.Text = "     CVV";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(346, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "CONFIRM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Navy;
            this.loginbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(204, 2);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(73, 61);
            this.loginbtn.TabIndex = 15;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            // 
            // bookingbtn
            // 
            this.bookingbtn.BackColor = System.Drawing.Color.Navy;
            this.bookingbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingbtn.ForeColor = System.Drawing.Color.White;
            this.bookingbtn.Location = new System.Drawing.Point(135, 2);
            this.bookingbtn.Name = "bookingbtn";
            this.bookingbtn.Size = new System.Drawing.Size(75, 61);
            this.bookingbtn.TabIndex = 14;
            this.bookingbtn.Text = "Booking";
            this.bookingbtn.UseVisualStyleBackColor = false;
            this.bookingbtn.Click += new System.EventHandler(this.bookingbtn_Click);
            // 
            // flightbtn
            // 
            this.flightbtn.BackColor = System.Drawing.Color.Navy;
            this.flightbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightbtn.ForeColor = System.Drawing.Color.White;
            this.flightbtn.Location = new System.Drawing.Point(66, 2);
            this.flightbtn.Name = "flightbtn";
            this.flightbtn.Size = new System.Drawing.Size(73, 61);
            this.flightbtn.TabIndex = 13;
            this.flightbtn.Text = "Flight";
            this.flightbtn.UseVisualStyleBackColor = false;
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.Navy;
            this.homebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.Color.White;
            this.homebtn.Location = new System.Drawing.Point(-2, 2);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(73, 61);
            this.homebtn.TabIndex = 12;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.bookingbtn);
            this.Controls.Add(this.flightbtn);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cvv);
            this.Controls.Add(this.yyyy);
            this.Controls.Add(this.mm);
            this.Controls.Add(this.acc);
            this.DoubleBuffered = true;
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox acc;
        private System.Windows.Forms.TextBox mm;
        private System.Windows.Forms.TextBox yyyy;
        private System.Windows.Forms.TextBox cvv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button bookingbtn;
        private System.Windows.Forms.Button flightbtn;
        private System.Windows.Forms.Button homebtn;
    }
}