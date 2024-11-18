using AG_15CadastroEventos.NovaPasta1;

namespace AG_15CadastroEventos
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            dtpk_inicio.MinimumDate = DateTime.Now;
            dtpk_fim.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
            dtpk_fim.MinimumDate = DateTime.Now.AddDays(1);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Evento A = new Evento
            {
                NomeEvento = Descricao.Text,
                Datacomeco = dtpk_inicio.Date,
                DataFinal = dtpk_fim.Date,
                QtdParticipantes = (int)stp_participantes.Value,
                LocalEvento = local.Text
               
            };

            await Navigation.PushAsync(new CustoTotal()
            { BindingContext = A });
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("ATENÇÃO", "Entrada por pessoa sai a 50 R$ e diária sai por 30 R$", "OK");
        }
    }

}
