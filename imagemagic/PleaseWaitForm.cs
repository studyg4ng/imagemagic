/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagemagic {
    public partial class PleaseWaitForm : Form {
        public PleaseWaitForm() {
            InitializeComponent();
            this.timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e) {

        }

        private void PleaseWaitForm_Load(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
        }
    }
}
