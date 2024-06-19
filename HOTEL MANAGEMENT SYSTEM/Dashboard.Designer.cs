namespace HOTEL_MANAGEMENT_SYSTEM
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRegistration = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoom = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonMini = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Panel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Employee1 = new HOTEL_MANAGEMENT_SYSTEM.All_User_Control.UC_Employee();
            this.customerDetails1 = new HOTEL_MANAGEMENT_SYSTEM.All_User_Control.CustomerDetails();
            this.uC_CustomerCheckOut1 = new HOTEL_MANAGEMENT_SYSTEM.All_User_Control.UC_CustomerCheckOut();
            this.uC_CustomerRegistration1 = new HOTEL_MANAGEMENT_SYSTEM.All_User_Control.UC_CustomerRegistration();
            this.uC_AddRoom1 = new HOTEL_MANAGEMENT_SYSTEM.All_User_Control.UC_AddRoom();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MovingPanel);
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.btnCustomerDetail);
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.btnCustomerRegistration);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Location = new System.Drawing.Point(62, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 130);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MovingPanel
            // 
            this.MovingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MovingPanel.Location = new System.Drawing.Point(16, 115);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(200, 5);
            this.MovingPanel.TabIndex = 0;
            // 
            // btnStaff
            // 
            this.btnStaff.BorderRadius = 26;
            this.btnStaff.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStaff.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStaff.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.ImageSize = new System.Drawing.Size(50, 50);
            this.btnStaff.Location = new System.Drawing.Point(1047, 25);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(236, 85);
            this.btnStaff.TabIndex = 4;
            this.btnStaff.Text = "Staff";
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnCustomerDetail
            // 
            this.btnCustomerDetail.BorderRadius = 26;
            this.btnCustomerDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerDetail.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerDetail.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnCustomerDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCustomerDetail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetail.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDetail.Image")));
            this.btnCustomerDetail.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomerDetail.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomerDetail.Location = new System.Drawing.Point(806, 25);
            this.btnCustomerDetail.Name = "btnCustomerDetail";
            this.btnCustomerDetail.Size = new System.Drawing.Size(236, 85);
            this.btnCustomerDetail.TabIndex = 2;
            this.btnCustomerDetail.Text = "      Customer Detail";
            this.btnCustomerDetail.Click += new System.EventHandler(this.btnCustomerDetail_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BorderRadius = 26;
            this.btnCheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCheckout.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckout.Image")));
            this.btnCheckout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCheckout.Location = new System.Drawing.Point(531, 25);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(236, 85);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCustomerRegistration
            // 
            this.btnCustomerRegistration.BorderRadius = 26;
            this.btnCustomerRegistration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRegistration.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnCustomerRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerRegistration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCustomerRegistration.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRegistration.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerRegistration.Image")));
            this.btnCustomerRegistration.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomerRegistration.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomerRegistration.Location = new System.Drawing.Point(254, 25);
            this.btnCustomerRegistration.Name = "btnCustomerRegistration";
            this.btnCustomerRegistration.Size = new System.Drawing.Size(272, 85);
            this.btnCustomerRegistration.TabIndex = 2;
            this.btnCustomerRegistration.Text = "   Customer    Registration";
            this.btnCustomerRegistration.Click += new System.EventHandler(this.btnCustomerRegistration_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.BorderRadius = 26;
            this.btnRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRoom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRoom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnRoom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRoom.Location = new System.Drawing.Point(3, 25);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(236, 85);
            this.btnRoom.TabIndex = 1;
            this.btnRoom.Text = "Add Room";
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // ButtonMini
            // 
            this.ButtonMini.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMini.Image")));
            this.ButtonMini.Location = new System.Drawing.Point(12, 58);
            this.ButtonMini.Name = "ButtonMini";
            this.ButtonMini.Size = new System.Drawing.Size(32, 28);
            this.ButtonMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonMini.TabIndex = 3;
            this.ButtonMini.TabStop = false;
            this.ButtonMini.Click += new System.EventHandler(this.ButtonMini_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(12, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(32, 28);
            this.buttonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonExit.TabIndex = 2;
            this.buttonExit.TabStop = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.uC_Employee1);
            this.Panel2.Controls.Add(this.customerDetails1);
            this.Panel2.Controls.Add(this.uC_CustomerCheckOut1);
            this.Panel2.Controls.Add(this.uC_CustomerRegistration1);
            this.Panel2.Controls.Add(this.uC_AddRoom1);
            this.Panel2.Location = new System.Drawing.Point(64, 182);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1400, 850);
            this.Panel2.TabIndex = 1;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint_1);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.White;
            this.uC_Employee1.Location = new System.Drawing.Point(3, 3);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1341, 642);
            this.uC_Employee1.TabIndex = 4;
            this.uC_Employee1.Load += new System.EventHandler(this.uC_Employee1_Load);
            // 
            // customerDetails1
            // 
            this.customerDetails1.BackColor = System.Drawing.Color.White;
            this.customerDetails1.Location = new System.Drawing.Point(3, 651);
            this.customerDetails1.Name = "customerDetails1";
            this.customerDetails1.Size = new System.Drawing.Size(1341, 642);
            this.customerDetails1.TabIndex = 3;
            // 
            // uC_CustomerCheckOut1
            // 
            this.uC_CustomerCheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerCheckOut1.Location = new System.Drawing.Point(3, 1299);
            this.uC_CustomerCheckOut1.Name = "uC_CustomerCheckOut1";
            this.uC_CustomerCheckOut1.Size = new System.Drawing.Size(1341, 652);
            this.uC_CustomerCheckOut1.TabIndex = 2;
            // 
            // uC_CustomerRegistration1
            // 
            this.uC_CustomerRegistration1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRegistration1.Location = new System.Drawing.Point(3, 1957);
            this.uC_CustomerRegistration1.Name = "uC_CustomerRegistration1";
            this.uC_CustomerRegistration1.Size = new System.Drawing.Size(1274, 629);
            this.uC_CustomerRegistration1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Location = new System.Drawing.Point(3, 2592);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1414, 665);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1600, 850);
            this.Controls.Add(this.ButtonMini);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox buttonExit;
        private System.Windows.Forms.PictureBox ButtonMini;
        private Guna.UI2.WinForms.Guna2Button btnRoom;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetail;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRegistration;
        private System.Windows.Forms.Panel MovingPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.FlowLayoutPanel Panel2;
        private All_User_Control.UC_AddRoom uC_AddRoom1;
        private All_User_Control.UC_CustomerCheckOut uC_CustomerCheckOut1;
        private All_User_Control.UC_CustomerRegistration uC_CustomerRegistration1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.CustomerDetails customerDetails1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Control.UC_Employee uC_Employee1;
    }
}