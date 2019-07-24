using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    class Filehandler
    {
        FileStream file;
        StreamReader reader;
        StreamWriter writer;

        // READ USERS FROM FILE
        public List<string> ReadData(string filePath)
        {
            List<string> rawData = new List<string>();
            try
            {
                file = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(file);

                string line = string.Empty;

                while ((line = reader.ReadLine()) != null)
                {
                    rawData.Add(line);
                }
            }
            catch (DirectoryNotFoundException dnfe)
            {
                MessageBox.Show(dnfe.Message);
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show(fnfe.Message);
            }
            finally
            {
                reader.Close();
                file.Close();
            }

            return rawData;
        }

        // REGISTER NEW USER
        public void WriteData(object obj, string filePath)
        {
            try
            {
                file = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(file);

                writer.WriteLine(obj);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                MessageBox.Show(dnfe.Message);
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show(fnfe.Message);
            }
            finally
            {
                writer.Close();
                file.Close();
            }
        }
    }
}
