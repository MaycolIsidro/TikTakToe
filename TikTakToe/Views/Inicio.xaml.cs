using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTakToe.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TikTakToe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            BindingContext = new InicioViewModel(Navigation);
        }
    }
}