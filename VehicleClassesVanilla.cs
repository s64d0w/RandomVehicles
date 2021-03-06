﻿using GTA;
using System.Collections.Generic;

namespace RandomVehicles
{
    class VehicleClassesVanilla
    {
        /*public static VehicleHash[] badVehicles =
        {
            VehicleHash.CableCar,
            VehicleHash.Submersible,
            VehicleHash.Submersible2,
            VehicleHash.Freight,
            VehicleHash.FreightCar,
            VehicleHash.FreightCont1,
            VehicleHash.FreightCont2,
            VehicleHash.FreightGrain,
            VehicleHash.FreightTrailer,
            VehicleHash.MetroTrain,
            VehicleHash.TankerCar
        };*/

        public static VehicleHash[] trailers =
        {
            VehicleHash.ArmyTanker,
            VehicleHash.ArmyTrailer,
            VehicleHash.ArmyTrailer2,
            VehicleHash.BaleTrailer,
            VehicleHash.BoatTrailer,
            VehicleHash.BoatTrailer,
            VehicleHash.DockTrailer,
            VehicleHash.GrainTrailer,
            VehicleHash.PropTrailer,
            VehicleHash.RakeTrailer,
            VehicleHash.Tanker,
            VehicleHash.Tanker2,
            VehicleHash.TR2,
            VehicleHash.TR3,
            VehicleHash.TR4,
            VehicleHash.TrailerLarge,
            VehicleHash.TrailerLogs,
            VehicleHash.Trailers,
            VehicleHash.Trailers2,
            VehicleHash.Trailers3,
            VehicleHash.Trailers4,
            VehicleHash.TrailerSmall,
            VehicleHash.TrailerSmall2,
            VehicleHash.TRFlat,
            VehicleHash.TVTrailer
        };

        public static VehicleHash[] bicycles =
        {
            VehicleHash.Bmx,
            VehicleHash.Cruiser,
            VehicleHash.Fixter,
            VehicleHash.Scorcher,
            VehicleHash.TriBike,
            VehicleHash.TriBike2,
            VehicleHash.TriBike3
        };

        public static VehicleHash[] boats =
        {
            VehicleHash.Dinghy,
            VehicleHash.Dinghy2,
            VehicleHash.Dinghy3,
            VehicleHash.Dinghy4,
            VehicleHash.Jetmax,
            VehicleHash.Marquis,
            VehicleHash.Predator,
            VehicleHash.Seashark,
            VehicleHash.Seashark2,
            VehicleHash.Seashark3,
            VehicleHash.Speeder,
            VehicleHash.Speeder2,
            VehicleHash.Squalo,
            VehicleHash.Suntrap,
            VehicleHash.Toro,
            VehicleHash.Toro2,
            VehicleHash.Tropic,
            VehicleHash.Tropic2,
            VehicleHash.Tug
        };

        public static VehicleHash[] compacts =
        {
            VehicleHash.Blista,
            VehicleHash.Brioso,
            VehicleHash.Dilettante,
            VehicleHash.Dilettante2,
            VehicleHash.Issi2,
            VehicleHash.Issi3,
            VehicleHash.Panto,
            VehicleHash.Prairie,
            VehicleHash.Rhapsody

        };

        public static VehicleHash[] coupes =
        {
            VehicleHash.CogCabrio,
            VehicleHash.Exemplar,
            VehicleHash.F620,
            VehicleHash.Faction,
            VehicleHash.Faction2,
            VehicleHash.Felon,
            VehicleHash.Felon2,
            VehicleHash.Jackal,
            VehicleHash.Sentinel,
            VehicleHash.Sentinel2,
            VehicleHash.Windsor,
            VehicleHash.Windsor2,
            VehicleHash.Zion,
            VehicleHash.Zion2
        };

