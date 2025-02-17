using PratikAbstraction;
//Abstract
Personel yonetici = new ProjeYoneticisi("Burak","Başol");
Personel gelistirici = new YazılımGelistirici("Hasan", "Gabze");
Personel satıs = new SatısTemsilcisi("Hasan", "Şaş");
yonetici.Gorev();
gelistirici.Gorev();
satıs.Gorev();
//Interface
IEmployee SoftwareDevoloper = new SoftwareDevoloper("Burak", "Yılmaz");
IEmployee SalesRepresentative = new SalesRepresentative("Okan", "Buruk");
IEmployee ProjectManager = new ProjectManager("İbrahim", "Yattara");
SoftwareDevoloper.Title();
SalesRepresentative.Title();
ProjectManager.Title();