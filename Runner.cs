using System;
using Microsoft.Extensions.Logging;

namespace nlog_lab
{
    public class Runner
    {
        private readonly ILogger<Runner> _logger;

        public Runner(ILogger<Runner> logger)
        {
            _logger = logger;
        }

        public void DoAction(string name)
        {
            try
            {
                if (name.Contains("9"))
                    throw new ArgumentException("Testing excepction");
                _logger.LogDebug(20, "Doing hard work! {Action}", name);
            }
            catch (ArgumentException ex)
            {
                _logger.LogCritical(ex, ex.ToString());
            }
        }
    }
}