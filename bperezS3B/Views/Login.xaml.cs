namespace bperezS3B.Views;

public partial class Login : ContentPage
{
    string user = "x", pass = "x";

    public Login()
    {
        InitializeComponent();
    }

    public Login(string username, string password)
    {
        InitializeComponent();
        user = username;
        pass = password;
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        if (user == txtUsuario.Text && pass == txtPassword.Text)
        {
            Navigation.PushAsync(new Views.Home(user));
        }
        else
        {
            DisplayAlert("Error", "Usuario o Contrase�a Incorrectos", "Cerrar");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.Registrar());
    }
}