using AndroidX.Lifecycle;

using SQLiteDemo.ViewModels;

namespace SQLiteDemo.Views;

public partial class StudentDetailsPage : ContentPage
{
	public StudentDetailsPage(StudentDetailsViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }
}