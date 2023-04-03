using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_Kelompok_LDI_6
{
    internal class DataMahasiswa1302213103
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"D:\modul7_Kelompok-LDI_6\jurnal7_1_1302213103.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($"first name : {jsonObject.firstName}");
            Console.WriteLine($"Last Name : {jsonObject.lastName}");
            Console.WriteLine($"Gender : {jsonObject.gender}");
            Console.WriteLine($"age : {jsonObject.age}");
            Console.WriteLine($"Address :{jsonObject.address}");
           

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int iter = 1;
            foreach (var course in jsonObject.courses)
            {
                Console.WriteLine($"MK {iter} {course.code}-{course.name}");
                iter++;

            }
        }
    }
}

