using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_Kelompok_LDI_6
{
    internal class GlossaryItem_1302210113
    {
        public void readJson()
        {
            string jsonString = File.ReadAllText(@"D:\modul7_Kelompok LDI_6\jurnal7_3_1302210113.json");

            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonString);

            
                Console.WriteLine($"glossary : {jsonObject.glossary}");
            
            

        }
    }
}
