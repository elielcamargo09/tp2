using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tp02XF
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        async void btnEstiloPadrão(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page_EstiloPadrao());
        }

        async void btnEstiloDinamico(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page_EstiloDinamico());
        }

        async void btnEventTriggers(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page_EstiloEventTriggers());
        }
        
        async void btnViewSimples(object sender, EventArgs e)
        {
            var contato = new Contact
            {
                Nome = "Eduardo Guilherme e Matheus Gomes",
                Idade = 24,
                Profissao = "Programador Front-end e Programador back-end",
                Pais = "Brasil"
            };
            var detalhePage = new Page_viewSimples();
            detalhePage.BindingContext = contato;
            await Navigation.PushAsync(detalhePage);
        }
    }
}
