# nauka-slowek

Opis dzia≥ania poszczegÛlnych funkcji:

```
private void check_Clicked(object sender, EventArgs e)
        {
            if (input.Text == words[currentWord])
            {
                DisplayAlert("Dobrze!", "Poprawna odpowiedü", "Okej");
                przetlumaczone.Text = "Przet≥umaczone" + ++score;
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
                DisplayAlert("èle!", "Z≥a odpowiedü", "Okej");
                pozostalezycia.Text = "Pozosta≥e øycia" + --lives;
                if (lives == 0)
                {
                    DisplayAlert("Koniec gry", "Koniec gry", "Okej");
                }
            } 
        }
        ```