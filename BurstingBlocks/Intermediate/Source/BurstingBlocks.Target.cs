using UnrealBuildTool;

public class BurstingBlocksTarget : TargetRules
{
	public BurstingBlocksTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("BurstingBlocks");
	}
}
