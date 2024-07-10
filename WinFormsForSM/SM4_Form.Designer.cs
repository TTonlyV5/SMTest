
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
            label4 = new Label();
            label3 = new Label();
            btnDeocde = new Button();
            label7 = new Label();
            txtplainText = new TextBox();
            txtIV = new TextBox();
            labelIV = new Label();
            label8 = new Label();
            BtnGen = new Button();
            comBoxMode = new ComboBox();
            comBoxEncoding = new ComboBox();
            SuspendLayout();
            // 
            // txtEncodeOutput
            // 
            txtEncodeOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEncodeOutput.Location = new Point(151, 317);
            txtEncodeOutput.Margin = new Padding(6);
            txtEncodeOutput.Multiline = true;
            txtEncodeOutput.Name = "txtEncodeOutput";
            txtEncodeOutput.Size = new Size(1256, 100);
            txtEncodeOutput.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 317);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 24);
            label6.TabIndex = 25;
            label6.Text = "密文：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 168);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 24);
            label5.TabIndex = 24;
            label5.Text = "明文：";
            // 
            // txtEncodeInput
            // 
            txtEncodeInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEncodeInput.Location = new Point(151, 158);
            txtEncodeInput.Margin = new Padding(6);
            txtEncodeInput.Name = "txtEncodeInput";
            txtEncodeInput.Size = new Size(1256, 30);
            txtEncodeInput.TabIndex = 23;
            txtEncodeInput.Text = "Hello, SM4 Encryption!";
            // 
            // btnEncode
            // 
            btnEncode.Location = new Point(151, 551);
            btnEncode.Margin = new Padding(6);
            btnEncode.Name = "btnEncode";
            btnEncode.Size = new Size(102, 47);
            btnEncode.TabIndex = 27;
            btnEncode.Text = "加密";
            btnEncode.UseVisualStyleBackColor = true;
            btnEncode.Click += btnEncode_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(187, 30);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(820, 62);
            label1.TabIndex = 28;
            label1.Text = "SM4是我国自主设计的分组对称密码算法，用于替代DES/AES等国际算法。\r\nSM4算法与AES算法具有相同的密钥长度、分组长度，都是128bit。";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 267);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 29;
            label2.Text = "秘钥：";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(151, 262);
            txtKey.Margin = new Padding(6);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(546, 30);
            txtKey.TabIndex = 30;
            txtKey.Text = "98C63180C3748ED2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 429);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 34;
            label4.Text = "模式：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(712, 267);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 24);
            label3.TabIndex = 31;
            label3.Text = "自定义秘钥可为空";
            // 
            // btnDeocde
            // 
            btnDeocde.Location = new Point(258, 551);
            btnDeocde.Margin = new Padding(6);
            btnDeocde.Name = "btnDeocde";
            btnDeocde.Size = new Size(102, 47);
            btnDeocde.TabIndex = 35;
            btnDeocde.Text = "解密";
            btnDeocde.UseVisualStyleBackColor = true;
            btnDeocde.Click += btnDeocde_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 642);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 24);
            label7.TabIndex = 36;
            label7.Text = "解密：";
            // 
            // txtplainText
            // 
            txtplainText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtplainText.Location = new Point(151, 635);
            txtplainText.Margin = new Padding(6);
            txtplainText.Multiline = true;
            txtplainText.Name = "txtplainText";
            txtplainText.Size = new Size(1256, 103);
            txtplainText.TabIndex = 37;
            // 
            // txtIV
            // 
            txtIV.Location = new Point(151, 486);
            txtIV.Margin = new Padding(6);
            txtIV.Name = "txtIV";
            txtIV.Size = new Size(546, 30);
            txtIV.TabIndex = 39;
            txtIV.Text = "UISwD9fW6cFh9SNS";
            txtIV.Visible = false;
            // 
            // labelIV
            // 
            labelIV.AutoSize = true;
            labelIV.Location = new Point(64, 491);
            labelIV.Margin = new Padding(6, 0, 6, 0);
            labelIV.Name = "labelIV";
            labelIV.Size = new Size(90, 24);
            labelIV.TabIndex = 38;
            labelIV.Text = "向量(iv)：";
            labelIV.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(64, 215);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(64, 24);
            label8.TabIndex = 42;
            label8.Text = "编码：";
            // 
            // BtnGen
            // 
            BtnGen.Location = new Point(1006, 254);
            BtnGen.Margin = new Padding(6);
            BtnGen.Name = "BtnGen";
            BtnGen.Size = new Size(221, 47);
            BtnGen.TabIndex = 43;
            BtnGen.Text = "生成Hex的key、Iv";
            BtnGen.UseVisualStyleBackColor = true;
            BtnGen.Click += BtnGen_Click;
            // 
            // comBoxMode
            // 
            comBoxMode.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxMode.FormattingEnabled = true;
            comBoxMode.Location = new Point(151, 429);
            comBoxMode.Name = "comBoxMode";
            comBoxMode.Size = new Size(182, 32);
            comBoxMode.TabIndex = 44;
            comBoxMode.SelectedIndexChanged += comBoxMode_SelectedIndexChanged;
            // 
            // comBoxEncoding
            // 
            comBoxEncoding.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxEncoding.FormattingEnabled = true;
            comBoxEncoding.Location = new Point(151, 212);
            comBoxEncoding.Name = "comBoxEncoding";
            comBoxEncoding.Size = new Size(182, 32);
            comBoxEncoding.TabIndex = 45;
            // 
            // SM4_Form
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 901);
            Controls.Add(comBoxEncoding);
            Controls.Add(comBoxMode);
            Controls.Add(BtnGen);
            Controls.Add(label8);
            Controls.Add(txtIV);
            Controls.Add(labelIV);
            Controls.Add(txtplainText);
            Controls.Add(label7);
            Controls.Add(btnDeocde);
            Controls.Add(label4);
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
            Margin = new Padding(6);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeocde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtplainText;
        private TextBox txtIV;
        private Label labelIV;
        private Label label8;
        private Button BtnGen;
        private ComboBox comBoxMode;
        private ComboBox comBoxEncoding;
    }
}