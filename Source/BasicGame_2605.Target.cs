// Copyright Jeffrey Wills. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BasicGame_2605Target : TargetRules
{
	public BasicGame_2605Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V6;

		ExtraModuleNames.AddRange( new string[] { "BasicGame_2605" } );
	}
}
