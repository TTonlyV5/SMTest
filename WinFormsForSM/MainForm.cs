using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsForSM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSM2_Click(object sender, EventArgs e)
        {
            SM2_Form form = new SM2_Form();
            form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SM3_Form form = new SM3_Form();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SM4_Form form = new SM4_Form();
            form.ShowDialog();
        }
    }
}
