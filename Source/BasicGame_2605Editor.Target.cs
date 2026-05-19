// Copyright Jeffrey Wills. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BasicGame_2605EditorTarget : TargetRules
{
	public BasicGame_2605EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V6;

		ExtraModuleNames.AddRange( new string[] { "BasicGame_2605" } );
	}
}
