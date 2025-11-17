using System;
using System.Collections.Generic;

namespace CTManip
{
    public class ManipList
    {
        private Dictionary<ManipNames, Func<Manip>> manipNameToFunc;

        public Manip GetManipByValue(ManipNames name)
        {
            if (manipNameToFunc.TryGetValue(name, out var manipFunc))
            {
                return manipFunc();
            }
            throw new ArgumentException("Error, manip value not in list", nameof(name));
        }
        
        public ManipList()
        {
            manipNameToFunc = new Dictionary<ManipNames, Func<Manip>>
            {
                { ManipNames.NewGame, NewGameCT },
                { ManipNames.Nagas, Nagas },
                { ManipNames.Zombor, Zombor },
                { ManipNames.Masamune, SealedCaveFF4 },
                { ManipNames.Nizbel, RainbowPudding },
                { ManipNames.Flea, Flea },
                { ManipNames.Magus, Magus },
                { ManipNames.BlackTyranno, BlackTyranno },
                { ManipNames.WoeRubble, WoeRubble },
                { ManipNames.GolemTwins, Octomammoth },
                { ManipNames.Ghosts, Ghosts},
                { ManipNames.RustRubbles, RustRubbles },
                { ManipNames.RustTyranno, RustTyranno },
                { ManipNames.SonOfSun, SonOfSun },
                { ManipNames.YakraXIII, RainbowPudding },
                { ManipNames.BlackOmen, BlackOmen },
                { ManipNames.LavosShell, LavosShell },
                { ManipNames.LavosCore, LavosCore },
                // BaseRNG mappings
                { ManipNames.BaseRNG_01, BaseRNG_01 }, { ManipNames.BaseRNG_02, BaseRNG_02 }, { ManipNames.BaseRNG_03, BaseRNG_03 }, { ManipNames.BaseRNG_04, BaseRNG_04 },
                { ManipNames.BaseRNG_05, BaseRNG_05 }, { ManipNames.BaseRNG_06, BaseRNG_06 }, { ManipNames.BaseRNG_07, BaseRNG_07 }, { ManipNames.BaseRNG_08, BaseRNG_08 },
                { ManipNames.BaseRNG_09, BaseRNG_09 }, { ManipNames.BaseRNG_0A, BaseRNG_0A }, { ManipNames.BaseRNG_0B, BaseRNG_0B }, { ManipNames.BaseRNG_0C, BaseRNG_0C },
                { ManipNames.BaseRNG_0D, BaseRNG_0D }, { ManipNames.BaseRNG_0E, BaseRNG_0E }, { ManipNames.BaseRNG_0F, BaseRNG_0F }, { ManipNames.BaseRNG_10, BaseRNG_10 },
                { ManipNames.BaseRNG_11, BaseRNG_11 }, { ManipNames.BaseRNG_12, BaseRNG_12 }, { ManipNames.BaseRNG_13, BaseRNG_13 }, { ManipNames.BaseRNG_14, BaseRNG_14 },
                { ManipNames.BaseRNG_15, BaseRNG_15 }, { ManipNames.BaseRNG_16, BaseRNG_16 }, { ManipNames.BaseRNG_17, BaseRNG_17 }, { ManipNames.BaseRNG_18, BaseRNG_18 },
                { ManipNames.BaseRNG_19, BaseRNG_19 }, { ManipNames.BaseRNG_1A, BaseRNG_1A }, { ManipNames.BaseRNG_1B, BaseRNG_1B }, { ManipNames.BaseRNG_1C, BaseRNG_1C },
                { ManipNames.BaseRNG_1D, BaseRNG_1D }, { ManipNames.BaseRNG_1E, BaseRNG_1E }, { ManipNames.BaseRNG_1F, BaseRNG_1F }, { ManipNames.BaseRNG_20, BaseRNG_20 },
                { ManipNames.BaseRNG_21, BaseRNG_21 }, { ManipNames.BaseRNG_22, BaseRNG_22 }, { ManipNames.BaseRNG_23, BaseRNG_23 }, { ManipNames.BaseRNG_24, BaseRNG_24 },
                { ManipNames.BaseRNG_25, BaseRNG_25 }, { ManipNames.BaseRNG_26, BaseRNG_26 }, { ManipNames.BaseRNG_27, BaseRNG_27 }, { ManipNames.BaseRNG_28, BaseRNG_28 },
                { ManipNames.BaseRNG_29, BaseRNG_29 }, { ManipNames.BaseRNG_2A, BaseRNG_2A }, { ManipNames.BaseRNG_2B, BaseRNG_2B }, { ManipNames.BaseRNG_2C, BaseRNG_2C },
                { ManipNames.BaseRNG_2D, BaseRNG_2D }, { ManipNames.BaseRNG_2E, BaseRNG_2E }, { ManipNames.BaseRNG_2F, BaseRNG_2F }, { ManipNames.BaseRNG_30, BaseRNG_30 },
                { ManipNames.BaseRNG_31, BaseRNG_31 }, { ManipNames.BaseRNG_32, BaseRNG_32 }, { ManipNames.BaseRNG_33, BaseRNG_33 }, { ManipNames.BaseRNG_34, BaseRNG_34 },
                { ManipNames.BaseRNG_35, BaseRNG_35 }, { ManipNames.BaseRNG_36, BaseRNG_36 }, { ManipNames.BaseRNG_37, BaseRNG_37 }, { ManipNames.BaseRNG_38, BaseRNG_38 },
                { ManipNames.BaseRNG_39, BaseRNG_39 }, { ManipNames.BaseRNG_3A, BaseRNG_3A }, { ManipNames.BaseRNG_3B, BaseRNG_3B }, { ManipNames.BaseRNG_3C, BaseRNG_3C },
                { ManipNames.BaseRNG_3D, BaseRNG_3D }, { ManipNames.BaseRNG_3E, BaseRNG_3E }, { ManipNames.BaseRNG_3F, BaseRNG_3F }, { ManipNames.BaseRNG_40, BaseRNG_40 },
                { ManipNames.BaseRNG_41, BaseRNG_41 }, { ManipNames.BaseRNG_42, BaseRNG_42 }, { ManipNames.BaseRNG_43, BaseRNG_43 }, { ManipNames.BaseRNG_44, BaseRNG_44 },
                { ManipNames.BaseRNG_45, BaseRNG_45 }, { ManipNames.BaseRNG_46, BaseRNG_46 }, { ManipNames.BaseRNG_47, BaseRNG_47 }, { ManipNames.BaseRNG_48, BaseRNG_48 },
                { ManipNames.BaseRNG_49, BaseRNG_49 }, { ManipNames.BaseRNG_4A, BaseRNG_4A }, { ManipNames.BaseRNG_4B, BaseRNG_4B }, { ManipNames.BaseRNG_4C, BaseRNG_4C },
                { ManipNames.BaseRNG_4D, BaseRNG_4D }, { ManipNames.BaseRNG_4E, BaseRNG_4E }, { ManipNames.BaseRNG_4F, BaseRNG_4F }, { ManipNames.BaseRNG_50, BaseRNG_50 },
                { ManipNames.BaseRNG_51, BaseRNG_51 }, { ManipNames.BaseRNG_52, BaseRNG_52 }, { ManipNames.BaseRNG_53, BaseRNG_53 }, { ManipNames.BaseRNG_54, BaseRNG_54 },
                { ManipNames.BaseRNG_55, BaseRNG_55 }, { ManipNames.BaseRNG_56, BaseRNG_56 }, { ManipNames.BaseRNG_57, BaseRNG_57 }, { ManipNames.BaseRNG_58, BaseRNG_58 },
                { ManipNames.BaseRNG_59, BaseRNG_59 }, { ManipNames.BaseRNG_5A, BaseRNG_5A }, { ManipNames.BaseRNG_5B, BaseRNG_5B }, { ManipNames.BaseRNG_5C, BaseRNG_5C },
                { ManipNames.BaseRNG_5D, BaseRNG_5D }, { ManipNames.BaseRNG_5E, BaseRNG_5E }, { ManipNames.BaseRNG_5F, BaseRNG_5F }, { ManipNames.BaseRNG_60, BaseRNG_60 },
                { ManipNames.BaseRNG_61, BaseRNG_61 }, { ManipNames.BaseRNG_62, BaseRNG_62 }, { ManipNames.BaseRNG_63, BaseRNG_63 }, { ManipNames.BaseRNG_64, BaseRNG_64 },
                { ManipNames.BaseRNG_65, BaseRNG_65 }, { ManipNames.BaseRNG_66, BaseRNG_66 }, { ManipNames.BaseRNG_67, BaseRNG_67 }, { ManipNames.BaseRNG_68, BaseRNG_68 },
                { ManipNames.BaseRNG_69, BaseRNG_69 }, { ManipNames.BaseRNG_6A, BaseRNG_6A }, { ManipNames.BaseRNG_6B, BaseRNG_6B }, { ManipNames.BaseRNG_6C, BaseRNG_6C },
                { ManipNames.BaseRNG_6D, BaseRNG_6D }, { ManipNames.BaseRNG_6E, BaseRNG_6E }, { ManipNames.BaseRNG_6F, BaseRNG_6F }, { ManipNames.BaseRNG_70, BaseRNG_70 },
                { ManipNames.BaseRNG_71, BaseRNG_71 }, { ManipNames.BaseRNG_72, BaseRNG_72 }, { ManipNames.BaseRNG_73, BaseRNG_73 }, { ManipNames.BaseRNG_74, BaseRNG_74 },
                { ManipNames.BaseRNG_75, BaseRNG_75 }, { ManipNames.BaseRNG_76, BaseRNG_76 }, { ManipNames.BaseRNG_77, BaseRNG_77 }, { ManipNames.BaseRNG_78, BaseRNG_78 },
                { ManipNames.BaseRNG_79, BaseRNG_79 }, { ManipNames.BaseRNG_7A, BaseRNG_7A }, { ManipNames.BaseRNG_7B, BaseRNG_7B }, { ManipNames.BaseRNG_7C, BaseRNG_7C },
                { ManipNames.BaseRNG_7D, BaseRNG_7D }, { ManipNames.BaseRNG_7E, BaseRNG_7E }, { ManipNames.BaseRNG_7F, BaseRNG_7F }, { ManipNames.BaseRNG_80, BaseRNG_80 },
                { ManipNames.BaseRNG_81, BaseRNG_81 }, { ManipNames.BaseRNG_82, BaseRNG_82 }, { ManipNames.BaseRNG_83, BaseRNG_83 }, { ManipNames.BaseRNG_84, BaseRNG_84 },
                { ManipNames.BaseRNG_85, BaseRNG_85 }, { ManipNames.BaseRNG_86, BaseRNG_86 }, { ManipNames.BaseRNG_87, BaseRNG_87 }, { ManipNames.BaseRNG_88, BaseRNG_88 },
                { ManipNames.BaseRNG_89, BaseRNG_89 }, { ManipNames.BaseRNG_8A, BaseRNG_8A }, { ManipNames.BaseRNG_8B, BaseRNG_8B }, { ManipNames.BaseRNG_8C, BaseRNG_8C },
                { ManipNames.BaseRNG_8D, BaseRNG_8D }, { ManipNames.BaseRNG_8E, BaseRNG_8E }, { ManipNames.BaseRNG_8F, BaseRNG_8F }, { ManipNames.BaseRNG_90, BaseRNG_90 },
                { ManipNames.BaseRNG_91, BaseRNG_91 }, { ManipNames.BaseRNG_92, BaseRNG_92 }, { ManipNames.BaseRNG_93, BaseRNG_93 }, { ManipNames.BaseRNG_94, BaseRNG_94 },
                { ManipNames.BaseRNG_95, BaseRNG_95 }, { ManipNames.BaseRNG_96, BaseRNG_96 }, { ManipNames.BaseRNG_97, BaseRNG_97 }, { ManipNames.BaseRNG_98, BaseRNG_98 },
                { ManipNames.BaseRNG_99, BaseRNG_99 }, { ManipNames.BaseRNG_9A, BaseRNG_9A }, { ManipNames.BaseRNG_9B, BaseRNG_9B }, { ManipNames.BaseRNG_9C, BaseRNG_9C },
                { ManipNames.BaseRNG_9D, BaseRNG_9D }, { ManipNames.BaseRNG_9E, BaseRNG_9E }, { ManipNames.BaseRNG_9F, BaseRNG_9F }, { ManipNames.BaseRNG_A0, BaseRNG_A0 },
                { ManipNames.BaseRNG_A1, BaseRNG_A1 }, { ManipNames.BaseRNG_A2, BaseRNG_A2 }, { ManipNames.BaseRNG_A3, BaseRNG_A3 }, { ManipNames.BaseRNG_A4, BaseRNG_A4 },
                { ManipNames.BaseRNG_A5, BaseRNG_A5 }, { ManipNames.BaseRNG_A6, BaseRNG_A6 }, { ManipNames.BaseRNG_A7, BaseRNG_A7 }, { ManipNames.BaseRNG_A8, BaseRNG_A8 },
                { ManipNames.BaseRNG_A9, BaseRNG_A9 }, { ManipNames.BaseRNG_AA, BaseRNG_AA }, { ManipNames.BaseRNG_AB, BaseRNG_AB }, { ManipNames.BaseRNG_AC, BaseRNG_AC },
                { ManipNames.BaseRNG_AD, BaseRNG_AD }, { ManipNames.BaseRNG_AE, BaseRNG_AE }, { ManipNames.BaseRNG_AF, BaseRNG_AF }, { ManipNames.BaseRNG_B0, BaseRNG_B0 },
                { ManipNames.BaseRNG_B1, BaseRNG_B1 }, { ManipNames.BaseRNG_B2, BaseRNG_B2 }, { ManipNames.BaseRNG_B3, BaseRNG_B3 }, { ManipNames.BaseRNG_B4, BaseRNG_B4 },
                { ManipNames.BaseRNG_B5, BaseRNG_B5 }, { ManipNames.BaseRNG_B6, BaseRNG_B6 }, { ManipNames.BaseRNG_B7, BaseRNG_B7 }, { ManipNames.BaseRNG_B8, BaseRNG_B8 },
                { ManipNames.BaseRNG_B9, BaseRNG_B9 }, { ManipNames.BaseRNG_BA, BaseRNG_BA }, { ManipNames.BaseRNG_BB, BaseRNG_BB }, { ManipNames.BaseRNG_BC, BaseRNG_BC },
                { ManipNames.BaseRNG_BD, BaseRNG_BD }, { ManipNames.BaseRNG_BE, BaseRNG_BE }, { ManipNames.BaseRNG_BF, BaseRNG_BF }, { ManipNames.BaseRNG_C0, BaseRNG_C0 },
                { ManipNames.BaseRNG_C1, BaseRNG_C1 }, { ManipNames.BaseRNG_C2, BaseRNG_C2 }, { ManipNames.BaseRNG_C3, BaseRNG_C3 }, { ManipNames.BaseRNG_C4, BaseRNG_C4 },
                { ManipNames.BaseRNG_C5, BaseRNG_C5 }, { ManipNames.BaseRNG_C6, BaseRNG_C6 }, { ManipNames.BaseRNG_C7, BaseRNG_C7 }, { ManipNames.BaseRNG_C8, BaseRNG_C8 },
                { ManipNames.BaseRNG_C9, BaseRNG_C9 }, { ManipNames.BaseRNG_CA, BaseRNG_CA }, { ManipNames.BaseRNG_CB, BaseRNG_CB }, { ManipNames.BaseRNG_CC, BaseRNG_CC },
                { ManipNames.BaseRNG_CD, BaseRNG_CD }, { ManipNames.BaseRNG_CE, BaseRNG_CE }, { ManipNames.BaseRNG_CF, BaseRNG_CF }, { ManipNames.BaseRNG_D0, BaseRNG_D0 },
                { ManipNames.BaseRNG_D1, BaseRNG_D1 }, { ManipNames.BaseRNG_D2, BaseRNG_D2 }, { ManipNames.BaseRNG_D3, BaseRNG_D3 }, { ManipNames.BaseRNG_D4, BaseRNG_D4 },
                { ManipNames.BaseRNG_D5, BaseRNG_D5 }, { ManipNames.BaseRNG_D6, BaseRNG_D6 }, { ManipNames.BaseRNG_D7, BaseRNG_D7 }, { ManipNames.BaseRNG_D8, BaseRNG_D8 },
                { ManipNames.BaseRNG_D9, BaseRNG_D9 }, { ManipNames.BaseRNG_DA, BaseRNG_DA }, { ManipNames.BaseRNG_DB, BaseRNG_DB }, { ManipNames.BaseRNG_DC, BaseRNG_DC },
                { ManipNames.BaseRNG_DD, BaseRNG_DD }, { ManipNames.BaseRNG_DE, BaseRNG_DE }, { ManipNames.BaseRNG_DF, BaseRNG_DF }, { ManipNames.BaseRNG_E0, BaseRNG_E0 },
                { ManipNames.BaseRNG_E1, BaseRNG_E1 }, { ManipNames.BaseRNG_E2, BaseRNG_E2 }, { ManipNames.BaseRNG_E3, BaseRNG_E3 }, { ManipNames.BaseRNG_E4, BaseRNG_E4 },
                { ManipNames.BaseRNG_E5, BaseRNG_E5 }, { ManipNames.BaseRNG_E6, BaseRNG_E6 }, { ManipNames.BaseRNG_E7, BaseRNG_E7 }, { ManipNames.BaseRNG_E8, BaseRNG_E8 },
                { ManipNames.BaseRNG_E9, BaseRNG_E9 }, { ManipNames.BaseRNG_EA, BaseRNG_EA }, { ManipNames.BaseRNG_EB, BaseRNG_EB }, { ManipNames.BaseRNG_EC, BaseRNG_EC },
                { ManipNames.BaseRNG_ED, BaseRNG_ED }, { ManipNames.BaseRNG_EE, BaseRNG_EE }, { ManipNames.BaseRNG_EF, BaseRNG_EF }, { ManipNames.BaseRNG_F0, BaseRNG_F0 },
                { ManipNames.BaseRNG_F1, BaseRNG_F1 }, { ManipNames.BaseRNG_F2, BaseRNG_F2 }, { ManipNames.BaseRNG_F3, BaseRNG_F3 }, { ManipNames.BaseRNG_F4, BaseRNG_F4 },
                { ManipNames.BaseRNG_F5, BaseRNG_F5 }, { ManipNames.BaseRNG_F6, BaseRNG_F6 }, { ManipNames.BaseRNG_F7, BaseRNG_F7 }, { ManipNames.BaseRNG_F8, BaseRNG_F8 },
                { ManipNames.BaseRNG_F9, BaseRNG_F9 }, { ManipNames.BaseRNG_FA, BaseRNG_FA }, { ManipNames.BaseRNG_FB, BaseRNG_FB }, { ManipNames.BaseRNG_FC, BaseRNG_FC },
                { ManipNames.BaseRNG_FD, BaseRNG_FD }, { ManipNames.BaseRNG_FE, BaseRNG_FE }, { ManipNames.BaseRNG_FF, BaseRNG_FF }
            };
        }

