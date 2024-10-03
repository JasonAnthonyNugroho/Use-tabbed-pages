namespace Astronomy.Pages;

public partial class AstronomicalBodyPage : ContentPage
{

    public AstronomicalBodiesPage()
    {
        InitializeComponent();

        btnComet.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails");
        btnEarth.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails");
        btnMoon.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails");
        btnSun.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails");
    }

    void UpdateAstroBodyUI(string astroName)
    {
        AstronomicalBody body = FindAstroData(astroName);

        Title = body.Name;

        lblIcon.Text = body.EmojiIcon;
        lblName.Text = body.Name;
        lblMass.Text = body.Mass;
        lblCircumference.Text = body.Circumference;
        lblAge.Text = body.Age;
    }

    AstronomicalBody FindAstroData(string astronomicalBodyName)
    {
        return astronomicalBodyName switch
        {
            "comet" => SolarSystemData.HalleysComet,
            "earth" => SolarSystemData.Earth,
            "moon" => SolarSystemData.Moon,
            "sun" => SolarSystemData.Sun,
            _ => throw new ArgumentException()
        };
    }
}