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
using System.ComponentModel;

namespace imagemagic {
    abstract class Filter {
        protected Bitmap _bitmap;

        public Filter(string srcPath) {
            this._bitmap = (Bitmap)FileIO.getImageFromFilePath(srcPath);
        }

        public Bitmap invertImage() {
            Bitmap bitmap = new Bitmap(this._bitmap.Width, this._bitmap.Height);
            Color pColor = new Color();

            for (int x = 0; x < this._bitmap.Width; x++) {
                for (int y = 0; y < this._bitmap.Height; y++) {
                    pColor = this._bitmap.GetPixel(x, y);
                    bitmap.SetPixel(x, y, filterPixel(pColor.R, pColor.G, pColor.B));
                }
            }
            return bitmap;
        }

        public virtual Color filterPixel(byte r, byte g, byte b) {
            throw new NotImplementedException();
        }
    }
}

