using UnrealBuildTool;

public class CoingameTarget : TargetRules
{
	public CoingameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Coingame");
	}
}
