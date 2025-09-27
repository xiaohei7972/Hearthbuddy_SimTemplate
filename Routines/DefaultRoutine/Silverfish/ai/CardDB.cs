using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace HREngine.Bots
{
    public partial class CardDB
    {
        /// <summary>
        /// <value> 卡牌类型 </value>
        /// </summary>
        public enum cardtype
        {
            NONE = 0,
            GAME = 1,
            PLAYER = 2,
            HERO = 3,//英雄
            MOB = 4,//随从
            SPELL = 5,//法术
            ENCHANTMENT = 6,//增幅（例如：变形术，救赎，力量的代价，自然之力的附加效果）
            WEAPON = 7,//武器
            ITEM = 8,
            TOKEN = 9,
            HEROPWR = 10,//英雄技能
            BLANK = 11,
            GAME_MODE_BUTTON = 12,
            MOVE_MINION_HOVER_TARGET = 22,
            LETTUCE_ABILITY,
            BATTLEGROUND_HERO_BUDDY,//战旗伙伴
            LOCATION = 39,//地标
            BATTLEGROUND_QUEST_REWARD,//战旗奖励
            BATTLEGROUND_ANOMALY = 43,//战旗畸变
            BATTLEGROUND_SPELL = 42,//战旗法术
            BATTLEGROUND_TRINKET = 44,//战旗饰品
        }

        /// <summary>
        /// 卡片效果
        /// </summary>
        public enum cardtrigers
        {
            /// <summary>
            /// 新触发
            /// </summary>
            newtriger,
            /// <summary>
            /// 战吼效果
            /// </summary>
            getBattlecryEffect,
            /// <summary>
            /// 一个英雄受到伤害触发
            /// </summary>
            onAHeroGotHealedTrigger,
            /// <summary>
            /// 随从受到伤害触发
            /// </summary>
            onAMinionGotHealedTrigger,//随从受到伤害触发
            /// <summary>
            /// 光环消失
            /// </summary>
            onAuraEnds,
            /// <summary>
            ///  光环开始
            /// </summary>
            onAuraStarts,
            /// <summary>
            /// 卡片即将使用
            /// </summary>
            onCardIsGoingToBePlayed,
            /// <summary>
            /// 卡片使用
            /// </summary>
            onCardPlay,
            /// <summary>
            /// 卡片使用后
            /// </summary>
            onCardWasPlayed,
            /// <summary>
            /// 亡语
            /// </summary>
            onDeathrattle,
            /// <summary>
            /// 激怒开始
            /// </summary>
            onEnrageStart,
            /// <summary>
            /// 激怒结束
            /// </summary>
            onEnrageStop,
            /// <summary>
            /// 随从死亡触发
            /// </summary>
            onMinionDiedTrigger,
            /// <summary>
            /// 随从受到伤害触发
            /// </summary>
            onMinionGotDmgTrigger,
            /// <summary>
            /// 随从被召唤
            /// </summary>
            onMinionIsSummoned,
            /// <summary>
            /// 随从召唤过
            /// </summary>
            onMinionWasSummoned,
            /// <summary>
            /// 奥秘使用
            /// </summary>
            onSecretPlay,
            /// <summary>
            /// 回合结束触发
            /// </summary>
            onTurnEndsTrigger,
            /// <summary>
            /// 回合开始触发
            /// </summary>
            onTurnStartTrigger,
            /// <summary>
            /// 触发激发
            /// </summary>
            triggerInspire,
            /// <summary>
            /// 超杀
            /// </summary>
            OnOverkill,
            /// <summary>
            /// 荣耀击杀
            /// </summary>
            OnHonorableKill,
            /// <summary>
            /// 消灭
            /// </summary>
            xiaomie,
            /// <summary>
            /// 回合开始
            /// </summary>
            onTurnStart,
            /// <summary>
            /// 回合结束
            /// </summary>
            onTurnEnd,
            /// <summary>
            /// 使用地标
            /// </summary>
            useLocation,
            /// <summary>
            /// 使用泰坦技能
            /// </summary>
            useTitanAbility,
            /// <summary>
            /// 当本随从攻击时
            /// </summary>
            onMinionAttack,
            /// <summary>
            /// 当本随从攻击后
            /// </summary>
            afterMinionAttack,
            /// <summary>
            /// 当随从牌打出后
            /// </summary>
            onCardIsAfterToBePlayed,
        }

        /// <summary>
        /// <value> 法术派系 </value>
        /// </summary>
        public enum SpellSchool
        {   /// <summary>
            /// <value> 法术派系 </value>
            /// </summary>
            NONE = 0,
            /// <summary>
            /// <value> 奥术 </value>
            /// </summary>
            ARCANE = 1,
            /// <summary>
            /// <value> 火焰 </value>
            /// </summary>
            FIRE = 2,
            /// <summary>
            /// <value> 冰霜 </value>
            /// </summary>
            FROST = 3,
            /// <summary>
            /// <value> 自然 </value>
            /// </summary>
            NATURE = 4,
            /// <summary>
            /// <value> 神圣 </value>
            /// </summary>
            HOLY = 5,
            /// <summary>
            /// <value> 暗影 </value>
            /// </summary>
            SHADOW = 6,
            /// <summary>
            /// <value> 邪能 </value>
            /// </summary>
            FEL = 7,
            /// <summary>
            /// <value> 无法术派系 </value>
            /// </summary>
            PHYSICAL_COMBAT = 8,
        }

        /// <summary>
        /// <value> 种族 </value>
        /// </summary>
        public enum Race
        {
            INVALID = 0,
            /// <summary>
            /// <value> 血精灵 </value>
            /// </summary>
            BLOODELF = 1,
            /// <summary>
            /// <value> 德莱尼 </value>
            /// </summary>
            DRAENEI = 2,
            /// <summary>
            /// <value> 矮人 </value>
            /// </summary>
            DWARF = 3,
            /// <summary>
            /// <value> 侏儒 </value>
            /// </summary>
            GNOME = 4,
            /// <summary>
            /// <value> 地精 </value>
            /// </summary>
            GOBLIN = 5,
            /// <summary>
            /// <value> 人类 </value>
            /// </summary>
            HUMAN = 6,
            /// <summary>
            /// <value> 暗夜精灵 </value>
            /// </summary>
            NIGHTELF = 7,
            /// <summary>
            /// <value> 兽人 </value>
            /// </summary>
            ORC = 8,
            /// <summary>
            /// <value> 牛头人 </value>
            /// </summary>
            TAUREN = 9,
            /// <summary>
            /// <value> 巨魔 </value>
            /// </summary>
            TROLL = 10,
            /// <summary>
            /// <value> 亡灵 </value>
            /// </summary>
            UNDEAD = 11,
            /// <summary>
            /// <value> 狼人 </value>
            /// </summary>
            WORGEN = 12,
            /// <summary>
            /// <value> 地精2 </value>
            /// </summary>
            GOBLIN2 = 13,
            /// <summary>
            /// <value> 鱼人 </value>
            /// </summary>
            MURLOC = 14,
            /// <summary>
            /// <value> 恶魔 </value>
            /// </summary>
            DEMON = 15,
            /// <summary>
            /// <value> 天灾 </value>
            /// </summary>
            SCOURGE = 16,
            /// <summary>
            /// <value> 机械 </value>
            /// </summary>
            MECHANICAL = 17,
            /// <summary>
            /// <value> 元素 </value>
            /// </summary>
            ELEMENTAL = 18,
            /// <summary>
            /// <value> 食人魔 </value>
            /// </summary>
            OGRE = 19,
            /// <summary>
            /// <value> 野兽 </value>
            /// </summary>
            PET = 20,
            /// <summary>
            /// <value> 图腾 </value>
            /// </summary>
            TOTEM = 21,
            /// <summary>
            /// <value> 蛛魔 </value>
            /// </summary>
            NERUBIAN = 22,
            /// <summary>
            /// <value> 海盗 </value>
            /// </summary>
            PIRATE = 23,
            /// <summary>
            /// <value> 龙 </value>
            /// </summary>
            DRAGON = 24,
            /// <summary>
            /// <value> 无种族 </value>
            /// </summary>
            BLANK = 25,
            /// <summary>
            /// <value> 全部 </value>
            /// </summary>
            ALL = 26,
            /// <summary>
            /// <value> 蛋  </value>
            /// </summary>
            EGG = 38,
            /// <summary>
            /// <value> 野猪人 </value>
            /// </summary>
            QUILBOAR = 43,
            /// <summary>
            /// <value> 纳迦 </value>
            /// </summary>
            NAGA = 92,
        }

        /// <summary>
        /// 输入卡牌中文名，输出Card类对象，多个同名，返回第一个
        /// </summary>
        /// <param name="chnName"></param>
        /// <returns></returns>
        public Card chnNameToCard(string chnName)
        {
            Card c;
            cardNameCN enumCn;
            if (Enum.TryParse(chnName, out enumCn) && cardNameCNToCardList.TryGetValue(enumCn, out c))
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 输入卡牌id，输出cardIDEnum枚举对象
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public cardIDEnum cardIdstringToEnum(string s)
        {
            CardDB.cardIDEnum CardEnum;
            if (Enum.TryParse<cardIDEnum>(s, false, out CardEnum)) return CardEnum;
            else
            {
                return CardDB.cardIDEnum.None;
            }
        }

        /// <summary>
        /// 输入卡牌英文名，输出cardNameEN枚举对象
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public cardNameEN cardNameENstringToEnum(string s)
        {
            CardDB.cardNameEN NameEnum;
            if (Enum.TryParse<cardNameEN>(s, false, out NameEnum)) return NameEnum;
            else return CardDB.cardNameEN.unknown;
        }

        /// <summary>
        /// 输入卡牌英文名，输出cardNameCN枚举对象
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public cardNameCN cardNameENstringToEnumCN(string s)
        {
            CardDB.cardNameEN NameEnum;
            if (Enum.TryParse<cardNameEN>(s, false, out NameEnum))
            {
                Card card = getCardData(NameEnum);
                return card.nameCN;
            }
            else
            {
                return CardDB.cardNameCN.未知;
            }
            ;
        }

        /// <summary>
        /// 输入卡牌中文名，输出cardNameCN枚举对象
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public cardNameCN cardNameCNstringToEnum(string s)
        {
            CardDB.cardNameCN NameEnum;
            if (Enum.TryParse<cardNameCN>(s, false, out NameEnum)) return NameEnum;
            else return CardDB.cardNameCN.未知;
        }

        /// <summary>
        /// 输入种族英文名,输出Race枚举对象
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public Race raceNameStringToEnum(string s)
        {
            CardDB.Race NameEnum;
            if (Enum.TryParse<Race>(s, false, out NameEnum)) return NameEnum;
            else return CardDB.Race.BLANK;
        }

        /// <summary>
        /// 输入种族英文名,输出SpellSchool枚举对象
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public SpellSchool spellSchoolNameStringToEnum(string s)
        {
            CardDB.SpellSchool NameEnum;
            if (Enum.TryParse<SpellSchool>(s, false, out NameEnum)) return NameEnum;
            else return CardDB.SpellSchool.PHYSICAL_COMBAT;
        }



        /// <summary>
        /// <value> 异常类型 </value>
        /// </summary>
        public enum ErrorType2
        {
            /// <summary>
            /// <value> 无效的 </value>
            /// </summary>
            INVALID = -1,
            /// <summary>
            /// <value> 异常类型 </value>
            /// </summary>
            NONE = 0,
            /// <summary>
            /// <value> 目标只能是随从 </value>
            /// </summary>
            REQ_MINION_TARGET = 1,
            /// <summary>
            /// <value> 目标只能是友方 </value>
            /// </summary>
            REQ_FRIENDLY_TARGET = 2,
            /// <summary>
            /// <value> 目标只能是敌方 </value>
            /// </summary>
            REQ_ENEMY_TARGET = 3,
            /// <summary>
            /// <value> 目标只能是受伤的随从 </value>
            /// </summary>
            REQ_DAMAGED_TARGET = 4,
            /// <summary>
            /// <value> 最大奥秘 </value>
            /// </summary>
            REQ_MAX_SECRETS = 5,
            /// <summary>
            /// <value> 目标只能是被冻结的随从 </value>
            /// </summary>
            REQ_FROZEN_TARGET = 6,
            /// <summary>
            /// <value> 冲锋 </value>
            /// </summary>
            REQ_CHARGE_TARGET = 7,
            /// <summary>
            /// <value> 目标攻击力要求小于 参数攻击力</value>
            /// </summary>
            REQ_TARGET_MAX_ATTACK = 8,
            /// <summary>
            /// <value> 目标是除了自身英雄以外的目标 </value>
            /// </summary>
            REQ_NONSELF_TARGET = 9,
            /// <summary>
            /// <value> 目标只能是指定种族的 参数为种族数字</value>
            /// </summary>
            REQ_TARGET_WITH_RACE = 10,
            /// <summary>
            /// <value> 需要有目标 </value>
            /// </summary>
            REQ_TARGET_TO_PLAY = 11,
            /// <summary>
            /// <value> 随从数量空位 有参数 </value>
            /// </summary>
            REQ_NUM_MINION_SLOTS = 12,
            /// <summary>
            /// <value> 需要武器才能使用 </value>
            /// </summary>
            REQ_WEAPON_EQUIPPED = 13,
            /// <summary>
            /// <value> 要求足够的法力值 </value>
            /// </summary>
            REQ_ENOUGH_MANA = 14,
            /// <summary>
            /// <value> 要求在你的回合 </value>
            /// </summary>
            REQ_YOUR_TURN = 15,
            /// <summary>
            /// <value> 要求非潜行敌方目标</value>
            /// </summary>
            REQ_NONSTEALTH_ENEMY_TARGET = 16,
            /// <summary>
            /// <value> 目标只能是英雄 </value>
            /// </summary>
            REQ_HERO_TARGET = 17,
            /// <summary>
            /// <value> 要求奥秘区域上限 </value>
            /// </summary>
            REQ_SECRET_ZONE_CAP = 18,
            /// <summary>
            /// <value> 要求随从上限（如果有目标） </value>
            /// </summary>
            REQ_MINION_CAP_IF_TARGET_AVAILABLE = 19,
            /// <summary>
            /// <value> 要求随从空位,param为数量 </value>
            /// </summary>
            REQ_MINION_CAP = 20,
            /// <summary>
            /// <value> 要求目标本回合攻击 </value>
            /// </summary>
            REQ_TARGET_ATTACKED_THIS_TURN = 21,
            /// <summary>
            /// <value> 无目标时也可以使用（抉择星辰降落，无面腐蚀者） </value>
            /// </summary>
            REQ_TARGET_IF_AVAILABLE = 22,
            /// <summary>
            /// <value> 对面场上的全部随从最少需要X个，有参数 </value>
            /// </summary>
            REQ_MINIMUM_ENEMY_MINIONS = 23,
            /// <summary>
            /// <value> 连击有目标 </value>
            /// </summary>
            REQ_TARGET_FOR_COMBO = 24,
            /// <summary>
            /// <value> 要求剩余法力水晶 </value>
            /// </summary>
            REQ_NOT_EXHAUSTED_ACTIVATE = 25,
            /// <summary>
            /// <value> 要求控制一个奥秘或任务 </value>
            /// </summary>
            REQ_UNIQUE_SECRET_OR_QUEST = 26,
            /// <summary>
            /// <value> 要求目标嘲讽 </value>
            /// </summary>
            REQ_TARGET_TAUNTER = 27,
            /// <summary>
            /// <value> 要求目标可以被攻击 </value>
            /// </summary>
            REQ_CAN_BE_ATTACKED = 28,
            /// <summary>
            /// <value> 要求英雄技能能使用 </value>
            /// </summary>
            REQ_ACTION_PWR_IS_MASTER_PWR = 29,
            /// <summary>
            /// <value> 要求磁力目标 </value>
            /// </summary>
            REQ_TARGET_MAGNET = 30,
            /// <summary>
            /// <value> 要求目标攻击力大于0 </value>
            /// </summary>
            REQ_ATTACK_GREATER_THAN_0 = 31,
            /// <summary>
            /// <value> 要求攻击者未被冻结 </value>
            /// </summary>
            REQ_ATTACKER_NOT_FROZEN = 32,
            /// <summary>
            /// <value> 要求目标为英雄或随从 </value>
            /// </summary>
            REQ_HERO_OR_MINION_TARGET = 33,
            /// <summary>
            /// <value> 要求目标能被法术指定 </value>
            /// </summary>
            REQ_CAN_BE_TARGETED_BY_SPELLS = 34,
            /// <summary>
            /// <value> 暂时不清楚 </value>
            /// </summary>
            REQ_SUBCARD_IS_PLAYABLE = 35,
            /// <summary>
            /// <value> 连击无目标 </value>
            /// </summary>
            REQ_TARGET_FOR_NO_COMBO = 36,
            /// <summary>
            /// <value> 要求没有控制其他随从 </value>
            /// </summary>
            REQ_NOT_MINION_JUST_PLAYED = 37,
            /// <summary>
            /// <value> 要求未使用英雄技能 </value>
            /// </summary>
            REQ_NOT_EXHAUSTED_HERO_POWER = 38,
            /// <summary>
            /// <value> 可由对手指定目标 </value>
            /// </summary>
            REQ_CAN_BE_TARGETED_BY_OPPONENTS = 39,
            /// <summary>
            /// <value> 攻击者可以攻击 </value>
            /// </summary>
            REQ_ATTACKER_CAN_ATTACK = 40,
            /// <summary>
            /// <value> 要求目标攻击力大于  参数为攻击力</value>
            /// </summary>
            REQ_TARGET_MIN_ATTACK = 41, // 有参数
            /// <summary>
            /// <value> 要求可被英雄技能瞄准 </value>
            /// </summary>
            REQ_CAN_BE_TARGETED_BY_HERO_POWERS = 42,
            /// <summary>
            /// <value> 要求敌方目标不具有免疫 </value>
            /// </summary>
            REQ_ENEMY_TARGET_NOT_IMMUNE = 43,
            /// <summary>
            /// <value> 要求全场面没有随从 </value>
            /// </summary>
            REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 44,
            /// <summary>
            /// <value> 对面场上的全部随从最少需要X个  参数最少随从数量</value>
            /// </summary>
            REQ_MINIMUM_TOTAL_MINIONS = 45,
            /// <summary>
            /// <value> 目标必须是嘲讽随从 </value>
            /// </summary>
            REQ_MUST_TARGET_TAUNTER = 46,
            /// <summary>
            /// <value> 目标只能是未受伤的随从 </value>
            /// </summary>
            REQ_UNDAMAGED_TARGET = 47,
            /// <summary>
            /// <value> 可以被战吼指定目标 </value>
            /// </summary>
            REQ_CAN_BE_TARGETED_BY_BATTLECRIES = 48,
            /// <summary>
            /// <value> 猎人英雄技能稳固射击 </value>
            /// </summary>
            REQ_STEADY_SHOT = 49,
            /// <summary>
            /// <value> 英雄技能 </value>
            /// </summary>
            REQ_MINION_OR_ENEMY_HERO = 50,
            /// <summary>
            /// <value> 有龙牌在手才有目标 </value>
            /// </summary>
            REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 51,
            /// <summary>
            /// <value> 目标只能是传说随从 </value>
            /// </summary>
            REQ_LEGENDARY_TARGET = 52,
            /// <summary>
            /// <value> 需要一个死亡的友方随从在当前回合死亡 </value>
            /// </summary>
            REQ_FRIENDLY_MINION_DIED_THIS_TURN = 53,
            /// <summary>
            /// <value> 需要一个死亡的友方随从 </value>
            /// </summary>
            REQ_FRIENDLY_MINION_DIED_THIS_GAME = 54,
            /// <summary>
            /// <value> 敌方英雄已装备武器 </value>
            /// </summary>
            REQ_ENEMY_WEAPON_EQUIPPED = 55,
            /// <summary>
            /// <value> 我方随从最少要X个可以使用 </value>
            /// </summary>
            REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS = 56,
            /// <summary>
            /// <value> 目标只能是战吼随从 </value>
            /// </summary>
            REQ_TARGET_WITH_BATTLECRY = 57,
            /// <summary>
            /// <value> 目标只能是亡语随从 </value>
            /// </summary>
            REQ_TARGET_WITH_DEATHRATTLE = 58,
            /// <summary>
            /// <value> 最少需要X个奥秘才有目标 </value>
            /// </summary>
            REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS = 59,
            /// <summary>
            /// <value> 奥秘数未达到奥秘区域上限 </value>
            /// </summary>
            REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 60,
            /// <summary>
            /// <value> 目标精确费用？ 不确定 </value>
            /// </summary>
            REQ_TARGET_EXACT_COST = 61,
            /// <summary>
            /// <value> 目标只能是潜行随从 </value>
            /// </summary>
            REQ_STEALTHED_TARGET = 62,
            /// <summary>
            /// <value> 场上可以放一个随从且小于10个水晶 </value>
            /// </summary>
            REQ_MINION_SLOT_OR_MANA_CRYSTAL_SLOT = 63,
            /// <summary>
            /// <value> 最少需要x个任务 </value>
            /// </summary>
            REQ_MAX_QUESTS = 64,
            /// <summary>
            /// <value> 如果上个回合打过元素牌则有目标 </value>
            /// </summary>
            REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN = 65,
            /// <summary>
            /// <value> 要求目标不是吸血鬼 冒险boss的技能</value>
            /// </summary>
            REQ_TARGET_NOT_VAMPIRE = 66,
            /// <summary>
            /// <value> 目标只会受到武器伤害 冒险boss的技能</value>
            /// </summary>
            REQ_TARGET_NOT_DAMAGEABLE_ONLY_BY_WEAPONS = 67,
            /// <summary>
            /// <value> 要求英雄技能未禁用 </value>
            /// </summary>
            REQ_NOT_DISABLED_HERO_POWER = 68,
            /// <summary>
            /// <value> 必须先使用其他卡牌 </value>
            /// 例如：暗影映像 - 每当你使用一张牌，变形成为该卡牌的复制。
            /// </summary>
            REQ_MUST_PLAY_OTHER_CARD_FIRST = 69,
            /// <summary>
            /// <value> 手牌未满 </value>
            /// </summary>
            REQ_HAND_NOT_FULL = 70,
            /// <summary>
            /// <value> 必须先使用其他卡牌 </value>
            /// <value> 例如：暗影映像 - 每当你使用一张牌，变形成为该卡牌的复制 </value>
            /// </summary>
            REQ_DRAG_TO_PLAY = 71,
            /// <summary>
            /// <value> 需要有目标2 </value>
            /// </summary>
            REQ_TARGET_TO_PLAY2 = 75,
            /// <summary>
            /// <value> 目标法术无自然属性 </value>
            /// </summary>
            REQ_TARGET_NO_NATURE = 77,
            REQ_LITERALLY_UNPLAYABLE,
            REQ_TARGET_IF_AVAILABLE_AND_HERO_HAS_ATTACK,
            /// <summary>
            /// <value> 需要一个对应种族的死亡友方随从在当前回合死亡 </value>
            /// </summary>
            REQ_FRIENDLY_MINION_OF_RACE_DIED_THIS_TURN,
            REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_SPELLS_PLAYED_THIS_TURN,
            /// <summary>
            /// <value> 要求手牌中有同种族友方随从 </value>
            /// </summary>
            REQ_FRIENDLY_MINION_OF_RACE_IN_HAND,
            /// <summary>
            /// <value> 要求本局对战有友方死语随从死亡 </value>
            /// </summary>
            REQ_FRIENDLY_DEATHRATTLE_MINION_DIED_THIS_GAME = 86,
            /// <summary>
            /// <value> 要求本局对战有友方复生随从死亡 </value>
            /// </summary>
            REQ_FRIENDLY_REBORN_MINION_DIED_THIS_GAME = 89,
            /// <summary>
            /// <value> 要求本局对战有随从死亡 </value>
            /// </summary>
            REQ_MINION_DIED_THIS_GAME,
            REQ_BOARD_NOT_COMPLETELY_FULL = 92,
            /// <summary>
            /// <value> 要求有过载的法力水晶才有目标</value>
            /// </summary>
            REQ_TARGET_IF_AVAILABLE_AND_HAS_OVERLOADED_MANA,
            REQ_TARGET_IF_AVAILABLE_AND_HERO_ATTACKED_THIS_TURN,
            REQ_TARGET_IF_AVAILABLE_AND_DRAWN_THIS_TURN,
            REQ_TARGET_IF_AVAILABLE_AND_NOT_DRAWN_THIS_TURN,
            REQ_TARGET_NON_TRIPLED_MINION,
            REQ_BOUGHT_MINION_THIS_TURN,
            REQ_SOLD_MINION_THIS_TURN,
            REQ_TARGET_IF_AVAILABLE_AND_PLAYER_HEALTH_CHANGED_THIS_TURN,
            REQ_TARGET_IF_AVAILABLE_AND_SOUL_FRAGMENT_IN_DECK,
            REQ_DAMAGED_TARGET_UNLESS_COMBO,
            REQ_NOT_MINION_DORMANT,
            REQ_TARGET_NOT_UNTOUCHABLE,
            REQ_TARGET_IF_AVAILABLE_AND_BOUGHT_RACE_THIS_TURN,
            REQ_TARGET_IF_AVAILABLE_AND_SOLD_RACE_THIS_TURN,
            REQ_NOT_IN_COOLDOWN,
            REQ_TARGET_IS_MERC,
            REQ_TARGET_IS_NON_MERC,
            REQ_TWO_OF_A_KIND,
            /// <summary>
            /// <value> 要求法力过载 </value>
            /// </summary>
            REQ_HAS_OVERLOADED_MANA,
            REQ_LETTUCE_ABILITY_CANNOT_TARGET_OWNER,
            REQ_TARGET_NOT_HAVE_TAG = 116,
            REQ_TARGET_MUST_HAVE_TAG,
            /// <summary>
            /// <value> 可交易 </value>
            /// </summary>
            REQ_TRADEABLE = 119,
            REQ_NOT_LEGENDARY_TARGET = 123,
            REQ_MINIMUM_TAVERN_TIER_LEVEL_TO_PLAY = 128,
            REQ_CARD_TAVERN_TIER_LEVEL_TO_PLAY,
            REQ_NOT_EXHAUSTED_LOCATION,
            /// <summary>
            /// 要求目标是地标
            /// </summary>
            REQ_LOCATION_TARGET,
            REQ_TARGET_SILVER_HAND_RECRUIT,
            REQ_MINIMUM_CORPSES,
            REQ_LOCATION_OR_MINION_TARGET,
            REQ_CAN_BE_TARGETED_BY_LOCATIONS,
            REQ_FORGE,
            REQ_TARGET_MAX_COST,
            REQ_HAS_PLAYED_SPELL_THIS_GAME,
            /// <summary>
            /// 目标不能是泰坦
            /// </summary>
            REQ_TARGET_IS_NON_TITAN = 141,
            REQ_BACON_DUO_PASSABLE,
            REQ_TARGET_EXACT_ATTACK,
            REQ_MINIMUM_NON_GOLDEN_ENEMY_MINIONS = 146,
        }

        public class Card
        {
            public string dbfId = "";
            public cardNameEN nameEN = cardNameEN.unknown;//名称
            public cardNameCN nameCN = cardNameCN.未知;
            public Race race = Race.INVALID;//种族
            public int rarity = 0;//稀有度
            public int cost = 0;//费用
            public int Class = 0;//职业
            public cardtype type = CardDB.cardtype.NONE;//类别
            public int Attack = 0; //攻击力
            public int Health = 0;//血量
            public int Durability = 0;//for weapons//耐久值
            public bool tank = false;//嘲讽
            public bool Silence = false;//沉默
            public bool choice = false;//抉择
            public bool windfury = false;//风怒
            public bool poisonous = false;//剧毒
            public bool lifesteal = false;//吸血
            public int dormant = 0;//休眠 0表示非休眠生物或者已醒，还有多少回合醒来
            public bool reborn = false;//复生
            public bool deathrattle = false;//亡语
            public bool battlecry = false;//战吼
            public bool discover = false;//发现
            public bool oneTurnEffect = false;
            public bool Enrage = false;//愤怒 激怒
            public bool Aura = false;//光环
            public bool Elite = false;//精华??
            public bool Combo = false;//连击
            public int overload = 0;//超载
            public bool immuneWhileAttacking = false;//攻击时免疫
            public bool untouchable = false;//不可被攻击
            public bool Stealth = false;//潜行
            public bool Freeze = false;//冰冻
            public bool AdjacentBuff = false;//相邻buff 恐狼?
            public bool Shield = false;//圣盾
            public bool Charge = false;//冲锋
            public bool Rush = false;//突袭
            public bool Secret = false;//奥秘
            public bool Nature = false;//自然
            public bool Quest = false;//任务
            public bool Questline = false;//任务线
            public bool Morph = false;//变形
            public bool Spellpower = false;//法强
            public bool Inspire = false;//激励
            public bool Outcast = false;//流放
            public bool Corrupted = false;//已腐蚀
            public bool Corrupt = false;//可腐蚀
            public bool CantAttack = false; //不可攻击
            public bool Collectable = false; //可收藏
            public SpellSchool SpellSchool = SpellSchool.NONE;//法术派系
            public bool Tradeable = false;//可交易
            public int TradeCost = 0;//交易消耗法力值
            public int needEmptyPlacesForPlaying = 0;
            public int needWithMinAttackValueOf = 0;
            public int needWithMaxAttackValueOf = 0;
            public int needRaceForPlaying = 0;
            public int needMinNumberOfEnemy = 0;
            public int needMinTotalMinions = 0;
            public int needMinOwnMinions = 0;
            public int needMinionsCapIfAvailable = 0;
            public int needControlaSecret = 0;
            public bool isToken = false;
            public int isCarddraw = 0;
            public bool damagesTarget = false;
            public bool damagesTargetWithSpecial = false;
            public int targetPriority = 0;
            public bool isSpecialMinion = false;
            public int spellpowervalue = 0;
            public cardIDEnum cardIDenum = cardIDEnum.None;
            public List<cardtrigers> trigers;
            public SimTemplate sim_card = new SimTemplate();

            public int TAG_SCRIPT_DATA_NUM_1 = 0;//标签脚本数据编号1，用于记录伤害、召唤数量、衍生物攻击力、衍生物血量、注能数量、法力渴求
            public int TAG_SCRIPT_DATA_NUM_2 = 0;//标签脚本数据编号2，用于记录伤害、召唤数量、衍生物攻击力、衍生物血量、注能数量、法力渴求
            public int TAG_SCRIPT_DATA_NUM_3 = 0;//标签脚本数据编号3，用于记录伤害、召唤数量、衍生物攻击力、衍生物血量、注能数量、法力渴求
            public int TAG_SCRIPT_DATA_NUM_4 = 0;//标签脚本数据编号4，用于记录伤害、召唤数量、衍生物攻击力、衍生物血量、注能数量、法力渴求

            public int DECK_ACTION_COST = 0;//卡组操作消耗法力值

            public bool Dredge = false;//探底
            public int CooldownTurn = 0;//地标冷却回合
            public bool Infuse = false;//注能
            public bool Infused = false;//已注能
            public int InfuseNum = 0;//注能数量
            public int Manathirst = 0;//法力渴求
            public bool Finale = false;//压轴
            public bool Overheal = false;//过量治疗
            public bool Titan = false;//泰坦
            public bool TitanAbilityUsed1 = false;//泰坦第一技能
            public bool TitanAbilityUsed2 = false;//泰坦第二技能
            public bool TitanAbilityUsed3 = false;//泰坦第三技能
            public List<Card> TitanAbility = new List<Card>();//泰坦技能列表
            public bool Forge = false;//锻造
            public int ForgeCost = 0;//锻造消耗法力值
            public bool Forged = false;//已锻造
            public bool Quickdraw = false;//快枪
            public bool Excavate = false;//发掘
            public bool Elusive = false;//扰魔
            public bool Echo = false; // 回响
            public bool nonKeywordEcho = false; // 非关键词回响，设计师左右脑互搏的结果。就是个在本回合可以重复使用
            public bool Twinspell = false; // 双生法术
            public bool Temporary = false; // 临时
            public int armor = 0;
            public cardIDEnum heroPower = cardIDEnum.None;
            public int Objective = 0; // 光环 如救生光环
            public int ObjectiveAura = 0; // 会影响场面的光环 如征战平原
            public int Sigil = 0; // 咒符
            public bool markOfEvil = false; // 跟班
            public bool Treant = false;  // 树人
            public bool IMP = false;  // 小鬼
            public bool Whelp = false;  // 雏龙
            public bool StarshipPiece = false;  // 星舰组件
            public bool Starship = false;   // 星舰           
            public bool Crewmate = false;  // 乘务员
            public int MultipleClasses = 0; // 194: 玉莲帮 296: 暗金教 532: 玉莲帮
            public bool Zerg = false;   // 异虫
            public bool Terran = false; // 人族
            public bool Protoss = false;    // 星灵
            public int costBlood = 0;   // 鲜血符文
            public int costFrost = 0;    // 冰霜符文
            public int costUnholy = 0; // 邪恶符文
            public int CastsWhenDrawn = 0; // 抽到时触发效果


            public List<Race> races = new List<Race>(); //TODO:种族集合

            //TODO:种族数
            public int GetRaceCount()
            {
                return this.races.Count;
            }
            //TODO:获取种族集合
            public List<Race> GetRaces()
            {

                this.races = Enumerable.ToList<Race>(Enumerable.Distinct<Race>(this.races));
                if (this.races.Count > 1)
                {
                    Race[] order = new Race[]
                    {
                        Race.UNDEAD,
                        Race.ELEMENTAL,
                        Race.MECHANICAL,
                        Race.DEMON,
                        Race.MURLOC,
                        Race.QUILBOAR,
                        Race.NAGA,
                        Race.PET,
                        Race.DRAGON,
                        Race.DRAENEI,
                        Race.TOTEM,
                        Race.PIRATE
                    };
                    this.races.Sort((Race r1, Race r2) => Array.IndexOf<Race>(order, r1).CompareTo(Array.IndexOf<Race>(order, r2)));
                }
                return this.races;
            }

            public string textCN = "";
            public int count = 1;

            private bool _honorableKill = false;
            private bool _overkill = false;
            private bool _spellburst = false;
            private bool _frenzy = false;

            /// <summary>
            /// 荣耀击杀
            /// </summary>
            public bool HonorableKill
            {
                get { return _honorableKill; }
                set { _honorableKill = value; }
            }

            /// <summary>
            /// 超杀
            /// </summary>
            public bool Overkill
            {
                get { return _overkill; }
                set { _overkill = value; }
            }

            /// <summary>
            /// 法术迸发
            /// </summary>
            public bool Spellburst
            {
                get { return _spellburst; }
                set { _spellburst = value; }
            }

            /// <summary>
            /// 暴怒
            /// </summary>
            public bool Frenzy
            {
                get { return _frenzy; }
                set { _frenzy = value; }
            }

            public string OnlineCardImage
            {
                get { return "https://art.hearthstonejson.com/v1/render/latest/zhCN/256x/" + cardIDenum.ToString() + ".png"; }
            }

            public string OnlineCardTile
            {
                get { return "https://art.hearthstonejson.com/v1/tiles/" + cardIDenum.ToString() + ".png"; }
            }

            public string CardInfo
            {
                get
                {
                    return "[" + cost + "] \t\t" + Attack.ToString() + "/" + Health.ToString() + "\n" + nameCN.ToString() + "\n" + textCN + "\n" + type.ToString() + " \t\t" + race.ToString();
                }
            }

            public string Status
            {
                get
                {
                    return "(" + cost + ") " + nameCN.ToString() + " [" + count + "] ";
                }
            }

            public string Color
            {
                get
                {
                    switch (rarity)
                    {
                        case 3:
                            return "DodgerBlue";
                        case 4:
                            return "BlueViolet";
                        case 5:
                            return "DarkOrange";
                        case 1:
                        default:
                            return "Gray";
                    }
                }
            }

            /// <summary>
            /// 存在错误类型
            /// </summary>
            /// <param name="errorType"></param>
            /// <returns></returns>
            public bool ExistErrorType(CardDB.ErrorType2 errorType)
            {
                foreach (var pr in this.sim_card.GetPlayReqs())
                {
                    if (pr.errorType == errorType) return true;
                }
                return false;
            }

            /// <summary>
            /// 获得卡牌的目标
            /// </summary>
            /// <param name="p"></param>
            /// <param name="isLethalCheck"></param>
            /// <param name="own"></param>
            /// <returns></returns>
            public List<Minion> getTargetsForCard(Playfield p, bool isLethalCheck, bool own)
            {
                //if wereTargets=true and 0 targets at end -> then can not play this card
                List<Minion> retval = new List<Minion>();
                if (this.type == CardDB.cardtype.MOB && ((own && p.ownMinions.Count >= 7) || (!own && p.enemyMinions.Count >= 7))) return retval; // cant play mob, if we have allready 7 mininos
                if (this.Secret && ((own && (p.ownSecretsIDList.Contains(this.cardIDenum) || p.ownSecretsIDList.Count >= 5)) || (!own && p.enemySecretCount >= 5))) return retval;
                if (this.sim_card.GetPlayReqs().Length == 0) { retval.Add(null); return retval; }

                List<Minion> targets = new List<Minion>();
                bool targetAll = false;
                bool targetAllEnemy = false;
                bool targetAllFriendly = false;
                bool targetEnemyHero = false;
                bool targetOwnHero = false;
                bool targetOnlyMinion = false;
                bool targetOnlyLocation = false;
                bool extraParam = false;
                bool wereTargets = false;
                bool REQ_UNDAMAGED_TARGET = false;
                bool REQ_TARGET_WITH_DEATHRATTLE = false;
                bool REQ_TARGET_WITH_RACE = false;
                bool REQ_TARGET_MIN_ATTACK = false;
                bool REQ_TARGET_MAX_ATTACK = false;
                bool REQ_MUST_TARGET_TAUNTER = false;
                bool REQ_STEADY_SHOT = false;
                bool REQ_FROZEN_TARGET = false;
                bool REQ_HERO_TARGET = false;
                bool REQ_DAMAGED_TARGET = false;
                bool REQ_LEGENDARY_TARGET = false;
                bool REQ_TARGET_IF_AVAILABLE = false;
                bool REQ_STEALTHED_TARGET = false;
                bool REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN = false;
                bool REQ_TARGET_NO_NATURE = false;

                foreach (PlayReq pr in this.sim_card.GetPlayReqs())
                {
                    switch (pr.errorType)
                    {
                        case ErrorType2.REQ_TARGET_TO_PLAY:
                        case ErrorType2.REQ_TARGET_TO_PLAY2:
                            targetAll = true;
                            continue;
                        case ErrorType2.REQ_MINION_TARGET:
                            targetOnlyMinion = true;
                            continue;
                        case ErrorType2.REQ_LOCATION_TARGET:
                            targetOnlyLocation = true;
                            continue;
                        case ErrorType2.REQ_TARGET_IF_AVAILABLE:
                            REQ_TARGET_IF_AVAILABLE = true;
                            targetAll = true;
                            continue;
                        case ErrorType2.REQ_FRIENDLY_TARGET:
                            if (own) targetAllFriendly = true;
                            else targetAllEnemy = true;
                            continue;
                        case ErrorType2.REQ_NUM_MINION_SLOTS:
                            if ((own ? p.ownMinions.Count : p.enemyMinions.Count) > 7 - this.needEmptyPlacesForPlaying) return retval;
                            continue;
                        case ErrorType2.REQ_MINION_SLOT_OR_MANA_CRYSTAL_SLOT:
                            if (own) { if (p.ownMinions.Count > 6 & p.ownMaxMana > 9) return retval; }
                            else if (p.enemyMinions.Count > 6 & p.enemyMaxMana > 9) return retval;
                            continue;
                        case ErrorType2.REQ_ENEMY_TARGET:
                            if (own) targetAllEnemy = true;
                            else targetAllFriendly = true;
                            continue;
                        case ErrorType2.REQ_HERO_TARGET:
                            REQ_HERO_TARGET = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_MINIMUM_ENEMY_MINIONS:
                            if ((own ? p.enemyMinions.Count : p.ownMinions.Count) < this.needMinNumberOfEnemy) return retval;
                            continue;
                        case ErrorType2.REQ_NONSELF_TARGET:
                            targetAll = true;
                            continue;
                        case ErrorType2.REQ_TARGET_WITH_RACE:
                            REQ_TARGET_WITH_RACE = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_DAMAGED_TARGET:
                            REQ_DAMAGED_TARGET = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_TARGET_MAX_ATTACK:
                            REQ_TARGET_MAX_ATTACK = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_WEAPON_EQUIPPED:
                            if ((own ? p.ownWeapon.Durability : p.enemyWeapon.Durability) == 0) return retval;
                            continue;
                        case ErrorType2.REQ_TARGET_FOR_COMBO:
                            if (p.cardsPlayedThisTurn >= 1) targetAll = true;
                            continue;
                        case ErrorType2.REQ_TARGET_MIN_ATTACK:
                            REQ_TARGET_MIN_ATTACK = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_MINIMUM_TOTAL_MINIONS:
                            if (this.needMinTotalMinions > p.ownMinions.Count + p.enemyMinions.Count) return retval;
                            continue;
                        case ErrorType2.REQ_MINION_CAP_IF_TARGET_AVAILABLE:
                            if ((own ? p.ownMinions.Count : p.enemyMinions.Count) > 7 - this.needMinionsCapIfAvailable) return retval;
                            continue;
                        case ErrorType2.REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY://不能召唤更多图腾
                            bool searingtotem = false;
                            bool wrathofairtotem = false;
                            bool stoneclawtotem = false;
                            bool healingtotem = false;
                            foreach (Minion m in (own ? p.ownMinions : p.enemyMinions))
                            {
                                if (m.name == CardDB.cardNameEN.healingtotem)
                                {//治疗图腾
                                    healingtotem = true;
                                    continue;
                                }
                                // 力量或者法强图腾
                                if (m.name == CardDB.cardNameEN.wrathofairtotem || m.name == CardDB.cardNameEN.strengthtotem)
                                {
                                    wrathofairtotem = true;
                                    continue;
                                }
                                if (m.name == CardDB.cardNameEN.searingtotem)
                                {
                                    searingtotem = true;
                                    continue;
                                }
                                if (m.name == CardDB.cardNameEN.stoneclawtotem)
                                {
                                    stoneclawtotem = true;
                                    continue;
                                }
                            }
                            if (healingtotem && wrathofairtotem && searingtotem && stoneclawtotem) return retval;
                            continue;
                        case ErrorType2.REQ_MUST_TARGET_TAUNTER:
                            REQ_MUST_TARGET_TAUNTER = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND:
                            if (own)
                            {
                                foreach (Handmanager.Handcard hc in p.owncards)
                                {
                                    if ((TAG_RACE)hc.card.race == TAG_RACE.DRAGON) { targetAll = true; break; }
                                }
                            }
                            else targetAll = true; // apriori the enemy have a dragon
                            continue;
                        case ErrorType2.REQ_LEGENDARY_TARGET:
                            REQ_LEGENDARY_TARGET = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_UNDAMAGED_TARGET:
                            REQ_UNDAMAGED_TARGET = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_TARGET_WITH_DEATHRATTLE:
                            REQ_TARGET_WITH_DEATHRATTLE = true;
                            targetOnlyMinion = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_TARGET_NO_NATURE:
                            REQ_TARGET_NO_NATURE = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN:
                            REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_STEADY_SHOT:
                            REQ_STEADY_SHOT = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_FROZEN_TARGET:
                            REQ_FROZEN_TARGET = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_MINION_OR_ENEMY_HERO:
                            REQ_STEADY_SHOT = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_STEALTHED_TARGET:
                            REQ_STEALTHED_TARGET = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_ENEMY_WEAPON_EQUIPPED:
                            if (own)
                            {
                                if (p.enemyWeapon.Durability > 0) targetEnemyHero = true;
                                else return retval;
                            }
                            else
                            {
                                if (p.ownWeapon.Durability > 0) targetOwnHero = true;
                                else return retval;
                            }
                            continue;
                        case ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS:
                            int tmp = (own) ? p.ownMinions.Count : p.enemyMinions.Count;
                            if (tmp >= needMinOwnMinions) targetAll = true;
                            continue;
                        case ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS:
                            if (p.ownSecretsIDList.Count >= needControlaSecret) targetAll = true;
                            continue;
                        case ErrorType2.REQ_MUST_PLAY_OTHER_CARD_FIRST:
                            if (p.cardsPlayedThisTurn == 0) return retval;
                            continue;
                        case ErrorType2.REQ_HAND_NOT_FULL:
                            if (p.owncards.Count == 10) return retval;
                            continue;
                    }
                }

                if (targetAll)
                {

                    wereTargets = true;
                    if (targetOnlyLocation)
                    {
                        foreach (Minion m in targets) if (m.handcard.card.type == cardtype.LOCATION) targets.Add(m);
                    }

                    if (targetAllFriendly != targetAllEnemy)
                    {
                        if (targetAllFriendly)
                        {
                            foreach (Minion m in p.ownMinions) if (!m.untouchable) targets.Add(m);
                        }
                        else
                        {
                            foreach (Minion m in p.enemyMinions) if (!m.untouchable) targets.Add(m);
                        }
                    }
                    else
                    {
                        foreach (Minion m in p.ownMinions) if (!m.untouchable) targets.Add(m);
                        foreach (Minion m in p.enemyMinions) if (!m.untouchable) targets.Add(m);
                    }
                    if (targetOnlyMinion)
                    {
                        targetEnemyHero = false;
                        targetOwnHero = false;
                    }
                    else
                    {
                        if (!p.enemyHero.immune) targetEnemyHero = true;
                        if (!p.ownHero.immune) targetOwnHero = true;
                        if (targetAllEnemy) targetOwnHero = false;
                        if (targetAllFriendly) targetEnemyHero = false;
                    }



                }

                if (extraParam)
                {
                    wereTargets = true;
                    if (REQ_TARGET_WITH_RACE)
                    {
                        foreach (Minion m in targets)
                        {
                            // 不满足使用条件（或者是融合怪）
                            if (m.handcard.card.race != (Race)this.needRaceForPlaying && m.handcard.card.race != Race.ALL) m.extraParam = true;
                        }
                        // targetOwnHero = (p.ownHeroName == HeroEnum.lordjaraxxus && (TAG_RACE)this.needRaceForPlaying == TAG_RACE.DEMON);
                        // targetEnemyHero = (p.enemyHeroName == HeroEnum.lordjaraxxus && (TAG_RACE)this.needRaceForPlaying == TAG_RACE.DEMON);
                        targetOwnHero = false;
                        targetEnemyHero = false;
                    }
                    if (REQ_HERO_TARGET)
                    {
                        foreach (Minion m in targets)
                        {
                            m.extraParam = true;
                        }
                        targetOwnHero = true;
                        targetEnemyHero = true;
                    }
                    if (REQ_DAMAGED_TARGET)
                    {
                        foreach (Minion m in targets)
                        {
                            if (!m.wounded)
                            {
                                m.extraParam = true;
                            }
                        }
                        targetOwnHero = false;
                        targetEnemyHero = false;
                    }
                    if (REQ_TARGET_MAX_ATTACK)
                    {
                        foreach (Minion m in targets)
                        {
                            if (m.Angr > this.needWithMaxAttackValueOf)
                            {
                                m.extraParam = true;
                            }
                        }
                        targetOwnHero = false;
                        targetEnemyHero = false;
                    }
                    if (REQ_TARGET_MIN_ATTACK)
                    {
                        foreach (Minion m in targets)
                        {
                            if (m.Angr < this.needWithMinAttackValueOf)
                            {
                                m.extraParam = true;
                            }
                        }
                        targetOwnHero = false;
                        targetEnemyHero = false;
                    }
                    if (REQ_MUST_TARGET_TAUNTER)
                    {
                        foreach (Minion m in targets)
                        {
                            if (!m.taunt)
                            {
                                m.extraParam = true;
                            }
                        }
                        targetOwnHero = false;
                        targetEnemyHero = false;
                    }
                    if (REQ_UNDAMAGED_TARGET)
                    {
                        foreach (Minion m in targets)
                        {
                            if (m.wounded)
                            {
                                m.extraParam = true;
                            }
                        }
                        targetOwnHero = false;
                        targetEnemyHero = false;
                    }
                    if (REQ_STEALTHED_TARGET)
                    {
                        foreach (Minion m in targets)
                        {
                            if (!m.stealth)
                            {
                                m.extraParam = true;
                            }
                        }
                        targetOwnHero = false;
                        targetEnemyHero = false;
                    }
                    if (REQ_TARGET_WITH_DEATHRATTLE)
                    {
                        foreach (Minion m in targets)
                        {
                            if (!m.silenced && (m.handcard.card.deathrattle || m.deathrattle2 != null ||
                            m.ancestralspirit + m.desperatestand + m.souloftheforest + m.stegodon + m.livingspores + m.explorershat + m.returnToHand + m.infest > 0)) continue;
                            else m.extraParam = true;
                        }
                        targetOwnHero = false;
                        targetEnemyHero = false;
                    }
                    if (REQ_TARGET_NO_NATURE)
                    {
                        if (p.useNature < 1)
                        {
                            foreach (Minion m in targets) m.extraParam = true;
                            targetOwnHero = false;
                            targetEnemyHero = false;
                        }
                    }
                    if (REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN)
                    {
                        if (p.anzOwnElementalsLastTurn < 1)
                        {
                            foreach (Minion m in targets) m.extraParam = true;
                            targetOwnHero = false;
                            targetEnemyHero = false;
                        }
                    }
                    if (REQ_TARGET_NO_NATURE)
                    {
                        if (p.useNature < 1)
                        {
                            foreach (Minion m in targets) m.extraParam = true;
                            targetOwnHero = false;
                            targetEnemyHero = false;
                        }
                    }
                    if (REQ_LEGENDARY_TARGET)
                    {
                        wereTargets = false;
                        foreach (Minion m in targets)
                        {
                            if (m.handcard.card.rarity != 5) m.extraParam = true;
                        }
                        targetOwnHero = false;
                        targetEnemyHero = false;
                    }
                    if (REQ_STEADY_SHOT)
                    {
                        if ((p.weHaveSteamwheedleSniper && own) || (p.enemyHaveSteamwheedleSniper && !own))
                        {
                            foreach (Minion m in targets)
                            {
                                // if (m.cantBeTargetedBySpellsOrHeroPowers && (this.type == cardtype.HEROPWR || this.type == cardtype.SPELL))
                                if (m.Elusive && (this.type == cardtype.HEROPWR || this.type == cardtype.SPELL))
                                {
                                    m.extraParam = true;
                                    if (m.stealth && !m.own) m.extraParam = true;
                                }
                            }
                            if (own) targetEnemyHero = true;
                            else targetOwnHero = true;
                        }
                        else wereTargets = false;
                    }
                    if (REQ_FROZEN_TARGET)
                    {

                        foreach (Minion m in targets)
                        {
                            if (!m.frozen) m.extraParam = true;
                        }
                    }
                }

                if (targetEnemyHero && own && p.enemyHero.stealth) targetEnemyHero = false;
                if (targetOwnHero && !own && p.ownHero.stealth) targetOwnHero = false;

                //斩杀
                if (isLethalCheck)
                {
                    if (targetEnemyHero && own) retval.Add(p.enemyHero);
                    else if (targetOwnHero && !own) retval.Add(p.ownHero);

                    switch (this.type)
                    {
                        case cardtype.SPELL:
                            if (p.prozis.penman.attackBuffDatabase.ContainsKey(this.nameEN))
                            {
                                if (targetOwnHero && own) retval.Add(p.ownHero);
                                foreach (Minion m in targets)
                                {
                                    if (m.extraParam != true && !m.Elusive)
                                    {
                                        if (m.own)
                                        {
                                            if (m.Ready) retval.Add(m);
                                        }
                                        else if (m.taunt) retval.Add(m);
                                    }
                                    m.extraParam = false;
                                }
                            }
                            else
                            {
                                switch (this.nameEN)
                                {
                                    case cardNameEN.polymorphboar://变形术：野猪
                                        foreach (Minion m in targets)
                                        {
                                            m.extraParam = false;
                                            if (m.Elusive) continue;
                                            if (m.own) retval.Add(m);
                                            else if (m.taunt) retval.Add(m);
                                        }
                                        break;
                                    // case cardNameEN.hex: goto case cardNameEN.polymorph;//妖术
                                    case cardNameEN.hex://妖术
                                    case cardNameEN.polymorph://变形术
                                        foreach (Minion m in targets)
                                        {
                                            m.extraParam = false;
                                            if (!m.own && m.taunt && !m.cantBeTargetedBySpellsOrHeroPowers) retval.Add(m);
                                        }
                                        break;
                                }
                            }
                            break;
                        case cardtype.MOB:
                            foreach (Minion m in targets)
                            {
                                if (m.extraParam != true)
                                {
                                    if (m.stealth && !m.own) continue;
                                    retval.Add(m);
                                }
                                m.extraParam = false;
                            }
                            break;
                        case cardtype.HEROPWR:
                            if (p.prozis.penman.attackBuffDatabase.ContainsKey(this.nameEN))
                            {
                                foreach (Minion m in targets)
                                {
                                    if (m.extraParam != true && !m.cantBeTargetedBySpellsOrHeroPowers)
                                    {
                                        if (m.own)
                                        {
                                            if (m.Ready) retval.Add(m);
                                        }
                                        else if (m.taunt) retval.Add(m);
                                    }
                                    m.extraParam = false;
                                }
                            }
                            break;
                    }
                }
                else
                {
                    if (targetEnemyHero) retval.Add(p.enemyHero);
                    if (targetOwnHero) retval.Add(p.ownHero);

                    foreach (Minion m in targets)
                    {
                        if (m.extraParam != true)
                        {
                            if (m.stealth && !m.own) continue;
                            if (m.cantBeTargetedBySpellsOrHeroPowers && (this.type == cardtype.SPELL || this.type == cardtype.HEROPWR)) continue;
                            retval.Add(m);
                        }
                        m.extraParam = false;
                    }
                }
                //非地标目标指向，移除地标
                if (!targetOnlyLocation)
                {
                    retval.RemoveAll(minion => minion != null &&
                          minion.handcard != null &&
                          minion.handcard.card != null &&
                          minion.handcard.card.type == CardDB.cardtype.LOCATION);

                }

                //如果是法术，移除扰魔、地标
                if (this.type == CardDB.cardtype.SPELL)
                {
                    retval.RemoveAll(minion => minion != null &&
                          minion.handcard != null &&
                          minion.handcard.card != null &&
                          minion.handcard.card.Elusive);
                    retval.RemoveAll(minion => minion != null &&
                          minion.handcard != null &&
                          minion.handcard.card != null &&
                          minion.handcard.card.type == CardDB.cardtype.LOCATION);
                }

                if (retval.Count == 0 && (!wereTargets || REQ_TARGET_IF_AVAILABLE)) retval.Add(null);

                return retval;
            }

            /// <summary>
            /// 获取英雄技能的目标
            /// </summary>
            /// <param name="p">场面</param>
            /// <param name="own">是否自己打出</param>
            /// <returns></returns>
            public List<Minion> getTargetsForHeroPower(Playfield p, bool own)
            {

                var targetsForHeroPower = getTargetsForCard(p, p.isLethalCheck, own);
                var abName = own ? p.ownHeroAblility.card.nameEN : p.enemyHeroAblility.card.nameEN;
                var abType = 0; //0 none, 1 damage, 2 heal, 3 buff
                switch (abName)
                {
                    case cardNameEN.heal:
                    case cardNameEN.lesserheal:
                        if (p.anzOwnAuchenaiSoulpriest > 0 || p.embracetheshadow > 0) abType = 1;
                        else abType = 2;
                        break;
                    case cardNameEN.ballistashot: abType = 1; break;
                    case cardNameEN.steadyshot: abType = 1; break;
                    case cardNameEN.fireblast: abType = 1; break;
                    case cardNameEN.fireblastrank2: abType = 1; break;
                    case cardNameEN.lightningjolt: abType = 1; break;
                    case cardNameEN.mindspike: abType = 1; break;
                    case cardNameEN.mindshatter: abType = 1; break;
                    case cardNameEN.powerofthefirelord: abType = 1; break;
                    case cardNameEN.shotgunblast: abType = 1; break;
                    case cardNameEN.unbalancingstrike: abType = 1; break;
                    case cardNameEN.dinomancy: abType = 3; break;
                }

                switch (abType)
                {
                    case 2:
                        List<Minion> minions = own ? p.ownMinions : p.enemyMinions;
                        int tCount = minions.Count;
                        bool needCut = true;
                        for (int i = 0; i < tCount; i++)
                        {
                            switch (minions[i].name)
                            {
                                case cardNameEN.shadowboxer:
                                    if (own && p.enemyHero.Hp == 1 && p.enemyMinions.Count > 0) needCut = false;
                                    break;
                                case cardNameEN.holychampion: needCut = false; break;
                                case cardNameEN.lightwarden: needCut = false; break;
                                case cardNameEN.northshirecleric: needCut = false; break;


                            }
                        }

                        tCount = targetsForHeroPower.Count;
                        if (tCount > 0)
                        {
                            if (targetsForHeroPower[0] != null)
                            {
                                List<Minion> tmp = new List<Minion>();
                                for (int i = 0; i < tCount; i++)
                                {
                                    Minion m = targetsForHeroPower[i];
                                    if (m.Hp < m.maxHp)
                                    {
                                        if (needCut)
                                        {
                                            if (m.own == own) tmp.Add(m);
                                        }
                                        else tmp.Add(m);
                                    }
                                }
                                return tmp;
                            }
                        }
                        break;
                }

                //移除扰魔的随从
                targetsForHeroPower.RemoveAll(minion => minion != null &&
                                                        minion.handcard != null &&
                                                        minion.handcard.card != null &&
                                                        minion.handcard.card.Elusive);
                //移除地标
                targetsForHeroPower.RemoveAll(minion => minion != null &&
                                                        minion.handcard != null &&
                                                        minion.handcard.card != null &&
                                                        minion.handcard.card.type == CardDB.cardtype.LOCATION);

                return targetsForHeroPower;
            }

            /// <summary>
            /// 获得地标卡牌的目标
            /// </summary>
            /// <param name="p">当前的游戏状态</param>
            /// <param name="isLethalCheck">是否进行斩杀检测</param>
            /// <param="own">是否为自己的回合</param>
            /// <returns>返回可以选择的随从目标列表</returns>
            public List<Minion> getTargetsForLocation(Playfield p, bool isLethalCheck, bool own)
            {
                List<Minion> retval = new List<Minion>();
                if (this.sim_card.GetUseAbilityReqs().Length == 0) { retval.Add(null); return retval; }

                List<Minion> targets = new List<Minion>();
                bool targetAll = false;
                bool targetAllEnemy = false;
                bool targetAllFriendly = false;
                bool targetEnemyHero = false;
                bool targetOwnHero = false;
                bool targetOnlyMinion = false;
                bool extraParam = false;
                bool wereTargets = false;
                bool REQ_DAMAGED_TARGET = false;
                bool REQ_TARGET_WITH_DEATHRATTLE = false;
                bool REQ_TARGET_WITH_RACE = false;

                foreach (PlayReq pr in this.sim_card.GetUseAbilityReqs())
                {
                    switch (pr.errorType)
                    {
                        case ErrorType2.REQ_TARGET_TO_PLAY:
                            targetAll = true;
                            continue;
                        case ErrorType2.REQ_MINION_TARGET:
                            targetOnlyMinion = true;
                            continue;
                        case ErrorType2.REQ_FRIENDLY_TARGET:
                            if (own) targetAllFriendly = true;
                            else targetAllEnemy = true;
                            continue;
                        case ErrorType2.REQ_ENEMY_TARGET:
                            if (own) targetAllEnemy = true;
                            else targetAllFriendly = true;
                            continue;
                        case ErrorType2.REQ_DAMAGED_TARGET:
                            REQ_DAMAGED_TARGET = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_TARGET_WITH_DEATHRATTLE:
                            REQ_TARGET_WITH_DEATHRATTLE = true;
                            targetOnlyMinion = true;
                            extraParam = true;
                            continue;
                        case ErrorType2.REQ_TARGET_WITH_RACE:
                            REQ_TARGET_WITH_RACE = true;
                            targetOnlyMinion = true;
                            extraParam = true;
                            continue;
                    }
                }

                foreach (var pr in this.sim_card.GetUseAbilityReqs()) pr.UpdateCardAttr(this);

                if (targetAll)
                {
                    wereTargets = true;
                    if (targetAllFriendly != targetAllEnemy)
                    {
                        if (targetAllFriendly)
                        {
                            foreach (Minion m in p.ownMinions) if (!m.untouchable) targets.Add(m);
                        }
                        else
                        {
                            foreach (Minion m in p.enemyMinions) if (!m.untouchable) targets.Add(m);
                        }
                    }
                    else
                    {
                        foreach (Minion m in p.ownMinions) if (!m.untouchable) targets.Add(m);
                        foreach (Minion m in p.enemyMinions) if (!m.untouchable) targets.Add(m);
                    }
                    if (targetOnlyMinion)
                    {
                        targetEnemyHero = false;
                        targetOwnHero = false;
                    }
                    else
                    {
                        if (!p.enemyHero.immune) targetEnemyHero = true;
                        if (!p.ownHero.immune) targetOwnHero = true;
                        if (targetAllEnemy) targetOwnHero = false;
                        if (targetAllFriendly) targetEnemyHero = false;
                    }
                }

                if (extraParam)
                {
                    wereTargets = true;
                    if (REQ_DAMAGED_TARGET)
                    {
                        foreach (Minion m in targets)
                        {
                            if (!m.wounded)
                            {
                                m.extraParam = true;
                            }
                        }
                        targetOwnHero = false;
                        targetEnemyHero = false;
                    }
                    if (REQ_TARGET_WITH_DEATHRATTLE)
                    {
                        foreach (Minion m in targets)
                        {
                            if (!m.silenced && (m.handcard.card.deathrattle || m.deathrattle2 != null)) continue;
                            else m.extraParam = true;
                        }
                        targetOwnHero = false;
                        targetEnemyHero = false;
                    }
                    if (REQ_TARGET_WITH_RACE)
                    {
                        foreach (Minion m in targets)
                        {
                            // 不满足使用条件（或者是融合怪）
                            if (m.handcard.card.race != (Race)this.needRaceForPlaying && m.handcard.card.race != Race.ALL) m.extraParam = true;
                        }
                        targetOwnHero = false;
                        targetEnemyHero = false;

                    }
                }

                if (targetEnemyHero && own && p.enemyHero.stealth) targetEnemyHero = false;
                if (targetOwnHero && !own && p.ownHero.stealth) targetOwnHero = false;

                // 斩杀检测
                if (isLethalCheck)
                {
                    if (targetEnemyHero && own) retval.Add(p.enemyHero);
                    else if (targetOwnHero && !own) retval.Add(p.ownHero);

                    foreach (Minion m in targets)
                    {
                        if (m.extraParam != true)
                        {
                            if (m.stealth && !m.own) continue;
                            retval.Add(m);
                        }
                        m.extraParam = false;
                    }
                }
                else
                {
                    if (targetEnemyHero) retval.Add(p.enemyHero);
                    if (targetOwnHero) retval.Add(p.ownHero);

                    foreach (Minion m in targets)
                    {
                        if (m.extraParam != true)
                        {
                            if (m.stealth && !m.own) continue;
                            if (m.cantBeTargetedBySpellsOrHeroPowers && (this.type == cardtype.SPELL || this.type == cardtype.HEROPWR)) continue;
                            retval.Add(m);
                        }
                        m.extraParam = false;
                    }
                }
                //移除不可接触的随从
                retval.RemoveAll(minion => minion != null &&
                                                        minion.handcard != null &&
                                                        minion.handcard.card != null &&
                                                        minion.handcard.card.untouchable);
                //移除地标
                retval.RemoveAll(minion => minion != null &&
                                                        minion.handcard != null &&
                                                        minion.handcard.card != null &&
                                                        minion.handcard.card.type == CardDB.cardtype.LOCATION);


                // 如果没有找到合适的目标且没有特定目标要求，则返回null
                if (retval.Count == 0 && !wereTargets)
                {
                    retval.Add(null);
                }

                return retval;
            }

            /// <summary>
            /// 计算费用 会减费的牌需要在里面写
            /// </summary>
            /// <param name="p"></param>
            /// <returns></returns>
            public int calculateManaCost(Playfield p)//calculates the mana from orginal mana, needed for back-to hand effects and new draw
            {
                int retval = this.cost;//卡牌本身的费用
                int offset = 0;//每个随从的减费

                if (p.anzOwnShadowfiend > 0) offset -= p.anzOwnShadowfiend;//暗影狂乱 需要费用减去抓的怪费用

                switch (this.type)
                {
                    case cardtype.MOB:
                        if (p.anzOwnAviana > 0) retval = 1;//av娜

                        if (p.anzOwnScargil > 0 && (this.race == Race.MURLOC || this.race == Race.ALL)) retval = 1;//斯卡基尔

                        if (p.ownDemonCostLessOnce > 0 && (this.race == Race.DEMON || this.race == Race.ALL))
                            offset -= p.ownDemonCostLessOnce;

                        offset += p.ownMinionsCostMore;//随从消耗更多

                        if (this.deathrattle) offset += p.ownDRcardsCostMore;

                        offset += p.managespenst;

                        int temp = -(p.startedWithbeschwoerungsportal) * 2;
                        if (retval + temp <= 0) temp = -retval + 1;//传送门 负数
                        offset = offset + temp;

                        if (p.mobsplayedThisTurn == 0)
                        {//消耗血
                            offset -= p.winzigebeschwoererin;
                        }

                        if (this.battlecry)
                        {
                            offset += p.nerubarweblord * 2;//尼鲁巴蛛网领主
                        }

                        if ((TAG_RACE)this.race == TAG_RACE.MECHANICAL)
                        { //if the number of zauberlehrlings change
                            offset -= p.anzOwnMechwarper;//Mechwarper机械跃迁
                        }
                        break;
                    case cardtype.SPELL:
                        if (p.nextSpellThisTurnCost0) return 0;//这个标志位在sim卡里
                        offset += p.ownSpelsCostMore;
                        if (p.playedPreparation)//伺机待发
                        { //if the number of zauberlehrlings change
                            offset -= 2;
                        }
                        break;
                    case cardtype.WEAPON:
                        offset -= p.blackwaterpirate * 2;//黑水海盗
                        if (this.deathrattle) offset += p.ownDRcardsCostMore;
                        break;
                }

                offset -= p.myCardsCostLess;

                switch (this.nameCN)
                {
                    case CardDB.cardNameCN.希望圣契:
                    case CardDB.cardNameCN.正义圣契:
                    case CardDB.cardNameCN.智慧圣契:
                    case CardDB.cardNameCN.审判圣契:
                        retval = retval + offset - p.libram;
                        break;
                }
                retval = retval + offset;
                if (this.Secret)
                {
                    if (p.anzOwnCloakedHuntress > 0 || p.nextSecretThisTurnCost0) retval = 0;
                }

                retval = Math.Max(0, retval);

                return retval;
            }

            /// <summary>
            /// 获取卡牌费用
            /// </summary>
            /// <param name="p"></param>
            /// <param name="currentcost"></param>
            /// <returns></returns>
            public int getManaCost(Playfield p, int currentcost)
            {
                int retval = currentcost;

                // offset < 0费用降低,offset > 0费用增加
                int offset = 0; // if offset < 0 costs become lower, if >0 costs are higher at the end

                // CARDS that increase/decrease the manacosts of others ##############################
                //卡片增加减少卡片法力消耗
                switch (this.type)
                {
                    case cardtype.HEROPWR:
                        retval += p.ownHeroPowerCostLessOnce;
                        if (retval < 0) retval = 0;
                        return retval;
                    case cardtype.MOB:

                        if (p.ownMinionsCostMore != p.ownMinionsCostMoreAtStart)
                        {
                            offset += (p.ownMinionsCostMore - p.ownMinionsCostMoreAtStart);
                        }//


                        if (this.deathrattle && p.ownDRcardsCostMore != p.ownDRcardsCostMoreAtStart)
                        {
                            offset += (p.ownDRcardsCostMore - p.ownDRcardsCostMoreAtStart);
                        }


                        if (p.managespenst != p.startedWithManagespenst)
                        {
                            offset += (p.managespenst - p.startedWithManagespenst);
                        }


                        if (this.battlecry && p.nerubarweblord != p.startedWithnerubarweblord)
                        {
                            offset += (p.nerubarweblord - p.startedWithnerubarweblord) * 2;
                        }


                        if (p.anzOwnAviana > 0)
                        {
                            retval = 1;
                        }

                        if (p.anzOwnScargil > 0 && (this.race == Race.MURLOC || this.race == Race.ALL))
                        {
                            retval = 1;
                        }

                        if (p.anzOwnMechwarper != p.anzOwnMechwarperStarted && (TAG_RACE)this.race == TAG_RACE.MECHANICAL)
                        {
                            offset += (p.anzOwnMechwarperStarted - p.anzOwnMechwarper);
                        }


                        if (p.startedWithbeschwoerungsportal != p.beschwoerungsportal)
                        {
                            offset += (p.startedWithbeschwoerungsportal - p.beschwoerungsportal) * 2;
                        }


                        if (p.winzigebeschwoererin != p.startedWithWinzigebeschwoererin && ((p.turnCounter == 0 && p.startedWithMobsPlayedThisTurn == 0) || (p.turnCounter > 0 && p.mobsplayedThisTurn == 0)))
                        {
                            offset += (p.startedWithWinzigebeschwoererin - p.winzigebeschwoererin);
                        }

                        //卫兵
                        if (p.winRazormaneBattleguard != p.startedRazormaneBattleguard && this.tank)
                        {
                            offset -= p.winRazormaneBattleguard * 2;
                        }

                        if (p.anzOwnDragonConsort != p.anzOwnDragonConsortStarted && (TAG_RACE)this.race == TAG_RACE.DRAGON)
                        {
                            offset += (p.anzOwnDragonConsortStarted - p.anzOwnDragonConsort) * 2;
                        }

                        //火光元素
                        if (p.ownElementCost != p.ownElementCostStarted && (TAG_RACE)this.race == TAG_RACE.ELEMENTAL)
                        {
                            offset += p.ownElementCostStarted - p.ownElementCost;
                        }

                        //雷矛军用山羊
                        if (p.ownBeastCostLessOnce != p.ownBeastCostLessOnceStarted && (TAG_RACE)this.race == TAG_RACE.PET)
                        {
                            offset += (p.ownBeastCostLessOnceStarted - p.ownBeastCostLessOnce) * 2;
                        }

                        // 下一张元素随从牌的法力值消耗减少量
                        if (p.nextElementalReduction > 0 && (TAG_RACE)this.race == TAG_RACE.ELEMENTAL)
                        {
                            offset -= p.nextElementalReduction;
                        }

                        // 本回合下一张元素随从牌的法力值消耗减少量
                        if (p.thisTurnNextElementalReduction > 0 && (TAG_RACE)this.race == TAG_RACE.ELEMENTAL)
                        {
                            offset -= p.thisTurnNextElementalReduction;
                        }

                        break;
                    case cardtype.SPELL:

                        if (p.nextSpellThisTurnCost0) return 0;


                        if (p.ownSpelsCostMoreAtStart != p.ownSpelsCostMore)
                        {
                            offset += p.ownSpelsCostMore - p.ownSpelsCostMoreAtStart;
                        }

                        if (p.anzOwnPopGarThePutrid > 0)
                        {
                            offset -= p.anzOwnPopGarThePutrid * 2;
                        }

                        if (p.playedPreparation)
                        {
                            offset -= 2;
                        }
                        break;
                    case cardtype.WEAPON:

                        if (p.blackwaterpirateStarted != p.blackwaterpirate)
                        {
                            offset += (p.blackwaterpirateStarted - p.blackwaterpirate) * 2;
                        }

                        if (this.deathrattle && p.ownDRcardsCostMore != p.ownDRcardsCostMoreAtStart)
                        {
                            offset += (p.ownDRcardsCostMore - p.ownDRcardsCostMoreAtStart);
                        }
                        break;
                }


                if (p.startedWithmyCardsCostLess != p.myCardsCostLess)
                {
                    offset += p.startedWithmyCardsCostLess - p.myCardsCostLess;
                }
                switch (this.nameEN)
                {
                    case CardDB.cardNameEN.frenziedfelwing://狂暴邪翼蝠
                        if (p.enemyHero.Hp < p.enemyHeroTurnStartedHp)
                        {
                            retval = retval + offset - (p.enemyHeroTurnStartedHp - p.enemyHero.Hp);
                        }
                        break;
                    case CardDB.cardNameEN.libramofwisdom: //智慧圣契
                    case CardDB.cardNameEN.libramofjustice: //正义圣契
                    case CardDB.cardNameEN.libramofhope: //希望圣契
                    case CardDB.cardNameEN.libramofjudgment: //审判圣契
                    case CardDB.cardNameEN.libramofjudgment_YOP_011t: //审判圣契已腐蚀
                    case CardDB.cardNameEN.libramofdivinity: //信仰圣契
                    case CardDB.cardNameEN.libramoffaith: //神性圣契
                        retval = retval + offset - p.libram;
                        break;
                    case CardDB.cardNameEN.volcaniclumberer: //火山邪木
                    case CardDB.cardNameEN.dragonsbreath: //龙息术
                    case CardDB.cardNameEN.solemnvigil: //严正警戒
                    case CardDB.cardNameEN.volcanicdrake: //火山幼龙
                    case CardDB.cardNameEN.volcanicdrake_Story_09_VolcanicDrake: //火山幼龙
                        retval = retval + offset - p.ownMinionsDiedTurn - p.enemyMinionsDiedTurn;
                        break;
                    case CardDB.cardNameEN.bookofthedead: //亡者之书
                    case CardDB.cardNameEN.bookofthedead_PVPDR_SCH_Active54: //亡者之书
                    case CardDB.cardNameEN.bookofthedead_ULDA_006: //亡者之书
                    case CardDB.cardNameEN.bookofthedead_VAC_464t24: //亡者之书
                    case CardDB.cardNameEN.reskathepitboss: //矿坑老板雷斯卡
                        retval = retval + offset - p.tempTrigger.ownMinionsDied - p.tempTrigger.enemyMinionsDied;
                        break;
                    case CardDB.cardNameEN.urzulgiant: //乌祖尔巨人
                        retval = retval + offset - p.tempTrigger.ownMinionsDied;
                        break;
                    case CardDB.cardNameEN.mulchmuncher: //植被破碎机
                        retval = retval + offset - p.tempTrigger.ownTreantDied;
                        break;
                    case CardDB.cardNameEN.knightofthewild: //荒野骑士
                    case CardDB.cardNameEN.knightofthewild_WON_003: //荒野骑士
                    case CardDB.cardNameEN.frostsabermatriarch: //霜刃豹头领
                        retval = retval + offset - p.tempTrigger.ownBeastSummoned;
                        break;
                    case CardDB.cardNameEN.fyethesettingsun: //落日灵龙菲伊
                        retval = retval + offset - p.tempTrigger.ownDragonSummoned;
                        break;
                    case CardDB.cardNameEN.cultivation: //栽培
                        retval = retval + offset - p.tempTrigger.ownTreantDied;
                        break;
                    case CardDB.cardNameEN.dreadcorsair: //恐怖海盗
                    case CardDB.cardNameEN.dreadcorsair_NEW1_022: //恐怖海盗
                    case CardDB.cardNameEN.dreadcorsair_VAN_NEW1_022: //恐怖海盗
                    case CardDB.cardNameEN.cuttingclass: //劈砍课程
                    case CardDB.cardNameEN.ravenousdrake: //贪食幼龙
                    case CardDB.cardNameEN.battlehawkstrider: //战斗陆行鸟
                        retval = retval + offset - p.ownWeapon.Angr + p.ownWeaponAttackStarted; // if weapon attack change we change manacost
                        break;
                    case CardDB.cardNameEN.spreadtheword_ETC_384: //散布消息
                        retval = retval + offset - p.ownHero.Angr;
                        break;
                    case CardDB.cardNameEN.thingfrombelow://深渊魔物
                    case CardDB.cardNameEN.gigantotem://图腾巨像
                        if (p.playactions.Count > 0)
                        {
                            foreach (Action a in p.playactions)
                            {
                                if (a.actionType == actionEnum.playcard)
                                {
                                    switch (a.card.card.nameEN)
                                    {
                                        case cardNameEN.tuskarrtotemic: retval -= p.ownBrannBronzebeard + 1; break;
                                        case cardNameEN.splittingaxe://分裂战斧
                                            int ownTotemsCount = 0;
                                            foreach (Minion m in p.ownMinions)
                                            {
                                                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.TOTEM) ownTotemsCount++;
                                            }
                                            retval -= ownTotemsCount;
                                            break;
                                        default:
                                            if ((TAG_RACE)a.card.card.race == TAG_RACE.TOTEM) retval--;
                                            break;
                                    }
                                }
                                else if (a.actionType == actionEnum.useHeroPower)
                                {
                                    switch (a.card.card.nameEN)
                                    {
                                        case cardNameEN.totemiccall: retval--; break;
                                        case cardNameEN.totemicslam: retval--; break;
                                    }
                                }
                            }
                        }
                        retval = retval + offset;
                        break;
                    case CardDB.cardNameEN.mountaingiant: //山岭巨人
                    case CardDB.cardNameEN.mountaingiant_EX1_105: //山岭巨人
                    case CardDB.cardNameEN.mountaingiant_VAN_EX1_105: //山岭巨人
                    case CardDB.cardNameEN.thesunwell: //太阳之井
                    case CardDB.cardNameEN.goldshiregnoll: //闪金镇豺狼人
                    case CardDB.cardNameEN.tableflip: //掀桌子
                    case CardDB.cardNameEN.livinghorizon: //活体天光
                        retval = retval + offset - (p.owncards.Count - 1) + p.ownCardsCountStarted;
                        break;
                    case CardDB.cardNameEN.clockworkgiant: //发条巨人
                        retval = retval + offset - p.enemyAnzCards + p.enemyCardsCountStarted;
                        break;
                    case CardDB.cardNameEN.moltengiant: //熔核巨人
                    case CardDB.cardNameEN.moltengiant_EX1_620: //熔核巨人
                    case CardDB.cardNameEN.moltengiant_LETLT_081_01: //熔核巨人
                    case CardDB.cardNameEN.moltengiant_Story_11_MoltenGiantPuzzle: //熔核巨人
                    case CardDB.cardNameEN.moltengiant_VAN_EX1_620: //熔核巨人
                        retval = retval + offset - p.ownHeroHpStarted + p.ownHero.Hp;
                        break;
                    case CardDB.cardNameEN.frostgiant:
                        retval = retval + offset - p.anzUsedOwnHeroPower;
                        break;
                    case CardDB.cardNameEN.arcanegiant: //奥术巨人
                    case CardDB.cardNameEN.gravehorror: //墓园恐魔
                    case CardDB.cardNameEN.umbralowl: //幽影猫头鹰
                    case CardDB.cardNameEN.umbralowl_DMF_060: //幽影猫头鹰
                        retval = retval + offset - p.spellsplayedSinceRecalc;
                        break;
                    case CardDB.cardNameEN.snowfurygiant: //雪怒巨人
                    case CardDB.cardNameEN.snowfurygiant_ICC_090: //雪怒巨人
                        retval = retval + offset - p.ueberladung;
                        break;
                    case CardDB.cardNameEN.kabalcrystalrunner: //暗金教水晶侍女
                    case CardDB.cardNameEN.kabalcrystalrunner_WON_308: //暗金教水晶侍女
                        retval = retval + offset - 2 * p.secretsplayedSinceRecalc;
                        break;
                    case CardDB.cardNameEN.seagiant: //海巨人
                    case CardDB.cardNameEN.mogufleshshaper: //魔古血肉塑型者
                        {
                            int MinionsCount = 0;

                            foreach (Minion m in p.ownMinions)
                            {
                                if (m.untouchable || m.dormant > 0) continue;
                                if (m.handcard.card.type == cardtype.MOB)
                                    MinionsCount++;
                            }
                            foreach (Minion m in p.ownMinions)
                            {
                                if (m.untouchable || m.dormant > 0) continue;
                                if (m.handcard.card.type == cardtype.MOB)
                                    MinionsCount++;
                            }

                            retval = retval + offset - MinionsCount + p.ownMinionStartCount + p.enemyMinionStartCount;
                        }
                        // retval = retval + offset - p.ownMinions.Count - p.enemyMinions.Count + p.ownMobsCountStarted + p.enemyMobsCountStarted;
                        break;
                    case CardDB.cardNameEN.bloodboilbrute: //沸血蛮兵
                        {
                            int woundedMinionsCount = 0;

                            foreach (Minion m in p.ownMinions)
                            {
                                if (m.untouchable || m.dormant > 0) continue;
                                if (m.handcard.card.type == cardtype.MOB && m.wounded)
                                    woundedMinionsCount++;
                            }
                            foreach (Minion m in p.enemyMinions)
                            {
                                if (m.untouchable || m.dormant > 0) continue;
                                if (m.handcard.card.type == cardtype.MOB && m.wounded)
                                    woundedMinionsCount++;
                            }
                            retval = retval + offset - woundedMinionsCount + p.ownMinionStartCount + p.enemyMinionStartCount;
                        }
                        break;
                    case CardDB.cardNameEN.demonbolt: //恶魔之箭
                        {
                            int ownMinionsCount = 0;
                            if (p.ownMinions.Count > 0)
                            {
                                foreach (Minion m in p.ownMinions)
                                {
                                    if (m.untouchable || m.dormant > 0) continue;
                                    if (m.handcard.card.type == cardtype.MOB)
                                        ownMinionsCount++;
                                }
                            }
                            retval = retval + offset - ownMinionsCount + p.ownMinionStartCount;
                        }
                        break;
                    case CardDB.cardNameEN.rabblebouncer: //场馆保镖
                    case CardDB.cardNameEN.prismaticbeam: //棱彩光束
                    case CardDB.cardNameEN.eredarbrute: //艾瑞达蛮兵
                        {
                            int enemyMinionsCount = 0;
                            if (p.enemyMinions.Count > 0)
                            {
                                foreach (Minion m in p.enemyMinions)
                                {
                                    if (m.untouchable || m.dormant > 0) continue;
                                    if (m.handcard.card.type == cardtype.MOB)
                                        enemyMinionsCount++;
                                }
                            }
                            retval = retval + offset - enemyMinionsCount + p.enemyMinionStartCount;
                        }
                        break;
                    case CardDB.cardNameEN.secondratebruiser: //二流打手
                        retval = retval + offset - ((p.enemyMinions.Count < 3) ? 0 : 2) + ((p.enemyMobsCountStarted < 3) ? 0 : 2);
                        break;
                    case CardDB.cardNameEN.golemagg: //古雷曼格
                        retval = retval + offset - p.ownHeroHpStarted + p.ownHero.Hp;
                        break;
                    case CardDB.cardNameEN.skycapnkragg: //天空上尉库拉格
                        {
                            int costBonusPirate = 0;
                            foreach (Minion m in p.ownMinions)
                            {
                                if (m.handcard.card.race == CardDB.Race.PIRATE || m.handcard.card.race == CardDB.Race.ALL) costBonusPirate++;
                            }
                            retval = retval + offset - costBonusPirate + p.anzOwnPiratesStarted;
                        }
                        break;
                    case CardDB.cardNameEN.everyfinisawesome: //鱼人恩典
                        {
                            int costBonusMurloc = 0;
                            foreach (Minion m in p.ownMinions)
                            {
                                if (m.untouchable || m.dormant > 0) continue;
                                if (m.handcard.card.race == Race.MURLOC || m.handcard.card.race == Race.ALL) costBonusMurloc++;
                            }
                            retval = retval + offset - costBonusMurloc + p.anzOwnMurlocStarted;
                        }
                        break;
                    case CardDB.cardNameEN.solarflare: //阳炎耀斑
                        {
                            int costBonusElemental = 0;
                            foreach (Minion m in p.ownMinions)
                            {
                                if (m.untouchable || m.dormant > 0) continue;
                                if (m.handcard.card.race == Race.ELEMENTAL || m.handcard.card.race == Race.ALL) costBonusElemental++;
                            }
                            retval = retval + offset - costBonusElemental + p.anzOwnElementStarted;
                        }
                        break;
                    case CardDB.cardNameEN.captainslog: //舰长日志
                        {
                            int costBonusDraenei = 0;
                            foreach (Minion m in p.ownMinions)
                            {
                                if (m.untouchable || m.dormant > 0) continue;
                                if (m.handcard.card.race == Race.DRAENEI || m.handcard.card.race == Race.ALL) costBonusDraenei++;
                            }
                            retval = retval + offset - costBonusDraenei + p.anzOwnDraeneiStarted;
                        }
                        break;
                    case CardDB.cardNameEN.aeroponics: //空气栽培
                        {
                            int costBonusTreant = 0;
                            if (p.ownMinions.Count > 0)
                            {
                                foreach (Minion m in p.ownMinions)
                                {
                                    if (m.untouchable || m.dormant > 0) continue;
                                    if (m.handcard.card.Terran)
                                        costBonusTreant++;
                                }
                            }
                            retval = retval + offset - costBonusTreant + p.anzOwnTreantStarted;
                        }
                        break;
                    case CardDB.cardNameEN.fleshgiant: // 血肉巨人
                        retval = retval + offset - p.healOrDamageTimes;
                        break;
                    case CardDB.cardNameEN.crush: //重碾
                        // cost 4 less if we have a dmged minion
                        {
                            bool dmgedminions = false;
                            foreach (Minion m in p.ownMinions)
                            {
                                if (m.wounded) dmgedminions = true;
                            }
                            if (dmgedminions != p.startedWithDamagedMinions)
                            {
                                if (dmgedminions) retval = retval + offset - 4;
                                else retval = retval + offset + 4;
                            }
                        }
                        break;
                    case CardDB.cardNameEN.happyghoul: //开心的食尸鬼
                    case CardDB.cardNameEN.happyghoul_ICC_700: //开心的食尸鬼
                        if (p.healTimes > 0)
                            retval = 0 + offset;
                        break;
                    case CardDB.cardNameEN.wildmagic: //狂野魔法
                        retval = 0;
                        break;
                    case CardDB.cardNameEN.shieldshatter: //裂盾一击
                    case CardDB.cardNameEN.cryptkeeper: //地穴看守者
                        retval = retval + offset - p.ownHero.armor;
                        break;
                    case CardDB.cardNameEN.safetygoggles: //安全护目镜'
                        if (p.ownHero.armor == 0)
                            retval = 0;
                        break;
                    case CardDB.cardNameEN.frostwolfwarmaster: //霜狼将领
                    case CardDB.cardNameEN.scribblingstenographer: //潦草的书记员
                    case CardDB.cardNameEN.scribblingstenographer_MAW_020: //潦草的书记员
                    case CardDB.cardNameEN.everburningphoenix: //永燃火凤
                        retval = retval + offset - p.cardsPlayedThisTurn;
                        break;
                    case CardDB.cardNameEN.ireboundbrute: //怒缚蛮兵
                    case CardDB.cardNameEN.everythingmustgo: //一件不留
                        retval = retval + offset - p.owncarddraw;
                        break;
                    default:
                        retval = retval + offset;
                        break;
                }

                if (this.Secret && (p.anzOwnCloakedHuntress > 0 || p.nextSecretThisTurnCost0))
                {
                    retval = 0;
                }

                retval = Math.Max(0, retval);

                return retval;
            }

            /// <summary>
            /// 能否打出牌
            /// </summary>
            /// <param name="p"></param>
            /// <param name="manacost"></param>
            /// <param name="own"></param>
            /// <returns></returns>
            public bool canplayCard(Playfield p, int manacost, bool own)
            {
                if (p.mana < this.getManaCost(p, manacost)) return false;
                if (this.getTargetsForCard(p, false, own).Count == 0) return false;
                return true;
            }

            /// <summary>
            /// 打印中文信息用，中文名 + 身材，方便辨识
            /// </summary>
            /// <returns></returns>
            public string chnInfo()
            {
                if (type == cardtype.MOB) //随从
                    return nameCN.ToString() + "(" + Attack + "," + Health + ")";
                else
                    return nameCN.ToString();
            }

            /// <summary>
            /// 获取泰坦卡牌的技能列表
            /// </summary>
            public List<CardDB.Card> GetTitanAbility()
            {
                var titanSkills = new List<CardDB.Card>();

                switch (this.cardIDenum.ToString())
                {
                    case "TTN_092":
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_092t1)); // 守护秩序
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_092t2)); // 统帅风范
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_092t3)); // 迅疾挥剑
                        break;
                    case "TTN_075":
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_075t)); // 元尊之力
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_075t2)); // 远古知识
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_075t3)); // 无限潜能
                        break;
                    case "TTN_800":
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_800t2)); // 天空之王
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_800t)); // 狂海怒涛
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_800t3)); // 沙加恩之怒
                        break;
                    case "TTN_415":
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_415t)); // 泰坦锻造
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_415t2)); // 升温回火
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_415t3)); // 烈焰之心
                        break;
                    case "TTN_858":
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_858t1)); // 增援
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_858t2)); // 强化
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_858t3)); // 平静
                        break;
                    case "TTN_429":
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_429t)); // 塑造星辰
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_429t2)); // 扫出历史
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_429t3)); // 英雄视界
                        break;
                    case "TTN_862":
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_862t1)); // 雕琢晶石
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_862t2)); // 力量展现
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_862t3)); // 阿古尼特大军
                        break;
                    case "TTN_737":
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_737t)); // 鲜血符文
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_737t3)); // 冰霜符文
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_737t1)); // 邪恶符文
                        break;
                    case "TTN_960":
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_960t2)); // 打入虚空！
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_960t3)); // 地狱火！
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_960t4)); // 军团进攻！
                        break;
                    case "YOG_516":
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.YOG_516t)); // 混沌统治
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.YOG_516t2)); // 诱引狂乱
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.YOG_516t3)); // 触须攒聚
                        break;
                    case "TTN_903":
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_903t)); // 自行生长
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_903t2)); // 丰饶收获
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_903t3)); // 繁茂似锦
                        break;
                    case "TTN_721":
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_721t)); // 加装火炮！
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_721t1)); // 动力全开！
                        titanSkills.Add(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_721t2)); // 防御拉满！
                        break;
                }

                return titanSkills;
            }
        }

        List<Card> cardlist = new List<Card>();
        Dictionary<cardIDEnum, Card> cardidToCardList = new Dictionary<cardIDEnum, Card>();
        Dictionary<string, Card> carddbfidToCardList = new Dictionary<string, Card>();
        Dictionary<cardNameCN, Card> cardNameCNToCardList = new Dictionary<cardNameCN, Card>();
        Dictionary<cardNameEN, Card> cardNameENToCardList = new Dictionary<cardNameEN, Card>();


        public Card unknownCard;
        public bool installedWrong = false;

        public Card burlyrockjaw;
        private static CardDB instance;

        //定义三个稀有度的宝藏卡牌池
        public Dictionary<string, List<cardIDEnum>> treasurePools;

        public static CardDB Instance
        {
            get
            {
                if (instance == null)
                {
                    Helpfunctions.Instance.ErrorLog("开始加载CardDB");
                    var dt = DateTime.Now;
                    instance = new CardDB();
                    //instance.enumCreator();// only call this to get latest cardids
                    // have to do it 2 times (or the kids inside the simcards will not have a simcard :D
                    Helpfunctions.Instance.ErrorLog("开始加载Sim");
                    foreach (Card c in instance.cardlist)
                    {
                        if (c.cardIDenum != cardIDEnum.None)  // 增加非None判断
                            c.sim_card = CardHelper.GetCardSimulation(c.cardIDenum);
                        if (c.sim_card == null) continue;
                        foreach (var pr in c.sim_card.GetPlayReqs()) pr.UpdateCardAttr(c);
                    }
                    Helpfunctions.Instance.ErrorLog("加载完毕,总计用时: " + (DateTime.Now - dt).TotalSeconds + " s");
                    instance.setAdditionalData();
                }
                return instance;
            }
        }
        //解析 carddefs.xml的函数
        CardDB()
        {
            this.cardlist.Clear();
            this.cardidToCardList.Clear();
            this.carddbfidToCardList.Clear();
            this.cardNameCNToCardList.Clear();
            this.cardNameENToCardList.Clear();

            treasurePools = new Dictionary<string, List<cardIDEnum>>
            {
                { "common", new List<cardIDEnum> {
                    cardIDEnum.WW_001t4,
                    cardIDEnum.WW_001t,
                    cardIDEnum.WW_001t2,
                    cardIDEnum.WW_001t18,
                    cardIDEnum.WW_001t3,
                    cardIDEnum.DEEP_999t1,
                }},
                { "rare", new List<cardIDEnum> {
                    cardIDEnum.WW_001t16,
                    cardIDEnum.WW_001t7,
                    cardIDEnum.WW_001t8,
                    cardIDEnum.WW_001t5,
                    cardIDEnum.WW_001t9,
                    cardIDEnum.DEEP_999t2,
                }},
                { "epic", new List<cardIDEnum> {
                    cardIDEnum.WW_001t11,
                    cardIDEnum.WW_001t17,
                    cardIDEnum.WW_001t13,
                    cardIDEnum.WW_001t12,
                    cardIDEnum.WW_001t14,
                    cardIDEnum.DEEP_999t3,
                }},
            };

            //placeholdercard
            this.cardlist.Add(new Card { nameEN = cardNameEN.unknown, cost = 10 });
            this.unknownCard = cardlist[0];

            var filePath = Path.Combine(Settings.Instance.path, "CardDefs.xml");
            if (!File.Exists(filePath))
            {
                Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                Helpfunctions.Instance.ErrorLog("在" + Settings.Instance.path + "下找不到 CardDefs.xml!");
                Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                return;
            }
            var reNameEN = new Regex("[a-zA-Z0-9]");
            var reNameCN = new Regex("[a-zA-Z0-9]|[\\u4e00-\\u9fa5]");

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            var entities = doc.SelectNodes("CardDefs/Entity");
            foreach (XmlElement entity in entities)
            {
                var cardId = entity.GetAttribute("CardID");
                var card = new Card();
                card.dbfId = entity.GetAttribute("ID");
                card.cardIDenum = this.cardIdstringToEnum(cardId);
                if (cardId.EndsWith("t") ||
                    cardId.Equals("ds1_whelptoken") ||
                    cardId.Equals("CS2_mirror") ||
                    cardId.Equals("CS2_050") ||
                    cardId.Equals("CS2_052") ||
                    cardId.Equals("CS2_051") ||
                    cardId.Equals("NEW1_009") ||
                    cardId.Equals("CS2_152") ||
                    cardId.Equals("CS2_boar") ||
                    cardId.Equals("EX1_tk11") ||
                    cardId.Equals("EX1_506a") ||
                    cardId.Equals("skele21") ||
                    cardId.Equals("EX1_tk9") ||
                    cardId.Equals("EX1_finkle") ||
                    cardId.Equals("EX1_598") ||
                    cardId.Equals("EX1_tk34"))
                {
                    card.isToken = true;
                }

                //parse tags
                foreach (XmlElement tag in entity.ChildNodes)
                {
                    if (!tag.HasAttribute("enumID"))
                        continue;
                    if ("ReferencedTag".Equals(tag.Name))
                    {
                        if (tag.GetAttribute("enumID") == "1518")
                        {
                            card.dormant = 1;
                        }
                        if (tag.GetAttribute("enumID") == "190")
                        {
                            card.tank = true;
                        }
                        continue;
                    }

                    switch (tag.GetAttribute("enumID"))
                    {
                        case "643":
                            {
                                card.Nature = true;
                            }
                            break;
                        case "321":
                            {
                                card.Collectable = true;
                            }
                            break;
                        case "227":
                            {
                                card.CantAttack = true;
                            }
                            break;
                        case "45":
                            {
                                card.Health = int.Parse(tag.GetAttribute("value"));
                            }
                            break;
                        case "199":
                            {
                                card.Class = int.Parse(tag.GetAttribute("value"));
                            }
                            break;
                        case "47":
                            {
                                card.Attack = int.Parse(tag.GetAttribute("value"));
                            }
                            break;
                        case "200":
                            {
                                card.race = (Race)int.Parse(tag.GetAttribute("value"));
                                //TODO:双种族代码
                                card.races.Add((Race)int.Parse(tag.GetAttribute("value")));
                            }
                            break;
                        case "203":
                            {
                                card.rarity = int.Parse(tag.GetAttribute("value"));
                            }
                            break;
                        case "48":
                            {
                                card.cost = int.Parse(tag.GetAttribute("value"));
                            }
                            break;
                        case "202":
                            {
                                card.type = (cardtype)int.Parse(tag.GetAttribute("value"));
                            }
                            break;
                        case "184":
                            {
                                foreach (XmlElement node in tag.ChildNodes)
                                {
                                    if (node.Name == "zhCN")
                                    {
                                        card.textCN = node.InnerText;
                                    }
                                }
                            }
                            break;
                        case "185":
                            {
                                foreach (XmlElement node in tag.ChildNodes)
                                {
                                    if (node.Name == "enUS")
                                    {
                                        var nameEN = "";
                                        foreach (Match m in reNameEN.Matches(node.InnerText))
                                        {
                                            if (m.Success)
                                                nameEN += m.Value;
                                        }
                                        if (nameEN == "continue" || nameEN == "protected")
                                            nameEN = "@" + nameEN;
                                        if (nameEN.Length > 0 && char.IsDigit(nameEN[0]))
                                            nameEN = "_" + nameEN;
                                        nameEN = nameEN.ToLower();
                                        card.nameEN = this.cardNameENstringToEnum(nameEN);
                                    }
                                    else if (node.Name == "zhCN")
                                    {
                                        var nameCN = "";
                                        foreach (Match m in reNameCN.Matches(node.InnerText))
                                        {
                                            if (m.Success)
                                                nameCN += m.Value;
                                        }
                                        if (nameCN == "continue" || nameCN == "protected")
                                            nameCN = "@" + nameCN;
                                        if (nameCN.Length > 0 && char.IsDigit(nameCN[0]))
                                            nameCN = "_" + nameCN;
                                        card.nameCN = this.cardNameCNstringToEnum(nameCN);
                                    }
                                }
                            }
                            break;
                        case "443":
                            {
                                card.choice = true;
                            }
                            break;
                        case "363":
                            {
                                card.poisonous = true;
                            }
                            break;
                        case "212":
                            {
                                card.Enrage = true;
                            }
                            break;
                        case "338":
                            {
                                card.oneTurnEffect = true;
                            }
                            break;
                        case "362":
                            {
                                card.Aura = true;
                            }
                            break;
                        case "190":
                            {
                                card.tank = true;
                            }
                            break;
                        case "218":
                            {
                                card.battlecry = true;
                            }
                            break;
                        case "415":
                            {
                                card.discover = true;
                            }
                            break;
                        case "189":
                            {
                                card.windfury = true;
                            }
                            break;
                        case "217":
                            {
                                card.deathrattle = true;
                            }
                            break;
                        case "403":
                            {
                                card.Inspire = true;
                            }
                            break;
                        case "187":
                            {
                                card.Durability = int.Parse(tag.GetAttribute("value"));
                            }
                            break;
                        case "114":
                            {
                                card.Elite = true;
                            }
                            break;
                        case "220":
                            {
                                card.Combo = true;
                            }
                            break;
                        case "1637":
                            {
                                card.Frenzy = true;
                            }
                            break;
                        case "1920":
                            {
                                card.HonorableKill = true;
                            }
                            break;
                        case "923":
                            {
                                card.Overkill = true;
                                break;
                            }
                        case "215":
                            {
                                card.overload = int.Parse(tag.GetAttribute("value"));
                            }
                            break;
                        case "685":
                            {
                                card.lifesteal = true;
                            }
                            break;
                        case "448":
                            {
                                card.untouchable = true;
                            }
                            break;
                        case "191":
                            {
                                card.Stealth = true;
                            }
                            break;
                        case "219":
                            {
                                card.Secret = true;
                            }
                            break;
                        case "462":
                            {
                                card.Quest = true;
                            }
                            break;
                        case "1725":
                            {
                                card.Questline = true;
                            }
                            break;
                        case "208":
                            {
                                card.Freeze = true;
                            }
                            break;
                        case "350":
                            {
                                card.AdjacentBuff = true;
                            }
                            break;
                        case "194":
                            {
                                card.Shield = true;
                            }
                            break;
                        case "197":
                            {
                                card.Charge = true;
                            }
                            break;
                        case "339":
                            {
                                card.Silence = true;
                            }
                            break;
                        case "293":
                            {
                                card.Morph = true;
                            }
                            break;
                        case "192":
                            {
                                card.Spellpower = true;
                                card.spellpowervalue = int.Parse(tag.GetAttribute("value"));
                            }
                            break;
                        case "791":
                            {
                                card.Rush = true;
                            }
                            break;
                        case "1085":
                            {
                                card.reborn = true;
                            }
                            break;
                        case "1427":
                            {
                                card.Spellburst = true;
                            }
                            break;
                        case "1452":
                            {
                                card.Corrupted = true;
                            }
                            break;
                        case "1524":
                            {
                                card.Corrupt = true;
                            }
                            break;
                        case "1635":
                            {
                                card.SpellSchool = (SpellSchool)int.Parse(tag.GetAttribute("value"));
                            }
                            break;
                        case "1518":
                            {
                                card.dormant = 1;
                            }
                            break;
                        case "1333":
                            {
                                card.Outcast = true;
                            }
                            break;
                        case "1720":
                            {
                                card.Tradeable = true;
                            }
                            break;
                        case "1743":
                            {
                                card.DECK_ACTION_COST = int.Parse(tag.GetAttribute("value"));
                            }
                            break;
                        case "2":
                            {
                                card.TAG_SCRIPT_DATA_NUM_1 = int.Parse(tag.GetAttribute("value"));
                            }
                            break;
                        case "3":
                            {
                                card.TAG_SCRIPT_DATA_NUM_2 = int.Parse(tag.GetAttribute("value"));
                            }
                            break;
                        case "2889":
                            {
                                card.TAG_SCRIPT_DATA_NUM_3 = int.Parse(tag.GetAttribute("value"));
                            }
                            break;
                        case "2919":
                            {
                                card.TAG_SCRIPT_DATA_NUM_4 = int.Parse(tag.GetAttribute("value"));
                            }
                            break;
                        case "2332":
                            {
                                card.Dredge = true;//探底
                            }
                            break;
                        case "2456":
                            {
                                //排除冥界侍从
                                if (cardId != "MAW_031")
                                {
                                    card.Infuse = true;//注能
                                }
                            }
                            break;
                        case "2457":
                            {
                                card.Infused = true;//已注能
                            }
                            break;
                        case "2498":
                            {
                                card.Manathirst = int.Parse(tag.GetAttribute("value"));//法力渴求
                            }
                            break;
                        case "2820":
                            {
                                card.Finale = true;//压轴
                            }
                            break;
                        case "2821":
                            if (!"ReferencedTag".Equals(tag.Name))
                            {
                                card.Overheal = true;//过量治疗
                            }
                            break;
                        case "2772":
                            if (!"ReferencedTag".Equals(tag.Name))
                            {
                                card.Titan = true;//泰坦
                            }
                            break;
                        case "2785":
                            {
                                card.Forge = true;//锻造
                            }
                            break;
                        case "3011":
                            {
                                card.Forged = true;//已锻造
                            }
                            break;
                        case "2905":
                            {
                                card.Quickdraw = true;//快枪
                            }
                            break;
                        case "3114":
                            {
                                card.Excavate = true;//发掘
                            }
                            break;
                        case "1211":
                            {
                                card.Elusive = true;//扰魔
                            }
                            break;
                        case "846":
                            if (!"ReferencedTag".Equals(tag.Name))
                            {
                                card.Echo = true; // 回响
                            }
                            break;
                        case "1114":
                            {
                                card.nonKeywordEcho = true; // 非关键词回响
                                break;
                            }
                        case "1193":
                            {
                                card.Twinspell = true; // 双生法术
                                break;
                            }
                        case "3630":
                            if (!"ReferencedTag".Equals(tag.Name))
                            {
                                card.Temporary = true;//临时
                            }
                            break;
                        case "373":
                            {
                                card.immuneWhileAttacking = true; // 攻击时免疫
                            }
                            break;
                        case "380":
                            {
                                card.heroPower = cardIdstringToEnum(tag.GetAttribute("cardID")); // 英雄牌技能
                            }
                            break;
                        case "292":
                            {
                                card.armor = int.Parse(tag.GetAttribute("value")); // 英雄牌护甲
                            }
                            break;

                        case "1077":
                            {
                                card.CastsWhenDrawn = int.Parse(tag.GetAttribute("value")); // 抽到时触发效果的属性
                            }
                            break;
                        case "1749":
                            {
                                card.Objective = int.Parse(tag.GetAttribute("value")); // 光环 如救生光环
                            }
                            break;
                        case "2311":
                            {
                                card.ObjectiveAura = int.Parse(tag.GetAttribute("value")); // 会影响场面的光环 如征战平原
                            }
                            break;
                        case "2329":
                            {
                                card.Sigil = int.Parse(tag.GetAttribute("value")); // 咒符
                            }
                            break;
                        case "2196":
                            {
                                card.costBlood = int.Parse(tag.GetAttribute("value")); // 鲜血符文
                            }
                            break;
                        case "2197":
                            {
                                card.costFrost = int.Parse(tag.GetAttribute("value")); // 冰霜符文
                            }
                            break;
                        case "2198":
                            {
                                card.costUnholy = int.Parse(tag.GetAttribute("value")); // 邪恶符文
                            }
                            break;
                        case "994":
                            {
                                card.markOfEvil = true; // 跟班
                            }
                            break;
                        case "2831":
                            {
                                card.Treant = true; // 树人
                            }
                            break;
                        case "1965":
                            {
                                card.IMP = true; // 小鬼
                            }
                            break;
                        case "2355":
                            {
                                card.Whelp = true; // 雏龙
                            }
                            break;
                        case "3555":
                            {
                                card.StarshipPiece = true; // 星舰组件
                            }
                            break;
                        case "3568":
                            {
                                card.Starship = true; // 星舰
                            }
                            break;
                        case "3631":
                            {
                                card.Crewmate = true; // 乘务员
                            }
                            break;
                        case "476":
                            {
                                card.MultipleClasses = int.Parse(tag.GetAttribute("value")); // 194: 玉莲帮  296: 暗金教 532: 玉莲帮
                            }
                            break;
                        case "3457":
                            {
                                card.Zerg = true; // 异虫
                            }
                            break;
                        case "3458":
                            {
                                card.Terran = true; // 人族
                            }
                            break;
                        case "3469":
                            {
                                card.Protoss = true; // 星灵
                            }
                            break;
                        //TODO:双种族代码
                        case "2524":
                            {
                                card.races.Add(Race.DRAENEI); // 添加第二种族德莱尼
                            }
                            break;
                        case "2534":
                            {
                                card.races.Add(Race.UNDEAD); // 添加第二种族亡灵
                            }
                            break;
                        case "2536":
                            {
                                card.races.Add(Race.MURLOC); // 添加第二种族鱼人
                            }
                            break;
                        case "2537":
                            {
                                card.races.Add(Race.DEMON); // 添加第二种族恶魔
                            }
                            break;
                        case "2539":
                            {
                                card.races.Add(Race.MECHANICAL); // 添加第二种族机械
                            }
                            break;
                        case "2540":
                            {
                                card.races.Add(Race.ELEMENTAL); // 添加第二种族元素
                            }
                            break;
                        case "2542":
                            {
                                card.races.Add(Race.PET); // 添加第二种族野兽
                            }
                            break;
                        case "2543":
                            {
                                card.races.Add(Race.TOTEM); // 添加第二种族图腾
                            }
                            break;
                        case "2522":
                            {
                                card.races.Add(Race.PIRATE); // 添加第二种族海盗
                            }
                            break;
                        case "2523":
                            {
                                card.races.Add(Race.DRAGON); // 添加第二种族龙
                            }
                            break;
                        case "2546":
                            {
                                card.races.Add(Race.QUILBOAR); // 添加第二种族野猪人
                            }
                            break;
                        case "2553":
                            {
                                card.races.Add(Race.NAGA); // 添加第二种族龙
                            }
                            break;

                    }
                }

                cardlist.Add(card);
                if (card.dbfId != null && card.dbfId != "")
                    carddbfidToCardList[card.dbfId] = card;
                if (card.cardIDenum != cardIDEnum.None)
                    cardidToCardList[card.cardIDenum] = card;
                if (card.nameCN != cardNameCN.未知)
                {
                    cardNameCNToCardList[card.nameCN] = card;
                }
                if (card.nameEN != cardNameEN.unknown)
                {
                    cardNameENToCardList[card.nameEN] = card;
                }
            }

            //处理DECK_ACTION_COST、TAG_SCRIPT_DATA_NUM_1、TAG_SCRIPT_DATA_NUM_2等属性
            foreach (Card item in cardlist)
            {
                if (item.Infuse)
                {
                    item.InfuseNum = item.TAG_SCRIPT_DATA_NUM_1;
                }
                if (item.Tradeable)
                {
                    item.TradeCost = item.DECK_ACTION_COST;
                }
                if (item.Forge)
                {
                    item.ForgeCost = item.DECK_ACTION_COST;
                }
            }
        }

        // 根据卡名获取卡
        public Card getCardData(CardDB.cardNameEN cardname)
        {
            Card c;
            if (this.cardNameENToCardList.TryGetValue(cardname, out c))
                return c;
            return this.unknownCard;
        }

        // 根据卡名获取卡
        public Card getCardData(CardDB.cardNameCN cardname)
        {
            Card c;
            if (this.cardNameCNToCardList.TryGetValue(cardname, out c))
                return c;
            return this.unknownCard;
        }

        // 根据id获取卡
        public Card getCardDataFromID(cardIDEnum id)
        {
            Card c;
            if (this.cardidToCardList.TryGetValue(id, out c))
                return c;
            return this.unknownCard;
        }

        // 根据dbfID获取卡
        public Card getCardDataFromDbfID(String dbfID)
        {
            Card c;
            if (this.carddbfidToCardList.TryGetValue(dbfID, out c))
                return c;
            return this.unknownCard;
        }

        private void setAdditionalData()
        {
            PenalityManager pen = PenalityManager.Instance;

            foreach (Card c in this.cardlist)
            {
                if (c.cardIDenum == cardIDEnum.None)
                    continue;                             //Todo: 为了确保Test能跑通

                if (pen.cardDrawBattleCryDatabase.ContainsKey(c.nameEN))
                {
                    c.isCarddraw = pen.cardDrawBattleCryDatabase[c.nameEN];
                }

                if (pen.DamageTargetSpecialDatabase.ContainsKey(c.nameEN))
                {
                    c.damagesTargetWithSpecial = true;
                }

                if (pen.DamageTargetDatabase.ContainsKey(c.nameEN))
                {
                    c.damagesTarget = true;
                }

                if (pen.priorityTargets.ContainsKey(c.nameEN))
                {
                    c.targetPriority = pen.priorityTargets[c.nameEN];
                }

                if (pen.specialMinions.ContainsKey(c.nameEN))
                {
                    c.isSpecialMinion = true;
                }

                c.trigers = new List<cardtrigers>();
                Type trigerType = c.sim_card.GetType();
                foreach (string trigerName in Enum.GetNames(typeof(cardtrigers)))
                {
                    try
                    {
                        foreach (var m in trigerType.GetMethods().Where(e => e.Name.Equals(trigerName, StringComparison.Ordinal)))
                        {
                            if (m.DeclaringType == trigerType)
                                c.trigers.Add((cardtrigers)Enum.Parse(typeof(cardtrigers), trigerName));
                        }
                    }
                    catch
                    {
                    }
                }
                if (c.trigers.Count > 10) c.trigers.Clear();
            }
        }
    }

    /// <summary>
    /// 目标
    /// </summary>
    public struct targett
    {
        public int target;//目标
        public int targetEntity;//目标实体

        public targett(int targ, int ent)
        {
            this.target = targ;
            this.targetEntity = ent;
        }
    }

    /// <summary>
    /// 打出卡牌要求
    /// </summary>
    public struct PlayReq
    {
        public CardDB.ErrorType2 errorType;
        public int param;

        public PlayReq(CardDB.ErrorType2 errorType, int param)
        {
            this.errorType = errorType;
            this.param = param;
        }

        public PlayReq(CardDB.ErrorType2 errorType)
        {
            this.errorType = errorType;
            this.param = -1;
        }
        public void UpdateCardAttr(CardDB.Card card)
        {
            switch (errorType)
            {
                case CardDB.ErrorType2.REQ_TARGET_MAX_ATTACK:
                    card.needWithMaxAttackValueOf = param;
                    break;
                case CardDB.ErrorType2.REQ_TARGET_WITH_RACE:
                    card.needRaceForPlaying = param;
                    break;
                case CardDB.ErrorType2.REQ_NUM_MINION_SLOTS:
                    card.needEmptyPlacesForPlaying = param;
                    break;
                case CardDB.ErrorType2.REQ_MINION_CAP_IF_TARGET_AVAILABLE:
                    card.needMinionsCapIfAvailable = param;
                    break;
                case CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS:
                    card.needMinNumberOfEnemy = param;
                    break;
                case CardDB.ErrorType2.REQ_TARGET_MIN_ATTACK:
                    card.needWithMinAttackValueOf = param;
                    break;
                case CardDB.ErrorType2.REQ_MINIMUM_TOTAL_MINIONS:
                    card.needMinTotalMinions = param;
                    break;
                case CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS:
                    card.needMinOwnMinions = param;
                    break;
                case CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS:
                    card.needControlaSecret = param;
                    break;
            }
        }
    }
}