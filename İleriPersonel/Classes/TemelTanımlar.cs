using İleriPersonel.Context;
using İleriPersonel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İleriPersonel.Classes
{
 abstract  public  class TemelTanımlar:ITanım
    {
        PersonelContext db = new PersonelContext();
        public int Id { get; set; }
        public string Ad { get; set; }

       

        public List<object> Liste()
        {
            throw new NotImplementedException();
        }
    }
}
