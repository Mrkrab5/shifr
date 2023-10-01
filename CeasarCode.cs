using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shifr
{
    class CeasarCode
    {
		
		public CeasarCode()
		{
		
		}

		static public string Decoding(string messange, int kod)
		{
			int shift = kod;
			string lowReg = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя",
				hightReg = lowReg.ToUpper(),
				n = "", result = "";

			for (int i = 0; i < messange.Length; i++)
			{
				if (lowReg.Contains(messange[i]))
					n = lowReg;
				else if (hightReg.Contains(messange[i]))
					n = hightReg;
				else
					result += messange[i];

				if (n.Contains(messange[i]))
                {
					for(int j = 0; j < n.Length; j++)
                    {
						if (j + shift >= 0 && j + shift < n.Length && messange[i] == n[j])
							result += n[j + shift];
						
						else if (j + shift >= n.Length && messange[i] == n[j])
							result += n[(j + shift) % n.Length];
						
						else if (j + shift < 0 && messange[i] == n[j])
							result += n[j + shift + n.Length];
                    }
                }
            }
			return result;
		}
	}
	
}
