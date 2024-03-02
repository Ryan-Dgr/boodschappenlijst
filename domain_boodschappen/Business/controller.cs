using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain_boodschappen.Persistence;

namespace domain_boodschappen.Business
{
    public class controller
    {
        private Persistence.Persistence _persistencecode;

        private static repository _repository;

        private boodschappenlijst _boodschappenlijst;

        public void addBoodschap(string product, int aantal, string extra)
        {
            boodschap boodschap = new boodschap(product, aantal, extra);
            _boodschappenlijst.addBoodschap(boodschap);
            _persistencecode.addBoodschap(boodschap);

        }
        public void deleteBoodschap(int id)
        {
            boodschap boodschap = new boodschap(id);
            _boodschappenlijst.deleteBoodschap(boodschap);
            _persistencecode.deleteBoodschap(boodschap);
        }

        public List<string> getBoodschappen()
        {
            List<string> boodschappen = new List<string>();
            foreach (boodschap item in _boodschappenlijst.Boodschap)
            {
                boodschappen.Add(item.ToString());
            }
            return boodschappen;
        }
        
        public controller()
        {
            _repository = new repository();
            _persistencecode = new Persistence.Persistence();
            _boodschappenlijst = new boodschappenlijst();
            _boodschappenlijst.Boodschap = _persistencecode.getBooschappen();
        }

    }
}
