using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVectores.clases
{
  public  class NumLetras
    {
        public static string[] unidades = new string[]{"cero", "uno", "dos ", "tres","cuatro","cinco","seis","siete",
            "ocho","nueve","diez","once","doce","trece","catorce","quince","dieciseis,","diecisiete","dieciocho","diecinueve"};
        public static string[] decenas = new string[]{"", "veinte ","veinti", "treinta","cuarenta","cincuenta","sesenta","setenta",
            "ochenta","noventa"};
        public static string[] centenas = new string[]{"cien","ciento","cientos" , "dociento ", "tresciento","cuatrociento","quinientos","seiscientos","setecientos",
            "ochocientos","novecientos"};
        public static string[] complementos = new string[] {"mil","Un millon" , "millones","dos millones" , "tres millones " ,"cuatro millones","cinco millones " , "seis millones","siete millones" ,"ocho millones" , "nueve millones", "un mil"};
        public static string getLetras (double num)
        {
            
            string aux = "";

            num = Math.Truncate(num);
            if (num == 0) aux = unidades[0];
            else if (num == 1) aux = unidades[1];
            else if (num == 2) aux = unidades[2];
            else if (num == 3) aux = unidades[3];
            else if (num == 4) aux = unidades[4];
            else if (num == 5) aux = unidades[5];
            else if (num == 6) aux = unidades[6];
            else if (num == 7) aux = unidades[7];
            else if (num == 8) aux = unidades[8];
            else if (num == 9) aux = unidades[9];
            else if (num == 10) aux = unidades[10];
            else if (num == 11) aux = unidades[11];
            else if (num == 12) aux = unidades[12];
            else if (num == 13) aux = unidades[13];
            else if (num == 14) aux = unidades[14];
            else if (num == 15) aux = unidades[15];
            else if (num == 16) aux = unidades[16];
            else if (num == 17) aux = unidades[17];
            else if (num == 18) aux = unidades[18];
            else if (num == 19) aux = unidades[19];
            else if (num == 20) aux = decenas[1];
            else if (num < 30) aux = decenas[2] +"  " + getLetras(num -20);
            else if (num == 30) aux = decenas[3];
            else if (num == 40) aux = decenas[4];
            else if (num == 50) aux = decenas[5];
            else if (num == 60) aux = decenas[6];
            else if (num == 70) aux = decenas[7];
            else if (num == 80) aux = decenas[8];
            else if (num == 90) aux = decenas[9];
            else if (num < 100) aux = getLetras(Math.Truncate(num / 10) * 10) + " y " + getLetras(num % 10);
            else if (num == 100) aux = centenas[0];
            else if (num < 200) aux = centenas[1] + getLetras(num - 100);
            else if (num == 200) aux = centenas[3];
            else if (num == 300) aux = centenas[4];
            else if (num == 400) aux = centenas[5];
            else if (num == 500) aux = centenas[6];
            else if (num == 600) aux = centenas[7];
            else if (num == 700) aux = centenas[8];
            else if (num == 800) aux = centenas[9];
            else if (num == 900) aux = centenas[10];
            else if (num < 1000) aux = getLetras(Math.Truncate(num / 100) * 100) + " " + getLetras(num % 100);
            else if (num ==1000) aux= complementos[11];
            else if (num < 2000) aux = complementos[0] + "  " +  getLetras(num % 1000);
            else if (num < 1000000)
            {
                aux = getLetras(Math.Truncate(num / 1000)) +" " + complementos[0];
                if ((num % 1000) > 0) aux = aux + " " + getLetras(num % 1000);
            }
            else if (num == 1000000) aux = complementos [1];
            else if (num < 2000000) aux = complementos[1] +" " +  getLetras(num % 1000000);
            else if (num == 2000000) aux = complementos[3];
            else if (num == 3000000) aux = complementos[4];
            else if (num == 4000000) aux = complementos[5];
            else if (num == 5000000) aux = complementos[6];
            else if (num == 6000000) aux = complementos[7];
            else if (num == 7000000) aux = complementos[8];
            else if (num == 8000000) aux = complementos[9];
            else if (num == 9000000) aux = complementos[10];
            else if (num < 10000000) aux = getLetras(Math.Truncate(num / 1000000))+"  " + complementos[2] +"  "+ getLetras(num % 1000000);

            return aux;         
        }
    }
}



