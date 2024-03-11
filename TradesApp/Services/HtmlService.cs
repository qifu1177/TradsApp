using App.Infrastructure.Datas;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Globalization;

namespace TradesApp.Services
{
    public class HtmlService
    {
        private IWebDriver _driver;
        private CultureInfo _culture;
        public async Task<IList<TradeData>> LoadDatasFromWebPage(string url)
        {
            _culture = CultureInfo.GetCultureInfo("de-DE");
            List<TradeData> dataList = new List<TradeData>();
            
            _driver=new ChromeDriver();
            _driver.Url = url;
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var buttons = wait.Until((driver) =>
            {
                var buttons = driver.FindElements(By.ClassName("bsg-cookie-layer__btn-confirm"));
                return buttons;
            });
           
            if(buttons != null && buttons.Count>0 ) {
                buttons[0].Click();
                wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(100));
                var table=wait.Until((driver) =>
                {
                    var table = driver.FindElement(By.ClassName("bsg-table"));                    
                    return table;
                });
                var tbody = table.FindElement(By.TagName("tbody"));
                var rows = tbody.FindElements(By.TagName("tr"));
                foreach (var row in rows)
                {
                    var cells = row.FindElements(By.TagName("span"));
                    if (cells.Count >= 7)
                    {
                        var data = CreateData(cells[0].Text, cells[1].Text, cells[2].Text, cells[3].Text, cells[4].Text, cells[5].Text, cells[6].Text);
                        dataList.Add(data);
                    }
                }
            }
            _driver.Close();
            _driver.Quit();
            return dataList;
        }

        private TradeData CreateData(string dateStr,string timeStr,string priceStr,string volumenUnitStr,string volumenEuro,string volumenStr,string volumenCumEuroStr)
        {
            var data = new TradeData();
            data.TimeStamp=Convert.ToDateTime(string.Format("{0} {1}", dateStr,timeStr),_culture.DateTimeFormat);
            data.Price=Convert.ToDecimal(priceStr.Replace("G","").Replace(".", ""), _culture.NumberFormat);
            data.VolumeUnits = Convert.ToInt32(volumenUnitStr.Replace(".", ""), _culture.NumberFormat);
            data.VolumeEuro = Convert.ToDecimal(volumenEuro.Replace(".", ""), _culture.NumberFormat);
            data.VolumePieces = Convert.ToInt32(volumenStr.Replace(".", ""), _culture.NumberFormat);
            data.VolumeCumEuro = Convert.ToDecimal(volumenCumEuroStr.Replace(".", ""), _culture.NumberFormat);
            return data;
        }
    }
}
