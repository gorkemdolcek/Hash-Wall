using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using HashWall;
using System.Reflection;

namespace HashWall
{
    public class FileRecord2
    {
        [Name("keyType")]
        public string keyType { get; set; }

        [Name("keyName")]
        public string keyName { get; set; }

        [Name("keySavedLocation")]
        public string keySavedLocation { get; set; }

        [Name("keyCreationDate")]
        public string keyCreationDate { get; set; }
    }

    public class rsaKeyStorageManager
    {

        private string loc = "db/rsadb.csv";

        public void checkdbFile()
        {
            if (!System.IO.File.Exists("db/rsadb.csv"))
            {
                System.IO.Directory.CreateDirectory("./db/");
                using (StreamWriter w = File.AppendText(".\\db\\rsadb.csv"))
                {
                    w.WriteLine("keyType,keyName,keySavedLocation,keyCreationDate" + "\n");
                    checkdbFile();
                }
            }
        }

        public void WriteToCsv(string keyType, string keyName, string keySavedLocation, DateTime DateTime)
        {
            using (StreamWriter sw = new StreamWriter(loc, append: true))
            {
                sw.WriteLine(keyType + "," + keyName + "," + keySavedLocation + "," + DateTime.Now.ToString());
            }
        }
        public List<FileRecord2> ReadFromCsv()
        {
            using (var reader = new StreamReader(loc))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<FileRecord2>().ToList();
            }
        }
        public void DeleteRowByKeyname(string keyName)
        {
            var records = ReadFromCsv();
            var rowToDelete = records.FirstOrDefault(record => record.keyName == keyName);

            if (rowToDelete != null)
            {
                records.Remove(rowToDelete);
                using (StreamWriter sw = new StreamWriter(loc, false))
                using (var csvWriter = new CsvWriter(sw, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(records);
                }
            }

        }
    }
}
