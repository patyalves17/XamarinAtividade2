using System;
using Main.ViewModel;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Main.View
{
    public partial class AlunoView : ContentPage
    {
        AlunoViewModel vmAluno;
        public AlunoView()
        {
            var aluno = AlunoViewModel.GetAluno();
            vmAluno = new AlunoViewModel(aluno);
            BindingContext = vmAluno;
            InitializeComponent();
        }

        private void btnNovo_Clicked(object sender, EventArgs e){
            Navigation.PushAsync(new NovoAlunoView());
        }
    }
}
