namespace flexview_demo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnAddTag(object sender, EventArgs e)
	{
		((MainPageViewModel)BindingContext).AddTag();
	}

	private void OnDeleteTag(object sender, EventArgs e)
	{
		((MainPageViewModel)BindingContext).DeleteTag(
			(string)((TappedEventArgs)e).Parameter);
	}
}

