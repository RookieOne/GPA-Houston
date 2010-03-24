using StructureMap.Configuration.DSL;

namespace GpaHouston.Framework
{
    public class MyAppRegistry : Registry
    {
        public MyAppRegistry()
        {
            Scan(s =>
                     {
                         s.TheCallingAssembly();
                         s.WithDefaultConventions();
                     });
        }
    }
}