using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_Kelompok_LDI_6
{
    internal class TeamMembers_1302210113
    {
        public void readJson()
        {
            string jsonString = File.ReadAllText(@"D:\modul7_Kelompok LDI_6\jurnal7_2_1302210113.json");

            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonString);

            Console.WriteLine($"Team member list: ");
            int iter = 1;
            foreach (var members in jsonObject.members)
            {
                Console.WriteLine($"Member {iter} {members.nim} {members.firstName}-{members.lastName} ({members.age} {members.gender} )");
                iter++;
            }

        }
    }
}
