
namespace WinFormsForSM
{
    partial class SM2_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SM2_Form));
            btnGenerateKey = new Button();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            txtPubKey = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPriKey = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtEncodeInput = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnEncode = new Button();
            label7 = new Label();
            label8 = new Label();
            btnDecode = new Button();
            label9 = new Label();
            label10 = new Label();
            txtDecodeOutput = new TextBox();
            label11 = new Label();
            txtDecodeInput = new TextBox();
            txtEncodeOutput = new TextBox();
            label12 = new Label();
            label13 = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGenerateKey
            // 
            btnGenerateKey.Location = new Point(78, 136);
            btnGenerateKey.Margin = new Padding(4, 4, 4, 4);
            btnGenerateKey.Name = "btnGenerateKey";
            btnGenerateKey.Size = new Size(121, 33);
            btnGenerateKey.TabIndex = 0;
            btnGenerateKey.Text = "生成公钥和私钥";
            btnGenerateKey.UseVisualStyleBackColor = true;
            btnGenerateKey.Click += btnGenerateKey_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 869);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1119, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(80, 17);
            lblStatus.Text = "在线验证工具";
            lblStatus.Click += lblStatus_Click;
            // 
            // txtPubKey
            // 
            txtPubKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPubKey.Location = new Point(78, 60);
            txtPubKey.Margin = new Padding(4, 4, 4, 4);
            txtPubKey.Name = "txtPubKey";
            txtPubKey.Size = new Size(1010, 23);
            txtPubKey.TabIndex = 2;
            txtPubKey.Text = "BO4x5eOZM1m+ebzkQc20Xx1V/k4f/bJFcuF72wR9FTSlSFgB/WghBp/HbKepgrG6YQPAz6OWTcr/qItxH5a1koU=";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 3;
            label1.Text = "公钥：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 103);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 5;
            label2.Text = "私钥：";
            // 
            // txtPriKey
            // 
            txtPriKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPriKey.Location = new Point(78, 98);
            txtPriKey.Margin = new Padding(4, 4, 4, 4);
            txtPriKey.Name = "txtPriKey";
            txtPriKey.Size = new Size(1010, 23);
            txtPriKey.TabIndex = 4;
            txtPriKey.Text = "Yl5iwQsc4DEgjKOevwYBqeGS2FYrP1u1D0zeG7zSv/M=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(144, 198);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 6;
            label3.Text = "（公钥加密）";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(145, 490);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 7;
            label4.Text = "（私钥解密）";
            // 
            // txtEncodeInput
            // 
            txtEncodeInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEncodeInput.Location = new Point(78, 232);
            txtEncodeInput.Margin = new Padding(4, 4, 4, 4);
            txtEncodeInput.Name = "txtEncodeInput";
            txtEncodeInput.Size = new Size(1010, 23);
            txtEncodeInput.TabIndex = 8;
            txtEncodeInput.Text = "asdcdefg1234567890!@#$%^&*()";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 239);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 9;
            label5.Text = "明文：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 282);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 10;
            label6.Text = "密文：";
            // 
            // btnEncode
            // 
            btnEncode.Location = new Point(78, 408);
            btnEncode.Margin = new Padding(4, 4, 4, 4);
            btnEncode.Name = "btnEncode";
            btnEncode.Size = new Size(65, 33);
            btnEncode.TabIndex = 12;
            btnEncode.Text = "加密";
            btnEncode.UseVisualStyleBackColor = true;
            btnEncode.Click += btnEncode_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("宋体", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.Location = new Point(23, 21);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(142, 12);
            label7.TabIndex = 13;
            label7.Text = "第1步：生成公钥和私钥";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("宋体", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label8.Location = new Point(23, 197);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 12);
            label8.TabIndex = 14;
            label8.Text = "第2步：测试加密";
            // 
            // btnDecode
            // 
            btnDecode.Location = new Point(78, 698);
            btnDecode.Margin = new Padding(4, 4, 4, 4);
            btnDecode.Name = "btnDecode";
            btnDecode.Size = new Size(65, 33);
            btnDecode.TabIndex = 19;
            btnDecode.Text = "解密";
            btnDecode.UseVisualStyleBackColor = true;
            btnDecode.Click += btnDecode_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 540);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(44, 17);
            label9.TabIndex = 17;
            label9.Text = "密文：";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 662);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 17);
            label10.TabIndex = 16;
            label10.Text = "明文：";
            // 
            // txtDecodeOutput
            // 
            txtDecodeOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDecodeOutput.Location = new Point(78, 654);
            txtDecodeOutput.Margin = new Padding(4, 4, 4, 4);
            txtDecodeOutput.Name = "txtDecodeOutput";
            txtDecodeOutput.Size = new Size(1010, 23);
            txtDecodeOutput.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("宋体", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label11.Location = new Point(23, 489);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(103, 12);
            label11.TabIndex = 20;
            label11.Text = "第3步：测试解密";
            // 
            // txtDecodeInput
            // 
            txtDecodeInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDecodeInput.Location = new Point(78, 536);
            txtDecodeInput.Margin = new Padding(4, 4, 4, 4);
            txtDecodeInput.Multiline = true;
            txtDecodeInput.Name = "txtDecodeInput";
            txtDecodeInput.Size = new Size(1010, 109);
            txtDecodeInput.TabIndex = 21;
            // 
            // txtEncodeOutput
            // 
            txtEncodeOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEncodeOutput.Location = new Point(78, 278);
            txtEncodeOutput.Margin = new Padding(4, 4, 4, 4);
            txtEncodeOutput.Multiline = true;
            txtEncodeOutput.Name = "txtEncodeOutput";
            txtEncodeOutput.Size = new Size(1010, 109);
            txtEncodeOutput.TabIndex = 22;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label12.ForeColor = Color.Green;
            label12.Location = new Point(638, 411);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(384, 68);
            label12.TabIndex = 23;
            label12.Text = "SM2加密过程：\r\n1.先将待加密字符串(string)转换为byte[]。\r\n2.再对byte[]进行加密运算，返回16进制的字节数组byte[]。\r\n3.最后将加密后的16进制byte[]，转换为16进制的原码字符串(string)。";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label13.ForeColor = Color.Green;
            label13.Location = new Point(638, 698);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(312, 68);
            label13.TabIndex = 24;
            label13.Text = "SM2解密过程：\r\n1.先将待解密的16进制原码字符串转字节数组byte[]。\r\n2.再对byte[]进行解密运算，返回解密文本对应的btye[]。\r\n3.最后将解密后的byte[]，再转换为普通字符串(string)。";
            // 
            // SM2_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 891);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtEncodeOutput);
            Controls.Add(txtDecodeInput);
            Controls.Add(label11);
            Controls.Add(btnDecode);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtDecodeOutput);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnEncode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEncodeInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPriKey);
            Controls.Add(label1);
            Controls.Add(txtPubKey);
            Controls.Add(statusStrip1);
            Controls.Add(btnGenerateKey);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "SM2_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "国密SM2算法辅助工具";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TextBox txtPubKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPriKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEncodeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDecodeOutput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDecodeInput;
        private System.Windows.Forms.TextBox txtEncodeOutput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