        public static VehicleHash[] emergency =
        {
            VehicleHash.Ambulance,
            VehicleHash.Barracks,
            VehicleHash.Barracks2,
            VehicleHash.Barracks3,
            VehicleHash.Crusader,
            VehicleHash.FBI,
            VehicleHash.FBI2,
            VehicleHash.FireTruck,
            VehicleHash.Lguard,
            VehicleHash.PBus,
            VehicleHash.Police,
            VehicleHash.Police2,
            VehicleHash.Police3,
            VehicleHash.Police4,
            VehicleHash.Policeb,
            VehicleHash.PoliceOld1,
            VehicleHash.PoliceOld2,
            VehicleHash.PoliceT,
            VehicleHash.Pranger,
            VehicleHash.Riot,
            VehicleHash.Sheriff,
            VehicleHash.Sheriff2
        };

        public static VehicleHash[] helicopters =
        {
            VehicleHash.Annihilator,
            VehicleHash.Buzzard,
            VehicleHash.Buzzard2,
            VehicleHash.Cargobob,
            VehicleHash.Cargobob2,
            VehicleHash.Cargobob3,
            VehicleHash.Cargobob4,
            VehicleHash.Frogger,
            VehicleHash.Frogger2,
            VehicleHash.Havok,
            VehicleHash.Hunter,
            VehicleHash.Maverick,
            VehicleHash.Polmav,
            VehicleHash.Savage,
            VehicleHash.SeaSparrow,
            VehicleHash.Skylift,
            VehicleHash.Supervolito,
            VehicleHash.Supervolito2,
            VehicleHash.Swift,
            VehicleHash.Swift2,
            VehicleHash.Valkyrie,
            VehicleHash.Valkyrie2,
            VehicleHash.Volatus

        };

        public static VehicleHash[] motorbikes =
        {
            VehicleHash.Akuma,
            VehicleHash.Avarus,
            VehicleHash.Bagger,
            VehicleHash.Bati,
            VehicleHash.Bati2,
            VehicleHash.BF400,
            VehicleHash.CarbonRS,
            VehicleHash.Chimera,
            VehicleHash.Cliffhanger,
            VehicleHash.Daemon,
            VehicleHash.Daemon2,
            VehicleHash.Defiler,
            VehicleHash.Diablous,
            VehicleHash.Diablous2,
            VehicleHash.Double,
            VehicleHash.Enduro,
            VehicleHash.Esskey,
            VehicleHash.Faggio,
            VehicleHash.Faggio2,
            VehicleHash.Faggio3,
            VehicleHash.FCR,
            VehicleHash.FCR2,
            VehicleHash.Gargoyle,
            VehicleHash.Hakuchou,
            VehicleHash.Hakuchou2,
            VehicleHash.Hexer,
            VehicleHash.Innovation,
            VehicleHash.Lectro,
            VehicleHash.Manchez,
            VehicleHash.Nemesis,
            VehicleHash.Nightblade,
            VehicleHash.Oppressor,
            VehicleHash.PCJ,
            VehicleHash.RatBike,
            VehicleHash.Ruffian,
            VehicleHash.Sanchez,
            VehicleHash.Sanchez2,
            VehicleHash.Sanctus,
            VehicleHash.Shotaro,
            VehicleHash.Sovereign,
            VehicleHash.Thrust,
            VehicleHash.Vader,
            VehicleHash.Vindicator,
            VehicleHash.Vortex,
            VehicleHash.Wolfsbane,
            VehicleHash.ZombieA,
            VehicleHash.ZombieB
        };

        public static VehicleHash[] military =
        {
            VehicleHash.HalfTrack,
            VehicleHash.Rhino,
            VehicleHash.Vigilante
        };

