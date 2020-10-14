using System;

namespace WebProjektBeispiel.Models
{
    public class Article
    {
        private decimal _price;

        public string Articlename{get;set;}
        public int ArticleID{get;set;}
        public string Description{get;set;}
        public DateTime ReleaseDate{get;set;}

        public decimal Price {
            get{return this._price;}
            set{
                this._price = value;
            }
        }
        /*
        int... Ganzahl  von ca -2Mil - +2Mil 
        int?... Ganzahl von -/- und zusätzlich null
        int? = null;
        double? = null;
        */

        public Article(int id,string articlename,decimal price,string description,DateTime release)
        {
            this.ArticleID=id;
            this.Articlename=articlename;
            this.Price=price;
            this.Description=description;
            this.ReleaseDate=release;
        }

        public override string ToString()
        {
            return this.ArticleID + " "+ this.Articlename+" "+this.Price;
        }
    }
    
}