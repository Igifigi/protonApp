using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace protonApp.Data
{
    public class StaticSettingsData
    {
        internal static readonly List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("Typ wydarzeń", "Dyscypliny indywidualne;Trening;Organizacja;Sędziowanie;Dyscypliny zespołowe;Dyscypliny indywidualne drużynowe"),
            new KeyValuePair<string, string>("Dyscypliny indywidualne", "Pływanie;Szachy;Narty;Łyżwy;Indywidualne biegi przełajowe;Inne"),
            new KeyValuePair<string, string>("Dyscypliny zespołowe", "Piłka nożna;Piłka ręczna;Siatkówka;Koszykówka;Badminton;Ringo;Ping pong;Streetball;Brydż;Inne"),
            new KeyValuePair<string, string>("Trening", "Trening"),
            new KeyValuePair<string, string>("Organizacja", "Organizacja wydarzenia"),
            new KeyValuePair<string, string>("Sędziowanie", "Sędziowanie"),
            new KeyValuePair<string, string>("Dyscypliny indywidualne drużynowe", "Sztafetowe biegi przełajowe;Streetball;Narty;Pływanie;Ping pong;Szachy;Lekkoatletyka;Łyżwy"),
            new KeyValuePair<string, string>("waitAfterError", "2000"),
            new KeyValuePair<string, string>("championsType", "Mistrzostwa województwa;Mistrzostwa Wrocławia;Mistrzostwa dzielnicy"),
            new KeyValuePair<string, string>("version", "0.2.1")
            //datasource=127.0.0.1;port=3306;username=root;password=;database=proton;convert zero datetime=True

        };
    }
}
