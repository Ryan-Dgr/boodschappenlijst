using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain_boodschappen.Business
{
     class boodschap
    {
        private int _id;
        private string _product;
        private int _aantal;
        private string _extra;
        
        public int Id { get { return _id; } set { _id = value; } }
        public string Product { get { return _product; } set { _product = value; } }
        public int Aantal { get { return _aantal; } set { _aantal = value; } }
        public string Extra { get { return _extra; } set { _extra = value; } }

        public override string ToString()
        {
            return _id.ToString() +"| product: " + _product + ", aantal: " + _aantal.ToString() + ", " + _extra;
        }
        // default constructor
        public boodschap()
        { }

        // data op roepen
        public boodschap(int id, string product, int aantal, string extra)
        {
            Id = id;
            Product = product;
            Aantal = aantal;
            Extra = extra;

        }
        //data toevoegen
        public boodschap( string product, int aantal, string extra)
        {
            
            Product = product;
            Aantal = aantal;
            Extra = extra;

        }



    }
}
