namespace bperezS3B.Views;

public partial class Home : ContentPage
{
    public Home()
    {
        InitializeComponent();
    }

    public Home(string User)
	{
		InitializeComponent();
        lblSaludo.Text = "Bienvenid@: " + User;
    }
}