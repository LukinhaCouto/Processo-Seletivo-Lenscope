using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processo_Seletivo_Lenscope
{
    internal class Program
    {
        static bool CondiçãoVision(double Esf_Esq, double Esf_Dir)
        {
            if ((Esf_Esq <= -3 && Esf_Esq >= -15)||(Esf_Dir <= -3 && Esf_Dir >= -15))
                return true;
            else
                return false;
        }
        static bool CondiçãoPrime(double Esf_Esq, double Esf_Dir)
        {
            if ((Esf_Esq <= -3 && Esf_Esq >= -12) || (Esf_Dir <= -3 && Esf_Dir >= -12))
                return true;
            else
                return false;
        }
        static bool Permitido(double Esf_Esq, double Esf_Dir, double Cili_Esq, double Cili_Dir)
        {
            if ((Esf_Esq < 0 && Esf_Esq > -15) || (Esf_Dir < 0 && Esf_Dir > -15))
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            double GrauEsf_Esq;
            double GrauEsf_Dir;

            double GrauCili_Esq;
            double GrauCili_Dir;

            bool Limite;
            bool CondiçãoA;
            bool CondiçãoV;

            string Resp = "";

            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.Write("Gráu esférico - Olho esquerdo: ");
                GrauEsf_Esq = double.Parse(Console.ReadLine());
                Console.Write("\nGráu esférico - Olho direito: ");
                GrauEsf_Dir = double.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------\n");
                Console.Write("Gráu cilíndrico - Olho esquerdo: ");
                GrauCili_Esq = double.Parse(Console.ReadLine());
                Console.Write("\nGráu cilíndrico - Olho direito: ");
                GrauCili_Dir = double.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                Limite = Permitido(GrauEsf_Esq, GrauEsf_Dir, GrauCili_Esq, GrauCili_Dir);

            } while(!Limite);

            CondiçãoA = CondiçãoPrime(GrauEsf_Esq, GrauEsf_Dir);
            CondiçãoV = CondiçãoVision(GrauEsf_Esq, GrauEsf_Dir);

            if (CondiçãoA)
            {
                if (GrauCili_Esq >= -2 || GrauCili_Dir >= -2)
                {
                    if ((GrauEsf_Esq <= -3 && GrauEsf_Esq >= -10) || (GrauEsf_Dir <= -3 && GrauEsf_Dir >= -10))
                        Resp = "O senhor necessita da Lente Prime";
                }
            }
            else if(CondiçãoV)
            {
                if(GrauCili_Esq >=-5 || GrauCili_Dir >=-5)
                {
                    Resp = "O senhor necessita da Lente Vision";
                }
            }
            else
                Resp = "O senhor necessita da Lente Prime!!!");

            Console.WriteLine(Resp);

            Console.ReadKey();
        }
    }
}
