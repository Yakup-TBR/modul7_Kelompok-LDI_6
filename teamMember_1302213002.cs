using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_Kelompok_LDI_6
{
    internal class teamMember_1302213002
    {
        public void readJSON()
        {

            string jsonString = File.ReadAllText(@"D:\modul7_Kelompok-LDI_6\jurnal7_2_1302213002.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

           
            Console.WriteLine("daftar nama kuliah yang diambil");
            int iter = 1;
            foreach (var member in jsonObject.members)
            {
                Console.WriteLine($"{iter}{member.firstName}-{member.lastName}-{member.gender}-{member.age}-{member.nim}");
                iter++;

            }

        }
    }
        
}
