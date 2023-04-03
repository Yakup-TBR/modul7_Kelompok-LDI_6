using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_Kelompok_LDI_6
{
    internal class GlossaryItem1302210027
    {
        public void readJSON()
        {
            string jsonString = File.ReadAllText(@"D:\modul7_Kelompok-LDI_6\jurnal7_3_1302210027.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($" Glossary {jsonObject.glossasry} {jsonObject.glossary.title}");
            Console.WriteLine($" Glossary {jsonObject.GlossDiv} {jsonObject.GlossDiv.title}");
        }
    }
}
