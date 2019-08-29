using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            DesktopComputerBuilder builder = new DesktopComputerBuilder();
            HighPerformanceComputerBuildDirector director = new HighPerformanceComputerBuildDirector();

            var computer = director.Construct(builder).Build();

            Console.WriteLine(computer.ToString());
        }
    }

    internal class HighPerformanceComputerBuildDirector
    {
        public ComputerBuilder Construct(ComputerBuilder builder)
        {
            return builder.AddHardware("Intel i5")
                          .AddHardware("4GB RAM")
                          .AddHardware("1TB HDD")
                          .SetupOperatingSystem("Windows")
                          .InstallCustomApplication("Skype");
        }
    }

}
