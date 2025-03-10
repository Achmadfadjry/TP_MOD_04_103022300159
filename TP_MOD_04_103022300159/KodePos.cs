using System;
using System.Collections.Generic;

namespace TP_MOD_04_103022300159
{
    class KodePos
    {
        private Dictionary<string, int> kodePosTable = new Dictionary<string, int>
        {
            { "Batununggal", 40266 },
            { "Kujangsari", 40287 },
            { "Mengger", 40267 },
            { "Wates", 40256 },
            { "Cijaura", 40287 },
            { "Jatisari", 40286 },
            { "Margasari", 40286 },
            { "Sekejati", 40286 },
            { "Kebonwaru", 40272 },
            { "Maleer", 40274 },
            { "Samoja", 40273 }
        };

        public int GetKodePos(string inputKelurahan)
        {
            if (string.IsNullOrEmpty(inputKelurahan)) return -1;

            inputKelurahan = inputKelurahan.ToLower();

            foreach (var kelurahan in kodePosTable.Keys)
            {
                if (kelurahan.ToLower() == inputKelurahan)
                {
                    return kodePosTable[kelurahan];
                }
            }

            return -1;
        }
    }
}
