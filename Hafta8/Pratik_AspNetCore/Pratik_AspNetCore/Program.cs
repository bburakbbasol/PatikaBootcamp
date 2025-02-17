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

/* Controller sayfalarýn indexleri ve actionlarýn bulunduðu sayfa model ve view ile etkileþim içerisindedir.
 * Action normal þartlar da bizim oluþturduðumuz metotlarýn aynýsý ama controller da biz bunlara action diyoruz
 * Model bizim verilerin bulunduðu kýsým
 * programda kullanýcýya gösterilen kýsým css,html ,javascript kodlarýnýn arasýna bizim model ve controller dan oluþturduðumuz verilerin koyulmuþ hali
 * @ sembolü ile gösterililir cshtml kodlarý yazmamýzý saðlar
 * Biz model de product diye bir sýnýf oluþturduk ve onun prop'larýný tanýmlatýk controller da bunun nesnesini oluþturduk ve daha sonra View de göstermek istiyoruz bunun için 
 * sayfanýn baþýna @model Product þeklinde yazýp html kodlarýn içinde þu þekilde gösterebiliriz.<h2>@model.Name</h2> product nesnemizin ismini çekmemizi saðlar
 *  Yapýlandýrmayý tamamla ve uygulamayý oluþtur
 *  Statik dosyalarýn (CSS, JS, resimler) tutulduðu klasör. app.UseStaticFiles() ile etkinleþtirilir.
 *  Web sunucusunu baþlatýr ve uygulamayý çalýþtýrýr.
 * 
 */