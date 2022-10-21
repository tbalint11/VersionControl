using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Properties;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using UserMaintenance.MnbServiceReference;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {


        
        List<RateData> Rates;

        public Form1()

        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };


            var response = mnbService.GetExchangeRates(request);


            var result = response.GetExchangeRatesResult;

            InitializeComponent();
            LoadData();
            

        }

        private void LoadData()
        {
            
        }

        
    }
}
