using System;
using System.Collections.Generic;
using System.Text;

using Hitung_Gaji_Karyawan.ClassInduk;
namespace Hitung_Gaji_Karyawan.ClassAnak
{
    class KaryawanHarian : Karyawan
    {
        public double UpahPerJam { get; set; }
		
			public double JumlahJamKerja { get; set; }
			
				public override double Gaji()
        {
            return UpahPerJam * JumlahJamKerja;
        }
    }
}
