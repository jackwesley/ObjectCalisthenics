using System;

namespace ObjectCalisthenics._02_DontUseTheELSEKeyword
{
    class DontUseTheELSEKeyword
    {
        public bool ValidateEmail(string email)
        {
            if (!isValid(email))
            {
                if (!isEmailRegistered(email))
                {
                    if (!isVip(email))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        private bool isVip(string email)
        {
            throw new NotImplementedException();
        }

        private bool isEmailRegistered(string email)
        {
            throw new NotImplementedException();
        }

        private bool isValid(string email)
        {
            throw new NotImplementedException();
        }

        //Refactoring
        public bool ValidateEmail2(string email)
        {
            if (!isValid(email))
                return false;

            if (!isEmailRegistered(email))
                return false;

            if (!isVip(email))
                return false;
                        
            return true;
        }
    }
}
