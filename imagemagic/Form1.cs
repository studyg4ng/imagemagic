/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagemagic {
    public partial class Form1 : Form {
        private string _filePath;
        private PleaseWaitForm _pleaseWait;
        private bool _wait = false;

        public Form1() {
            InitializeComponent();
        }

        private void pleaseWait() {
            if (_pleaseWait == null) _pleaseWait = new PleaseWaitForm();
            if (_wait) {
                _wait = false;
                _pleaseWait.Hide();
            }
            else {
                _wait = true;
                _pleaseWait.Show();
            }
        }

        private void updateFilterImage(Bitmap filteredImage) {
            pbFilter.Image = filteredImage;
            pbFilter.Update();
        }

        private void btnImageSelect_Click(object sender, EventArgs e) {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                _filePath = openFileDialog1.FileName;
                try {
                    string text = File.ReadAllText(_filePath);
                }
                catch (IOException) {
                    MessageBox.Show("Error");
                }
                txtImagePath.Text = _filePath;
                pbOriginal.ImageLocation = _filePath;
                pbOriginal.Update();
                gbFilters.Enabled = true;
            }
        }

        private void rbClamp_CheckedChanged(object sender, EventArgs e) {
            pleaseWait();
            updateFilterImage(new Clamp(_filePath, 100, 150).invertImage());
            pleaseWait();
        }

        private void rbThreshold_CheckedChanged(object sender, EventArgs e) {
            pleaseWait();
            updateFilterImage(new Threshold(_filePath, 128).invertImage());
            pleaseWait();
        }

        private void rbInvert_CheckedChanged(object sender, EventArgs e) {
            pleaseWait();
            updateFilterImage(new Invert(_filePath).invertImage());
            pleaseWait();
        }

        private void rbQuantiz_CheckedChanged(object sender, EventArgs e) {
            pleaseWait();
            updateFilterImage(new UniformQuantize(_filePath, 16, 16).invertImage());
            pleaseWait();
        }

        private void rbMultiplyAndClamp_CheckedChanged(object sender, EventArgs e) {
            pleaseWait();
            updateFilterImage(new MultiplyAndClamp(_filePath, 4, 2, 253).invertImage());
            pleaseWait();
        }

        private void rbChannel_CheckedChanged(object sender, EventArgs e) {
            pleaseWait();
            updateFilterImage(new Channel(_filePath, ChannelColor.BLUE).invertImage());
            pleaseWait();
        }

        private void rbGrayScale_CheckedChanged(object sender, EventArgs e) {
            pleaseWait();
            updateFilterImage(new GrayScale(_filePath).invertImage());
            pleaseWait();
        }

        private void rbGRB_CheckedChanged(object sender, EventArgs e) {
            pleaseWait();
            updateFilterImage(new GRB(_filePath).invertImage());
            pleaseWait();
        }

        private void lbAuthors_Click(object sender, EventArgs e) {

        }

        private void lbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("http://www.fh-salzburg.ac.at/");
        }

        private void progressBar1_Click(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            // this.progressBarImageLoad.Increment(1);
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void gbFilters_Enter(object sender, EventArgs e) {

        }

        private void pbFilter_Click(object sender, EventArgs e) {

        }

        private void progressBar1_Click_1(object sender, EventArgs e) {

        }
    }
}
