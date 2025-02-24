﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{

    // Paala, James P.                    BSIT - 501                         EVENT DRIVEN PTASK
    internal class CashierClass
    {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;
        public CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }
        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }

        public string GetCurrentNumber()
        {
            if(CashierQueue.Count == 0)
            {
                return "-";
            }

            return CashierQueue.First().ToString();
        }
    }
}
