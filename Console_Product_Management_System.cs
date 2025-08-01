/*
AUTHOR NICO/NIKO/WOTAH 🐺🐺🐺🐺🐺

NAMA : NICO DIGDAYA AGIS
NIM : 102022400212
KELAS : SI-48-08
KELOMPOK : 01
*/

class LIVECODE_UAS_NICO
{
    static int ID_M;
    static string NAMA_M;
    static void Main(string[] args)
    {
        bool LOOP = true;
        try
        {
        while (LOOP)
        {
        System.Console.WriteLine("\n=== PILIH MENU ===");
        System.Console.WriteLine("1. Tambah Produk");
        System.Console.WriteLine("2. Mengecek Produk");
        System.Console.WriteLine("3. Keluar");
        System.Console.Write("\nAnda memilih menu : ");
        string UIMENU;
        UIMENU = System.Console.ReadLine();
        if (int.TryParse(UIMENU, out int UIMENU_BENAR)&& UIMENU_BENAR >= 1 && UIMENU_BENAR <= 3)
        {
            switch (UIMENU_BENAR)
            {
                case 1:
                TAMBAH();
                break;

                case 2:
                CHECK();
                break;

                case 3:
                LOOP = false;
                System.Console.WriteLine("\n=== PROGRAM BERHENTI ===");
                break;

            }
        } 
        else
        {
            System.Console.WriteLine("ERROR! menu tidak valid!");
        }
        }
        }
        catch (Exception ex)
        {
            System.Console.WriteLine("Terjadi ERROR! pada " + ex.Message);
        }
    }

    static void TAMBAH()
    {
        try
        {
            System.Console.Write("\nMohon isi ID : ");
            string input_ID = System.Console.ReadLine();
            if (int.TryParse(input_ID, out ID_M))
            {
                System.Console.WriteLine("Berhasil memasukkan ID : " + ID_M);
            }
            else
            {
                System.Console.WriteLine("ERROR! harus angka");
            }

            System.Console.Write("\nMohon isi Nama Makanan : ");
            NAMA_M = System.Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(NAMA_M))
            {
                System.Console.WriteLine("Berhasil memasukkan Nama Makanan : " + NAMA_M);
            }
            else
            {
                System.Console.WriteLine("ERROR! nama tidak bole kosong");
            }

            System.Console.WriteLine($"\nJadi kita ada produk {NAMA_M} dengan ID:{ID_M}");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine("Terjadi ERROR! pada" + ex.Message);
        }
    }

    static void CHECK()
    {
        try
        {
            bool loop2 = true;
            while (loop2 == true)
            {
            System.Console.Write("\nSilahkan input ID : ");
            string input_ID2 = System.Console.ReadLine();
            int.TryParse(input_ID2, out int ID_CHECK);
            System.Console.Write("Silahkan input Nama : ");
            string input_Nama = System.Console.ReadLine();

            if (ID_CHECK == ID_M && input_Nama == NAMA_M) 
            {
                System.Console.WriteLine("\nSudah terdaftar!!");
                loop2 = false;
            }
            else if (ID_CHECK != ID_M && input_Nama == NAMA_M)
            {
                System.Console.WriteLine("\nInput ID SALAH!");
            }
            else if (ID_CHECK == ID_M && input_Nama != NAMA_M)
            {
                System.Console.WriteLine("\nInput NAMA SALAH!");
            }
            else if (ID_CHECK != ID_M && input_Nama != NAMA_M)
            {
                System.Console.WriteLine("\nKedua input ID dan NAMA SALAH!");
            }
            }

        }
        catch (Exception ex)
        {
            System.Console.WriteLine("Terjadi ERROR! pada" + ex.Message);
        }
    }
}