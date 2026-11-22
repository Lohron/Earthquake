using UnrealBuildTool;

public class EarthquakeTarget : TargetRules
{
	public EarthquakeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Earthquake");
	}
}
