using UnrealBuildTool;

public class CoingameEditorTarget : TargetRules
{
	public CoingameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Coingame");
	}
}
