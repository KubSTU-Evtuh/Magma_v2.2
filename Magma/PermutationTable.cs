﻿namespace Magma
{
    internal class PermutationTable
    {
        public int[,] table;

        public PermutationTable()
        {
            table = new int[16, 8]
            {
                { 1, 13, 4, 6, 7, 5, 14, 4 },
                { 15, 11, 11, 12, 13, 8, 11, 10 },
                { 13, 4, 10, 7, 10, 1, 4, 9 },
                { 0, 1, 0, 1, 1, 13, 12, 2 },
                { 5, 3, 7, 5, 0, 10, 6, 13 },
                { 7, 15, 2, 15, 8, 3, 13, 8 },
                { 10, 5, 1, 13, 9, 4, 15, 0 },
                { 4, 9, 13, 8, 15, 2, 10, 14 },
                { 9, 0, 3, 4, 14, 14, 2, 6 },
                { 2, 10, 6, 10, 4, 15, 3, 11 },
                { 3, 14, 8, 9, 6, 12, 8, 1 },
                { 14, 7, 5, 14, 12, 7, 1, 12 },
                { 6, 6, 9, 0, 11, 6, 0, 7 },
                { 11, 8, 12, 3, 2, 0, 7, 15 },
                { 8, 2, 15, 11, 5, 9, 5, 5 },
                { 12, 12, 14, 2, 3, 11, 9, 3 }
            };
        }

        public int Permuate(int oldNumber, int blockNumber)
        {
            return table[oldNumber, blockNumber];
        }
    }
}
