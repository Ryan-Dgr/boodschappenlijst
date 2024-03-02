using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace domain_boodschappen.Business
{
    internal class boodschappenlijst
    {
        //private klassevariabele

        private List<boodschap> _boodschap;

        public List<boodschap> Boodschap { get { return _boodschap; } set { _boodschap = value; } }

        // boodschap toevoegen aan het boodschappenlijstje
        public void addBoodschap(boodschap boodschap)
        {
            _boodschap.Add(boodschap);
        }
        // constructor
        public boodschappenlijst()
        {
            _boodschap = new List<boodschap>();
        }

    }
}
