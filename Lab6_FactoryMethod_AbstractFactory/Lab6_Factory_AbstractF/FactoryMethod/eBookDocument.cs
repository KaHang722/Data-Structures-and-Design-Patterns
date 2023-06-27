using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FactoryM_AbstractF.FactoryMethod
{
    public class eBookDocument : Document
    {
        //Factory
        public override void AddPages()
        {
            Pages.Add(new TitlePage());
            Pages.Add(new DescriptionPage());
            Pages.Add(new CreditsPage());
        }
    }
}
