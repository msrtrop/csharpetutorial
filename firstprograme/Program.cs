using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_type.float_point_type
{
    class Program
    {
        static void Main(string[] args)
        {
            float flmin = float.MinValue;
            float flmax = float.MaxValue;

            Console.WriteLine("float min{0} float max{1}", flmin, flmax);


            float flvar = 1f / 3;
            double dbvar = 1d / 3;
            decimal dlvar = 1m / 3;

            Console.WriteLine("\nfloat var{0} \ndouble var {1} \ndecimale var {2}", flvar, dbvar, dlvar);

            Console.ReadKey();
        }
    }
}
