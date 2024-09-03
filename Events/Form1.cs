using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        private MainAccount _mainAccount;
        private SavingAccount _secondAccount;

        public Form1()
        {
            InitializeComponent();
            _mainAccount = new MainAccount(100);
            _secondAccount = new SavingAccount(400);
            _mainAccount.SavingAccount = _secondAccount;

            _mainAccount.Deposit(100);
            _secondAccount.Deposit(200);
            txtMainAccountBalance.Text = _mainAccount.GetBalance().ToString("C");
            txtSecondAccountBalance.Text = _secondAccount.GetBalance().ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show("Hello from method");
        }

        private void btnMainAccountDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMainAccountDepositValue.Text, out decimal value))
            {
                _mainAccount.Deposit(value);
                txtMainAccountBalance.Text = _mainAccount.GetBalance().ToString();
            }
            else
            {
                MessageBox.Show("Duzgun formatda eded daxil edilmeyib");
            }
        }

        private void btnSecondAccountDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSecondAccountDepositValue.Text, out decimal value))
            {
                _secondAccount.Deposit(value);
                txtSecondAccountBalance.Text = _secondAccount.GetBalance().ToString();
            }
            else
            {
                MessageBox.Show("Duzgun formatda eded daxil edilmeyib");
            }
        }

        private void btnMainAccountWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMainAccountWithdrawValue.Text, out decimal value))
            {
                _mainAccount.Withdraw(value);
                txtMainAccountBalance.Text = _mainAccount.GetBalance().ToString();
                txtSecondAccountBalance.Text = _secondAccount.GetBalance().ToString();
            }
        }
    }
}
