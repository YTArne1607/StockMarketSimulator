using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketSimulator
{
    public class Company
    {
        public string Name { get; set; } = string.Empty;   // Name
        public int Revenue { get; set; }        // Einnahmen
        public int Expenses { get; set; }       // Ausgaben
        public int Profit { get; set; }         // Gewinn

        public int Employees { get; set; }      // Mitarbeiter
        public int Reputation { get; set; }     // Ruf (0 => schlecht bis 100 => gut)
    }
}
