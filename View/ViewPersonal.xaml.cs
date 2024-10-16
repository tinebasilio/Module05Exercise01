using Module05Exercise01.ViewModel;
using Module05Exercise01.Services;

namespace Module05Exercise01.View;

public partial class ViewPersonal : ContentPage
{
    public ViewPersonal()
    {
        InitializeComponent();

        var personalViewModel = new PersonalViewModel();
        BindingContext = personalViewModel;
    }
}