﻿using System;
namespace FF1Lib
{
	public enum MapIndex : byte
	{
		ConeriaTown = 0,
		Pravoka = 1,
		Elfland = 2,
		Melmond = 3,
		CrescentLake = 4,
		Gaia = 5,
		Onrac = 6,
		Lefein = 7,
		ConeriaCastle1F = 8,
		ElflandCastle = 9,
		NorthwestCastle = 10,
		CastleOrdeals1F = 11,
		TempleOfFiends = 12,
		EarthCaveB1 = 13,
		GurguVolcanoB1 = 14,
		IceCaveB1 = 15,
		Cardia = 16,
		BahamutCaveB1 = 17,
		Waterfall = 18,
		DwarfCave = 19,
		MatoyasCave = 20,
		SardasCave = 21,
		MarshCaveB1 = 22,
		MirageTower1F = 23,
		ConeriaCastle2F = 24,
		CastleOrdeals2F = 25,
		CastleOrdeals3F = 26,
		MarshCaveB2 = 27,
		MarshCaveB3 = 28,
		EarthCaveB2 = 29,
		EarthCaveB3 = 30,
		EarthCaveB4 = 31,
		EarthCaveB5 = 32,
		GurguVolcanoB2 = 33,
		GurguVolcanoB3 = 34,
		GurguVolcanoB4 = 35,
		GurguVolcanoB5 = 36,
		IceCaveB2 = 37,
		IceCaveB3 = 38,
		BahamutCaveB2 = 39,
		MirageTower2F = 40,
		MirageTower3F = 41,
		SeaShrineB5 = 42,
		SeaShrineB4 = 43,
		SeaShrineB3 = 44,
		SeaShrineB2 = 45,
		SeaShrineB1 = 46,
		SkyPalace1F = 47,
		SkyPalace2F = 48,
		SkyPalace3F = 49,
		SkyPalace4F = 50,
		SkyPalace5F = 51,
		TempleOfFiendsRevisited1F = 52,
		TempleOfFiendsRevisited2F = 53,
		TempleOfFiendsRevisited3F = 54,
		TempleOfFiendsRevisitedEarth = 55,
		TempleOfFiendsRevisitedFire = 56,
		TempleOfFiendsRevisitedWater = 57,
		TempleOfFiendsRevisitedAir = 58,
		TempleOfFiendsRevisitedChaos = 59,
		TitansTunnel = 60,
	}
	public enum MapLocation
	{
		StartingLocation,
		AirshipLocation,
		Coneria,
		Pravoka,
		Elfland,
		Melmond,
		CrescentLake,
		Gaia,
		Onrac,
		Lefein,
		Caravan,
		ConeriaCastle1,
		ConeriaCastle2,
		ConeriaCastleRoom1,
		ConeriaCastleRoom2,
		ElflandCastle,
		ElflandCastleRoom1,
		NorthwestCastle,
		NorthwestCastleRoom2,
		CastleOrdeals1,
		CastleOrdealsMaze,
		CastleOrdealsTop,
		EarthCave1,
		EarthCave2,
		EarthCaveVampire,
		EarthCave4,
		EarthCaveLich,
		GurguVolcano1,
		GurguVolcano2,
		GurguVolcano3,
		GurguVolcano4,
		GurguVolcano5,
		GurguVolcano6,
		GurguVolcanoKary,
		IceCave1,
		IceCave2,
		IceCave3,
		IceCavePitRoom,
		IceCave5,
		IceCaveBackExit,
		IceCaveFloater,
		Cardia1,
		Cardia2,
		BahamutCave1,
		BahamutCave2,
		Cardia4,
		Cardia5,
		Cardia6,
		Waterfall,
		DwarfCave,
		DwarfCaveRoom3,
		MatoyasCave,
		SardasCave,
		MarshCave1,
		MarshCaveTop,
		MarshCave3,
		MarshCaveBottom,
		MarshCaveBottomRoom13,
		MarshCaveBottomRoom14,
		MarshCaveBottomRoom16,
		MirageTower1,
		MirageTower2,
		MirageTower3,
		SeaShrine1,
		SeaShrine2,
		SeaShrine2Room2,
		SeaShrineMermaids,
		SeaShrine4,
		SeaShrine5,
		SeaShrine6,
		SeaShrine7,
		SeaShrine8,
		SeaShrineKraken,
		SkyPalace1,
		SkyPalace2,
		SkyPalace3,
		SkyPalaceMaze,
		SkyPalaceTiamat,
		TempleOfFiends1,
		TempleOfFiends1Room1,
		TempleOfFiends1Room2,
		TempleOfFiends1Room3,
		TempleOfFiends1Room4,
		TempleOfFiendsRevisited1,
		TempleOfFiendsRevisited2,
		TempleOfFiendsRevisitedPhantom,
		TempleOfFiendsRevisited4,
		TempleOfFiendsRevisited5,
		TempleOfFiendsRevisitedEarth,
		TempleOfFiendsRevisitedEarthDeadEnd,
		TempleOfFiendsRevisitedFire,
		TempleOfFiendsRevisitedWater,
		TempleOfFiendsRevisitedAir,
		TempleOfFiendsRevisitedChaos,
		TitansTunnelEast,
		TitansTunnelWest,
		TitansTunnelRoom,
	}
	public enum ExitTeleportIndex : byte
	{
		ExitTitanE = 0,
		ExitTitanW = 1,
		ExitIceCave = 2,
		ExitCastleOrdeals = 3,
		ExitCastleConeria = 4,
		ExitEarthCave = 5,
		ExitGurguVolcano = 6,
		ExitSeaShrine = 7,
		ExitSkyPalace = 8,
		ExitUnused1 = 9,
		ExitUnused2 = 10,
		ExitUnused3 = 11,
		ExitUnused4 = 12,
		ExitUnused5 = 13,
		ExitUnused6 = 14,
		ExitUnused7 = 15,
		None = 255
	}
	public enum TeleportIndex : byte
	{
		ConeriaCastle2 = 0, // to go upstairs
		TimeWarp = 1,
		MarshCaveTop = 2,
		MarshCave3 = 3,
		MarshCaveBottom = 4,
		EarthCave2 = 5,
		EarthCaveVampire = 6,
		EarthCave4 = 7,
		EarthCaveLich = 8,
		GurguVolcano2 = 9,
		GurguVolcano3 = 10,
		GurguVolcano4 = 11,
		GurguVolcano5 = 12,
		GurguVolcano6 = 13,
		GurguVolcanoKary = 14,
		IceCave2 = 15,
		IceCave3 = 16,
		IceCavePitRoom = 17,
		IceCave4 = 18,
		IceCave5 = 19,
		IceCave6 = 20,
		IceCave7 = 21,
		CastleOrdealsMaze = 22,
		CastleOrdealsTop = 23,
		CastleOrdealsBack = 24,
		BahamutsRoom = 25,
		CastleOrdeals4 = 26,
		CastleOrdeals5 = 27,
		CastleOrdeals6 = 28,
		CastleOrdeals7 = 29,
		CastleOrdeals8 = 30,
		CastleOrdeals9 = 31,
		SeaShrine1 = 32,
		SeaShrine2 = 33,
		SeaShrineMermaids = 34,
		SeaShrine4 = 35,
		SeaShrine5 = 36,
		SeaShrine6 = 37,
		SeaShrine7 = 38,
		SeaShrine8 = 39,
		SeaShrineKraken = 40,
		MirageTower2 = 41,
		MirageTower3 = 42,
		SkyPalace1 = 43,
		SkyPalace2 = 44,
		SkyPalace3 = 45,
		SkyPalaceMaze = 46,
		SkyPalaceTiamat = 47,
		TempleOfFiendsRevisitedEarthDeadEnd = 48,
		TempleOfFiendsRevisited2 = 49,
		TempleOfFiendsRevisitedPhantom = 50,
		TempleOfFiendsRevisited4 = 51,
		TempleOfFiendsRevisited5 = 52,
		TempleOfFiendsRevisitedEarth = 53,
		TempleOfFiendsRevisitedFire = 54,
		TempleOfFiendsRevisitedWater = 55,
		TempleOfFiendsRevisitedAir = 56,
		TempleOfFiendsRevisitedChaos = 57,
		CastleOrdeals10 = 58,
		CastleOrdeals11 = 59,
		CastleOrdeals12 = 60,
		CastleOrdeals13 = 61,
		ConeriaCastleBack = 62, // going back down
		RescuePrincess = 63,
		Overworld = 255
	}
	public enum OverworldTeleportIndex : byte
	{
		Cardia1 = 0,
		Coneria = 1,
		Pravoka = 2,
		Elfland = 3,
		Melmond = 4,
		CrescentLake = 5,
		Gaia = 6,
		Onrac = 7,
		Lefein = 8,
		ConeriaCastle1 = 9,
		ElflandCastle = 10,
		NorthwestCastle = 11,
		CastleOrdeals1 = 12,
		TempleOfFiends1 = 13,
		EarthCave1 = 14,
		GurguVolcano1 = 15,
		IceCave1 = 16,
		Cardia2 = 17,
		BahamutCave1 = 18,
		Waterfall = 19,
		DwarfCave = 20,
		MatoyasCave = 21,
		SardasCave = 22,
		MarshCave1 = 23,
		MirageTower1 = 24,
		TitansTunnelEast = 25,
		TitansTunnelWest = 26,
		Cardia4 = 27,
		Cardia5 = 28,
		Cardia6 = 29,
		Unused1 = 30,
		Unused2 = 31
	}
	public enum Backdrop : byte
	{
		Grass = 0x00,
		MarshCave = 0x01,
		Cave = 0x02,
		Water = 0x03,
		Forest = 0x04,
		TempleOfFiends = 0x05,
		Desert = 0x06,
		Marsh = 0x07,
		EarthCave = 0x08,
		Castle = 0x09,
		River = 0x0A,
		Tower = 0x0B,
		SeaShrine = 0x0C,
		IceCave	= 0x0D,
		Volcano	= 0x0E,
		Waterfall = 0x0F,
	}
}
