using UnrealBuildTool;

public class CoingameClientTarget : TargetRules
{
	public CoingameClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Coingame");
	}
}
