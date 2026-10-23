using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockMarketSimulator
{
    public partial class StockMarketForm : Form
    {
        public List<string> CompanyNames = new List<string> {
            "AeroTech Systems",
            "AgriNova Foods",
            "Atlas Energy Group",
            "BlueWave Technologies",
            "Crystal Dynamics Pharma",
            "EcoVolt Power",
            "GlobalTrust Bank",
            "IronPeak Industries",
            "Nova Logistics",
            "Skyline Real Estate"
            };

        public StockMarketForm()
        {
            InitializeComponent();
        }


    }
}
