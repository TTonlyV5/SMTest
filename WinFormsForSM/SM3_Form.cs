using System;
using System.Windows.Forms;

namespace WinFormsForSM
{
    public partial class SM3_Form : Form
    {
        public SM3_Form()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                var input = txtEncodeInput.Text;
                var key = txtKey.Text.Trim();
                var output = key.Length > 0
                    ? SM3Encryption.ComputeHMACSM3Hex(input, key).ToUpper()
                    : SM3Encryption.ComputeSM3HashHex(input).ToUpper();
                txtEncodeOutput.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}