namespace fastFoodResturant
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button_user = new System.Windows.Forms.Button();
            this.button_pay = new System.Windows.Forms.Button();
            this.button_collection = new System.Windows.Forms.Button();
            this.button_best = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.paymentUserControl11 = new fastFoodResturant.paymentUserControl1();
            this.notificationUserControl11 = new fastFoodResturant.notificationUserControl1();
            this.customerUserControl11 = new fastFoodResturant.customerUserControl1();
            this.registerUserControl11 = new fastFoodResturant.registerUserControl1();
            this.loginUserControl11 = new fastFoodResturant.loginUserControl1((Form1)this);
            this.collectionUserControl11 = new collectionUserControl1(notificationUserControl11);
            this.firstUserControl11 = new fastFoodResturant.firstUserControl1(notificationUserControl11);
            this.secondUserControl11 = new fastFoodResturant.secondUserControl1(notificationUserControl11);
            this.button2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button_user);
            this.panel1.Controls.Add(this.button_pay);
            this.panel1.Controls.Add(this.button_collection);
            this.panel1.Controls.Add(this.button_best);
            this.panel1.Controls.Add(this.button_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 561);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel4.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.panel4.Location = new System.Drawing.Point(0, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(11, 53);
            this.panel4.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(12, 412);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 53);
            this.button6.TabIndex = 5;
            this.button6.Text = "    Register";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.reg_btn);
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(12, 353);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(197, 53);
            this.button12.TabIndex = 5;
            this.button12.Text = "    Login";
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.login_btn);
            // 
            // button_user
            // 
            this.button_user.FlatAppearance.BorderSize = 0;
            this.button_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_user.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_user.Image = ((System.Drawing.Image)(resources.GetObject("button_user.Image")));
            this.button_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_user.Location = new System.Drawing.Point(12, 294);
            this.button_user.Name = "button_user";
            this.button_user.Size = new System.Drawing.Size(197, 53);
            this.button_user.TabIndex = 5;
            this.button_user.Text = "    Customers";
            this.button_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_user.UseVisualStyleBackColor = true;
            this.button_user.Click += new System.EventHandler(this.custome_btn);
            // 
            // button_pay
            // 
            this.button_pay.FlatAppearance.BorderSize = 0;
            this.button_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_pay.Image = ((System.Drawing.Image)(resources.GetObject("button_pay.Image")));
            this.button_pay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_pay.Location = new System.Drawing.Point(12, 235);
            this.button_pay.Name = "button_pay";
            this.button_pay.Size = new System.Drawing.Size(197, 53);
            this.button_pay.TabIndex = 5;
            this.button_pay.Text = "    Delivery Payment";
            this.button_pay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_pay.UseVisualStyleBackColor = true;
            this.button_pay.Click += new System.EventHandler(this.payment_btn);
            // 
            // button_collection
            // 
            this.button_collection.FlatAppearance.BorderSize = 0;
            this.button_collection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_collection.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_collection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_collection.Image = ((System.Drawing.Image)(resources.GetObject("button_collection.Image")));
            this.button_collection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_collection.Location = new System.Drawing.Point(12, 176);
            this.button_collection.Name = "button_collection";
            this.button_collection.Size = new System.Drawing.Size(197, 53);
            this.button_collection.TabIndex = 5;
            this.button_collection.Text = "    Collection";
            this.button_collection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_collection.UseVisualStyleBackColor = true;
            this.button_collection.Click += new System.EventHandler(this.order_btn);
            // 
            // button_best
            // 
            this.button_best.FlatAppearance.BorderSize = 0;
            this.button_best.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_best.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_best.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_best.Image = ((System.Drawing.Image)(resources.GetObject("button_best.Image")));
            this.button_best.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_best.Location = new System.Drawing.Point(12, 117);
            this.button_best.Name = "button_best";
            this.button_best.Size = new System.Drawing.Size(197, 53);
            this.button_best.TabIndex = 5;
            this.button_best.Text = "    Best Orders";
            this.button_best.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_best.UseVisualStyleBackColor = true;
            this.button_best.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_home
            // 
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_home.Image = ((System.Drawing.Image)(resources.GetObject("button_home.Image")));
            this.button_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home.Location = new System.Drawing.Point(12, 58);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(197, 53);
            this.button_home.TabIndex = 5;
            this.button_home.Text = "   Home";
            this.button_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 14);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(266, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 182);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Restaurant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fast Foods";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Collegae project team";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.paymentUserControl11);
            this.panel5.Controls.Add(this.collectionUserControl11);
            this.panel5.Controls.Add(this.customerUserControl11);
            this.panel5.Controls.Add(this.notificationUserControl11);
            this.panel5.Controls.Add(this.registerUserControl11);
            this.panel5.Controls.Add(this.loginUserControl11);
            this.panel5.Controls.Add(this.firstUserControl11);
            this.panel5.Controls.Add(this.secondUserControl11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(209, 198);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(715, 363);
            this.panel5.TabIndex = 6;
            // 
            // paymentUserControl11
            // 
            this.paymentUserControl11.Location = new System.Drawing.Point(0, 0);
            this.paymentUserControl11.Name = "paymentUserControl11";
            this.paymentUserControl11.Size = new System.Drawing.Size(715, 363);
            this.paymentUserControl11.TabIndex = 7;
            this.paymentUserControl11.Load += new System.EventHandler(this.paymentUserControl11_Load);
            // 
            // notificationUserControl11
            // 
            this.notificationUserControl11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.notificationUserControl11.Location = new System.Drawing.Point(0, 0);
            this.notificationUserControl11.Name = "notificationUserControl11";
            this.notificationUserControl11.Size = new System.Drawing.Size(715, 363);
            this.notificationUserControl11.TabIndex = 5;
            // 
            // collectionUserControl11
            // 
            this.collectionUserControl11.Location = new System.Drawing.Point(-3, -12);
            this.collectionUserControl11.Name = "collectionUserControl11";
            this.collectionUserControl11.Size = new System.Drawing.Size(715, 363);
            this.collectionUserControl11.TabIndex = 0;
            // 
            // customerUserControl11
            // 
            this.customerUserControl11.Location = new System.Drawing.Point(0, 0);
            this.customerUserControl11.Name = "customerUserControl11";
            this.customerUserControl11.Size = new System.Drawing.Size(715, 363);
            this.customerUserControl11.TabIndex = 6;
            // 
            // registerUserControl11
            // 
            this.registerUserControl11.BackColor = System.Drawing.Color.LightGreen;
            this.registerUserControl11.Location = new System.Drawing.Point(0, 0);
            this.registerUserControl11.Name = "registerUserControl11";
            this.registerUserControl11.Size = new System.Drawing.Size(715, 363);
            this.registerUserControl11.TabIndex = 3;
            // 
            // loginUserControl11
            // 
            this.loginUserControl11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginUserControl11.Location = new System.Drawing.Point(0, 0);
            this.loginUserControl11.Name = "loginUserControl11";
            this.loginUserControl11.Size = new System.Drawing.Size(715, 363);
            this.loginUserControl11.TabIndex = 2;
            // 
            // firstUserControl11
            // 
            this.firstUserControl11.Location = new System.Drawing.Point(0, 0);
            this.firstUserControl11.Name = "firstUserControl11";
            this.firstUserControl11.Size = new System.Drawing.Size(715, 363);
            this.firstUserControl11.TabIndex = 0;
            // 
            // secondUserControl11
            // 
            this.secondUserControl11.Location = new System.Drawing.Point(0, 0);
            this.secondUserControl11.Name = "secondUserControl11";
            this.secondUserControl11.Size = new System.Drawing.Size(715, 363);
            this.secondUserControl11.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(855, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 53);
            this.button2.TabIndex = 5;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(626, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(38, 53);
            this.button9.TabIndex = 5;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(670, 20);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(44, 53);
            this.button10.TabIndex = 5;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(720, 20);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 53);
            this.button11.TabIndex = 5;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(806, 27);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(43, 46);
            this.button13.TabIndex = 5;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.not_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(766, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 46);
            this.button5.TabIndex = 5;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.logout_btn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 561);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button button_user;
        public System.Windows.Forms.Button button_pay;
        public System.Windows.Forms.Button button_collection;
        public System.Windows.Forms.Button button_best;
        private System.Windows.Forms.Panel panel5;
        private firstUserControl1 firstUserControl11;
        private secondUserControl1 secondUserControl11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button6;
        private loginUserControl1 loginUserControl11;
        private registerUserControl1 registerUserControl11;
        private System.Windows.Forms.Button button13;
        private notificationUserControl1 notificationUserControl11;
        private customerUserControl1 customerUserControl11;
        private collectionUserControl1 collectionUserControl11;
        private paymentUserControl1 paymentUserControl11;
        private System.Windows.Forms.Button button5;
    }
}

