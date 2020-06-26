using Binance.Net.ClientWPF.MVVM;
using Binance.Net.Objects;
using Binance.Net.ClientWPF.ViewModels;
using Binance.Net.ClientWPF.UserControls;
using Binance.Net.ClientWPF.MessageBox;
using CryptoExchange.Net.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.Net.ClientWPF.ViewModels
{
    class BalansViewModel : ObservableObject
    {
        private string balans_ful;
        public string Balans_ful
        {
            get { return balans_ful; }
            set
            {
                balans_ful = value;
                RaisePropertyChangedEvent("Balans_ful");
            }
        }

        private decimal free_bal;
        public decimal Free_bal
        {
            get { return free_bal; }
            set
            {
                free_bal = value;
                RaisePropertyChangedEvent("Free_bal");
            }
        }

        private decimal locked_bal;
        public decimal Locked_bal
        {
            get { return locked_bal; }
            set
            {
                locked_bal = value;
                RaisePropertyChangedEvent("Locked_bal");
            }
        }
    }
}
