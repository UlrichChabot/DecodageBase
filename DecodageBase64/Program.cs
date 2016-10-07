using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodageBase64Console
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DecodageBase64();
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static int PickANumber()
        {
            string picked = Console.ReadLine();

            // Vérifier la validité de la saisie avec TryParse
            int pickedNum;
            bool isNumeric = int.TryParse(picked, out pickedNum);
            while (isNumeric == false)
            {
                // A VOUS : Trouvez le code à écrire ici
                Console.WriteLine("Oups, ce n'est pas un nombre. Essaie encore.");
                picked = Console.ReadLine();
                isNumeric = int.TryParse(picked, out pickedNum);
            }

            return pickedNum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static string PickASring()
        {
            string picked = Console.ReadLine();
            while (true )
            {
                if ( picked.Equals("") )
                {
                    Console.WriteLine("Maivaise réponse. Essaie encore.");
                    continue;
                }
                else
                {
                    break;
                }
            }

            return picked;
        }

            /// <summary>
            /// 
            /// </summary>
            static void Fin()
        {
            Console.WriteLine("Décode terminé.");
        }

        /// <summary>
        /// 
        /// </summary>
        static void DecodageBase64()
        {

            Console.WriteLine("Saisissez la chaine en base64: ");

            string base64Encoded = PickASring();
            //string base64Encoded = "YmFzZTY0IGVuY29kZWQgc3RyaW5n";

            string base64Decoded;
            byte[] data = System.Convert.FromBase64String(base64Encoded);
            base64Decoded = System.Text.ASCIIEncoding.ASCII.GetString(data);

            Console.WriteLine("Resultat :" + base64Decoded);

            Fin();
        }
    }
}
