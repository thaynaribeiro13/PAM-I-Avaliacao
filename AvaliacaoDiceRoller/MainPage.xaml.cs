using System.Xml.Serialization;

namespace AvaliacaoDiceRoller
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                RollerBtn.Text = picker.ItemsSource[selectedIndex].ToString();
            }
        }

        private void RollerBtn_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private class RandomDiceRoller : Random
        {
            Random rnd = new Random();
        }
    }

}
