using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class Validador
    {
        public int validados = 0;
        public int invalidos = 0;
        public bool entero(String a)
        {
            bool validar = false;
            int n = Int32.Parse(a);
            if (n >= 0 && n <= 110)
            {
                validar = true;
                validados += 1;

            }
            else if (validar == false)
            {
                invalidos += 1;
            }
            return validar;
        }
        public bool edad(String a)
        {
            bool validar = false;
            int n = Int32.Parse(a);
            if (n >= 0 && n <= 110)
            {
                validar = true;
                validados += 1;

            }
            else if (validar == false)
            {
                invalidos += 1;
            }
            return validar;
        }
        public bool Decimal(String a)
        {
            bool validar = false;
            try
            {
                double n = double.Parse(a);
                validar = true;
                validados += 1;
            }
            catch
            {
                invalidos += 1;
            }


            return validar;
        }


    }
}
