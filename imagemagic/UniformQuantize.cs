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
    class UniformQuantize : Filter {
        private byte _multiplicator, _quotient;

        public UniformQuantize(string srcPath, byte quotient, byte multiplicator) : base(srcPath) {
            this._quotient = quotient;
            this._multiplicator = multiplicator;
        }

        public override Color filterPixel(byte r, byte g, byte b) {
            r /= this._quotient;
            g /= this._quotient;
            b /= this._quotient;

            r *= this._multiplicator;
            g *= this._multiplicator;
            b *= this._multiplicator;

            return Color.FromArgb(r, g, b);
        }
    }
}
