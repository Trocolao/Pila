using System.Security.Principal;

namespace StackSegundo.MVC.Models
{
    public class ModeloPila
    {
        public int?[] StackArray { get; set; }
        public int? NumeroElementos { get; set; }
     
        public ModeloPila()
        {
            StackArray= new int?[10];
            NumeroElementos = 0;
        }
       /*public int? AsignarElementos(int?[] array)
        {
            int? numElementos=0;
            for(int i=0;i<array.Length; i++)
            {
                if (array[i] == null)
                {
                    numElementos = i+1; break;
                }
            }
            return numElementos;
        }*/
    }
}
