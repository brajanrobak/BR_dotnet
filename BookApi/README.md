## Jak uruchomić projekt:
1. Sklonuj repozytorium na swój dysk.
2. Otwórz terminal (lub wiersz poleceń) i przejdź do folderu z projektem.
3. Wpisz polecenie: `dotnet run` i wciśnij Enter.
4. Aplikacja automatycznie utworzy bazę danych `books.db` przy pierwszym uruchomieniu.
5. API nasłuchuje pod adresem widocznym w konsoli.
## Testowanie (Postman)
W folderze projektu znajduje się plik `.json` z wyeksportowaną kolekcją testów.
1. Otwórz program Postman.
2. Wybierz opcję "Import".
3. Wskaż plik `.json` z tego repozytorium.
4. Przetestuj endpointy (GET, POST, PUT, DELETE) na adresie podanym w konsoli przy uruchomieniu.