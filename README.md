# nauka-slowek

Opis dzia�ania poszczeg�lnych funkcji:

```
private void check_Clicked(object sender, EventArgs e)
        {
            if (input.Text == words[currentWord])
            {
                DisplayAlert("Dobrze!", "Poprawna odpowied�", "Okej");
                przetlumaczone.Text = "Przet�umaczone" + ++score;
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
                DisplayAlert("�le!", "Z�a odpowied�", "Okej");
                pozostalezycia.Text = "Pozosta�e �ycia" + --lives;
                if (lives == 0)
                {
                    DisplayAlert("Koniec gry", "Koniec gry", "Okej");
                }
            } 
        }
        ```