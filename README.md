# nauka-slowek

Opis dzia≥ania poszczegÛlnych funkcji:

private void check_Clicked(object sender, EventArgs e)
        {
            //sprawdzamy czy podane slowo jest poprawne
            //jesli tak to wyswietlamy komunikat "dobrze" i zwiekszamy punktacje
            //jesli nie to wyswietlamy komunikat "zle" i zmniejszamy ilosc zyc
            //jesli ilosc zyc wynosi 0 to wyswietlamy komunikat o koncu gry
            //jesli ilosc zyc jest wieksza niz 0 to wyswietlamy komunikat o bledzie i zmniejszamy ilosc zyc
            //jesli ilosc punktow wynosi 5 to wyswietlamy komunikat o wygranej i konczymy gre
            //jesli ilosc punktow jest mniejsza niz 5 to wyswietlamy komunikat o poprawnej odpowiedzi i zwiekszamy ilosc punktow
            //wyswietlamy kolejne slowo w tablicy slowa
            //jesli ilosc punktow wynosi 5 to wyswietlamy komunikat o koncu gry
            //jesli ilosc zyc wynosi 0 to wyswietlamy komunikat o koncu gry
            //check if the input word is correct, if yes then display "correct" and increase score
            //if not then display "wrong" and decrease lives, if lives = 0 then display "game over"
            //if score = 5 then display "you won" and end the game
            //if score < 5 then display "correct answer" and increase score
            //display next word in the array slowa
            //if score = 5 then display "game over"
            //if lives = 0 then display "game over"
            // <summary>
            // Funkcja sprawdza czy podane s≥owo jest poprawne
            // </summary>
            // <param name="sender"></param>
            // <param name="e"></param>
            // <returns></returns>
            // <author>Anna W≥odarczyk</author>
            // <created>2021-02-14</created>
            // <seealso>checkprivate void check_Clicked(object sender, EventArgs e)
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