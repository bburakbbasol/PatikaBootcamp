using System;
using System.Collections.Generic;

//String Liste tanımı
List<string> Davetliler=new List<string>();

//Listenin Elemanlarını oluşturma
Davetliler.Add("Bülent Ersoy");
Davetliler.Add("Ajda Pekkan");
Davetliler.Add("Ebru Gündeş");
Davetliler.Add("Hadise");
Davetliler.Add("Hande Yener");
Davetliler.Add("Tarkan");
Davetliler.Add("Funda Arar");
Davetliler.Add("Demet Akalın");

//Foreach ile Elemanları Yazdırma
int sira = 0;
foreach(string davetli in Davetliler)
{
	sira++;
	Console.WriteLine( sira+"-"+davetli);


}
//For ile elemanları Yazdırma
Console.WriteLine("------------------For ile Yapılış------------------------");
Console.WriteLine("");
for (int i = 0; i < Davetliler.Count; i++)
{
	Console.WriteLine((i+1)+"-" + Davetliler[i]);
}