        public enum ManipNames
        {
            NewGame,
            Nagas,
            Zombor,
            Masamune,
            Nizbel,
            Flea,
            Magus,
            Nizbel2,
            BlackTyranno,
            MudImp,
            WoeRubble,
            GolemTwins,
            Ghosts,
            RustRubbles,
            RustTyranno,
            SonOfSun,
            YakraXIII,
            BlackOmen,
            LavosShell,
            LavosCore,
            // BaseRNG values from 01 to FF
            BaseRNG_01, BaseRNG_02, BaseRNG_03, BaseRNG_04, BaseRNG_05, BaseRNG_06, BaseRNG_07, BaseRNG_08,
            BaseRNG_09, BaseRNG_0A, BaseRNG_0B, BaseRNG_0C, BaseRNG_0D, BaseRNG_0E, BaseRNG_0F, BaseRNG_10,
            BaseRNG_11, BaseRNG_12, BaseRNG_13, BaseRNG_14, BaseRNG_15, BaseRNG_16, BaseRNG_17, BaseRNG_18,
            BaseRNG_19, BaseRNG_1A, BaseRNG_1B, BaseRNG_1C, BaseRNG_1D, BaseRNG_1E, BaseRNG_1F, BaseRNG_20,
            BaseRNG_21, BaseRNG_22, BaseRNG_23, BaseRNG_24, BaseRNG_25, BaseRNG_26, BaseRNG_27, BaseRNG_28,
            BaseRNG_29, BaseRNG_2A, BaseRNG_2B, BaseRNG_2C, BaseRNG_2D, BaseRNG_2E, BaseRNG_2F, BaseRNG_30,
            BaseRNG_31, BaseRNG_32, BaseRNG_33, BaseRNG_34, BaseRNG_35, BaseRNG_36, BaseRNG_37, BaseRNG_38,
            BaseRNG_39, BaseRNG_3A, BaseRNG_3B, BaseRNG_3C, BaseRNG_3D, BaseRNG_3E, BaseRNG_3F, BaseRNG_40,
            BaseRNG_41, BaseRNG_42, BaseRNG_43, BaseRNG_44, BaseRNG_45, BaseRNG_46, BaseRNG_47, BaseRNG_48,
            BaseRNG_49, BaseRNG_4A, BaseRNG_4B, BaseRNG_4C, BaseRNG_4D, BaseRNG_4E, BaseRNG_4F, BaseRNG_50,
            BaseRNG_51, BaseRNG_52, BaseRNG_53, BaseRNG_54, BaseRNG_55, BaseRNG_56, BaseRNG_57, BaseRNG_58,
            BaseRNG_59, BaseRNG_5A, BaseRNG_5B, BaseRNG_5C, BaseRNG_5D, BaseRNG_5E, BaseRNG_5F, BaseRNG_60,
            BaseRNG_61, BaseRNG_62, BaseRNG_63, BaseRNG_64, BaseRNG_65, BaseRNG_66, BaseRNG_67, BaseRNG_68,
            BaseRNG_69, BaseRNG_6A, BaseRNG_6B, BaseRNG_6C, BaseRNG_6D, BaseRNG_6E, BaseRNG_6F, BaseRNG_70,
            BaseRNG_71, BaseRNG_72, BaseRNG_73, BaseRNG_74, BaseRNG_75, BaseRNG_76, BaseRNG_77, BaseRNG_78,
            BaseRNG_79, BaseRNG_7A, BaseRNG_7B, BaseRNG_7C, BaseRNG_7D, BaseRNG_7E, BaseRNG_7F, BaseRNG_80,
            BaseRNG_81, BaseRNG_82, BaseRNG_83, BaseRNG_84, BaseRNG_85, BaseRNG_86, BaseRNG_87, BaseRNG_88,
            BaseRNG_89, BaseRNG_8A, BaseRNG_8B, BaseRNG_8C, BaseRNG_8D, BaseRNG_8E, BaseRNG_8F, BaseRNG_90,
            BaseRNG_91, BaseRNG_92, BaseRNG_93, BaseRNG_94, BaseRNG_95, BaseRNG_96, BaseRNG_97, BaseRNG_98,
            BaseRNG_99, BaseRNG_9A, BaseRNG_9B, BaseRNG_9C, BaseRNG_9D, BaseRNG_9E, BaseRNG_9F, BaseRNG_A0,
            BaseRNG_A1, BaseRNG_A2, BaseRNG_A3, BaseRNG_A4, BaseRNG_A5, BaseRNG_A6, BaseRNG_A7, BaseRNG_A8,
            BaseRNG_A9, BaseRNG_AA, BaseRNG_AB, BaseRNG_AC, BaseRNG_AD, BaseRNG_AE, BaseRNG_AF, BaseRNG_B0,
            BaseRNG_B1, BaseRNG_B2, BaseRNG_B3, BaseRNG_B4, BaseRNG_B5, BaseRNG_B6, BaseRNG_B7, BaseRNG_B8,
            BaseRNG_B9, BaseRNG_BA, BaseRNG_BB, BaseRNG_BC, BaseRNG_BD, BaseRNG_BE, BaseRNG_BF, BaseRNG_C0,
            BaseRNG_C1, BaseRNG_C2, BaseRNG_C3, BaseRNG_C4, BaseRNG_C5, BaseRNG_C6, BaseRNG_C7, BaseRNG_C8,
            BaseRNG_C9, BaseRNG_CA, BaseRNG_CB, BaseRNG_CC, BaseRNG_CD, BaseRNG_CE, BaseRNG_CF, BaseRNG_D0,
            BaseRNG_D1, BaseRNG_D2, BaseRNG_D3, BaseRNG_D4, BaseRNG_D5, BaseRNG_D6, BaseRNG_D7, BaseRNG_D8,
            BaseRNG_D9, BaseRNG_DA, BaseRNG_DB, BaseRNG_DC, BaseRNG_DD, BaseRNG_DE, BaseRNG_DF, BaseRNG_E0,
            BaseRNG_E1, BaseRNG_E2, BaseRNG_E3, BaseRNG_E4, BaseRNG_E5, BaseRNG_E6, BaseRNG_E7, BaseRNG_E8,
            BaseRNG_E9, BaseRNG_EA, BaseRNG_EB, BaseRNG_EC, BaseRNG_ED, BaseRNG_EE, BaseRNG_EF, BaseRNG_F0,
            BaseRNG_F1, BaseRNG_F2, BaseRNG_F3, BaseRNG_F4, BaseRNG_F5, BaseRNG_F6, BaseRNG_F7, BaseRNG_F8,
            BaseRNG_F9, BaseRNG_FA, BaseRNG_FB, BaseRNG_FC, BaseRNG_FD, BaseRNG_FE, BaseRNG_FF
        }