        public static VehicleHash[] muscle =
        {
            VehicleHash.Blade,
            VehicleHash.BType2,
            VehicleHash.Buccaneer,
            VehicleHash.Buccaneer2,
            VehicleHash.Chino,
            VehicleHash.Chino2,
            VehicleHash.Dominator,
            VehicleHash.Dominator2,
            VehicleHash.Dominator3,
            VehicleHash.Dukes,
            VehicleHash.Dukes2,
            VehicleHash.Ellie,
            VehicleHash.Faction3,
            VehicleHash.Gauntlet,
            VehicleHash.Gauntlet2,
            VehicleHash.Hotknife,
            VehicleHash.Minivan2,
            VehicleHash.Nightshade,
            VehicleHash.Phoenix,
            VehicleHash.Picador,
            VehicleHash.Ruiner,
            VehicleHash.SabreGT,
            VehicleHash.SabreGT2,
            VehicleHash.SlamVan,
            VehicleHash.SlamVan2,
            VehicleHash.SlamVan3,
            VehicleHash.Stalion,
            VehicleHash.Stalion2,
            VehicleHash.Tampa,
            VehicleHash.Tampa2,
            VehicleHash.Tampa3,
            VehicleHash.Tornado5,
            VehicleHash.Tornado6,
            VehicleHash.Vigero,
            VehicleHash.Virgo,
            VehicleHash.Virgo2,
            VehicleHash.Virgo3,
            VehicleHash.Voodoo,
            VehicleHash.Voodoo2,
        };

        public static VehicleHash[] offroad =
        {
            VehicleHash.BfInjection,
            VehicleHash.Bifta,
            VehicleHash.Blazer,
            VehicleHash.Blazer2,
            VehicleHash.Blazer3,
            VehicleHash.Blazer4,
            VehicleHash.Blazer5,
            VehicleHash.Bodhi2,
            VehicleHash.Brawler,
            VehicleHash.Caracara,
            VehicleHash.DLoader,
            VehicleHash.Dubsta3,
            VehicleHash.Dune,
            VehicleHash.Dune2,
            VehicleHash.Dune3,
            VehicleHash.Dune4,
            VehicleHash.Dune5,
            VehicleHash.Guardian,
            VehicleHash.Insurgent,
            VehicleHash.Insurgent2,
            VehicleHash.Insurgent3,
            VehicleHash.Kalahari,
            VehicleHash.Marshall,
            VehicleHash.Mesa3,
            VehicleHash.Monster,
            VehicleHash.NightShark,
            VehicleHash.RancherXL,
            VehicleHash.RancherXL2,
            VehicleHash.Rebel,
            VehicleHash.Rebel2,
            VehicleHash.Sandking,
            VehicleHash.Sandking2,
            VehicleHash.Technical,
            VehicleHash.Technical2,
            VehicleHash.Technical3,
            VehicleHash.TrophyTruck,
            VehicleHash.TrophyTruck2,
            VehicleHash.Wastelander
        };

        public static VehicleHash[] pickups =
        {
            VehicleHash.Bison,
            VehicleHash.Bison2,
            VehicleHash.Bison3,
            VehicleHash.BobcatXL,
            VehicleHash.Contender,
            VehicleHash.RatLoader,
            VehicleHash.RatLoader2,
            VehicleHash.Sadler,
            VehicleHash.Sadler2
        };

        public static VehicleHash[] planes =
        {
            VehicleHash.AlphaZ1,
            VehicleHash.Besra,
            VehicleHash.Blimp,
            VehicleHash.Blimp2,
            VehicleHash.Bombushka,
            VehicleHash.CargoPlane,
            VehicleHash.Cuban800,
            VehicleHash.Dodo,
            VehicleHash.Duster,
            VehicleHash.Howard,
            VehicleHash.Hydra,
            VehicleHash.Jet,
            VehicleHash.Lazer,
            VehicleHash.Luxor,
            VehicleHash.Luxor2,
            VehicleHash.Mammatus,
            VehicleHash.Microlight,
            VehicleHash.Miljet,
            VehicleHash.Mogul,
            VehicleHash.Molotok,
            VehicleHash.Nimbus,
            VehicleHash.Nokota,
            VehicleHash.Pyro,
            VehicleHash.Rogue,
            VehicleHash.Seabreeze,
            VehicleHash.Shamal,
            VehicleHash.Starling,
            VehicleHash.Stunt,
            VehicleHash.Titan,
            VehicleHash.Tula,
            VehicleHash.Velum,
            VehicleHash.Velum2,
            VehicleHash.Vestra,
        };

