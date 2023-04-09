using MauiApp1.ViewModel;

namespace MauiApp1;

public partial class ProgressBarPage : ContentPage
{
    ProgressBarVM progressBar;
    public ProgressBarPage()
    {
        InitializeComponent();

        progressBar = new ProgressBarVM();
        BindingContext = progressBar;
    }



    private void OnButtonStartClicked(object sender, EventArgs e)
    {
        progressBar.StartEvaluating();
    }

    private void OnButtonCancelClicked(object sender, EventArgs e)
    {
        progressBar.StopEvaluating();
    }
}