        // CT
        
        private Manip NewGameCT() { return new Manip(ManipController.TimeZones.CEST, 24, 10, 2021, 16, 20, 01); }
        private Manip Nagas() { return new Manip(ManipController.TimeZones.CEST, 24, 10, 2021, 16, 20, 00); }
        private Manip Masamune() {return new Manip(ManipController.TimeZones.GMT, 18, 11, 23, 8, 6, 20); }  
        private Manip Flea() { return new Manip(ManipController.TimeZones.CEST, 24, 10, 2021, 16, 20, 01); }
        private Manip Zombor() { return new Manip(ManipController.TimeZones.CEST, 24, 10, 2021, 16, 20, 01); }
        private Manip Magus() { return new Manip(ManipController.TimeZones.CEST, 24, 10, 2021, 16, 20, 01); }
        private Manip BlackTyranno() { return new Manip(ManipController.TimeZones.CEST, 24, 10, 2021, 16, 20, 01); }
        private Manip MudImp() { return new Manip(ManipController.TimeZones.CEST, 02, 05, 24, 09, 48, 09); }
        private Manip WoeRubble() { return new Manip(ManipController.TimeZones.CEST, 24, 10, 2021, 16, 20, 01); }
        private Manip Ghosts() { return new Manip(ManipController.TimeZones.CEST, 05, 04, 24, 19, 35, 12); }
        private Manip RustRubbles() { return new Manip(ManipController.TimeZones.CEST, 24, 10, 2021, 16, 20, 00); }
        private Manip RustTyranno() { return new Manip(ManipController.TimeZones.GMT, 10, 04, 21, 19, 43, 18); }      
        private Manip SonOfSun() { return new Manip(ManipController.TimeZones.CEST, 29, 05, 25, 19, 24, 01); }
        private Manip BlackOmen() { return new Manip(ManipController.TimeZones.CEST, 15, 03, 25, 14, 09, 01); }
        private Manip LavosShell() { return new Manip(ManipController.TimeZones.CEST, 24, 10, 2021, 16, 20, 01); }
        private Manip LavosCore() { return new Manip(ManipController.TimeZones.CEST, 29, 03, 25, 12, 16, 32); }
        



