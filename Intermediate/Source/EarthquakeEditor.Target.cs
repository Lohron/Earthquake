using UnrealBuildTool;

public class EarthquakeEditorTarget : TargetRules
{
	public EarthquakeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Earthquake");
	}
}
