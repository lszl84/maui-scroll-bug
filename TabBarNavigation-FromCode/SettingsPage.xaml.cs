
namespace BeginnersTasks;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
    }

    // SetCurentItem_Clicked method
    private void SetCurrentItem_Clicked(object sender, EventArgs e)
    {
        ((AppShell)Shell.Current).GoToMainBySettingCurrentItem();
    }

    // GoToAsync_Clicked method
    private void GoToAsync_Clicked(object sender, EventArgs e)
    {
        ((AppShell)Shell.Current).GoToMainByNavigating();
    }
}