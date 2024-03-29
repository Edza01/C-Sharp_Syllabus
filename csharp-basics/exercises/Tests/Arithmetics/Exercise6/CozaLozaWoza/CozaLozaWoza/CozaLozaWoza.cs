﻿using System;

namespace CozaLozaWoza
{
    public class CozaLozaWoza : ICozaLozaWoza
    {
        public int DoTillConditionIsMet(int number)
        {
            while (number <= 110)
                ConvertToCozaLozaWozaElement(number);

            return number;
        }

        public string ConvertToCozaLozaWozaElement(int number)
        {
            if (number % 3 == 0 && number % 5 == 0) return "CozaLoza ";
            else if (number % 5 == 0 && number % 7 == 0) return "LozaCoza ";
            else if(number % 3 == 0) return "Coza ";
            else if(number % 5 == 0) return "Loza ";
            else if(number % 7 == 0) return "Woza ";
            else if(number % 11 == 0) return Environment.NewLine + number;
        
            return number + " ";
        }
    }
}
