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
    class Invert : Filter {
        public Invert(string srcPath) : base(srcPath) { }

        public override Color filterPixel(byte r, byte g, byte b) {
            return Color.FromArgb((255 - r), (255 - g), (255 - b));
        }
    }
}
