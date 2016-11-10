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
using ObSi;

namespace imagemagic {
    class GRB : Filter {
        public GRB(string srcPath) : base(srcPath) { }

        public override Color filterPixel(byte r, byte g, byte b) {
            byte tmp = r;
            r = g;
            g = tmp;
            return Color.FromArgb(r, g, b);
        }
    }
}
