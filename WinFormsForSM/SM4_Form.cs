using Org.BouncyCastle.Utilities.Encoders;

namespace WinFormsForSM
{
    public partial class SM4_Form : Form
    {
        public SM4_Form()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                var input = txtEncodeInput.Text;
                var key = txtKey.Text.Trim();


                string iv = txtIV.Text.Trim();
                var output = radECB.Checked
                    ? SM4Encryption.EncryptBase64(input, key, iv, "ECB")
                    : SM4Encryption.EncryptBase64(input, key, iv, "CBC");


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
                var output = radECB.Checked
                    ? SM4Encryption.DecryptBase64(input, key, iv, "ECB")
                    : SM4Encryption.DecryptBase64(input, key, iv, "CBC");
                txtplainText.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radCBC_CheckedChanged(object sender, EventArgs e)
        {
            if (radCBC.Checked)
            {
                labelIV.Visible =true;
                txtIV.Visible =true;
            }
            else
            {
                labelIV.Visible = false;
                txtIV.Visible = false;
            }
        }
    }
}