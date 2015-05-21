﻿using System.Configuration;
using HandyConfig.Configuration;
using Humanizer;
using System;
using System.Collections.Generic;


namespace Joyride.Specflow.Configuration
{
    public class JoyrideSectionHandler : ConfigurationSection
    {
        [ConfigurationProperty("capabilities", IsRequired = true)]
        public CapabilitiesElement Capabilities { get { return (CapabilitiesElement) base["capabilities"]; } }
        
        [ConfigurationProperty("servers", IsRequired = true)]
        public ServersElement Servers { get { return (ServersElement) base["servers"]; } }
    }

 
    public class IosElement : HandyConfigElement
    {
        [ConfigurationProperty("devices")]
        public DeviceElementCollection Devices
        {
            get { return this["devices"] as DeviceElementCollection; }
        }      
    }

    public class AndroidElement : HandyConfigElement
    {
        [ConfigurationProperty("devices")]
        public DeviceElementCollection Devices
        {
            get { return this["devices"] as DeviceElementCollection; }
        }
    }
}
