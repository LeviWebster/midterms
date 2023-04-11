using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace midterms
{
    //parent costomer class
    public class costomer
    {
        public string UserName;
        public string Password;
        public decimal checkingamount;
        public decimal savingsamount;
        public decimal cost;
        public decimal finalamount;

        public costomer() { }

        //costomer functions
        public virtual string purchasechecking(int balance, int cost)
        {
            finalamount = checkingamount - cost;
            return finalamount.ToString();
        }

        public virtual string purchasesavings(int balance, int cost)
        {
            finalamount = savingsamount - cost;
            return finalamount.ToString();
        }

    }

    //atm usser subclass
    public class atmcostomer : costomer
    { 
        //subclass variables
    public string UserName;
    public string Password;
    public decimal checkingamount;
    public decimal savingsamount;
    public decimal cost;
    public decimal finalamount;

    public atmcostomer() { }

        //subclass functions
    public override string purchasechecking(int balance, int cost)
    {
        finalamount = checkingamount - cost;
        return finalamount.ToString();
    }

    public override string purchasesavings(int balance, int cost)
    {
        finalamount = savingsamount - cost;
        return finalamount.ToString();
    }
        public override string ToString()
        {
            return UserName + " " + Password + " " + Convert.ToString(checkingamount) + " " + Convert.ToString(savingsamount) + " " + Convert.ToString(checkingamount);
        }

    }







    /* public class account
     {
         public decimal cost;
         public decimal deposit;
         public decimal balance;
         public decimal purchasemod;
         public decimal depostitmod;

         public account() { }

         public virtual string  purchase(int balance, int cost)
         {
             purchasemod = balance - cost;
             return purchasemod.ToString();
         }

         public virtual string depositfunction()
         {
             depostitmod = balance + deposit;
             return depostitmod.ToString();
         }

     }

     public class SavingCostomer: account
     {
         public decimal cost;

         public decimal balance;

         public decimal SavingBudgetMod;
         public override string purchase(int balance, int cost)
         {
             purchasemod = balance - cost;
             return purchasemod.ToString();
         }

         public override string depositfunction()
         {
             depostitmod = balance + deposit;
             return depostitmod.ToString();
         }


     }


     public class CheckingCostomer: account
     {
         public decimal cost;

         public decimal balance;

         public decimal CheckingBudgetMod;

         public override string purchase(int balance, int cost)
         {
             CheckingBudgetMod = balance - cost;
             return CheckingBudgetMod.ToString();
         }
     }*/



}





