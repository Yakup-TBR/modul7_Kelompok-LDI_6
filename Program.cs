// See https://aka.ms/new-console-template for more information
using modul7_Kelompok_LDI_6;

DataMahasiswa1302210027 objMhs1 = new DataMahasiswa1302210027();
TeamMembers1302210027 objMbr1 = new TeamMembers1302210027();
GlossaryItem1302210027 objgls1 = new GlossaryItem1302210027();


datamahasiswa_1302213002 objmhs = new datamahasiswa_1302213002();
teamMember_1302213002 member = new teamMember_1302213002();
objmhs.readJSON();
member.readJSON();


objMhs1.readJSON();
objMbr1.readJSON();
objgls1.readJSON();  


DataMahasiswa_1302210113 datamhs = new DataMahasiswa_1302210113();
TeamMembers_1302210113 datamember = new TeamMembers_1302210113();
GlossaryItem_1302210113 glos = new GlossaryItem_1302210113();

datamhs.readJson();
Console.WriteLine();
datamember.readJson();
Console.WriteLine();


