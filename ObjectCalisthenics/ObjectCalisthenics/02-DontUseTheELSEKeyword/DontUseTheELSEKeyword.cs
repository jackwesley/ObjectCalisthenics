namespace ObjectCalisthenics._02_DontUseTheELSEKeyword
{
    class DontUseTheELSEKeyword
    {
        public bool CheckPermittedAge(int age)
        {
            bool permission = false;
            if (age > 18)
                permission = true;
            else
                permission = false;

            return permission;
        }

        //Refactoring
        public bool CheckPermittedAgeRefactored(int age)
        {
            if (age > 18)
                return true;

            return false;
        }
    }
}
