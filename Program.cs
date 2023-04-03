// See https://aka.ms/new-console-template for more information
using modul7_Kelompok_LDI_6;

DataMahasiswa_1302210113 datamhs = new DataMahasiswa_1302210113();
TeamMembers_1302210113 datamember = new TeamMembers_1302210113();
GlossaryItem_1302210113 glos = new GlossaryItem_1302210113();

datamhs.readJson();
Console.WriteLine();
datamember.readJson();
Console.WriteLine();
glos.readJson();