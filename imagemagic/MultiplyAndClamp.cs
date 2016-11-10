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
    class MultiplyAndClamp : Filter {
        private byte _multiplicator;
        private byte _min, _max;

        public MultiplyAndClamp(string srcPath, byte multiplicator, byte min, byte max) : base(srcPath) {
            this._min = min;
            this._max = max;
            this._multiplicator = multiplicator;
        }

        public override Color filterPixel(byte r, byte g, byte b) {
            r *= this._multiplicator;
            g *= this._multiplicator;
            b *= this._multiplicator;

            if (r >= this._max) r = this._max;
            if (r <= this._min) r = this._min;

            if (g >= this._max) g = this._max;
            if (g <= this._min) g = this._min;

            if (b >= this._max) b = this._max;
            if (b <= this._min) b = this._min;

            return Color.FromArgb(r, g, b);
        }
    }
}
