using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace modul7_Kelompok_LDI_6
{
    internal class datamahasiswa_1302213002
    {
        public void readJSON()
        {
            string jsonString = File.ReadAllText(@"D:\modul7_Kelompok-LDI_6\jurnal7_1_1302213002.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($"firstname   :{jsonObject.firstName} ");
            Console.WriteLine($"lastname    :{jsonObject.lastName} ");
            Console.WriteLine($"gender      :{jsonObject.gender} ");
            Console.WriteLine($"age         :{jsonObject.age} ");
            Console.WriteLine($"addres      :{jsonObject.address} ");


            Console.WriteLine("daftar nama kuliah yang diambil");
            int iter = 1;
            foreach (var course in jsonObject.courses)
            {
                Console.WriteLine($"nama{iter}{course.code}-{course.nama}");
                iter++
;
            }

            


                
        }

    }
}
