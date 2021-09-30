namespace _1_3習題
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.pbBig = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBig)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "路徑：";
            // 
            // lbPath
            // 
            this.lbPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPath.Location = new System.Drawing.Point(71, 9);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(662, 24);
            this.lbPath.TabIndex = 1;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(172, 633);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(75, 75);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(10, 633);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 75);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "瀏覽";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Location = new System.Drawing.Point(91, 633);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 75);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "<<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(253, 633);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(75, 75);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(334, 633);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(75, 75);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(415, 633);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(75, 75);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 2;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(496, 633);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(75, 75);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 2;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(577, 633);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(75, 75);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 2;
            this.pb6.TabStop = false;
            this.pb6.Click += new System.EventHandler(this.pb1_Click);
            // 
            // btnRight
            // 
            this.btnRight.Enabled = false;
            this.btnRight.Location = new System.Drawing.Point(658, 633);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 75);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = ">>";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // pbBig
            // 
            this.pbBig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBig.Location = new System.Drawing.Point(10, 36);
            this.pbBig.Name = "pbBig";
            this.pbBig.Size = new System.Drawing.Size(723, 591);
            this.pbBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBig.TabIndex = 2;
            this.pbBig.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 720);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.pbBig);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "1_3_7習題";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.PictureBox pbBig;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

