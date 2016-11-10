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

namespace ObSi {
    class FileIO {
        public static string getFileContent(string filePath) {
            string content = "";
            if (File.Exists(filePath)) {
                using (StreamReader reader = new StreamReader(filePath)) {
                    content = reader.ReadToEnd();
                    return content;
                }
            }
            else throw new FileNotFoundException(String.Format("File [{0}] not Found!", filePath));
        }

        public static Image getImageFromFilePath(string filePath) {
            if (File.Exists(filePath)) {
                Image img = Image.FromFile(filePath);
                return img;
            }
            else throw new FileNotFoundException(String.Format("File [{0}] not Found!", filePath));
        }

        public static void writeOutputFile(string filePath, string content) {
            if (File.Exists(filePath)) File.Delete(filePath);
            using (StreamWriter writer = new StreamWriter(filePath)) {
                writer.Write(content);
                writer.Flush();
            }
        }
    }
}
