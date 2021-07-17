using System.Collections.Generic;
using System.Linq;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Netension.Testing
{
    public class FeatureTraitDiscoverer : ITraitDiscoverer
    {
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            var ctorArgs = traitAttribute.GetConstructorArguments().Cast<string>().ToList();
            yield return new KeyValuePair<string, string>(string.Empty, ctorArgs[0]);
        }
    }
}
