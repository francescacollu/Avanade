using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbergoEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            EsempiEF.testLettura1();
            EsempiEF.testInserimento();
            EsempiEF.testLettura2();
            EsempiEF.testAggiorno();
            EsempiEF.testLettura1();
            EsempiEF.testCancello();
            EsempiEF.testLettura1();


        }


    }
}