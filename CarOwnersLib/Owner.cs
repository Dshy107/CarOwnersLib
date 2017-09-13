using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOwnersLib
{
    public class Owner
    {
        public string Address;
        public string Name;
        public string Phone;
        /// <summary>
        /// Telefon nummret skal være på 8 tegn
        /// </summary>
        /// <returns></returns>
        private string PhoneChar
        {
            get { return Phone; }
            set
            {
                if (Phone.Length == 8)
                {
                    throw new ArgumentException("Dit telefon nummer må kun være 8 karaktere langt.");
                }
            }
        }
        /// <summary>
        /// Navn skal være på eller over 4 tegn
        /// </summary>
        /// <returns></returns>
        private string NameChars
        {
            get { return Name; }
            set
            {
                if (Name.Length > 4)
                {
                    throw new ArgumentException("Dit navn skal være fire karaktere langt eller mere.");
                }
            }
        }

        
        /// <summary>
        /// Addressen må ikke være over 6 tegn
        /// </summary>
        /// <returns></returns>
        private string AddressChar
        {
            get { return Address; }
            set
            {
                if (Address.Length > 6)
                {
                    throw new ArgumentException("Addressen må ikke være længere end 6.");
                }
            }
        }


        public Owner()
        {

        }
        
        
        
       
        
        
    }
}
