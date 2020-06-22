using System;
using System.Collections.Generic;
using System.Text;

namespace Hitung_Gaji_Karyawan.ClassInduk
{
    abstract class Karyawan
    {
        public string Nik { get; set; }
		
			public string Nama { get; set; }
			
				public abstract double Gaji();
    }
}
