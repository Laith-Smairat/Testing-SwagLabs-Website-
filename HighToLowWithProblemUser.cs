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
    public class HighToLowWithProblemUser
    {

        [TestMethod]
        public void SortingHighToLow()
        {

            Login.LoginWithProblemUser();

            IWebElement productSort = TestSetup.driver.FindElement(By.XPath("//span/select[@data-test='product_sort_container']"));
            TestSetup.HighlightElement(TestSetup.driver, productSort);
            productSort.Click();
            System.Threading.Thread.Sleep(5000);

            IWebElement price = TestSetup.driver.FindElement(By.XPath("//div/span/select/option[@value='hilo']"));
            TestSetup.HighlightElement(TestSetup.driver, price);
            price.Click();
            System.Threading.Thread.Sleep(5000);




            ReadOnlyCollection<IWebElement> webElements = TestSetup.driver.FindElements(By.XPath("//div/div[@class='inventory_item_price']"));


            double[] prices = new double[webElements.Count];


            for (int i = 0; i < webElements.Count; i++)
            {
                prices[i] = Convert.ToDouble(webElements[i].GetAttribute("innerText").Trim('$', ' '));

            }



            for (int i = 0; i < prices.Length; i++)
            {

                if (i == prices.Length - 1)
                {
                    Console.WriteLine("Pass");

                    break;
                }
                if (prices[i] >= prices[i + 1])
                    continue;
                else
                {

                    Console.WriteLine("Fail");
                    Excel.sortingHighToLowWithProblemUser();
                    break;
                }
            }

        }
    }
}
