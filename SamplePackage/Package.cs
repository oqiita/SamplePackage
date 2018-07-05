using Artech.Architecture.Common.Packages;
using Artech.Architecture.Common.Services;
using System.Runtime.InteropServices;

namespace Oqiita.Packages.SamplePackage
{
	[Guid("a4b8938e-c41b-4f49-9e5e-0773df6598fc")]
public class Package : AbstractPackage	{
    public override string Name
    {
        get { return "SamplePackage"; }
    }

    public override void Initialize(IGxServiceProvider services)
    {
        base.Initialize(services);
% ADD_OBJECT_BEGIN %
            LoadCategories();
        LoadObjectTypes();% ADD_OBJECT_END %
% ADD_PART_BEGIN % LoadPartTypes();
        LoadEditors();% ADD_PART_END %

        }
	}
}
