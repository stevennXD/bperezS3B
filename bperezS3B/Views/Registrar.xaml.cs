namespace bperezS3B.Views;

public partial class Registrar : ContentPage
{
	public Registrar()
    {
        InitializeComponent();
    }

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuarioR.Text;
        string password = txtPasswordR.Text;

        Navigation.PushAsync(new Views.Login(usuario, password));

    }
}