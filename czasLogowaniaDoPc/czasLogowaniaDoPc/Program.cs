using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Przed uruchomieniem programu warto najpierw ustawić swoją ścieżką do folderu i nazwę pliku w linijakch nr 31 i 32. Program przetestowany na windows 7 i windows 10.
//Jeśli tego nie zrobimy to dane będą w C:\dane\czasLogowaniaDoPc.txt
//Aby program uruchamiał się wraz z logowaniem do komputera, stosujemy się do instrukcji:
//Wpisujemy w pasek wyszukiwania windows ,,Zarządzanie komputerem", i klikamy enter lub można je też odpalić z C:\Windows\system32\compmgmt
//Na drzewku z lewej strony klikamy najpierw lewym przyciskiem myszy na Harmonogram zadań, a potem prawym też na Harmonogram zadań.
//Klikamy utwórz zadanie podstawowe.
//Wypełniamy pola Nazwa i opis wg własnej woli, klikamy dalej. Nazwę warto sobie zapisać lub zapamiętać, przyda się później. 
//Na następnej stronie zaznaczamy ,,przy logowaniu komputera", klikamy dalej.
//Powinna być zaznaczona opcja uruchom program, jak nie jest to ją zaznaczamy.
//Klikamy dalej.
//Klikamy przeglądaj, szukamy folderu z tym programem, wchodzimy w podfolder \bin\Debug\ i wybieramy czasLogowaniaDoPc.exe
//Klikamy dalej, zakończ.
//Teraz można się wylogować i zalogować by przetestować program.
//Gdy już nie chcemy by program rejestrował czas uruchamiania komputera, odpalamy Zarządzanie komputerem.
//Rozwijamy Harmonogram zadań.
//Klikamy biblioteka Harmonogramu zadań.
//Teraz przyda się nazwa programu. W środkowym oknie programu klikamy prawym przyciskiem myszy na nazwę programu(teraz się ona przyda), następnie usuń i tak.
namespace czas_uruchomienia_pc
{
    class Program
    {

        static void Main(string[] args)
        {
            string folder = @"C:\dane\";//Tu wpisujemy własną ścieżkę do folderu w którym będzie zapisywany czas uruchomienia komputera. Wpisujemy między znaki " ".
            string nazwapliku = @"czasLogowaniaDoPc.txt";//Tu wpisujemy nazwę pliku w którym będzie zapisywany czas uruchomienia komputera. Wpisujemy między znaki " ".
            string path = folder + nazwapliku;
            DateTime teraz = DateTime.Now;
            try
            {
                File.AppendAllText(path, teraz.ToString() + Environment.NewLine);
            }
            catch (DirectoryNotFoundException e)
            {
                Directory.CreateDirectory(folder);
                File.AppendAllText(path, teraz.ToString() + Environment.NewLine);
            }
        }
    }
}
