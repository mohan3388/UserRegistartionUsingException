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
        public static string EMAIL_REGEX_PATTERN = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static string MOBILE_REGEX_PATTERN = "^[91]{2}[' ']{1}[7898625487]{10}$";
        public static string PASS_REGEX_PATTERN = "^[A-Za-z]{8,}";
        public static string PASS_REGEX_PATTERN2 = "^[A-Z]{1,}[A-Za-z]{8,}";
        public static string PASS_REGEX_PATTERN3 = "^[A-Z]{1,}[A-Za-z]{6,}[0-9]{1,}";
        public static string PASS_REGEX_PATTERN4 = "^[A-Z]{1,}[A-Za-z]{5,}[!@#$%^&*]{1,}[0-9]{1,}";
        public bool FNameValidation(string name)
        {
            try{
                return Regex.IsMatch(name, REGEX_PATTERN);
            }
            catch (Exception ex)
            {
                throw ex;

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
        public bool EmailValidation(string email)
        {
            try
            {
                return Regex.IsMatch(email, EMAIL_REGEX_PATTERN);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool MobileValidation(string mobile)
        {
            try
            {
                return Regex.IsMatch(mobile, MOBILE_REGEX_PATTERN);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool PasswordValidation(string pass)
        {
            try
            {
                return Regex.IsMatch(pass, PASS_REGEX_PATTERN);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool PassIncludeOneUppercase(string pass)
        {
            try
            {
                return Regex.IsMatch(pass, PASS_REGEX_PATTERN2);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool PassIncludeOneNumeric(string pass)
        {
            try
            {
                return Regex.IsMatch(pass, PASS_REGEX_PATTERN3);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool PassIncludeOneSpecialChar(string pass)
        {
            try
            {
                return Regex.IsMatch(pass, PASS_REGEX_PATTERN4);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