        public static VehicleHash[] suvs =
        {
            VehicleHash.Baller,
            VehicleHash.Baller2,
            VehicleHash.Baller3,
            VehicleHash.Baller4,
            VehicleHash.Baller5,
            VehicleHash.Baller6,
            VehicleHash.BJXL,
            VehicleHash.Cavalcade,
            VehicleHash.Cavalcade2,
            VehicleHash.Dubsta,
            VehicleHash.Dubsta2,
            VehicleHash.FQ2,
            VehicleHash.Granger,
            VehicleHash.Gresley,
            VehicleHash.Habanero,
            VehicleHash.Huntley,
            VehicleHash.Landstalker,
            VehicleHash.Mesa,
            VehicleHash.Mesa2,
            VehicleHash.Patriot,
            VehicleHash.Radi,
            VehicleHash.Rocoto,
            VehicleHash.Seminole,
            VehicleHash.Serrano,
            VehicleHash.XLS,
            VehicleHash.XLS2
        };

        public static VehicleHash[] sedans =
        {
            VehicleHash.Asea,
            VehicleHash.Asea2,
            VehicleHash.Asterope,
            VehicleHash.Cog55,
            VehicleHash.Cog552,
            VehicleHash.Cognoscenti,
            VehicleHash.Cognoscenti2,
            VehicleHash.Emperor,
            VehicleHash.Emperor2,
            VehicleHash.Emperor3,
            VehicleHash.Fugitive,
            VehicleHash.Glendale,
            VehicleHash.Ingot,
            VehicleHash.Intruder,
            VehicleHash.Limo2,
            VehicleHash.Oracle,
            VehicleHash.Oracle2,
            VehicleHash.Premier,
            VehicleHash.Primo,
            VehicleHash.Primo2,
            VehicleHash.Regina,
            VehicleHash.Romero,
            VehicleHash.Schafter2,
            VehicleHash.Schafter3,
            VehicleHash.Schafter4,
            VehicleHash.Schafter5,
            VehicleHash.Schafter6,
            VehicleHash.Stanier,
            VehicleHash.Stratum,
            VehicleHash.Stretch,
            VehicleHash.Superd,
            VehicleHash.Surge,
            VehicleHash.Tailgater,
            VehicleHash.Taxi,
            VehicleHash.Warrener,
            VehicleHash.Washington
        };

        public static VehicleHash[] service =
        {
            VehicleHash.Airbus,
            VehicleHash.Airtug,
            VehicleHash.Brickade,
            VehicleHash.Bulldozer,
            VehicleHash.Bus,
            VehicleHash.Caddy,
            VehicleHash.Caddy2,
            VehicleHash.Caddy3,
            VehicleHash.Coach,
            VehicleHash.Forklift,
            VehicleHash.Mower,
            VehicleHash.RentalBus,
            VehicleHash.Ripley,
            VehicleHash.Tourbus,
            VehicleHash.Tractor,
            VehicleHash.Tractor2,
            VehicleHash.Tractor3,
            VehicleHash.Trash,
            VehicleHash.Trash2,
            VehicleHash.UtilityTruck,
            VehicleHash.UtilityTruck2,
            VehicleHash.UtilityTruck3
        };

