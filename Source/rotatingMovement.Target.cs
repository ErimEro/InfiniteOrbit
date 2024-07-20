using UnrealBuildTool;

public class rotatingMovementTarget : TargetRules
{
	public rotatingMovementTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("rotatingMovement");
	}
}
