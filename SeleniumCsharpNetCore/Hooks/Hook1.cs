using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumCsharpNetCore.Hooks
{
    [Binding]
    public sealed class Hook1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("This is executed before every scenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("This is executed after every scenario");
        }

    }
}
