using System ;
using System.ComponentModel.Design.Serialization;
namespace Imc
{
    public class Program
    {
        public static void Main()
        {
          Console.WriteLine ("---------------CALCULADORA IMC-------------") ;
          Console.WriteLine ("\n Digite sua altura : ") ;
          double altura= Convert.ToDouble (Console.ReadLine()) ;
          Console.WriteLine ("\n Digite seu peso : ") ;
          double peso= Convert.ToDouble (Console.ReadLine()) ;

          double ResultImc= peso / altura ^ 2.0 ; 

            if (ResultImc > 25 )
            {
                Console.WriteLine ("\n Já pode se preocupar, você está com sobrepeso.") ; 
            }
            else
            {
                Console.WriteLine ("\n Seu IMC está normal.") ;
            }


            } 
        }
    }
