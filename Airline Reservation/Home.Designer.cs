namespace Airline_Reservation
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.homebtn = new System.Windows.Forms.Button();
            this.flightbtn = new System.Windows.Forms.Button();
            this.bookingbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.Navy;
            this.homebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.Color.White;
            this.homebtn.Location = new System.Drawing.Point(0, 1);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(73, 61);
            this.homebtn.TabIndex = 0;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            // 
            // flightbtn
            // 
            this.flightbtn.BackColor = System.Drawing.Color.Navy;
            this.flightbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightbtn.ForeColor = System.Drawing.Color.White;
            this.flightbtn.Location = new System.Drawing.Point(68, 1);
            this.flightbtn.Name = "flightbtn";
            this.flightbtn.Size = new System.Drawing.Size(73, 61);
            this.flightbtn.TabIndex = 1;
            this.flightbtn.Text = "Flight";
            this.flightbtn.UseVisualStyleBackColor = false;
            this.flightbtn.Click += new System.EventHandler(this.flightbtn_Click);
            // 
            // bookingbtn
            // 
            this.bookingbtn.BackColor = System.Drawing.Color.Navy;
            this.bookingbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingbtn.ForeColor = System.Drawing.Color.White;
            this.bookingbtn.Location = new System.Drawing.Point(137, 1);
            this.bookingbtn.Name = "bookingbtn";
            this.bookingbtn.Size = new System.Drawing.Size(75, 61);
            this.bookingbtn.TabIndex = 2;
            this.bookingbtn.Text = "Booking";
            this.bookingbtn.UseVisualStyleBackColor = false;
            this.bookingbtn.Click += new System.EventHandler(this.bookingbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Navy;
            this.loginbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(206, 1);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(73, 61);
            this.loginbtn.TabIndex = 3;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.bookingbtn);
            this.Controls.Add(this.flightbtn);
            this.Controls.Add(this.homebtn);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button flightbtn;
        private System.Windows.Forms.Button bookingbtn;
        private System.Windows.Forms.Button loginbtn;
    }
}

