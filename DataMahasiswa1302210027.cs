using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace modul7_Kelompok_LDI_6
{
    internal class DataMahasiswa1302210027
    {
        public void readJSON()
        {
            string jsonString = File.ReadAllText(@"D:\modul7_Kelompok-LDI_6\jurnal7_1_1302210027.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($"Nama {jsonObject.firstName} {jsonObject.lastName}");
            Console.WriteLine($"Gender {jsonObject.gender}");
            Console.WriteLine($"age {jsonObject.age}");
            Console.WriteLine($"alamat {jsonObject.address.streetAddress} {jsonObject.address.city} {jsonObject.address.state} ");
            

            Console.WriteLine("Daftar mata kuliah yang diambil");
            int iter = 1;
            foreach(var course in jsonObject.courses)
            {
                Console.WriteLine($"MK {iter} {course.code}-{course.name}");
                iter++;

            }
        }
    }
}
