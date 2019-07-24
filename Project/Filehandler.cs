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
        public List<string> ReadUsers(string fileName)
        {
            List<string> data = new List<string>();     
            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(stream);

                string line = string.Empty;
                while ((line=reader.ReadLine())!=null)
                {
                    data.Add(line);
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
                reader.Close();
                stream.Close();
            }
            return data;
            // REGISTER NEW USER
            
        }
        public List<string> WriteData(string fileName,string dataToWrite)
        {
            List<string> writedata = new List<string>();

            try
            {
                stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(stream);

                foreach (var item in dataToWrite)
                {
                    writer.WriteLine(item);
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
                writer.Flush();
                writer.Close();
                stream.Close();
            }
            return writedata;
        }
    }
}
