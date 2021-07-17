using System;
using Xunit.Sdk;

namespace Xunit
{
    [TraitDiscoverer("Netension.Testing.FeatureTraitDiscoverer", "Netension.Extensions.Testing")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class FeatureAttribute : Attribute, ITraitAttribute
    {
        public FeatureAttribute(string name) { }
    }
}
