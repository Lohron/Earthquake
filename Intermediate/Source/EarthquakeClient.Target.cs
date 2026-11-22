using UnrealBuildTool;

public class EarthquakeClientTarget : TargetRules
{
	public EarthquakeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Earthquake");
	}
}
