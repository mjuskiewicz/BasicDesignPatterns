namespace Builder
{
    internal abstract class ComputerBuilder
    {
        protected Computer _computer = new Computer();

        public abstract ComputerBuilder AddHardware(string hardware);
        public abstract ComputerBuilder SetupOperatingSystem(string operatingSystem);
        public abstract ComputerBuilder InstallCustomApplication(string applicationName);

        public Computer Build()
        {
            return _computer;
        }
    }
}
