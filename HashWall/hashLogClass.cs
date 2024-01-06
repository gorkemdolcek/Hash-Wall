using CsvHelper;
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
    public class FileRecord
    {
        [Name("fileName")]
        public string FileName { get; set; }

        [Name("hashType")]
        public string HashType { get; set; }

        [Name("hash")]
        public string Hash { get; set; }

        [Name("dateTime")]
        public string DateTime { get; set; }
    }

    public class hashLogClass
    {

        private string loc = "db/hashdb.csv";

        public static void checkdbFile()
        {
            if (!System.IO.File.Exists("db/hashdb.csv"))
            {
                System.IO.Directory.CreateDirectory("./db/");
                using (StreamWriter w = File.AppendText(".\\db\\hashdb.csv"))
                {
                    w.WriteLine("fileName,hashType,hash,dateTime" + "\n");
                    checkdbFile();
                }
            }
        }

        public void WriteToCsv(string fileName, string hashType, string hash, DateTime DateTime)
        {
            using (StreamWriter sw = new StreamWriter(loc, append: true))
            {
                sw.WriteLine(fileName + "," + hashType + "," + hash + "," + DateTime.Now.ToString());
            }
        }
        public List<FileRecord> ReadFromCsv()
        {
            using (var reader = new StreamReader(loc))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<FileRecord>().ToList();
            }
        }

    }
}