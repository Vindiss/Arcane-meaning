// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Arcane_meaning : ModuleRules
{
	public Arcane_meaning(ReadOnlyTargetRules Target) : base(Target)
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
			"Arcane_meaning",
			"Arcane_meaning/Variant_Horror",
			"Arcane_meaning/Variant_Horror/UI",
			"Arcane_meaning/Variant_Shooter",
			"Arcane_meaning/Variant_Shooter/AI",
			"Arcane_meaning/Variant_Shooter/UI",
			"Arcane_meaning/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
