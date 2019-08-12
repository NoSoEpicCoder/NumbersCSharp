using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void BtnIntegers_Click(object sender, EventArgs e) {
            int myInteger = 25;
            MessageBox.Show(myInteger.ToString());
        }

        private void BtnFloat_Click(object sender, EventArgs e) {
            float myFloat = 0.42F;
            MessageBox.Show(myFloat.ToString());
        }

        private void BtnDouble_Click(object sender, EventArgs e) {
            double myDouble = 0.7777777777777777777777777777777777777777777777;
            MessageBox.Show(myDouble.ToString());
        }
    }
}
