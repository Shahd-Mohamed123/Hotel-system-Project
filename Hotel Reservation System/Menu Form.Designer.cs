namespace Hotel_Reservation_System
{
    partial class menufrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menufrm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnbooking = new System.Windows.Forms.Button();
            this.btnrooms = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnmang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(-108, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1284, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "                                           Hotel Menu                            " +
    "               ";
            // 
            // btnbooking
            // 
            this.btnbooking.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnbooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbooking.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnbooking.Location = new System.Drawing.Point(417, 128);
            this.btnbooking.Name = "btnbooking";
            this.btnbooking.Size = new System.Drawing.Size(291, 114);
            this.btnbooking.TabIndex = 1;
            this.btnbooking.Text = "🗓️ Booking";
            this.toolTip1.SetToolTip(this.btnbooking, "Click to Book Your Room");
            this.btnbooking.UseVisualStyleBackColor = false;
            this.btnbooking.Click += new System.EventHandler(this.btnbooking_Click);
            this.btnbooking.MouseLeave += new System.EventHandler(this.btnbooking_MouseLeave);
            this.btnbooking.MouseHover += new System.EventHandler(this.btnbooking_MouseHover);
            // 
            // btnrooms
            // 
            this.btnrooms.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnrooms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrooms.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnrooms.Location = new System.Drawing.Point(120, 128);
            this.btnrooms.Name = "btnrooms";
            this.btnrooms.Size = new System.Drawing.Size(291, 114);
            this.btnrooms.TabIndex = 2;
            this.btnrooms.Text = "🛏️ Rooms";
            this.toolTip1.SetToolTip(this.btnrooms, "Click to Inquire about Available Rooms");
            this.btnrooms.UseVisualStyleBackColor = false;
            this.btnrooms.Click += new System.EventHandler(this.button1_Click);
            this.btnrooms.MouseLeave += new System.EventHandler(this.btnrooms_MouseLeave);
            this.btnrooms.MouseHover += new System.EventHandler(this.btnrooms_MouseHover);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnexit.Location = new System.Drawing.Point(417, 248);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(291, 114);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "➡️ Exit";
            this.toolTip1.SetToolTip(this.btnexit, "Click to Exit");
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            this.btnexit.MouseLeave += new System.EventHandler(this.btnexit_MouseLeave);
            this.btnexit.MouseHover += new System.EventHandler(this.btnexit_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            this.toolTip1.AutoPopDelay = 3000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 60;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(311, 379);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(203, 45);
            this.txtpass.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtpass, "Enter Password And Press Enter");
            this.txtpass.Visible = false;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.Enter += new System.EventHandler(this.btnrooms_MouseLeave);
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // btnmang
            // 
            this.btnmang.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnmang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmang.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnmang.Location = new System.Drawing.Point(120, 248);
            this.btnmang.Name = "btnmang";
            this.btnmang.Size = new System.Drawing.Size(291, 114);
            this.btnmang.TabIndex = 4;
            this.btnmang.Text = "📋 Administration";
            this.btnmang.UseVisualStyleBackColor = false;
            this.btnmang.Click += new System.EventHandler(this.btnmang_Click);
            // 
            // menufrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(813, 493);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.btnmang);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnrooms);
            this.Controls.Add(this.btnbooking);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "menufrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Reservation System";
            this.Load += new System.EventHandler(this.menufrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbooking;
        private System.Windows.Forms.Button btnrooms;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnmang;
        private System.Windows.Forms.TextBox txtpass;
    }
}

