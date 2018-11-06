using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GasolinaAlcool
{
    public partial class MainPage : ContentPage
    {
        const float valorDiv = 0.70f;
        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;

            if (Device.RuntimePlatform == Device.Android)
                adMobView.AdUnitId = "ca-app-pub-7579073752816689/9694362394";
        }

        private void btnVerificar_Clicked(object sender, EventArgs e)
        {
            float precoAlcool;
            float precoGasolina;
            lblExibeResultado.Text = "";
            
            if (txtAlcool.Text == null || txtGasolina.Text == null || txtAlcool.Text == "" || txtGasolina.Text == "")
            {
                return;
            }
            try
            {
                precoAlcool = float.Parse(txtAlcool.Text);
                precoGasolina = float.Parse(txtGasolina.Text);

                if(precoAlcool / precoGasolina <= valorDiv)
                {
                    lblExibeResultado.Text = "Abasteça com Álcool!";
                }
                else
                {
                    lblExibeResultado.Text = "Abasteça com Gasolina!";
                }
                

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Info());
        }
    }
}
