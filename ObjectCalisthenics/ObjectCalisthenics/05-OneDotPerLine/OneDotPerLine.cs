using Microsoft.Extensions.Configuration;


namespace ObjectCalisthenics._05_OneDotPerLine
{
    public class OneDotPerLine
    {
        public void Method()
        {

            var builder = new ConfigurationBuilder().SetBasePath("hostEnvironment.ContentRootPath").AddJsonFile(path: "appsettings.json").AddJsonFile(path: $"appsettings.json").AddEnvironmentVariables();
        }


        #region Law of Demeter
        public class Car
        {
            public Performance Performance { get; set; }

            public void Start()
            {
                Performance.Engine.Parts.Start();
            }

        }

        public class Performance
        {
            public Engine Engine { get; set; }

            public void Start()
            {
                Engine.Start();
            }
        }

        public class Engine
        {
            public Parts Parts { get; set; }
            public void Start() 
            {
                Parts.Start();
            }
        }

        public class Parts
        {
            public void Start()
            {
                //Do some logic   
            }
        }
        #endregion
    }
}
