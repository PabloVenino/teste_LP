using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_LP
{
    public class Alfabet
    {
        public List<string> CompleteAlfabet = new List<string>();
        public List<string> bar = new List<string>();
        public List<string> foo = new List<string>();
        public Alfabet()
        {
            //k, b, w, r, q, d, n, f, x, j, m, l, v, h, t, c, g, z, p, s
            CompleteAlfabet.Add("k");
            CompleteAlfabet.Add("b");
            CompleteAlfabet.Add("w");
            CompleteAlfabet.Add("r");
            CompleteAlfabet.Add("q");
            CompleteAlfabet.Add("d");
            CompleteAlfabet.Add("n");
            CompleteAlfabet.Add("f");
            CompleteAlfabet.Add("x");
            CompleteAlfabet.Add("j");
            CompleteAlfabet.Add("m");
            CompleteAlfabet.Add("l");
            CompleteAlfabet.Add("v");
            CompleteAlfabet.Add("h");
            CompleteAlfabet.Add("t");
            CompleteAlfabet.Add("c");
            CompleteAlfabet.Add("g");
            CompleteAlfabet.Add("z");
            CompleteAlfabet.Add("p");
            CompleteAlfabet.Add("s");


            foreach(var item in CompleteAlfabet)
            {
                switch (item)
                {
                    case "s":
                    case "l":
                    case "f":
                    case "w":
                    case "k":
                        foo.Add(item);
                        break;

                    default:
                        bar.Add(item);
                        break;
                }
            }
        }
    }
}
