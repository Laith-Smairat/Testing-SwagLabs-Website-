using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs2
{
    [TestClass]
    public class AToZWithProblemUser
    {

        [TestMethod]
        public void SortNameAToZ()
        {
            Login.LoginWithProblemUser();

            IWebElement productSort = TestSetup.driver.FindElement(By.XPath("//span/select[@data-test='product_sort_container']"));
            TestSetup.HighlightElement(TestSetup.driver, productSort);
            productSort.Click();
            System.Threading.Thread.Sleep(5000);

            IWebElement name = TestSetup.driver.FindElement(By.XPath("//div/span/select/option[@value='az']"));
            TestSetup.HighlightElement(TestSetup.driver, name);
            name.Click();
            System.Threading.Thread.Sleep(5000);



            List<String> item = new List<string>();

            IReadOnlyList<IWebElement> cells = TestSetup.driver.FindElements(By.XPath("//div/a/div[@class='inventory_item_name']"));

            for (int i = 0; i < cells.Count; i++)
            {
                IWebElement cell = cells[i];
                item.Add(cell.Text.Trim());

            }
            List<string> listDefault = item.Select(e => e).ToList();
            List<string> listSorted = listDefault.OrderBy(x => x).ToList(); //sort list asc to compare 
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(listDefault.SequenceEqual(listSorted));
            if (listDefault != listSorted)
            {
                Console.WriteLine("Pass");
                Excel.sortingAToZWithProblemUser();
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
    }
}
