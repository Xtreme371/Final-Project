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
        FileStream stream;
        StreamReader reader;
        StreamWriter writer;

        // READ USERS FROM FILE
        public List<string> ReadData(string filename)
        {
            List<string> rawData = new List<string>();
            try
            {
                stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(stream);
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    rawData.Add(line);
                }
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show(fnfe.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                MessageBox.Show(dnfe.Message);
            }
            finally
            {
                stream.Flush();
                reader.Close();//Important
                stream.Close();//Important
            }
            return rawData;
        }


        // REGISTER NEW USER
        public void WriteData(string fileName, string dataToWrite)
        {
            try
            {
                stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(stream);
                writer.WriteLine(dataToWrite);
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show(fnfe.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                MessageBox.Show(dnfe.Message);
            }
            finally
            {
                writer.Close();//Important
                stream.Close();//Important
            }
        }


    }
}

    

