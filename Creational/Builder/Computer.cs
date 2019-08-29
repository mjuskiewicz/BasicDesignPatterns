using System.Collections.Generic;

namespace Builder
{
    internal class Computer
    {
        public List<string> Hardware { get; set; } = new List<string>();
        public string OperatingSystem { get; set; }
        public List<string> Applications { get; set; } = new List<string>();

        public override string ToString()
        {
            var hardware = string.Join(",", Hardware);
            var applications = string.Join(",", Applications);
            return $"Hardware: {hardware}; OperatingSystem: {OperatingSystem}; Applications: {applications}";
        }
    }
}
