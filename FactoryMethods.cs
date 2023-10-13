using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern
{
    public interface FactoryMethods
    {
        // Credit card 
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
     class MoneyBack : FactoryMethods
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
     public class Titanium : FactoryMethods
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
     public abstract class CreditCardFactory
    {
        protected abstract FactoryMethods MakeProduct();
        public FactoryMethods CreateProduct()
        {
            return this.MakeProduct();
        }
    }

     public class MoneyBackFactory : CreditCardFactory
    {
        protected override FactoryMethods MakeProduct()
        {
            FactoryMethods product = new MoneyBack();
            return product;
        }
    }

    public class TitaniumFactory : CreditCardFactory
    {
        protected override FactoryMethods MakeProduct()
        {
            FactoryMethods product = new Titanium();
            return product;
        }
    }
}