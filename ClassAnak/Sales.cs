using System;
using System.Collections.Generic;
using System.Text;

using Hitung_Gaji_Karyawan.ClassInduk;
namespace Hitung_Gaji_Karyawan.ClassAnak

{
    class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
		
			public double Komisi { get; set; }
        
				public override double Gaji()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}
