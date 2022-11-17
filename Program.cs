using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungMitTieren {
    class Program {
        static void Main ( string [ ] args ) {
            Baer b = new Baer ( );
            Tier [ ] tiere = new Tier [ 5 ];
            tiere [ 0 ] = b;
            b.BemerkbarMachen ( );

            IFressen [ ] fressende = new IFressen [ 5 ];
            fressende [ 0 ] = b;
            fressende [ 1 ] = new Baer();
            Vogel v = new Vogel ( );
            fressende [ 2 ] = v;
            tiere [ 1 ] = v;

            Console.Read ( );
        }
    }

    abstract class Tier {
        public void BemerkbarMachen ( ) {
            Console.WriteLine ( "hallo");
        }
    }
    class Baer : Tier, IFressen, IFliegen {
        public int MyProperty { get; set; }

        public void Fliegen ( ) {
            
        }

        public void Fressen ( ) {
            MyProperty = 100;

        }
    }

    class Vogel : Tier, IFliegen, IFressen  {
        public int MyProperty { get; set; }

        public void Fliegen ( ) {
            
        }

        public void Fressen ( ) {
            
        }
    }

    interface IFressen {
        int MyProperty { get; set; }

        void Fressen ( );
    }

    interface IFliegen {
        void Fliegen ( );
    }

}
