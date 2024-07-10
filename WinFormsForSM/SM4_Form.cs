using Org.BouncyCastle.Utilities.Encoders;
using SMLib.Helpers;
using System.Text;

namespace WinFormsForSM
{
    public partial class SM4_Form : Form
    {
        public SM4_Form()
        {
            InitializeComponent();

            comBoxEncoding.Items.Add("Base64");//添加item
            comBoxEncoding.Items.Add("Hex");//添加item
            comBoxEncoding.SelectedIndex = 0;//设置显示的item索引

            comBoxMode.Items.Add("ECB");//添加item
            comBoxMode.Items.Add("CBC");//添加item
            comBoxMode.SelectedIndex = 0;//设置显示的item索引
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                var input = txtEncodeInput.Text;
                var key = txtKey.Text.Trim();


                string iv = txtIV.Text.Trim();
                var output = string.Empty;
                if (comBoxEncoding.SelectedIndex == 0)
                {
                    output = comBoxMode.SelectedIndex == 0
                               ? SM4Encryption.EncryptBase64(input, key, iv, "ECB")
                               : SM4Encryption.EncryptBase64(input, key, iv, "CBC");
                }
                else
                {
                    output = comBoxMode.SelectedIndex == 0
                               ? SM4Encryption.EncryptHex(input, key, iv, "ECB")
                               : SM4Encryption.EncryptHex(input, key, iv, "CBC");
                }

                txtEncodeOutput.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeocde_Click(object sender, EventArgs e)
        {
            try
            {
                var input = txtEncodeOutput.Text;

                var key = txtKey.Text.Trim();

                string iv = txtIV.Text.Trim();
                var output = string.Empty;
                if (comBoxEncoding.SelectedIndex==0)
                {
                    output = comBoxMode.SelectedIndex == 0
                                ? SM4Encryption.DecryptBase64(input, key, iv, "ECB")
                                : SM4Encryption.DecryptBase64(input, key, iv, "CBC");
                }
                else
                {

                    output = comBoxMode.SelectedIndex == 0
                                ? SM4Encryption.DecryptHex(input, key, iv, "ECB")
                                : SM4Encryption.DecryptHex(input, key, iv, "CBC");
                }

                txtplainText.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void BtnGen_Click(object sender, EventArgs e)
        {
            //创建key
            var keyString = StringHelper.GenerateRandom(16);
            byte[] keyBytes = Encoding.Default.GetBytes(keyString);
            string keyHexString = BitConverter.ToString(keyBytes);
            var encryptKey = keyHexString.Replace("-", "").ToLower();
            //创建iv
            var ivString = StringHelper.GenerateRandom(16);
            byte[] ivBytes = Encoding.Default.GetBytes(ivString);
            string ivHexString = BitConverter.ToString(ivBytes);
            var iv = ivHexString.Replace("-", "").ToLower();

            if (comBoxEncoding.SelectedIndex==0)
            {
                txtKey.Text = keyString;
                txtIV.Text = ivString;
            }
            else
            {
                txtKey.Text = encryptKey;
                txtIV.Text = iv;
            }

        }

        private void comBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxMode.SelectedIndex == 0)
            {
                labelIV.Visible = false;
                txtIV.Visible = false;
            }
            else
            {
              
                labelIV.Visible = true;
                txtIV.Visible = true;
            }

        }
    }
}