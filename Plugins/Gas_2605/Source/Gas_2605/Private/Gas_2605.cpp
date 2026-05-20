// Copyright Epic Games, Inc. All Rights Reserved.

#include "Gas_2605.h"

#define LOCTEXT_NAMESPACE "FGas_2605Module"

void FGas_2605Module::StartupModule()
{
	// This code will execute after your module is loaded into memory; the exact timing is specified in the .uplugin file per-module
}

void FGas_2605Module::ShutdownModule()
{
	// This function may be called during shutdown to clean up your module.  For modules that support dynamic reloading,
	// we call this function before unloading the module.
}

#undef LOCTEXT_NAMESPACE
	
IMPLEMENT_MODULE(FGas_2605Module, Gas_2605)