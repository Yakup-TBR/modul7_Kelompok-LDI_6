using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_Kelompok_LDI_6
{
    internal class TeamMembers1302210027
    {
        public void readJSON()
        {
            string jsonString = File.ReadAllText(@"D:\modul7_Kelompok-LDI_6\jurnal7_2_1302210027.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);


            Console.WriteLine("Nama Member");
            int iter = 1;
            foreach (var member in jsonObject.members)
            {
                Console.WriteLine($" Nama {iter} {member.firstName} {member.lastName} gender {member.gender} age {member.age} nim {member.nim}");
                iter++;

            }
        }
    }
}
