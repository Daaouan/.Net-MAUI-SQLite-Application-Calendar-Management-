using MAUISql.ViewModels;

namespace MAUISql;

public partial class MainPage : ContentPage
{
    private readonly EventsViewModel _viewModel;

    public MainPage(EventsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        _viewModel = viewModel;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.LoadEventsAsync();
    }
}
