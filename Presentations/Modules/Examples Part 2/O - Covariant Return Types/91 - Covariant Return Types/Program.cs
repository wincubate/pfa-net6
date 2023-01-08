using System;
using Wincubate.CS10.Part3.Slide91;

var provider = new AppleConfigProvider();
//Console.WriteLine( provider.GetConfig().IsTooExpensive);

namespace Wincubate.CS10.Part3.Slide91
{
    public class Config
    {
        public string ModelName { get; set; }
    }

    public class ConfigProvider
    {
        public virtual Config GetConfig() => new Config { ModelName = "Unknown" };
    }

    public class AppleConfig : Config
    {
        public bool IsTooExpensive { get; set; }
    }

    public class AppleConfigProvider : ConfigProvider
    {
        public override Config GetConfig()
        {
            return new AppleConfig
            {
                ModelName = "Iphone Y",
                IsTooExpensive = true
            };
        }
    }
}
