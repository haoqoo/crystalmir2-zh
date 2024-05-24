﻿using Server.MirEnvir;
using Server.MirObjects;

namespace Server.MirDatabase
{
    public class BuffInfo
    {
        public BuffType Type { get; set; }
        public BuffStackType StackType { get; set; }
        public BuffProperty Properties { get; set; }
        public int Icon { get; set; }
        public bool Visible { get; set; }

        public static List<BuffInfo> Load()
        {
            List<BuffInfo> info = new List<BuffInfo>
            {
                //Magics
                new BuffInfo { Type = BuffType.时间之殇, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration },
                new BuffInfo { Type = BuffType.隐身术, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration },
                new BuffInfo { Type = BuffType.体迅风, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration },
                new BuffInfo { Type = BuffType.轻身步, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.血龙剑法, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.幽灵盾, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration },
                new BuffInfo { Type = BuffType.神圣战甲术, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration },
                new BuffInfo { Type = BuffType.风身术, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration },
                new BuffInfo { Type = BuffType.无极真气, Properties = BuffProperty.None, StackType = BuffStackType.ResetStatAndDuration },
                new BuffInfo { Type = BuffType.护身气幕, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration },
                new BuffInfo { Type = BuffType.剑气爆, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration },
                new BuffInfo { Type = BuffType.诅咒术, Properties = BuffProperty.RemoveOnDeath | BuffProperty.Debuff, StackType = BuffStackType.ResetDuration },
                new BuffInfo { Type = BuffType.月影术, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.烈火身, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.气流术, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration },
                new BuffInfo { Type = BuffType.吸血地闪, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.毒魔闪, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.天务, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.精神状态, Properties = BuffProperty.None, StackType = BuffStackType.Infinite },
                new BuffInfo { Type = BuffType.先天气功, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.深延术, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.血龙水, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.金刚不坏, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.金刚不坏秘籍, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.天上秘术, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.魔法盾, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration },
                new BuffInfo { Type = BuffType.金刚术, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration },

                //Monsters
                new BuffInfo { Type = BuffType.HornedArcherBuff, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.ColdArcherBuff, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.HornedColdArcherBuff, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.GeneralMeowMeowShield, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.惩戒真言, Properties = BuffProperty.Debuff, StackType = BuffStackType.ResetDuration },
                new BuffInfo { Type = BuffType.御体之力, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.HornedWarriorShield, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.ChieftainSwordBuff, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
				new BuffInfo { Type = BuffType.HornedCommanderShield, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.Blindness, Properties = BuffProperty.RemoveOnDeath | BuffProperty.Debuff, StackType = BuffStackType.ResetDuration },
                new BuffInfo { Type = BuffType.寒冰护甲, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.ReaperPriestBuff, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.至尊威严, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.伤口加深, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.死亡印记, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.RiklebitesShield, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.麻痹状态, Properties = BuffProperty.Debuff, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.绝对封锁, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.Mon564NSealing, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },
                new BuffInfo { Type = BuffType.防御诅咒, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration, Visible = true },

                //Special
                new BuffInfo { Type = BuffType.游戏管理, Properties = BuffProperty.None, StackType = BuffStackType.Infinite, Visible = Settings.GameMasterEffect },
                new BuffInfo { Type = BuffType.衣钵相传, Properties = BuffProperty.None, StackType = BuffStackType.Infinite },
                new BuffInfo { Type = BuffType.火传穷薪, Properties = BuffProperty.None, StackType = BuffStackType.Infinite },
                new BuffInfo { Type = BuffType.公会特效, Properties = BuffProperty.None, StackType = BuffStackType.Infinite },
                new BuffInfo { Type = BuffType.技巧项链, Properties = BuffProperty.None, StackType = BuffStackType.Infinite },
                new BuffInfo { Type = BuffType.隐身戒指, Properties = BuffProperty.None, StackType = BuffStackType.Infinite },
                new BuffInfo { Type = BuffType.变形效果, Properties = BuffProperty.None, StackType = BuffStackType.None },
                new BuffInfo { Type = BuffType.心心相映, Properties = BuffProperty.RemoveOnExit, StackType = BuffStackType.Infinite },
                new BuffInfo { Type = BuffType.精力充沛, Properties = BuffProperty.None, StackType = BuffStackType.ResetDuration },
                new BuffInfo { Type = BuffType.Prison, Properties = BuffProperty.None, StackType = BuffStackType.None }, //???
                new BuffInfo { Type = BuffType.General, Properties = BuffProperty.None, StackType = BuffStackType.None }, //???
                new BuffInfo { Type = BuffType.英雄灵气, Properties = BuffProperty.None, StackType = BuffStackType.Infinite },
                new BuffInfo { Type = BuffType.暗影侵袭, Properties = BuffProperty.None, StackType = BuffStackType.Infinite },

                //Stats
                new BuffInfo { Type = BuffType.经验丰富, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.落物纷飞, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.金币辉煌, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.包罗万象, Properties = BuffProperty.None, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.火龍祝福, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.蓝魔之眼, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.冰龍祝福, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.眼疾手快, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.生命永驻, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.法力常在, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.防御之力, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.抗魔屏障, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.灵丹妙药, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.包容万金, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.精确命中, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.敏捷加身, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.潜心修炼, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration },
                new BuffInfo { Type = BuffType.龍之祝福, Properties = BuffProperty.PauseInSafeZone, StackType = BuffStackType.StackDuration }
            };

            return info;
        }
    }