        // FF3
        private Manip AltarCave() { return new Manip(ManipController.TimeZones.GMT, 10, 04, 21, 19, 43, 17); }
        private Manip SealedCave() { return new Manip(ManipController.TimeZones.CEST, 02, 05, 24, 09, 48, 08); }
        private Manip DragonsPeak() { return new Manip(ManipController.TimeZones.CEST, 02, 05, 24, 11, 42, 36); }
        private Manip TozusTunnel() { return new Manip(ManipController.TimeZones.CEST, 02, 05, 24, 11, 57, 50); }
        private Manip ToTowerOfOwen() { return new Manip(ManipController.TimeZones.CEST, 02, 05, 24, 13, 15, 41); }
        private Manip TowenOfOwen() { return new Manip(ManipController.TimeZones.CEST, 17, 02, 24, 10, 00, 07); }
        private Manip SubterraneanLake() { return new Manip(ManipController.TimeZones.CEST, 30, 04, 24, 13, 01, 56); }
        private Manip MoltenCave() { return new Manip(ManipController.TimeZones.CEST, 21, 02, 24, 12, 51, 32); }
        private Manip HeinCastle() { return new Manip(ManipController.TimeZones.CEST, 11, 02, 24, 13, 10, 42); }
        private Manip CaveOfTides() { return new Manip(ManipController.TimeZones.CEST, 02, 05, 24, 18, 14, 42); }
        private Manip Sewers() { return new Manip(ManipController.TimeZones.CEST, 03, 05, 24, 12, 02, 16); }
        private Manip ChocoboWrath() { return new Manip(ManipController.TimeZones.CEST, 14, 10, 23, 11, 04, 04); }
        private Manip GoldorManor() { return new Manip(ManipController.TimeZones.CEST, 05, 05, 24, 10, 21, 39); }
        private Manip Garuda() { return new Manip(ManipController.TimeZones.CEST, 15, 10, 23, 12, 37, 19); }
        private Manip CaveOfTheCircle() { return new Manip(ManipController.TimeZones.CEST, 15, 10, 23, 13, 07, 36); }
        private Manip SaroniaCatacombs() { return new Manip(ManipController.TimeZones.CEST, 05, 05, 24, 13, 08, 20); }
        private Manip AncientsMaze() { return new Manip(ManipController.TimeZones.CEST, 05, 04, 24, 19, 35, 15); }
        private Manip CaveOfShadows() { return new Manip(ManipController.TimeZones.CEST, 23, 01, 24, 12, 07, 14); }
        private Manip ShiningCurtain() { return new Manip(ManipController.TimeZones.CEST, 01, 04, 24, 18, 30, 13); }
        private Manip DogasGrotto() { return new Manip(ManipController.TimeZones.CEST, 16, 10, 23, 10, 50, 57); }
        private Manip ToXande() { return new Manip(ManipController.TimeZones.CEST, 21, 10, 23, 21, 35, 31); }
        private Manip WorldOfDarkness() { return new Manip(ManipController.TimeZones.CEST, 28, 10, 23, 14, 58, 25); }
        private Manip CloudOfDarkness() { return new Manip(ManipController.TimeZones.CEST, 04, 04, 24, 12, 36, 49); }

