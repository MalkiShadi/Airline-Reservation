namespace Airline_Reservation
{
    partial class Flight_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flight_1));
            this.homebtn = new System.Windows.Forms.Button();
            this.flightbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.bookingbtn = new System.Windows.Forms.Button();
            this.From = new System.Windows.Forms.ComboBox();
            this.to = new System.Windows.Forms.ComboBox();
            this.DepatureDate = new System.Windows.Forms.DateTimePicker();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.DDtext = new System.Windows.Forms.TextBox();
            this.RDtxt = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.passenger = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.Navy;
            this.homebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.Color.White;
            this.homebtn.Location = new System.Drawing.Point(468, 0);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(73, 61);
            this.homebtn.TabIndex = 1;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // flightbtn
            // 
            this.flightbtn.BackColor = System.Drawing.Color.Navy;
            this.flightbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightbtn.ForeColor = System.Drawing.Color.White;
            this.flightbtn.Location = new System.Drawing.Point(537, 0);
            this.flightbtn.Name = "flightbtn";
            this.flightbtn.Size = new System.Drawing.Size(73, 61);
            this.flightbtn.TabIndex = 2;
            this.flightbtn.Text = "Flight";
            this.flightbtn.UseVisualStyleBackColor = false;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Navy;
            this.loginbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(678, 0);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(73, 61);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // bookingbtn
            // 
            this.bookingbtn.BackColor = System.Drawing.Color.Navy;
            this.bookingbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingbtn.ForeColor = System.Drawing.Color.White;
            this.bookingbtn.Location = new System.Drawing.Point(606, 0);
            this.bookingbtn.Name = "bookingbtn";
            this.bookingbtn.Size = new System.Drawing.Size(75, 61);
            this.bookingbtn.TabIndex = 4;
            this.bookingbtn.Text = "Booking";
            this.bookingbtn.UseVisualStyleBackColor = false;
            this.bookingbtn.Click += new System.EventHandler(this.bookingbtn_Click);
            // 
            // From
            // 
            this.From.DropDownHeight = 110;
            this.From.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.FormattingEnabled = true;
            this.From.IntegralHeight = false;
            this.From.Items.AddRange(new object[] {
            "Amsterdam (AMS)",
            "Atlanta (ATL)",
            "Auckland (AKL)",
            "Bangkok (BKK)",
            "Beijing (PEK)",
            "Berlin (BER)",
            "Cairo (CAI)",
            "Chicago (ORD)",
            "Copenhagen (CPH)",
            "Colombo",
            "Dallas (DFW)",
            "Delhi (DEL)",
            "Dubai (DXB)",
            "Edinburgh (EDI)",
            "Entebbe (EBB)",
            "Eindhoven (EIN)",
            "Frankfurt (FRA)",
            "Fukuoka (FUK)",
            "Florence (FLR)",
            "Geneva (GVA)",
            "Guangzhou (CAN)",
            "Guadalajara (GDL)",
            "Helsinki (HEL)",
            "Hong Kong (HKG)",
            "Houston (IAH)",
            "Istanbul (IST)",
            "Islamabad (ISB)",
            "Indianapolis (IND)",
            "Jakarta (CGK)",
            "Johannesburg (JNB)",
            "Jeddah (JED)",
            "Karachi (KHI)",
            "Kigali (KGL)",
            "Kyoto (ITM - Osaka area)",
            "London (LHR)",
            "Los Angeles (LAX)",
            "Lagos (LOS)",
            "Madrid (MAD)",
            "Melbourne (MEL)",
            "Mumbai (BOM)",
            "Nairobi (NBO)",
            "New York (JFK)",
            "Nagoya (NGO)",
            "Osaka (KIX)",
            "Oslo (OSL)",
            "Ottawa (YOW)",
            "Paris (CDG)",
            "Perth (PER)",
            "Prague (PRG)",
            "Quito (UIO)",
            "Quebec City (YQB)",
            "Quetta (UET)",
            "Rome (FCO)",
            "Riyadh (RUH)",
            "Rotterdam (RTM)",
            "Seoul (ICN)",
            "Singapore (SIN)",
            "Sydney (SYD)",
            "Tokyo (NRT)",
            "Toronto (YYZ)",
            "Tehran (IKA)",
            "Ulaanbaatar (UBN)",
            "Ufa (UFA)",
            "Ushuaia (USH)",
            "Vienna (VIE)",
            "Vancouver (YVR)",
            "Venice (VCE)",
            "Warsaw (WAW)",
            "Washington, D.C. (IAD)",
            "Wellington (WLG)",
            "Xi\'an (XIY)",
            "Yangon (RGN)",
            "Yerevan (EVN)",
            "Zurich (ZRH)",
            "Zhengzhou (CGO)"});
            this.From.Location = new System.Drawing.Point(153, 174);
            this.From.MaxDropDownItems = 100;
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(200, 23);
            this.From.TabIndex = 6;
            this.From.Text = "From";
            // 
            // to
            // 
            this.to.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.FormattingEnabled = true;
            this.to.Items.AddRange(new object[] {
            "Amsterdam (AMS)",
            "Atlanta (ATL)",
            "Auckland (AKL)",
            "Bangkok (BKK)",
            "Beijing (PEK)",
            "Berlin (BER)",
            "Cairo (CAI)",
            "Chicago (ORD)",
            "Copenhagen (CPH)",
            "Colombo",
            "Dallas (DFW)",
            "Delhi (DEL)",
            "Dubai (DXB)",
            "Edinburgh (EDI)",
            "Entebbe (EBB)",
            "Eindhoven (EIN)",
            "Frankfurt (FRA)",
            "Fukuoka (FUK)",
            "Florence (FLR)",
            "Geneva (GVA)",
            "Guangzhou (CAN)",
            "Guadalajara (GDL)",
            "Helsinki (HEL)",
            "Hong Kong (HKG)",
            "Houston (IAH)",
            "Istanbul (IST)",
            "Islamabad (ISB)",
            "Indianapolis (IND)",
            "Jakarta (CGK)",
            "Johannesburg (JNB)",
            "Jeddah (JED)",
            "Karachi (KHI)",
            "Kigali (KGL)",
            "Kyoto (ITM - Osaka area)",
            "London (LHR)",
            "Los Angeles (LAX)",
            "Lagos (LOS)",
            "Madrid (MAD)",
            "Melbourne (MEL)",
            "Mumbai (BOM)",
            "Nairobi (NBO)",
            "New York (JFK)",
            "Nagoya (NGO)",
            "Osaka (KIX)",
            "Oslo (OSL)",
            "Ottawa (YOW)",
            "Paris (CDG)",
            "Perth (PER)",
            "Prague (PRG)",
            "Quito (UIO)",
            "Quebec City (YQB)",
            "Quetta (UET)",
            "Rome (FCO)",
            "Riyadh (RUH)",
            "Rotterdam (RTM)",
            "Seoul (ICN)",
            "Singapore (SIN)",
            "Sydney (SYD)",
            "Tokyo (NRT)",
            "Toronto (YYZ)",
            "Tehran (IKA)",
            "Ulaanbaatar (UBN)",
            "Ufa (UFA)",
            "Ushuaia (USH)",
            "Vienna (VIE)",
            "Vancouver (YVR)",
            "Venice (VCE)",
            "Warsaw (WAW)",
            "Washington, D.C. (IAD)",
            "Wellington (WLG)",
            "Xi\'an (XIY)",
            "Yangon (RGN)",
            "Yerevan (EVN)",
            "Zurich (ZRH)",
            "Zhengzhou (CGO)"});
            this.to.Location = new System.Drawing.Point(439, 174);
            this.to.MaxDropDownItems = 100;
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(200, 23);
            this.to.TabIndex = 7;
            this.to.Text = "To";
            // 
            // DepatureDate
            // 
            this.DepatureDate.Location = new System.Drawing.Point(153, 241);
            this.DepatureDate.Name = "DepatureDate";
            this.DepatureDate.Size = new System.Drawing.Size(200, 20);
            this.DepatureDate.TabIndex = 8;
            // 
            // ReturnDate
            // 
            this.ReturnDate.Location = new System.Drawing.Point(439, 244);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(200, 20);
            this.ReturnDate.TabIndex = 9;
            // 
            // DDtext
            // 
            this.DDtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DDtext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DDtext.ForeColor = System.Drawing.Color.Navy;
            this.DDtext.Location = new System.Drawing.Point(153, 222);
            this.DDtext.Name = "DDtext";
            this.DDtext.Size = new System.Drawing.Size(200, 19);
            this.DDtext.TabIndex = 10;
            this.DDtext.Text = "Depature Date";
            this.DDtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RDtxt
            // 
            this.RDtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RDtxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDtxt.ForeColor = System.Drawing.Color.Navy;
            this.RDtxt.Location = new System.Drawing.Point(439, 224);
            this.RDtxt.Name = "RDtxt";
            this.RDtxt.Size = new System.Drawing.Size(200, 19);
            this.RDtxt.TabIndex = 11;
            this.RDtxt.Text = "Return Date";
            this.RDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.Color.Navy;
            this.Searchbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.ForeColor = System.Drawing.Color.White;
            this.Searchbtn.Location = new System.Drawing.Point(323, 345);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(145, 47);
            this.Searchbtn.TabIndex = 12;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // passenger
            // 
            this.passenger.Location = new System.Drawing.Point(346, 306);
            this.passenger.MaxLength = 2;
            this.passenger.Name = "passenger";
            this.passenger.Size = new System.Drawing.Size(100, 20);
            this.passenger.TabIndex = 13;
            this.passenger.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Navy;
            this.textBox2.Location = new System.Drawing.Point(293, 281);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 19);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Passenger Count";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Flight_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.passenger);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.RDtxt);
            this.Controls.Add(this.DDtext);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.DepatureDate);
            this.Controls.Add(this.to);
            this.Controls.Add(this.From);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.bookingbtn);
            this.Controls.Add(this.flightbtn);
            this.Controls.Add(this.homebtn);
            this.DoubleBuffered = true;
            this.Name = "Flight_1";
            this.Text = "Flight_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button flightbtn;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button bookingbtn;
        private System.Windows.Forms.ComboBox From;
        private System.Windows.Forms.ComboBox to;
        private System.Windows.Forms.DateTimePicker DepatureDate;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.TextBox DDtext;
        private System.Windows.Forms.TextBox RDtxt;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox passenger;
        private System.Windows.Forms.TextBox textBox2;
    }
}