using System;
using System.Collections.Generic;
using System.Text;

using Hitung_Gaji_Karyawan.ClassInduk;
namespace Hitung_Gaji_Karyawan.ClassAnak
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
		
			public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}
