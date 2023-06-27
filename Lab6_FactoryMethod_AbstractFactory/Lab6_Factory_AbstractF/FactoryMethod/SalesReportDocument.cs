using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FactoryM_AbstractF.FactoryMethod
{
    public class SalesReportDocument : Document
    {
        //Factory Method
        public override void AddPages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
        }
    }
}
