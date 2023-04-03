using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_Kelompok_LDI_6
{
    internal class TeamMembers1302213103
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"D:\modul7_Kelompok-LDI_6\jurnal7_2_1302213103.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("Team member list:");
            int iter = 1;
            foreach (var members in jsonObject.members)
            {
                Console.WriteLine($"MK {iter} {members.firstName}-{members.lastName}-{members.gender}-{members.age}-{members.nim}");
                iter++;
            }
        }
    }
}
