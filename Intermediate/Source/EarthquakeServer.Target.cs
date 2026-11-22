using UnrealBuildTool;

public class EarthquakeServerTarget : TargetRules
{
	public EarthquakeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Earthquake");
	}
}
