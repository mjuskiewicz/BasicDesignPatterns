using System;

namespace Builder
{
    internal class DesktopComputerBuilder : ComputerBuilder
    {
        public override ComputerBuilder AddHardware(string hardware)
        {
            _computer.Hardware.Add(hardware ?? throw new ArgumentNullException(nameof(hardware)));
            return this;
        }

        public override ComputerBuilder InstallCustomApplication(string applicationName)
        {
            _computer.Applications.Add(applicationName ?? throw new ArgumentNullException(nameof(applicationName)));
            return this;
        }

        public override ComputerBuilder SetupOperatingSystem(string operatingSystem)
        {
            _computer.OperatingSystem = operatingSystem ?? throw new ArgumentNullException(nameof(operatingSystem));
            return this;
        }
    }
}