        // FF4
        private Manip NewGame() { return new Manip(ManipController.TimeZones.CEST, 24, 10, 2021, 16, 20, 00); }
        private Manip Octomammoth() { return new Manip(ManipController.TimeZones.CEST, 15, 03, 25, 14, 09, 00); }
        private Manip MysidiaOrdeals() { return new Manip(ManipController.TimeZones.CEST, 24, 04, 2021, 16, 20, 08); }
        private Manip RainbowPudding() { return new Manip(ManipController.TimeZones.CEST, 29, 03, 25, 12, 16, 31); }
        private Manip Underworld() { return new Manip(ManipController.TimeZones.CEST, 29, 05, 25, 19, 24, 00); }
        private Manip Lugae() { return new Manip(ManipController.TimeZones.CEST, 01, 03, 25, 23, 31, 31); }
        private Manip BabilRubi() { return new Manip(ManipController.TimeZones.CEST, 24, 04, 2021, 16, 20, 17); }
        private Manip SealedCaveFF4() {return new Manip(ManipController.TimeZones.CEST, 09, 06, 25, 13, 33, 26); }
        private Manip SafeTravel() { return new Manip(ManipController.TimeZones.CEST, 11, 05, 2021, 16, 45, 00); }
        private Manip DragonOneCycle() { return new Manip(ManipController.TimeZones.CEST, 25, 05, 25, 11, 55, 22); }
        private Manip PinkTail() { return new Manip(ManipController.TimeZones.CEST, 24, 04, 2021, 16, 20, 27); }

