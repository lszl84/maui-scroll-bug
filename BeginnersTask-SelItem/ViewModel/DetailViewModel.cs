using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BeginnersTasks.ViewModel;

public partial class DetailViewModel : ObservableObject, IQueryAttributable
{

    [ObservableProperty]
    private ObservableCollection<string>? _strings
    =
    // initialize with data
    new ObservableCollection<string>
    {
        "string 1",
        "string 2",
        "string 3",
        "string 4",
        "string 5",
        "string 6",
        "string 7",
        "string 8",
        "string 9",
        "string 10"
    };

    [ObservableProperty]
    string text;


    [ObservableProperty]
    string selectedString;

    [RelayCommand]
    private async Task StringSelected()
    {
        Console.WriteLine($"------- DETAIL Selected: {SelectedString}. My instance is {this.GetHashCode():X}");
    }

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Console.WriteLine($"------- DETAIL ApplyQueryAttributes: {query["Text"]}");
    }
}
