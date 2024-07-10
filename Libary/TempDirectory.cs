using System.IO;

namespace Librarys
{
    public class TempDirectory
    {
        private string temp_path;
        private string tempfolderpaht;

        public TempDirectory()
        {
            temp_path = Path.GetTempPath() + "MoneyPlus";
        }

        public TempDirectory(string foldername)
        {
            temp_path = Path.GetTempPath() + "MoneyPlus";
            tempfolderpaht = Path.Combine(temp_path, foldername);
            Directory.CreateDirectory(tempfolderpaht);
        }

        public string Tempfolderpaht { get => tempfolderpaht; }

        public string createTempFolder(string foldername)
        {
            tempfolderpaht = Path.Combine(temp_path, foldername);
            Directory.CreateDirectory(tempfolderpaht);
            return tempfolderpaht;
        }

        public void deleteTempFile()
        {
            Directory.Delete(tempfolderpaht, true);
        }
        public void deletetempFolder()
        {
            Directory.Delete(tempfolderpaht, true);
        }

        
    }



}
