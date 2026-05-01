namespace Hotel_Reservation_System
{
    partial class Booking_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblroom = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtroom = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnrooms = new System.Windows.Forms.Button();
            this.lblnumofnight = new System.Windows.Forms.Label();
            this.numofnight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblsucces = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numofnight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(-93, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1218, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "                                           Booking                               " +
    "            ";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(160, 106);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(114, 36);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name :";
            // 
            // lblroom
            // 
            this.lblroom.AutoSize = true;
            this.lblroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroom.Location = new System.Drawing.Point(60, 240);
            this.lblroom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblroom.Name = "lblroom";
            this.lblroom.Size = new System.Drawing.Size(236, 36);
            this.lblroom.TabIndex = 3;
            this.lblroom.Text = "Room Number :";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(149, 174);
            this.lblphone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(125, 36);
            this.lblphone.TabIndex = 4;
            this.lblphone.Text = "Phone :";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(287, 109);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(413, 34);
            this.txtname.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtname, "Enter your Full Name");
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtroom
            // 
            this.txtroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroom.Location = new System.Drawing.Point(287, 240);
            this.txtroom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtroom.Name = "txtroom";
            this.txtroom.Size = new System.Drawing.Size(413, 34);
            this.txtroom.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtroom, "Enter your chosen Room");
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(288, 174);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(412, 34);
            this.txtphone.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtphone, "Enter your Phone Number");
            // 
            // btnrooms
            // 
            this.btnrooms.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnrooms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrooms.ForeColor = System.Drawing.Color.Black;
            this.btnrooms.Location = new System.Drawing.Point(75, 385);
            this.btnrooms.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnrooms.Name = "btnrooms";
            this.btnrooms.Size = new System.Drawing.Size(321, 58);
            this.btnrooms.TabIndex = 8;
            this.btnrooms.Text = "🎟️Book";
            this.btnrooms.UseVisualStyleBackColor = false;
            this.btnrooms.Click += new System.EventHandler(this.btnrooms_Click);
            this.btnrooms.MouseLeave += new System.EventHandler(this.btnrooms_MouseLeave);
            this.btnrooms.MouseHover += new System.EventHandler(this.btnrooms_MouseHover);
            // 
            // lblnumofnight
            // 
            this.lblnumofnight.AutoSize = true;
            this.lblnumofnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumofnight.Location = new System.Drawing.Point(146, 310);
            this.lblnumofnight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumofnight.Name = "lblnumofnight";
            this.lblnumofnight.Size = new System.Drawing.Size(125, 36);
            this.lblnumofnight.TabIndex = 9;
            this.lblnumofnight.Text = "Nights :";
            // 
            // numofnight
            // 
            this.numofnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numofnight.Location = new System.Drawing.Point(287, 314);
            this.numofnight.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.numofnight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numofnight.Name = "numofnight";
            this.numofnight.Size = new System.Drawing.Size(137, 34);
            this.numofnight.TabIndex = 11;
            this.numofnight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total Price :";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(617, 318);
            this.lblprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(31, 32);
            this.lblprice.TabIndex = 13;
            this.lblprice.Text = "0";
            this.lblprice.Click += new System.EventHandler(this.lblprice_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(404, 385);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 58);
            this.button1.TabIndex = 14;
            this.button1.Text = "💲Show Price";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            this.toolTip1.AutoPopDelay = 3000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 60;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(302, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Please Enter Your Name !";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(302, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Please Enter Phone Number !";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(302, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Please Enter Your Chosen Room !";
            this.label5.Visible = false;
            // 
            // lblsucces
            // 
            this.lblsucces.AutoSize = true;
            this.lblsucces.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsucces.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblsucces.Location = new System.Drawing.Point(241, 51);
            this.lblsucces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsucces.Name = "lblsucces";
            this.lblsucces.Size = new System.Drawing.Size(360, 38);
            this.lblsucces.TabIndex = 18;
            this.lblsucces.Text = "Booked Successfully !";
            this.lblsucces.Visible = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.DarkSalmon;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Black;
            this.btncancel.Location = new System.Drawing.Point(238, 447);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(321, 58);
            this.btncancel.TabIndex = 19;
            this.btncancel.Text = "Cancel Booking";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            this.btncancel.MouseLeave += new System.EventHandler(this.btncancel_MouseLeave);
            this.btncancel.MouseHover += new System.EventHandler(this.btncancel_MouseHover);
            // 
            // Booking_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(791, 511);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.lblsucces);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numofnight);
            this.Controls.Add(this.lblnumofnight);
            this.Controls.Add(this.btnrooms);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtroom);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblroom);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Booking_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking_Form";
            this.Load += new System.EventHandler(this.Booking_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numofnight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblroom;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtroom;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnrooms;
        private System.Windows.Forms.Label lblnumofnight;
        private System.Windows.Forms.NumericUpDown numofnight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblsucces;
        private System.Windows.Forms.Button btncancel;
    }
}