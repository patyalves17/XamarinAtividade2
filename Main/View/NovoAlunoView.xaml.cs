using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Main.View
{
    public partial class NovoAlunoView : ContentPage
    {
        public NovoAlunoView()
        {
            InitializeComponent();
        }

        private void btnSalvar_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new NovoAlunoView());
        }
    }
}
