using System;
using System.Collections;

namespace Program_queue
{
    class Program
    {
         static Queue queue = new Queue();
        static void Main(string[] args)
        {
        bool exit = false;

        do
        {
            Console.WriteLine("=== Aplikasi Antrian ===");
            Console.WriteLine("1. Tambah Data");
            Console.WriteLine("2. Hapus Data");
            Console.WriteLine("3. Tampilkan Antrian");
            Console.WriteLine("4. Cek Kosong");
            Console.WriteLine("5. Keluar");
            Console.Write("Pilih menu (1-5): ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        EnqueueElement();
                        break;
                    case 2:
                        DequeueElement();
                        break;
                    case 3:
                        DisplayQueue();
                        break;
                    case 4:
                        CheckIsEmpty();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Input tidak valid. Silakan masukkan angka.");
            }

            Console.WriteLine();
        } while (!exit);
    }

    static void EnqueueElement()
    {
        if (queue.Count < 10)
        {
            Console.Write("Masukkan data baru: ");
            string data = Console.ReadLine();
            queue.Enqueue(data);
            Console.WriteLine("Data berhasil ditambahkan ke dalam antrian.");
        }
        else
        {
            Console.WriteLine("Antrian sudah penuh. Tidak dapat menambahkan data.");
        }
    }

    static void DequeueElement()
    {
        if (queue.Count > 0)
        {
            string data = (string)queue.Dequeue();
            Console.WriteLine($"Data yang dihapus dari antrian: {data}");
        }
        else
        {
            Console.WriteLine("Antrian kosong. Tidak ada data yang dapat dihapus.");
        }
    }

    static void DisplayQueue()
    {
        if (queue.Count > 0)
        {
            Console.WriteLine("Isi Antrian:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Antrian kosong. Tidak ada data untuk ditampilkan.");
        }
    }

    static void CheckIsEmpty()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Antrian kosong.");
        }
        else
        {
            Console.WriteLine($"Antrian tidak kosong. Jumlah elemen: {queue.Count}");
        }
    }
}
}         
