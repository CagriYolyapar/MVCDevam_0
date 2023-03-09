using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDevam_0.Controllers
{
    public class HomeController : Controller
    {


        //MVC'de bir Action'a Request tipi vermemişseniz o Action otomatik olarak kendisini HTTPGet request'ine göre ayarlar

        //Eger bir Action'in parametresi routeConfig'deki wildcard ile eşleşiyorsa URL'de direkt slash ile verilen deger algılanır... Lakin eger eşleşmiyorsa (Asagıdaki Index Action'i gibi) o zaman ilgili argümanı slash ile degil QueryString ile gönderebilirsiniz(?item=2&sayi=1)
       



        public ActionResult Index(int? item,int? sayi)
        {
            //Dikkat ederseniz bu Action'da RouteConfig'in argüman wildcard'ından farklı bir isim alması durumu söz konusudur...O yüzden bu Action'a gitmek istiyorsak QueryString ile veri göndermeliyiz...Eger birden fazla parametre varsa QueryString'inize & sembolü ile ekl tanımlama yapabilirsiniz...
           
            
            return View();
        }

        public ActionResult Contact(int? id)
        {
            //Siz her ne kadar bir View metoduna string argüman vererek ilgili isimdeki View'i döndürme sistemine sahip olsanız da aslında MVC metot güdümlü calıstıgı icin ve View'lariniz action'larınıza baglı olduğu icin bir baska View döndürmek istediginiz bunu ilgili yapıyı önce Action'a yönlendirerek yapmalısınız...Statik tasarımlarda bu bir sorun cıkarmazken, dinamik bir şekilde back end'den veri isteyen tasarımlarda sorumluluk sahibi olan Action'i bypass etmek size sorun cıkartır...O yüzden o sorumlu Action kimse ona Redirect edilir onun kendisinin View'i döndürmesi saglanır...
            int a = 5;
            return RedirectToAction("Index");
        }
    }
}