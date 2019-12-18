using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithme_huffman
{
    class classe_noeud
    {
        
		public byte ASCIICode;
		
		public long Count;
		
		public classe_noeud parent;
		
		public classe_noeud LNode;
		
		public classe_noeud RNode;
		
		public string	CodeWord = "";

        public classe_noeud() 
        {

            this.ASCIICode = 0;
            this.Count = -1;
            this.parent = null;
            this.LNode = null;
            this.RNode = null;
        }
        public classe_noeud(int valeur,long occurence)
        {
			this.ASCIICode = (byte)valeur;
			this.Count = occurence;
			this.parent = null;
			this.LNode = null;
			this.RNode = null;
		}
    public classe_noeud(ref classe_noeud left,ref classe_noeud right)
		{
			this.parent = null;
			this.ASCIICode = 0;
			this.Count = left.Count + right.Count;
			this.LNode = left;
			this.RNode = right;
		}

    public int HasLRChildren()
    {
        int result = 0;

        if (this.LNode != null)
        {
            result = 1;
        }
        if (this.RNode != null)
        {
            if (result == 1)
            {
                result++;
            }
            result++;
        }
        return result;
    }

    }
}
