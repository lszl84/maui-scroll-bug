namespace BeginnersTasks;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
        this.Navigating += AppShell_Navigating;
        this.Navigated += AppShell_Navigated;
    }

    public void AppShell_Navigating(object sender, ShellNavigatingEventArgs e)
    {
        Console.WriteLine($"--- Navigating from {e.Current?.Location} to {e.Target?.Location}");
    }

    public void AppShell_Navigated(object sender, ShellNavigatedEventArgs e)
    {
        Console.WriteLine($"--- Navigated from {e.Previous?.Location} to {e.Current?.Location}");
    }
}
