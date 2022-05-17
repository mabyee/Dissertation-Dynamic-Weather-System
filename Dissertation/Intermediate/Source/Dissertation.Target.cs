using UnrealBuildTool;

public class DissertationTarget : TargetRules
{
	public DissertationTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Dissertation");
	}
}
