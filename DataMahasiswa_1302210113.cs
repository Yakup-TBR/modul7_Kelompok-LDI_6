using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace modul7_Kelompok_LDI_6
{
    internal class DataMahasiswa_1302210113
    {
        public void readJson()
        {
            string jsonString = File.ReadAllText(@"D:\modul7_Kelompok LDI_6\jurnal7_1_1302210113.json");

            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonString);

            Console.WriteLine($"Nama     {jsonObject.firstName} {jsonObject.lastName}");
            Console.WriteLine($"Gender  : {jsonObject.gender} dengan umur {jsonObject.age}");
            Console.WriteLine($"Umur    : {jsonObject.age}");
            Console.WriteLine($"Address : {jsonObject.address}");

            Console.WriteLine($"Daftar Mata Kuliah yang diambil : ");
            int iter = 1;
            foreach (var courses in jsonObject.courses)
            {
                Console.WriteLine($"MK {iter} {courses.code}-{courses.name}");
                iter++;
            }

        }
    }
}