    public class Buff
    {
        protected static Envir Envir
        {
            get { return Envir.Main; }
        }

        private Dictionary<string, object> Data { get; set; } = new Dictionary<string, object>();

        public BuffInfo Info;
        public MapObject Caster;
        public uint ObjectID;
        public long ExpireTime;

        public long LastTime, NextTime;

        public Stats Stats;

        public int[] Values;

        public bool FlagForRemoval;
        public bool Paused;

        public BuffType Type
        {
            get { return Info.Type; }
        }

        public BuffStackType StackType
        {
            get { return Info.StackType; }
        }

        public BuffProperty Properties
        {
            get { return Info.Properties; }
        }

        public Buff(BuffType type)
        {
            Info = Envir.GetBuffInfo(type);
            Stats = new Stats();
            Data = new Dictionary<string, object>();
        }

        public Buff(BinaryReader reader, int version, int customVersion)
        {
            var type = (BuffType)reader.ReadByte();

            Info = Envir.GetBuffInfo(type);

            Caster = null;

            if (version < 88)
            {
                var visible = reader.ReadBoolean();
            }

            ObjectID = reader.ReadUInt32();
            ExpireTime = reader.ReadInt64();

            if (version <= 84)
            {
                Values = new int[reader.ReadInt32()];

                for (int i = 0; i < Values.Length; i++)
                {
                    Values[i] = reader.ReadInt32();
                }

                if (version < 88)
                {
                    var infinite = reader.ReadBoolean();
                }

                Stats = new Stats();
                Data = new Dictionary<string, object>();
            }
            else
            {
                if (version < 88)
                {
                    var stackable = reader.ReadBoolean();
                }

                Values = new int[0];
                Stats = new Stats(reader, version, customVersion);
                Data = new Dictionary<string, object>();

                int count = reader.ReadInt32();

                for (int i = 0; i < count; i++)
                {
                    var key = reader.ReadString();
                    var length = reader.ReadInt32();

                    var array = new byte[length];

                    for (int j = 0; j < array.Length; j++)
                    {
                        array[j] = reader.ReadByte();
                    }

                    Data[key] = Functions.DeserializeFromBytes(array);
                }

                if (version > 86)
                {
                    count = reader.ReadInt32();

                    Values = new int[count];

                    for (int i = 0; i < count; i++)
                    {
                        Values[i] = reader.ReadInt32();
                    }
                }
            }
        }

        public void Save(BinaryWriter writer)
        {
            writer.Write((byte)Type);
            writer.Write(ObjectID);
            writer.Write(ExpireTime);

            Stats.Save(writer);

            writer.Write(Data.Count);

            foreach (KeyValuePair<string, object> pair in Data)
            {
                var bytes = Functions.SerializeToBytes(pair.Value);

                writer.Write(pair.Key);
                writer.Write(bytes.Length);

                for (int i = 0; i < bytes.Length; i++)
                {
                    writer.Write(bytes[i]);
                }
            }

            writer.Write(Values.Length);

            for (int i = 0; i < Values.Length; i++)
            {
                writer.Write(Values[i]);
            }
        }

        public T Get<T>(string key)
        {
            if (!Data.TryGetValue(key, out object result))
            {
                return default;
            }

            return (T)result;
        }

        public void Set(string key, object val)
        {
            Data[key] = val;
        }

        public ClientBuff ToClientBuff()
        {
            return new ClientBuff
            {
                Type = Type,
                Caster = Caster?.Name ?? "",
                ObjectID = ObjectID,
                Visible = Info.Visible,
                Infinite = StackType == BuffStackType.Infinite,
                Paused = Paused,
                ExpireTime = ExpireTime,
                Stats = new Stats(Stats),
                Values = Values
            };
        }
    }
}
