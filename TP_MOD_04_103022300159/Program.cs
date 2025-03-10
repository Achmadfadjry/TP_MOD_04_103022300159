using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_MOD_04_103022300159;

namespace TP_MOD_04_103022300159
{
    class MainClass
    {
        static void Main()
        {
            KodePos kodePosObj = new KodePos();
            DoorMachine pintu = new DoorMachine();

            Console.Write("Masukkan nama kelurahan: ");
            string input = Console.ReadLine()?.Trim() ?? "";

            int kode = kodePosObj.GetKodePos(input);

            if (kode != -1)
            {
                Console.WriteLine($"Kode Pos dari {input} adalah {kode}");
            }
            else
            {
                Console.WriteLine("Kelurahan tidak ditemukan.");
            }

            Console.WriteLine("\n===== Simulasi Perubahan State Pintu =====");

            string command;
            do
            {
                Console.Write("\nMasukkan perintah (buka/kunci/keluar): ");
                command = Console.ReadLine()?.Trim().ToLower() ?? "";

                if (command == "buka")
                {
                    pintu.BukaPintu();
                }
                else if (command == "kunci")
                {
                    pintu.KunciPintu();
                }

            } while (command != "keluar");

            Console.WriteLine("Program selesai.");
        }
    }
}
