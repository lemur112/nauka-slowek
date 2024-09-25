namespace tlumaczenie
{
    public partial class MainPage : ContentPage
    {
        string[] slowa = { "Ptak", "Kot", "Pies" };
        string[] words = { "Bird", "Cat", "Dog" };
        int lives = 3;
        int score = 0;
        int currentWord = 0;

        public MainPage()
        {
            InitializeComponent();
            

        }

        private void slowo_Loaded(object sender, EventArgs e)
        {
            // Obsługa przynajmniej trzech słow i wyswietlanie ich
            slowo.Text = slowa[0];


            
        }

        private void check_Clicked(object sender, EventArgs e)
        {
            if (input.Text == words[currentWord])
            {
                DisplayAlert("Dobrze!", "Poprawna odpowiedź", "Okej");
                przetlumaczone.Text = "Przetłumaczone" + ++score;
                if(currentWord == slowa.Length - 1)
                {
                    DisplayAlert("Koniec gry", "Koniec gry", "Okej");
                    currentWord = 0;
                }
                else
                {
                    currentWord++;
                }
                slowo.Text = slowa[currentWord];
            }
            else
            {
                DisplayAlert("Źle!", "Zła odpowiedź", "Okej");
                pozostalezycia.Text = "Pozostałe życia" + --lives;
                if (lives == 0)
                {
                    DisplayAlert("Koniec gry", "Koniec gry", "Okej");
                }
            } 
        }

        private void pozostalezycia_Loaded(object sender, EventArgs e)
        {
            pozostalezycia.Text += lives;
        }

        private void przetlumaczone_Loaded(object sender, EventArgs e)
        {
            przetlumaczone.Text += score;
        }
    }

}
