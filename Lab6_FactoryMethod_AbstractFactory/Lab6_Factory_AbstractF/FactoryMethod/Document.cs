using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FactoryM_AbstractF.FactoryMethod
{
    public abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public Document()
        {
            this.AddPages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        //Factory Method
        public abstract void AddPages();

    }
}
