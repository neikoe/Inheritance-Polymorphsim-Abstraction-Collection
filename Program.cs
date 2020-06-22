using System;
using System.Collections.Generic;

using Hitung_Gaji_Karyawan.ClassInduk;
using Hitung_Gaji_Karyawan.ClassAnak;

namespace Hitung_Gaji_Karyawan
{
    class Program
    {
        static void Main(string[] args)
        {

            KaryawanTetap kttp = new KaryawanTetap();
            kttp.Nik = "1009";
            kttp.Nama = "Andhika Br";
            kttp.GajiBulanan = 15000000;
			
			KaryawanHarian khrn = new KaryawanHarian();
            khrn.Nik = "1010";
            khrn.Nama = "Bagus Ramadhan";
            khrn.UpahPerJam = 120000;
            khrn.JumlahJamKerja = 12;

            Sales slss = new Sales();
            slss.Nik = "1011";
            slss.Nama = "Rudi Tabuti";
            slss.JumlahPenjualan = 100;
            slss.Komisi = 150000;

			
            List<Karyawan> listkaryawan = new List<Karyawan>();

			listkaryawan.Add(kttp);
            listkaryawan.Add(khrn);
            listkaryawan.Add(slss);

            int urutan = 1;

            foreach (Karyawan nei in listkaryawan)
            {
                Console.WriteLine(urutan + ". " + "Nik: " +nei.Nik+ ",\t Nama: " +nei.Nama+ ",\t Gaji: " +nei.Gaji());

                urutan++;
            }
            Console.ReadKey();
        }
    }
}
