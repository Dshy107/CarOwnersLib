using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOwnersLib
{
    public class Owner
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Owner()
        {

        }
        /// <summary>
        /// Addressen må ikke være over 6 tegn
        /// </summary>
        /// <returns></returns>
        public string AddressChars()
        {
            string address = this.Address;
            if (address.Length > 6)
                throw new ArgumentException("Addressen må ikke være længere end 6.");
            return address;
        }
        /// <summary>
        /// Navn skal være på eller over 4 tegn
        /// </summary>
        /// <returns></returns>
        public string NameChars()
        {
            string name = this.Name;
            if (name.Length > 4)
                throw new ArgumentException("Dit navn skal være fire karaktere langt eller mere.");
            return name;
        }
        /// <summary>
        /// Telefon nummret skal være på 8 tegn
        /// </summary>
        /// <returns></returns>
        public string PhoneChars()
        {
            string phone = this.Phone;
            if (phone.Length == 8)
                throw new ArgumentException("Dit telefon nummer må kun være 8 karaktere langt.");
            return phone;

        }
    }
}
