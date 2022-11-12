
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor {
    class Person {
        private string vorname;
        private string nachname;

        // Standardkonstruktor - manipuliert
        public Person ( ) {
            vorname = "James";
            nachname = "Blond";
        }

        
        // überladener Konstruktor
        public Person (string vorname, string nachname ) {
            this.vorname = vorname;
            this.nachname = nachname;
        }

        public void ZeigMal ( ) {
            Console.WriteLine ("Vorname: {0} Nachname: {1}", vorname, nachname);
        }
    }
}
