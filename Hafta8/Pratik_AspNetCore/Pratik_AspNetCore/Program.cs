using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
	name: "default",
	pattern : "{Controller = Home}/{ Action = Index }"
);
app.Run();

/* Controller sayfalar�n indexleri ve actionlar�n bulundu�u sayfa model ve view ile etkile�im i�erisindedir.
 * Action normal �artlar da bizim olu�turdu�umuz metotlar�n ayn�s� ama controller da biz bunlara action diyoruz
 * Model bizim verilerin bulundu�u k�s�m
 * programda kullan�c�ya g�sterilen k�s�m css,html ,javascript kodlar�n�n aras�na bizim model ve controller dan olu�turdu�umuz verilerin koyulmu� hali
 * @ sembol� ile g�sterililir cshtml kodlar� yazmam�z� sa�lar
 * Biz model de product diye bir s�n�f olu�turduk ve onun prop'lar�n� tan�mlat�k controller da bunun nesnesini olu�turduk ve daha sonra View de g�stermek istiyoruz bunun i�in 
 * sayfan�n ba��na @model Product �eklinde yaz�p html kodlar�n i�inde �u �ekilde g�sterebiliriz.<h2>@model.Name</h2> product nesnemizin ismini �ekmemizi sa�lar
 *  Yap�land�rmay� tamamla ve uygulamay� olu�tur
 *  Statik dosyalar�n (CSS, JS, resimler) tutuldu�u klas�r. app.UseStaticFiles() ile etkinle�tirilir.
 *  Web sunucusunu ba�lat�r ve uygulamay� �al��t�r�r.
 * 
 */