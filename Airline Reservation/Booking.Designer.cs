namespace Airline_Reservation
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.loginbtn = new System.Windows.Forms.Button();
            this.bookingbtn = new System.Windows.Forms.Button();
            this.flightbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.TicketId = new System.Windows.Forms.TextBox();
            this.PpId = new System.Windows.Forms.TextBox();
            this.BKDetails = new System.Windows.Forms.Button();
            this.Ticket = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Navy;
            this.loginbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(205, 3);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(73, 61);
            this.loginbtn.TabIndex = 11;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // bookingbtn
            // 
            this.bookingbtn.BackColor = System.Drawing.Color.Navy;
            this.bookingbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingbtn.ForeColor = System.Drawing.Color.White;
            this.bookingbtn.Location = new System.Drawing.Point(136, 3);
            this.bookingbtn.Name = "bookingbtn";
            this.bookingbtn.Size = new System.Drawing.Size(75, 61);
            this.bookingbtn.TabIndex = 10;
            this.bookingbtn.Text = "Booking";
            this.bookingbtn.UseVisualStyleBackColor = false;
            // 
            // flightbtn
            // 
            this.flightbtn.BackColor = System.Drawing.Color.Navy;
            this.flightbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightbtn.ForeColor = System.Drawing.Color.White;
            this.flightbtn.Location = new System.Drawing.Point(67, 3);
            this.flightbtn.Name = "flightbtn";
            this.flightbtn.Size = new System.Drawing.Size(73, 61);
            this.flightbtn.TabIndex = 9;
            this.flightbtn.Text = "Flight";
            this.flightbtn.UseVisualStyleBackColor = false;
            this.flightbtn.Click += new System.EventHandler(this.flightbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.Navy;
            this.homebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.Color.White;
            this.homebtn.Location = new System.Drawing.Point(-1, 3);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(73, 61);
            this.homebtn.TabIndex = 8;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // TicketId
            // 
            this.TicketId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TicketId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TicketId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketId.Location = new System.Drawing.Point(225, 235);
            this.TicketId.Name = "TicketId";
            this.TicketId.Size = new System.Drawing.Size(161, 22);
            this.TicketId.TabIndex = 12;
            this.TicketId.Text = "Ticket ID";
            this.TicketId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PpId
            // 
            this.PpId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PpId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PpId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PpId.Location = new System.Drawing.Point(445, 235);
            this.PpId.Name = "PpId";
            this.PpId.Size = new System.Drawing.Size(161, 22);
            this.PpId.TabIndex = 13;
            this.PpId.Text = "Passport ID";
            this.PpId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BKDetails
            // 
            this.BKDetails.BackColor = System.Drawing.Color.Navy;
            this.BKDetails.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BKDetails.ForeColor = System.Drawing.Color.White;
            this.BKDetails.Location = new System.Drawing.Point(586, 22);
            this.BKDetails.Name = "BKDetails";
            this.BKDetails.Size = new System.Drawing.Size(160, 42);
            this.BKDetails.TabIndex = 14;
            this.BKDetails.Text = "BOOKING DETAILS";
            this.BKDetails.UseVisualStyleBackColor = false;
            this.BKDetails.Click += new System.EventHandler(this.BKDetails_Click);
            // 
            // Ticket
            // 
            this.Ticket.BackColor = System.Drawing.Color.Navy;
            this.Ticket.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ticket.ForeColor = System.Drawing.Color.White;
            this.Ticket.Location = new System.Drawing.Point(586, 70);
            this.Ticket.Name = "Ticket";
            this.Ticket.Size = new System.Drawing.Size(160, 42);
            this.Ticket.TabIndex = 15;
            this.Ticket.Text = "TICKET";
            this.Ticket.UseVisualStyleBackColor = false;
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.Navy;
            this.Continue.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.Color.White;
            this.Continue.Location = new System.Drawing.Point(586, 118);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(160, 42);
            this.Continue.TabIndex = 16;
            this.Continue.Text = "CONTINUE";
            this.Continue.UseVisualStyleBackColor = false;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Ticket);
            this.Controls.Add(this.BKDetails);
            this.Controls.Add(this.PpId);
            this.Controls.Add(this.TicketId);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.bookingbtn);
            this.Controls.Add(this.flightbtn);
            this.Controls.Add(this.homebtn);
            this.DoubleBuffered = true;
            this.Name = "Booking";
            this.Text = "Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button bookingbtn;
        private System.Windows.Forms.Button flightbtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.TextBox TicketId;
        private System.Windows.Forms.TextBox PpId;
        private System.Windows.Forms.Button BKDetails;
        private System.Windows.Forms.Button Ticket;
        private System.Windows.Forms.Button Continue;
    }
}