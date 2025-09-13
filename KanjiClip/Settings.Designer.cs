namespace KanjiClip
{
    partial class Settings
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nanoGPTBaseUrl = new FlatUI.FlatTextBox();
            this.nanoGPTApiKey = new FlatUI.FlatTextBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.imgBBKey = new FlatUI.FlatTextBox();
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatButton2 = new KanjiClip.Components.FlatButton();
            this.formSkin1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.tableLayoutPanel1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(265, 305);
            this.formSkin1.TabIndex = 1;
            this.formSkin1.Text = "Settings";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Controls.Add(this.nanoGPTBaseUrl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nanoGPTApiKey, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flatLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flatLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flatLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.imgBBKey, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flatButton1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flatButton2, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.53853F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.53853F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.53853F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.3844F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 223);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // nanoGPTBaseUrl
            // 
            this.nanoGPTBaseUrl.BackColor = System.Drawing.Color.Transparent;
            this.nanoGPTBaseUrl.FocusOnHover = false;
            this.nanoGPTBaseUrl.Location = new System.Drawing.Point(119, 129);
            this.nanoGPTBaseUrl.MaxLength = 32767;
            this.nanoGPTBaseUrl.Multiline = false;
            this.nanoGPTBaseUrl.Name = "nanoGPTBaseUrl";
            this.nanoGPTBaseUrl.ReadOnly = false;
            this.nanoGPTBaseUrl.Size = new System.Drawing.Size(137, 29);
            this.nanoGPTBaseUrl.TabIndex = 5;
            this.nanoGPTBaseUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nanoGPTBaseUrl.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nanoGPTBaseUrl.UseSystemPasswordChar = false;
            // 
            // nanoGPTApiKey
            // 
            this.nanoGPTApiKey.BackColor = System.Drawing.Color.Transparent;
            this.nanoGPTApiKey.FocusOnHover = false;
            this.nanoGPTApiKey.Location = new System.Drawing.Point(119, 66);
            this.nanoGPTApiKey.MaxLength = 32767;
            this.nanoGPTApiKey.Multiline = false;
            this.nanoGPTApiKey.Name = "nanoGPTApiKey";
            this.nanoGPTApiKey.ReadOnly = false;
            this.nanoGPTApiKey.Size = new System.Drawing.Size(137, 29);
            this.nanoGPTApiKey.TabIndex = 4;
            this.nanoGPTApiKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nanoGPTApiKey.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nanoGPTApiKey.UseSystemPasswordChar = false;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(3, 0);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(107, 20);
            this.flatLabel1.TabIndex = 0;
            this.flatLabel1.Text = "ImgBB API Key";
            this.flatLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(3, 63);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(110, 17);
            this.flatLabel2.TabIndex = 1;
            this.flatLabel2.Text = "NanoGPT API Key";
            this.flatLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(3, 126);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(102, 15);
            this.flatLabel3.TabIndex = 2;
            this.flatLabel3.Text = "NanoGPT Base Url";
            this.flatLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgBBKey
            // 
            this.imgBBKey.BackColor = System.Drawing.Color.Transparent;
            this.imgBBKey.FocusOnHover = false;
            this.imgBBKey.Location = new System.Drawing.Point(119, 3);
            this.imgBBKey.MaxLength = 32767;
            this.imgBBKey.Multiline = false;
            this.imgBBKey.Name = "imgBBKey";
            this.imgBBKey.ReadOnly = false;
            this.imgBBKey.Size = new System.Drawing.Size(137, 29);
            this.imgBBKey.TabIndex = 3;
            this.imgBBKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.imgBBKey.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.imgBBKey.UseSystemPasswordChar = false;
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(119, 192);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(137, 28);
            this.flatButton1.TabIndex = 10;
            this.flatButton1.Text = "Save";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.SaveSettings);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(235, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 1;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(211, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 0;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(3, 192);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(106, 28);
            this.flatButton2.TabIndex = 11;
            this.flatButton2.Text = "Cancel";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.Close);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 305);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatMini flatMini1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatTextBox nanoGPTBaseUrl;
        private FlatUI.FlatTextBox nanoGPTApiKey;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatTextBox imgBBKey;
        private FlatUI.FlatButton flatButton1;
        private Components.FlatButton flatButton2;
    }
}