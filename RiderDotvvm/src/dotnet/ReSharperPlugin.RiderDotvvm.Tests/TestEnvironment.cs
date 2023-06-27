﻿using System.Threading;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: Apartment(ApartmentState.STA)]

namespace ReSharperPlugin.RiderDotvvm.Tests
{
    [ZoneDefinition]
    public class RiderDotvvmTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<IRiderDotvvmZone> { }

    [ZoneMarker]
    public class ZoneMarker : IRequire<ICodeEditingZone>, IRequire<ILanguageCSharpZone>, IRequire<RiderDotvvmTestEnvironmentZone> { }

    [SetUpFixture]
    public class RiderDotvvmTestsAssembly : ExtensionTestEnvironmentAssembly<RiderDotvvmTestEnvironmentZone> { }
}
