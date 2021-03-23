using UnrealBuildTool;

public class CRUNCHTarget : TargetRules
{
	public CRUNCHTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("CRUNCH");
	}
}
