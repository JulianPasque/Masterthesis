using System.Collections.Generic;

namespace SampleApp.Models
{
    public class PublicExampleClass
    {
        // Konstruktor
        public PublicExampleClass()
        {
            PublicChar = 'j';
        }

        // Ganzzahl
        private int PrivateInt;

        // Gleitkommazahl
        private double PrivateDouble;
        public float PublicFloat;

        // Boolean
        private bool PrivateBool;
        
        // Textzeichen
        public char PublicChar;
        
        // Zeichenfolge
        public string PublicString;
        
        // Datenfeld
        public char[] PublicCharArray;
        
        // Auflistung
        public List<int> _PublicIntList;
        
        //Hashtabelle
        public Dictionary<int, char> PublicHashTable;

    }
}
