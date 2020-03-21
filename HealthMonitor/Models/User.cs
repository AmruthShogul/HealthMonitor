using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HealthMonitor.Models
{
    class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }

        public string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";

        public User()
        {

        }
        public User(string Username,string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        public User(string Username,string Password,string RePassword)
        {
            this.Username = Username;
            this.Password = Password;
            this.RePassword = RePassword;
        }
        // Login Email Validations
        public bool LoginEmailValidation()
        {
            if (this.Username.Equals(""))
            {
                return false;
            }
            else if (!(Regex.IsMatch(Username, emailPattern)))
            {
                return false;
            }
            else
                return true;
        }

        //Login Pwd Validation
        public bool LoginPasswordValidation()
        {
            if(this.Password.Equals(""))
            {
                return false;
            }
            else if (!((this.Password.Length >= 8) && (this.Password.Length <= 15)))
            {
                return false;
            }

            else if (!((this.Password.Contains("1") || this.Password.Contains("2")
            || this.Password.Contains("3") || this.Password.Contains("4")
            || this.Password.Contains("5") || this.Password.Contains("6")
            || this.Password.Contains("7") || this.Password.Contains("8")
            || this.Password.Contains("9") || this.Password.Contains("0"))
            && (this.Password.Contains("@") || this.Password.Contains("#")
                || this.Password.Contains("!") || this.Password.Contains("~")
                || this.Password.Contains("$") || this.Password.Contains("%")
                || this.Password.Contains("^") || this.Password.Contains("&")
                || this.Password.Contains("*") || this.Password.Contains("(")
                || this.Password.Contains(")") || this.Password.Contains("-")
                || this.Password.Contains("+") || this.Password.Contains("/")
                || this.Password.Contains(":") || this.Password.Contains(".")
                || this.Password.Contains(", ") || this.Password.Contains("<")
                || this.Password.Contains(">") || this.Password.Contains("?")
                || this.Password.Contains("|"))))

            {
                return false;
            }
            else
                return true;
        }

        //Sample Validation
        public bool CheckInformation()
        {
            if (this.Username.Equals("") || this.Password.Equals(""))
            {
                return false;
            }
            else if (!(Regex.IsMatch(Username, emailPattern)))
            {
                return false;
            }
            else if (!((this.Password.Length >= 8) && (this.Password.Length <= 15)))
            {
                return false;
            }

            else if (!((this.Password.Contains("1") || this.Password.Contains("2")
            || this.Password.Contains("3") || this.Password.Contains("4")
            || this.Password.Contains("5") || this.Password.Contains("6")
            || this.Password.Contains("7") || this.Password.Contains("8")
            || this.Password.Contains("9") || this.Password.Contains("0"))
            && (this.Password.Contains("@") || this.Password.Contains("#")
                || this.Password.Contains("!") || this.Password.Contains("~")
                || this.Password.Contains("$") || this.Password.Contains("%")
                || this.Password.Contains("^") || this.Password.Contains("&")
                || this.Password.Contains("*") || this.Password.Contains("(")
                || this.Password.Contains(")") || this.Password.Contains("-")
                || this.Password.Contains("+") || this.Password.Contains("/")
                || this.Password.Contains(":") || this.Password.Contains(".")
                || this.Password.Contains(", ") || this.Password.Contains("<")
                || this.Password.Contains(">") || this.Password.Contains("?")
                || this.Password.Contains("|"))))

            {
                return false;
            }
            else 
                return true;
        }

        //Sample Validation
        public bool SignUpCheckInformation()
        {
            if (this.Username.Equals("") || this.Password.Equals("") || this.RePassword.Equals(""))
            {
                return false;
            }
            else if (!(Regex.IsMatch(Username, emailPattern)))
            {
                return false;
            }
            else if (!((this.Password.Length >= 8) && (this.Password.Length <= 15)))
            {
                return false;
            }

            else if (!((this.Password.Contains("1") || this.Password.Contains("2")
            || this.Password.Contains("3") || this.Password.Contains("4")
            || this.Password.Contains("5") || this.Password.Contains("6")
            || this.Password.Contains("7") || this.Password.Contains("8")
            || this.Password.Contains("9") || this.Password.Contains("0"))
            && (this.Password.Contains("@") || this.Password.Contains("#")
                || this.Password.Contains("!") || this.Password.Contains("~")
                || this.Password.Contains("$") || this.Password.Contains("%")
                || this.Password.Contains("^") || this.Password.Contains("&")
                || this.Password.Contains("*") || this.Password.Contains("(")
                || this.Password.Contains(")") || this.Password.Contains("-")
                || this.Password.Contains("+") || this.Password.Contains("/")
                || this.Password.Contains(":") || this.Password.Contains(".")
                || this.Password.Contains(", ") || this.Password.Contains("<")
                || this.Password.Contains(">") || this.Password.Contains("?")
                || this.Password.Contains("|"))))

            {
                return false;
            }

            else if(!(this.Password.Equals(this.RePassword)))
            {
                return false;
            }
            else
                return true;
        }


        //SignUp Validations
        public bool SignupEmailValidation()
        {
            if (this.Username.Equals(""))
            {
                return false;
            }
            else if (!(Regex.IsMatch(Username, emailPattern)))
            {
                return false;
            }
            else
                return true;
        }
        public bool SignupPasswordValidation()
        {
            if (this.Password.Equals(""))
            {
                return false;
            }
            else if (!((this.Password.Length >= 8) && (this.Password.Length <= 15)))
            {
                return false;
            }

            else if (!((this.Password.Contains("1") || this.Password.Contains("2")
            || this.Password.Contains("3") || this.Password.Contains("4")
            || this.Password.Contains("5") || this.Password.Contains("6")
            || this.Password.Contains("7") || this.Password.Contains("8")
            || this.Password.Contains("9") || this.Password.Contains("0"))
            && (this.Password.Contains("@") || this.Password.Contains("#")
                || this.Password.Contains("!") || this.Password.Contains("~")
                || this.Password.Contains("$") || this.Password.Contains("%")
                || this.Password.Contains("^") || this.Password.Contains("&")
                || this.Password.Contains("*") || this.Password.Contains("(")
                || this.Password.Contains(")") || this.Password.Contains("-")
                || this.Password.Contains("+") || this.Password.Contains("/")
                || this.Password.Contains(":") || this.Password.Contains(".")
                || this.Password.Contains(", ") || this.Password.Contains("<")
                || this.Password.Contains(">") || this.Password.Contains("?")
                || this.Password.Contains("|"))))

            {
                return false;
            }
            else
                return true;
        }
        public bool PasswordMatchValidation()
        {
            if (!(Password.Equals(RePassword)))
            {
                return false;
            }
            else
                return true;
        }


    }
}
