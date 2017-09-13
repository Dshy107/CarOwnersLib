using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOwnersLib
{
    public class Car
    {
        public enum Color { Black, White, Gray, Red, Green, Blue }
        public int Doors { get; set; }
        public string Model { get; set; }
        public string registrationNo { get; set; }

        public Car()
        {
            
        }
        /// <summary>
        /// Her skal der være mellem 2 og 5 døre
        /// </summary>
        /// <returns></returns>
        public int DoorsNo()
        {
            int doors = this.Doors;
            if (doors >= 2 && doors <= 5)
                throw new ArgumentException("Der må kun være mellem 2 og 5 døre.");
            return doors;
        }
        /// <summary>
        /// Her skal den blive not null
        /// </summary>
        /// <returns></returns>
        public string ModelNotNull()
        {
            
            string model = this.Model;
            if (model.Equals(null))
                throw new NullReferenceException("Der skal være en Model.");
            return model;
                    
        }
        /// <summary>
        /// Registrerings nummeret skal være på 7 karaktere
        /// </summary>
        /// <returns></returns>
        public string regNummer()
        {
            string Regnummer = this.registrationNo;
            if (Regnummer.Length == 7)
                throw new ArgumentException("Der må kun være 7 karaktere i regnummeret");
            return Regnummer;
        }
        
    }
}
