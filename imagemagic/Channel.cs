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
    enum ChannelColor { RED, GREEN, BLUE };

    class Channel : Filter {
        private ChannelColor _channel;

        public Channel(string srcPath, ChannelColor channel) : base(srcPath) {
            this._channel = channel;
        }

        public override Color filterPixel(byte r, byte g, byte b) {
            switch (this._channel) {
                case ChannelColor.RED:
                    g = (byte)0;
                    b = (byte)0;
                    break;
                case ChannelColor.GREEN:
                    r = (byte)0;
                    b = (byte)0;
                    break;
                case ChannelColor.BLUE:
                    r = (byte)0;
                    g = (byte)0;
                    break;
                default:
                    break;
            }
            return Color.FromArgb(r, g, b);
        }
    }
}
