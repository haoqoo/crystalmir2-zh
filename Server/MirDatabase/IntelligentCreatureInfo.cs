﻿using Server.MirEnvir;

namespace Server.MirDatabase
{
    public class IntelligentCreatureInfo
    {
        protected static Envir Envir
        {
            get { return Envir.Main; }
        }

        public static List<IntelligentCreatureInfo> Creatures = new List<IntelligentCreatureInfo>();

        public IntelligentCreatureType PetType;

        public int Icon;
        public int MinimalFullness = 1000;

        public bool MousePickupEnabled = false;
        public int MousePickupRange = 0;
        public bool AutoPickupEnabled = false;
        public int AutoPickupRange = 0;
        public bool SemiAutoPickupEnabled = false;
        public int SemiAutoPickupRange = 0;

        public bool CanProduceBlackStone = false;

        static IntelligentCreatureInfo()
        {
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.小猪, Icon = 500, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 3, MinimalFullness = 4000 };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.小鸡, Icon = 501, MousePickupEnabled = true, MousePickupRange = 11, AutoPickupEnabled = true, AutoPickupRange = 7, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 7, CanProduceBlackStone = true };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.小猫, Icon = 502, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 3, MinimalFullness = 6000 };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.精灵骷髅, Icon = 503, MousePickupEnabled = true, MousePickupRange = 11, AutoPickupEnabled = true, AutoPickupRange = 7, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 7, CanProduceBlackStone = true };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.白猪, Icon = 504, MousePickupEnabled = true, MousePickupRange = 11, AutoPickupEnabled = true, AutoPickupRange = 7, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 7, CanProduceBlackStone = true };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.纸片人, Icon = 505, MousePickupEnabled = true, MousePickupRange = 7, AutoPickupEnabled = true, AutoPickupRange = 5, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 5, MinimalFullness = 5000 };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.黑猫, Icon = 506, MousePickupEnabled = true, MousePickupRange = 7, AutoPickupEnabled = true, AutoPickupRange = 5, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 5, MinimalFullness = 5000 };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.龙蛋, Icon = 507, MousePickupEnabled = true, MousePickupRange = 7, AutoPickupEnabled = true, AutoPickupRange = 5, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 5, MinimalFullness = 7000 };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.火娃, Icon = 508, MousePickupEnabled = true, MousePickupRange = 11, AutoPickupEnabled = true, AutoPickupRange = 11, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 11, CanProduceBlackStone = true };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.雪人, Icon = 509, MousePickupEnabled = true, MousePickupRange = 11, AutoPickupEnabled = true, AutoPickupRange = 11, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 11, CanProduceBlackStone = true };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.青蛙, Icon = 510, MousePickupEnabled = true, MousePickupRange = 11, AutoPickupEnabled = true, AutoPickupRange = 11, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 11, CanProduceBlackStone = true };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.红猴, Icon = 511, MousePickupEnabled = true, MousePickupRange = 11, AutoPickupEnabled = true, AutoPickupRange = 11, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 11, CanProduceBlackStone = true };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.愤怒的小鸟, Icon = 512, MousePickupEnabled = true, MousePickupRange = 11, AutoPickupEnabled = true, AutoPickupRange = 11, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 11, CanProduceBlackStone = true };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.阿福, Icon = 513, MousePickupEnabled = true, MousePickupRange = 11, AutoPickupEnabled = true, AutoPickupRange = 11, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 11, CanProduceBlackStone = true };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.治疗拉拉, Icon = 514, MousePickupEnabled = true, MousePickupRange = 11, AutoPickupEnabled = true, AutoPickupRange = 11, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 11, CanProduceBlackStone = true };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.猫咪超人, Icon = 515, MousePickupEnabled = true, MousePickupRange = 11, AutoPickupEnabled = true, AutoPickupRange = 11, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 11, CanProduceBlackStone = true };
            new IntelligentCreatureInfo { PetType = IntelligentCreatureType.龙宝宝, Icon = 516, MousePickupEnabled = true, MousePickupRange = 11, AutoPickupEnabled = true, AutoPickupRange = 11, SemiAutoPickupEnabled = true, SemiAutoPickupRange = 11, CanProduceBlackStone = true };            
}

        public IntelligentCreatureInfo()
        {
            Creatures.Add(this);
        }

        public static IntelligentCreatureInfo GetCreatureInfo(IntelligentCreatureType petType)
        {
            for (int i = 0; i < Creatures.Count; i++)
            {
                IntelligentCreatureInfo info = Creatures[i];
                if (info.PetType != petType) continue;
                return info;
            }
            return null;
        }
    }

    public class UserIntelligentCreature
    {
        protected static Envir Envir
        {
            get { return Envir.Main; }
        }

        public IntelligentCreatureType PetType;
        public IntelligentCreatureInfo Info;
        public IntelligentCreatureItemFilter Filter;

        public IntelligentCreaturePickupMode petMode = IntelligentCreaturePickupMode.SemiAutomatic;

        public string CustomName;
        public int Fullness;
        public int SlotIndex;
        public DateTime Expire;
        public long BlackstoneTime = 0;
        public long MaintainFoodTime = 0;

        public UserIntelligentCreature(IntelligentCreatureType creatureType, int slot, byte effect = 0)
        {
            PetType = creatureType;
            Info = IntelligentCreatureInfo.GetCreatureInfo(PetType);
            CustomName = Envir.Main.GetMonsterInfo(64, (byte)PetType)?.Name ?? PetType.ToString();
            Fullness = 7500;//starts at 75% food
            SlotIndex = slot;

            if (effect > 0) Expire = Envir.Now.AddDays(effect);//effect holds the amount in days
            else Expire = DateTime.MinValue;//permanent

            BlackstoneTime = 0;
            MaintainFoodTime = 0;

            Filter = new IntelligentCreatureItemFilter();
        }

        public UserIntelligentCreature(BinaryReader reader, int version, int customVersion)
        {
            PetType = (IntelligentCreatureType)reader.ReadByte();
            Info = IntelligentCreatureInfo.GetCreatureInfo(PetType);

            CustomName = reader.ReadString();
            Fullness = reader.ReadInt32();
            SlotIndex = reader.ReadInt32();

            var expireTime = reader.ReadInt64();

            if (expireTime == -9999)
            {
                Expire = DateTime.MinValue;
            }
            else
            {
                Expire = Envir.Now.AddSeconds(expireTime);
            }

            BlackstoneTime = reader.ReadInt64();

            petMode = (IntelligentCreaturePickupMode)reader.ReadByte();

            Filter = new IntelligentCreatureItemFilter(reader);
            if (version > 48)
            {
                Filter.PickupGrade = (ItemGrade)reader.ReadByte();

                MaintainFoodTime = reader.ReadInt64();//maintain food buff
            }
        }

        public void Save(BinaryWriter writer)
        {
            writer.Write((byte)PetType);

            writer.Write(CustomName);
            writer.Write(Fullness);
            writer.Write(SlotIndex);

            if (Expire == DateTime.MinValue)
            {
                writer.Write((long)-9999);
            }
            else
            {
                writer.Write((long)(Expire - Envir.Now).TotalSeconds);
            }

            writer.Write(BlackstoneTime);

            writer.Write((byte)petMode);

            Filter.Save(writer);
            writer.Write((byte)Filter.PickupGrade);//since Envir.Version 49

            writer.Write(MaintainFoodTime);//maintain food buff

        }

        public Packet GetInfo()
        {
            return new ServerPackets.NewIntelligentCreature
            {
                Creature = CreateClientIntelligentCreature()
            };
        }

        public ClientIntelligentCreature CreateClientIntelligentCreature()
        {
            return new ClientIntelligentCreature
            {
                PetType = PetType,
                Icon = Info.Icon,
                CustomName = CustomName,
                Fullness = Fullness,
                SlotIndex = SlotIndex,
                Expire = Expire,
                BlackstoneTime = BlackstoneTime,
                MaintainFoodTime = MaintainFoodTime,

                petMode = petMode,

                CreatureRules = new IntelligentCreatureRules
                {
                    MinimalFullness = Info.MinimalFullness,
                    MousePickupEnabled = Info.MousePickupEnabled,
                    MousePickupRange = Info.MousePickupRange,
                    AutoPickupEnabled = Info.AutoPickupEnabled,
                    AutoPickupRange = Info.AutoPickupRange,
                    SemiAutoPickupEnabled = Info.SemiAutoPickupEnabled,
                    SemiAutoPickupRange = Info.SemiAutoPickupRange,
                    CanProduceBlackStone = Info.CanProduceBlackStone
                },

                Filter = Filter
            };
        }
    }
}
