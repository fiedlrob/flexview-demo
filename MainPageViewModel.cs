using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using static System.String;

namespace flexview_demo;

public class MainPageViewModel : INotifyPropertyChanged
{
    public string Tag { get; set; }

    public ObservableCollection<string> Tags { get; } = new();

    public MainPageViewModel()
    {
        // Uncomment this lines to fill the collection with some dummy values
        // If you do this, scrolling works
        //for (var i = 0; i < 20; i++)
        //    _tags.Add($"Item {i}");
    }

    public void AddTag()
    {
        if (IsNullOrEmpty(Tag))
            return;

        Tags.Add(Tag);
        OnPropertyChanged(nameof(Tags));

        Tag = "";
        OnPropertyChanged(nameof(Tag));
    }

    public void DeleteTag(string value)
    {
        if (Tags.Remove(Tags.First(translation => translation == value)))
            OnPropertyChanged(nameof(Tags));
    }
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
