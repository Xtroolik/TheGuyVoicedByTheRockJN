namespace TheGuyVoicedByTheRockJN
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
                Random r = new Random();

                int roll = r.Next(1, 7);
                CounterBtn.Text = "Rolled the number: " + roll.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
