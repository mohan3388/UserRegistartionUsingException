using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class User
    {
        public static string REGEX_PATTERN = "^[A-Z]{1}[A-Za-z]{2,}$";
       
        public bool FNameValidation(string name)
        {
            try{
                return Regex.IsMatch(name, REGEX_PATTERN);
            }
            catch(Exception)
            {
                return false;
            }
        }
        public bool LNameValidation(string lname)
        {
            try
            {
                return Regex.IsMatch(lname, REGEX_PATTERN);
               
            }
            catch (Exception ex)
            {
                throw ex;
               
            }
            
        }
    }
}
