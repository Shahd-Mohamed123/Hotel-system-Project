namespace Hotel_Reservation_System
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaddsingle = new System.Windows.Forms.Button();
            this.btnadddouble = new System.Windows.Forms.Button();
            this.btnaddsuit = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnums = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column3,
            this.Column4,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(29, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 265);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "ID";
            this.Column5.MinimumWidth = 4;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Customer Name";
            this.Column3.MinimumWidth = 4;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Phone";
            this.Column4.MinimumWidth = 4;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Room Number";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Type";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(-40, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1147, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "                                          Hotel Management                       " +
    "                   ";
            // 
            // btnaddsingle
            // 
            this.btnaddsingle.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnaddsingle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddsingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddsingle.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnaddsingle.Location = new System.Drawing.Point(29, 365);
            this.btnaddsingle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnaddsingle.Name = "btnaddsingle";
            this.btnaddsingle.Size = new System.Drawing.Size(231, 58);
            this.btnaddsingle.TabIndex = 11;
            this.btnaddsingle.Text = "+ Single Room";
            this.btnaddsingle.UseVisualStyleBackColor = false;
            this.btnaddsingle.Click += new System.EventHandler(this.btnaddsingle_Click);
            // 
            // btnadddouble
            // 
            this.btnadddouble.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnadddouble.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadddouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadddouble.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnadddouble.Location = new System.Drawing.Point(292, 365);
            this.btnadddouble.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnadddouble.Name = "btnadddouble";
            this.btnadddouble.Size = new System.Drawing.Size(231, 58);
            this.btnadddouble.TabIndex = 12;
            this.btnadddouble.Text = "+ Double Room";
            this.btnadddouble.UseVisualStyleBackColor = false;
            this.btnadddouble.Click += new System.EventHandler(this.btnadddouble_Click);
            // 
            // btnaddsuit
            // 
            this.btnaddsuit.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnaddsuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddsuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddsuit.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnaddsuit.Location = new System.Drawing.Point(559, 365);
            this.btnaddsuit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnaddsuit.Name = "btnaddsuit";
            this.btnaddsuit.Size = new System.Drawing.Size(231, 58);
            this.btnaddsuit.TabIndex = 13;
            this.btnaddsuit.Text = "+ Suit Room";
            this.btnaddsuit.UseVisualStyleBackColor = false;
            this.btnaddsuit.Click += new System.EventHandler(this.btnaddsuit_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(29, 447);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(231, 30);
            this.txtnum1.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtnum1, "Enter Room Number");
            // 
            // txtnums
            // 
            this.txtnums.Location = new System.Drawing.Point(559, 447);
            this.txtnums.Name = "txtnums";
            this.txtnums.Size = new System.Drawing.Size(231, 30);
            this.txtnums.TabIndex = 19;
            this.toolTip1.SetToolTip(this.txtnums, "Enter Room Number");
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(292, 447);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(231, 30);
            this.txtnum2.TabIndex = 21;
            this.toolTip1.SetToolTip(this.txtnum2, "Enter Room Number");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            this.toolTip1.AutoPopDelay = 3000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 60;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(819, 543);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnums);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.btnaddsuit);
            this.Controls.Add(this.btnadddouble);
            this.Controls.Add(this.btnaddsingle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Admin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddsingle;
        private System.Windows.Forms.Button btnadddouble;
        private System.Windows.Forms.Button btnaddsuit;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnums;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}