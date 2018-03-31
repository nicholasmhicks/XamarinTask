using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuoteAppNew
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        public string[] _quotes;
        public string randomquote;
        public static Random _rnd = new Random();
        public static int r = _rnd.Next(0, 4);
        public QuotesPage()
        {
            InitializeComponent();
            BindingContext = this;
            _quotes = new string[] { "new quote1", "new quote2", "new quote3", "new quote4", "new quote5" };
            randomquote = _quotes[r];
            QuotesLabel.Text = randomquote;
        } 
    }
}