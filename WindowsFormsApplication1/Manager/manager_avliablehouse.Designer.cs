﻿namespace WindowsFormsApplication1.Manager
{
    partial class manager_avliablehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_avliablehouse));
            this.label3 = new System.Windows.Forms.Label();
            this.pHome = new System.Windows.Forms.PictureBox();
            this.pAvailable = new System.Windows.Forms.PictureBox();
            this.pAgent = new System.Windows.Forms.PictureBox();
            this.pAddHouse = new System.Windows.Forms.PictureBox();
            this.pReser = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pClint = new System.Windows.Forms.PictureBox();
            this.pRent = new System.Windows.Forms.PictureBox();
            this.pReturn = new System.Windows.Forms.PictureBox();
            this.pExit = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.luname = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboarea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAddHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pClint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOGOUT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pHome
            // 
            this.pHome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pHome.Image = ((System.Drawing.Image)(resources.GetObject("pHome.Image")));
            this.pHome.Location = new System.Drawing.Point(78, 31);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(69, 60);
            this.pHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pHome.TabIndex = 0;
            this.pHome.TabStop = false;
            this.toolTip1.SetToolTip(this.pHome, "Home");
            this.pHome.Click += new System.EventHandler(this.pHome_Click);
            // 
            // pAvailable
            // 
            this.pAvailable.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pAvailable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAvailable.Image = ((System.Drawing.Image)(resources.GetObject("pAvailable.Image")));
            this.pAvailable.Location = new System.Drawing.Point(153, 31);
            this.pAvailable.Name = "pAvailable";
            this.pAvailable.Size = new System.Drawing.Size(69, 60);
            this.pAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAvailable.TabIndex = 1;
            this.pAvailable.TabStop = false;
            this.toolTip1.SetToolTip(this.pAvailable, "Avaliable\r\n  Houses");
            this.pAvailable.Click += new System.EventHandler(this.pAvailable_Click);
            // 
            // pAgent
            // 
            this.pAgent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pAgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAgent.Image = ((System.Drawing.Image)(resources.GetObject("pAgent.Image")));
            this.pAgent.Location = new System.Drawing.Point(228, 31);
            this.pAgent.Name = "pAgent";
            this.pAgent.Size = new System.Drawing.Size(69, 62);
            this.pAgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAgent.TabIndex = 2;
            this.pAgent.TabStop = false;
            this.toolTip1.SetToolTip(this.pAgent, "Agent Details");
            this.pAgent.Click += new System.EventHandler(this.pAgent_Click);
            // 
            // pAddHouse
            // 
            this.pAddHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAddHouse.Image = ((System.Drawing.Image)(resources.GetObject("pAddHouse.Image")));
            this.pAddHouse.Location = new System.Drawing.Point(303, 31);
            this.pAddHouse.Name = "pAddHouse";
            this.pAddHouse.Size = new System.Drawing.Size(69, 62);
            this.pAddHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAddHouse.TabIndex = 3;
            this.pAddHouse.TabStop = false;
            this.toolTip1.SetToolTip(this.pAddHouse, "Add House");
            this.pAddHouse.Click += new System.EventHandler(this.pAddHouse_Click);
            // 
            // pReser
            // 
            this.pReser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pReser.Image = ((System.Drawing.Image)(resources.GetObject("pReser.Image")));
            this.pReser.Location = new System.Drawing.Point(378, 31);
            this.pReser.Name = "pReser";
            this.pReser.Size = new System.Drawing.Size(69, 62);
            this.pReser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pReser.TabIndex = 4;
            this.pReser.TabStop = false;
            this.toolTip1.SetToolTip(this.pReser, "RECORD MANAGER");
            this.pReser.Click += new System.EventHandler(this.pReser_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 10;
            this.toolTip1.AutoPopDelay = 0;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 2;
            // 
            // pClint
            // 
            this.pClint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pClint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pClint.Image = ((System.Drawing.Image)(resources.GetObject("pClint.Image")));
            this.pClint.Location = new System.Drawing.Point(453, 31);
            this.pClint.Name = "pClint";
            this.pClint.Size = new System.Drawing.Size(69, 60);
            this.pClint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pClint.TabIndex = 5;
            this.pClint.TabStop = false;
            this.toolTip1.SetToolTip(this.pClint, "Clints\r\nDetails");
            this.pClint.Click += new System.EventHandler(this.pClint_Click);
            // 
            // pRent
            // 
            this.pRent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pRent.Cursor = System.Windows.Forms.Cursors.No;
            this.pRent.Image = ((System.Drawing.Image)(resources.GetObject("pRent.Image")));
            this.pRent.Location = new System.Drawing.Point(528, 31);
            this.pRent.Name = "pRent";
            this.pRent.Size = new System.Drawing.Size(69, 60);
            this.pRent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pRent.TabIndex = 6;
            this.pRent.TabStop = false;
            this.toolTip1.SetToolTip(this.pRent, "Only agent can acces");
            // 
            // pReturn
            // 
            this.pReturn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pReturn.Cursor = System.Windows.Forms.Cursors.No;
            this.pReturn.Image = ((System.Drawing.Image)(resources.GetObject("pReturn.Image")));
            this.pReturn.Location = new System.Drawing.Point(603, 31);
            this.pReturn.Name = "pReturn";
            this.pReturn.Size = new System.Drawing.Size(69, 60);
            this.pReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pReturn.TabIndex = 7;
            this.pReturn.TabStop = false;
            this.toolTip1.SetToolTip(this.pReturn, "Only agent can acces");
            // 
            // pExit
            // 
            this.pExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pExit.Image = ((System.Drawing.Image)(resources.GetObject("pExit.Image")));
            this.pExit.Location = new System.Drawing.Point(678, 31);
            this.pExit.Name = "pExit";
            this.pExit.Size = new System.Drawing.Size(69, 62);
            this.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pExit.TabIndex = 8;
            this.pExit.TabStop = false;
            this.toolTip1.SetToolTip(this.pExit, "Exit");
            this.pExit.Click += new System.EventHandler(this.pExit_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 11;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pHome, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.pAvailable, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.pAgent, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.pReser, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.pClint, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.pRent, 7, 1);
            this.tableLayoutPanel3.Controls.Add(this.pReturn, 8, 1);
            this.tableLayoutPanel3.Controls.Add(this.pExit, 9, 1);
            this.tableLayoutPanel3.Controls.Add(this.pAddHouse, 4, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 62);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.85075F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.14925F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(836, 96);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(3, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(45, 41);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // luname
            // 
            this.luname.AutoSize = true;
            this.luname.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luname.ForeColor = System.Drawing.Color.Coral;
            this.luname.Location = new System.Drawing.Point(54, 0);
            this.luname.Name = "luname";
            this.luname.Size = new System.Drawing.Size(88, 46);
            this.luname.TabIndex = 0;
            this.luname.Text = "\r\nUsername";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.luname, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(147, 47);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.06897F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.93103F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 161);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.l1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.comboarea);
            this.panel1.Location = new System.Drawing.Point(40, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 317);
            this.panel1.TabIndex = 10;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Pristina", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.Color.Snow;
            this.l1.Location = new System.Drawing.Point(53, 28);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(156, 35);
            this.l1.TabIndex = 51;
            this.l1.Text = "Avaliable House";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(44, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(711, 238);
            this.listView1.TabIndex = 43;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "House number";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Location";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 452;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 120;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(432, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 23);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search By Area";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboarea
            // 
            this.comboarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboarea.FormattingEnabled = true;
            this.comboarea.Location = new System.Drawing.Point(533, 35);
            this.comboarea.Name = "comboarea";
            this.comboarea.Size = new System.Drawing.Size(144, 21);
            this.comboarea.TabIndex = 41;
            // 
            // manager_avliablehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(844, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "manager_avliablehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVALIABLE HOUSES";
            this.Load += new System.EventHandler(this.manager_avliablehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAddHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pClint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pHome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pAvailable;
        private System.Windows.Forms.PictureBox pAgent;
        private System.Windows.Forms.PictureBox pAddHouse;
        private System.Windows.Forms.PictureBox pReser;
        private System.Windows.Forms.PictureBox pClint;
        private System.Windows.Forms.PictureBox pRent;
        private System.Windows.Forms.PictureBox pReturn;
        private System.Windows.Forms.PictureBox pExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label luname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboarea;
        private System.Windows.Forms.Label l1;
    }
}