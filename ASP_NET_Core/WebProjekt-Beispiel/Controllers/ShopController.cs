using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebProjektBeispiel.Models;

namespace WebProjekt_Beispiel.Controllers
{
    public class ShopController : Controller
    {
        // Wird Index aufgerufen sollen alle Article aufgerufen werden
        public IActionResult Index()
        {
            //List articlesformdb = CreateArticle();
            return View(CreateArticle());
        }
        public IActionResult ReturnArticles()
        {
            return View();
        }
        private List<Article> CreateArticle()
        {
            //Normalerweise werden die Artikel aus einer DB oder JSON geladen
            return new List<Article>()
            {
                new Article(1,"Iphone 11",990.90m,"Tolles teures Handy",DateTime.Now),
                new Article(2,"Thinkpad T14",1680.00m,"Tolles Nootebook",DateTime.Now),
                new Article(3,"Regenschirm(blau)",10.99m,"Suppa sachn bei dem wetter",DateTime.Now),
                new Article(4,"Pizzalieferdrohne",19650.00m,"Leise und mit E-Motor gegen das Fenster. Pizza is da",DateTime.Now),
                new Article(5,"Wanduhr",2.90m,"für de Schual",DateTime.Now)
            };
        }
    }
}
