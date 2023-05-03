using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ConsoleApp.DomainModel
{

    /////////////////////////////////////////////////////////////////////////////////
    /// ATTUALMENTE USELESS
    /// CLASSE STATICA PER UNA POSSIBILE IMPLEMENTAZIONE
    /// DI FUNZIONI CHE PERMETTONO DI DIFFERENZIARE LE OPERAZIONI
    /// SE SI VGOLIONO USARE PIU' INCOGNITE
    /// 
    public static class HelpfulMethods
    {
        /// <summary>
        /// Controlla se tutte le lettere sono uguali
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool AllLettersEqual(string str)
        {
            // Controlla se la stringa è vuota o ha solo un carattere
            if (string.IsNullOrEmpty(str) || str.Length == 1)
            {
                return true;
            }

            // Confronta il primo carattere con tutti gli altri caratteri
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != str[0])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
