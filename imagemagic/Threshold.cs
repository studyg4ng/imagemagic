/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imagemagic {
    class Threshold : Filter {
        private byte _pivot;

        public Threshold(string srcPath, byte pivot) : base(srcPath) {
            this._pivot = pivot;
        }

        public override Color filterPixel(byte r, byte g, byte b) {
            r = r <= this._pivot ? (byte)255 : (byte)0;
            g = g <= this._pivot ? (byte)255 : (byte)0;
            b = b <= this._pivot ? (byte)255 : (byte)0;

            return Color.FromArgb(r, g, b);
        }
    }
}
