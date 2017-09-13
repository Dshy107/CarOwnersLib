using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOwnersLib
{
    public enum Color { Black, White, Gray, Red, Green, Blue }
    public class Car
    {
       
        //public int Doors { get; set; }
        //public string Model { get; set; }
        //public string registrationNo { get; set; }
        public int Doors;
        public string Model;
        public string registrationNo;

        /// <summary>
        /// Registrerings nummeret skal være på 7 karaktere
        /// </summary>
        /// <returns></returns>
        private string RegNo
        {
            get { return registrationNo; }
            set
            {
                if (RegNo.Length == 7)
                {
                    throw new Exception("Der må kun være 7 karaktere i regnummeret");
                }
            }
        }
        /// <summary>
        /// Her skal den blive not null
        /// </summary>
        /// <returns></returns>
        private string ModelNotNull
        {
            get { return Model; }
            set
            {
                if (Model.Equals(null))
                {
                    throw new NullReferenceException("Der skal være en Model.");
                }
            }
        }
        /// <summary>
        /// Her skal der være mellem 2 og 5 døre
        /// </summary>
        /// <returns></returns>
        private int DoorsNo
        {
            get { return Doors; }
            set
            {
                if (Doors >= 2 && Doors <= 5)
                {
                    throw new Exception("Der må kun være mellem 2 og 5 døre.");
                }
            }
        }


        public Car()
        {
            
        }
       
       
        
    }
}
