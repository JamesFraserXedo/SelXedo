using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Core.Utilities
{
    class CustomDriver : RemoteWebDriver
        {
            public CustomDriver(ICommandExecutor commandExecutor, ICapabilities desiredCapabilities)
                : base(commandExecutor, desiredCapabilities)
            {
            }

            public CustomDriver(ICapabilities desiredCapabilities)
                : base(desiredCapabilities)
            {
            }

            public CustomDriver(Uri remoteAddress, ICapabilities desiredCapabilities)
                : base(remoteAddress, desiredCapabilities)
            {
            }

            public CustomDriver(Uri remoteAddress, ICapabilities desiredCapabilities, TimeSpan commandTimeout)
                : base(remoteAddress, desiredCapabilities, commandTimeout)
            {
            }

            public SessionId JobId { get { return SessionId; } }
        
    }
}
