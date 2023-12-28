
namespace HandWriteApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_big = new System.Windows.Forms.PictureBox();
            this.btn_clearPic = new System.Windows.Forms.Button();
            this.pictureBox_small = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_serial_open = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_COM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_baud = new System.Windows.Forms.TextBox();
            this.tb_log = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_big)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_small)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_big
            // 
            this.pictureBox_big.Location = new System.Drawing.Point(6, 20);
            this.pictureBox_big.MaximumSize = new System.Drawing.Size(280, 280);
            this.pictureBox_big.MinimumSize = new System.Drawing.Size(280, 280);
            this.pictureBox_big.Name = "pictureBox_big";
            this.pictureBox_big.Size = new System.Drawing.Size(280, 280);
            this.pictureBox_big.TabIndex = 0;
            this.pictureBox_big.TabStop = false;
            this.pictureBox_big.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_big_MouseDown);
            this.pictureBox_big.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_big_MouseMove);
            this.pictureBox_big.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_big_MouseUp);
            // 
            // btn_clearPic
            // 
            this.btn_clearPic.Location = new System.Drawing.Point(6, 306);
            this.btn_clearPic.Name = "btn_clearPic";
            this.btn_clearPic.Size = new System.Drawing.Size(75, 23);
            this.btn_clearPic.TabIndex = 1;
            this.btn_clearPic.Text = "Clear";
            this.btn_clearPic.UseVisualStyleBackColor = true;
            this.btn_clearPic.Click += new System.EventHandler(this.btn_clearPic_Click);
            // 
            // pictureBox_small
            // 
            this.pictureBox_small.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_small.Location = new System.Drawing.Point(258, 306);
            this.pictureBox_small.MaximumSize = new System.Drawing.Size(28, 28);
            this.pictureBox_small.MinimumSize = new System.Drawing.Size(28, 28);
            this.pictureBox_small.Name = "pictureBox_small";
            this.pictureBox_small.Size = new System.Drawing.Size(28, 28);
            this.pictureBox_small.TabIndex = 2;
            this.pictureBox_small.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_big);
            this.groupBox1.Controls.Add(this.pictureBox_small);
            this.groupBox1.Controls.Add(this.btn_clearPic);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 340);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WriteRegion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Send);
            this.groupBox2.Controls.Add(this.btn_serial_open);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox_COM);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_baud);
            this.groupBox2.Location = new System.Drawing.Point(315, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 54);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(330, 17);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(87, 23);
            this.btn_Send.TabIndex = 4;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_serial_open
            // 
            this.btn_serial_open.Location = new System.Drawing.Point(237, 17);
            this.btn_serial_open.Name = "btn_serial_open";
            this.btn_serial_open.Size = new System.Drawing.Size(87, 23);
            this.btn_serial_open.TabIndex = 3;
            this.btn_serial_open.Text = "Open";
            this.btn_serial_open.UseVisualStyleBackColor = true;
            this.btn_serial_open.Click += new System.EventHandler(this.btn_serial_open_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud";
            // 
            // comboBox_COM
            // 
            this.comboBox_COM.FormattingEnabled = true;
            this.comboBox_COM.Location = new System.Drawing.Point(35, 20);
            this.comboBox_COM.Name = "comboBox_COM";
            this.comboBox_COM.Size = new System.Drawing.Size(82, 20);
            this.comboBox_COM.TabIndex = 2;
            this.comboBox_COM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_COM_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // tb_baud
            // 
            this.tb_baud.Location = new System.Drawing.Point(158, 19);
            this.tb_baud.Name = "tb_baud";
            this.tb_baud.Size = new System.Drawing.Size(73, 21);
            this.tb_baud.TabIndex = 0;
            this.tb_baud.Text = "115200";
            // 
            // tb_log
            // 
            this.tb_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_log.Font = new System.Drawing.Font("宋体", 14F);
            this.tb_log.Location = new System.Drawing.Point(315, 72);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_log.Size = new System.Drawing.Size(434, 280);
            this.tb_log.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 362);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(777, 401);
            this.Name = "Form1";
            this.Text = "HandWriteDemo V1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_big)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_small)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_big;
        private System.Windows.Forms.Button btn_clearPic;
        private System.Windows.Forms.PictureBox pictureBox_small;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_serial_open;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_COM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_baud;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.Button btn_Send;
    }
}

