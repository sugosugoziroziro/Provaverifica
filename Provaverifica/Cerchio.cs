using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provaverifica
{
    internal class Cerchio
    {
        public double Raggio { get; set; }
        public double Circonferenza { get { return 2 * Raggio * Math.PI; } } 
        public double CalcoloCirc()
        {
            return 2 * Raggio * Math.PI;
        }
        public Cerchio(double raggio) 
        { 
            Raggio= raggio;
        }
        public override string ToString()
        {
            return $"r={Raggio}";
        }
        public static bool TryParse(string s,out Cerchio c)
        {
            try 
            {
                if (Cerchio.Parse(s).ToString() == s) // "pollo"
                {
                    c = Cerchio.Parse(s);
                    return true;
                }
                else
                {
                    c = null;
                    return false;
                }
            }
            catch(Exception e)
            {
                c = null;
                return false;
            }
            
        }
        public static bool operator ==(Cerchio c1, Cerchio c2)
        {
            if (Object.ReferenceEquals(c1,null))
            {
                if(Object.ReferenceEquals(c2,null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
                
            else if(Object.ReferenceEquals(c2,null)) 
            {
                return false;
            }
            else
            {
                if(c1.Raggio==c2.Raggio)
                {
                    return true;
                }
                else { return false;}
            }
        }
    
        public static bool operator !=(Cerchio c1, Cerchio c2)
        {
            if(c1==c2)
            {
                return false;
            }
            else 
                return true;
   
        }
        public static Cerchio Parse(string s)
        {
            string[] a = new string[2];
            a = s.Split('=');

            return new Cerchio(double.Parse(a[1]));   
        }

    }

}
