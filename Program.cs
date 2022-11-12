using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor {
    class Program {
        static void Main ( string [ ] args ) {
            Person robert = new Person ( );
            robert.ZeigMal ( );

            Person p = new Person ("Sebastian", "Boo" );
            p.ZeigMal ( );

            Console.Read ( );
        }
    }
}
