using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teoria_Computacional {
    public partial class frmInicio : Form {
        public frmInicio () {
            InitializeComponent();
        }

        private void btnAFD_Click (object sender, EventArgs e) {
            this.Hide();
            new AFD(this).Show();
        }

        private void btnAFN_Click (object sender, EventArgs e) {
            this.Hide();
            new AFN(this).Show();
        }
    }
}
