using System;

namespace Singleton
{
    class SmartServiceFactory : ISmartServiceFactory
    {
        public IRelay CreateRelay()
        {
            return new Relay();
        }

        public IRGB CreateRGB()
        {
            return new RGB();
        }
    }
}