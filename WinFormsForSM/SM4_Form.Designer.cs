
namespace WinFormsForSM
{
    partial class SM4_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SM4_Form));
            txtEncodeOutput = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtEncodeInput = new TextBox();
            btnEncode = new Button();
            label1 = new Label();
            label2 = new Label();
            txtKey = new TextBox();
            radECB = new RadioButton();
            radCBC = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            btnDeocde = new Button();
            label7 = new Label();
            txtplainText = new TextBox();
            txtIV = new TextBox();
            labelIV = new Label();
            SuspendLayout();
            // 
            // txtEncodeOutput
            // 
            txtEncodeOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEncodeOutput.Location = new Point(96, 215);
            txtEncodeOutput.Margin = new Padding(4);
            txtEncodeOutput.Multiline = true;
            txtEncodeOutput.Name = "txtEncodeOutput";
            txtEncodeOutput.Size = new Size(801, 72);
            txtEncodeOutput.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 215);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 25;
            label6.Text = "密文：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 119);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 24;
            label5.Text = "明文：";
            // 
            // txtEncodeInput
            // 
            txtEncodeInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEncodeInput.Location = new Point(96, 112);
            txtEncodeInput.Margin = new Padding(4);
            txtEncodeInput.Name = "txtEncodeInput";
            txtEncodeInput.Size = new Size(801, 23);
            txtEncodeInput.TabIndex = 23;
            txtEncodeInput.Text = "You're the best!";
            // 
            // btnEncode
            // 
            btnEncode.Location = new Point(96, 390);
            btnEncode.Margin = new Padding(4);
            btnEncode.Name = "btnEncode";
            btnEncode.Size = new Size(65, 33);
            btnEncode.TabIndex = 27;
            btnEncode.Text = "加密";
            btnEncode.UseVisualStyleBackColor = true;
            btnEncode.Click += btnEncode_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(119, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(549, 44);
            label1.TabIndex = 28;
            label1.Text = "SM4是我国自主设计的分组对称密码算法，用于替代DES/AES等国际算法。\r\nSM4算法与AES算法具有相同的密钥长度、分组长度，都是128bit。";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 166);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 29;
            label2.Text = "秘钥：";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(96, 162);
            txtKey.Margin = new Padding(4);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(349, 23);
            txtKey.TabIndex = 30;
            txtKey.Text = "JeF8U9wHFOMfs2Y8";
            // 
            // radECB
            // 
            radECB.AutoSize = true;
            radECB.Checked = true;
            radECB.Location = new Point(96, 304);
            radECB.Margin = new Padding(4);
            radECB.Name = "radECB";
            radECB.Size = new Size(49, 21);
            radECB.TabIndex = 32;
            radECB.TabStop = true;
            radECB.Text = "ECB";
            radECB.UseVisualStyleBackColor = true;
            // 
            // radCBC
            // 
            radCBC.AutoSize = true;
            radCBC.Location = new Point(164, 304);
            radCBC.Margin = new Padding(4);
            radCBC.Name = "radCBC";
            radCBC.Size = new Size(50, 21);
            radCBC.TabIndex = 33;
            radCBC.Text = "CBC";
            radCBC.UseVisualStyleBackColor = true;
            radCBC.CheckedChanged += radCBC_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 304);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 34;
            label4.Text = "模式：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(453, 166);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 31;
            label3.Text = "自定义秘钥可为空";
            // 
            // btnDeocde
            // 
            btnDeocde.Location = new Point(164, 390);
            btnDeocde.Margin = new Padding(4);
            btnDeocde.Name = "btnDeocde";
            btnDeocde.Size = new Size(65, 33);
            btnDeocde.TabIndex = 35;
            btnDeocde.Text = "解密";
            btnDeocde.UseVisualStyleBackColor = true;
            btnDeocde.Click += btnDeocde_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 455);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(44, 17);
            label7.TabIndex = 36;
            label7.Text = "解密：";
            // 
            // txtplainText
            // 
            txtplainText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtplainText.Location = new Point(96, 450);
            txtplainText.Margin = new Padding(4);
            txtplainText.Multiline = true;
            txtplainText.Name = "txtplainText";
            txtplainText.Size = new Size(801, 74);
            txtplainText.TabIndex = 37;
            // 
            // txtIV
            // 
            txtIV.Location = new Point(96, 344);
            txtIV.Margin = new Padding(4);
            txtIV.Name = "txtIV";
            txtIV.Size = new Size(349, 23);
            txtIV.TabIndex = 39;
            txtIV.Text = "UISwD9fW6cFh9SN8";
            txtIV.Visible = false;
            // 
            // labelIV
            // 
            labelIV.AutoSize = true;
            labelIV.Location = new Point(41, 348);
            labelIV.Margin = new Padding(4, 0, 4, 0);
            labelIV.Name = "labelIV";
            labelIV.Size = new Size(61, 17);
            labelIV.TabIndex = 38;
            labelIV.Text = "向量(iv)：";
            labelIV.Visible = false;
            // 
            // SM4_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 638);
            Controls.Add(txtIV);
            Controls.Add(labelIV);
            Controls.Add(txtplainText);
            Controls.Add(label7);
            Controls.Add(btnDeocde);
            Controls.Add(label4);
            Controls.Add(radCBC);
            Controls.Add(radECB);
            Controls.Add(label3);
            Controls.Add(txtKey);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEncode);
            Controls.Add(txtEncodeOutput);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEncodeInput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "SM4_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "国密SM4测试工具";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtEncodeOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEncodeInput;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.RadioButton radECB;
        private System.Windows.Forms.RadioButton radCBC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeocde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtplainText;
        private TextBox txtIV;
        private Label labelIV;
    }
}