        // CT BaseRNG values
        private Manip BaseRNG_01() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 25); }
        private Manip BaseRNG_02() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 09); }
        private Manip BaseRNG_03() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 53); }
        private Manip BaseRNG_04() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 22, 26); }
        private Manip BaseRNG_05() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 37); }
        private Manip BaseRNG_06() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 21); }
        private Manip BaseRNG_07() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 27); }
        private Manip BaseRNG_08() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 19, 49); }
        private Manip BaseRNG_09() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 44); }
        private Manip BaseRNG_0A() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 06); }
        private Manip BaseRNG_0B() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 50); }
        private Manip BaseRNG_0C() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 23); }
        private Manip BaseRNG_0D() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 18, 45); }
        private Manip BaseRNG_0E() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 23, 40); }
        private Manip BaseRNG_0F() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 51); }
        private Manip BaseRNG_10() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 35); }
        private Manip BaseRNG_11() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 08); }
        private Manip BaseRNG_12() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 21, 03); }
        private Manip BaseRNG_13() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 25, 58); }
        private Manip BaseRNG_14() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 47); }
        private Manip BaseRNG_15() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 31); }
        private Manip BaseRNG_16() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 04); }
        private Manip BaseRNG_17() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 19, 59); }
        private Manip BaseRNG_18() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 54); }
        private Manip BaseRNG_19() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 16); }
        private Manip BaseRNG_1A() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 00); }
        private Manip BaseRNG_1B() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 17, 22); }
        private Manip BaseRNG_1C() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 18, 55); }
        private Manip BaseRNG_1D() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 25, 39); }
        private Manip BaseRNG_1E() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 01); }
        private Manip BaseRNG_1F() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 45); }
        private Manip BaseRNG_20() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 18); }
        private Manip BaseRNG_21() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 17, 51); }
        private Manip BaseRNG_22() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 35); }
        private Manip BaseRNG_23() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 57); }
        private Manip BaseRNG_24() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 41); }
        private Manip BaseRNG_25() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 14); }
        private Manip BaseRNG_26() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 09); }
        private Manip BaseRNG_27() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 26, 53); }
        private Manip BaseRNG_28() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 15); }
        private Manip BaseRNG_29() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 26); }
        private Manip BaseRNG_2A() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 10); }
        private Manip BaseRNG_2B() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 19, 05); }
        private Manip BaseRNG_2C() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 25, 49); }
        private Manip BaseRNG_2D() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 22); }
        private Manip BaseRNG_2E() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 55); }
        private Manip BaseRNG_2F() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 28); }
        private Manip BaseRNG_30() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 21, 23); }
        private Manip BaseRNG_31() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 45); }
        private Manip BaseRNG_32() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 07); }
        private Manip BaseRNG_33() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 51); }
        private Manip BaseRNG_34() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 24); }
        private Manip BaseRNG_35() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 19); }
        private Manip BaseRNG_36() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 23, 41); }
        private Manip BaseRNG_37() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 25); }
        private Manip BaseRNG_38() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 36); }
        private Manip BaseRNG_39() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 20); }
        private Manip BaseRNG_3A() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 21, 04); }
        private Manip BaseRNG_3B() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 22, 37); }
        private Manip BaseRNG_3C() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 21); }
        private Manip BaseRNG_3D() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 32); }
        private Manip BaseRNG_3E() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 38); }
        private Manip BaseRNG_3F() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 00); }
        private Manip BaseRNG_40() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 55); }
        private Manip BaseRNG_41() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 17); }
        private Manip BaseRNG_42() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 01); }
        private Manip BaseRNG_43() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 34); }
        private Manip BaseRNG_44() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 22, 18); }
        private Manip BaseRNG_45() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 23, 51); }
        private Manip BaseRNG_46() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 30, 35); }
        private Manip BaseRNG_47() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 46); }
        private Manip BaseRNG_48() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 30); }
        private Manip BaseRNG_49() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 21, 14); }
        private Manip BaseRNG_4A() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 22, 47); }
        private Manip BaseRNG_4B() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 58); }
        private Manip BaseRNG_4C() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 42); }
        private Manip BaseRNG_4D() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 48); }
        private Manip BaseRNG_4E() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 10); }
        private Manip BaseRNG_4F() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 25, 05); }
        private Manip BaseRNG_50() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 27); }
        private Manip BaseRNG_51() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 11); }
        private Manip BaseRNG_52() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 44); }
        private Manip BaseRNG_53() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 19, 06); }
        private Manip BaseRNG_54() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 01); }
        private Manip BaseRNG_55() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 23); }
        private Manip BaseRNG_56() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 56); }
        private Manip BaseRNG_57() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 29); }
        private Manip BaseRNG_58() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 18, 02); }
        private Manip BaseRNG_59() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 46); }
        private Manip BaseRNG_5A() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 08); }
        private Manip BaseRNG_5B() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 52); }
        private Manip BaseRNG_5C() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 25); }
        private Manip BaseRNG_5D() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 20); }
        private Manip BaseRNG_5E() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 25, 15); }
        private Manip BaseRNG_5F() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 26); }
        private Manip BaseRNG_60() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 21); }
        private Manip BaseRNG_61() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 17, 43); }
        private Manip BaseRNG_62() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 19, 16); }
        private Manip BaseRNG_63() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 26, 00); }
        private Manip BaseRNG_64() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 33); }
        private Manip BaseRNG_65() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 06); }
        private Manip BaseRNG_66() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 39); }
        private Manip BaseRNG_67() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 18, 12); }
        private Manip BaseRNG_68() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 56); }
        private Manip BaseRNG_69() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 18); }
        private Manip BaseRNG_6A() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 02); }
        private Manip BaseRNG_6B() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 35); }
        private Manip BaseRNG_6C() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 30); }
        private Manip BaseRNG_6D() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 23, 52); }
        private Manip BaseRNG_6E() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 36); }
        private Manip BaseRNG_6F() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 47); }
        private Manip BaseRNG_70() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 31); }
        private Manip BaseRNG_71() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 19, 26); }
        private Manip BaseRNG_72() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 26, 10); }
        private Manip BaseRNG_73() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 32); }
        private Manip BaseRNG_74() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 43); }
        private Manip BaseRNG_75() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 27); }
        private Manip BaseRNG_76() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 11); }
        private Manip BaseRNG_77() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 25, 06); }
        private Manip BaseRNG_78() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 28); }
        private Manip BaseRNG_79() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 12); }
        private Manip BaseRNG_7A() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 45); }
        private Manip BaseRNG_7B() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 40); }
        private Manip BaseRNG_7C() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 02); }
        private Manip BaseRNG_7D() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 24); }
        private Manip BaseRNG_7E() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 57); }
        private Manip BaseRNG_7F() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 41); }
        private Manip BaseRNG_80() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 21, 25); }
        private Manip BaseRNG_81() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 22, 58); }
        private Manip BaseRNG_82() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 42); }
        private Manip BaseRNG_83() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 53); }
        private Manip BaseRNG_84() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 59); }
        private Manip BaseRNG_85() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 21); }
        private Manip BaseRNG_86() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 25, 16); }
        private Manip BaseRNG_87() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 38); }
        private Manip BaseRNG_88() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 22); }
        private Manip BaseRNG_89() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 55); }
        private Manip BaseRNG_8A() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 19, 17); }
        private Manip BaseRNG_8B() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 12); }
        private Manip BaseRNG_8C() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 34); }
        private Manip BaseRNG_8D() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 07); }
        private Manip BaseRNG_8E() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 40); }
        private Manip BaseRNG_8F() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 21, 35); }
        private Manip BaseRNG_90() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 23, 08); }
        private Manip BaseRNG_91() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 19); }
        private Manip BaseRNG_92() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 03); }
        private Manip BaseRNG_93() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 36); }
        private Manip BaseRNG_94() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 31); }
        private Manip BaseRNG_95() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 25, 26); }
        private Manip BaseRNG_96() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 48); }
        private Manip BaseRNG_97() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 32); }
        private Manip BaseRNG_98() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 17, 54); }
        private Manip BaseRNG_99() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 19, 27); }
        private Manip BaseRNG_9A() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 22); }
        private Manip BaseRNG_9B() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 44); }
        private Manip BaseRNG_9C() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 28); }
        private Manip BaseRNG_9D() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 50); }
        private Manip BaseRNG_9E() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 18, 23); }
        private Manip BaseRNG_9F() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 25, 07); }
        private Manip BaseRNG_A0() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 29); }
        private Manip BaseRNG_A1() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 13); }
        private Manip BaseRNG_A2() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 46); }
        private Manip BaseRNG_A3() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 41); }
        private Manip BaseRNG_A4() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 03); }
        private Manip BaseRNG_A5() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 25); }
        private Manip BaseRNG_A6() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 58); }
        private Manip BaseRNG_A7() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 42); }
        private Manip BaseRNG_A8() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 19, 37); }
        private Manip BaseRNG_A9() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 26, 21); }
        private Manip BaseRNG_AA() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 43); }
        private Manip BaseRNG_AB() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 38); }
        private Manip BaseRNG_AC() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 17, 00); }
        private Manip BaseRNG_AD() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 22); }
        private Manip BaseRNG_AE() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 25, 17); }
        private Manip BaseRNG_AF() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 39); }
        private Manip BaseRNG_B0() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 23); }
        private Manip BaseRNG_B1() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 56); }
        private Manip BaseRNG_B2() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 51); }
        private Manip BaseRNG_B3() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 13); }
        private Manip BaseRNG_B4() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 35); }
        private Manip BaseRNG_B5() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 08); }
        private Manip BaseRNG_B6() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 52); }
        private Manip BaseRNG_B7() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 21, 36); }
        private Manip BaseRNG_B8() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 23, 09); }
        private Manip BaseRNG_B9() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 53); }
        private Manip BaseRNG_BA() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 04); }
        private Manip BaseRNG_BB() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 48); }
        private Manip BaseRNG_BC() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 32); }
        private Manip BaseRNG_BD() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 25, 27); }
        private Manip BaseRNG_BE() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 49); }
        private Manip BaseRNG_BF() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 33); }
        private Manip BaseRNG_C0() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 06); }
        private Manip BaseRNG_C1() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 19, 28); }
        private Manip BaseRNG_C2() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 23); }
        private Manip BaseRNG_C3() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 45); }
        private Manip BaseRNG_C4() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 29); }
        private Manip BaseRNG_C5() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 02); }
        private Manip BaseRNG_C6() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 21, 46); }
        private Manip BaseRNG_C7() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 23, 19); }
        private Manip BaseRNG_C8() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 30, 03); }
        private Manip BaseRNG_C9() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 14); }
        private Manip BaseRNG_CA() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 47); }
        private Manip BaseRNG_CB() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 42); }
        private Manip BaseRNG_CC() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 25, 37); }
        private Manip BaseRNG_CD() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 26); }
        private Manip BaseRNG_CE() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 43); }
        private Manip BaseRNG_CF() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 16); }
        private Manip BaseRNG_D0() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 19, 38); }
        private Manip BaseRNG_D1() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 33); }
        private Manip BaseRNG_D2() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 55); }
        private Manip BaseRNG_D3() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 39); }
        private Manip BaseRNG_D4() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 17, 01); }
        private Manip BaseRNG_D5() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 18, 34); }
        private Manip BaseRNG_D6() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 25, 18); }
        private Manip BaseRNG_D7() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 40); }
        private Manip BaseRNG_D8() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 24); }
        private Manip BaseRNG_D9() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 57); }
        private Manip BaseRNG_DA() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 52); }
        private Manip BaseRNG_DB() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 14); }
        private Manip BaseRNG_DC() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 36); }
        private Manip BaseRNG_DD() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 20); }
        private Manip BaseRNG_DE() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 53); }
        private Manip BaseRNG_DF() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 19, 48); }
        private Manip BaseRNG_E0() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 26, 32); }
        private Manip BaseRNG_E1() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 05); }
        private Manip BaseRNG_E2() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 49); }
        private Manip BaseRNG_E3() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 17, 11); }
        private Manip BaseRNG_E4() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 18, 44); }
        private Manip BaseRNG_E5() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 25, 28); }
        private Manip BaseRNG_E6() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 50); }
        private Manip BaseRNG_E7() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 34); }
        private Manip BaseRNG_E8() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 07); }
        private Manip BaseRNG_E9() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 21, 02); }
        private Manip BaseRNG_EA() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 24); }
        private Manip BaseRNG_EB() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 46); }
        private Manip BaseRNG_EC() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 30); }
        private Manip BaseRNG_ED() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 03); }
        private Manip BaseRNG_EE() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 19, 58); }
        private Manip BaseRNG_EF() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 23, 20); }
        private Manip BaseRNG_F0() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 04); }
        private Manip BaseRNG_F1() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 15); }
        private Manip BaseRNG_F2() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 59); }
        private Manip BaseRNG_F3() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 20, 43); }
        private Manip BaseRNG_F4() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 25, 38); }
        private Manip BaseRNG_F5() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 00); }
        private Manip BaseRNG_F6() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 14, 44); }
        private Manip BaseRNG_F7() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 16, 17); }
        private Manip BaseRNG_F8() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 19, 39); }
        private Manip BaseRNG_F9() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 24, 34); }
        private Manip BaseRNG_FA() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 56); }
        private Manip BaseRNG_FB() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 13, 40); }
        private Manip BaseRNG_FC() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 15, 13); }
        private Manip BaseRNG_FD() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 21, 57); }
        private Manip BaseRNG_FE() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 23, 30); }
        private Manip BaseRNG_FF() { return new Manip(ManipController.TimeZones.ET, 14, 11, 2023, 17, 30, 14); }
    }
}   