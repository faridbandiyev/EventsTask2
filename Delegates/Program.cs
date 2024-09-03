using System;
using System.Diagnostics;

namespace Delegates
{
    public delegate void OverDrawnd();

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Credit(100);
            account.Debit(200);

            MarketMoneyAccount marketMoneyAccount = new MarketMoneyAccount();
            marketMoneyAccount.Balance = 100;
            marketMoneyAccount.DebitFee(300);
        }
    }

    public class BankAccount
    {
        protected EventHandler OverDrawndEvent;
        protected event Action OverDrawndTest;

        public BankAccount()
        {
            OverDrawndEvent += Overdrawn;
        }

        public decimal Balance { get; set; }

        public virtual void OnOverdrawnEvent(OverDrawnEventArgs eventArgs)
        {
            if (OverDrawndEvent != null)
                OverDrawndEvent.Invoke(this, eventArgs);

            OverDrawndTest.Invoke();
        }

        public void Credit(decimal amount)
        {
            Balance += amount;
        }

        public void Debit(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                //OnOverdrawnEvent(new OverDrawnEventArgs(amount));
                if (OverDrawndEvent != null)
                    OverDrawndEvent.Invoke(this, new OverDrawnEventArgs(amount));
            }
        }

        private void Overdrawn(Object obj, EventArgs eventArgs)
        {
            OverDrawnEventArgs overDrawnEventArgs = eventArgs as OverDrawnEventArgs;
            BankAccount bankAccount = obj as BankAccount;
            Console.WriteLine($"Balansda pul yoxdur. Balance{bankAccount.Balance} Amount:{overDrawnEventArgs.Amount}");
        }
    }

    public class MarketMoneyAccount : BankAccount
    {
        public void DebitFee(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                base.OnOverdrawnEvent(new OverDrawnEventArgs(amount));
                if (OverDrawndEvent != null)
                    OverDrawndEvent.Invoke(this, new OverDrawnEventArgs(amount));         
            }
        }

    }

    public class OverDrawnEventArgs : EventArgs 
    {
        public decimal Amount { get; set; }

        public OverDrawnEventArgs(decimal amount)
        {
            Amount = amount;
        }
    }
}
