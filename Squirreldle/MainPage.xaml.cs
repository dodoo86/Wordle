using Squirreldle.ViewModel;

namespace Squirreldle;

public partial class MainPage : ContentPage
{

	public MainPage(GameViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;

	}

}

