// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GitTest : ModuleRules
{
	public GitTest(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"GitTest",
			"GitTest/Variant_Platforming",
			"GitTest/Variant_Platforming/Animation",
			"GitTest/Variant_Combat",
			"GitTest/Variant_Combat/AI",
			"GitTest/Variant_Combat/Animation",
			"GitTest/Variant_Combat/Gameplay",
			"GitTest/Variant_Combat/Interfaces",
			"GitTest/Variant_Combat/UI",
			"GitTest/Variant_SideScrolling",
			"GitTest/Variant_SideScrolling/AI",
			"GitTest/Variant_SideScrolling/Gameplay",
			"GitTest/Variant_SideScrolling/Interfaces",
			"GitTest/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
