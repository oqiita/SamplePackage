using Artech.Architecture.Common.Services;
using Artech.Architecture.UI.Framework.Packages;
using System;
using System.Runtime.InteropServices;

namespace Oqiita.Packages.SamplePackage
{
    [Guid("92706303-332a-4e7d-8cd4-3d19ca092c14")]
    public class Package : AbstractPackageUI
    {

        // Add Code Oqiita
        public static Guid guid = typeof(Package).GUID;

        public override string Name
        {
            get { return "SamplePackage"; }
        }

        public override void Initialize(IGxServiceProvider services)
        {
            base.Initialize(services);

            // ƒRƒ}ƒ“ƒh‚Ì’Ç‰Á
            AddCommandTarget(new CommandManager());
        }
    }
}
