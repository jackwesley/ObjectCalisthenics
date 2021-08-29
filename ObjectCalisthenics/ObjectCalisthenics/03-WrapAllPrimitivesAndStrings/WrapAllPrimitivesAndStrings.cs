namespace ObjectCalisthenics._03_WrapAllPrimitivesAndStrings
{
    public class WrapAllPrimitivesAndStrings
    {
        public class User
        {
            public string Name { get; set; }
            public string CPF { get; set; }
        }

        //Refactoring
        public class User2
        {
            public string Name { get; set; }
            public CPF CPF { get; set; }
        }

        public class CPF
        {
            public string Value { get; set; }

            public bool IsValid() 
            { 
                return true; 
            }

            public bool IsCPF()
            {
                return true;
            }
        }
    }
}
