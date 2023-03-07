using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Interactions;
using System.Reflection;

namespace ConsoleApp1
{
    internal class voucher
    {
            //create the reference for the browser  
            IWebDriver driver = new ChromeDriver();
            [SetUp]
            public void Initialize()
            {
            //navigate to URL  
            driver.Navigate().GoToUrl("https://wrmstorm-dev-mt-utility-ng.azurewebsites.net/default.aspx");
                //Maximize the browser window  
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
            }
            [Test]
            public void ExecuteTest()
            {
            //STEP01 Login
            //click on the Login button
            IWebElement elelogin = driver.FindElement(By.Id("AdvanceSearch_ASPxButton1"));
            elelogin.Click();
            Thread.Sleep(1000);
            Console.Write("login button is clicked \n");
            //identify the username text box  
            IWebElement eleusername = driver.FindElement(By.Name("Username"));
            //enter the username value  
            eleusername.SendKeys("sirinun@wrmsoftware.com");
            Thread.Sleep(1000);
            Console.Write("username value is entered \n");
            //identify the password text box  
            IWebElement elepassword = driver.FindElement(By.Name("Password"));
            //enter the password value  
            elepassword.SendKeys("Multitenant01@");
            Console.Write("password is entered \n");
            //click on the Login button  
            IWebElement elelogin2 = driver.FindElement(By.Id("btn_VendorLogin"));
            elelogin2.Click();
            Thread.Sleep(1000);
            Console.Write("login button is clicked \n");
            //click on the access without event selection button  
            IWebElement eleaccess = driver.FindElement(By.Id("ASPxPanel2_ContentPlaceHolder1_btnSelectNoEvent_CD"));
            eleaccess.Click();
            Thread.Sleep(1000);
            Console.Write("access without event selection button is clicked \n");

            //STEP02 Hotel Assignment
            //click on the logistics button  
            IWebElement elelogistics = driver.FindElement(By.Id("TopPanel_ASPxMenu1_DXI3_P"));
            elelogistics.Click();
            Thread.Sleep(1000);
            Console.Write("logistics button   is clicked \n");
            //click on the hotel assignment button
            IWebElement elehotel = driver.FindElement(By.XPath("//*[@id=\"TopPanel_ASPxMenu1_MTCNT3_ASPxSiteMapControlLogistic_3_C1\"]/table/tbody/tr/td/div/div[6]/div/table/tbody/tr/td[2]/a"));
            elehotel.Click();
            Thread.Sleep(1000);
            Console.Write("hotel assignment button   is clicked \n");

            //STEP03 Print Voucher
            //click on the eleoc button  
            IWebElement eleoc = driver.FindElement(By.Id("TopPanel_UpdatePanel1"));
            eleoc.Click();
            Thread.Sleep(1000);
            Console.Write("eleoc button   is clicked \n");
            //click on the New England button
            IWebElement eleng = driver.FindElement(By.Id("TopPanel_cbOCselection_DDD_L_LBI2T0"));
            eleng.Click();
            Thread.Sleep(1000);
            Console.Write("NG: New England button   is clicked \n");
            //click on the eleoc button  
            IWebElement eleevent = driver.FindElement(By.Id("TopPanel_gluEvents_B-1"));
            eleevent.Click();
            Thread.Sleep(2000);
            Console.Write("eleevent button   is clicked \n");
            //click on the New England button
            IWebElement eleeleevent1 = driver.FindElement(By.Id("TopPanel_gluEvents_DDD_gv_DXDataRow8"));
            eleeleevent1.Click();
            Thread.Sleep(7000);
            Console.Write("eleeleevent1 button   is clicked \n");
            //click on the eleoc button  
            IWebElement eleregion = driver.FindElement(By.Id("ASPxPanel2_ContentPlaceHolder1_ddeRegion_B-1"));
            eleregion.Click();
            Thread.Sleep(2000);
            Console.Write("eleregion button   is clicked \n");
            //click on the New England button //ASPxPanel2_ContentPlaceHolder1_ddeRegion_DDD_L_LBI3T0
            IWebElement eleregion1 = driver.FindElement(By.XPath("//*[@id=\"ASPxPanel2_ContentPlaceHolder1_ddeRegion_DDD_L_LBT\"]/tbody/tr[4]"));
            eleregion1.Click();
            Thread.Sleep(15000);
            Console.Write("eleregion1 button   is clicked \n");
            //click on the checkbox button 
            IWebElement elecheckbox = driver.FindElement(By.Id("ASPxPanel2_ContentPlaceHolder1_gvHotelAssignment_DXSelBtn0_D"));
            elecheckbox.Click();
            Thread.Sleep(5000);
            Console.Write("checkbox button is clicked \n");
            //click on the voucher button 
            IWebElement elevoucher = driver.FindElement(By.Id("ASPxPanel2_ContentPlaceHolder1_btnVoucher"));
            elevoucher.Click();
            Thread.Sleep(5000);
            Console.Write("voucher button is clicked \n");
            //click on the download button  ASPxPanel2_ContentPlaceHolder1_voucherDownloadPopup_DXPWMB-1
            IWebElement eledownload = driver.FindElement(By.Id("ASPxPanel2_ContentPlaceHolder1_voucherDownloadPopup_downloadVoucherBtn"));
            eledownload.Click();
            Thread.Sleep(6000);
            Console.Write("download button is clicked \n");
        }
        [TearDown]
            public void EndTest()
            {
                //close the browser  
                driver.Close();
            }
        }
    }  