        public static VehicleHash[] sports =
        {
            VehicleHash.Alpha,
            VehicleHash.Banshee,
            VehicleHash.BestiaGTS,
            VehicleHash.Blista2,
            VehicleHash.Blista3,
            VehicleHash.Buffalo,
            VehicleHash.Buffalo2,
            VehicleHash.Buffalo3,
            VehicleHash.Carbonizzare,
            VehicleHash.Comet2,
            VehicleHash.Comet3,
            VehicleHash.Coquette,
            VehicleHash.Elegy,
            VehicleHash.Elegy2,
            VehicleHash.Feltzer2,
            VehicleHash.FlashGT,
            VehicleHash.Furoregt,
            VehicleHash.Fusilade,
            VehicleHash.Futo,
            VehicleHash.GB200,
            VehicleHash.HotringSabre,
            VehicleHash.Infernus2,
            VehicleHash.Jester,
            VehicleHash.Jester2,
            VehicleHash.Khamelion,
            VehicleHash.Kuruma,
            VehicleHash.Kuruma2,
            VehicleHash.Lynx,
            VehicleHash.Mamba,
            VehicleHash.Massacro,
            VehicleHash.Massacro2,
            VehicleHash.Ninef,
            VehicleHash.Ninef2,
            VehicleHash.Omnis,
            VehicleHash.Penumbra,
            VehicleHash.RapidGT,
            VehicleHash.RapidGT2,
            VehicleHash.Raptor,
            VehicleHash.Ruiner2,
            VehicleHash.Ruiner3,
            VehicleHash.Ruston,
            VehicleHash.Schwarzer,
            VehicleHash.Seven70,
            VehicleHash.Specter,
            VehicleHash.Specter2,
            VehicleHash.Sultan,
            VehicleHash.Surano,
            VehicleHash.Tropos,
            VehicleHash.Verlierer2
        };

        public static VehicleHash[] sportsClassic =
        {
            VehicleHash.Ardent,
            VehicleHash.BType,
            VehicleHash.BType3,
            VehicleHash.Casco,
            VehicleHash.Cheburek,
            VehicleHash.Cheetah2,
            VehicleHash.Coquette2,
            VehicleHash.Coquette3,
            VehicleHash.Fagaloa,
            VehicleHash.Feltzer3,
            VehicleHash.JB700,
            VehicleHash.Jester3,
            VehicleHash.Lurcher,
            VehicleHash.Manana,
            VehicleHash.Michelli,
            VehicleHash.Monroe,
            VehicleHash.Peyote,
            VehicleHash.Pigalle,
            VehicleHash.RapidGT3,
            VehicleHash.Retinue,
            VehicleHash.Stinger,
            VehicleHash.StingerGT,
            VehicleHash.Torero,
            VehicleHash.Tornado,
            VehicleHash.Tornado2,
            VehicleHash.Tornado3,
            VehicleHash.Tornado4,
            VehicleHash.ZType
        };

        public static VehicleHash[] super =
        {
            VehicleHash.Adder,
            VehicleHash.Banshee2,
            VehicleHash.Bullet,
            VehicleHash.Cheetah,
            VehicleHash.Cyclone,
            VehicleHash.EntityXXR,
            VehicleHash.EntityXF,
            VehicleHash.FMJ,
            VehicleHash.GP1,
            VehicleHash.Infernus,
            VehicleHash.ItaliGTB,
            VehicleHash.ItaliGTB2,
            VehicleHash.Nero,
            VehicleHash.Nero2,
            VehicleHash.Osiris,
            VehicleHash.Penetrator,
            VehicleHash.Pfister811,
            VehicleHash.Prototipo,
            VehicleHash.Reaper,
            VehicleHash.Sheava,
            VehicleHash.SultanRS,
            VehicleHash.T20,
            VehicleHash.Taipan,
            VehicleHash.Tempesta,
            VehicleHash.Tezeract,
            VehicleHash.Turismo2,
            VehicleHash.Turismor,
            VehicleHash.Tyrant,
            VehicleHash.Tyrus,
            VehicleHash.Vacca,
            VehicleHash.Vagner,
            VehicleHash.Visione,
            VehicleHash.Voltic,
            VehicleHash.Voltic2,
            VehicleHash.XA21,
            VehicleHash.Zentorno
        };

