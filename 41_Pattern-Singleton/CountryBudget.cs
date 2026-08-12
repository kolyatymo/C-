using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Pattern_Singleton
{
    internal class CountryBudget
    {
        private double money;

        private static CountryBudget instance; // по замовчуванню null
        private CountryBudget(double startMoney) // заборонити використання клієнтом ctor
        {
            money = startMoney;
        }

        public void add(double addMoney)
        {
            money += addMoney; 
        }

        public void spend(double spendMoney)
        {
            if(money >= spendMoney)
                money -= spendMoney;
        }
        public double getMoney => money;

        public static CountryBudget getInstance(double startMoney = 1_000_000)
        {
            if(instance == null)
                instance = new CountryBudget(startMoney);

            return instance;
        }
    }
}
