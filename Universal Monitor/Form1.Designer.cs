namespace Universal_Monitor
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
            this.urlTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keywordTxtBox = new System.Windows.Forms.TextBox();
            this.addSiteBtn = new System.Windows.Forms.Button();
            this.siteList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.refreshRateNum = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.cookieTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.defineKeywordDrop = new System.Windows.Forms.ComboBox();
            this.stopTskBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRateNum)).BeginInit();
            this.SuspendLayout();
            // 
            // urlTxtBox
            // 
            this.urlTxtBox.Location = new System.Drawing.Point(51, 10);
            this.urlTxtBox.Name = "urlTxtBox";
            this.urlTxtBox.Size = new System.Drawing.Size(163, 20);
            this.urlTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Keyword:";
            // 
            // keywordTxtBox
            // 
            this.keywordTxtBox.Location = new System.Drawing.Point(278, 10);
            this.keywordTxtBox.Name = "keywordTxtBox";
            this.keywordTxtBox.Size = new System.Drawing.Size(132, 20);
            this.keywordTxtBox.TabIndex = 3;
            // 
            // addSiteBtn
            // 
            this.addSiteBtn.Location = new System.Drawing.Point(606, 35);
            this.addSiteBtn.Name = "addSiteBtn";
            this.addSiteBtn.Size = new System.Drawing.Size(101, 23);
            this.addSiteBtn.TabIndex = 4;
            this.addSiteBtn.Text = "Add Site";
            this.addSiteBtn.UseVisualStyleBackColor = true;
            this.addSiteBtn.Click += new System.EventHandler(this.addSiteBtn_Click);
            // 
            // siteList
            // 
            this.siteList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader4});
            this.siteList.HideSelection = false;
            this.siteList.Location = new System.Drawing.Point(16, 64);
            this.siteList.Name = "siteList";
            this.siteList.Size = new System.Drawing.Size(690, 201);
            this.siteList.TabIndex = 5;
            this.siteList.UseCompatibleStateImageBehavior = false;
            this.siteList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Website URL";
            this.columnHeader1.Width = 186;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Keyword";
            this.columnHeader2.Width = 164;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Keyword State";
            this.columnHeader5.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Refresh Rate(ms)";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cookies";
            this.columnHeader4.Width = 113;
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(12, 271);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(588, 23);
            this.checkBtn.TabIndex = 6;
            this.checkBtn.Text = "Start Checking";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Refresh Rate(ms):";
            // 
            // refreshRateNum
            // 
            this.refreshRateNum.Location = new System.Drawing.Point(609, 10);
            this.refreshRateNum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.refreshRateNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.refreshRateNum.Name = "refreshRateNum";
            this.refreshRateNum.Size = new System.Drawing.Size(97, 20);
            this.refreshRateNum.TabIndex = 9;
            this.refreshRateNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.refreshRateNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cookieTxtBox
            // 
            this.cookieTxtBox.Location = new System.Drawing.Point(66, 38);
            this.cookieTxtBox.Name = "cookieTxtBox";
            this.cookieTxtBox.Size = new System.Drawing.Size(537, 20);
            this.cookieTxtBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cookies:";
            // 
            // defineKeywordDrop
            // 
            this.defineKeywordDrop.FormattingEnabled = true;
            this.defineKeywordDrop.Items.AddRange(new object[] {
            "In Stock",
            "Out Of Stock"});
            this.defineKeywordDrop.Location = new System.Drawing.Point(416, 10);
            this.defineKeywordDrop.MaxDropDownItems = 2;
            this.defineKeywordDrop.Name = "defineKeywordDrop";
            this.defineKeywordDrop.Size = new System.Drawing.Size(89, 21);
            this.defineKeywordDrop.TabIndex = 13;
            this.defineKeywordDrop.Text = "Out Of Stock";
            // 
            // stopTskBtn
            // 
            this.stopTskBtn.Location = new System.Drawing.Point(13, 301);
            this.stopTskBtn.Name = "stopTskBtn";
            this.stopTskBtn.Size = new System.Drawing.Size(693, 23);
            this.stopTskBtn.TabIndex = 14;
            this.stopTskBtn.Text = "Stop all Tasks";
            this.stopTskBtn.UseVisualStyleBackColor = true;
            this.stopTskBtn.Click += new System.EventHandler(this.stopTskBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(719, 329);
            this.Controls.Add(this.stopTskBtn);
            this.Controls.Add(this.defineKeywordDrop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cookieTxtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refreshRateNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.siteList);
            this.Controls.Add(this.addSiteBtn);
            this.Controls.Add(this.keywordTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlTxtBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Universal Stock Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refreshRateNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keywordTxtBox;
        private System.Windows.Forms.Button addSiteBtn;
        private System.Windows.Forms.ListView siteList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown refreshRateNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox cookieTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox defineKeywordDrop;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button stopTskBtn;
    }
}

