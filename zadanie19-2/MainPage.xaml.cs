
namespace zadanie19_2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

            void OnCounterClicked(object? sender, EventArgs e)
        {
            if (Wybor.SelectedItem == null || string.IsNullOrWhiteSpace(Wybor.SelectedItem.ToString()))
            {
                DisplayAlert("Alert", "Proszę wybrać rodzaj lekarza.", "OK");
                return;
            }


            if (datePicker.Date == null || string.IsNullOrWhiteSpace(datePicker.Date.ToString()))
            {
                DisplayAlert("Alert", "Proszę wybrać datę wizyty.", "OK");
                return;
            }


            if (timePicker.Time == null || string.IsNullOrWhiteSpace(timePicker.Time.ToString()))
            {
                DisplayAlert("Alert", "Proszę wybrać godzinę wizyty.", "OK");
                return;
            }

            string Wybor1 =  Wybor.SelectedItem.ToString();
            string datePicker1 = datePicker.Date.ToString();
            string timePicker1 = timePicker.Time.ToString();

            DisplayAlert("Alert", "Wizyta u: " + Wybor1 + ", dnia: " + datePicker1 + ", o godzinie: " + timePicker1, "OK");

        }
    }
}




