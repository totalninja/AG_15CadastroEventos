namespace AG_15CadastroEventos;

public partial class CustoTotal : ContentPage
{
	public CustoTotal()
	{
		InitializeComponent();

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Sucesso", "Evento Cadastrado", "OK");
		Navigation.PushAsync(new MainPage());
    }
}
