using StockMarketSimulator.InitializationHelpers;

namespace StockMarketSimulator
{
    public partial class MainForm : Form
    {
        List<Company> companies = new List<Company>();

        public MainForm()
        {
            InitializeComponent();

            foreach (Company company in CompanyInitializationHelper.InitCompaniesOnApplicationStart())
            {
                companies.Add(company);
                
            }
        }

        private void SetupCompanies()
        {

        }
    }
}