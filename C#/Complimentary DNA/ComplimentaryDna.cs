// Successful solution

using System.Collections.Generic;

public class DnaStrand 
    {
        
        public static string MakeComplement(string dna)
        {
            Dictionary<char, char> complements = new Dictionary<char, char>()
            {
                {'A', 'T'},
                {'C', 'G'},
                {'G', 'C'},
                {'T', 'A'}
            };

            char[] symbols = dna.ToCharArray();
            char[] resultArr = new char[symbols.Length];

            for (int i = 0; i < symbols.Length; i++)
            {
                resultArr[i] = complements[symbols[i]];
            }

            return new string(resultArr);
        }
    }