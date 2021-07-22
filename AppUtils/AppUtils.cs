using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Security.Permissions;
using SR = System.Reflection;

namespace AppUtils
{
    public class AppUtils
    {
		public class IdentificaUtils
		{
			public int Calculo_NIT_DV(Int64 Identificacion)
			{

				int Retorno;
				int nTotal;
				int nVal;
				string Cadena;

				Retorno = 0;
				nTotal = 0;
				nVal = 0;
				Cadena = string.Empty;

				Cadena = Identificacion.ToString("000000000000000");

				//Pos 1
				int.TryParse(Cadena.Substring(14 , 1) , out nVal);
				nVal = (nVal * 3);
				nTotal += nVal;

				//Pos 2
				int.TryParse(Cadena.Substring(13 , 1) , out nVal);
				nVal = (nVal * 7);
				nTotal += nVal;

				//Pos 3
				int.TryParse(Cadena.Substring(12 , 1) , out nVal);
				nVal = (nVal * 13);
				nTotal += nVal;

				//Pos 4
				int.TryParse(Cadena.Substring(11 , 1) , out nVal);
				nVal = (nVal * 17);
				nTotal += nVal;

				//Pos 5
				int.TryParse(Cadena.Substring(10 , 1) , out nVal);
				nVal = (nVal * 19);
				nTotal += nVal;

				//Pos 6
				int.TryParse(Cadena.Substring(9 , 1) , out nVal);
				nVal = (nVal * 23);
				nTotal += nVal;

				//Pos 7
				int.TryParse(Cadena.Substring(8 , 1) , out nVal);
				nVal = (nVal * 29);
				nTotal += nVal;

				//Pos 8
				int.TryParse(Cadena.Substring(7 , 1) , out nVal);
				nVal = (nVal * 37);
				nTotal += nVal;

				//Pos 9
				int.TryParse(Cadena.Substring(6 , 1) , out nVal);
				nVal = (nVal * 41);
				nTotal += nVal;

				//Pos 10
				int.TryParse(Cadena.Substring(5 , 1) , out nVal);
				nVal = (nVal * 43);
				nTotal += nVal;

				//Pos 11
				int.TryParse(Cadena.Substring(4 , 1) , out nVal);
				nVal = (nVal * 47);
				nTotal += nVal;

				//Pos 12
				int.TryParse(Cadena.Substring(3 , 1) , out nVal);
				nVal = (nVal * 53);
				nTotal += nVal;

				//Pos 13
				int.TryParse(Cadena.Substring(2 , 1) , out nVal);
				nVal = (nVal * 59);
				nTotal += nVal;

				//Pos 14
				int.TryParse(Cadena.Substring(1 , 1) , out nVal);
				nVal = (nVal * 67);
				nTotal += nVal;

				//Pos 15
				int.TryParse(Cadena.Substring(0 , 1) , out nVal);
				nVal = (nVal * 71);
				nTotal += nVal;

				//Halla el residuo para nTotal / 11
				Retorno = (nTotal % 11);

				if (Retorno > 1)
					Retorno = (11 - Retorno);
 
				return Retorno;

			}

		}
		
    }
}