        public static VehicleHash[] trucks =
        {
            VehicleHash.Benson,
            VehicleHash.Biff,
            VehicleHash.Boxville,
            VehicleHash.Boxville2,
            VehicleHash.Boxville3,
            VehicleHash.Boxville4,
            VehicleHash.Boxville5,
            VehicleHash.Cutter,
            VehicleHash.Docktug,
            VehicleHash.Dump,
            VehicleHash.Flatbed,
            VehicleHash.Handler,
            VehicleHash.Hauler,
            VehicleHash.Mixer,
            VehicleHash.Mixer2,
            VehicleHash.Mule,
            VehicleHash.Mule2,
            VehicleHash.Mule3,
            VehicleHash.Packer,
            VehicleHash.Phantom,
            VehicleHash.Phantom2,
            VehicleHash.Pounder,
            VehicleHash.RallyTruck,
            VehicleHash.Rubble,
            VehicleHash.Scrap,
            VehicleHash.Stockade,
            VehicleHash.Stockade3,
            VehicleHash.TipTruck,
            VehicleHash.TipTruck2,
            VehicleHash.TowTruck,
            VehicleHash.TowTruck2,
            VehicleHash.Hauler2,
            VehicleHash.Phantom3
        };

        public static VehicleHash[] vans =
        {
            VehicleHash.Burrito,
            VehicleHash.Burrito2,
            VehicleHash.Burrito3,
            VehicleHash.Burrito4,
            VehicleHash.Burrito5,
            VehicleHash.Camper,
            VehicleHash.GBurrito,
            VehicleHash.GBurrito2,
            VehicleHash.Journey,
            VehicleHash.Minivan,
            VehicleHash.Moonbeam,
            VehicleHash.Moonbeam2,
            VehicleHash.Paradise, 
            VehicleHash.Pony,
            VehicleHash.Pony2,
            VehicleHash.Rumpo,
            VehicleHash.Rumpo2,
            VehicleHash.Rumpo3,
            VehicleHash.Speedo,
            VehicleHash.Speedo2,
            VehicleHash.Surfer,
            VehicleHash.Surfer2,
            VehicleHash.Taco,
            VehicleHash.Youga,
            VehicleHash.Youga2
        };

        public static List<List<VehicleHash>> GetVehicleList(bool specialClasses, bool useTrailers)
        {
            List<List<VehicleHash>> allVehicles = new List<List<VehicleHash>>();

            List<VehicleHash> vehiclesList = new List<VehicleHash>();
            List<VehicleHash> boatsList = new List<VehicleHash>();
            List<VehicleHash> planesList = new List<VehicleHash>();
            List<VehicleHash> helisList = new List<VehicleHash>();

            vehiclesList.AddRange(bicycles);
            vehiclesList.AddRange(compacts);
            vehiclesList.AddRange(coupes);
            vehiclesList.AddRange(emergency);
            vehiclesList.AddRange(motorbikes);
            vehiclesList.AddRange(military);
            vehiclesList.AddRange(muscle);
            vehiclesList.AddRange(offroad);
            vehiclesList.AddRange(pickups);
            vehiclesList.AddRange(suvs);
            vehiclesList.AddRange(sedans);
            vehiclesList.AddRange(service);
            vehiclesList.AddRange(sports);
            vehiclesList.AddRange(sportsClassic);
            vehiclesList.AddRange(super);
            vehiclesList.AddRange(trucks);
            vehiclesList.AddRange(vans);

            if (specialClasses)
            {
                boatsList.AddRange(boats);
                planesList.AddRange(planes);
                helisList.AddRange(helicopters);
            }
            else
            {
                vehiclesList.AddRange(boats);
                vehiclesList.AddRange(planes);
                vehiclesList.AddRange(helicopters);
            }

            if (useTrailers) vehiclesList.AddRange(trailers);

            allVehicles.Add(vehiclesList);
            allVehicles.Add(boatsList);
            allVehicles.Add(planesList);
            allVehicles.Add(helisList);
            return allVehicles;
        }

    }
}
