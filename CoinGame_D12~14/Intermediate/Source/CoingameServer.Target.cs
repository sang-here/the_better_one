using UnrealBuildTool;

public class CoingameServerTarget : TargetRules
{
	public CoingameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Coingame");
	}
}
