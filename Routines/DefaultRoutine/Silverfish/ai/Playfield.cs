using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using Triton.Common.LogUtilities;

namespace HREngine.Bots
{
    /// <summary>
    /// todo save "started" variables outside (they doesnt change)
    /// 记录战场数据 标记
    /// </summary>
    public class Playfield
    {
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();

        public bool loatheb = false; //标志洛欧塞布效果是否生效
        public int loathebEffect = 0; //洛欧塞布效果的法力值增加量
        public List<Handmanager.Handcard> enemyHand = new List<Handmanager.Handcard>();//用于存储敌方手牌的字段，这是一个 List 类型的字段，用于存储敌方当前手牌中的所有卡牌对象
        public List<CardDB.Card> ownDeck = new List<CardDB.Card>();//新增ownDeck字段，用于记录玩家的牌库
        public Dictionary<CardDB.cardIDEnum, int> ownGraveyard = new Dictionary<CardDB.cardIDEnum, int>();//坟场，已死亡随从，不包括弃牌
        public List<CardDB.cardIDEnum> ownSecretsIDList = new List<CardDB.cardIDEnum>();
        public List<SecretItem> enemySecretList = new List<SecretItem>();
        public Dictionary<CardDB.cardIDEnum, int> enemyCardsOut = null;
        public List<Playfield> nextPlayfields = new List<Playfield>();
        public List<Minion> ownMinions = new List<Minion>();
        public List<Minion> enemyMinions = new List<Minion>();
        public List<GraveYardItem> diedMinions = null;
        public Dictionary<int, IDEnumOwner> LurkersDB = new Dictionary<int, IDEnumOwner>();
        public List<Handmanager.Handcard> owncards = new List<Handmanager.Handcard>();//玩家手牌
        public List<Action> playactions = new List<Action>();
        public List<int> pIdHistory = new List<int>();

        public string name = "";
        public string enemyGuessDeck = "";
        public bool logging = false;
        public bool complete = false;
        public int bestBoard = 0;
        public bool dirtyTwoTurnSim = false;
        public bool checkLostAct = false;
        public int totalAngr = -1;//场攻
        public int enemyTotalAngr = -1;
        public bool patchesInDeck = true;//可能有帕奇斯
        public int ownMinionsDied = 0;
        public bool anzSolor = false;//日蚀
        public int ownMinionStartCount = 0;//回合开始时己方随从数
        public int enemyMinionStartCount = 0;//回合开始时敌方随从数
        public int healOrDamageTimes = 0;//本回合治疗或受伤次数，巨人用
        public int healTimes = 0;
        public bool setMankrik = false;//曼科里克
        public int deckAngrBuff = 0;//牌库攻击BUFF
        public int deckHpBuff = 0;//牌库生命值BUFF
        public int nextEntity = 70;
        public int pID = 0;
        public bool isLethalCheck = false;
        public int enemyTurnsCount = 0;
        public triggerCounter tempTrigger = new triggerCounter();
        public Hrtprozis prozis = Hrtprozis.Instance;//对局信息
        public int gTurn = 0;
        public int gTurnStep = 0;
        //aura minions########################## 光环随从
        //anz开头的都是某某随从的数量
        public int AnzSoulFragments = 0;// 灵魂残片
        public int anzOwnRaidleader = 0;//团队领袖
        public int anzEnemyRaidleader = 0;
        public int anzOwnVessina = 0;//维西纳
        public int anzEnemyVessina = 0;
        public int anzOwnStormwindChamps = 0;//暴风城勇士
        public int anzEnemyStormwindChamps = 0;
        public int anzOwnWarhorseTrainer = 0;//战马训练师
        public int anzEnemyWarhorseTrainer = 0;
        public int anzOwnTundrarhino = 0;//苔原犀牛
        public int anzEnemyTundrarhino = 0;
        public int anzOwnMrSmite = 0;//重拳先生
        public int anzEnemyMrSmite = 0;
        public int anzOwnTimberWolfs = 0;//森林狼
        public int anzEnemyTimberWolfs = 0;
        public int anzOwnMurlocWarleader = 0;//鱼人领军
        public int anzEnemyMurlocWarleader = 0;
        public int anzAcidmaw = 0;//酸喉
        public int anzOwnGrimscaleOracle = 0;//暗鳞先知
        public int anzEnemyGrimscaleOracle = 0;
        public int anzOwnShadowfiend = 0;//暗影魔
        public int anzOwnAuchenaiSoulpriest = 0;//奥金尼灵魂祭司
        public int anzEnemyAuchenaiSoulpriest = 0;
        public int anzOwnSouthseacaptain = 0;//南海船长
        public int anzEnemySouthseacaptain = 0;
        public int anzOwnMalGanis = 0;//玛尔加尼斯
        public int anzEnemyMalGanis = 0;
        public int anzOwnPiratesStarted = 0;//回合开始海盗数
        public int anzOwnMurlocStarted = 0;//回合开始鱼人数
        public int anzOwnElementStarted = 0;//回合开始元素数
        public int anzOwnDraeneiStarted = 0;//回合开始德莱尼数
        public int anzOwnTreantStarted = 0;//回合开始树人数
        public int anzOwnChromaggus = 0;//克洛玛古斯
        public int anzEnemyChromaggus = 0;
        public int anzOwnDragonConsort = 0;//龙王配偶
        public int anzOwnMurlocConsort = 0;
        public int anzOwnDragonConsortStarted = 0;
        public int ownElementCost = 0;//火光元素
        public int ownElementCostStarted = 0;
        public int ownBeastCostLessOnce = 0;//雷矛军用山羊
        public int ownBeastCostLessOnceStarted = 0;
        public int anzOwnBolfRamshield = 0;//博尔夫·碎盾
        public int anzEnemyBolfRamshield = 0;
        public int anzOwnHorsemen = 0;
        public int anzEnemyHorsemen = 0;
        public int anzOwnAnimatedArmor = 0;//复活的铠甲
        public int anzEnemyAnimatedArmor = 0;
        public int anzMoorabi = 0;//莫拉比
        public int anzDark = 0;//黑眼
        public int anzTamsinroame = 0;//塔姆辛罗姆
        public int anzOldWoman = 0;//虚触侍从
        public bool anzTamsin = false;//术士任务线 SW_091
        public int anzUsedOwnHeroPower = 0;
        public int anzUsedEnemyHeroPower = 0;
        public int anzOwnExtraAngrHp = 0;
        public int anzEnemyExtraAngrHp = 0;
        public int anzOwnMechwarper = 0;//机械跃迁者
        public int anzOwnMechwarperStarted = 0;
        public int anzEnemyMechwarper = 0;
        public int anzEnemyMechwarperStarted = 0;
        public int anzOgOwnCThun = 0; //克苏恩
        public int anzOgOwnCThunHpBonus = 0;
        public int anzOgOwnCThunAngrBonus = 0;
        public int anzOgOwnCThunTaunt = 0;
        public int anzOwnJadeGolem = 0;//青玉魔像
        public int anzEnemyJadeGolem = 0;
        public int anzOwnElementalsThisTurn = 0;  //这回合使用过元素
        public int anzOwnElementalsLastTurn = 0;  //上回合使用过元素
        public int anzEnemyTaunt = 0;
        public int anzOwnTaunt = 0;
        //#########################################

        public int usedUndeadAllies = 0;//不死盟军
        public int ownAbilityFreezesTarget = 0;
        public int enemyAbilityFreezesTarget = 0;
        public int ownHeroPowerCostLessOnce = 0;//英雄技能消耗更小一次
        public int enemyHeroPowerCostLessOnce = 0;
        public int ownHeroPowerCostLessTwice = 0;//英雄技能消耗更小两次
        public int ownDemonCostLessOnce = 0;//恶魔牌的法力值消耗减少
        public int ownHeroPowerExtraDamage = 0;//英雄技能会额外造成伤害
        public int enemyHeroPowerExtraDamage = 0;
        public int ownHeroPowerAllowedQuantity = 1;//英雄技能可以使用次数价值
        public int enemyHeroPowerAllowedQuantity = 1;
        public int useNature = 0;//特定牌在手中时触发是否使用过自然法术
        public int blackwaterpirate = 0;//黑水海盗
        public int blackwaterpirateStarted = 0;
        public int embracetheshadow = 0;//暗影之握
        public int ownCrystalCore = 0;//水晶核心
        public bool ownMinionsInDeckCost0 = false;//“践踏者”班纳布斯，牌库中所有随从的法力值消耗变为（0）点
        public bool LothraxionsPower = false;//使白银之手新兵获得圣盾标志位
        public int ownMinionsDiedTurn = 0;//本回合己方随从死亡的数量
        public int enemyMinionsDiedTurn = 0;//本回合敌方随从死亡的数量
        public bool feugenDead = false;//费尔根
        public bool stalaggDead = false;//斯塔拉格
        public bool weHavePlayedMillhouseManastorm = false;//米尔豪斯·法力风暴
        public bool weHaveSteamwheedleSniper = false;//热砂港狙击手
        public bool enemyHaveSteamwheedleSniper = false;
        public bool ownSpiritclaws = false;//幽灵之爪
        public bool enemySpiritclaws = false;
        public bool needGraveyard = false;//随从死亡
        public int doublepriest = 0;//先知维伦
        public int enemydoublepriest = 0;
        public int ownMistcaller = 0;//唤雾者伊戈瓦尔
        public int lockandload = 0;//子弹上膛
        public int stampede = 0;//奔踏
        public int ownBaronRivendare = 0;//瑞文戴尔男爵
        public int enemyBaronRivendare = 0;
        public int ownBrannBronzebeard = 0;//友方战吼额外触发次数
        public int enemyBrannBronzebeard = 0;//敌方战吼额外触发次数
        public int ownTurnEndEffectsTriggerTwice = 0;//己方达卡莱附魔师，回合结束效果会生效两次
        public int enemyTurnEndEffectsTriggerTwice = 0; //敌方达卡莱附魔师，回合结束效果会生效两次
        public int ownFandralStaghelm = 0;//范达尔·鹿盔
        public int tempanzOwnCards = 0; //手牌数 地精工兵
        public int tempanzEnemyCards = 0;//手牌数 地精工兵
        public bool isOwnTurn = true; //是我的回合
        public int turnCounter = 0;
        public bool attacked = false;// 标记已执行攻击
        public int attackFaceHP = 15;//打脸血量
        public int ownController = 0;
        public int evaluatePenality = 0;
        public int ruleWeight = 0;
        public string rulesUsed = "";
        public bool useSecretsPlayAround = true;
        public bool print = false;
        public Int64 hashcode = 0;
        public float value = Int32.MinValue;
        public int guessingHeroHP = 30;
        public float doDirtyTts = 100000;
        public int mana = 0;
        public int manaTurnEnd = 0;
        public int enemySecretCount = 0;
        public Minion ownHero;
        public Minion enemyHero;
        public HeroEnum ownHeroName = HeroEnum.None;
        public HeroEnum enemyHeroName = HeroEnum.None;
        public TAG_CLASS ownHeroStartClass = TAG_CLASS.INVALID;
        public TAG_CLASS enemyHeroStartClass = TAG_CLASS.INVALID;
        public Weapon ownWeapon = new Weapon();// 玩家当前装备的武器
        public Weapon enemyWeapon = new Weapon();// 玩家当前装备的武器
        public Questmanager.QuestItem ownQuest = new Questmanager.QuestItem();
        public Questmanager.QuestItem enemyQuest = new Questmanager.QuestItem();
        public Questmanager.QuestItem sideQuest = new Questmanager.QuestItem();
        public int owncarddraw = 0;
        public int enemycarddraw = 0;
        public int enemyAnzCards = 0;
        public int libram = 0;//圣契指示物
        public int spellpower = 0;
        public int spellpowerStarted = 0;//回合开始时的法强
        public int enemyspellpower = 0;
        public int enemyspellpowerStarted = 0;
        public int wehaveCounterspell = 0;
        public int lethlMissing = 1000;
        public bool nextSecretThisTurnCost0 = false;
        public bool playedPreparation = false;
        public bool nextSpellThisTurnCost0 = false;
        public bool nextMurlocThisTurnCostHealth = false;
        public bool nextSpellThisTurnCostHealth = false;
        public bool nextAnyCardThisTurnCostEnemyHealth = false;
        public int winzigebeschwoererin = 0;
        public int startedWithWinzigebeschwoererin = 0;
        public int winRazormaneBattleguard = 0;//钢鬃卫兵
        public int startedRazormaneBattleguard = 0;
        public int managespenst = 0;
        public int startedWithManagespenst = 0;
        public int ownMinionsCostMore = 0;
        public int ownMinionsCostMoreAtStart = 0;
        public int ownSpelsCostMore = 0;
        public int ownSpelsCostMoreAtStart = 0;
        public int ownDRcardsCostMore = 0;
        public int ownDRcardsCostMoreAtStart = 0;
        public int beschwoerungsportal = 0;
        public int startedWithbeschwoerungsportal = 0;
        public int myCardsCostLess = 0;
        public int startedWithmyCardsCostLess = 0;
        public int anzOwnAviana = 0; //艾维娜
        public int anzOwnScargil = 0; //斯卡基尔
        public int anzOwnCloakedHuntress = 0;//神秘女猎手
        public int anzOwnRazorfenRockstar = 0; // 剃刀沼泽摇滚明星
        public int anzOwnXB931Housekeeper = 0; // XB-931型家政机
        public int anzOwnPopGarThePutrid = 0;//我方腐臭淤泥波普加
        public int anzEnemyPopGarThePutrid = 0;//敌方腐臭淤泥波普加

        public int nerubarweblord = 0;
        public int startedWithnerubarweblord = 0;
        public bool startedWithDamagedMinions = false; //重碾
        public int ownWeaponAttackStarted = 0;
        public int ownMobsCountStarted = 0;
        public int ownCardsCountStarted = 0;
        public int enemyMobsCountStarted = 0;
        public int enemyCardsCountStarted = 0;
        public int ownHeroHpStarted = 30;
        public int enemyHeroHpStarted = 30;
        public int mobsplayedThisTurn = 0;
        public int startedWithMobsPlayedThisTurn = 0;
        public int spellsplayedSinceRecalc = 0;
        public int secretsplayedSinceRecalc = 0;
        public int optionsPlayedThisTurn = 0;
        public int cardsPlayedThisTurn = 0;
        public int ueberladung = 0;
        public int lockedMana = 0;
        public int enemyOptionsDoneThisTurn = 0;
        public int ownMaxMana = 0;
        public int enemyMaxMana = 0;
        public int lostDamage = 0;
        public int lostHeal = 0;
        public int lostWeaponDamage = 0;
        public int ownDeckSize = 30;
        public int enemyDeckSize = 30;
        public int ownHeroFatigue = 0;
        public int enemyHeroFatigue = 0;
        public bool ownAbilityReady = false;
        public Handmanager.Handcard ownHeroAblility;
        public bool enemyAbilityReady = false;
        public Handmanager.Handcard enemyHeroAblility;
        public Playfield bestEnemyPlay = null;
        public Playfield endTurnState = null;
        public CardDB.cardIDEnum revivingOwnMinion = CardDB.cardIDEnum.None;//只是为了保存用奥秘复活的随从
        public CardDB.cardIDEnum revivingEnemyMinion = CardDB.cardIDEnum.None;
        public CardDB.cardIDEnum OwnLastDiedMinion = CardDB.cardIDEnum.None;
        public int shadowmadnessed = 0; //这一回合随从更换了控制权
        public int enemyHeroTurnStartedHp = 0;
        public int ownHeroTurnStartedHp = 0;
        public List<CardDB.cardIDEnum> sigilsToTriggerOnOwnTurnStart = new List<CardDB.cardIDEnum>();

        //法术派系
        public Dictionary<TAG_SPELL_SCHOOL, int> ownSpellSchoolCounts;
        //伊丽扎·刺刃光环
        public int ownElizagoreblade = 0;
        //回合结束存放的标志
        public List<CardDB.cardIDEnum> cardsToReturnAtEndOfTurn = new List<CardDB.cardIDEnum>();
        //救生光环
        public int ownSunscreenTurns = 0;
        public int enemySunscreenTurns = 0;
        //使用过的亡语牌
        public List<CardDB.cardIDEnum> ownPlayedDeathrattleCards = new List<CardDB.cardIDEnum>();
        public List<CardDB.cardIDEnum> enemyPlayedDeathrattleCards = new List<CardDB.cardIDEnum>();
        //重封者拉兹
        public bool ownHeroPowerCanBeUsedMultipleTimes = false;
        //使用过的随从牌
        public List<CardDB.cardIDEnum> ownMinionsPlayedThisGame = new List<CardDB.cardIDEnum>();
        //当前发掘次数
        public int excavationCount = 0;
        //总发掘次数
        public int allExcavationCount = 0;
        //下个战吼触发次数
        public int nextBattlecryTriggers = 1;
        //用于跟踪己方圣物是否需要双重施放
        public bool ownRelicDoubleCast = false;
        //用于跟踪敌方圣物是否需要双重施放
        public bool enemyRelicDoubleCast = false;
        //标志：下一个召唤的随从是否应该变为5/5
        public bool nextMinionBecomesFiveFive = false;
        //临时的法强
        public int tempSpellPower = 0;
        //下一张抉择牌同时拥有两种效果
        public bool nextChooseOneHasBothEffects = false;
        //鹦鹉乐园，战吼随从牌的法力值消耗减少
        public int parrotSanctuaryCount = 0;
        //小玩物小屋，记录手牌中的最后一张牌的实体ID
        public int lastDrawnCardEntityID = -1;
        //军团进攻
        public bool ownLegionInvasion = false;
        public bool enemyLegionInvasion = false;
        //维和者阿米图斯
        public bool ownAmitusThePeacekeeper = false;
        public bool enemyAmitusThePeacekeeper = false;
        //本回合对敌方英雄造成的伤害
        public int damageDealtToEnemyHeroThisTurn = 0;
        //下一张元素随从牌的法力值消耗减少量
        public int nextElementalReduction = 0;
        //本回合下一张元素随从牌的法力值消耗减少量
        public int thisTurnNextElementalReduction = 0;
        //上次打出的卡牌的费用
        public int lastPlayedCardCost = 0;
        //在本回合是否打出了元素牌
        public bool playedElementalThisTurn = false;
        //本回合打出的元素随从数量
        public int ownElementalsPlayedThisTurn = 0;
        //伞降咒符实现,添加一个全局光环检查
        public void onOwnTurnStart(Playfield p)
        {
            // 检查光环是否结束，召唤三个1/1海盗
            if (p.sigilsToTriggerOnOwnTurnStart.Contains(CardDB.cardIDEnum.VAC_925))
            {
                for (int i = 0; i < 3; i++)
                {
                    summonPirate(p);
                }
                // 移除触发标记
                p.sigilsToTriggerOnOwnTurnStart.Remove(CardDB.cardIDEnum.VAC_925);
            }
        }
        /// <summary>
        /// 在敌方回合开始时调用
        /// </summary>
        public void onEnemyTurnStart()
        {
            if (loatheb)
            {
                // 应用洛欧塞布效果：增大敌方法术的法力值消耗
                applyLoathebEffect();
            }
        }

        /// <summary>
        /// 在敌方回合结束时调用
        /// </summary>
        public void onEnemyTurnEnd()
        {
            // 重置洛欧塞布效果
            loatheb = false;
            loathebEffect = 0;
        }

        /// <summary>
        /// 应用洛欧塞布效果
        /// </summary>
        private void applyLoathebEffect()
        {
            // 这个方法应当在敌方使用法术时调整法力值消耗，具体实现会依赖游戏的规则
        }

        /// <summary>
        /// 方法：将卡牌添加到敌方手牌中
        /// 该方法接收一个 Handmanager.Handcard 对象作为参数，并将其添加到敌方手牌列表中
        /// </summary>
        /// <param name="card"></param>
        public void AddToEnemyHand(Handmanager.Handcard card)
        {
            enemyHand.Add(card);
        }

        /// <summary>
        /// 方法：从敌方手牌中移除卡牌
        /// 该方法接收一个 Handmanager.Handcard 对象作为参数，并从敌方手牌列表中移除该卡牌
        /// </summary>
        /// <param name="card"></param>
        public void RemoveFromEnemyHand(Handmanager.Handcard card)
        {
            enemyHand.Remove(card);
        }

        /// <summary>
        /// 将卡牌添加到牌库
        /// </summary>
        /// <param name="card"></param>
        public void AddToDeck(CardDB.Card card)
        {
            ownDeck.Add(card);
        }

        /// <summary>
        /// 移除牌库中的指定牌
        /// </summary>
        /// <param name="card"></param>
        public void RemoveFromDeck(CardDB.Card card)
        {
            ownDeck.Remove(card);
        }

        /// <summary>
        /// 增加尸体
        /// </summary>
        /// <param name="count"></param>
        public void addCorpses(int count)
        {
            if (!this.ownGraveyard.ContainsKey(CardDB.cardIDEnum.CS2_122))
                this.ownGraveyard.Add(CardDB.cardIDEnum.CS2_122, count);
            else
                this.ownGraveyard[CardDB.cardIDEnum.CS2_122] += count;
        }
        //伞降咒符 海盗帕奇斯降落伞 惊险悬崖 sim实现方法
        public void summonPirate(Playfield p)
        {
            // 冲锋海盗卡牌ID为 "VAC_926t'"
            CardDB.Card pirateCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_926t);
            int position = p.ownMinions.Count; // 召唤的位置在己方随从的最后
            p.callKid(pirateCard, position, true);
        }
        /// <summary>
        /// 消耗尸体
        /// </summary>
        /// <param name="count"></param>
        public void corpseConsumption(int count)
        {
            Dictionary<CardDB.cardIDEnum, int> tempOwnGraveyard = new Dictionary<CardDB.cardIDEnum, int>();
            foreach (var item in this.ownGraveyard)
            {
                if (CardDB.Instance.getCardDataFromID(item.Key).type == CardDB.cardtype.MOB)
                {
                    if (item.Value > count)
                    {
                        int temp = item.Value - count;
                        this.ownGraveyard[item.Key] = temp;
                        break;
                    }
                    else if (item.Value == count)
                    {
                        count = count - item.Value;
                        tempOwnGraveyard.Add(item.Key, item.Value);
                        break;
                    }
                    else
                    {
                        count = count - item.Value;
                        tempOwnGraveyard.Add(item.Key, item.Value);
                    }
                }
            }

            foreach (var item in tempOwnGraveyard)
            {
                this.ownGraveyard.Remove(item.Key);
            }

        }

        /// <summary>
        /// 获取尸体数量
        /// </summary>
        /// <returns></returns>
        public int getCorpseCount()
        {
            int retCount = 0;
            foreach (var item in this.ownGraveyard)
            {
                if (CardDB.Instance.getCardDataFromID(item.Key).type == CardDB.cardtype.MOB)
                {
                    retCount += item.Value;
                }
            }
            return retCount;
        }


        /// <summary>
        /// 将源列表中的所有 Minion 实例复制并添加到目标列表中。
        /// </summary>
        /// <param name="source">要复制的 Minion 列表。</param>
        /// <param name="trgt">目标 Minion 列表，将接收复制的 Minion。</param>
        private void addMinionsReal(List<Minion> source, List<Minion> trgt)
        {
            foreach (Minion m in source)
            {
                trgt.Add(new Minion(m));  // 创建源 Minion 的副本并添加到目标列表
            }
        }

        /// <summary>
        /// 将源列表中的所有 Handcard 实例复制并添加到当前对象的 owncards 列表中。
        /// </summary>
        /// <param name="source">要复制的 Handcard 列表。</param>
        private void addCardsReal(List<Handmanager.Handcard> source)
        {
            foreach (Handmanager.Handcard hc in source)
            {
                this.owncards.Add(new Handmanager.Handcard(hc));  // 创建源 Handcard 的副本并添加到 owncards 列表
            }
        }

        /// <summary>
        /// 当前回合第0步操作或重新计算时会读取场面获得初始的 p，光环效果要初始化
        /// </summary>
        public Playfield()
        {
            this.value = int.MinValue;
            this.deckAngrBuff = 0;
            this.deckHpBuff = 0;
            this.patchesInDeck = true;
            this.healOrDamageTimes = 0;
            this.healTimes = 0;
            this.totalAngr = -1;
            this.enemyTotalAngr = -1;
            this.ownMinionsDied = 0;
            this.setMankrik = false;
            this.anzSolor = false;
            this.enemyMinionStartCount = 0;
            this.pID = prozis.getPid();
            if (this.print)
            {
                this.pIdHistory.Add(pID);
            }
            this.nextEntity = 1000;
            this.isLethalCheck = false;
            this.ownController = prozis.getOwnController();
            this.libram = 0;
            this.gTurn = (prozis.gTurn + 1) / 2;
            this.gTurnStep = prozis.gTurnStep;
            this.mana = prozis.currentMana;
            this.manaTurnEnd = this.mana;
            this.ownMaxMana = prozis.ownMaxMana;
            this.enemyMaxMana = prozis.enemyMaxMana;
            this.evaluatePenality = 0;
            this.ruleWeight = 0;
            this.rulesUsed = "";
            this.ownSecretsIDList.AddRange(prozis.ownSecretList);
            this.enemySecretCount = prozis.enemySecretCount;
            this.anzOgOwnCThunAngrBonus = prozis.anzOgOwnCThunAngrBonus;
            this.anzOgOwnCThunHpBonus = prozis.anzOgOwnCThunHpBonus;
            this.anzOgOwnCThunTaunt = prozis.anzOgOwnCThunTaunt;
            this.anzOwnJadeGolem = prozis.anzOwnJadeGolem;
            this.anzEnemyJadeGolem = prozis.anzEnemyJadeGolem;
            this.OwnLastDiedMinion = prozis.OwnLastDiedMinion;
            this.anzOwnElementalsThisTurn = prozis.anzOwnElementalsThisTurn;
            this.anzOwnElementalsLastTurn = prozis.anzOwnElementalsLastTurn;
            this.useNature = prozis.useNature;
            this.attackFaceHP = prozis.attackFaceHp;
            this.complete = false;
            this.ownHero = new Minion(prozis.ownHero);
            this.enemyHero = new Minion(prozis.enemyHero);
            this.ownWeapon = new Weapon(prozis.ownWeapon);
            this.enemyWeapon = new Weapon(prozis.enemyWeapon);
            this.AnzSoulFragments = prozis.turnDeck.ContainsKey(CardDB.cardIDEnum.SCH_307t) ? prozis.turnDeck[CardDB.cardIDEnum.SCH_307t] : 0;
            this.anzTamsin = prozis.anzTamsin;

            foreach (var item in Probabilitymaker.Instance.ownGraveyard)
            {
                if (!this.ownGraveyard.ContainsKey(item.Key) && CardDB.Instance.getCardDataFromID(item.Key).type == CardDB.cardtype.MOB)
                {
                    this.ownGraveyard.Add(item.Key, item.Value);
                }
            }

            addMinionsReal(prozis.ownMinions, ownMinions);
            addMinionsReal(prozis.enemyMinions, enemyMinions);
            addCardsReal(Handmanager.Instance.handCards);
            this.LurkersDB = new Dictionary<int, IDEnumOwner>(prozis.LurkersDB);

            this.enemySecretList.Clear();
            this.useSecretsPlayAround = true;
            foreach (SecretItem si in Probabilitymaker.Instance.enemySecrets) // 敌方可能的奥秘
            {
                this.enemySecretList.Add(new SecretItem(si));
            }

            this.ownHeroName = prozis.heroname;
            this.enemyHeroName = prozis.enemyHeroname;
            this.ownHeroStartClass = prozis.ownHeroStartClass;
            this.enemyHeroStartClass = prozis.enemyHeroStartClass;
            //####buffs#############################

            this.anzOwnRaidleader = 0;
            this.anzEnemyRaidleader = 0;
            this.anzOwnVessina = 0;
            this.anzEnemyVessina = 0;
            this.anzOwnStormwindChamps = 0;
            this.anzEnemyStormwindChamps = 0;
            this.anzOwnAnimatedArmor = 0;
            this.anzEnemyAnimatedArmor = 0;
            this.anzMoorabi = 0;
            this.anzDark = 0;
            this.anzTamsinroame = 0;
            this.anzOldWoman = 0;
            this.usedUndeadAllies = 0;
            this.anzOwnExtraAngrHp = 0;
            this.anzEnemyExtraAngrHp = 0;
            this.anzOwnWarhorseTrainer = 0;
            this.anzEnemyWarhorseTrainer = 0;
            this.anzOwnTundrarhino = 0;
            this.anzEnemyTundrarhino = 0;
            this.anzOwnMrSmite = 0;//重拳先生
            this.anzEnemyMrSmite = 0;
            this.anzOwnTimberWolfs = 0;//森林狼
            this.anzEnemyTimberWolfs = 0;
            this.anzOwnMurlocWarleader = 0;
            this.anzEnemyMurlocWarleader = 0;
            this.anzAcidmaw = 0;
            this.anzOwnGrimscaleOracle = 0;
            this.anzEnemyGrimscaleOracle = 0;
            this.anzOwnShadowfiend = 0;
            this.anzOwnAuchenaiSoulpriest = 0;
            this.anzEnemyAuchenaiSoulpriest = 0;
            this.anzOwnSouthseacaptain = 0;
            this.anzEnemySouthseacaptain = 0;
            this.anzOwnDragonConsortStarted = 0;
            this.ownElementCostStarted = 0;//火光元素
            this.ownBeastCostLessOnceStarted = 0;//雷矛军用山羊
            this.anzOwnPiratesStarted = 0;//回合开始海盗数
            this.anzOwnMurlocStarted = 0;//回合开始鱼人数
            this.anzOwnElementStarted = 0;//回合开始元素数
            this.anzOwnDraeneiStarted = 0;//回合开始德莱尼数
            this.anzOwnTreantStarted = 0;//回合开始树人数
            this.ownAbilityFreezesTarget = 0;
            this.enemyAbilityFreezesTarget = 0;
            this.ownDemonCostLessOnce = 0;
            this.ownHeroPowerCostLessOnce = 0;
            this.ownHeroPowerCostLessTwice = 0;
            this.enemyHeroPowerCostLessOnce = 0;
            this.ownHeroPowerExtraDamage = 0;
            this.enemyHeroPowerExtraDamage = 0;
            this.ownHeroPowerAllowedQuantity = 1;
            this.enemyHeroPowerAllowedQuantity = 1;
            this.anzUsedOwnHeroPower = 0;
            this.anzUsedEnemyHeroPower = 0;
            this.anzEnemyTaunt = 0;
            this.anzOwnTaunt = 0;
            this.ownMinionsDiedTurn = 0;
            this.enemyMinionsDiedTurn = 0;
            this.feugenDead = Probabilitymaker.Instance.feugenDead;
            this.stalaggDead = Probabilitymaker.Instance.stalaggDead;
            this.weHavePlayedMillhouseManastorm = false;
            this.doublepriest = 0;
            this.enemydoublepriest = 0;
            this.ownMistcaller = 0;
            this.lockandload = 0;//子弹上膛标记
            this.stampede = 0;
            this.ownBaronRivendare = 0;
            this.enemyBaronRivendare = 0;
            this.ownBrannBronzebeard = 0;//友方战吼额外触发次数
            this.enemyBrannBronzebeard = 0;//敌方战吼额外触发次数
            this.ownTurnEndEffectsTriggerTwice = 0;
            this.enemyTurnEndEffectsTriggerTwice = 0;
            this.ownFandralStaghelm = 0;//范达尔·鹿盔
            this.anzOwnRazorfenRockstar = 0; // 剃刀沼泽摇滚明星
            this.anzOwnXB931Housekeeper = 0; // XB-931型家政机
            //#########################################
            this.enemycarddraw = 0;
            this.owncarddraw = 0;
            this.enemyAnzCards = Handmanager.Instance.enemyAnzCards;
            this.ownAbilityReady = prozis.ownAbilityisReady;
            this.ownHeroAblility = new Handmanager.Handcard { card = prozis.heroAbility, manacost = prozis.ownHeroPowerCost };
            this.enemyHeroAblility = new Handmanager.Handcard { card = prozis.enemyAbility, manacost = prozis.enemyHeroPowerCost };
            this.enemyAbilityReady = false;
            this.bestEnemyPlay = null;
            this.ownQuest.Copy(Questmanager.Instance.ownQuest);
            this.enemyQuest.Copy(Questmanager.Instance.enemyQuest);
            this.sideQuest.Copy(Questmanager.Instance.sideQuest);
            this.mobsplayedThisTurn = prozis.numMinionsPlayedThisTurn;
            this.startedWithMobsPlayedThisTurn = prozis.numMinionsPlayedThisTurn;// only change mobsplayedthisturm
            this.cardsPlayedThisTurn = prozis.cardsPlayedThisTurn;
            this.spellsplayedSinceRecalc = 0;
            this.secretsplayedSinceRecalc = 0;
            this.optionsPlayedThisTurn = prozis.numOptionsPlayedThisTurn;
            this.ueberladung = prozis.ueberladung;
            this.lockedMana = prozis.lockedMana;
            this.ownHeroFatigue = prozis.ownHeroFatigue;
            this.enemyHeroFatigue = prozis.enemyHeroFatigue;
            this.ownDeckSize = prozis.ownDeckSize;
            this.enemyDeckSize = prozis.enemyDeckSize;
            //需要以下内容来计算法力值
            this.ownHeroHpStarted = this.ownHero.Hp;
            this.enemyHeroHpStarted = this.enemyHero.Hp;
            this.ownWeaponAttackStarted = this.ownWeapon.Angr;
            this.ownCardsCountStarted = this.owncards.Count;
            this.enemyCardsCountStarted = this.enemyAnzCards;
            this.ownMobsCountStarted = this.ownMinions.Count;
            this.enemyMobsCountStarted = this.enemyMinions.Count;
            this.nextSecretThisTurnCost0 = false;
            this.playedPreparation = false;
            this.nextSpellThisTurnCost0 = false;
            this.nextMurlocThisTurnCostHealth = false;
            this.nextSpellThisTurnCostHealth = false;
            this.nextAnyCardThisTurnCostEnemyHealth = false;
            this.winzigebeschwoererin = 0;
            this.winRazormaneBattleguard = 0;
            this.managespenst = 0;
            this.beschwoerungsportal = 0;
            this.anzOwnAviana = 0; //艾维娜
            this.anzOwnScargil = 0; //斯卡基尔
            this.anzOwnCloakedHuntress = 0; //神秘女猎手
            this.anzOwnPopGarThePutrid = 0;//我方腐臭淤泥波普加

            this.nerubarweblord = 0;
            this.myCardsCostLess = 0;
            this.startedWithmyCardsCostLess = 0;
            this.startedWithnerubarweblord = 0;
            this.startedWithbeschwoerungsportal = 0;
            this.startedWithManagespenst = 0;
            this.startedWithWinzigebeschwoererin = 0;
            this.startedRazormaneBattleguard = 0;
            this.blackwaterpirate = 0;
            this.blackwaterpirateStarted = 0;
            this.embracetheshadow = 0;
            this.ownCrystalCore = prozis.ownCrystalCore;
            this.ownMinionsInDeckCost0 = prozis.ownMinionsInDeckCost0;
            this.LothraxionsPower = prozis.LothraxionsPower;
            this.needGraveyard = true;
            this.loatheb = false;
            this.spellpower = 0;
            this.spellpowerStarted = 0;
            this.enemyspellpower = 0;
            this.enemyspellpowerStarted = 0;
            this.startedWithDamagedMinions = false;
            this.enemyHeroTurnStartedHp = this.enemyHero.Hp;
            this.ownHeroTurnStartedHp = this.ownHero.Hp;
            this.tempanzOwnCards = this.owncards.Count;//手牌数
            this.tempanzEnemyCards = this.enemyAnzCards;
            this.value = int.MinValue;

            //法术派系
            this.ownSpellSchoolCounts = new Dictionary<TAG_SPELL_SCHOOL, int>();
            //伊丽扎·刺刃光环
            this.ownElizagoreblade = 0;
            //回合结束存放的标志
            this.cardsToReturnAtEndOfTurn = new List<CardDB.cardIDEnum>();
            //救生光环
            this.ownSunscreenTurns = 0;
            this.enemySunscreenTurns = 0;
            //重封者拉兹
            this.ownHeroPowerCanBeUsedMultipleTimes = false;
            //当前发掘次数
            this.excavationCount = 0;
            //总发掘次数
            this.allExcavationCount = 0;
            //下个战吼触发次数
            this.nextBattlecryTriggers = 1;
            //军团进攻
            this.ownLegionInvasion = false;
            this.enemyLegionInvasion = false;
            //维和者阿米图斯
            this.ownAmitusThePeacekeeper = false;
            this.enemyAmitusThePeacekeeper = false;
            //下一张元素随从牌的法力值消耗减少量
            this.nextElementalReduction = 0;
            //本回合下一张元素随从牌的法力值消耗减少量
            this.thisTurnNextElementalReduction = 0;
            //上次打出的卡牌的费用
            this.lastPlayedCardCost = 0;
            //在本回合是否打出了元素牌
            this.playedElementalThisTurn = false;
            foreach (TAG_SPELL_SCHOOL school in Enum.GetValues(typeof(TAG_SPELL_SCHOOL)))
            {
                this.ownSpellSchoolCounts[school] = 0;
            }

            //我方特殊随从的效果标志位 站场效果
            foreach (Minion m in this.ownMinions)
            {
                // 计算鱼人恩典
                if (!m.untouchable && (m.handcard.card.race == CardDB.Race.MURLOC || m.handcard.card.race == CardDB.Race.ALL)) this.anzOwnMurlocStarted++; //鱼人
                if (!m.untouchable && (m.handcard.card.race == CardDB.Race.PIRATE || m.handcard.card.race == CardDB.Race.ALL)) this.anzOwnPiratesStarted++;//Pirates海盗
                if (!m.untouchable && (m.handcard.card.race == CardDB.Race.ELEMENTAL || m.handcard.card.race == CardDB.Race.ALL)) this.anzOwnElementStarted++;//元素
                if (!m.untouchable && (m.handcard.card.race == CardDB.Race.DRAENEI || m.handcard.card.race == CardDB.Race.ALL)) this.anzOwnDraeneiStarted++;//德莱尼
                if (!m.untouchable && m.handcard.card.Treant) this.anzOwnTreantStarted++;//树人


                if (m.Hp < m.maxHp && m.Hp >= 1) this.startedWithDamagedMinions = true;

                this.spellpowerStarted += m.spellpower;//法强
                if (m.silenced) continue;
                this.spellpowerStarted += m.handcard.card.spellpowervalue;
                this.spellpower = this.spellpowerStarted;
                if (m.taunt) anzOwnTaunt++;

                //用来写 触发标记的随从
                switch (m.name)
                {
                    case CardDB.cardNameEN.blackwaterpirate://黑水海盗
                        this.blackwaterpirate++;
                        this.blackwaterpirateStarted++;
                        continue;
                    case CardDB.cardNameEN.chogall://古加尔
                        if (m.playedThisTurn && this.cardsPlayedThisTurn == this.mobsplayedThisTurn) this.nextSpellThisTurnCostHealth = true;
                        continue;
                    case CardDB.cardNameEN.prophetvelen://先知维纶
                        this.doublepriest++;//双倍牧师
                        continue;
                    case CardDB.cardNameEN.themistcaller:
                        this.ownMistcaller++;//随从+1+1
                        continue;
                    case CardDB.cardNameEN.pintsizedsummoner://小个子召唤师
                        this.winzigebeschwoererin++;
                        this.startedWithWinzigebeschwoererin++;
                        continue;
                    case CardDB.cardNameEN.razormanebattleguard://卫兵
                        this.winRazormaneBattleguard++;
                        this.startedRazormaneBattleguard++;
                        continue;
                    case CardDB.cardNameEN.manawraith:
                        this.managespenst++;//法力怨魂
                        this.startedWithManagespenst++;
                        continue;
                    case CardDB.cardNameEN.nerubarweblord://尼鲁巴蛛网领主
                        this.nerubarweblord++;
                        this.startedWithnerubarweblord++;
                        continue;
                    case CardDB.cardNameEN.venturecomercenary:  //风险投资公司雇佣兵                      
                        this.ownMinionsCostMore += 3;
                        this.ownMinionsCostMoreAtStart += 3;
                        continue;
                    case CardDB.cardNameEN.corpsewidow://巨型尸蛛
                        this.ownDRcardsCostMore -= 2;
                        this.ownDRcardsCostMoreAtStart -= 2;
                        continue;
                    case CardDB.cardNameEN.summoningportal://召唤传送门
                        this.beschwoerungsportal++;
                        this.startedWithbeschwoerungsportal++;
                        continue;
                    case CardDB.cardNameEN.vaelastrasz://瓦拉斯塔兹
                        this.myCardsCostLess += 3;//卡牌法力值消耗减少3
                        this.startedWithmyCardsCostLess += 3;
                        continue;
                    case CardDB.cardNameEN.scargil: // 斯卡基尔
                        this.anzOwnScargil++;
                        continue;
                    case CardDB.cardNameEN.aviana://艾维娜
                        this.anzOwnAviana++;
                        continue;
                    case CardDB.cardNameEN.cloakedhuntress://神秘女猎手
                        this.anzOwnCloakedHuntress++;
                        continue;
                    case CardDB.cardNameEN.razorfenrockstar: //剃刀沼泽摇滚明星
                        this.anzOwnRazorfenRockstar++;
                        continue;
                    case CardDB.cardNameEN.xb931housekeeper: //XB-931型家政机
                        this.anzOwnXB931Housekeeper++;
                        continue;
                    case CardDB.cardNameEN.popgartheputrid://腐臭淤泥波普加

                        this.anzOwnPopGarThePutrid++;
                        continue;
                    case CardDB.cardNameEN.baronrivendare://瑞文戴尔男爵
                        this.ownBaronRivendare++;
                        continue;
                    case CardDB.cardNameEN.brannbronzebeard://布莱恩·铜须
                        this.ownBrannBronzebeard++;
                        continue;
                    case CardDB.cardNameEN.drakkarienchanter://达卡莱附魔师
                        this.ownTurnEndEffectsTriggerTwice++;
                        continue;
                    case CardDB.cardNameEN.fandralstaghelm://范达尔·鹿盔
                        this.ownFandralStaghelm++;
                        continue;
                    case CardDB.cardNameEN.kelthuzad://克尔苏加德
                        this.needGraveyard = true;
                        continue;
                    case CardDB.cardNameEN.leokk://雷欧克
                        this.anzOwnRaidleader++;
                        continue;
                    case CardDB.cardNameEN.raidleader://团队领袖
                        this.anzOwnRaidleader++;
                        continue;
                    case CardDB.cardNameEN.vessina://维西纳
                        this.anzOwnVessina++;
                        continue;
                    case CardDB.cardNameEN.warhorsetrainer://战马训练师
                        this.anzOwnWarhorseTrainer++;
                        continue;
                    case CardDB.cardNameEN.fallenhero://英雄之魂
                        this.ownHeroPowerExtraDamage++;
                        continue;
                    case CardDB.cardNameEN.garrisoncommander://要塞指挥官
                        bool another = false;
                        foreach (Minion mnn in this.ownMinions)
                        {
                            if (mnn.name == CardDB.cardNameEN.garrisoncommander && mnn.entitiyID != m.entitiyID) another = true;
                        }
                        if (!another) this.ownHeroPowerAllowedQuantity++;
                        continue;
                    case CardDB.cardNameEN.coldarradrake://考达拉幼龙
                        this.ownHeroPowerAllowedQuantity += 100;
                        continue;
                    case CardDB.cardNameEN.mindbreaker://摧心者
                        this.ownHeroAblility.manacost = 100;
                        this.enemyHeroAblility.manacost = 100;
                        this.ownAbilityReady = false;
                        this.ownAbilityReady = false;
                        continue;
                    case CardDB.cardNameEN.malganis://玛尔加尼斯
                        this.anzOwnMalGanis++;
                        continue;
                    case CardDB.cardNameEN.bolframshield://博尔夫·碎盾
                        this.anzOwnBolfRamshield++;
                        continue;
                    case CardDB.cardNameEN.ladyblaumeux://女公爵布劳缪克丝 冒险卡
                        this.anzOwnHorsemen++;
                        continue;
                    case CardDB.cardNameEN.thanekorthazz://库尔塔兹领主 冒险
                        this.anzOwnHorsemen++;
                        continue;
                    case CardDB.cardNameEN.sirzeliek://瑟里耶克爵士 冒险
                        this.anzOwnHorsemen++;
                        continue;
                    case CardDB.cardNameEN.stormwindchampion://暴风城勇士
                        this.anzOwnStormwindChamps++;
                        continue;
                    case CardDB.cardNameEN.animatedarmor://复活的铠甲
                        this.anzOwnAnimatedArmor++;
                        continue;
                    case CardDB.cardNameEN.moorabi://莫拉比
                        this.anzMoorabi++;
                        continue;
                    case CardDB.cardNameEN.darkglare://黑眼
                        this.anzDark++;
                        continue;
                    case CardDB.cardNameEN.tamsinroame: //塔姆辛罗姆
                        this.anzTamsinroame++;
                        continue;
                    case CardDB.cardNameEN.voidtouchedattendant: //虚触侍从
                        this.anzOldWoman++;
                        continue;
                    case CardDB.cardNameEN.tundrarhino://苔原犀牛
                        this.anzOwnTundrarhino++;
                        continue;
                    case CardDB.cardNameEN.mrsmite://重拳先生
                        this.anzOwnMrSmite++;
                        continue;
                    case CardDB.cardNameEN.timberwolf://森林狼
                        this.anzOwnTimberWolfs++;
                        continue;
                    case CardDB.cardNameEN.murlocwarleader://鱼人领军
                        this.anzOwnMurlocWarleader++;
                        continue;
                    case CardDB.cardNameEN.acidmaw://酸喉
                        this.anzAcidmaw++;
                        continue;
                    case CardDB.cardNameEN.grimscaleoracle://暗鳞先知
                        this.anzOwnGrimscaleOracle++;
                        continue;
                    case CardDB.cardNameEN.shadowfiend://暗影魔
                        this.anzOwnShadowfiend++;
                        continue;
                    case CardDB.cardNameEN.auchenaisoulpriest://奥金尼灵魂祭司
                        this.anzOwnAuchenaiSoulpriest++;
                        continue;
                    case CardDB.cardNameEN.radiantelemental: goto case CardDB.cardNameEN.sorcerersapprentice;//光照元素
                    case CardDB.cardNameEN.sorcerersapprentice://巫师学徒
                        this.ownSpelsCostMore--;
                        this.ownSpelsCostMoreAtStart--;
                        continue;
                    case CardDB.cardNameEN.nerubianunraveler:  //     蛛魔拆解者                 
                        this.ownSpelsCostMore += 2;
                        this.ownSpelsCostMoreAtStart += 2;
                        continue;
                    case CardDB.cardNameEN.electron://电荷金刚
                        this.ownSpelsCostMore -= 3;
                        this.ownSpelsCostMoreAtStart -= 3;
                        continue;
                    case CardDB.cardNameEN.icewalker://寒冰行者
                        this.ownAbilityFreezesTarget++;
                        continue;
                    case CardDB.cardNameEN.southseacaptain://南海船长
                        this.anzOwnSouthseacaptain++;
                        continue;
                    case CardDB.cardNameEN.chromaggus://克洛玛古斯
                        this.anzOwnChromaggus++;
                        continue;
                    case CardDB.cardNameEN.mechwarper://机械跃迁者
                        this.anzOwnMechwarper++;
                        this.anzOwnMechwarperStarted++;
                        continue;
                    case CardDB.cardNameEN.steamwheedlesniper://热砂港狙击手
                        this.weHaveSteamwheedleSniper = true;
                        continue;
                    default:
                        break;
                }
            }

            foreach (Handmanager.Handcard hc in this.owncards)
            {

                if (hc.card.nameEN == CardDB.cardNameEN.kelthuzad)//克总
                {
                    this.needGraveyard = true;
                }
            }

            //敌方特殊随从的效果标志位
            foreach (Minion m in this.enemyMinions)
            {
                this.enemyMinionStartCount++;
                this.enemyspellpowerStarted += m.spellpower;
                if (m.silenced) continue;
                this.enemyspellpowerStarted += m.handcard.card.spellpowervalue;
                this.enemyspellpower = this.enemyspellpowerStarted;
                if (m.taunt) anzEnemyTaunt++;

                switch (m.name)
                {
                    case CardDB.cardNameEN.voidtouchedattendant:
                        this.anzOldWoman++;
                        continue;
                    case CardDB.cardNameEN.baronrivendare:
                        this.enemyBaronRivendare++;
                        continue;
                    case CardDB.cardNameEN.brannbronzebeard:
                        this.enemyBrannBronzebeard++;
                        continue;
                    case CardDB.cardNameEN.drakkarienchanter:
                        this.enemyTurnEndEffectsTriggerTwice++;
                        continue;
                    case CardDB.cardNameEN.kelthuzad:
                        this.needGraveyard = true;
                        continue;
                    case CardDB.cardNameEN.prophetvelen:
                        this.enemydoublepriest++;
                        continue;
                    case CardDB.cardNameEN.manawraith:
                        this.managespenst++;
                        this.startedWithManagespenst++;
                        continue;
                    case CardDB.cardNameEN.electron:
                        this.ownSpelsCostMore -= 3;
                        this.ownSpelsCostMoreAtStart -= 3;
                        continue;
                    case CardDB.cardNameEN.doomedapprentice:
                        this.ownSpelsCostMore++;
                        this.ownSpelsCostMoreAtStart++;
                        continue;
                    case CardDB.cardNameEN.nerubarweblord:
                        this.nerubarweblord++;
                        this.startedWithnerubarweblord++;
                        continue;
                    case CardDB.cardNameEN.garrisoncommander:
                        bool another = false;
                        foreach (Minion mnn in this.enemyMinions)
                        {
                            if (mnn.name == CardDB.cardNameEN.garrisoncommander && mnn.entitiyID != m.entitiyID) another = true;
                        }
                        if (!another) this.enemyHeroPowerAllowedQuantity++;
                        continue;
                    case CardDB.cardNameEN.coldarradrake:
                        this.enemyHeroPowerAllowedQuantity += 100;
                        continue;
                    case CardDB.cardNameEN.mindbreaker:
                        this.ownHeroAblility.manacost = 100;
                        this.enemyHeroAblility.manacost = 100;
                        this.ownAbilityReady = false;
                        this.ownAbilityReady = false;
                        continue;
                    case CardDB.cardNameEN.fallenhero:
                        this.enemyHeroPowerExtraDamage++;
                        continue;
                    case CardDB.cardNameEN.leokk:
                        this.anzEnemyRaidleader++;
                        continue;
                    case CardDB.cardNameEN.raidleader:
                        this.anzEnemyRaidleader++;
                        continue;
                    case CardDB.cardNameEN.vessina:
                        this.anzEnemyVessina++;
                        continue;
                    case CardDB.cardNameEN.warhorsetrainer:
                        this.anzEnemyWarhorseTrainer++;
                        continue;
                    case CardDB.cardNameEN.malganis:
                        this.anzEnemyMalGanis++;
                        continue;
                    case CardDB.cardNameEN.bolframshield:
                        this.anzEnemyBolfRamshield++;
                        continue;
                    case CardDB.cardNameEN.ladyblaumeux:
                        this.anzEnemyHorsemen++;
                        continue;
                    case CardDB.cardNameEN.thanekorthazz:
                        this.anzEnemyHorsemen++;
                        continue;
                    case CardDB.cardNameEN.sirzeliek:
                        this.anzEnemyHorsemen++;
                        continue;
                    case CardDB.cardNameEN.stormwindchampion:
                        this.anzEnemyStormwindChamps++;
                        continue;
                    case CardDB.cardNameEN.animatedarmor:
                        this.anzEnemyAnimatedArmor++;
                        continue;
                    case CardDB.cardNameEN.moorabi:
                        this.anzMoorabi++;
                        continue;
                    case CardDB.cardNameEN.tundrarhino:
                        this.anzEnemyTundrarhino++;
                        continue;
                    case CardDB.cardNameEN.mrsmite:
                        this.anzEnemyMrSmite++;
                        continue;
                    case CardDB.cardNameEN.timberwolf:
                        this.anzEnemyTimberWolfs++;
                        continue;
                    case CardDB.cardNameEN.murlocwarleader:
                        this.anzEnemyMurlocWarleader++;
                        continue;
                    case CardDB.cardNameEN.acidmaw:
                        this.anzAcidmaw++;
                        continue;
                    case CardDB.cardNameEN.grimscaleoracle:
                        this.anzEnemyGrimscaleOracle++;
                        continue;
                    case CardDB.cardNameEN.auchenaisoulpriest:
                        this.anzEnemyAuchenaiSoulpriest++;
                        continue;
                    case CardDB.cardNameEN.steamwheedlesniper:
                        this.enemyHaveSteamwheedleSniper = true;
                        continue;
                    case CardDB.cardNameEN.icewalker:
                        this.enemyAbilityFreezesTarget++;
                        continue;
                    case CardDB.cardNameEN.southseacaptain:
                        this.anzEnemySouthseacaptain++;
                        continue;
                    case CardDB.cardNameEN.chromaggus:
                        this.anzEnemyChromaggus++;
                        continue;
                    case CardDB.cardNameEN.mechwarper:
                        this.anzEnemyMechwarper++;
                        this.anzEnemyMechwarperStarted++;
                        continue;
                }
            }

            if (this.spellpowerStarted > 0) this.ownSpiritclaws = true;//幽灵爪加攻
            if (this.enemyspellpowerStarted > 0) this.enemySpiritclaws = true;

            if (this.enemySecretCount >= 1) this.needGraveyard = true;
            if (this.needGraveyard) this.diedMinions = new List<GraveYardItem>(Probabilitymaker.Instance.turngraveyard);//墓地

            deckGuess.guessEnemyDeck(this);
            this.enemyGuessDeck = Hrtprozis.Instance.enemyDeckName;
        }

        /// <summary>
        /// 后续计算从之前的 p 继承数据，光环效果从之前继承，因此 sim 中需要对光环做相应处理
        /// </summary>
        /// <param name="p"></param>
        /// <param name="transToEnemy">改为用对手的视角来看</param>
        public Playfield(Playfield p, bool transToEnemy = false)
        {
            this.value = int.MinValue;
            this.enemyGuessDeck = p.enemyGuessDeck;
            this.enemyHeroTurnStartedHp = p.enemyHeroTurnStartedHp;
            this.ownHeroTurnStartedHp = p.ownHeroTurnStartedHp;
            this.pID = prozis.getPid();
            if (p.print)
            {
                this.print = true;
                this.pIdHistory.AddRange(p.pIdHistory);
                this.pIdHistory.Add(pID);
                this.doDirtyTts = p.doDirtyTts;
                this.dirtyTwoTurnSim = p.dirtyTwoTurnSim;
                this.checkLostAct = p.checkLostAct;
                this.enemyTurnsCount = p.enemyTurnsCount;
            }
            this.isLethalCheck = p.isLethalCheck;
            this.nextEntity = p.nextEntity;
            this.patchesInDeck = p.patchesInDeck;
            this.anzDark = p.anzDark;
            this.anzTamsinroame = p.anzTamsinroame;
            this.healOrDamageTimes = p.healOrDamageTimes;
            this.healTimes = p.healTimes;
            this.totalAngr = -1;
            this.enemyTotalAngr = -1;
            this.ownMinionsDied = p.ownMinionsDied;
            this.setMankrik = p.setMankrik;
            this.anzSolor = p.anzSolor;
            this.enemyMinionStartCount = p.enemyMinionStartCount;
            this.deckAngrBuff = p.deckAngrBuff;
            this.deckHpBuff = p.deckHpBuff;
            this.isOwnTurn = p.isOwnTurn;
            this.turnCounter = p.turnCounter;
            this.gTurn = p.gTurn;
            this.gTurnStep = p.gTurnStep;
            this.AnzSoulFragments = p.AnzSoulFragments;
            this.anzOldWoman = p.anzOldWoman;
            this.usedUndeadAllies = p.usedUndeadAllies;
            this.anzTamsin = p.anzTamsin;

            foreach (var item in p.ownGraveyard)
            {
                if (!this.ownGraveyard.ContainsKey(item.Key) && CardDB.Instance.getCardDataFromID(item.Key).type == CardDB.cardtype.MOB)
                {
                    this.ownGraveyard.Add(item.Key, item.Value);
                }
            }

            this.anzOgOwnCThunAngrBonus = p.anzOgOwnCThunAngrBonus;
            this.anzOgOwnCThunHpBonus = p.anzOgOwnCThunHpBonus;
            this.anzOgOwnCThunTaunt = p.anzOgOwnCThunTaunt;
            this.anzOwnJadeGolem = p.anzOwnJadeGolem;
            this.anzEnemyJadeGolem = p.anzEnemyJadeGolem;
            this.anzOwnElementalsThisTurn = p.anzOwnElementalsThisTurn;
            this.anzOwnElementalsLastTurn = p.anzOwnElementalsLastTurn;
            this.attacked = p.attacked;
            this.ownController = p.ownController;
            this.bestEnemyPlay = p.bestEnemyPlay;
            this.endTurnState = p.endTurnState;
            this.ownSecretsIDList.AddRange(p.ownSecretsIDList);
            this.evaluatePenality = p.evaluatePenality;
            this.ruleWeight = p.ruleWeight;
            this.rulesUsed = p.rulesUsed;
            this.enemySecretList.Clear();
            if (p.useSecretsPlayAround)
            {
                this.useSecretsPlayAround = true;
                foreach (SecretItem si in p.enemySecretList)
                {
                    this.enemySecretList.Add(new SecretItem(si));
                }
            }
            this.mana = p.mana;
            this.manaTurnEnd = p.manaTurnEnd;

            if (p.LurkersDB.Count > 0) this.LurkersDB = new Dictionary<int, IDEnumOwner>(p.LurkersDB);

            if (transToEnemy)
            {
                this.enemyMaxMana = p.ownMaxMana;
                this.ownMaxMana = p.enemyMaxMana;
                this.mana = p.enemyMaxMana;

                addMinionsReal(prozis.ownMinions, enemyMinions);
                addMinionsReal(prozis.enemyMinions, ownMinions);

                this.ownHero = new Minion(prozis.enemyHero);
                this.enemyHero = new Minion(prozis.ownHero);
                this.ownWeapon = new Weapon(prozis.enemyWeapon);
                this.enemyWeapon = new Weapon(prozis.ownWeapon);

                this.ownHeroName = prozis.enemyHeroname;
                this.enemyHeroName = prozis.heroname;
                this.ownHeroStartClass = prozis.enemyHeroStartClass;
                this.enemyHeroStartClass = prozis.ownHeroStartClass;

                this.anzTamsin = this.ownHero.enchs.IndexOf("SW_091t5") > 0;

                this.enemyAnzCards = Handmanager.Instance.anzcards;
                this.owncarddraw = p.enemycarddraw;
                this.enemycarddraw = p.owncarddraw;

                this.ownAbilityReady = true;
                this.enemyHeroAblility = new Handmanager.Handcard { card = prozis.heroAbility, manacost = prozis.ownHeroPowerCost };
                this.ownHeroAblility = new Handmanager.Handcard { card = prozis.enemyAbility, manacost = prozis.enemyHeroPowerCost };
                this.enemyAbilityReady = false;
                this.bestEnemyPlay = null;

                this.enemyQuest.Copy(p.ownQuest);
                this.ownQuest.Copy(p.enemyQuest);

                this.anzOwnTaunt = p.anzEnemyTaunt;
                this.anzEnemyTaunt = p.anzOwnTaunt;

                this.enemyspellpower = p.spellpower;
                this.enemyspellpowerStarted = p.spellpowerStarted;
                this.spellpower = p.enemyspellpower;
                this.spellpowerStarted = p.enemyspellpowerStarted;

                if (this.ownHero.enchs.IndexOf("SW_450t4e") > 0)
                {
                    this.spellpower += 3;
                }

                // TODO 对手的光环随从
                this.anzDark = 0;
                this.anzTamsinroame = 0;
                this.ownHeroPowerExtraDamage = 0;
                this.ownHero.numAttacksThisTurn = 0;

                this.enemySecretCount = p.ownSecretsIDList.Count;

                foreach (Minion m in p.ownMinions)
                {
                    switch (m.handcard.card.nameCN)
                    {
                        case CardDB.cardNameCN.黑眼:
                            anzDark++;
                            break;
                        case CardDB.cardNameCN.塔姆辛罗姆:
                            anzTamsinroame++;
                            break;
                    }
                }

            }
            else
            {
                this.ownMaxMana = p.ownMaxMana;
                this.enemyMaxMana = p.enemyMaxMana;

                addMinionsReal(p.ownMinions, ownMinions);
                addMinionsReal(p.enemyMinions, enemyMinions);
                addCardsReal(p.owncards);

                this.ownHero = new Minion(p.ownHero);
                this.enemyHero = new Minion(p.enemyHero);
                this.ownWeapon = new Weapon(p.ownWeapon);
                this.enemyWeapon = new Weapon(p.enemyWeapon);
                this.ownHeroName = p.ownHeroName;
                this.enemyHeroName = p.enemyHeroName;

                this.ownHeroStartClass = p.ownHeroStartClass;
                this.enemyHeroStartClass = p.enemyHeroStartClass;

                this.owncarddraw = p.owncarddraw;
                this.enemycarddraw = p.enemycarddraw;
                this.enemyAnzCards = p.enemyAnzCards;

                this.ownAbilityReady = p.ownAbilityReady;
                this.enemyAbilityReady = p.enemyAbilityReady;
                this.ownHeroAblility = new Handmanager.Handcard(p.ownHeroAblility);
                this.enemyHeroAblility = new Handmanager.Handcard(p.enemyHeroAblility);

                this.ownQuest.Copy(p.ownQuest);
                this.enemyQuest.Copy(p.enemyQuest);
                this.sideQuest.Copy(p.sideQuest);

                this.anzEnemyTaunt = p.anzEnemyTaunt;
                this.anzOwnTaunt = p.anzOwnTaunt;

                this.spellpower = p.spellpower;
                this.spellpowerStarted = p.spellpowerStarted;
                this.enemyspellpower = p.enemyspellpower;
                this.enemyspellpowerStarted = p.enemyspellpowerStarted;

                this.anzDark = p.anzDark;
                this.anzTamsinroame = p.anzTamsinroame;
                this.ownHeroPowerExtraDamage = p.ownHeroPowerExtraDamage;
                this.enemySecretCount = p.enemySecretCount;

            }

            this.playactions.AddRange(p.playactions);
            this.complete = false;

            this.attackFaceHP = p.attackFaceHP;


            this.lostDamage = p.lostDamage;
            this.lostWeaponDamage = p.lostWeaponDamage;
            this.lostHeal = p.lostHeal;

            this.mobsplayedThisTurn = p.mobsplayedThisTurn;
            this.startedWithMobsPlayedThisTurn = p.startedWithMobsPlayedThisTurn;
            this.spellsplayedSinceRecalc = p.spellsplayedSinceRecalc;
            this.secretsplayedSinceRecalc = p.secretsplayedSinceRecalc;
            this.optionsPlayedThisTurn = p.optionsPlayedThisTurn;
            this.cardsPlayedThisTurn = p.cardsPlayedThisTurn;
            this.enemyOptionsDoneThisTurn = p.enemyOptionsDoneThisTurn;
            this.ueberladung = p.ueberladung;
            this.lockedMana = p.lockedMana;
            //圣契
            this.libram = p.libram;
            this.ownDeckSize = p.ownDeckSize;
            this.enemyDeckSize = p.enemyDeckSize;
            this.ownHeroFatigue = p.ownHeroFatigue;
            this.enemyHeroFatigue = p.enemyHeroFatigue;

            //白银之手新兵
            this.LothraxionsPower = p.LothraxionsPower;

            //need the following for manacost-calculation
            this.ownHeroHpStarted = p.ownHeroHpStarted;
            this.ownWeaponAttackStarted = p.ownWeaponAttackStarted;
            this.ownCardsCountStarted = p.ownCardsCountStarted;
            this.enemyCardsCountStarted = p.enemyCardsCountStarted;
            this.ownMobsCountStarted = p.ownMobsCountStarted;
            this.enemyMobsCountStarted = p.enemyMobsCountStarted;
            this.nextSecretThisTurnCost0 = p.nextSecretThisTurnCost0;
            this.nextSpellThisTurnCost0 = p.nextSpellThisTurnCost0;
            this.nextMurlocThisTurnCostHealth = p.nextMurlocThisTurnCostHealth;
            this.nextAnyCardThisTurnCostEnemyHealth = p.nextAnyCardThisTurnCostEnemyHealth;


            this.blackwaterpirate = p.blackwaterpirate;
            this.blackwaterpirateStarted = p.blackwaterpirateStarted;
            this.nextSpellThisTurnCostHealth = p.nextSpellThisTurnCostHealth;
            this.embracetheshadow = p.embracetheshadow;
            this.ownCrystalCore = p.ownCrystalCore;
            this.ownMinionsInDeckCost0 = p.ownMinionsInDeckCost0;

            this.playedPreparation = p.playedPreparation;

            this.winzigebeschwoererin = p.winzigebeschwoererin;
            this.startedWithWinzigebeschwoererin = p.startedWithWinzigebeschwoererin;
            this.winRazormaneBattleguard = p.winRazormaneBattleguard;
            this.startedRazormaneBattleguard = p.startedRazormaneBattleguard;
            this.managespenst = p.managespenst;
            this.startedWithManagespenst = p.startedWithManagespenst;
            this.ownSpelsCostMore = p.ownSpelsCostMore;
            this.ownSpelsCostMoreAtStart = p.ownSpelsCostMoreAtStart;
            this.ownMinionsCostMore = p.ownMinionsCostMore;
            this.ownMinionsCostMoreAtStart = p.ownMinionsCostMoreAtStart;
            this.ownDRcardsCostMore = p.ownDRcardsCostMore;
            this.ownDRcardsCostMoreAtStart = p.ownDRcardsCostMoreAtStart;
            this.beschwoerungsportal = p.beschwoerungsportal;
            this.startedWithbeschwoerungsportal = p.startedWithbeschwoerungsportal;
            this.myCardsCostLess = p.myCardsCostLess;
            this.startedWithmyCardsCostLess = p.startedWithmyCardsCostLess;
            this.anzOwnScargil = p.anzOwnScargil;//斯卡基尔
            this.anzOwnAviana = p.anzOwnAviana; //艾维娜
            this.anzOwnCloakedHuntress = p.anzOwnCloakedHuntress;//神秘女猎手
            this.anzOwnRazorfenRockstar = p.anzOwnRazorfenRockstar; // 剃刀沼泽摇滚明星
            this.anzOwnXB931Housekeeper = p.anzOwnXB931Housekeeper; // XB-931型家政机
            this.anzOwnPopGarThePutrid = p.anzOwnPopGarThePutrid;//我方腐臭淤泥波普加
            
            this.nerubarweblord = p.nerubarweblord;
            this.startedWithnerubarweblord = p.startedWithnerubarweblord;
            this.startedWithDamagedMinions = p.startedWithDamagedMinions;
            this.loatheb = p.loatheb;
            this.needGraveyard = p.needGraveyard;
            if (p.needGraveyard) this.diedMinions = new List<GraveYardItem>(p.diedMinions);
            this.OwnLastDiedMinion = p.OwnLastDiedMinion;

            //####buffs#############################

            this.anzOwnRaidleader = p.anzOwnRaidleader;
            this.anzEnemyRaidleader = p.anzEnemyRaidleader;
            this.anzOwnVessina = p.anzOwnVessina;
            this.anzEnemyVessina = p.anzEnemyVessina;
            this.anzOwnWarhorseTrainer = p.anzOwnWarhorseTrainer;
            this.anzEnemyWarhorseTrainer = p.anzEnemyWarhorseTrainer;
            this.anzOwnMalGanis = p.anzOwnMalGanis;
            this.anzEnemyMalGanis = p.anzEnemyMalGanis;
            this.anzOwnBolfRamshield = p.anzOwnBolfRamshield;
            this.anzEnemyBolfRamshield = p.anzEnemyBolfRamshield;
            this.anzOwnHorsemen = p.anzOwnHorsemen;
            this.anzEnemyHorsemen = p.anzEnemyHorsemen;
            this.anzOwnAnimatedArmor = p.anzOwnAnimatedArmor;
            this.anzOwnExtraAngrHp = p.anzOwnExtraAngrHp;
            this.anzEnemyExtraAngrHp = p.anzEnemyExtraAngrHp;
            this.anzEnemyAnimatedArmor = p.anzEnemyAnimatedArmor;
            this.anzMoorabi = p.anzMoorabi;
            this.anzOwnPiratesStarted = p.anzOwnPiratesStarted;
            this.anzOwnMurlocStarted = p.anzOwnMurlocStarted;
            this.anzOwnElementStarted = p.anzOwnElementStarted;
            this.anzOwnDraeneiStarted = p.anzOwnDraeneiStarted;
            this.anzOwnTreantStarted = p.anzOwnTreantStarted;
            this.anzOwnStormwindChamps = p.anzOwnStormwindChamps;
            this.anzEnemyStormwindChamps = p.anzEnemyStormwindChamps;
            this.anzOwnTundrarhino = p.anzOwnTundrarhino;
            this.anzEnemyTundrarhino = p.anzEnemyTundrarhino;
            //重拳先生
            this.anzOwnMrSmite = p.anzOwnMrSmite;
            this.anzEnemyMrSmite = p.anzEnemyMrSmite;
            this.anzOwnTimberWolfs = p.anzOwnTimberWolfs;
            this.anzEnemyTimberWolfs = p.anzEnemyTimberWolfs;
            this.anzOwnMurlocWarleader = p.anzOwnMurlocWarleader;
            this.anzEnemyMurlocWarleader = p.anzEnemyMurlocWarleader;
            this.anzAcidmaw = p.anzAcidmaw;
            this.anzOwnGrimscaleOracle = p.anzOwnGrimscaleOracle;
            this.anzEnemyGrimscaleOracle = p.anzEnemyGrimscaleOracle;
            this.anzOwnShadowfiend = p.anzOwnShadowfiend;
            this.anzOwnAuchenaiSoulpriest = p.anzOwnAuchenaiSoulpriest;
            this.anzEnemyAuchenaiSoulpriest = p.anzEnemyAuchenaiSoulpriest;
            this.anzOwnSouthseacaptain = p.anzOwnSouthseacaptain;
            this.anzEnemySouthseacaptain = p.anzEnemySouthseacaptain;
            this.anzOwnMechwarper = p.anzOwnMechwarper;
            this.anzOwnMechwarperStarted = p.anzOwnMechwarperStarted;
            this.anzEnemyMechwarper = p.anzEnemyMechwarper;
            this.anzEnemyMechwarperStarted = p.anzEnemyMechwarperStarted;
            this.anzOwnChromaggus = p.anzOwnChromaggus;
            this.anzEnemyChromaggus = p.anzEnemyChromaggus;
            this.anzOwnDragonConsort = p.anzOwnDragonConsort;
            this.anzOwnMurlocConsort = p.anzOwnMurlocConsort;   //酸小明
            this.anzOwnDragonConsortStarted = p.anzOwnDragonConsortStarted;
            //火光元素
            this.ownElementCost = p.ownElementCost;
            this.ownElementCostStarted = p.ownElementCostStarted;
            //雷矛军用山羊
            this.ownBeastCostLessOnce = p.ownBeastCostLessOnce;
            this.ownBeastCostLessOnceStarted = p.ownBeastCostLessOnceStarted;
            this.ownAbilityFreezesTarget = p.ownAbilityFreezesTarget;
            this.enemyAbilityFreezesTarget = p.enemyAbilityFreezesTarget;
            this.ownDemonCostLessOnce = p.ownDemonCostLessOnce;
            this.ownHeroPowerCostLessOnce = p.ownHeroPowerCostLessOnce;
            this.ownHeroPowerCostLessTwice = p.ownHeroPowerCostLessTwice;
            this.enemyHeroPowerCostLessOnce = p.enemyHeroPowerCostLessOnce;
            this.enemyHeroPowerExtraDamage = p.enemyHeroPowerExtraDamage;
            this.ownHeroPowerAllowedQuantity = p.ownHeroPowerAllowedQuantity;
            this.enemyHeroPowerAllowedQuantity = p.enemyHeroPowerAllowedQuantity;
            this.anzUsedOwnHeroPower = p.anzUsedOwnHeroPower;
            this.anzUsedEnemyHeroPower = p.anzUsedEnemyHeroPower;
            this.ownMinionsDiedTurn = p.ownMinionsDiedTurn;
            this.enemyMinionsDiedTurn = p.enemyMinionsDiedTurn;
            this.feugenDead = p.feugenDead;
            this.stalaggDead = p.stalaggDead;
            this.weHavePlayedMillhouseManastorm = p.weHavePlayedMillhouseManastorm;
            this.ownSpiritclaws = p.ownSpiritclaws;
            this.enemySpiritclaws = p.enemySpiritclaws;
            this.doublepriest = p.doublepriest;
            this.enemydoublepriest = p.enemydoublepriest;
            this.ownMistcaller = p.ownMistcaller;
            this.lockandload = p.lockandload;
            this.stampede = p.stampede;
            this.ownBaronRivendare = p.ownBaronRivendare;
            this.enemyBaronRivendare = p.enemyBaronRivendare;
            this.ownBrannBronzebeard = p.ownBrannBronzebeard;
            this.enemyBrannBronzebeard = p.enemyBrannBronzebeard;
            this.ownTurnEndEffectsTriggerTwice = p.ownTurnEndEffectsTriggerTwice;
            this.enemyTurnEndEffectsTriggerTwice = p.enemyTurnEndEffectsTriggerTwice;
            this.ownFandralStaghelm = p.ownFandralStaghelm;
            this.weHaveSteamwheedleSniper = p.weHaveSteamwheedleSniper;
            this.enemyHaveSteamwheedleSniper = p.enemyHaveSteamwheedleSniper;
            //#########################################
            this.tempanzOwnCards = this.owncards.Count;
            this.tempanzEnemyCards = this.enemyAnzCards;
            this.value = int.MinValue;


            //法术派系
            this.ownSpellSchoolCounts = p.ownSpellSchoolCounts;
            //伊丽扎·刺刃光环
            this.ownElizagoreblade = p.ownElizagoreblade;
            //救生光环
            this.ownSunscreenTurns = p.ownSunscreenTurns;
            this.enemySunscreenTurns = p.enemySunscreenTurns;
            //重封者拉兹
            this.ownHeroPowerCanBeUsedMultipleTimes = p.ownHeroPowerCanBeUsedMultipleTimes;
            //当前发掘次数
            this.excavationCount = p.excavationCount;
            //总发掘次数
            this.allExcavationCount = p.allExcavationCount;
            //下个战吼触发次数
            this.nextBattlecryTriggers = p.nextBattlecryTriggers;
            //军团进攻
            this.ownLegionInvasion = p.ownLegionInvasion;
            this.enemyLegionInvasion = p.enemyLegionInvasion;
            //维和者阿米图斯
            this.ownAmitusThePeacekeeper = p.ownAmitusThePeacekeeper;
            this.enemyAmitusThePeacekeeper = p.enemyAmitusThePeacekeeper;
            //元素牌费用减少
            this.nextElementalReduction = p.nextElementalReduction;
            this.thisTurnNextElementalReduction = p.thisTurnNextElementalReduction;
            //上次打出的卡牌的费用
            this.lastPlayedCardCost = p.lastPlayedCardCost;
            //在本回合是否打出了元素牌
            this.playedElementalThisTurn = p.playedElementalThisTurn;
        }

        public void copyValuesFrom(Playfield p)
        {

        }

        public bool isEqual(Playfield p, bool logg)
        {
            if (logg)
            {
                if (this.value != p.value) return false;
            }
            if (this.enemySecretCount != p.enemySecretCount)
            {
                if (logg) Helpfunctions.Instance.logg("敌方奥秘改变 ");
                return false;
            }

            if (this.enemySecretCount >= 1)
            {
                for (int i = 0; i < this.enemySecretList.Count; i++)
                {
                    if (!this.enemySecretList[i].isEqual(p.enemySecretList[i]))
                    {
                        if (logg) Helpfunctions.Instance.logg("敌方奥秘改变 ");
                        return false;
                    }
                }
            }

            if (this.mana != p.mana || this.enemyMaxMana != p.enemyMaxMana || this.ownMaxMana != p.ownMaxMana)
            {
                if (logg) Helpfunctions.Instance.logg("法力水晶改变 " + this.mana + " " + p.mana + " " + this.enemyMaxMana + " " + p.enemyMaxMana + " " + this.ownMaxMana + " " + p.ownMaxMana);
                return false;
            }

            if (this.ownDeckSize != p.ownDeckSize || this.enemyDeckSize != p.enemyDeckSize || this.ownHeroFatigue != p.ownHeroFatigue || this.enemyHeroFatigue != p.enemyHeroFatigue)
            {
                if (logg) Helpfunctions.Instance.logg("卡组/疲劳改变" + this.ownDeckSize + " " + p.ownDeckSize + " " + this.enemyDeckSize + " " + p.enemyDeckSize + " " + this.ownHeroFatigue + " " + p.ownHeroFatigue + " " + this.enemyHeroFatigue + " " + p.enemyHeroFatigue);
            }

            if (this.cardsPlayedThisTurn != p.cardsPlayedThisTurn || this.mobsplayedThisTurn != p.mobsplayedThisTurn || this.ueberladung != p.ueberladung || this.lockedMana != p.lockedMana || this.ownAbilityReady != p.ownAbilityReady || this.ownQuest.questProgress != p.ownQuest.questProgress)
            {
                if (logg) Helpfunctions.Instance.logg("资料改变 " + this.cardsPlayedThisTurn + " " + p.cardsPlayedThisTurn + " " + this.mobsplayedThisTurn + " " + p.mobsplayedThisTurn + " " + this.ueberladung + " " + p.ueberladung + " " + this.lockedMana + " " + p.lockedMana + " " + this.ownAbilityReady + " " + p.ownAbilityReady + " " + this.ownQuest.questProgress + " " + p.ownQuest.questProgress);
                return false;
            }

            if (this.ownHeroName != p.ownHeroName || this.enemyHeroName != p.enemyHeroName)
            {
                if (logg) Helpfunctions.Instance.logg("英雄名字改变 ");
                return false;
            }

            if (this.ownHero.Hp != p.ownHero.Hp || this.ownHero.Angr != p.ownHero.Angr || this.ownHero.armor != p.ownHero.armor || this.ownHero.frozen != p.ownHero.frozen || this.ownHero.immuneWhileAttacking != p.ownHero.immuneWhileAttacking || this.ownHero.immune != p.ownHero.immune)
            {
                if (logg) Helpfunctions.Instance.logg("ownhero changed " + this.ownHero.Hp + " " + p.ownHero.Hp + " " + this.ownHero.Angr + " " + p.ownHero.Angr + " " + this.ownHero.armor + " " + p.ownHero.armor + " " + this.ownHero.frozen + " " + p.ownHero.frozen + " " + this.ownHero.immuneWhileAttacking + " " + p.ownHero.immuneWhileAttacking + " " + this.ownHero.immune + " " + p.ownHero.immune);
                return false;
            }
            if (this.ownHero.Ready != p.ownHero.Ready || !this.ownWeapon.isEqual(p.ownWeapon) || this.ownHero.numAttacksThisTurn != p.ownHero.numAttacksThisTurn || this.ownHero.windfury != p.ownHero.windfury)
            {
                if (logg) Helpfunctions.Instance.logg("weapon changed " + this.ownHero.Ready + " " + p.ownHero.Ready + " " + this.ownWeapon.Angr + " " + p.ownWeapon.Angr + " " + this.ownWeapon.Durability + " " + p.ownWeapon.Durability + " " + this.ownHero.numAttacksThisTurn + " " + p.ownHero.numAttacksThisTurn + " " + this.ownHero.windfury + " " + p.ownHero.windfury + " " + this.ownWeapon.poisonous + " " + p.ownWeapon.poisonous + " " + this.ownWeapon.lifesteal + " " + p.ownWeapon.lifesteal);
                return false;
            }
            if (this.enemyHero.Hp != p.enemyHero.Hp || !this.enemyWeapon.isEqual(p.enemyWeapon) || this.enemyHero.armor != p.enemyHero.armor || this.enemyHero.frozen != p.enemyHero.frozen || this.enemyHero.immune != p.enemyHero.immune)
            {
                if (logg) Helpfunctions.Instance.logg("enemyhero changed " + this.enemyHero.Hp + " " + p.enemyHero.Hp + " " + this.enemyWeapon.Angr + " " + p.enemyWeapon.Angr + " " + this.enemyHero.armor + " " + p.enemyHero.armor + " " + this.enemyWeapon.Durability + " " + p.enemyWeapon.Durability + " " + this.enemyHero.frozen + " " + p.enemyHero.frozen + " " + this.enemyHero.immune + " " + p.enemyHero.immune + " " + this.enemyWeapon.poisonous + " " + p.enemyWeapon.poisonous + " " + this.enemyWeapon.lifesteal + " " + p.enemyWeapon.lifesteal);
                return false;
            }

            if (this.ownHeroAblility.card.nameEN != p.ownHeroAblility.card.nameEN)
            {
                if (logg) Helpfunctions.Instance.logg("hero ability changed ");
                return false;
            }

            if (this.spellpower != p.spellpower)
            {
                if (logg) Helpfunctions.Instance.logg("spellpower changed");
                return false;
            }

            if (this.ownMinions.Count != p.ownMinions.Count || this.enemyMinions.Count != p.enemyMinions.Count || this.owncards.Count != p.owncards.Count)
            {
                if (logg) Helpfunctions.Instance.logg("minions count or hand changed");
                return false;
            }

            bool minionbool = true;
            for (int i = 0; i < this.ownMinions.Count; i++)
            {
                Minion dis = this.ownMinions[i]; Minion pis = p.ownMinions[i];

                if (dis.name != pis.name) minionbool = false;
                if (dis.Angr != pis.Angr || dis.Hp != pis.Hp || dis.maxHp != pis.maxHp || dis.numAttacksThisTurn != pis.numAttacksThisTurn) minionbool = false;
                if (dis.Ready != pis.Ready) minionbool = false; // includes frozen, exhaunted
                if (dis.playedThisTurn != pis.playedThisTurn) minionbool = false;
                if (dis.silenced != pis.silenced || dis.stealth != pis.stealth || dis.taunt != pis.taunt || dis.windfury != pis.windfury || dis.zonepos != pis.zonepos) minionbool = false;
                if (dis.divineshild != pis.divineshild || dis.cantLowerHPbelowONE != pis.cantLowerHPbelowONE || dis.immune != pis.immune) minionbool = false;
                if (dis.ownBlessingOfWisdom != pis.ownBlessingOfWisdom || dis.enemyBlessingOfWisdom != pis.enemyBlessingOfWisdom) minionbool = false;
                if (dis.ownPowerWordGlory != pis.ownPowerWordGlory || dis.enemyPowerWordGlory != pis.enemyPowerWordGlory) minionbool = false;
                if (dis.destroyOnEnemyTurnStart != pis.destroyOnEnemyTurnStart || dis.destroyOnEnemyTurnEnd != pis.destroyOnEnemyTurnEnd || dis.destroyOnOwnTurnEnd != pis.destroyOnOwnTurnEnd || dis.destroyOnOwnTurnStart != pis.destroyOnOwnTurnStart) minionbool = false;
                if (dis.ancestralspirit != pis.ancestralspirit || dis.desperatestand != pis.desperatestand || dis.souloftheforest != pis.souloftheforest || dis.stegodon != pis.stegodon || dis.livingspores != pis.livingspores) minionbool = false;
                if (dis.explorershat != pis.explorershat || dis.returnToHand != pis.returnToHand || dis.infest != pis.infest || dis.deathrattle2 != pis.deathrattle2) minionbool = false;
                if (dis.hChoice != pis.hChoice || dis.Elusive != pis.Elusive || dis.poisonous != pis.poisonous || dis.lifesteal != pis.lifesteal) minionbool = false;
                if (dis.handcard.card.type == CardDB.cardtype.LOCATION)
                {
                    if (dis.Hp != pis.Hp || dis.CooldownTurn != pis.CooldownTurn)
                    {
                        minionbool = false;
                    }
                }
            }
            if (minionbool == false)
            {
                if (logg) Helpfunctions.Instance.logg("ownminions changed");
                return false;
            }

            for (int i = 0; i < this.enemyMinions.Count; i++)
            {
                Minion dis = this.enemyMinions[i]; Minion pis = p.enemyMinions[i];

                if (dis.name != pis.name) minionbool = false;
                if (dis.Angr != pis.Angr || dis.Hp != pis.Hp || dis.maxHp != pis.maxHp || dis.numAttacksThisTurn != pis.numAttacksThisTurn) minionbool = false;
                if (dis.Ready != pis.Ready) minionbool = false; // includes frozen, exhaunted
                if (dis.playedThisTurn != pis.playedThisTurn) minionbool = false;
                if (dis.silenced != pis.silenced || dis.stealth != pis.stealth || dis.taunt != pis.taunt || dis.windfury != pis.windfury || dis.zonepos != pis.zonepos) minionbool = false;
                if (dis.divineshild != pis.divineshild || dis.cantLowerHPbelowONE != pis.cantLowerHPbelowONE || dis.immune != pis.immune) minionbool = false;
                if (dis.ownBlessingOfWisdom != pis.ownBlessingOfWisdom || dis.enemyBlessingOfWisdom != pis.enemyBlessingOfWisdom) minionbool = false;
                if (dis.ownPowerWordGlory != pis.ownPowerWordGlory || dis.enemyPowerWordGlory != pis.enemyPowerWordGlory) minionbool = false;
                if (dis.destroyOnEnemyTurnStart != pis.destroyOnEnemyTurnStart || dis.destroyOnEnemyTurnEnd != pis.destroyOnEnemyTurnEnd || dis.destroyOnOwnTurnEnd != pis.destroyOnOwnTurnEnd || dis.destroyOnOwnTurnStart != pis.destroyOnOwnTurnStart) minionbool = false;
                if (dis.ancestralspirit != pis.ancestralspirit || dis.desperatestand != pis.desperatestand || dis.souloftheforest != pis.souloftheforest || dis.stegodon != pis.stegodon || dis.livingspores != pis.livingspores) minionbool = false;
                if (dis.explorershat != pis.explorershat || dis.returnToHand != pis.returnToHand || dis.infest != pis.infest || dis.deathrattle2 != pis.deathrattle2) minionbool = false;
                if (dis.hChoice != pis.hChoice || dis.Elusive != pis.Elusive || dis.poisonous != pis.poisonous || dis.lifesteal != pis.lifesteal) minionbool = false;
            }
            if (minionbool == false)
            {
                if (logg) Helpfunctions.Instance.logg("enemyminions changed");
                return false;
            }

            for (int i = 0; i < this.owncards.Count; i++)
            {
                Handmanager.Handcard dishc = this.owncards[i]; Handmanager.Handcard pishc = p.owncards[i];
                if (dishc.position != pishc.position || dishc.entity != pishc.entity || dishc.getManaCost(this) != pishc.getManaCost(p))
                {
                    if (logg) Helpfunctions.Instance.logg("handcard changed: " + dishc.card.nameEN);
                    return false;
                }
            }

            for (int i = 0; i < this.ownMinions.Count; i++)
            {
                Minion dis = this.ownMinions[i]; Minion pis = p.ownMinions[i];
                if (dis.entitiyID != pis.entitiyID) Ai.Instance.updateEntitiy(pis.entitiyID, dis.entitiyID);

            }

            for (int i = 0; i < this.enemyMinions.Count; i++)
            {
                Minion dis = this.enemyMinions[i]; Minion pis = p.enemyMinions[i];
                if (dis.entitiyID != pis.entitiyID) Ai.Instance.updateEntitiy(pis.entitiyID, dis.entitiyID);

            }
            if (this.ownSecretsIDList.Count != p.ownSecretsIDList.Count)
            {
                if (logg) Helpfunctions.Instance.logg("secretsCount changed");
                return false;
            }
            for (int i = 0; i < this.ownSecretsIDList.Count; i++)
            {
                if (this.ownSecretsIDList[i] != p.ownSecretsIDList[i])
                {
                    if (logg) Helpfunctions.Instance.logg("secrets changed");
                    return false;
                }
            }
            return true;
        }

        public bool isEqualf(Playfield p)
        {
            if (this.value != p.value) return false;

            if (this.ownMinions.Count != p.ownMinions.Count || this.enemyMinions.Count != p.enemyMinions.Count || this.owncards.Count != p.owncards.Count) return false;

            if (this.cardsPlayedThisTurn != p.cardsPlayedThisTurn || this.mobsplayedThisTurn != p.mobsplayedThisTurn || this.ueberladung != p.ueberladung || this.lockedMana != p.lockedMana || this.ownAbilityReady != p.ownAbilityReady) return false;

            if (this.mana != p.mana || this.enemyMaxMana != p.enemyMaxMana || this.ownMaxMana != p.ownMaxMana || this.ownQuest.questProgress != p.ownQuest.questProgress) return false;

            if (this.ownHeroName != p.ownHeroName || this.enemyHeroName != p.enemyHeroName || this.enemySecretCount != p.enemySecretCount) return false;

            if (this.ownHero.Hp != p.ownHero.Hp || this.ownHero.Angr != p.ownHero.Angr || this.ownHero.armor != p.ownHero.armor || this.ownHero.frozen != p.ownHero.frozen || this.ownHero.immuneWhileAttacking != p.ownHero.immuneWhileAttacking || this.ownHero.immune != p.ownHero.immune) return false;

            if (this.ownHero.Ready != p.ownHero.Ready || !this.ownWeapon.isEqual(p.ownWeapon) || this.ownHero.numAttacksThisTurn != p.ownHero.numAttacksThisTurn || this.ownHero.windfury != p.ownHero.windfury) return false;

            if (this.enemyHero.Hp != p.enemyHero.Hp || !this.enemyWeapon.isEqual(p.enemyWeapon) || this.enemyHero.armor != p.enemyHero.armor || this.enemyHero.frozen != p.enemyHero.frozen || this.enemyHero.immune != p.enemyHero.immune) return false;

            if (this.ownHeroAblility.card.nameEN != p.ownHeroAblility.card.nameEN || this.spellpower != p.spellpower) return false;

            bool minionbool = true;
            for (int i = 0; i < this.ownMinions.Count; i++)
            {
                Minion dis = this.ownMinions[i]; Minion pis = p.ownMinions[i];
                if (dis.entitiyID != pis.entitiyID) minionbool = false;
                if (dis.Angr != pis.Angr || dis.Hp != pis.Hp || dis.maxHp != pis.maxHp || dis.numAttacksThisTurn != pis.numAttacksThisTurn) minionbool = false;
                if (dis.Ready != pis.Ready) minionbool = false; // includes frozen, exhaunted
                if (dis.playedThisTurn != pis.playedThisTurn) minionbool = false;
                if (dis.silenced != pis.silenced || dis.stealth != pis.stealth || dis.taunt != pis.taunt || dis.windfury != pis.windfury || dis.zonepos != pis.zonepos) minionbool = false;
                if (dis.divineshild != pis.divineshild || dis.cantLowerHPbelowONE != pis.cantLowerHPbelowONE || dis.immune != pis.immune) minionbool = false;
                if (dis.ownBlessingOfWisdom != pis.ownBlessingOfWisdom || dis.enemyBlessingOfWisdom != pis.enemyBlessingOfWisdom) minionbool = false;
                if (dis.ownPowerWordGlory != pis.ownPowerWordGlory || dis.enemyPowerWordGlory != pis.enemyPowerWordGlory) minionbool = false;
                if (dis.destroyOnEnemyTurnStart != pis.destroyOnEnemyTurnStart || dis.destroyOnEnemyTurnEnd != pis.destroyOnEnemyTurnEnd || dis.destroyOnOwnTurnEnd != pis.destroyOnOwnTurnEnd || dis.destroyOnOwnTurnStart != pis.destroyOnOwnTurnStart) minionbool = false;
                if (dis.ancestralspirit != pis.ancestralspirit || dis.desperatestand != pis.desperatestand || dis.souloftheforest != pis.souloftheforest || dis.stegodon != pis.stegodon || dis.livingspores != pis.livingspores) minionbool = false;
                if (dis.explorershat != pis.explorershat || dis.returnToHand != pis.returnToHand || dis.infest != pis.infest || dis.deathrattle2 != pis.deathrattle2) minionbool = false;
                if (dis.hChoice != pis.hChoice || dis.Elusive != pis.Elusive || dis.poisonous != pis.poisonous || dis.lifesteal != pis.lifesteal) minionbool = false;
                if (minionbool == false) break;
            }
            if (minionbool == false)
            {

                return false;
            }

            for (int i = 0; i < this.enemyMinions.Count; i++)
            {
                Minion dis = this.enemyMinions[i]; Minion pis = p.enemyMinions[i];
                if (dis.entitiyID != pis.entitiyID) minionbool = false;
                if (dis.Angr != pis.Angr || dis.Hp != pis.Hp || dis.maxHp != pis.maxHp || dis.numAttacksThisTurn != pis.numAttacksThisTurn) minionbool = false;
                if (dis.Ready != pis.Ready) minionbool = false; // includes frozen, exhaunted
                if (dis.playedThisTurn != pis.playedThisTurn) minionbool = false;
                if (dis.silenced != pis.silenced || dis.stealth != pis.stealth || dis.taunt != pis.taunt || dis.windfury != pis.windfury || dis.zonepos != pis.zonepos) minionbool = false;
                if (dis.divineshild != pis.divineshild || dis.cantLowerHPbelowONE != pis.cantLowerHPbelowONE || dis.immune != pis.immune) minionbool = false;
                if (dis.ownBlessingOfWisdom != pis.ownBlessingOfWisdom || dis.enemyBlessingOfWisdom != pis.enemyBlessingOfWisdom) minionbool = false;
                if (dis.ownPowerWordGlory != pis.ownPowerWordGlory || dis.enemyPowerWordGlory != pis.enemyPowerWordGlory) minionbool = false;
                if (dis.destroyOnEnemyTurnStart != pis.destroyOnEnemyTurnStart || dis.destroyOnEnemyTurnEnd != pis.destroyOnEnemyTurnEnd || dis.destroyOnOwnTurnEnd != pis.destroyOnOwnTurnEnd || dis.destroyOnOwnTurnStart != pis.destroyOnOwnTurnStart) minionbool = false;
                if (dis.ancestralspirit != pis.ancestralspirit || dis.desperatestand != pis.desperatestand || dis.souloftheforest != pis.souloftheforest || dis.stegodon != pis.stegodon || dis.livingspores != pis.livingspores) minionbool = false;
                if (dis.explorershat != pis.explorershat || dis.returnToHand != pis.returnToHand || dis.infest != pis.infest || dis.deathrattle2 != pis.deathrattle2) minionbool = false;
                if (dis.hChoice != pis.hChoice || dis.Elusive != pis.Elusive || dis.poisonous != pis.poisonous || dis.lifesteal != pis.lifesteal) minionbool = false;
                if (minionbool == false) break;
            }
            if (minionbool == false)
            {
                return false;
            }

            for (int i = 0; i < this.owncards.Count; i++)
            {
                Handmanager.Handcard dishc = this.owncards[i]; Handmanager.Handcard pishc = p.owncards[i];
                if (dishc.position != pishc.position || dishc.entity != pishc.entity || dishc.manacost != pishc.manacost)
                {
                    return false;
                }
            }

            if (this.enemySecretCount >= 1)
            {
                for (int i = 0; i < this.enemySecretList.Count; i++)
                {
                    if (!this.enemySecretList[i].isEqual(p.enemySecretList[i]))
                    {
                        return false;
                    }
                }
            }

            if (this.ownSecretsIDList.Count != p.ownSecretsIDList.Count)
            {
                return false;
            }
            for (int i = 0; i < this.ownSecretsIDList.Count; i++)
            {
                if (this.ownSecretsIDList[i] != p.ownSecretsIDList[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 获取hash值
        /// </summary>
        /// <returns></returns>
        public Int64 GetPHash()
        {
            Int64 retval = 0;
            if (this.playactions.Count > 0)
            {
                foreach (Action a in this.playactions)
                {
                    switch (a.actionType)
                    {
                        case actionEnum.playcard:
                            retval += a.card.entity;
                            if (a.target != null)
                            {
                                retval += a.target.entitiyID;
                            }
                            retval += a.druidchoice;
                            continue;
                        case actionEnum.attackWithMinion:
                            retval += a.own.entitiyID + a.target.entitiyID;
                            continue;
                        case actionEnum.attackWithHero:
                            retval += a.target.entitiyID;
                            continue;
                        case actionEnum.useHeroPower:
                            retval += 100;
                            if (a.target != null)
                            {
                                retval += a.target.entitiyID;
                            }
                            retval += a.druidchoice;
                            continue;
                    }
                }
                if (this.playactions[this.playactions.Count - 1].card != null && this.playactions[this.playactions.Count - 1].card.card.type == CardDB.cardtype.MOB) retval++;
                retval += this.manaTurnEnd;
            }

            retval += this.anzOgOwnCThunAngrBonus + this.anzOwnJadeGolem + this.anzOwnElementalsLastTurn;
            retval *= 1000;

            foreach (Minion m in this.ownMinions)
            {
                retval += m.entitiyID + m.Angr + m.Hp + (m.taunt ? 1 : 0) + (m.divineshild ? 1 : 0) + (m.wounded ? 0 : 1);
            }
            retval *= 10000000;
            retval += 10000 * this.ownMinions.Count + 100 * this.enemyMinions.Count + 1000 * this.mana + 100000 * (this.ownHero.Hp + this.enemyHero.Hp) + this.owncards.Count + this.enemycarddraw + this.cardsPlayedThisTurn + this.mobsplayedThisTurn + this.ownHero.Angr + this.ownHero.armor + this.ownWeapon.Angr + this.enemyWeapon.Durability + this.spellpower + this.enemyspellpower + this.ownQuest.questProgress;
            return retval;
        }

        /// <summary>
        /// 模拟敌方使用AOE（范围攻击）技能的场景，并评估对局势的影响。
        /// </summary>
        /// <param name="pprob">敌方第一种AOE技能的概率。</param>
        /// <param name="pprob2">敌方第二种AOE技能的概率。</param>
        public void enemyPlaysAoe(int pprob, int pprob2)
        {
            if (!this.loatheb)  // 如果未受洛欧塞布的影响
            {
                Playfield p = new Playfield(this);  // 创建当前场景的副本
                float oldval = Ai.Instance.botBase.getPlayfieldValue(p);  // 计算当前场景的价值
                p.value = int.MinValue;  // 设置场景值为最小值，避免误用

                // 模拟敌方使用AOE技能的效果
                p.EnemyCardPlaying(p.enemyHeroStartClass, p.mana, p.enemyAnzCards, pprob, pprob2);

                float newval = Ai.Instance.botBase.getPlayfieldValue(p);  // 计算敌方使用AOE后的场景价值
                p.value = int.MinValue;  // 再次设置场景值为最小值

                // 如果模拟后的场景对敌方更有利（价值更低）
                if (oldval > newval)
                {
                    this.copyValuesFrom(p);  // 更新当前场景为模拟后的场景
                }
            }
        }


        /// <summary>
        /// 根据敌方英雄职业、当前法力值、手牌数量和概率，模拟敌方使用AOE（范围攻击）或其他卡牌的行为。
        /// </summary>
        /// <param name="enemyHeroStrtClass">敌方英雄的职业。</param>
        /// <param name="currmana">当前敌方的法力值。</param>
        /// <param name="cardcount">敌方手中的卡牌数量。</param>
        /// <param name="playAroundProb">敌方使用卡牌的概率。</param>
        /// <param name="pap2">另一个影响敌方使用卡牌的概率参数。</param>
        /// <returns>模拟敌方使用卡牌后剩余的法力值。</returns>
        public int EnemyCardPlaying(TAG_CLASS enemyHeroStrtClass, int currmana, int cardcount, int playAroundProb, int pap2)
        {
            int mana = currmana;
            if (cardcount == 0) return currmana;  // 如果敌方手中没有卡牌，直接返回当前法力值

            bool useAOE = false;  // 是否使用AOE技能的标志
            int mobscount = 0;  // 己方随从数量统计
            foreach (Minion min in this.ownMinions)
            {
                if (min.maxHp >= 2 && min.Angr >= 2) mobscount++;  // 统计攻击力和生命值都大于等于2的己方随从
            }

            if (mobscount >= 3) useAOE = true;  // 如果己方随从数量达到3个或以上，敌方可能会使用AOE技能

            if (enemyHeroStrtClass == TAG_CLASS.WARRIOR)  // 如果敌方是战士职业
            {
                bool usewhirlwind = true;  // 是否使用旋风斩的标志
                foreach (Minion m in this.enemyMinions)
                {
                    if (m.Hp == 1) usewhirlwind = false;  // 如果敌方随从生命值为1，则不使用旋风斩
                }
                if (this.ownMinions.Count <= 3) usewhirlwind = false;  // 如果己方随从数量小于等于3，则不使用旋风斩

                if (usewhirlwind)
                {
                    mana = EnemyPlaysACard(CardDB.cardNameEN.whirlwind, mana, playAroundProb, pap2);  // 模拟敌方使用旋风斩，并更新法力值
                }
            }

            if (!useAOE) return mana;  // 如果不使用AOE，直接返回当前法力值

            // 根据敌方英雄的职业，模拟使用相应的AOE技能，并更新法力值
            switch (enemyHeroStrtClass)
            {
                case TAG_CLASS.MAGE:  // 法师
                    mana = EnemyPlaysACard(CardDB.cardNameEN.flamestrike, mana, playAroundProb, pap2);//烈焰风暴
                    mana = EnemyPlaysACard(CardDB.cardNameEN.blizzard, mana, playAroundProb, pap2);//暴风雪
                    break;
                case TAG_CLASS.HUNTER:  // 猎人
                    mana = EnemyPlaysACard(CardDB.cardNameEN.unleashthehounds, mana, playAroundProb, pap2);//放狗
                    break;
                case TAG_CLASS.PRIEST:  // 牧师
                    mana = EnemyPlaysACard(CardDB.cardNameEN.holynova, mana, playAroundProb, pap2);//神圣新星
                    break;
                case TAG_CLASS.SHAMAN:  // 萨满
                    mana = EnemyPlaysACard(CardDB.cardNameEN.lightningstorm, mana, playAroundProb, pap2);//闪电风暴
                    mana = EnemyPlaysACard(CardDB.cardNameEN.maelstromportal, mana, playAroundProb, pap2);//漩涡传送门
                    break;
                case TAG_CLASS.PALADIN:  // 圣骑士
                    mana = EnemyPlaysACard(CardDB.cardNameEN.consecration, mana, playAroundProb, pap2);//奉献
                    break;
                case TAG_CLASS.DRUID:  // 德鲁伊
                    mana = EnemyPlaysACard(CardDB.cardNameEN.swipe, mana, playAroundProb, pap2);//横扫
                    break;
            }

            return mana;  // 返回敌方使用卡牌后的剩余法力值
        }


        /// <summary>
        /// 模拟敌方使用指定的卡牌，并根据卡牌效果对己方和敌方的随从、英雄进行相应的操作，
        /// 最后返回剩余的法力值。
        /// </summary>
        /// <param name="cardname">敌方使用的卡牌名称。</param>
        /// <param name="currmana">敌方当前的法力值。</param>
        /// <param name="playAroundProb">敌方使用卡牌的概率。</param>
        /// <param name="pap2">另一个影响敌方使用卡牌的概率参数。</param>
        /// <returns>使用卡牌后的剩余法力值。</returns>
        public int EnemyPlaysACard(CardDB.cardNameEN cardname, int currmana, int playAroundProb, int pap2)
        {
            switch (cardname)
            {
                case CardDB.cardNameEN.flamestrike:  // 烈焰风暴
                    if (currmana >= 7)
                    {
                        if (wehaveCounterspell == 0)  // 如果没有反制法术
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.CS2_032, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.ownMinions;
                            int damage = getEnemySpellDamageDamage(5);  // 烈焰风暴造成5点伤害
                            foreach (Minion enemy in temp)
                            {
                                enemy.cantLowerHPbelowONE = dontkill;  // 如果设置了dontkill标志，则随从的HP不会降到1以下
                                this.minionGetDamageOrHeal(enemy, damage);
                                enemy.cantLowerHPbelowONE = false;
                            }
                        }
                        else wehaveCounterspell++;  // 如果有反制法术，则递增反制计数
                        currmana -= 7;  // 消耗7点法力值
                    }
                    break;

                case CardDB.cardNameEN.blizzard:  // 暴风雪
                    if (currmana >= 6)
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.CS2_028, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.ownMinions;
                            int damage = getEnemySpellDamageDamage(2);  // 暴风雪造成2点伤害并使随从冻结
                            foreach (Minion enemy in temp)
                            {
                                minionGetFrozen(enemy);  // 使随从冻结
                                enemy.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(enemy, damage);
                                enemy.cantLowerHPbelowONE = false;
                            }
                        }
                        else wehaveCounterspell++;
                        currmana -= 6;
                    }
                    break;

                case CardDB.cardNameEN.unleashthehounds:  // 放狗
                    if (currmana >= 3)  // 消耗3点法力值
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.EX1_538, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob)
                            {
                                dontkill = true;
                            }

                            int anz = this.ownMinions.Count;  // 己方随从的数量
                            int posi = this.enemyMinions.Count - 1;
                            CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_538t);  // 召唤的狗
                            for (int i = 0; i < anz; i++)
                            {
                                callKid(kid, posi, false);  // 根据己方随从数量召唤狗
                            }
                        }
                        else wehaveCounterspell++;
                        currmana -= 3;
                    }
                    break;

                case CardDB.cardNameEN.holynova:  // 神圣新星
                    if (currmana >= 3)
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.CS1_112, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.enemyMinions;
                            int heal = getEnemySpellHeal(2);  // 神圣新星对敌方随从和英雄治疗2点
                            int damage = getEnemySpellDamageDamage(2);  // 对己方随从和英雄造成2点伤害
                            foreach (Minion enemy in temp)
                            {
                                this.minionGetDamageOrHeal(enemy, -heal);
                            }
                            this.minionGetDamageOrHeal(this.enemyHero, -heal);
                            temp = this.ownMinions;
                            foreach (Minion enemy in temp)
                            {
                                enemy.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(enemy, damage);
                                enemy.cantLowerHPbelowONE = false;
                            }
                            this.minionGetDamageOrHeal(this.ownHero, damage);
                        }
                        else wehaveCounterspell++;
                        currmana -= 5;
                    }
                    break;

                case CardDB.cardNameEN.lightningstorm:  // 闪电风暴
                    if (currmana >= 3)  // 消耗3点法力值
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.EX1_259, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.ownMinions;
                            int damage = getEnemySpellDamageDamage(3);  // 闪电风暴造成3点伤害
                            foreach (Minion enemy in temp)
                            {
                                enemy.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(enemy, damage);
                                enemy.cantLowerHPbelowONE = false;
                            }
                        }
                        else wehaveCounterspell++;
                        currmana -= 3;
                    }
                    break;

                case CardDB.cardNameEN.maelstromportal:  // 漩涡传送门
                    if (currmana >= 2)  // 消耗2点法力值
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.KAR_073, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.ownMinions;
                            int damage = getEnemySpellDamageDamage(1);  // 漩涡传送门造成1点伤害
                            foreach (Minion enemy in temp)
                            {
                                enemy.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(enemy, damage);
                                enemy.cantLowerHPbelowONE = false;
                            }
                        }
                        else wehaveCounterspell++;
                        currmana -= 2;
                    }
                    break;

                case CardDB.cardNameEN.whirlwind:  // 旋风斩
                    if (currmana >= 1)  // 消耗1点法力值
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.EX1_400, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.enemyMinions;
                            int damage = getEnemySpellDamageDamage(1);  // 旋风斩造成1点伤害
                            foreach (Minion enemy in temp)
                            {
                                this.minionGetDamageOrHeal(enemy, damage);
                            }
                            temp = this.ownMinions;
                            foreach (Minion enemy in temp)
                            {
                                enemy.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(enemy, damage);
                                enemy.cantLowerHPbelowONE = false;
                            }
                        }
                        else wehaveCounterspell++;
                        currmana -= 1;
                    }
                    break;

                case CardDB.cardNameEN.consecration:  // 奉献
                    if (currmana >= 3)
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.CS2_093, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.ownMinions;
                            int damage = getEnemySpellDamageDamage(2);  // 奉献造成2点伤害
                            foreach (Minion enemy in temp)
                            {
                                enemy.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(enemy, damage);
                                enemy.cantLowerHPbelowONE = false;
                            }

                            this.minionGetDamageOrHeal(this.ownHero, damage);
                        }
                        else wehaveCounterspell++;
                        currmana -= 4;
                    }
                    break;

                case CardDB.cardNameEN.swipe:  // 横扫
                    if (currmana >= 3)
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.CS2_012, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            int damage4 = getEnemySpellDamageDamage(4);  // 横扫对一个目标造成4点伤害
                            int damage1 = getEnemySpellDamageDamage(1);  // 对其他目标造成1点伤害

                            List<Minion> temp = this.ownMinions;
                            Minion target = null;
                            foreach (Minion mnn in temp)
                            {
                                if (mnn.Hp <= damage4 || mnn.handcard.card.isSpecialMinion || target == null)
                                {
                                    target = mnn;  // 选择主目标
                                }
                            }
                            foreach (Minion mnn in temp.ToArray())
                            {
                                mnn.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(mnn, mnn.entitiyID == target.entitiyID ? damage4 : damage1);
                                mnn.cantLowerHPbelowONE = false;
                            }
                        }
                        else wehaveCounterspell++;
                        currmana -= 4;
                    }
                    break;
                case CardDB.cardNameEN.remorselesswinter:  // 冷酷严冬
                    if (currmana >= 4)
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.RLK_709, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.ownMinions;
                            int damage = getEnemySpellDamageDamage(2);  // 冷酷严冬造成2点伤害
                            foreach (Minion enemy in temp)
                            {
                                enemy.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(enemy, damage);
                                enemy.cantLowerHPbelowONE = false;
                            }
                        }
                        else wehaveCounterspell++;
                        currmana -= 4;
                    }
                    break;

                case CardDB.cardNameEN.starfall:  // 星辰坠落
                    if (currmana >= 5)
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.VAN_NEW1_007, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.ownMinions;
                            int damage = getEnemySpellDamageDamage(2);  // 星辰坠落造成2点伤害
                            foreach (Minion enemy in temp)
                            {
                                enemy.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(enemy, damage);
                                enemy.cantLowerHPbelowONE = false;
                            }
                        }
                        else wehaveCounterspell++;
                        currmana -= 5;
                    }
                    break;

                case CardDB.cardNameEN.volcanicpotion:  // 火山药水
                    if (currmana >= 3)
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.CFM_065, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.ownMinions;
                            int damage = getEnemySpellDamageDamage(2);  // 火山药水造成2点伤害
                            foreach (Minion enemy in temp)
                            {
                                enemy.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(enemy, damage);
                                enemy.cantLowerHPbelowONE = false;
                            }
                        }
                        else wehaveCounterspell++;
                        currmana -= 3;
                    }
                    break;

                case CardDB.cardNameEN.firesale:  // 火热促销
                    if (currmana >= 4)
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.SW_107, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.ownMinions;
                            int damage = getEnemySpellDamageDamage(3);  // 火热促销造成3点伤害
                            foreach (Minion enemy in temp)
                            {
                                enemy.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(enemy, damage);
                                enemy.cantLowerHPbelowONE = false;
                            }
                        }
                        else wehaveCounterspell++;
                        currmana -= 4;
                    }
                    break;

                case CardDB.cardNameEN.risingwaves:  // 浪潮涌起
                    if (currmana >= 3)
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.VAC_953, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.ownMinions;
                            int damage = getEnemySpellDamageDamage(2);  // 浪潮涌起初始造成2点伤害
                            bool anyMinionDied = false;
                            foreach (Minion enemy in temp)
                            {
                                enemy.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(enemy, damage);
                                if (enemy.Hp <= 0)
                                {
                                    anyMinionDied = true;
                                }
                                enemy.cantLowerHPbelowONE = false;
                            }
                            if (!anyMinionDied)
                            {
                                foreach (Minion enemy in temp)
                                {
                                    this.minionGetDamageOrHeal(enemy, damage);  // 如果没有随从死亡，再造成2点伤害
                                }
                            }
                        }
                        else wehaveCounterspell++;
                        currmana -= 3;
                    }
                    break;

                case CardDB.cardNameEN.spiritlash:  // 灵魂鞭笞
                    if (currmana >= 2)
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.ICC_802, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.ownMinions;
                            int damage = getEnemySpellDamageDamage(1);  // 灵魂鞭笞造成1点伤害
                            foreach (Minion enemy in temp)
                            {
                                enemy.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(enemy, damage);
                                this.minionGetDamageOrHeal(this.enemyHero, -damage);  // 对敌方英雄造成治疗
                                enemy.cantLowerHPbelowONE = false;
                            }
                        }
                        else wehaveCounterspell++;
                        currmana -= 2;
                    }
                    break;

                case CardDB.cardNameEN.dragonfirepotion:  // 龙息药水
                    if (currmana >= 6)
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.CFM_662, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.ownMinions;
                            int damage = getEnemySpellDamageDamage(5);  // 龙息药水造成5点伤害
                            foreach (Minion enemy in temp)
                            {
                                if (!enemy.handcard.card.race.Equals(TAG_RACE.DRAGON))  // 如果随从不是龙族，则造成伤害
                                {
                                    enemy.cantLowerHPbelowONE = dontkill;
                                    this.minionGetDamageOrHeal(enemy, damage);
                                    enemy.cantLowerHPbelowONE = false;
                                }
                            }
                        }
                        else wehaveCounterspell++;
                        currmana -= 6;
                    }
                    break;

                case CardDB.cardNameEN.fanofknives:  // 刀扇
                    if (currmana >= 2)
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.EX1_129, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.ownMinions;
                            int damage = getEnemySpellDamageDamage(1);  // 刀扇造成1点伤害
                            foreach (Minion enemy in temp)
                            {
                                enemy.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(enemy, damage);
                                enemy.cantLowerHPbelowONE = false;
                            }
                        }
                        else wehaveCounterspell++;
                        currmana -= 3;
                    }
                    break;

                case CardDB.cardNameEN.elementaldestruction:  // 元素毁灭
                    if (currmana >= 3)
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.AT_051, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.ownMinions;
                            Random rng = new Random();
                            int damage = rng.Next(4, 6);  // 元素毁灭造成4到5点伤害
                            foreach (Minion enemy in temp)
                            {
                                enemy.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(enemy, damage);
                                enemy.cantLowerHPbelowONE = false;
                            }
                        }
                        else wehaveCounterspell++;
                        currmana -= 3;
                    }
                    break;

                case CardDB.cardNameEN.hellfire:  // 地狱烈焰
                    if (currmana >= 3)
                    {
                        if (wehaveCounterspell == 0)
                        {
                            bool dontkill = false;
                            int prob = Probabilitymaker.Instance.getProbOfEnemyHavingCardInHand(CardDB.cardIDEnum.CORE_CS2_062, this.enemyAnzCards, this.enemyDeckSize);
                            if (playAroundProb > prob) return currmana;
                            if (pap2 > prob) dontkill = true;

                            List<Minion> temp = this.ownMinions;
                            int damage = getEnemySpellDamageDamage(3);  // 地狱烈焰造成3点伤害
                            foreach (Minion enemy in temp)
                            {
                                enemy.cantLowerHPbelowONE = dontkill;
                                this.minionGetDamageOrHeal(enemy, damage);
                                enemy.cantLowerHPbelowONE = false;
                            }
                            this.minionGetDamageOrHeal(this.ownHero, damage);
                            this.minionGetDamageOrHeal(this.enemyHero, damage);
                        }
                        else wehaveCounterspell++;
                        currmana -= 3;
                    }
                    break;
            }
            return currmana;  // 返回使用卡牌后的剩余法力值
        }

        /// <summary>
        /// 获取并返回下一个实体编号，同时将实体编号计数器递增。
        /// </summary>
        /// <returns>当前的实体编号。</returns>
        public int getNextEntity()
        {
            int retval = this.nextEntity;  // 保存当前的实体编号
            this.nextEntity++;  // 将实体编号计数器递增
            return retval;  // 返回当前的实体编号
        }

        /// <summary>
        /// 获得所有可攻击的目标随从
        /// </summary>
        /// <param name="own"></param>
        /// <param name="isLethalCheck"></param>
        /// <returns></returns>
        public List<Minion> GetAttackTargets(bool own, bool isLethalCheck)
        {
            List<Minion> trgts = new List<Minion>();
            List<Minion> trgts2 = new List<Minion>();

            List<Minion> temp = (own) ? this.enemyMinions : this.ownMinions;
            bool hasTaunts = false;
            foreach (Minion m in temp)
            {
                if (m.untouchable) continue;//不可攻击
                if (m.stealth) continue;//潜行
                if (m.taunt)
                {
                    hasTaunts = true;
                    trgts.Add(m);
                }
                else
                {
                    trgts2.Add(m);
                }
            }
            if (hasTaunts) return trgts;

            if (isLethalCheck) trgts2.Clear(); // only target enemy hero during Lethal check!

            if (own && !(this.enemyHero.immune || this.enemyHero.stealth)) trgts2.Add(this.enemyHero);//免疫 潜行
            else if (!own && !(this.ownHero.immune || this.ownHero.stealth)) trgts2.Add(this.ownHero);

            //移除地标
            trgts2.RemoveAll(minion => minion != null &&
                                       minion.handcard != null &&
                                       minion.handcard.card != null &&
                                       minion.handcard.card.type == CardDB.cardtype.LOCATION);
            return trgts2;
        }

        /// <summary>
        /// 获取最好的位置
        /// </summary>
        /// <param name="card"></param>
        /// <param name="lethal"></param>
        /// <returns></returns>
        public int getBestPlace(CardDB.Card card, bool lethal)
        {
            //we return the zonepos!
            if (card.type != CardDB.cardtype.MOB) return 1;
            if (this.ownMinions.Count == 0) return 1;
            if (this.ownMinions.Count == 1)
            {
                if (this.ownMinions[0].Angr < card.Attack) return 1;
                else if (this.ownMinions[0].handcard.card.nameEN == CardDB.cardNameEN.flametonguetotem || this.ownMinions[0].handcard.card.nameEN == CardDB.cardNameEN.direwolfalpha) return 1;
                else if (card.nameEN == CardDB.cardNameEN.tuskarrtotemic) return 1;
                else if (this.ownMinions[0].handcard.card.nameCN == CardDB.cardNameCN.战场军官
                    || this.ownMinions[0].handcard.card.nameCN == CardDB.cardNameCN.恐狼前锋
                    || this.ownMinions[0].handcard.card.nameCN == CardDB.cardNameCN.火舌图腾) return 1;
                else return 2;
            }

            // 战场军官特别判定,随从至少两只
            if (card.nameCN == CardDB.cardNameCN.战场军官)
            {
                int place = 1;
                int maxAngr = 0;
                for (int ii = 1; ii < this.ownMinions.Count; ii++)
                {
                    int angr = (this.ownMinions[ii - 1].windfury || this.ownMinions[ii - 1].frozen || this.ownMinions[ii - 1].cantAttack ? 0 : this.ownMinions[ii - 1].Angr) + (this.ownMinions[ii].windfury || this.ownMinions[ii].frozen || this.ownMinions[ii].cantAttack ? 0 : this.ownMinions[ii].Angr);
                    if (angr > maxAngr)
                    {
                        place = ii + 1;
                        maxAngr = angr;
                    }
                }
                return place;
            }

            for (int ii = 0; ii < this.ownMinions.Count; ii++)
            {
                if (this.ownMinions[ii].handcard.card.nameCN == CardDB.cardNameCN.战场军官 || this.ownMinions[ii].handcard.card.nameCN == CardDB.cardNameCN.恐狼前锋 || this.ownMinions[ii].handcard.card.nameCN == CardDB.cardNameCN.战场军官)
                {
                    // 冲锋怪放在战场军官左边
                    if (card.Charge || card.Rush)
                    {
                        return ii + 1;
                    }
                    else
                    {
                        // 右边没有怪或者左边有两只怪
                        if (this.ownMinions.Count - ii <= 1 || ii >= 2) return this.ownMinions.Count + 1;
                        else return 1;
                    }
                }
            }

            // buff 怪
            if (card.nameCN == CardDB.cardNameCN.暴风城卫兵 || card.nameCN == CardDB.cardNameCN.阿古斯防御者 || card.nameCN == CardDB.cardNameCN.年迈的法师
                || card.nameCN == CardDB.cardNameCN.阳焰瓦格里 || card.nameCN == CardDB.cardNameCN.菌菇术士 || card.nameCN == CardDB.cardNameCN.蠕动的恐魔 || card.nameCN == CardDB.cardNameCN.污手街守护者)
            {
                int place = 1;
                int maxVal = 0;
                for (int ii = 1; ii < this.ownMinions.Count; ii++)
                {
                    int val = 0;
                    if (this.ownMinions[ii - 1].Ready)
                    {
                        val++;
                        if (this.ownMinions[ii - 1].windfury) val++;
                    }
                    if (this.ownMinions[ii].Ready)
                    {
                        val++;
                        if (this.ownMinions[ii].windfury) val++;
                    }
                    if (val > maxVal)
                    {
                        place = ii + 1;
                        maxVal = val;
                    }
                }
                return place;
            }

            // 为军官准备
            if (Ai.Instance.botBase.BehaviorName() == "骑士" || Ai.Instance.botBase.BehaviorName() == "黑眼任务术")
            {
                int nowAngr = card.Attack;
                for (int ii = 0; ii < this.ownMinions.Count; ii++)
                {
                    if (this.ownMinions[ii].Angr < nowAngr)
                    {
                        return ii + 1;
                    }
                }
                return this.ownMinions.Count + 1;
            }


            int omCount = this.ownMinions.Count;
            int[] places = new int[omCount];
            int[] buffplaces = new int[omCount];
            int i = 0;
            int tempval = 0;
            if (lethal)
            {
                bool givesBuff = false;
                switch (card.nameEN)
                {
                    case CardDB.cardNameEN.grimestreetprotector: givesBuff = true; break;
                    case CardDB.cardNameEN.defenderofargus: givesBuff = true; break;
                    case CardDB.cardNameEN.flametonguetotem: givesBuff = true; break;
                    case CardDB.cardNameEN.direwolfalpha: givesBuff = true; break;
                    case CardDB.cardNameEN.ancientmage: givesBuff = true; break;
                    case CardDB.cardNameEN.tuskarrtotemic: givesBuff = true; break;
                    case CardDB.cardNameEN.battlegroundbattlemaster: givesBuff = true; break;
                }
                if (givesBuff)
                {
                    if (this.ownMinions.Count == 2) return 2;
                    i = 0;
                    foreach (Minion m in this.ownMinions)
                    {

                        places[i] = 0;
                        tempval = 0;
                        if (m.Ready)
                        {
                            tempval -= m.Angr - 1;
                            if (m.windfury) tempval -= m.Angr - 1;
                        }
                        else tempval = 1000;
                        places[i] = tempval;

                        i++;
                    }

                    i = 0;
                    int bestpl = 7;
                    int bestval = 10000;
                    foreach (Minion m in this.ownMinions)
                    {
                        int prev = 0;
                        int next = 0;
                        if (i >= 1) prev = places[i - 1];
                        next = places[i];
                        if (bestval >= prev + next)
                        {
                            bestval = prev + next;
                            bestpl = i;
                        }
                        i++;
                    }
                    return bestpl + 1;
                }
                else return this.ownMinions.Count + 1;
            }
            //日怒、阿古斯
            if (card.nameEN == CardDB.cardNameEN.sunfuryprotector || card.nameEN == CardDB.cardNameEN.defenderofargus) // bestplace, if right and left minions have no taunt + lots of hp, dont make priority-minions to taunt
            {
                if (lethal) return 1;
                if (this.ownMinions.Count == 2)
                {
                    int val1 = prozis.penman.getValueOfUsefulNeedKeepPriority(this.ownMinions[0].handcard.card.nameEN);
                    int val2 = prozis.penman.getValueOfUsefulNeedKeepPriority(this.ownMinions[1].handcard.card.nameEN);
                    if (val1 == 0 && val2 == 0) return 2;
                    else if (val1 > val2) return 3;
                    else return 1;
                }

                i = 0;
                foreach (Minion m in this.ownMinions)
                {

                    places[i] = 0;
                    tempval = 0;
                    if (!m.taunt)
                    {
                        tempval -= m.Hp;
                    }
                    else
                    {
                        tempval -= m.Hp - 2;
                    }

                    if (m.windfury)
                    {
                        tempval += 2;
                    }

                    tempval += prozis.penman.getValueOfUsefulNeedKeepPriority(m.handcard.card.nameEN);
                    places[i] = tempval;
                    i++;
                }


                i = 0;
                int bestpl = 7;
                int bestval = 10000;
                foreach (Minion m in this.ownMinions)
                {
                    int prev = 0;
                    int next = 0;
                    if (i >= 1) prev = places[i - 1];
                    next = places[i];
                    if (bestval > prev + next)
                    {
                        bestval = prev + next;
                        bestpl = i;
                    }
                    i++;
                }
                return bestpl + 1;
            }

            int cardIsBuffer = 0;
            bool placebuff = false;
            if (card.nameEN == CardDB.cardNameEN.flametonguetotem || card.nameEN == CardDB.cardNameEN.direwolfalpha || card.nameEN == CardDB.cardNameEN.tuskarrtotemic || card.nameEN == CardDB.cardNameEN.battlegroundbattlemaster)
            {
                placebuff = true;
                if (card.nameEN == CardDB.cardNameEN.flametonguetotem || card.nameEN == CardDB.cardNameEN.tuskarrtotemic) cardIsBuffer = 2;
                if (card.nameEN == CardDB.cardNameEN.direwolfalpha) cardIsBuffer = 1;
            }
            bool tundrarhino = false;
            foreach (Minion m in this.ownMinions)
            {
                if (m.handcard.card.nameEN == CardDB.cardNameEN.tundrarhino) tundrarhino = true;
                if (m.handcard.card.nameEN == CardDB.cardNameEN.flametonguetotem || m.handcard.card.nameEN == CardDB.cardNameEN.direwolfalpha || card.nameEN == CardDB.cardNameEN.battlegroundbattlemaster) placebuff = true;
            }
            //max attack this turn
            if (placebuff)
            {


                int cval = 0;
                if (card.Charge || (card.race == CardDB.Race.PET && tundrarhino))
                {
                    cval = card.Attack;
                    if (card.windfury) cval = card.Attack;
                }
                if (card.nameEN == CardDB.cardNameEN.nerubianegg)
                {
                    cval += 1;
                }
                i = 0;
                int[] whirlwindplaces = new int[this.ownMinions.Count];
                int gesval = 0;
                int minionsBefore = -1;
                int minionsAfter = -1;
                foreach (Minion m in this.ownMinions)
                {
                    buffplaces[i] = 0;
                    whirlwindplaces[i] = 1;
                    places[i] = 0;
                    tempval = -1;

                    if (m.Ready)
                    {
                        tempval = m.Angr;
                        if (m.windfury && m.numAttacksThisTurn == 0)
                        {
                            tempval += m.Angr;
                            whirlwindplaces[i] = 2;
                        }
                    }
                    else whirlwindplaces[i] = 0;

                    switch (m.handcard.card.nameEN)
                    {
                        case CardDB.cardNameEN.flametonguetotem:
                            buffplaces[i] = 2;
                            goto case CardDB.cardNameEN.aiextra1;
                        case CardDB.cardNameEN.direwolfalpha:
                            buffplaces[i] = 1;
                            goto case CardDB.cardNameEN.aiextra1;
                        case CardDB.cardNameEN.aiextra1:
                            if (minionsBefore == -1) minionsBefore = i;
                            minionsAfter = omCount - i - 1;
                            break;
                    }
                    tempval++;
                    places[i] = tempval;
                    gesval += tempval;
                    i++;
                }
                //gesval = whole possible damage
                int bplace = 0;
                int bvale = 0;
                bool needbefore = false;
                int middle = (omCount + 1) / 2;
                int middleProximity = 1000;
                int tmp = 0;
                if (minionsBefore > -1 && minionsBefore <= minionsAfter) needbefore = true;
                tempval = 0;
                for (i = 0; i <= omCount; i++)
                {
                    tempval = gesval;
                    int current = cval;
                    int prev = 0;
                    int next = 0;
                    if (i >= 1)
                    {
                        tempval -= places[i - 1];
                        prev = places[i - 1];
                        if (prev >= 0) prev += whirlwindplaces[i - 1] * cardIsBuffer;
                        if (i < omCount)
                        {
                            prev -= whirlwindplaces[i - 1] * buffplaces[i];
                        }
                        if (current > 0) current += buffplaces[i - 1];
                    }
                    if (i < omCount)
                    {
                        tempval -= places[i];
                        next = places[i];
                        if (next >= 0) next += whirlwindplaces[i] * cardIsBuffer;
                        if (i >= 1)
                        {
                            next -= whirlwindplaces[i] * buffplaces[i - 1];
                        }
                        if (current > 0) current += buffplaces[i];
                    }
                    tempval += current + prev + next;

                    bool setVal = false;
                    if (tempval > bvale) setVal = true;
                    else if (tempval == bvale)
                    {
                        if (needbefore)
                        {
                            if (i <= minionsBefore) setVal = true;
                        }
                        else
                        {
                            if (minionsBefore > -1)
                            {
                                if (i >= omCount - minionsAfter) setVal = true;
                            }
                            else
                            {
                                tmp = middle - i;
                                if (tmp < 0) tmp *= -1;
                                if (tmp <= middleProximity)
                                {
                                    middleProximity = tmp;
                                    setVal = true;
                                }
                            }
                        }
                    }
                    if (setVal)
                    {
                        bplace = i;
                        bvale = tempval;
                    }
                }
                return bplace + 1;
            }

            // normal placement
            int bestplace = 0;
            int bestvale = 0;
            if (prozis.settings.placement == 1)
            {
                int cardvalue = card.Health * 2 + card.Attack;
                if (card.Shield) cardvalue = cardvalue * 3 / 2;
                cardvalue += prozis.penman.getValueOfUsefulNeedKeepPriority(card.nameEN);

                i = 0;
                foreach (Minion m in this.ownMinions)
                {
                    places[i] = 0;
                    tempval = m.maxHp * 2 + m.Angr;
                    if (m.divineshild) tempval = tempval * 3 / 2;
                    if (!m.silenced) tempval += prozis.penman.getValueOfUsefulNeedKeepPriority(m.handcard.card.nameEN);
                    places[i] = tempval;
                    i++;
                }

                tempval = 0;
                for (i = 0; i <= omCount; i++)
                {
                    if (i >= omCount - i)
                    {
                        bestplace = i;
                        break;
                    }
                    if (cardvalue >= places[i])
                    {
                        if (cardvalue < places[omCount - i - 1])
                        {
                            bestplace = i;
                            break;
                        }
                        else
                        {
                            if (places[i] > places[omCount - i - 1]) bestplace = omCount - i;
                            else bestplace = i;
                            break;
                        }
                    }
                    else
                    {
                        if (cardvalue >= places[omCount - i - 1])
                        {
                            bestplace = omCount - i;
                            break;
                        }
                    }
                }
            }
            else
            {
                int cardvalue = card.Attack * 2 + card.Health;
                if (card.tank)
                {
                    cardvalue += 5;
                    cardvalue += card.Health;
                }

                cardvalue += prozis.penman.getValueOfUsefulNeedKeepPriority(card.nameEN);
                cardvalue += 1;

                i = 0;
                foreach (Minion m in this.ownMinions)
                {
                    places[i] = 0;
                    tempval = m.Angr * 2 + m.maxHp;
                    if (m.taunt)
                    {
                        tempval += 6;
                        tempval += m.maxHp;
                    }
                    if (!m.silenced)
                    {
                        tempval += prozis.penman.getValueOfUsefulNeedKeepPriority(m.handcard.card.nameEN);
                        if (m.stealth) tempval += 40;
                    }
                    places[i] = tempval;

                    i++;
                }

                //bigminion if >=10
                tempval = 0;
                for (i = 0; i <= omCount; i++)
                {
                    int prev = cardvalue;
                    int next = cardvalue;
                    if (i >= 1) prev = places[i - 1];
                    if (i < omCount) next = places[i];


                    if (cardvalue >= prev && cardvalue >= next)
                    {
                        tempval = 2 * cardvalue - prev - next;
                        if (tempval > bestvale)
                        {
                            bestplace = i;
                            bestvale = tempval;
                        }
                    }
                    if (cardvalue <= prev && cardvalue <= next)
                    {
                        tempval = -2 * cardvalue + prev + next;
                        if (tempval > bestvale)
                        {
                            bestplace = i;
                            bestvale = tempval;
                        }
                    }
                }

            }

            return bestplace + 1;
        }

        /// <summary>
        /// 获取随从的最佳进化选择，并根据当前情况对随从进行增强或赋予新的特性。
        /// 进化选项：1-+1/+1，2-+3攻击力，3-+3生命值，4-嘲讽，5-圣盾，6-剧毒。
        /// </summary>
        /// <param name="m">需要进化的随从。</param>
        /// <returns>选择的进化效果对应的数字编号。</returns>
        public int getBestAdapt(Minion m)
        {
            // 判断己方英雄是否具有直接斩杀对手的能力
            bool ownLethal = this.ownHeroHasDirectLethal();
            bool needTaunt = false;

            // 如果己方具有斩杀能力，优先考虑为随从赋予嘲讽
            if (ownLethal)
            {
                needTaunt = true;
            }
            else if (m.Ready) // 如果随从已经准备好攻击
            {
                // 判断敌方英雄距离被斩杀还差多少伤害，如果小于等于3，则增加随从的攻击力
                if (guessEnemyHeroLethalMissing() <= 3)
                {
                    this.minionGetBuffed(m, 3, 0);
                    return 2; // 返回+3攻击力的选择
                }
                else if (ownLethal)
                {
                    needTaunt = true;
                }
                else
                {
                    // 如果随从的生命值大于3，则增加生命值
                    if (m.Hp > 3)
                    {
                        this.minionGetBuffed(m, 0, 3);
                        return 3; // 返回+3生命值的选择
                    }
                    else
                    {
                        m.poisonous = true;
                        return 6; // 如果生命值不高，则赋予剧毒效果
                    }
                }
            }
            else
            {
                this.minionGetBuffed(m, 1, 1);
                return 1; // 随从未准备好攻击时，增加+1/+1
            }

            // 如果需要嘲讽效果
            if (needTaunt)
            {
                // 如果随从没有嘲讽，赋予嘲讽效果
                if (!m.taunt)
                {
                    m.taunt = true;
                    if (m.own) this.anzOwnTaunt++;
                    else this.anzEnemyTaunt++;
                    return 4; // 返回嘲讽效果
                }
                // 如果随从已经有嘲讽，但没有圣盾，赋予圣盾效果
                else if (!m.divineshild)
                {
                    m.divineshild = true;
                    return 5; // 返回圣盾效果
                }
                // 如果随从已经有嘲讽和圣盾，但没有剧毒，赋予剧毒效果
                else if (!m.poisonous)
                {
                    m.poisonous = true;
                    return 6; // 返回剧毒效果
                }
                // 否则，增加生命值
                else
                {
                    this.minionGetBuffed(m, 0, 3);
                    return 3; // 返回+3生命值的选择
                }
            }

            return 0; // 返回0表示未进行任何进化
        }

        /// <summary>
        /// 猜测敌方英雄血量丢失
        /// </summary>
        /// <returns></returns>
        public int guessEnemyHeroLethalMissing()
        {
            int lethalMissing = this.enemyHero.armor + this.enemyHero.Hp;
            if (this.anzEnemyTaunt == 0)
            {
                foreach (Minion m in this.ownMinions)
                {
                    if (m.Ready)
                    {
                        lethalMissing -= m.Angr;
                        if (m.windfury && m.numAttacksThisTurn == 0) lethalMissing -= m.Angr;
                    }
                }
            }
            return lethalMissing;
        }

        /// <summary>
        /// 随机伤害
        /// </summary>
        public void guessHeroDamage()
        {
            int ghd = 0;
            int ablilityDmg = 0;
            switch (this.enemyHeroAblility.card.cardIDenum)
            {
                //direct damage直伤
                case CardDB.cardIDEnum.HERO_05bp: ablilityDmg += 2; break;//猎人技能
                case CardDB.cardIDEnum.DS1h_292_H1: ablilityDmg += 2; break;
                case CardDB.cardIDEnum.HERO_05bp2: ablilityDmg += 3; break;
                case CardDB.cardIDEnum.DS1h_292_H1_AT_132: ablilityDmg += 3; break;
                case CardDB.cardIDEnum.NAX15_02: ablilityDmg += 2; break;
                case CardDB.cardIDEnum.NAX15_02H: ablilityDmg += 2; break;
                case CardDB.cardIDEnum.NAX6_02: ablilityDmg += 3; break;
                case CardDB.cardIDEnum.NAX6_02H: ablilityDmg += 3; break;
                case CardDB.cardIDEnum.HERO_08bp: ablilityDmg += 1; break;
                case CardDB.cardIDEnum.CS2_034_H1: ablilityDmg += 1; break;
                case CardDB.cardIDEnum.CS2_034_H2: ablilityDmg += 1; break;
                case CardDB.cardIDEnum.AT_050t: ablilityDmg += 2; break;
                case CardDB.cardIDEnum.HERO_08bp2: ablilityDmg += 2; break;
                case CardDB.cardIDEnum.CS2_034_H1_AT_132: ablilityDmg += 2; break;
                case CardDB.cardIDEnum.CS2_034_H2_AT_132: ablilityDmg += 2; break;
                case CardDB.cardIDEnum.EX1_625t: ablilityDmg += 2; break;
                case CardDB.cardIDEnum.EX1_625t2: ablilityDmg += 3; break;
                case CardDB.cardIDEnum.TU4d_003: ablilityDmg += 1; break;
                case CardDB.cardIDEnum.NAX7_03: ablilityDmg += 3; break;
                case CardDB.cardIDEnum.NAX7_03H: ablilityDmg += 4; break;
                case CardDB.cardIDEnum.ICC_830p: ablilityDmg += 2; break;//牧师dk技能
                case CardDB.cardIDEnum.ICC_831p: ablilityDmg += 3; break;//术士dk 技能
                case CardDB.cardIDEnum.ICC_833h: ablilityDmg += 1; break;//法师 dk技能
                //condition 有条件的
                case CardDB.cardIDEnum.BRMA05_2H: if (this.mana > 0) ablilityDmg += 10; break;
                case CardDB.cardIDEnum.BRMA05_2: if (this.mana > 0) ablilityDmg += 5; break;
                case CardDB.cardIDEnum.BRM_027p: if (this.ownMinions.Count < 1) ablilityDmg += 8; break;
                case CardDB.cardIDEnum.BRM_027pH: if (this.ownMinions.Count < 2) ablilityDmg += 8; break;
                case CardDB.cardIDEnum.TB_MechWar_Boss2_HeroPower: if (this.ownMinions.Count < 2) ablilityDmg += 1; break;
                //equip weapon 装备武器
                case CardDB.cardIDEnum.LOEA09_2: if (this.enemyWeapon.Durability < 1 && !this.enemyHero.frozen) ghd += 2; break;
                case CardDB.cardIDEnum.LOEA09_2H: if (this.enemyWeapon.Durability < 1 && !this.enemyHero.frozen) ghd += 5; break;
                case CardDB.cardIDEnum.HERO_03bp: if (this.enemyWeapon.Durability < 1 && !this.enemyHero.frozen) ghd += 1; break;
                case CardDB.cardIDEnum.CS2_083b_H1: if (this.enemyWeapon.Durability < 1 && !this.enemyHero.frozen) ghd += 1; break;
                case CardDB.cardIDEnum.HERO_03bp2: if (this.enemyWeapon.Durability < 1 && !this.enemyHero.frozen) ghd += 2; break;
                case CardDB.cardIDEnum.HERO_06bp: if (!this.enemyHero.frozen) ghd += 1; break;
                case CardDB.cardIDEnum.HERO_06bp2: if (!this.enemyHero.frozen) ghd += 2; break;
                case CardDB.cardIDEnum.ICC_832p: if (!this.enemyHero.frozen) ghd += 3; break;
            }

            ghd += ablilityDmg;
            foreach (Minion m in this.enemyMinions)
            {
                if (m.frozen) continue;
                switch (m.name)
                {
                    case CardDB.cardNameEN.ancientwatcher: if (!m.silenced) continue; break;
                    case CardDB.cardNameEN.blackknight: if (!m.silenced) continue; break;
                    case CardDB.cardNameEN.whiteknight: if (!m.silenced) continue; break;
                    case CardDB.cardNameEN.humongousrazorleaf: if (!m.silenced) continue; break;
                }
                ghd += m.Angr;//总伤害
                if (m.windfury) ghd += m.Angr;
            }

            if (this.enemyWeapon.Durability > 0 && !this.enemyHero.frozen)
            {
                ghd += this.enemyWeapon.Angr;
                if (this.enemyHero.windfury && this.enemyWeapon.Durability > 1) ghd += this.enemyWeapon.Angr;
            }

            foreach (Minion m in this.ownMinions)
            {
                if (m.taunt) ghd -= m.Hp;
                if (m.taunt && m.divineshild) ghd -= 1;
            }

            int guessingHeroDamage = Math.Max(0, ghd);
            if (this.ownHero.immune) guessingHeroDamage = 0;
            this.guessingHeroHP = this.ownHero.Hp + this.ownHero.armor - guessingHeroDamage;

            bool haveImmune = false;
            if (this.guessingHeroHP < 1 && this.ownSecretsIDList.Count > 0)//场面伤害我死了的时候,有奥秘,计算能挡的伤害
            {
                foreach (CardDB.cardIDEnum secretID in this.ownSecretsIDList)
                {
                    switch (secretID)
                    {//能抗上伤害的奥秘
                        case CardDB.cardIDEnum.EX1_130: //Noble Sacrifice
                            if (this.enemyMinions.Count > 0)
                            {
                                int mAngr = 1000;
                                foreach (Minion m in this.enemyMinions)
                                {
                                    if (!m.frozen && m.Angr < mAngr && m.Angr > 0) mAngr = m.Angr; //take the weakest
                                }
                                if (mAngr != 1000) this.guessingHeroHP += mAngr;
                            }
                            continue;
                        case CardDB.cardIDEnum.EX1_533: //Misdirection误导
                            if (this.enemyMinions.Count > 0)
                            {
                                int mAngr = 1000;
                                foreach (Minion m in this.enemyMinions)
                                {
                                    if (!m.frozen && m.Angr < mAngr && m.Angr > 0) mAngr = m.Angr; //take the weakest
                                }
                                if (mAngr != 1000) this.guessingHeroHP += mAngr;
                            }
                            continue;
                        case CardDB.cardIDEnum.AT_060: //Bear Trap
                            if (this.enemyMinions.Count > 1) this.guessingHeroHP += 3;
                            continue;
                        case CardDB.cardIDEnum.EX1_611: //Freezing Trap
                            if (this.enemyMinions.Count > 0)
                            {
                                int mAngr = 1000;
                                int mCharge = 0;
                                foreach (Minion m in this.enemyMinions)
                                {
                                    if (!m.frozen && m.Angr < mAngr && m.Angr > 0)
                                    {
                                        mAngr = m.Angr; //take the weakest
                                        mCharge = m.charge;
                                    }
                                }
                                if (mAngr < 1000 && mCharge < 1) this.guessingHeroHP += mAngr;
                            }
                            continue;
                        case CardDB.cardIDEnum.EX1_289: //Ice Barrier 寒冰护体
                            this.guessingHeroHP += 8;
                            continue;
                        case CardDB.cardIDEnum.EX1_295: //Ice Block
                            haveImmune = true;
                            break;
                        case CardDB.cardIDEnum.EX1_594: //Vaporize
                            if (this.enemyMinions.Count > 0)
                            {
                                int mAngr = 1000;
                                foreach (Minion m in this.enemyMinions)
                                {
                                    if (!m.frozen && m.Angr < mAngr && m.Angr > 0) mAngr = m.Angr; //take the weakest
                                }
                                if (mAngr != 1000) this.guessingHeroHP += mAngr;
                            }
                            continue;
                        case CardDB.cardIDEnum.CORE_EX1_610: //Explosive Trap
                        case CardDB.cardIDEnum.VAN_EX1_610: //Explosive Trap
                        case CardDB.cardIDEnum.EX1_610: //Explosive Trap
                            if (this.enemyMinions.Count > 0)
                            {
                                int losshd = 0;
                                foreach (Minion m in this.enemyMinions)
                                {
                                    if (m.frozen) continue;
                                    switch (m.name)
                                    {
                                        case CardDB.cardNameEN.ancientwatcher: if (!m.silenced) continue; break;
                                        case CardDB.cardNameEN.blackknight: if (!m.silenced) continue; break;
                                        case CardDB.cardNameEN.whiteknight: if (!m.silenced) continue; break;
                                        case CardDB.cardNameEN.humongousrazorleaf: if (!m.silenced) continue; break;
                                    }
                                    if (m.Hp < 3)
                                    {
                                        losshd += m.Angr;
                                        if (m.windfury) losshd += m.Angr;
                                    }
                                }
                                this.guessingHeroHP += losshd;
                            }
                            continue;
                        //此处可加火焰陷阱
                        case CardDB.cardIDEnum.ULD_239: //Explosive Trap
                            if (this.enemyMinions.Count > 0)
                            {
                                int losshd = 0;
                                int maxAngr = 0;
                                foreach (Minion m in this.enemyMinions)
                                {
                                    if (m.frozen) continue;
                                    switch (m.name)
                                    {
                                        case CardDB.cardNameEN.ancientwatcher: if (!m.silenced) continue; break;
                                        case CardDB.cardNameEN.blackknight: if (!m.silenced) continue; break;
                                        case CardDB.cardNameEN.whiteknight: if (!m.silenced) continue; break;
                                        case CardDB.cardNameEN.humongousrazorleaf: if (!m.silenced) continue; break;
                                    }
                                    if (m.Hp < 4)
                                    {
                                        losshd += m.Angr;
                                        if (maxAngr < m.Angr) maxAngr = m.Angr;
                                        if (m.windfury) losshd += m.Angr;
                                    }
                                }
                                this.guessingHeroHP += losshd - maxAngr;
                            }
                            continue;
                    }
                }
                if (haveImmune && this.guessingHeroHP < 2) this.guessingHeroHP = 2;
            }
            if (this.ownHero.Hp + this.ownHero.armor <= ablilityDmg && !haveImmune) this.guessingHeroHP = this.ownHero.Hp + this.ownHero.armor - ablilityDmg;
        }

        /// <summary>
        /// 我方被斩杀的可能性
        /// </summary>
        /// <returns></returns>
        public bool ownHeroHasDirectLethal()
        {
            //fastLethalCheck
            if (this.anzOwnTaunt != 0) return false;
            if (this.ownHero.immune) return false;
            int totalEnemyDamage = 0;
            foreach (Minion m in this.enemyMinions)
            {
                if (!m.frozen && !m.cantAttack)
                {
                    switch (m.name)
                    {
                        case CardDB.cardNameEN.icehowl: if (!m.silenced) continue; break;
                    }
                    totalEnemyDamage += m.Angr;
                    if (m.windfury) totalEnemyDamage += m.Angr;
                }
            }

            if (this.enemyAbilityReady)
            {
                switch (this.enemyHeroAblility.card.cardIDenum)
                {
                    //direct damage
                    case CardDB.cardIDEnum.HERO_05bp: totalEnemyDamage += 2; break;
                    case CardDB.cardIDEnum.DS1h_292_H1: totalEnemyDamage += 2; break;
                    case CardDB.cardIDEnum.HERO_05bp2: totalEnemyDamage += 3; break;
                    case CardDB.cardIDEnum.DS1h_292_H1_AT_132: totalEnemyDamage += 3; break;
                    case CardDB.cardIDEnum.NAX15_02: totalEnemyDamage += 2; break;
                    case CardDB.cardIDEnum.NAX15_02H: totalEnemyDamage += 2; break;
                    case CardDB.cardIDEnum.NAX6_02: totalEnemyDamage += 3; break;
                    case CardDB.cardIDEnum.NAX6_02H: totalEnemyDamage += 3; break;
                    case CardDB.cardIDEnum.HERO_08bp: totalEnemyDamage += 1; break;
                    case CardDB.cardIDEnum.CS2_034_H1: totalEnemyDamage += 1; break;
                    case CardDB.cardIDEnum.CS2_034_H2: totalEnemyDamage += 1; break;
                    case CardDB.cardIDEnum.AT_050t: totalEnemyDamage += 2; break;
                    case CardDB.cardIDEnum.HERO_08bp2: totalEnemyDamage += 2; break;
                    case CardDB.cardIDEnum.CS2_034_H1_AT_132: totalEnemyDamage += 2; break;
                    case CardDB.cardIDEnum.CS2_034_H2_AT_132: totalEnemyDamage += 2; break;
                    case CardDB.cardIDEnum.EX1_625t: totalEnemyDamage += 2; break;
                    case CardDB.cardIDEnum.EX1_625t2: totalEnemyDamage += 3; break;
                    case CardDB.cardIDEnum.TU4d_003: totalEnemyDamage += 1; break;
                    case CardDB.cardIDEnum.NAX7_03: totalEnemyDamage += 3; break;
                    case CardDB.cardIDEnum.NAX7_03H: totalEnemyDamage += 4; break;
                    //condition
                    case CardDB.cardIDEnum.BRMA05_2H: if (this.mana > 0) totalEnemyDamage += 10; break;
                    case CardDB.cardIDEnum.BRMA05_2: if (this.mana > 0) totalEnemyDamage += 5; break;
                    case CardDB.cardIDEnum.BRM_027p: if (this.ownMinions.Count < 1) totalEnemyDamage += 8; break;
                    case CardDB.cardIDEnum.BRM_027pH: if (this.ownMinions.Count < 2) totalEnemyDamage += 8; break;
                    case CardDB.cardIDEnum.TB_MechWar_Boss2_HeroPower: if (this.ownMinions.Count < 2) totalEnemyDamage += 1; break;
                    //equip weapon
                    case CardDB.cardIDEnum.LOEA09_2: if (this.enemyWeapon.Durability < 1 && !this.enemyHero.frozen) totalEnemyDamage += 2; break;
                    case CardDB.cardIDEnum.LOEA09_2H: if (this.enemyWeapon.Durability < 1 && !this.enemyHero.frozen) totalEnemyDamage += 5; break;
                    case CardDB.cardIDEnum.HERO_06bp: if (this.enemyWeapon.Durability < 1 && !this.enemyHero.frozen) totalEnemyDamage += 1; break;
                    case CardDB.cardIDEnum.HERO_03bp: if (this.enemyWeapon.Durability < 1 && !this.enemyHero.frozen) totalEnemyDamage += 1; break;
                    case CardDB.cardIDEnum.CS2_083b_H1: if (this.enemyWeapon.Durability < 1 && !this.enemyHero.frozen) totalEnemyDamage += 1; break;
                    case CardDB.cardIDEnum.HERO_03bp2: if (this.enemyWeapon.Durability < 1 && !this.enemyHero.frozen) totalEnemyDamage += 2; break;
                    case CardDB.cardIDEnum.HERO_06bp2: if (this.enemyWeapon.Durability < 1 && !this.enemyHero.frozen) totalEnemyDamage += 2; break;
                }
            }
            if (this.enemyWeapon.Durability > 0 && this.enemyHero.Ready && !this.enemyHero.frozen)
            {
                totalEnemyDamage += this.enemyWeapon.Angr;
                if (this.enemyHero.windfury && this.enemyWeapon.Durability > 1) totalEnemyDamage += this.enemyWeapon.Angr;
            }

            if (totalEnemyDamage < this.ownHero.Hp + this.ownHero.armor) return false;
            if (this.ownSecretsIDList.Count > 0)
            {
                foreach (CardDB.cardIDEnum secretID in this.ownSecretsIDList)
                {
                    switch (secretID)
                    {
                        case CardDB.cardIDEnum.EX1_289: //Ice Barrier 寒冰护体
                            totalEnemyDamage -= 8;
                            continue;
                        case CardDB.cardIDEnum.EX1_295: //Ice Block
                            return false;
                        case CardDB.cardIDEnum.EX1_130: //Noble Sacrifice
                            return false;
                        case CardDB.cardIDEnum.EX1_533: //Misdirection
                            return false;
                        case CardDB.cardIDEnum.EX1_594: //Vaporize
                            return false;
                        case CardDB.cardIDEnum.EX1_611: //Freezing Trap
                            return false;
                        case CardDB.cardIDEnum.EX1_610: //Explosive Trap
                            return false;
                        case CardDB.cardIDEnum.AT_060: //Bear Trap
                            return false;
                        case CardDB.cardIDEnum.EX1_132: //Eye for an Eye
                            if ((this.enemyHero.Hp + this.enemyHero.armor) <= (this.ownHero.Hp + this.ownHero.armor) && !this.enemyHero.immune) return false;
                            continue;
                        case CardDB.cardIDEnum.LOE_021: //Dart Trap
                            if ((this.enemyHero.Hp + this.enemyHero.armor) < 6 && !this.enemyHero.immune) return false;
                            continue;
                    }
                }
            }
            if (totalEnemyDamage < this.ownHero.Hp + this.ownHero.armor) return false;
            return true;
        }

        /// <summary>
        /// 在敌方回合开始时模拟触发我方奥秘
        /// </summary>
        public void simulateTrapsStartEnemyTurn()
        {
            // DONT KILL ENEMY HERO (cause its only guessing)

            List<CardDB.cardIDEnum> tmpSecretsIDList = new List<CardDB.cardIDEnum>();
            List<Minion> temp;
            int pos;

            foreach (CardDB.cardIDEnum secretID in this.ownSecretsIDList)
            {
                switch (secretID)
                {
                    // 火焰结界：如果敌方怪兽属性值总和大于我方，则破坏我方场上所有怪兽，对敌方场上所有怪兽造成 3 点伤害

                    case CardDB.cardIDEnum.EX1_554: //snaketrap

                        pos = this.ownMinions.Count;
                        if (pos == 0) continue;
                        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_554t);//snake
                        callKid(kid, pos, true, false);
                        callKid(kid, pos, true);
                        callKid(kid, pos, true);
                        continue;
                    case CardDB.cardIDEnum.EX1_610: //explosive trap

                        temp = new List<Minion>(this.enemyMinions);
                        int damage = getSpellDamageDamage(2);
                        foreach (Minion m in temp)
                        {
                            minionGetDamageOrHeal(m, damage);
                        }
                        attackEnemyHeroWithoutKill(damage);
                        continue;
                    case CardDB.cardIDEnum.EX1_611: //freezing trap
                        {

                            int count = this.enemyMinions.Count;
                            if (count == 0) continue;
                            Minion mnn = this.enemyMinions[0];
                            for (int i = 1; i < count; i++)
                            {
                                if (this.enemyMinions[i].Angr < mnn.Angr) mnn = this.enemyMinions[i]; //take the weakest
                            }
                            minionReturnToHand(mnn, false, 0);
                            continue;
                        }
                    case CardDB.cardIDEnum.AT_060: //beartrap

                        if (this.enemyMinions.Count == 0 && ((this.enemyWeapon.Angr == 0 && !prozis.penman.HeroPowerEquipWeapon.ContainsKey(this.enemyHeroAblility.card.nameEN)) || this.enemyHero.frozen)) continue;
                        pos = this.ownMinions.Count;
                        callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_125), pos, true, false);
                        continue;
                    case CardDB.cardIDEnum.LOE_021: //Dart Trap

                        minionGetDamageOrHeal(this.enemyHero, getSpellDamageDamage(5), true);
                        continue;
                    case CardDB.cardIDEnum.EX1_533: // misdirection
                        {


                            int count = this.enemyMinions.Count;
                            if (count == 0 && ((this.enemyWeapon.Angr == 0 && !prozis.penman.HeroPowerEquipWeapon.ContainsKey(this.enemyHeroAblility.card.nameEN)) || this.enemyHero.frozen)) continue;
                            Minion mnn = this.enemyMinions[0];
                            for (int i = 1; i < count; i++)
                            {
                                if (this.enemyMinions[i].Angr > mnn.Angr) mnn = this.enemyMinions[i]; //take the strongest
                            }
                            mnn.Angr = 0;
                            //this.evaluatePenality -= this.enemyMinions.Count;// Todo: 不在这里引入打分 the more the enemy minions has on board, the more the posibility to destroy something other :D
                            continue;
                        }
                    case CardDB.cardIDEnum.KAR_004: //cattrick

                        pos = this.ownMinions.Count;
                        callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_017), pos, true, false);
                        continue;


                    case CardDB.cardIDEnum.EX1_287: //counterspell

                        wehaveCounterspell++;
                        continue;
                    case CardDB.cardIDEnum.EX1_289: //ice barrier  寒冰护体

                        if (this.enemyMinions.Count == 0 && ((this.enemyWeapon.Angr == 0 && !prozis.penman.HeroPowerEquipWeapon.ContainsKey(this.enemyHeroAblility.card.nameEN)) || this.enemyHero.frozen)) continue;
                        this.ownHero.armor += 8;
                        continue;
                    case CardDB.cardIDEnum.EX1_295: //ice block

                        guessHeroDamage();
                        if (guessingHeroHP < 11) this.ownHero.immune = true;
                        continue;
                    case CardDB.cardIDEnum.EX1_294: //mirror entity

                        if (this.ownMinions.Count < 7)
                        {
                            pos = this.ownMinions.Count - 1;
                            callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TU4f_007), pos, true, false);
                        }
                        else goto default;
                        continue;
                    case CardDB.cardIDEnum.AT_002: //effigy

                        if (this.ownMinions.Count == 0) continue;
                        pos = this.ownMinions.Count - 1;
                        callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TU4f_007), pos, true);
                        continue;
                    case CardDB.cardIDEnum.tt_010: //spellbender

                        //this.evaluatePenality -= 4;
                        continue;
                    case CardDB.cardIDEnum.EX1_594: // vaporize
                        {

                            int count = this.enemyMinions.Count;
                            if (count == 0) continue;
                            Minion mnn = this.enemyMinions[0];
                            for (int i = 1; i < count; i++)
                            {
                                if (this.enemyMinions[i].Angr < mnn.Angr) mnn = this.enemyMinions[i]; //take the weakest
                            }
                            minionGetDestroyed(mnn);
                            continue;
                        }
                    case CardDB.cardIDEnum.FP1_018: // duplicate
                        {

                            int count = this.ownMinions.Count;
                            if (count == 0) continue;
                            Minion mnn = this.ownMinions[0];
                            for (int i = 1; i < count; i++)
                            {
                                if (this.ownMinions[i].Angr < mnn.Angr) mnn = this.ownMinions[i]; //take the weakest
                            }
                            drawACard(mnn.name, true);
                            drawACard(mnn.name, true);
                            continue;
                        }




                    case CardDB.cardIDEnum.EX1_132: // eye for an eye
                        {

                            // todo for mage and hunter
                            if (this.enemyHero.frozen && this.enemyMinions.Count == 0) continue;
                            int dmg = 0;
                            int dmgW = 0;

                            int count = this.enemyMinions.Count;
                            if (count != 0)
                            {
                                Minion mnn = this.enemyMinions[0];
                                for (int i = 1; i < count; i++)
                                {
                                    if (this.enemyMinions[i].Angr < mnn.Angr) mnn = this.enemyMinions[i]; //take the weakest
                                }
                                dmg = mnn.Angr;
                            }
                            if (this.enemyWeapon.Angr != 0) dmgW = this.enemyWeapon.Angr;
                            else if (prozis.penman.HeroPowerEquipWeapon.ContainsKey(this.enemyHeroAblility.card.nameEN)) dmgW = prozis.penman.HeroPowerEquipWeapon[this.enemyHeroAblility.card.nameEN];
                            if (dmgW != 0)
                            {
                                if (dmg != 0)
                                {
                                    if (dmgW < dmg) dmg = dmgW;
                                }
                                else dmg = dmgW;
                            }
                            dmg = getSpellDamageDamage(dmg);
                            if (dmg != 0) attackEnemyHeroWithoutKill(dmg);
                            continue;
                        }
                    case CardDB.cardIDEnum.EX1_130: // noble sacrifice

                        if (this.enemyMinions.Count == 0 && ((this.enemyWeapon.Angr == 0 && !prozis.penman.HeroPowerEquipWeapon.ContainsKey(this.enemyHeroAblility.card.nameEN)) || this.enemyHero.frozen)) continue;
                        if (this.ownMinions.Count == 7) continue;
                        pos = this.ownMinions.Count - 1;
                        callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_097), pos, true, false);
                        continue;
                    case CardDB.cardIDEnum.EX1_136: // redemption


                        if (this.ownMinions.Count == 0) continue;
                        temp = new List<Minion>(this.ownMinions);
                        temp.Sort((a, b) => a.Hp.CompareTo(b.Hp));
                        foreach (Minion m in temp)
                        {
                            if (m.divineshild) continue;
                            m.divineshild = true;
                            break;
                        }
                        continue;
                    case CardDB.cardIDEnum.FP1_020: // avenge


                        if (this.ownMinions.Count < 2 || (this.ownMinions.Count == 1 && !this.ownSecretsIDList.Contains(CardDB.cardIDEnum.EX1_130))) continue;
                        temp = new List<Minion>(this.ownMinions);
                        temp.Sort((a, b) => a.Hp.CompareTo(b.Hp));
                        minionGetBuffed(temp[0], 3, 2);
                        continue;
                    default:
                        tmpSecretsIDList.Add(secretID);
                        continue;
                }
            }
            this.ownSecretsIDList.Clear();
            this.ownSecretsIDList.AddRange(tmpSecretsIDList);

            this.doDmgTriggers();
        }

        /// <summary>
        /// 模拟敌方回合结束时触发己方的陷阱（奥秘）效果，并处理相应的随从和英雄状态。
        /// </summary>
        public void simulateTrapsEndEnemyTurn()
        {
            // 不杀死敌方英雄（因为这是一个推测性的模拟）
            List<CardDB.cardIDEnum> tmpSecretsIDList = new List<CardDB.cardIDEnum>(); // 用于存储未触发的奥秘
            List<Minion> temp;

            bool activate = false;
            foreach (CardDB.cardIDEnum secretID in this.ownSecretsIDList)
            {
                switch (secretID)
                {
                    case CardDB.cardIDEnum.EX1_609: // 狙击
                        activate = false;
                        if (this.enemyMinions.Count > 0)
                        {
                            temp = new List<Minion>(this.enemyMinions);
                            int damage = getSpellDamageDamage(4); // 狙击造成4点伤害
                            foreach (Minion m in temp)
                            {
                                if (m.playedThisTurn) // 如果随从在本回合中被召唤
                                {
                                    minionGetDamageOrHeal(m, damage); // 对该随从造成伤害
                                    activate = true;
                                    break;
                                }
                            }
                        }
                        if (!activate) tmpSecretsIDList.Add(secretID); // 如果未触发，将奥秘重新加入列表
                        continue;

                    case CardDB.cardIDEnum.EX1_379: // 忏悔
                        activate = false;
                        if (this.enemyMinions.Count > 0)
                        {
                            temp = new List<Minion>(this.enemyMinions);
                            foreach (Minion m in temp)
                            {
                                if (m.playedThisTurn) // 如果随从在本回合中被召唤
                                {
                                    m.Hp = 1; // 将该随从的生命值设为1
                                    m.maxHp = 1; // 将该随从的最大生命值设为1
                                    activate = true;
                                    break;
                                }
                            }
                        }
                        if (!activate) tmpSecretsIDList.Add(secretID); // 如果未触发，将奥秘重新加入列表
                        continue;

                    case CardDB.cardIDEnum.LOE_027: // 圣殿执行者的考验
                        activate = false;
                        if (this.enemyMinions.Count > 3) // 如果敌方随从数量超过3个
                        {
                            temp = new List<Minion>(this.enemyMinions);
                            foreach (Minion m in temp)
                            {
                                if (m.playedThisTurn) // 如果随从在本回合中被召唤
                                {
                                    this.minionGetDestroyed(m); // 摧毁该随从
                                    activate = true;
                                    break;
                                }
                            }
                        }
                        if (!activate) tmpSecretsIDList.Add(secretID); // 如果未触发，将奥秘重新加入列表
                        continue;

                    case CardDB.cardIDEnum.AT_073: // 竞争精神
                        if (this.enemyMinions.Count == 0) continue; // 如果没有敌方随从，则跳过
                        foreach (Minion m in this.ownMinions)
                        {
                            minionGetBuffed(m, 1, 1); // 增加己方所有随从的攻击力和生命值
                        }
                        continue;

                    default:
                        tmpSecretsIDList.Add(secretID); // 其他未触发的奥秘重新加入列表
                        continue;
                }
            }

            this.ownSecretsIDList.Clear(); // 清空当前的奥秘列表
            this.ownSecretsIDList.AddRange(tmpSecretsIDList); // 重新添加未触发的奥秘

            this.doDmgTriggers(); // 触发伤害相关的效果
        }

        /// <summary>
        /// 处理回合结束的逻辑，包括更新回合计数、元素计数、触发回合结束事件等。
        /// </summary>
        public void endTurn()
        {
            // 如果是第一回合，记录回合结束时的法力值
            if (this.turnCounter == 0)
            {
                this.manaTurnEnd = this.mana;  // 记录回合结束时的法力值
            }

            this.turnCounter++;  // 增加回合计数
            this.pIdHistory.Add(0);  // 将回合历史记录中添加一个0（可能用于记录玩家行动）

            if (isOwnTurn)  // 如果是己方的回合结束
            {
                this.value = int.MinValue;  // 将当前的评分值重置为最小值

                // 检查是否破坏了连击，并增加相应的惩罚值
                this.evaluatePenality += ComboBreaker.Instance.checkIfComboWasPlayed(this);

                if (this.complete) return;  // 如果回合已完成，直接返回

                // 更新上回合和本回合使用的元素随从数量
                this.anzOwnElementalsLastTurn = this.anzOwnElementalsThisTurn;  // 将本回合使用的元素数量赋值给上回合
                this.anzOwnElementalsThisTurn = 0;  // 重置本回合使用的元素数量
            }
            else  // 如果是敌方的回合结束
            {
                simulateTrapsEndEnemyTurn();  // 模拟敌方回合结束时的陷阱触发
            }

            this.triggerEndTurn(this.isOwnTurn);  // 触发回合结束时的相关事件
            this.isOwnTurn = !this.isOwnTurn;  // 切换回合控制权

            // 移除手牌中所有快枪状态
            RemoveQuickDrawStatus(this.owncards);
            RemoveQuickDrawStatus(this.enemyHand);

            //重置本回合对敌方英雄造成的伤害
            this.damageDealtToEnemyHeroThisTurn = 0;
            //重置本回合下一张元素随从牌的法力值消耗减少量
            this.thisTurnNextElementalReduction = 0;
            //重置连续使用元素牌的回合数
            if (!this.playedElementalThisTurn) Hrtprozis.Instance.ownConsecutiveElementalTurns = 0;
            //更新上个回合玩家使用的元素牌数量
            Hrtprozis.Instance.ownElementalsPlayedLastTurn = this.ownElementalsPlayedThisTurn;
        }

        /// <summary>
        /// 处理回合开始的逻辑，包括触发回合开始事件、模拟敌方回合开始的陷阱触发等。
        /// </summary>
        public void startTurn()
        {
            // 触发回合开始时的相关事件
            this.triggerStartTurn(this.isOwnTurn);

            if (!this.isOwnTurn) // 如果是敌方的回合开始
            {
                //敌方战士任务
                this.enemyQuest.trigger_startTurn();
                simulateTrapsStartEnemyTurn(); // 模拟敌方回合开始时触发的陷阱（奥秘）
                guessHeroDamage(); // 估算敌方英雄可能造成的伤害
            }
            else // 如果是己方的回合开始
            {
                //己方战士任务
                this.ownQuest.trigger_startTurn();
                this.enemyHeroPowerCostLessOnce = 0; // 重置敌方英雄技能一次性费用减少的标记
            }
        }

        /// <summary>
        /// 解锁法力水晶，将锁定的法力水晶转化为可用的法力水晶，并重置过载状态。
        /// </summary>
        public void unlockMana()
        {
            this.ueberladung = 0; // 重置过载值，表示本回合没有过载的法力水晶
            this.mana += lockedMana; // 将锁定的法力水晶加回到当前的法力值中
            this.lockedMana = 0; // 重置锁定的法力水晶数为0
        }

        /// <summary>
        /// 计算英雄技能造成的最终伤害值，考虑额外伤害和效果加成。
        /// </summary>
        /// <param name="dmg">基础伤害值。</param>
        /// <returns>最终计算后的英雄技能伤害值。</returns>
        public int getHeroPowerDamage(int dmg)
        {
            // 加上由于其他效果或增益而获得的额外伤害
            dmg += this.ownHeroPowerExtraDamage;

            // 如果存在双倍治疗效果（如奥金尼灵魂祭司），伤害值乘以双倍效果的数量
            if (this.doublepriest >= 1)
            {
                dmg *= (2 * this.doublepriest);
            }

            // 返回最终计算的伤害值
            return dmg;
        }

        /// <summary>
        /// 计算敌方英雄技能造成的最终伤害值，考虑额外伤害和效果加成。
        /// </summary>
        /// <param name="dmg">基础伤害值。</param>
        /// <returns>最终计算后的敌方英雄技能伤害值。</returns>
        public int getEnemyHeroPowerDamage(int dmg)
        {
            // 加上由于敌方增益效果或其他因素导致的额外伤害
            dmg += this.enemyHeroPowerExtraDamage;

            // 如果敌方存在双倍治疗效果（如奥金尼灵魂祭司），伤害值乘以双倍效果的数量
            if (this.enemydoublepriest >= 1)
            {
                dmg *= (2 * this.enemydoublepriest);
            }

            // 返回最终计算的伤害值
            return dmg;
        }

        /// <summary>
        /// 计算施法造成的最终伤害值，考虑法术伤害加成和效果倍增。
        /// </summary>
        /// <param name="dmg">基础伤害值。</param>
        /// <returns>最终计算后的法术伤害值。</returns>
        public int getSpellDamageDamage(int dmg)
        {
            int retval = dmg;  // 初始化返回值为基础伤害值

            // 加上法术伤害增益（如法术伤害+1效果）
            retval += this.spellpower;

            // 如果存在双倍治疗效果（如奥金尼灵魂祭司），伤害值乘以双倍效果的数量
            if (this.doublepriest >= 1)
            {
                retval *= (2 * this.doublepriest);
            }

            // 返回最终计算的法术伤害值
            return retval;
        }

        /// <summary>
        /// 计算法术治疗效果的最终数值，考虑到特殊效果如奥金尼灵魂祭司和阴影之握等。
        /// </summary>
        /// <param name="heal">基础治疗量。</param>
        /// <returns>最终计算后的治疗量或伤害量。</returns>
        public int getSpellHeal(int heal)
        {
            int retval = heal;  // 初始化返回值为基础治疗量

            // 检查是否有奥金尼灵魂祭司或阴影之握效果，这些效果会将治疗转化为伤害
            if (this.anzOwnAuchenaiSoulpriest > 0 || this.embracetheshadow > 0)
            {
                retval *= -1;  // 将治疗量转为负值，表示伤害
                retval -= this.spellpower;  // 减去法术伤害增益，使得转化后的伤害更高
            }

            // 如果存在双倍治疗效果（如双倍治疗牧师），对治疗量或伤害量乘以双倍效果的数量
            if (this.doublepriest >= 1)
            {
                retval *= (2 * this.doublepriest);
            }

            // 返回最终计算的治疗量或伤害量
            return retval;
        }

        /// <summary>
        /// 处理法术的吸血效果，根据法术治疗量为英雄恢复生命值或造成伤害。
        /// </summary>
        /// <param name="heal">法术治疗量。</param>
        /// <param name="own">是否是己方英雄（true 表示己方，false 表示敌方）。</param>
        public void applySpellLifesteal(int heal, bool own)
        {
            // 判断是否应将治疗转化为伤害
            bool minus = own ?
                (this.anzOwnAuchenaiSoulpriest > 0 || this.embracetheshadow > 0) :
                (this.anzEnemyAuchenaiSoulpriest > 0);

            // 计算吸血效果并应用于对应的英雄
            this.minionGetDamageOrHeal(own ? ownHero : enemyHero, -heal * (minus ? -1 : 1));
        }

        /// <summary>
        /// 计算随从治疗量，如果存在奥金尼灵魂祭司或阴影之握效果，将治疗转化为伤害。
        /// </summary>
        /// <param name="heal">基础治疗量。</param>
        /// <returns>最终的治疗量或伤害量。</returns>
        public int getMinionHeal(int heal)
        {
            // 如果存在奥金尼灵魂祭司或阴影之握效果，将治疗转化为伤害（即返回负的治疗量）
            return (this.anzOwnAuchenaiSoulpriest > 0 || this.embracetheshadow > 0) ? -heal : heal;
        }

        /// <summary>
        /// 计算敌方法术造成的最终伤害值，考虑法术伤害加成和效果倍增。
        /// </summary>
        /// <param name="dmg">基础伤害值。</param>
        /// <returns>最终计算后的敌方法术伤害值。</returns>
        public int getEnemySpellDamageDamage(int dmg)
        {
            int retval = dmg;  // 初始化返回值为基础伤害值

            // 加上敌方的法术伤害增益（如法术伤害+1效果）
            retval += this.enemyspellpower;

            // 如果敌方存在双倍治疗效果（如奥金尼灵魂祭司），伤害值乘以双倍效果的数量
            if (this.enemydoublepriest >= 1)
            {
                retval *= (2 * this.enemydoublepriest);
            }

            // 返回最终计算的法术伤害值
            return retval;
        }

        /// <summary>
        /// 计算敌方法术的治疗效果，根据敌方的奥金尼灵魂祭司和法术伤害加成决定是否将治疗转化为伤害。
        /// </summary>
        /// <param name="heal">基础治疗量。</param>
        /// <returns>最终计算后的治疗量或伤害量。</returns>
        public int getEnemySpellHeal(int heal)
        {
            int retval = heal;  // 初始化返回值为基础治疗量

            // 如果敌方有奥金尼灵魂祭司存在，将治疗转化为伤害，并且减去法术伤害加成
            if (this.anzEnemyAuchenaiSoulpriest >= 1)
            {
                retval *= -1;  // 将治疗转化为伤害
                retval -= this.enemyspellpower;  // 减去敌方的法术伤害加成，使得转化后的伤害更高
            }

            // 如果己方存在双倍治疗效果，对治疗量或伤害量进行倍增
            if (this.doublepriest >= 1)
            {
                retval *= (2 * this.doublepriest);
            }

            // 返回最终计算的治疗量或伤害量
            return retval;
        }

        /// <summary>
        /// 计算敌方随从的治疗效果，如果敌方有奥金尼灵魂祭司存在，将治疗转化为伤害。
        /// </summary>
        /// <param name="heal">基础治疗量。</param>
        /// <returns>最终的治疗量或伤害量。</returns>
        public int getEnemyMinionHeal(int heal)
        {
            // 如果敌方有奥金尼灵魂祭司存在，将治疗转化为伤害（即返回负的治疗量）
            return (this.anzEnemyAuchenaiSoulpriest >= 1) ? -heal : heal;
        }

        /// <summary>
        /// 执行一个操作，并在此过程中更新场面的evaluatePenality值。
        /// </summary>
        /// <param name="aa">要执行的操作。</param>
        public void doAction(Action aa)
        {
            // 查找目标随从或英雄
            Minion trgt = FindMinionByEntityId(aa.target);
            // 查找执行操作的随从或英雄
            Minion o = FindMinionByEntityId(aa.own);
            // 查找要操作的手牌
            Handmanager.Handcard ha = FindHandCard(aa);

            // 创建并执行操作
            Action a = new Action(aa.actionType, ha, o, aa.place, trgt, aa.penalty, aa.druidchoice);

            // 如果是己方回合，记录操作
            if (this.isOwnTurn)
            {
                this.playactions.Add(a);
            }

            // 根据不同的动作类型执行相应的操作逻辑
            switch (a.actionType)
            {
                case actionEnum.attackWithMinion:
                    HandleMinionAttack(a); // 处理随从攻击
                    break;
                case actionEnum.attackWithHero:
                    attackWithWeapon(a.own, a.target, a.penalty); // 处理英雄攻击
                    break;
                case actionEnum.playcard:
                    if (this.isOwnTurn)
                    {
                        PlayACard(a.card, a.target, a.place, a.druidchoice, a.penalty); // 打出一张卡牌
                        // HandleTamsinRoameEffect(a); // 处2理塔姆辛·罗姆的效果
                        HandlePatchesSummon(a); // 处理帕奇斯召唤
                        HandleQuestCompletion(); // 处理任务完成
                    }
                    break;
                case actionEnum.useHeroPower:
                    PlayHeroPower(a.target, a.penalty, this.isOwnTurn, a.druidchoice); // 使用英雄技能
                    break;
                case actionEnum.trade:
                    HandleTrade(a); // 处理交易操作
                    break;
                case actionEnum.useLocation:
                    // 记录敌方英雄当前的生命值
                    int enemyHeroHpBefore = this.enemyHero.Hp;
                    if (a.target != null)
                    {
                        Minion targetMinon = FindMinionByEntityId(new Minion { entitiyID = a.target.entitiyID });
                        // 使用地标
                        useLocation(a.own, targetMinon);
                    }
                    else
                    {
                        // 使用地标
                        useLocation(a.own, a.target);
                    }
                    // 计算英雄技能执行后敌方英雄的生命值差
                    int damageDealt = enemyHeroHpBefore - this.enemyHero.Hp;
                    if (damageDealt > 0)
                    {
                        this.damageDealtToEnemyHeroThisTurn += damageDealt;
                    }
                    break;
                case actionEnum.useTitanAbility:
                    // 记录敌方英雄当前的生命值
                    enemyHeroHpBefore = this.enemyHero.Hp;
                    if (a.target != null)
                    {
                        Minion targetMinon = FindMinionByEntityId(new Minion { entitiyID = a.target.entitiyID });
                        // 使用泰坦技能
                        useTitanAbility(a.own, a.titanAbilityNO, targetMinon);
                    }
                    else
                    {
                        // 使用泰坦技能
                        useTitanAbility(a.own, a.titanAbilityNO, a.target);
                    }
                    // 计算英雄技能执行后敌方英雄的生命值差
                    damageDealt = enemyHeroHpBefore - this.enemyHero.Hp;
                    if (damageDealt > 0)
                    {
                        this.damageDealtToEnemyHeroThisTurn += damageDealt;
                    }
                    break;
                case actionEnum.forge:
                    HandleForge(a); // 处理锻造操作
                    break;
            }

            // 更新当前回合的操作计数
            if (this.isOwnTurn)
            {
                this.optionsPlayedThisTurn++;
            }
            else
            {
                this.enemyOptionsDoneThisTurn++;
            }
        }

        /// <summary>
        /// 根据实体ID查找随从或英雄。
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public Minion FindMinionByEntityId(Minion target)
        {
            if (target == null) return null;

            if (target.entitiyID == this.ownHero.entitiyID) return this.ownHero;
            if (target.entitiyID == this.enemyHero.entitiyID) return this.enemyHero;

            return this.ownMinions.Concat(this.enemyMinions).FirstOrDefault(m => m.entitiyID == target.entitiyID);
        }

        /// <summary>
        /// 查找操作中涉及的手牌。
        /// </summary>
        private Handmanager.Handcard FindHandCard(Action aa)
        {
            if (aa.card == null) return null;

            if (aa.actionType == actionEnum.useHeroPower)
            {
                return this.isOwnTurn ? this.ownHeroAblility : this.enemyHeroAblility;
            }

            return this.owncards.FirstOrDefault(hh => hh.entity == aa.card.entity);
        }

        /// <summary>
        /// 处理随从攻击逻辑。
        /// </summary>
        private void HandleMinionAttack(Action a)
        {
            this.evaluatePenality += a.penalty;
            Minion target = a.target;

            int newTarget = this.secretTrigger_CharIsAttacked(a.own, target);
            if (newTarget >= 1)
            {
                target = FindMinionByEntityId(new Minion { entitiyID = newTarget });
            }

            if (a.own != null && a.own.Hp >= 1)
            {
                minionAttacksMinion(a.own, target);
            }
        }

        /// <summary>
        /// 处理塔姆辛·罗姆的特效。
        /// </summary>
        private void HandleTamsinRoameEffect(Action a)
        {
            if (this.anzTamsinroame > 0 && a.card.card.SpellSchool == CardDB.SpellSchool.SHADOW && a.card.card.getManaCost(this, a.card.getManaCost(this)) > 0)
            {
                for (int i = 0; i < this.anzTamsinroame; i++)
                {
                    this.drawACard(a.card.card.cardIDenum, true, true);
                    this.owncards[this.owncards.Count - 1].manacost = 0;
                    this.evaluatePenality -= 10;
                }
            }
        }

        /// <summary>
        /// 处理帕奇斯的召唤逻辑。
        /// </summary>
        private void HandlePatchesSummon(Action a)
        {
            if (patchesInDeck && (a.card.card.race == CardDB.Race.PIRATE || a.card.card.race == CardDB.Race.ALL))
            {
                if (this.ownMinions.Any(m => m.handcard.card.nameCN == CardDB.cardNameCN.海盗帕奇斯) ||
                    this.owncards.Any(hc => hc.card.nameCN == CardDB.cardNameCN.海盗帕奇斯))
                {
                    this.patchesInDeck = false;
                }

                if (this.patchesInDeck)
                {
                    var patchCard = this.prozis.turnDeck.ToArray().FirstOrDefault(kvp => kvp.Key == CardDB.cardIDEnum.CFM_637);
                    if (!patchCard.Equals(default(KeyValuePair<CardDB.cardIDEnum, int>)))
                    {
                        this.callKid(CardDB.Instance.getCardDataFromID(patchCard.Key), this.ownMinions.Count, true);
                        if (this.deckAngrBuff > 0)
                        {
                            this.minionGetBuffed(this.ownMinions.Last(), this.deckAngrBuff, this.deckHpBuff);
                        }
                    }
                    this.patchesInDeck = false;
                }
            }
        }

        /// <summary>
        /// 处理任务完成后的奖励发放。
        /// </summary>
        private void HandleQuestCompletion()
        {
            if (ownQuest.questProgress == ownQuest.maxProgress && ownQuest.Id != CardDB.cardIDEnum.None)
            {
                this.drawACard(ownQuest.Reward(), true);
                ownQuest.Reset();
            }
        }

        /// <summary>
        /// 处理卡牌交易操作。
        /// </summary>
        private void HandleTrade(Action a)
        {
            this.mana -= a.card.card.TradeCost;
            this.drawACard(CardDB.cardIDEnum.None, true);
            removeCard(a.card);

            if (this.prozis.turnDeck.ContainsKey(a.card.card.cardIDenum))
            {
                this.prozis.turnDeck[a.card.card.cardIDenum]++;
            }
            else
            {
                this.prozis.turnDeck.Add(a.card.card.cardIDenum, 1);
            }
        }

        /// <summary>
        /// 处理卡牌锻造操作
        /// </summary>
        /// <param name="a"></param>
        private void HandleForge(Action a)
        {
            this.mana -= a.card.card.ForgeCost;
            a.card.card = CardDB.Instance.getCardDataFromID(CardDB.Instance.cardIdstringToEnum(a.card.card.cardIDenum + "t"));
            a.card.card.Forged = true;
        }

        /// <summary>
        /// 处理随从之间的攻击逻辑，包括攻击前后触发的效果和伤害计算。
        /// </summary>
        /// <param name="attacker">攻击方的随从或英雄。</param>
        /// <param name="defender">防守方的随从或英雄。</param>
        /// <param name="dontcount">是否不计入攻击次数，默认值为 false。</param>
        public void minionAttacksMinion(Minion attacker, Minion defender, bool dontcount = false)
        {
            // 如果攻击者或防御者已死亡，或攻击者/防御者无法成为攻击目标，则返回
            if (attacker.Hp <= 0 || attacker.untouchable || defender.untouchable) return;

            int oldHp = defender.Hp;

            // 处理英雄攻击的特殊情况
            if (attacker.isHero)
            {
                HandleHeroAttack(attacker, defender, oldHp);
                return;
            }

            // 处理随从的攻击次数和状态
            if (!dontcount)
            {
                attacker.numAttacksThisTurn++;
                attacker.stealth = false;
                if ((attacker.windfury && attacker.numAttacksThisTurn == 2) || !attacker.windfury)
                {
                    attacker.Ready = false;
                }
            }

            // 日志记录
            if (logging) Helpfunctions.Instance.logg(".attack with " + attacker.name + " A " + attacker.Angr + " H " + attacker.Hp);

            int attackerAngr = attacker.Angr;
            int defAngr = defender.Angr;

            // 触发攻击前的事件
            this.triggerAMinionIsGoingToAttack(attacker, defender);

            int dmg1 = AdjustDamageForWeapon(attacker, attacker.Angr);

            // 防御者受到伤害
            bool defenderHasDivineshild = defender.divineshild; // 攻击前，防御者是否具有圣盾
            oldHp = defender.Hp;
            defender.getDamageOrHeal(dmg1, this, true, false);
            bool defenderGotDmg = oldHp > defender.Hp;

            // 更新 damageDealtToEnemyHeroThisTurn 字段
            if (defender.isHero && defenderGotDmg)
            {
                this.damageDealtToEnemyHeroThisTurn += (oldHp - defender.Hp); // 记录本次攻击对敌方英雄造成的伤害
            }

            if (defenderGotDmg)
            {
                HandleDefenderDamageEffects(attacker, defender, oldHp, defenderHasDivineshild);
            }

            if (defender.isHero)
            {
                doDmgTriggers();
                return;
            }

            HandleOverkillAndHonorableKill(attacker, defender, oldHp, attackerAngr, defenderHasDivineshild);

            // 攻击者受到伤害
            bool attackerGotDmg = false;
            if (!dontcount)
            {
                oldHp = attacker.Hp;
                attacker.getDamageOrHeal(defAngr, this, true, false);
                attackerGotDmg = oldHp > attacker.Hp;
                if (attackerGotDmg)
                {
                    HandleAttackerDamageEffects(attacker, defender, oldHp);
                }
            }

            // 触发剧毒效果
            if (defenderGotDmg && attacker.poisonous && !defender.isHero)
            {
                minionGetDestroyed(defender);
            }

            if (attackerGotDmg && defender.poisonous && !attacker.isHero)
            {
                minionGetDestroyed(attacker);
            }

            HandlePostAttackEffects(attacker, defender, dontcount);

            this.doDmgTriggers();
        }

        /// <summary>
        /// 处理英雄攻击的逻辑，包括攻击力调整和特殊效果触发。
        /// </summary>
        private void HandleHeroAttack(Minion attacker, Minion defender, int oldHp)
        {
            //英雄攻击时方法
            this.ownWeapon.card.sim_card.onHeroattack(this, this.ownHero, defender);
            //当英雄攻击时,随从触发效果
            foreach (Minion m in this.ownMinions.ToArray())
            {
                if (!m.silenced)
                {
                    m.handcard.card.sim_card.onHeroattack(this, m, defender, this.ownHero);
                }
            }
            int dmg = AdjustDamageForWeapon(attacker, attacker.Angr);
            defender.getDamageOrHeal(dmg, this, true, false);

            // 如果防御者是敌方英雄，更新 damageDealtToEnemyHeroThisTurn 字段
            if (defender.isHero)
            {
                this.damageDealtToEnemyHeroThisTurn += (oldHp - defender.Hp); // 记录本次攻击对敌方英雄造成的伤害
            }

            HandleWeaponSpecialEffects(attacker, defender, oldHp);

            // 触发英雄攻击后的事件
            // if (this.ownWeapon != null && this.ownWeapon.card.sim_card != null)
            if (this.ownWeapon != null)
            {
                List<miniEnch> miniEnchs = this.ownWeapon.enchants;
                System.Action combinedAction = null;
                if (miniEnchs.Count > 0)
                {
                    foreach (miniEnch item in miniEnchs)
                    {
                        System.Action additionalAction = null;

                        if (item.CARDID == CardDB.cardIDEnum.TTN_092t1) // 守护秩序
                        {
                            additionalAction = () =>
                            {
                                // 守护秩序效果：在你的英雄攻击后，抽一张牌
                                this.drawACard(CardDB.cardIDEnum.None, true);
                            };
                        }
                        else if (item.CARDID == CardDB.cardIDEnum.TTN_092t2) // 统帅风范
                        {
                            additionalAction = () =>
                            {
                                // 统帅风范效果：在你的英雄攻击后，召唤一个3/3并具有嘲讽的执行者
                                this.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_092e2t), 0, ownHero.own);
                            };
                        }
                        else if (item.CARDID == CardDB.cardIDEnum.TTN_092t3) // 迅疾挥剑
                        {
                            additionalAction = () =>
                            {
                                // 迅疾挥剑效果：英雄在攻击时免疫
                                this.ownHero.immuneWhileAttacking = true;
                            };
                        }

                        // 将每个附魔的效果追加到 combinedAction 中
                        if (additionalAction != null)
                        {
                            if (combinedAction == null)
                            {
                                combinedAction = additionalAction;
                            }
                            else
                            {
                                combinedAction += additionalAction;
                            }
                        }
                    }
                }
                // 调用 ExecuteHeroAttackWithAction 方法，传递组合后的附魔效果
                this.ownWeapon.card.sim_card.ExecuteHeroAttackWithAction(this, this.ownHero, defender, combinedAction);
                //英雄攻击后方法
                this.ownWeapon.card.sim_card.afterHeroattack(this, this.ownHero, defender);
            }
            //当英雄攻击后,随从触发效果
            foreach (Minion m in this.ownMinions.ToArray())
            {
                if (!m.silenced)
                {
                    m.handcard.card.sim_card.afterHeroattack(this, m, defender, this.ownHero);
                }
            }

            // 处理英雄攻击后“小型法术欧珀石”的升级逻辑
            /* foreach (Handmanager.Handcard hc in this.owncards)
            {
                if (hc.card.nameEN == CardDB.cardNameEN.lesseropalspellstone)
                {
                    hc.SCRIPT_DATA_NUM_1 += 1; // 累积攻击次数
                    if (hc.SCRIPT_DATA_NUM_1 >= 2)
                    {
                        hc.SCRIPT_DATA_NUM_1 = 0; // 重置计数
                        hc.card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_645t); // 升级到法术欧珀石
                    }
                }
                else if (hc.card.nameEN == CardDB.cardNameEN.opalspellstone)
                {
                    hc.SCRIPT_DATA_NUM_1 += 1; // 累积攻击次数
                    if (hc.SCRIPT_DATA_NUM_1 >= 2)
                    {
                        hc.SCRIPT_DATA_NUM_1 = 0; // 重置计数
                        hc.card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_645t1); // 升级到大型法术欧珀石
                    }
                }
            } */

            doDmgTriggers();
        }

        /// <summary>
        /// 根据武器调整伤害值，处理武器的耐久度变化。
        /// </summary>
        private int AdjustDamageForWeapon(Minion attacker, int dmg)
        {
            switch (attacker.own ? this.ownWeapon.name : this.enemyWeapon.name)
            {
                case CardDB.cardNameEN.bulwarkofazzinoth:
                    dmg = 1;
                    DecreaseWeaponDurability(attacker.own);
                    break;
            }
            return dmg;
        }

        /// <summary>
        /// 减少武器的耐久度。
        /// </summary>
        private void DecreaseWeaponDurability(bool own)
        {
            if (own)
            {
                this.ownWeapon.Durability--;
            }
            else
            {
                this.enemyWeapon.Durability--;
            }
        }

        /// <summary>
        /// 处理武器的特殊效果，如墓地复仇、巨型符文剑等。
        /// </summary>
        private void HandleWeaponSpecialEffects(Minion attacker, Minion defender, int oldHp)
        {
            if (attacker.own)
            {
                switch (this.ownWeapon.name)
                {
                    case CardDB.cardNameEN.massiveruneblade:
                        if (defender.isHero)
                        {
                            // 巨型符文剑效果：对英雄的伤害翻倍
                            this.ownHero.Angr *= 2;
                        }
                        break;

                    case CardDB.cardNameEN.gravevengeance:
                        if (oldHp > defender.Hp)
                        {
                            // 墓地复仇效果：如果造成了伤害，触发相应的效果
                            this.triggerAMinionDealedDmg(attacker, oldHp - defender.Hp, true);
                        }
                        break;

                    case CardDB.cardNameEN.icebreaker:
                        if (defender.frozen && oldHp > defender.Hp)
                        {
                            // 破冰者效果：如果攻击冻结目标，则直接摧毁目标
                            minionGetDestroyed(defender);
                        }
                        break;
                }
            }
            else
            {
                switch (this.enemyWeapon.name)
                {
                    case CardDB.cardNameEN.bulwarkofazzinoth:
                        // 阿兹诺斯战盾效果：每次攻击只受到1点伤害，并减少耐久度
                        this.enemyWeapon.Durability--;
                        break;
                }
            }
        }

        /// <summary>
        /// 处理防御者受到伤害后的效果，如冻结、吸血等。
        /// </summary>
        private void HandleDefenderDamageEffects(Minion attacker, Minion defender, int oldHp, bool defenderHasDivineshild)
        {
            if (!attacker.silenced)
            {
                switch (attacker.handcard.card.nameEN)
                {
                    case CardDB.cardNameEN.voodoohexxer:
                    case CardDB.cardNameEN.snowchugger:
                    case CardDB.cardNameEN.waterelemental:
                        if (!defender.silenced) minionGetFrozen(defender);
                        break;
                }
            }
            this.triggerAMinionDealedDmg(attacker, defender.GotDmgValue, true); // attacker did dmg

            // 处理吸血效果
            if (attacker.lifesteal)
            {
                HealHero(attacker.own, oldHp - defender.Hp);
            }
        }

        /// <summary>
        /// 处理攻击者受到伤害后的效果，如冻结、吸血等。
        /// </summary>
        private void HandleAttackerDamageEffects(Minion attacker, Minion defender, int oldHp)
        {
            if (!defender.silenced)
            {
                switch (defender.handcard.card.nameEN)
                {
                    case CardDB.cardNameEN.voodoohexxer:
                    case CardDB.cardNameEN.voodoohexxer_ICC_088:
                    case CardDB.cardNameEN.snowchugger:
                    case CardDB.cardNameEN.chillomatic:
                    case CardDB.cardNameEN.waterelemental:
                    case CardDB.cardNameEN.waterelemental_CS2_033:
                    case CardDB.cardNameEN.waterelemental_Story_11_WaterElemental:
                    case CardDB.cardNameEN.waterelemental_ICC_833t:
                    case CardDB.cardNameEN.waterelemental_VAC_509t:
                    case CardDB.cardNameEN.waterelemental_VAN_CS2_033:
                    case CardDB.cardNameEN.iceshard_YOD_029t:
                    case CardDB.cardNameEN.snowman:
                    case CardDB.cardNameEN.snowbrute:
                    case CardDB.cardNameEN.frozenstagguard:
                    case CardDB.cardNameEN.sindragosaswing:
                    case CardDB.cardNameEN.sindragosaswing_NX2_037t2:
                    case CardDB.cardNameEN.icehoofprotector:
                        minionGetFrozen(attacker);
                        break;
                    default:
                        break;
                }
            }

            // 处理吸血效果
            if (defender.lifesteal)
            {
                HealHero(defender.own, oldHp - attacker.Hp);
            }

            this.triggerAMinionDealedDmg(defender, attacker.GotDmgValue, false); // defender did dmg
        }

        /// <summary>
        /// 处理超杀和荣誉击杀效果。
        /// </summary>
        private void HandleOverkillAndHonorableKill(Minion attacker, Minion defender, int oldHp, int attackerAngr, bool defenderHasDivineshild)
        {
            if (oldHp < attackerAngr && !defenderHasDivineshild)
            {
                if (!attacker.isHero)
                {
                    attacker.handcard.card.sim_card.OnOverkill(this, attacker);
                }
                else
                {
                    Weapon weapon = attacker.own ? this.ownWeapon : this.enemyWeapon;
                    weapon.card.sim_card.OnOverkill(this, weapon);
                }
            }

            if (oldHp == attackerAngr && !defenderHasDivineshild)
            {
                if (!attacker.isHero)
                {
                    attacker.handcard.card.sim_card.OnHonorableKill(this, attacker, defender);
                }
                else
                {
                    Weapon weapon = attacker.own ? this.ownWeapon : this.enemyWeapon;
                    weapon.card.sim_card.OnHonorableKill(this, weapon, defender);
                }
            }
        }

        /// <summary>
        /// 为英雄恢复生命值，处理吸血效果。
        /// </summary>
        private void HealHero(bool own, int amount)
        {
            this.minionGetDamageOrHeal(own ? this.ownHero : this.enemyHero, -amount);
        }

        /// <summary>
        /// 处理攻击后触发的效果。
        /// </summary>
        private void HandlePostAttackEffects(Minion attacker, Minion defender, bool dontcount)
        {
            if (!attacker.silenced && !dontcount)
            {
                //调用随从攻击后的sim方法
                attacker.handcard.card.sim_card.afterMinionAttack(this, attacker, defender, dontcount);
            }
            // switch (attacker.name)
            // {
            //     case CardDB.cardNameEN.parkpanther:
            //         if (attacker.own)
            //         {
            //             this.minionGetTempBuff(this.ownHero, 3, 0);
            //         }
            //         break;
            //     case CardDB.cardNameEN.theboogeymonster:
            //         if (!defender.isHero && defender.Hp < 1 && attacker.Hp > 0) this.minionGetBuffed(attacker, 2, 2);
            //         break;
            //     case CardDB.cardNameEN.overlordrunthak:
            //         foreach (Handmanager.Handcard hc in this.owncards)
            //         {
            //             if (hc.card.type == CardDB.cardtype.MOB)
            //             {
            //                 hc.addattack++;
            //                 hc.addHp++;
            //                 this.anzOwnExtraAngrHp += 2;
            //             }
            //         }
            //         break;
            //     case CardDB.cardNameEN.windupburglebot:
            //         if (!defender.isHero && attacker.Hp > 0) this.drawACard(CardDB.cardNameEN.unknown, attacker.own);
            //         break;
            //     case CardDB.cardNameEN.lotusassassin:
            //         if (!defender.isHero && defender.Hp < 1 && attacker.Hp > 0) attacker.stealth = true;
            //         break;
            //     case CardDB.cardNameEN.lotusillusionist:
            //         if (defender.isHero) this.minionTransform(attacker, this.getRandomCardForManaMinion(6));
            //         break;
            //     case CardDB.cardNameEN.viciousfledgling:
            //         if (defender.isHero) this.getBestAdapt(attacker);
            //         break;
            //     case CardDB.cardNameEN.knuckles:
            //         if (!defender.isHero && attacker.Hp > 0) this.minionAttacksMinion(attacker, attacker.own ? this.enemyHero : this.ownHero, true);
            //         break;
            //     case CardDB.cardNameEN.finjatheflyingstar:
            //         if (!defender.isHero && defender.Hp < 1)
            //         {
            //             SummonMurlocs(attacker);
            //         }
            //         break;
            //     case CardDB.cardNameEN.giantsandworm:
            //         if (!defender.isHero && defender.Hp < 1 && attacker.Hp > 0)
            //         {
            //             attacker.numAttacksThisTurn = 0;
            //             attacker.Ready = true;
            //         }
            //         break;
            //     case CardDB.cardNameEN.drakonidslayer:
            //     case CardDB.cardNameEN.magnatauralpha:
            //     case CardDB.cardNameEN.lakethresher:
            //     case CardDB.cardNameEN.darkmoonrabbit:
            //     case CardDB.cardNameEN.foereaper4000:
            //         if (!attacker.silenced && !dontcount)
            //         {
            //             AttackAdjacentMinions(attacker, defender);
            //         }
            //         break;
            // }
        }

        /// <summary>
        /// 处理攻击相邻随从的逻辑。
        /// </summary>
        public void AttackAdjacentMinions(Minion attacker, Minion defender)
        {
            List<Minion> temp = (attacker.own) ? this.enemyMinions : this.ownMinions;
            foreach (Minion mnn in temp)
            {
                if (mnn.zonepos + 1 == defender.zonepos || mnn.zonepos - 1 == defender.zonepos)
                {
                    this.minionAttacksMinion(attacker, mnn, true);
                }
            }
        }

        /// <summary>
        /// 处理芬杰的效果，召唤鱼人。
        /// </summary>
        public void SummonMurlocs(Minion attacker)
        {
            if (attacker.own)
            {
                int count = Math.Min(7 - this.ownMinions.Count, 2);
                foreach (KeyValuePair<CardDB.cardIDEnum, int> cid in this.prozis.turnDeck)
                {
                    CardDB.Card c = CardDB.Instance.getCardDataFromID(cid.Key);
                    if ((TAG_RACE)c.race == TAG_RACE.MURLOC)
                    {
                        for (int i = 0; i < cid.Value && count > 0; i++, count--)
                        {
                            this.callKid(c, this.ownMinions.Count, true);
                        }
                    }
                }
            }
            else
            {
                this.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_168), this.enemyMinions.Count, false);
                this.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_168), this.enemyMinions.Count, false);
            }
        }

        /// <summary>
        /// 处理英雄使用武器进行攻击的逻辑，包括武器特效、任务进度更新、目标判定等。
        /// </summary>
        /// <param name="hero">执行攻击的英雄随从。</param>
        /// <param name="target">攻击的目标随从或英雄。</param>
        /// <param name="penality">该操作的惩罚值。</param>
        public void attackWithWeapon(Minion hero, Minion target, int penality)
        {
            bool own = hero.own; // 判断攻击方是否为己方
            Weapon weapon = own ? this.ownWeapon : this.enemyWeapon; // 获取当前使用的武器
            this.attacked = true; // 标记已执行攻击
            this.evaluatePenality += penality; // 累加惩罚值
            hero.numAttacksThisTurn++; // 更新攻击次数

            // 更新英雄是否准备好攻击的状态
            hero.updateReadyness();

            // 特殊武器处理：愚者之剑
            if (weapon.name == CardDB.cardNameEN.foolsbane && !hero.frozen)
            {
                hero.Ready = true;
            }

            // 特殊武器处理：铁刃护手
            if (weapon.card.nameCN == CardDB.cardNameCN.铁刃护手 && target.isHero)
            {
                this.evaluatePenality += 1000;
            }

            // 处理武器的吸血效果
            if (weapon.lifesteal)
            {
                this.minionGetDamageOrHeal(hero, -weapon.Angr);
            }

            // 处理保护甲板支线任务
            /* if (this.sideQuest.maxProgress != 1000 && this.sideQuest.Id == CardDB.cardIDEnum.DRG_317)
            {
                this.sideQuest.questProgress++;
                if (this.sideQuest.questProgress >= this.sideQuest.maxProgress)
                {
                    this.drawACard(CardDB.cardIDEnum.CS2_005, true, true);
                    this.drawACard(CardDB.cardIDEnum.CS2_005, true, true);
                    this.drawACard(CardDB.cardIDEnum.CS2_005, true, true);
                    this.sideQuest.Reset();
                }
            } */

            // 处理特殊武器效果
            /*  switch (weapon.name)
             {
                 case CardDB.cardNameEN.truesilverchampion:
                     int heal = own ? this.getMinionHeal(2) : this.getEnemyMinionHeal(2);
                     this.minionGetDamageOrHeal(hero, -heal);
                     doDmgTriggers(); // 触发伤害效果
                     break;
                 case CardDB.cardNameEN.piranhalauncher:
                     int pos = own ? this.ownMinions.Count : this.enemyMinions.Count;
                     this.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_337t), pos, own);
                     break;
                 case CardDB.cardNameEN.vinecleaver:
                     int pos2 = own ? this.ownMinions.Count : this.enemyMinions.Count;
                     this.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t), pos2, own);
                     this.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t), pos2, own);
                     break;
                 case CardDB.cardNameEN.foolsbane:
                     if (!hero.frozen)
                     {
                         hero.Ready = true; // 愚者之剑的效果使得英雄在攻击后仍然准备好
                     }
                     break;
                 case CardDB.cardNameEN.brassknuckles:
                     if (own)
                     {
                         // 为手牌中的随机随从+1/+1
                         Handmanager.Handcard hc = this.searchRandomMinionInHand(this.owncards, searchmode.searchLowestCost, GAME_TAGs.Mob);
                         if (hc != null)
                         {
                             hc.addattack++;
                             hc.addHp++;
                             this.anzOwnExtraAngrHp += 2;
                         }
                     }
                     else
                     {
                         if (this.enemyAnzCards > 0)
                         {
                             this.anzEnemyExtraAngrHp += this.enemyAnzCards * 2 - 1;
                         }
                     }
                     break;
             } */

            if (logging)
            {
                Helpfunctions.Instance.logg("attack with weapon target: " + target.entitiyID);
            }

            // 如果目标是英雄，则处理触发的秘密，并可能改变攻击目标
            if (target.isHero)
            {
                int newTarget = this.secretTrigger_CharIsAttacked(hero, target);
                if (newTarget >= 1)
                {
                    // 搜索新的攻击目标
                    foreach (Minion m in this.ownMinions)
                    {
                        if (m.entitiyID == newTarget)
                        {
                            target = m;
                            break;
                        }
                    }
                    foreach (Minion m in this.enemyMinions)
                    {
                        if (m.entitiyID == newTarget)
                        {
                            target = m;
                            break;
                        }
                    }
                    if (this.ownHero.entitiyID == newTarget) target = this.ownHero;
                    if (this.enemyHero.entitiyID == newTarget) target = this.enemyHero;
                }
            }

            // 执行攻击逻辑
            this.minionAttacksMinion(hero, target);

            // 处理嗜血狂怒的效果：攻击随从时不损失武器耐久
            if (own)
            {
                if (this.ownWeapon.name == CardDB.cardNameEN.gorehowl && !target.isHero)
                {
                    this.ownWeapon.Angr--;
                    hero.Angr--;
                }
                else
                {
                    this.lowerWeaponDurability(1, true); // 减少武器耐久度
                }
            }
            else
            {
                if (this.enemyWeapon.name == CardDB.cardNameEN.gorehowl && !target.isHero)
                {
                    this.enemyWeapon.Angr--;
                    hero.Angr--;
                }
                else
                {
                    this.lowerWeaponDurability(1, false); // 减少敌方武器耐久度
                }
            }

            // 处理友方地标VAC_929（惊险悬崖）的冷却状态
            // foreach (Minion m in this.ownMinions)
            // {
            //     if (m.handcard.card.cardIDenum == CardDB.cardIDEnum.VAC_929 && m.CooldownTurn > 0)
            //     {
            //         CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_929);
            //         m.CooldownTurn = 0;
            //         m.handcard.card.CooldownTurn = 0;
            //         m.Ready = true;
            //         Helpfunctions.Instance.logg("卡牌名称 - " + card.nameCN.ToString() + " " + card.cardIDenum.ToString() + " 地标冷却回合 - 0");
            //     }
            // }
        }

        /// <summary>
        /// 执行打出一张卡牌的逻辑，包括处理各种触发效果、奥秘触发、战吼、法术效果等。
        /// </summary>
        /// <param name="hc">要打出的手牌。</param>
        /// <param name="target">卡牌的目标随从或英雄。</param>
        /// <param name="position">随从放置的位置。</param>
        /// <param name="choice">卡牌的选择参数（用于二选一或类似效果）。</param>
        /// <param name="penality">执行该操作的惩罚值。</param>
        public void PlayACard(Handmanager.Handcard hc, Minion target, int position, int choice, int penality)
        {
            if (hc == null) hc = new Handmanager.Handcard();
            CardDB.Card c = hc.card;
            this.evaluatePenality += penality;

            // 记录敌方英雄当前的生命值
            int enemyHeroHpBefore = this.enemyHero.Hp;

            // 更新 lastPlayedCardCost 属性
            this.lastPlayedCardCost = c.getManaCost(this, hc.manacost);

            if (hc.card.race == CardDB.Race.ELEMENTAL)
            {
                this.ownElementalsPlayedThisTurn++;
                if (!this.playedElementalThisTurn)
                {
                    this.playedElementalThisTurn = true;
                    Hrtprozis.Instance.ownConsecutiveElementalTurns++;
                }
            }

            // 处理特殊卡牌费用
            HandleSpecialCardCost(hc);

            // 删除其他发现的选项
            if (hc.discovered)
            {
                RemoveOtherDiscoveredCards(hc);
            }

            if (hc != null)
            {
                removeCard(hc); // 从手牌中移除该牌
            }

            this.triggerCardsChanged(true); // 触发手牌变化的相关事件

            // 更新元素和自然法术标志
            UpdateElementalAndNatureFlags(c);

            // 处理法术卡牌的效果
            if (c.type == CardDB.cardtype.SPELL)
            {
                HandleSpellCardEffects(hc, target, choice);
            }

            hc.target = target;
            this.triggerACardWillBePlayed(hc, true); // 触发即将打出卡牌的事件

            int newTarget = secretTrigger_SpellIsPlayed(target, c); // 处理奥秘触发
            target = UpdateTargetBasedOnSecret(newTarget, target);

            if (newTarget != -2)
            {
                HandleMinionOrSpellPlay(hc, target, position, choice);
            }

            // 计算卡牌效果执行后敌方英雄的生命值差
            int damageDealt = enemyHeroHpBefore - this.enemyHero.Hp;
            if (damageDealt > 0)
            {
                this.damageDealtToEnemyHeroThisTurn += damageDealt;
            }

            // 处理法术反制/扰咒术
            if (newTarget != 0 && target != null)
            {
                HandleCounterspellOrSpellbender(c, target);
            }

            // 处理增益效果
            ApplyBuffEffect(hc);

            // 鹦鹉乐园，战吼随从牌的法力值消耗减少
            if (this.parrotSanctuaryCount > 0 && hc.card.battlecry)
            {
                this.parrotSanctuaryCount = 0;
                // 处理友方地标VAC_409（鹦鹉乐园）的冷却状态
                // foreach (Minion m in this.ownMinions)
                // {
                //     if (m.handcard.card.cardIDenum == CardDB.cardIDEnum.VAC_409 && m.CooldownTurn > 0)
                //     {
                //         CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_409);
                //         m.CooldownTurn = 0;
                //         m.handcard.card.CooldownTurn = 0;
                //         m.Ready = true;
                //         Helpfunctions.Instance.logg("卡牌名称 - " + card.nameCN.ToString() + " " + card.cardIDenum.ToString() + " 地标冷却回合 - 0");
                //     }
                // }
            }

            // 检查是否打出了记录的最后一张牌
            // if (hc.entity == this.lastDrawnCardEntityID)
            // {
            //     // 处理友方地标VAC_334（小玩物小屋）的冷却状态
            //     foreach (Minion m in this.ownMinions)
            //     {
            //         if (m.handcard.card.cardIDenum == CardDB.cardIDEnum.VAC_334 && m.CooldownTurn > 0)
            //         {
            //             CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_334);
            //             m.CooldownTurn = 0;
            //             m.handcard.card.CooldownTurn = 0;
            //             m.Ready = true;
            //             Helpfunctions.Instance.logg("卡牌名称 - " + card.nameCN.ToString() + " " + card.cardIDenum.ToString() + " 地标冷却回合 - 0");
            //         }
            //     }

            //     // 重置lastDrawnCardEntityID
            //     this.lastDrawnCardEntityID = -1;
            // }

            // 检查是否打出了法术牌
            // if (c.type == CardDB.cardtype.SPELL)
            // {
            //     // 处理友方地标VAC_522（潮汐之池）的冷却状态
            //     foreach (Minion m in this.ownMinions)
            //     {
            //         if (m.handcard.card.cardIDenum == CardDB.cardIDEnum.VAC_522 && m.CooldownTurn > 0)
            //         {
            //             CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_522);
            //             m.CooldownTurn = 0;
            //             m.handcard.card.CooldownTurn = 0;
            //             m.Ready = true;
            //             Helpfunctions.Instance.logg("卡牌名称 - " + card.nameCN.ToString() + " " + card.cardIDenum.ToString() + " 地标冷却回合 - 0");
            //         }
            //     }
            // }

            this.cardsPlayedThisTurn++; // 更新本回合打出的牌数
        }

        /// <summary>
        /// 处理卡牌的特殊费用逻辑，如用血量支付法术/鱼人牌的费用。
        /// </summary>
        private void HandleSpecialCardCost(Handmanager.Handcard hc)
        {
            if (this.nextSpellThisTurnCostHealth && hc.card.type == CardDB.cardtype.SPELL)
            {
                PayHealthForSpell(hc);
            }
            else if (this.nextMurlocThisTurnCostHealth && (hc.card.race == CardDB.Race.MURLOC || hc.card.race == CardDB.Race.ALL))
            {
                PayHealthForMurloc(hc);
            }
            else if (this.nextAnyCardThisTurnCostEnemyHealth)
            {
                PayEnemyHealthForAnyCard(hc);
            }
            else if (this.ownDemonCostLessOnce > 0 && (hc.card.race == CardDB.Race.DEMON || hc.card.race == CardDB.Race.ALL))
            {
                this.ownDemonCostLessOnce = 0; // 恶魔卡牌法力消耗减少
            }
            else
            {
                this.mana -= hc.getManaCost(this); // 正常减少法力值
            }
        }

        /// <summary>
        /// 用血量支付法术牌的费用。
        /// </summary>
        private void PayHealthForSpell(Handmanager.Handcard hc)
        {
            this.minionGetDamageOrHeal(this.ownHero, hc.card.getManaCost(this, hc.manacost));
            doDmgTriggers();
            this.nextSpellThisTurnCostHealth = false;
        }



        /// <summary>
        /// 用血量支付鱼人牌的费用。
        /// </summary>
        private void PayHealthForMurloc(Handmanager.Handcard hc)
        {
            this.minionGetDamageOrHeal(this.ownHero, hc.card.getManaCost(this, hc.manacost));
            doDmgTriggers();
            this.nextMurlocThisTurnCostHealth = false;
        }

        /// <summary>
        /// 用敌方英雄血量支付任何牌的费用。
        /// </summary>
        private void PayEnemyHealthForAnyCard(Handmanager.Handcard hc)
        {
            this.minionGetDamageOrHeal(this.enemyHero, hc.card.getManaCost(this, hc.manacost));
            doDmgTriggers();
            this.nextAnyCardThisTurnCostEnemyHealth = false;
        }

        /// <summary>
        /// 移除其他发现的卡牌。
        /// </summary>
        private void RemoveOtherDiscoveredCards(Handmanager.Handcard hc)
        {
            foreach (Handmanager.Handcard hcc in this.owncards.ToArray())
            {
                if (hcc.discovered && hcc.entity != hc.entity)
                {
                    removeCard(hcc);
                }
            }
        }

        /// <summary>
        /// 更新元素和自然法术的标志位。
        /// </summary>
        private void UpdateElementalAndNatureFlags(CardDB.Card c)
        {
            UpdateElementalFlag();
            UpdateNatureSpellFlag(c);
            this.anzOwnElementalsThisTurn = 0;
        }

        /// <summary>
        /// 更新元素生物的标志位。
        /// </summary>
        private void UpdateElementalFlag()
        {
            foreach (Minion elm in this.ownMinions)
            {
                if ((TAG_RACE)elm.handcard.card.race == TAG_RACE.ELEMENTAL)
                {
                    this.anzOwnElementalsThisTurn = 1;
                    this.anzOwnElementalsLastTurn = this.anzOwnElementalsThisTurn;
                    break;
                }
            }
        }


        /// <summary>
        /// 更新自然法术的标志位。
        /// </summary>
        private void UpdateNatureSpellFlag(CardDB.Card c)
        {
            if (c.SpellSchool == CardDB.SpellSchool.NATURE)
            {
                foreach (Handmanager.Handcard ohc in this.owncards)
                {
                    if (ohc.card.nameCN == CardDB.cardNameCN.自然使徒)
                    {
                        this.useNature = 1;
                        prozis.useNature = 1;
                        break;
                    }
                }
            }
            else
            {
                this.useNature = 0;
                prozis.useNature = 0;
            }
        }

        /// <summary>
        /// 处理法术卡牌的效果，包括目标选择和特殊触发。
        /// </summary>
        private void HandleSpellCardEffects(Handmanager.Handcard hc, Minion target, int choice)
        {
            this.playedPreparation = false; // 清除伺机待发标志
            this.spellsplayedSinceRecalc++;

            // 处理暗影布缝针的效果
            if (this.ownWeapon != null && this.ownWeapon.Durability > 0 && this.ownWeapon.card.nameCN == CardDB.cardNameCN.暗影布缝针 && hc.card.SpellSchool == CardDB.SpellSchool.SHADOW)
            {
                this.allCharsOfASideGetDamage(false, 1);
                this.evaluatePenality -= (this.enemyMinions.Count + 1) * 4;
                this.ownWeapon.Durability--;
            }

            // 处理法术目标的特殊效果
            HandleSpellTargetEffects(hc, target, choice);

            // 处理奥秘牌
            if (hc.card.Secret)
            {
                this.ownSecretsIDList.Add(hc.card.cardIDenum);
                this.nextSecretThisTurnCost0 = false;
                this.secretsplayedSinceRecalc++;
            }
        }

        /// <summary>
        /// 处理法术目标的特殊效果。
        /// </summary>
        private void HandleSpellTargetEffects(Handmanager.Handcard hc, Minion target, int choice)
        {
            //这卡没几个人用注释掉优化性能，有需要再自己取消注释
            // if (target != null && target.own)
            // {
            //     switch (target.name)
            //     {
            //         case CardDB.cardNameEN.dragonkinsorcerer:
            //             this.minionGetBuffed(target, 1, 1);
            //             break;
            //         case CardDB.cardNameEN.eydisdarkbane:
            //             Minion mTarget = this.getEnemyCharTargetForRandomSingleDamage(3);
            //             this.minionGetDamageOrHeal(mTarget, 3, true);
            //             break;
            //         case CardDB.cardNameEN.fjolalightbane:
            //             target.divineshild = true;
            //             break;
            //         default:
            //             break;
            //     }
            // }
        }

        /// <summary>
        /// 根据奥秘更新目标。
        /// </summary>
        private Minion UpdateTargetBasedOnSecret(int newTarget, Minion target)
        {
            if (newTarget >= 1)
            {
                foreach (Minion m in this.ownMinions)
                {
                    if (m.entitiyID == newTarget)
                    {
                        return m;
                    }
                }
                foreach (Minion m in this.enemyMinions)
                {
                    if (m.entitiyID == newTarget)
                    {
                        return m;
                    }
                }
                if (this.ownHero.entitiyID == newTarget) return this.ownHero;
                if (this.enemyHero.entitiyID == newTarget) return this.enemyHero;
            }
            return target;
        }

        /// <summary>
        /// 处理随从或法术牌的效果。
        /// 2025-08-10添加武器牌和英雄牌
        /// </summary>
        private void HandleMinionOrSpellPlay(Handmanager.Handcard hc, Minion target, int position, int choice)
        {
            switch (hc.card.type)
            {
                case CardDB.cardtype.MOB:
                    HandleMinionPlay(hc, position, choice);
                    break;
                case CardDB.cardtype.SPELL:
                    HandleSpellPlay(hc, target, choice);
                    break;

                case CardDB.cardtype.WEAPON:
                    HandleWeaponPlay(hc, target, choice);
                    break;

                case CardDB.cardtype.HERO:
                    HandleHeroPlay(hc, choice);
                    break;

                case CardDB.cardtype.LOCATION:
                    HandleLocationPlay(hc, position, choice);
                    break;

                default:
                    HandleSpellPlay(hc, target, choice);
                    break;
            }
        }

        /// <summary>
        /// 处理地标卡牌的效果。
        /// </summary>
        /// <param name="hc"></param>
        /// <param name="position"></param>
        /// <param name="choice"></param>
        private void HandleLocationPlay(Handmanager.Handcard hc, int position, int choice)
        {
            if (this.ownMinions.Count < 7)
            {
                // 创建一个新的随从并设置其为手牌中打出
                Minion m = createNewMinion(hc, position, true);
                m.playedFromHand = true;

                // 将随从添加到战场
                addMinionToBattlefield(m);
                // 记录日志信息
                if (logging) Helpfunctions.Instance.logg("added " + m.handcard.card.nameEN);
                this.mobsplayedThisTurn++;
            }
        }
        /// <summary>
        ///  处理武器卡牌的效果。
        /// </summary>
        /// <param name="hc"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        private void HandleWeaponPlay(Handmanager.Handcard hc, Minion target, int choice)
        {
            this.equipWeapon(hc.card, true);
            hc.card.sim_card.onCardPlay(this, true, hc.target, choice);
            hc.card.sim_card.getBattlecryEffect(this, this.ownWeapon, hc.target, choice);
            if (this.ownBrannBronzebeard > 0)
            {
                for (int i = 0; i < this.ownBrannBronzebeard; i++)
                {
                    hc.card.sim_card.getBattlecryEffect(this, this.ownWeapon, hc.target, choice);
                }
            }

        }
        /// <summary>
        /// 处理英雄卡牌的效果。
        /// </summary>
        /// <param name="hc"></param>
        /// <param name="choice"></param>
        private void HandleHeroPlay(Handmanager.Handcard hc, int choice)
        {

            hc.card.sim_card.getBattlecryEffect(this, this.ownHero, hc.target, choice);
            if (this.ownBrannBronzebeard > 0)
            {
                for (int i = 0; i < this.ownBrannBronzebeard; i++)
                {
                    hc.card.sim_card.getBattlecryEffect(this, this.ownHero, hc.target, choice);
                }
            }
            hc.card.sim_card.onCardPlay(this, this.ownHero, hc.target, choice);
            this.setNewHeroPower(hc.card.heroPower, true);
            this.minionGetArmor(this.ownHero, hc.card.armor);
            // Minion m = new Minion
            // {
            //     handcard = new Handmanager.Handcard(hc),
            //     own = true,
            //     isHero = true,
            //     entitiyID = hc.entity,
            //     playedThisTurn = true,
            //     numAttacksThisTurn = 0,
            //     divineshild = ownHero.divineshild,
            //     lifesteal = ownHero.lifesteal,
            //     stealth = ownHero.stealth,
            //     name = hc.card.nameEN,
            //     nameCN = hc.card.nameCN,
            // };

        }



        /// <summary>
        /// 处理随从卡牌的效果，包括召唤、群兽奔腾等。
        /// </summary>
        private void HandleMinionPlay(Handmanager.Handcard hc, int position, int choice)
        {
            if (this.ownMinions.Count < 7)
            {
                this.placeAmobSomewhere(hc, choice, position); // 放置随从到战场
                this.mobsplayedThisTurn++;
            }

            // 处理奔踏效果
            if (this.stampede > 0 && (TAG_RACE)hc.card.race == TAG_RACE.PET)
            {
                for (int i = 1; i <= stampede; i++)
                {
                    this.drawACard(CardDB.cardNameEN.unknown, true, true); // 随机获取一张野兽
                }
            }

            // 处理流放效果
            HandleOutcastEffect(hc, hc.card.Outcast);
        }

        /// <summary>
        /// 处理法术卡牌的效果。
        /// </summary>
        private void HandleSpellPlay(Handmanager.Handcard hc, Minion target, int choice)
        {
            // 处理锁定装载特效
            if (this.lockandload > 0 && hc.card.type == CardDB.cardtype.SPELL)
            {
                // for (int i = 1; i <= lockandload; i++)
                // {
                this.drawACard(CardDB.cardNameEN.unknown, true, true);
                // }
            }

            // 处理流放效果
            HandleOutcastEffect(hc, hc.card.Outcast);

            // 处理日蚀的效果
            if (this.anzSolor && hc.card.type == CardDB.cardtype.SPELL)
            {
                if (hc.card.nameCN == CardDB.cardNameCN.日蚀)
                {
                    this.evaluatePenality += 1000;
                }
                hc.card.sim_card.onCardPlay(this, true, target, choice);
                hc.card.sim_card.onCardPlay(this, true, target, choice, hc);
                this.anzSolor = false;
            }

            // 执行卡牌的主要效果
            hc.card.sim_card.onCardPlay(this, true, target, choice);
            hc.card.sim_card.onCardPlay(this, true, target, choice, hc);

            // 处理法术迸发效果
            HandleSpellburstEffect(hc);
        }

        /// <summary>
        /// 处理流放效果。
        /// </summary>
        private void HandleOutcastEffect(Handmanager.Handcard hc, bool outcast)
        {
            if (outcast && (hc.position == 1 || hc.position == this.owncards.Count + 1))
            {
                hc.card.sim_card.onCardPlay(this, true, hc.target, hc.extraParam2, true);
                this.evaluatePenality--; // 优先打出右手边的流放
            }
        }

        /// <summary>
        /// 处理法术迸发效果。
        /// </summary>
        private void HandleSpellburstEffect(Handmanager.Handcard hc)
        {
            if (hc.card.type == CardDB.cardtype.SPELL)
            {
                foreach (Minion m in this.ownMinions.ToArray())
                {
                    if (m.Spellburst && !m.silenced)
                    {
                        m.handcard.card.sim_card.OnSpellburst(this, m, hc);
                        m.Spellburst = false;
                    }
                }
                if (this.ownWeapon.Spellburst)
                {
                    this.ownWeapon.card.sim_card.OnSpellburst(this, this.ownWeapon, hc);
                    this.ownWeapon.Spellburst = false;
                }
            }
        }

        /// <summary>
        /// 处理法术反制或扰咒术的逻辑。
        /// </summary>
        private void HandleCounterspellOrSpellbender(CardDB.Card c, Minion target)
        {
            if (!target.own && (prozis.penman.attackBuffDatabase.ContainsKey(c.nameEN) || prozis.penman.healthBuffDatabase.ContainsKey(c.nameEN)))
            {
                // 可在此引入打分逻辑
            }
        }

        /// <summary>
        /// 应用卡牌的增益效果。
        /// </summary>
        private void ApplyBuffEffect(Handmanager.Handcard hc)
        {
            if (hc.target != null && prozis.penman.healthBuffDatabase.ContainsKey(hc.card.nameEN))
            {
                hc.target.justBuffed += prozis.penman.healthBuffDatabase[hc.card.nameEN];
            }
        }

        /// <summary>
        /// 处理敌方打出一张卡牌的逻辑，包括触发相关效果、目标选择和奥秘触发等。
        /// </summary>
        /// <param name="c">敌方打出的卡牌。</param>
        /// <param name="target">卡牌的目标随从或英雄。</param>
        /// <param name="position">随从放置的位置。</param>
        /// <param name="choice">卡牌的选择参数（用于二选一或类似效果）。</param>
        /// <param name="penality">执行该操作的惩罚值。</param>
        public void EnemyplaysACard(CardDB.Card c, Minion target, int position, int choice, int penality)
        {
            // 创建一个新的手牌实例，表示敌方打出的卡牌
            Handmanager.Handcard hc = new Handmanager.Handcard(c);
            hc.entity = this.getNextEntity(); // 获取下一个实体ID
            if (logging) Helpfunctions.Instance.logg("enemy plays card " + c.nameEN + " target " + target);

            this.enemyAnzCards--; // 敌方手牌数量减少

            hc.target = target; // 设置目标
            this.triggerACardWillBePlayed(hc, false); // 触发卡牌即将被打出的事件
            this.triggerCardsChanged(false); // 触发手牌变化的事件

            // 检查并触发奥秘
            int newTarget = secretTrigger_SpellIsPlayed(target, c);
            target = EnemyUpdateTargetBasedOnSecret(newTarget, target);

            if (newTarget != -2) // 如果奥秘不是法术反制或扰咒术，执行卡牌效果
            {
                if (c.type == CardDB.cardtype.MOB) // 处理随从卡牌
                {
                    EnemyHandleEnemyMinionPlay(hc, target, position, choice);
                }
                else // 处理法术卡牌
                {
                    c.sim_card.onCardPlay(this, false, target, choice); // 执行卡牌的主要效果
                    this.doDmgTriggers(); // 触发伤害效果
                }
            }
        }

        /// <summary>
        /// 敌方 - 根据奥秘更新目标。
        /// </summary>
        /// <param name="newTarget">奥秘可能更改后的新目标。</param>
        /// <param name="target">当前的目标。</param>
        /// <returns>更新后的目标。</returns>
        private Minion EnemyUpdateTargetBasedOnSecret(int newTarget, Minion target)
        {
            if (newTarget >= 1)
            {
                // 遍历己方和敌方随从列表，找到新的攻击目标
                foreach (Minion m in this.ownMinions)
                {
                    if (m.entitiyID == newTarget)
                    {
                        return m;
                    }
                }
                foreach (Minion m in this.enemyMinions)
                {
                    if (m.entitiyID == newTarget)
                    {
                        return m;
                    }
                }
                if (this.ownHero.entitiyID == newTarget) return this.ownHero;
                if (this.enemyHero.entitiyID == newTarget) return this.enemyHero;
            }
            return target;
        }

        /// <summary>
        /// 敌方 - 处理敌方随从卡牌的打出逻辑。
        /// </summary>
        /// <param name="hc">手牌信息。</param>
        /// <param name="target">卡牌的目标。</param>
        /// <param name="position">随从放置的位置。</param>
        /// <param name="choice">卡牌的选择参数。</param>
        private void EnemyHandleEnemyMinionPlay(Handmanager.Handcard hc, Minion target, int position, int choice)
        {
            // TODO: 实现敌方随从的打出逻辑
            // 示例：this.placeAmobSomewhere(hc, target, choice, position);
        }

        /// <summary>
        /// 执行英雄技能的逻辑，包括处理技能使用次数、法力消耗、目标选择、触发效果等。
        /// </summary>
        /// <param name="target">技能的目标随从或英雄。</param>
        /// <param name="penality">执行该操作的惩罚值。</param>
        /// <param name="ownturn">标识是否为己方回合。</param>
        /// <param name="choice">技能的选择参数（用于二选一或类似效果）。</param>
        public void PlayHeroPower(Minion target, int penality, bool ownturn, int choice)
        {
            // 获取当前回合使用的英雄技能卡牌
            CardDB.Card c = ownturn ? this.ownHeroAblility.card : this.enemyHeroAblility.card;

            // 记录敌方英雄当前的生命值
            int enemyHeroHpBefore = this.enemyHero.Hp;

            // 处理技能使用次数和状态更新
            if (ownturn)
            {
                this.anzUsedOwnHeroPower++; // 更新己方英雄技能使用次数
                                            // 检查是否超过使用限制
                if (this.anzUsedOwnHeroPower >= this.ownHeroPowerAllowedQuantity)
                {
                    this.ownAbilityReady = false; // 超过限制后，标记技能未准备好
                }
            }
            else
            {
                this.anzUsedEnemyHeroPower++; // 更新敌方英雄技能使用次数
                if (this.anzUsedEnemyHeroPower >= this.enemyHeroPowerAllowedQuantity)
                {
                    this.enemyAbilityReady = false; // 超过限制后，标记技能未准备好
                }
            }

            // 累加惩罚值
            this.evaluatePenality += penality;

            // 处理特殊情况：如黑眼任务术中的法力消耗调整
            // if (this.ownHeroPowerCostLessOnce <= -2 && Ai.Instance.botBase.BehaviorName() == "黑眼任务术")
            // {
            //     this.evaluatePenality -= 20; // 减少惩罚值
            // }

            // 计算并减少法力值，确保消耗至少为0
            int manaCost = Math.Max(0, this.ownHeroAblility.manacost + this.ownHeroPowerCostLessOnce);
            this.mana -= manaCost;

            if (logging) Helpfunctions.Instance.logg("play hero power " + c.nameEN + " on target " + target);

            // 执行英雄技能的主要效果
            c.sim_card.onCardPlay(this, ownturn, target, choice);

            // 计算英雄技能执行后敌方英雄的生命值差
            int damageDealt = enemyHeroHpBefore - this.enemyHero.Hp;
            if (damageDealt > 0)
            {
                this.damageDealtToEnemyHeroThisTurn += damageDealt;
            }

            // 重置技能法力消耗的临时减少效果
            this.ownHeroPowerCostLessOnce = 0;

            // 处理目标被冻结的效果
            if (target != null && (ownturn ? this.ownAbilityFreezesTarget > 0 : this.enemyAbilityFreezesTarget > 0))
            {
                minionGetFrozen(target); // 冻结目标
            }

            // 触发激励效果
            this.triggerInspire(ownturn);

            // 触发奥秘：英雄技能使用
            this.secretTrigger_HeroPowerUsed();

            // 触发所有的伤害效果
            this.doDmgTriggers();
        }

        /// <summary>
        /// 降低武器的耐久度，如果耐久度降为0，处理武器的亡语效果，并更新英雄的状态。
        /// </summary>
        /// <param name="value">要降低的耐久度值。</param>
        /// <param name="own">标识是否为己方的武器。</param>
        public void lowerWeaponDurability(int value, bool own)
        {
            // 处理己方武器的耐久度
            if (own)
            {
                if (this.ownWeapon.Durability <= 0 || this.ownWeapon.immune) return; // 如果武器已无耐久度或具有免疫效果，则直接返回

                this.ownWeapon.Durability -= value; // 减少武器的耐久度
                if (this.ownWeapon.Durability <= 0) // 如果武器耐久度降为0或以下
                {
                    HandleWeaponBreak(this.ownWeapon, true); // 处理己方武器破碎的逻辑
                }
            }
            // 处理敌方武器的耐久度
            else
            {
                if (this.enemyWeapon.Durability <= 0 || this.enemyWeapon.immune) return; // 如果武器已无耐久度或具有免疫效果，则直接返回

                this.enemyWeapon.Durability -= value; // 减少武器的耐久度
                if (this.enemyWeapon.Durability <= 0) // 如果武器耐久度降为0或以下
                {
                    HandleWeaponBreak(this.enemyWeapon, false); // 处理敌方武器破碎的逻辑
                }
            }
        }

        /// <summary>
        /// 处理武器破碎后的逻辑，包括亡语触发、英雄攻击力更新、随从效果处理等。
        /// </summary>
        /// <param name="weapon">要处理的武器。</param>
        /// <param name="own">标识是否为己方的武器。</param>
        private void HandleWeaponBreak(Weapon weapon, bool own)
        {
            if (weapon.card.deathrattle)
            {
                Minion m = new Minion { own = own };
                weapon.card.sim_card.onDeathrattle(this, m); // 触发武器的亡语效果
            }

            // 更新英雄的攻击力
            if (own)
            {
                this.ownHero.Angr = Math.Max(0, this.ownHero.Angr - weapon.Angr);
                this.ownWeapon = new Weapon(); // 重置己方武器
                this.ownHero.windfury = false; // 移除风怒效果
                UpdateMinionsAfterWeaponBreak(this.ownMinions, true); // 更新己方随从的状态
                this.ownHero.updateReadyness(); // 更新英雄的准备状态
            }
            else
            {
                this.enemyHero.Angr = Math.Max(0, this.enemyHero.Angr - weapon.Angr);
                this.enemyWeapon = new Weapon(); // 重置敌方武器
                this.enemyHero.windfury = false; // 移除风怒效果
                UpdateMinionsAfterWeaponBreak(this.enemyMinions, false); // 更新敌方随从的状态
                this.enemyHero.updateReadyness(); // 更新英雄的准备状态
            }
        }

        /// <summary>
        /// 在武器破碎后，更新随从的状态，包括移除增益、减少攻击力等。
        /// </summary>
        /// <param name="minions">随从列表。</param>
        /// <param name="own">标识随从是否为己方。</param>
        private void UpdateMinionsAfterWeaponBreak(List<Minion> minions, bool own)
        {
            foreach (Minion m in minions)
            {
                switch (m.name)
                {
                    case CardDB.cardNameEN.southseadeckhand:
                        if (m.playedThisTurn)
                        {
                            m.charge--; // 减少冲锋次数
                            m.updateReadyness(); // 更新随从的准备状态
                        }
                        break;

                    case CardDB.cardNameEN.smalltimebuccaneer:
                        this.minionGetBuffed(m, -2, 0); // 移除因武器存在而获得的攻击力增益
                        break;

                    case CardDB.cardNameEN.graveshambler:
                        if (!m.silenced)
                        {
                            this.minionGetBuffed(m, 1, 1); // 增加墓穴践踏者的攻击力和生命值
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// 处理所有伤害触发器，包括随从和角色的治疗、伤害、死亡等效果。
        /// </summary>
        public void doDmgTriggers()
        {
            // 处理角色治疗触发的效果（如获得攻击力等）
            if (this.tempTrigger.charsGotHealed >= 1)
            {
                triggerACharGotHealed();
            }

            // 处理随从治疗触发的效果（如抽卡等）
            if (this.tempTrigger.minionsGotHealed >= 1)
            {
                triggerAMinionGotHealed();
            }

            // 处理随从受伤触发的效果（如抽卡、获得护甲或攻击力等）
            if (this.tempTrigger.ownMinionsGotDmg + this.tempTrigger.enemyMinionsGotDmg >= 1)
            {
                triggerAMinionGotDmg();
            }

            // 处理随从死亡触发的效果（如抽卡、获得攻击力和生命值、召唤随从等）
            if (this.tempTrigger.ownMinionsDied + this.tempTrigger.enemyMinionsDied >= 1)
            {
                triggerAMinionDied();

                // 更新随从状态变化的标志位
                if (this.tempTrigger.ownMinionsDied >= 1)
                {
                    this.tempTrigger.ownMinionsChanged = true;
                }
                if (this.tempTrigger.enemyMinionsDied >= 1)
                {
                    this.tempTrigger.enemyMininsChanged = true;
                }

                // 重置死亡触发器计数
                ResetMinionDeathTriggers();
            }

            // 处理随从失去圣盾触发的效果（如抽卡、获得护甲或攻击力等）
            if (this.tempTrigger.ownMinionLosesDivineShield + this.tempTrigger.enemyMinionLosesDivineShield >= 1)
            {
                triggerAMinionLosesDivineShield();
            }

            // 更新当前游戏状态，如随从的位置和状态等
            updateBoards();

            // 处理“小型法术尖晶石”卡牌升级的逻辑
            /* if (this.owncards.Any())
            {
                foreach (Handmanager.Handcard hc in this.owncards.ToArray())
                {
                    if (hc.card.nameEN == CardDB.cardNameEN.lesserspinelspellstone)
                    {
                        hc.SCRIPT_DATA_NUM_1 += this.tempTrigger.ownMinionsDied;
                        if (hc.SCRIPT_DATA_NUM_1 >= 5)
                        {
                            hc.SCRIPT_DATA_NUM_1 = 0;
                            hc.card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_825t); // 升级到法术尖晶石
                        }
                    }
                    else if (hc.card.nameEN == CardDB.cardNameEN.spinelspellstone)
                    {
                        hc.SCRIPT_DATA_NUM_1 += this.tempTrigger.ownMinionsDied;
                        if (hc.SCRIPT_DATA_NUM_1 >= 5)
                        {
                            hc.SCRIPT_DATA_NUM_1 = 0;
                            hc.card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_825t2); // 升级到大型法术尖晶石
                        }
                    }
                }
            } */

            // 处理友方地标VAC_425（大地之末号）的冷却状态
            // foreach (Minion m in this.ownMinions)
            // {
            //     if (m.handcard.card.cardIDenum == CardDB.cardIDEnum.VAC_425 && m.CooldownTurn > 0)
            //     {
            //         CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_425);
            //         m.CooldownTurn = 0;
            //         m.handcard.card.CooldownTurn = 0;
            //         m.Ready = true;
            //         Helpfunctions.Instance.logg("卡牌名称 - " + card.nameCN.ToString() + " " + card.cardIDenum.ToString() + " 地标冷却回合 - 0");
            //     }
            // }

            // 如果在处理伤害触发器的过程中又触发了新的事件，递归处理这些事件
            if (HasPendingTriggers())
            {
                doDmgTriggers(); // 递归调用以处理新触发的事件
            }
        }

        /// <summary>
        /// 重置随从死亡触发器的计数。
        /// </summary>
        private void ResetMinionDeathTriggers()
        {
            this.tempTrigger.ownMinionsDied = 0;
            this.tempTrigger.enemyMinionsDied = 0;
            this.tempTrigger.ownBeastDied = 0;
            this.tempTrigger.enemyBeastDied = 0;
            this.tempTrigger.ownMurlocDied = 0;
            this.tempTrigger.enemyMurlocDied = 0;
            this.tempTrigger.ownMechanicDied = 0;
            this.tempTrigger.enemyMechanicDied = 0;
            this.tempTrigger.ownUndeadDied = 0;
            this.tempTrigger.enemyUndeadDied = 0;
            this.tempTrigger.ownTreantDied = 0;
        }

        /// <summary>
        /// 判断是否有待处理的触发器。
        /// </summary>
        /// <returns>如果有待处理的触发器返回 true，否则返回 false。</returns>
        private bool HasPendingTriggers()
        {
            return this.tempTrigger.charsGotHealed + this.tempTrigger.minionsGotHealed +
                   this.tempTrigger.ownMinionsGotDmg + this.tempTrigger.enemyMinionsGotDmg +
                   this.tempTrigger.ownMinionsDied + this.tempTrigger.enemyMinionsDied >= 1;
        }


        /// <summary>
        /// 触发当角色被治疗时的效果，检查场上所有随从并执行相应的逻辑。
        /// </summary>
        public void triggerACharGotHealed()
        {
            int healedAmount = this.tempTrigger.charsGotHealed; // 获取触发的治疗量
            this.tempTrigger.charsGotHealed = 0; // 重置治疗触发计数

            // 处理己方随从的治疗触发效果
            foreach (Minion mnn in this.ownMinions)
            {
                if (mnn.silenced) continue; // 如果随从被沉默，跳过处理

                // 根据随从的名称触发相应的治疗效果
                switch (mnn.handcard.card.nameEN)
                {
                    case CardDB.cardNameEN.lightwarden:
                    case CardDB.cardNameEN.holychampion:
                    case CardDB.cardNameEN.shadowboxer:
                    case CardDB.cardNameEN.hoodedacolyte:
                    case CardDB.cardNameEN.aiextra1:
                        mnn.handcard.card.sim_card.onACharGotHealed(this, mnn, healedAmount);
                        break;

                    case CardDB.cardNameEN.blackguard:
                        if (ownHero.GotHealedValue > 0) // 如果己方英雄被治疗
                        {
                            mnn.handcard.card.sim_card.onACharGotHealed(this, mnn, ownHero.GotHealedValue);
                        }
                        break;
                }
            }

            // 处理敌方随从的治疗触发效果
            foreach (Minion mnn in this.enemyMinions)
            {
                if (mnn.silenced) continue; // 如果随从被沉默，跳过处理

                // 根据随从的名称触发相应的治疗效果
                switch (mnn.handcard.card.nameEN)
                {
                    case CardDB.cardNameEN.lightwarden:
                    case CardDB.cardNameEN.holychampion:
                    case CardDB.cardNameEN.shadowboxer:
                    case CardDB.cardNameEN.hoodedacolyte:
                    case CardDB.cardNameEN.aiextra1:
                        mnn.handcard.card.sim_card.onACharGotHealed(this, mnn, healedAmount);
                        break;

                    case CardDB.cardNameEN.blackguard:
                        if (enemyHero.GotHealedValue > 0) // 如果敌方英雄被治疗
                        {
                            mnn.handcard.card.sim_card.onACharGotHealed(this, mnn, enemyHero.GotHealedValue);
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// 触发随从被治疗时的效果，遍历己方和敌方随从，执行相应的逻辑。
        /// </summary>
        public void triggerAMinionGotHealed()
        {
            int healedMinionsCount = this.tempTrigger.minionsGotHealed; // 获取触发的随从治疗次数
            this.tempTrigger.minionsGotHealed = 0; // 重置随从治疗触发计数

            // 处理己方随从的治疗触发效果
            foreach (Minion mnn in this.ownMinions.ToArray()) // 使用 ToArray 防止在遍历过程中修改集合
            {
                if (mnn.silenced) continue; // 如果随从被沉默，跳过处理

                // 根据随从的名称触发相应的治疗效果
                switch (mnn.handcard.card.nameEN)
                {
                    case CardDB.cardNameEN.northshirecleric: // 北郡牧师
                    case CardDB.cardNameEN.manageode: // 法力侏儒
                    case CardDB.cardNameEN.aiextra1:
                        mnn.handcard.card.sim_card.onAMinionGotHealedTrigger(this, mnn, healedMinionsCount);
                        break;
                }
            }

            // 处理敌方随从的治疗触发效果
            foreach (Minion mnn in this.enemyMinions.ToArray()) // 使用 ToArray 防止在遍历过程中修改集合
            {
                if (mnn.silenced) continue; // 如果随从被沉默，跳过处理

                // 根据随从的名称触发相应的治疗效果
                switch (mnn.handcard.card.nameEN)
                {
                    case CardDB.cardNameEN.northshirecleric: // 北郡牧师
                    case CardDB.cardNameEN.manageode: // 法力侏儒
                    case CardDB.cardNameEN.aiextra1:
                        mnn.handcard.card.sim_card.onAMinionGotHealedTrigger(this, mnn, healedMinionsCount);
                        break;
                }
            }
        }

        /// <summary>
        /// 触发随从或英雄受到伤害后的效果，遍历己方和敌方随从，并执行相应的逻辑。
        /// </summary>
        public void triggerAMinionGotDmg()
        {
            // 记录己方和敌方随从及英雄受到伤害的次数
            int anzOwnMinionsGotDmg = this.tempTrigger.ownMinionsGotDmg;
            int anzEnemyMinionsGotDmg = this.tempTrigger.enemyMinionsGotDmg;
            int anzOwnHeroGotDmg = this.tempTrigger.ownHeroGotDmg;
            int anzEnemyHeroGotDmg = this.tempTrigger.enemyHeroGotDmg;

            // 处理己方随从受到伤害后的效果
            foreach (Minion m in this.ownMinions.ToArray())
            {
                if (m.silenced)
                {
                    m.anzGotDmg = 0; // 如果随从被沉默，重置其受到伤害的计数
                    continue;
                }

                // 触发随从的受到伤害效果
                m.handcard.card.sim_card.onMinionGotDmgTrigger(this, m, anzOwnMinionsGotDmg, anzEnemyMinionsGotDmg, anzOwnHeroGotDmg, anzEnemyHeroGotDmg);

                // 重置随从的伤害相关计数器
                m.anzGotDmg = 0;
                m.GotDmgValue = 0;
            }

            // 处理敌方随从受到伤害后的效果
            foreach (Minion m in this.enemyMinions.ToArray())
            {
                if (m.silenced)
                {
                    m.anzGotDmg = 0; // 如果随从被沉默，重置其受到伤害的计数
                    continue;
                }

                // 触发随从的受到伤害效果
                m.handcard.card.sim_card.onMinionGotDmgTrigger(this, m, anzOwnMinionsGotDmg, anzEnemyMinionsGotDmg, anzOwnHeroGotDmg, anzEnemyHeroGotDmg);

                // 重置随从的伤害相关计数器
                m.anzGotDmg = 0;
                m.GotDmgValue = 0;
            }

            // 重置英雄的伤害相关计数器
            this.ownHero.anzGotDmg = 0;
            this.enemyHero.anzGotDmg = 0;

            this.tempTrigger.ownMinionsGotDmg = 0;
            this.tempTrigger.enemyMinionsGotDmg = 0;
            this.tempTrigger.ownHeroGotDmg = 0;
            this.tempTrigger.enemyHeroGotDmg = 0;
        }

        /// <summary>
        /// 处理随从失去圣盾后的触发效果，遍历己方和敌方随从，并执行相应的逻辑。
        /// </summary>
        public void triggerAMinionLosesDivineShield()
        {
            int anzOwn = this.tempTrigger.ownMinionLosesDivineShield; // 记录己方随从失去圣盾的次数
            int anzEnemy = this.tempTrigger.enemyMinionLosesDivineShield; // 记录敌方随从失去圣盾的次数
            this.tempTrigger.ownMinionLosesDivineShield = 0; // 重置己方随从失去圣盾的计数器
            this.tempTrigger.enemyMinionLosesDivineShield = 0; // 重置敌方随从失去圣盾的计数器

            // 处理己方随从失去圣盾的效果
            if (anzOwn > 0)
            {
                foreach (Minion m in this.ownMinions.ToArray())
                {
                    if (m.silenced) continue; // 如果随从被沉默，跳过处理
                    m.handcard.card.sim_card.onMinionLosesDivineShield(this, m, anzOwn); // 触发随从失去圣盾后的效果
                }

                // 检查己方武器是否为 "光之悲伤" 并增加其攻击力
                if (this.ownWeapon.name == CardDB.cardNameEN.lightssorrow)
                {
                    this.ownWeapon.Angr += anzOwn;
                }

                // 检查己方武器是否为 "棱彩珠宝包" 并触发其效果
                if (this.ownWeapon.name == CardDB.cardNameEN.prismaticjewelkit)
                {
                    this.ownWeapon.card.sim_card.onMinionLosesDivineShield(this, new Minion(), anzOwn);
                }
            }

            // 处理敌方随从失去圣盾的效果
            if (anzEnemy > 0)
            {
                foreach (Minion m in this.enemyMinions.ToArray())
                {
                    if (m.silenced) continue; // 如果随从被沉默，跳过处理
                    m.handcard.card.sim_card.onMinionLosesDivineShield(this, m, anzEnemy); // 触发随从失去圣盾后的效果
                }

                // 检查敌方武器是否为 "光之悲伤" 并增加其攻击力
                if (this.enemyWeapon.name == CardDB.cardNameEN.lightssorrow)
                {
                    this.enemyWeapon.Angr += anzEnemy;
                }
            }
        }

        /// <summary>
        /// 触发随从死亡后的效果，处理己方和敌方随从的死亡触发器，并执行相应的逻辑。
        /// </summary>
        public void triggerAMinionDied()
        {
            // 更新当前回合己方和敌方随从的死亡计数
            this.ownMinionsDiedTurn += this.tempTrigger.ownMinionsDied;
            this.enemyMinionsDiedTurn += this.tempTrigger.enemyMinionsDied;

            // 处理己方随从的死亡触发效果
            TriggerMinionDiedEffects(this.ownMinions);

            // 处理敌方随从的死亡触发效果
            TriggerMinionDiedEffects(this.enemyMinions);

            // // 处理己方手牌中 "伯瓦尔·弗塔根" 的攻击力增加效果
            // foreach (Handmanager.Handcard hc in this.owncards)
            // {
            //     if (hc.card.nameEN == CardDB.cardNameEN.bolvarfordragon_GVG_063)
            //     {
            //         hc.addattack += this.tempTrigger.ownMinionsDied; // 每死亡一个己方随从，攻击力增加
            //     }
            // }

            // 处理己方和敌方武器 "鲨鱼之颚" 的攻击力增加效果
            // HandleWeaponEffectOnMinionDeath(this.ownWeapon, true);
            // HandleWeaponEffectOnMinionDeath(this.enemyWeapon, false);

            // 处理英雄技能 "死者复生" 的召唤效果
            // HandleHeroAbilitySummon(this.ownHeroAblility, this.tempTrigger.enemyMinionsDied, true);
            // HandleHeroAbilitySummon(this.enemyHeroAblility, this.tempTrigger.ownMinionsDied, false);

            // 处理注能卡牌
            if (this.ownMinions.Any(m => m.handcard.card.cardIDenum == CardDB.cardIDEnum.MAW_031))
            {
                InfuseDeckCards();
            }
            else
            {
                InfuseHandCards();
            }
        }

        /// <summary>
        /// 处理随从的死亡触发效果
        /// </summary>
        /// <param name="minions">场上的随从列表（己方或敌方）</param>
        private void TriggerMinionDiedEffects(List<Minion> minions)
        {
            foreach (Minion m in minions.ToArray())
            {
                if (m.silenced || m.Hp > 0) continue; // 如果随从被沉默或未死亡，跳过处理
                m.handcard.card.sim_card.onMinionDiedTrigger(this, m, m); // 触发随从的死亡效果
            }
        }

        /// <summary>
        /// 处理英雄技能 "死者复生" 的召唤效果
        /// </summary>
        /// <param name="ability">英雄技能对应的卡牌</param>
        /// <param name="minionsDied">触发技能的随从死亡数量</param>
        /// <param name="isOwn">是否为己方英雄技能</param>
        private void HandleHeroAbilitySummon(Handmanager.Handcard ability, int minionsDied, bool isOwn)
        {
            if (ability.card.nameEN == CardDB.cardNameEN.raisedead && minionsDied > 0)
            {
                CardDB.Card kid = CardDB.Instance.getCardDataFromID(
                    (ability.card.cardIDenum == CardDB.cardIDEnum.NAX4_04H) ?
                    CardDB.cardIDEnum.NAX4_03H :
                    CardDB.cardIDEnum.NAX4_03
                );
                for (int i = 0; i < minionsDied; i++)
                {
                    this.callKid(kid, isOwn ? this.ownMinions.Count : this.enemyMinions.Count, isOwn); // 召唤对应的随从
                }
            }
        }

        /// <summary>
        /// 注能己方牌库中的卡牌
        /// </summary>
        private void InfuseDeckCards()
        {
            foreach (CardDB.Card item in this.ownDeck)
            {
                if (item.Infuse && !item.Infused)
                {
                    Handmanager.Handcard hc = new Handmanager.Handcard(item);
                    InfuseCard(hc); // 对卡牌进行注能处理
                }
            }
        }

        /// <summary>
        /// 注能己方手牌中的卡牌
        /// </summary>
        private void InfuseHandCards()
        {
            foreach (Handmanager.Handcard hc in this.owncards)
            {
                if (hc.card.Infuse && !hc.card.Infused)
                {
                    InfuseCard(hc); // 对卡牌进行注能处理
                }
            }
        }

        /// <summary>
        /// 处理单张手牌的注能逻辑
        /// </summary>
        /// <param name="hc">需要注能的手牌</param>
        private void InfuseCard(Handmanager.Handcard hc)
        {
            // 累计注能值
            hc.SCRIPT_DATA_NUM_1 += 1;

            if (hc.SCRIPT_DATA_NUM_1 >= hc.card.InfuseNum)
            {
                // 重置注能值
                hc.SCRIPT_DATA_NUM_1 = 0;

                // 特殊处理德纳修斯大帝和猎手阿尔迪莫
                if (hc.card.cardIDenum != CardDB.cardIDEnum.REV_906 && hc.card.cardIDenum != CardDB.cardIDEnum.REV_906t &&
                    hc.card.cardIDenum != CardDB.cardIDEnum.REV_353 && hc.card.cardIDenum != CardDB.cardIDEnum.REV_353t && hc.card.cardIDenum != CardDB.cardIDEnum.REV_353t2)
                {
                    // 升级卡牌并标记为已注能
                    hc.card = CardDB.Instance.getCardDataFromID(CardDB.Instance.cardIdstringToEnum(hc.card.cardIDenum.ToString() + "t"));
                    hc.card.Infused = true;
                }
                else if (hc.card.cardIDenum == CardDB.cardIDEnum.REV_906)
                {
                    hc.card = CardDB.Instance.getCardDataFromID(CardDB.Instance.cardIdstringToEnum(hc.card.cardIDenum.ToString() + "t"));
                }
                else if (hc.card.cardIDenum == CardDB.cardIDEnum.REV_906t)
                {
                    hc.card.TAG_SCRIPT_DATA_NUM_2++; // 无限注能，伤害增加1点
                }
                else if (hc.card.cardIDenum == CardDB.cardIDEnum.REV_353)
                {
                    hc.card = CardDB.Instance.getCardDataFromID(CardDB.Instance.cardIdstringToEnum(hc.card.cardIDenum.ToString() + "t"));
                }
                else if (hc.card.cardIDenum == CardDB.cardIDEnum.REV_353t)
                {
                    hc.card = CardDB.Instance.getCardDataFromID(CardDB.Instance.cardIdstringToEnum(hc.card.cardIDenum.ToString() + "t2"));
                    hc.card.Infused = true; // 标记为已注能
                }
            }
        }

        /// <summary>
        /// 处理武器在随从死亡时的效果，主要针对 "巨颚" 的攻击力增加。
        /// </summary>
        /// <param name="weapon">要处理的武器。</param>
        /// <param name="own">标识武器是否为己方。</param>
        private void HandleWeaponEffectOnMinionDeath(Weapon weapon, bool own)
        {
            if (weapon.name == CardDB.cardNameEN.jaws)
            {
                int bonus = 0;

                // 计算己方和敌方已死亡且具有亡语的随从数
                foreach (Minion m in this.ownMinions)
                {
                    if (m.Hp < 1 && m.handcard.card.deathrattle && !m.silenced) bonus++;
                }
                foreach (Minion m in this.enemyMinions)
                {
                    if (m.Hp < 1 && m.handcard.card.deathrattle && !m.silenced) bonus++;
                }

                // 增加武器的攻击力
                weapon.Angr += bonus * 2;
            }
        }


        /// <summary>
        /// 触发随从即将攻击前的效果，根据随从的类型和附加的效果执行相应的逻辑。
        /// </summary>
        /// <param name="attacker">即将攻击的随从。</param>
        /// <param name="target">攻击的目标。</param>
        public void triggerAMinionIsGoingToAttack(Minion attacker, Minion target)
        {
            if (!attacker.silenced)

                //调用随从攻击时的sim方法
                attacker.handcard.card.sim_card.onMinionAttack(this, attacker, target);
            // // 根据随从的名称触发特定效果
            // switch (attacker.name)
            // {
            //     case CardDB.cardNameEN.cutpurse: // "潜行者"：如果攻击英雄，抽取一张"硬币"卡
            //         if (target.isHero)
            //             this.drawACard(CardDB.cardNameEN.thecoin, attacker.own, true);
            //         break;

            //     case CardDB.cardNameEN.wretchedtiller: // "卑劣的农夫"：如果攻击英雄，对敌方英雄造成2点伤害
            //         if (target.isHero)
            //             minionGetDamageOrHeal(attacker.own ? this.enemyHero : this.ownHero, 2);
            //         break;

            //     case CardDB.cardNameEN.shakuthecollector: // "收集者沙库"：攻击时随机抽一张牌
            //         this.drawACard(CardDB.cardNameEN.unknown, attacker.own, true);
            //         break;

            //     case CardDB.cardNameEN.genzotheshark: // "鲨鱼仁佐"：双方玩家的手牌数补充到3张
            //         while (this.owncards.Count < 3 && this.ownDeckSize > 0)
            //         {
            //             this.drawACard(CardDB.cardNameEN.unknown, true, true);
            //         }
            //         while (this.enemyAnzCards < 3 && this.enemyDeckSize > 0)
            //         {
            //             this.drawACard(CardDB.cardNameEN.unknown, false, true);
            //         }
            //         break;

            //     case CardDB.cardNameEN.carielroame: // "凯瑞尔·罗姆"：攻击时己方手牌中的神圣法术法力值减少1点
            //         foreach (Handmanager.Handcard hc in this.owncards)
            //         {
            //             if (hc.card.SpellSchool == CardDB.SpellSchool.HOLY)
            //             {
            //                 hc.manacost--;
            //                 //this.evaluatePenality -= 5; // TODO: 这里可能需要调整评分
            //             }
            //         }
            //         break;
            // }

            // 处理随从上附加的智慧祝福效果：每次攻击时抽取一张牌
            if (attacker.ownBlessingOfWisdom >= 1)
            {
                for (int i = 0; i < attacker.ownBlessingOfWisdom; i++)
                {
                    this.drawACard(CardDB.cardNameEN.unknown, true);
                }
            }
            if (attacker.enemyBlessingOfWisdom >= 1)
            {
                for (int i = 0; i < attacker.enemyBlessingOfWisdom; i++)
                {
                    this.drawACard(CardDB.cardNameEN.unknown, false);
                }
            }

            // 处理随从上附加的真言术：耀效果：每次攻击时为英雄恢复4点生命值
            if (attacker.ownPowerWordGlory >= 1)
            {
                int heal = this.getMinionHeal(4);
                for (int i = 0; i < attacker.ownPowerWordGlory; i++)
                {
                    this.minionGetDamageOrHeal(this.ownHero, -heal);
                }
            }
            if (attacker.enemyPowerWordGlory >= 1)
            {
                int heal = this.getEnemyMinionHeal(4);
                for (int i = 0; i < attacker.enemyPowerWordGlory; i++)
                {
                    this.minionGetDamageOrHeal(this.enemyHero, -heal);
                }
            }
        }

        /// <summary>
        /// 处理随从造成伤害后的触发效果。
        /// </summary>
        /// <param name="m">造成伤害的随从。</param>
        /// <param name="dmgDone">造成的伤害值。</param>
        /// <param name="isAttacker">是否是攻击者造成的伤害。</param>
        public void triggerAMinionDealedDmg(Minion m, int dmgDone, bool isAttacker)
        {
            // 仅有少数卡牌具有此触发效果
            m.handcard.card.sim_card.onDamageDealtByMinion(this, m, dmgDone, isAttacker);

            // 处理随从的吸血效果
            if (m.lifesteal && isAttacker && dmgDone > 0)
            {
                if (m.own)
                {
                    // 如果己方有奥金尼灵魂祭司或暗影之握效果，则吸血效果反转为伤害自己
                    if (this.anzOwnAuchenaiSoulpriest > 0 || this.embracetheshadow > 0)
                    {
                        dmgDone *= -1;
                    }
                    // 为己方英雄治疗等同于伤害值的生命值
                    this.minionGetDamageOrHeal(this.ownHero, -dmgDone);
                }
                else
                {
                    // 如果敌方有奥金尼灵魂祭司，则吸血效果反转为伤害敌方英雄
                    if (this.anzEnemyAuchenaiSoulpriest > 1)
                    {
                        dmgDone *= -1;
                    }
                    // 为敌方英雄治疗等同于伤害值的生命值
                    this.minionGetDamageOrHeal(this.enemyHero, -dmgDone);
                }
            }
        }

        /// <summary>
        /// 处理一张卡牌即将被打出的事件，根据场上的随从和武器触发相应的效果。
        /// </summary>
        /// <param name="hc">即将被打出的手牌。</param>
        /// <param name="own">标识是否为己方打出的卡牌。</param>
        public void triggerACardWillBePlayed(Handmanager.Handcard hc, bool own)
        {
            if (own)
            {
                // 处理特殊随从效果
                if (anzOwnDragonConsort > 0 && (TAG_RACE)hc.card.race == TAG_RACE.DRAGON) anzOwnDragonConsort = 0; // 龙族侍女效果
                if (ownBeastCostLessOnce > 0 && (TAG_RACE)hc.card.race == TAG_RACE.PET) ownBeastCostLessOnce = 0; // 野兽费用减免效果
                if (nextElementalReduction > 0 && (TAG_RACE)hc.card.race == TAG_RACE.ELEMENTAL) nextElementalReduction = 0; // 下一张元素随从牌的法力值消耗减少量
                if (thisTurnNextElementalReduction > 0 && (TAG_RACE)hc.card.race == TAG_RACE.ELEMENTAL) thisTurnNextElementalReduction = 0; // 本回合下一张元素费用减免效果

                int burly = 0;
                int ssm = 0;

                // 触发己方随从的效果
                foreach (Minion m in this.ownMinions.ToArray())
                {
                    if (!m.silenced)
                    {
                        m.handcard.card.sim_card.onCardIsGoingToBePlayed(this, hc, own, m);
                        // m.handcard.card.sim_card.onCardWasPlayed(this, hc.card, own, m);
                    }
                }

                // 触发敌方随从的效果
                foreach (Minion m in this.enemyMinions)
                {
                    if (m.name == CardDB.cardNameEN.troggzortheearthinator)
                    {
                        burly++;
                    }
                    // //敌方魔能机甲
                    // if (m.name == CardDB.cardNameEN.felreaver)
                    // {
                    //     m.handcard.card.sim_card.onCardIsGoingToBePlayed(this, hc, own, m);

                    // }
                    // // 处理敌方随从食人魔巫术师的效果
                    // if (m.handcard.card.nameCN == CardDB.cardNameCN.食人魔巫术师 && hc.card.type == CardDB.cardtype.SPELL)
                    // {
                    //     ssm++;
                    // }
                    m.handcard.card.sim_card.onCardIsGoingToBePlayed(this, hc, own, m);

                }

                // 处理腐蚀卡的效果
                List<Handmanager.Handcard> afterCorrput = new List<Handmanager.Handcard>();
                foreach (Handmanager.Handcard ohc in this.owncards)
                {
                    if (ohc.card.Corrupt && hc.manacost > ohc.manacost)
                    {
                        // 腐蚀卡的处理
                        ohc.card = CardDB.Instance.getCardDataFromID(CardDB.Instance.cardIdstringToEnum(ohc.card.cardIDenum.ToString() + "t"));
                        // if (ohc.card.nameCN == CardDB.cardNameCN.大力士)
                        // {
                        //     ohc.manacost = 0;
                        // }
                        afterCorrput.Add(ohc);
                        // this.evaluatePenality -= 5;
                    }
                }
                foreach (Handmanager.Handcard ohc in afterCorrput)
                {
                    this.removeCard(ohc);
                    this.drawACard(ohc.card.cardIDenum, true, true);
                    foreach (Handmanager.Handcard ahc in this.owncards)
                    {
                        if (ahc.card.cardIDenum == ohc.card.cardIDenum)
                        {
                            ahc.manacost = ohc.manacost;
                        }
                    }
                }

                // 处理己方英雄技能和武器的特殊效果
                // if (this.ownHeroAblility.card.nameEN == CardDB.cardNameEN.voidform)
                // {
                //     this.ownHeroAblility.card.sim_card.onCardIsGoingToBePlayed(this, hc, own, this.ownHeroAblility);
                //     // this.enemyHeroAblility.card.sim_card.onCardWasPlayed(this, hc.card, own, this.enemyHeroAblility);


                // }
                // if (this.ownWeapon.name == CardDB.cardNameEN.atiesh)
                // {
                //     this.callKid(this.getRandomCardForManaMinion(hc.manacost), this.ownMinions.Count, own);
                //     this.lowerWeaponDurability(1, own);
                // }

                // 触发敌方随从的召唤效果
                for (int i = 0; i < burly; i++)
                {
                    this.callKid(CardDB.Instance.burlyrockjaw, this.enemyMinions.Count, !own);
                }
                for (int i = 0; i < ssm; i++)
                {
                    this.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_710t), this.enemyMinions.Count, !own);
                    foreach (Minion m in this.enemyMinions)
                    {
                        if (m.handcard.card.cardIDenum == CardDB.cardIDEnum.SCH_710t)
                        {
                            m.taunt = true;
                            if (m.own) this.anzOwnTaunt++;
                            else this.anzEnemyTaunt++;
                        }
                    }
                }
            }
            else
            {
                // 处理敌方出牌时的特殊效果
                int burly = 0;
                foreach (Minion m in this.enemyMinions.ToArray())
                {
                    if (!m.silenced)
                    {
                        m.handcard.card.sim_card.onCardIsGoingToBePlayed(this, hc, own, m);
                        // m.handcard.card.sim_card.onCardWasPlayed(this, hc.card, own, m);

                    }
                }
                foreach (Minion m in this.ownMinions)
                {
                    if (m.name == CardDB.cardNameEN.troggzortheearthinator)
                    {
                        burly++;
                    }
                    //我方魔能机甲
                    if (m.name == CardDB.cardNameEN.felreaver)
                    {
                        m.handcard.card.sim_card.onCardIsGoingToBePlayed(this, hc, own, m);

                    }
                }

                // 处理敌方英雄技能和武器的特殊效果
                // if (this.enemyHeroAblility.card.nameEN == CardDB.cardNameEN.voidform)
                // {
                //     this.enemyHeroAblility.card.sim_card.onCardIsGoingToBePlayed(this, hc, own, this.enemyHeroAblility);
                //     // this.enemyHeroAblility.card.sim_card.onCardWasPlayed(this, hc.card, own, this.enemyHeroAblility);

                // }
                // if (this.enemyWeapon.name == CardDB.cardNameEN.atiesh)
                // {
                //     this.callKid(this.getRandomCardForManaMinion(hc.manacost), this.enemyMinions.Count, own);
                //     this.lowerWeaponDurability(1, own);
                // }

                // 触发己方随从的召唤效果
                for (int i = 0; i < burly; i++)
                {
                    this.callKid(CardDB.Instance.burlyrockjaw, this.ownMinions.Count, own);
                }
            }
        }

        /// <summary>
        /// 处理一个随从被召唤时的触发效果，根据随从所属的阵营分别处理己方或敌方的召唤事件。
        /// </summary>
        /// <param name="m">被召唤的随从。</param>
        public void triggerAMinionIsSummoned(Minion m)
        {
            // 判断随从是否为己方随从
            if (m.own)
            {
                // 遍历己方随从并触发对应的召唤事件
                foreach (Minion mnn in this.ownMinions.ToArray())
                {
                    // 如果随从被沉默，则跳过
                    if (mnn.silenced) continue;
                    // 调用随从卡牌的召唤触发方法
                    mnn.handcard.card.sim_card.onMinionIsSummoned(this, mnn, m);
                }
            }
            else
            {
                // 遍历敌方随从并触发对应的召唤事件
                foreach (Minion mnn in this.enemyMinions.ToArray())
                {
                    // 如果随从被沉默，则跳过
                    if (mnn.silenced) continue;
                    // 调用随从卡牌的召唤触发方法
                    mnn.handcard.card.sim_card.onMinionIsSummoned(this, mnn, m);
                }
            }
        }

        /// <summary>
        /// 处理随从被召唤后的触发效果，根据随从的阵营分别触发己方或敌方的事件。
        /// </summary>
        /// <param name="mnn">被召唤的随从。</param>
        public void triggerAMinionWasSummoned(Minion mnn)
        {
            if (mnn.own)
            {
                // 处理己方任务的随从召唤触发效果
                if (this.ownQuest.Id != CardDB.cardIDEnum.None)
                {
                    this.ownQuest.trigger_MinionWasSummoned(mnn);
                }

                // 如果召唤的随从具有嘲讽属性，则增加己方嘲讽随从计数
                if (mnn.taunt)
                {
                    anzOwnTaunt++;
                }

                // 如果己方英雄能力为洛瑟玛的力量，并且召唤的是银色黎明新兵，则为其添加圣盾
                if (this.LothraxionsPower && mnn.name == CardDB.cardNameEN.silverhandrecruit)
                {
                    mnn.divineshild = true;
                }

                // 遍历己方随从，触发每个随从的“随从被召唤”效果
                foreach (Minion m in this.ownMinions.ToArray())
                {
                    // 跳过被沉默的随从和刚刚被召唤的随从自身
                    if (m.silenced || m.entitiyID == mnn.entitiyID) continue;
                    // 触发随从的 onMinionWasSummoned 事件
                    m.handcard.card.sim_card.onMinionWasSummoned(this, m, mnn);
                }

                // 如果己方装备了正义之剑，则为召唤的随从添加 +1/+1 并降低武器耐久度
                switch (this.ownWeapon.name)
                {
                    case CardDB.cardNameEN.swordofjustice:
                        this.minionGetBuffed(mnn, 1, 1);
                        this.lowerWeaponDurability(1, true);
                        break;
                }
            }
            else
            {
                // 处理敌方任务的随从召唤触发效果
                if (this.enemyQuest.Id != CardDB.cardIDEnum.None)
                {
                    this.enemyQuest.trigger_MinionWasSummoned(mnn);
                }

                // 如果召唤的随从具有嘲讽属性，则增加敌方嘲讽随从计数
                if (mnn.taunt)
                {
                    anzEnemyTaunt++;
                }

                // 遍历敌方随从，触发每个随从的“随从被召唤”效果
                foreach (Minion m in this.enemyMinions.ToArray())
                {
                    // 跳过被沉默的随从和刚刚被召唤的随从自身
                    if (m.silenced || m.entitiyID == mnn.entitiyID) continue;
                    // 触发随从的 onMinionWasSummoned 事件
                    m.handcard.card.sim_card.onMinionWasSummoned(this, m, mnn);
                }

                // 如果敌方装备了正义之剑，则为召唤的随从添加 +1/+1 并降低武器耐久度
                switch (this.enemyWeapon.name)
                {
                    case CardDB.cardNameEN.swordofjustice:
                        this.minionGetBuffed(mnn, 1, 1);
                        this.lowerWeaponDurability(1, false);
                        break;
                }
            }
        }

        /// <summary>
        /// 处理回合结束时的所有相关逻辑，包括随从效果触发、特殊状态重置等。
        /// </summary>
        /// <param name="ownturn">指示当前回合是否为己方回合。如果为 true，则表示是己方回合结束，否则为敌方回合结束。</param>
        public void triggerEndTurn(bool ownturn)
        {
            // 处理己方随从的回合结束效果，包括双重触发和随从销毁逻辑
            HandleEndTurnForMinions(this.ownMinions, ownturn, true, this.ownTurnEndEffectsTriggerTwice);

            // 处理敌方随从的回合结束效果，包括双重触发和随从销毁逻辑
            HandleEndTurnForMinions(this.enemyMinions, ownturn, false, this.enemyTurnEndEffectsTriggerTwice);

            // 处理己方手牌的回合结束效果
            HandleEndTurnForHandcard(this.owncards, ownturn, true);

            // 触发所有伤害触发器，如流血效果、火焰伤害等
            this.doDmgTriggers();

            // 处理暗影狂乱（Shadow Madness）效果，将受影响的随从归还给原控制者
            HandleShadowMadnessEffect(ownturn);

            // 重置本回合中特定卡牌效果的状态
            ResetSpecialCardEffects();

            // 移除所有随从的临时攻击力加成和免疫效果
            RemoveTemporaryBuffsAndImmunity(this.ownMinions);
            RemoveTemporaryBuffsAndImmunity(this.enemyMinions);

            //将回合结束时会返回到手牌的卡牌添加到手牌，如巅峰无限、甜筒殡淇淋、神性圣契
            HandlecardsToReturnAtEndOfTurn();
            removeTemporaryCards(ownturn);

            // 如果没有马尔加尼斯，移除英雄的免疫效果
            if (this.anzOwnMalGanis < 1) this.ownHero.immune = false;
            if (this.anzEnemyMalGanis < 1) this.enemyHero.immune = false;

            // 移除武器的免疫效果
            this.ownWeapon.immune = false;
            this.enemyWeapon.immune = false;
        }
        private void HandlecardsToReturnAtEndOfTurn()
        {
            if (this.cardsToReturnAtEndOfTurn.Count > 0)
            {
                foreach (CardDB.cardIDEnum cardIDEnum in this.cardsToReturnAtEndOfTurn.ToArray())
                {
                    this.drawACard(cardIDEnum, true, true);
                    this.cardsToReturnAtEndOfTurn.Remove(cardIDEnum);
                }
            }
        }

        private void HandleEndTurnForHandcard(List<Handmanager.Handcard> owncards, bool ownturn, bool v)
        {
            foreach (Handmanager.Handcard hc in owncards.ToArray())
            {
                hc.card.sim_card.onTurnEndsTrigger(this, hc, ownturn);
            }
        }

        private void HandleStartTurnForHandcard(List<Handmanager.Handcard> owncards, bool ownturn, bool v)
        {
            foreach (Handmanager.Handcard hc in owncards.ToArray())
            {
                hc.card.sim_card.onTurnStartTrigger(this, hc, ownturn);
            }
        }

        /// <summary>
        /// 处理随从的回合结束效果，包括双重触发效果和随从销毁逻辑。
        /// </summary>
        /// <param name="minions">随从列表，包括己方或敌方随从。</param>
        /// <param name="ownturn">当前回合是否为己方回合。</param>
        /// <param name="isOwnMinions">指示该随从列表是否为己方随从。</param>
        /// <param name="triggerTwice">指示是否需要双重触发回合结束效果。</param>
        private void HandleEndTurnForMinions(List<Minion> minions, bool ownturn, bool isOwnMinions, int triggerTwice)
        {
            // 遍历当前所有随从
            foreach (Minion m in minions.ToArray())
            {
                // 重置随从的不能攻击英雄状态
                m.cantAttackHeroes = false;

                // 如果随从未被沉默，则触发回合结束效果
                if (!m.silenced)
                {
                    // 根据条件确定触发效果的次数
                    int triggers = (isOwnMinions == ownturn) ? 1 + triggerTwice : 1;

                    // 触发指定次数的回合结束效果
                    for (int i = 0; i < triggers; i++)
                    {
                        m.handcard.card.sim_card.onTurnEndsTrigger(this, m, ownturn);
                    }
                }

                // 判断随从是否在回合结束时被销毁
                if ((isOwnMinions && ownturn && m.destroyOnOwnTurnEnd) ||
                    (!isOwnMinions && !ownturn && m.destroyOnEnemyTurnEnd))
                {
                    // 销毁该随从
                    this.minionGetDestroyed(m);
                }
            }
        }

        /// <summary>
        /// 处理暗影狂乱效果，归还受影响的随从给原控制者。
        /// </summary>
        /// <param name="ownturn">当前回合是否为己方回合。</param>
        private void HandleShadowMadnessEffect(bool ownturn)
        {
            // 如果有随从受到暗影狂乱影响
            if (this.shadowmadnessed >= 1)
            {
                // 根据当前回合选择己方或敌方随从列表
                List<Minion> ownm = (ownturn) ? this.ownMinions : this.enemyMinions;

                // 遍历受到暗影狂乱影响的随从
                foreach (Minion m in ownm.ToArray())
                {
                    if (m.shadowmadnessed)
                    {
                        // 取消暗影狂乱效果
                        m.shadowmadnessed = false;

                        // 将随从控制权归还给原控制者
                        this.minionGetControlled(m, !m.own, false);
                    }
                }

                // 重置暗影狂乱的影响计数
                this.shadowmadnessed = 0;

                // 更新场面状态
                updateBoards();
            }
        }

        /// <summary>
        /// 重置特定卡牌效果的状态，这些效果只在本回合有效。
        /// </summary>
        private void ResetSpecialCardEffects()
        {
            // 重置本回合内的秘密法术费用、下一个法术费用等状态
            this.nextSecretThisTurnCost0 = false;
            this.nextSpellThisTurnCost0 = false;
            this.nextMurlocThisTurnCostHealth = false;
            this.nextSpellThisTurnCostHealth = false;
            this.nextAnyCardThisTurnCostEnemyHealth = false;

            // 重置其他特殊效果状态
            this.lockandload = 0;
            this.stampede = 0;
            this.embracetheshadow = 0;
            this.playedPreparation = false;
        }

        /// <summary>
        /// 移除所有随从的临时攻击力加成和免疫效果，并重置随从的某些特殊状态。
        /// </summary>
        /// <param name="minions">随从列表。</param>
        private void RemoveTemporaryBuffsAndImmunity(List<Minion> minions)
        {
            // 遍历每个随从，移除临时攻击加成和免疫效果
            foreach (Minion m in minions)
            {
                // 移除临时攻击加成
                this.minionGetTempBuff(m, -m.tempAttack, 0);

                // 移除随从的免疫效果
                m.immune = false;

                // 重置随从的血量不能降至1点以下的状态
                m.cantLowerHPbelowONE = false;
            }
        }

        /// <summary>
        /// 处理回合开始时的触发效果，根据是己方回合还是敌方回合分别进行处理。
        /// </summary>
        /// <param name="ownturn">是否为己方回合。</param>
        public void triggerStartTurn(bool ownturn)
        {
            // 重置死亡随从列表和回合内死亡随从计数
            if (this.diedMinions != null)
            {
                this.ownMinionsDiedTurn = 0;
                this.enemyMinionsDiedTurn = 0;
                if (!this.print) this.diedMinions.Clear(); // 仅包含本回合内死亡的随从
            }

            // 处理己方或敌方随从
            List<Minion> ownm = (ownturn) ? this.ownMinions : this.enemyMinions;
            foreach (Minion m in ownm.ToArray())
            {
                // 更新随从状态
                m.playedPrevTurn = m.playedThisTurn;
                m.playedThisTurn = false;
                m.numAttacksThisTurn = 0;
                m.justBuffed = 0;
                m.updateReadyness();

                // 处理随从苏醒效果（休眠结束）
                if (m.dormant > 0 && ownturn == m.own)
                {
                    m.dormant--;
                    if (m.dormant == 0)
                    {
                        m.handcard.card.sim_card.onDormantEndsTrigger(this, m);
                    }
                }

                // 处理潜行状态的取消
                if (m.conceal)
                {
                    m.conceal = false;
                    m.stealth = false;
                }

                // 触发随从的回合开始效果（非沉默状态）
                if (!m.silenced)
                {
                    m.handcard.card.sim_card.onTurnStartTrigger(this, m, ownturn);
                }

                // 处理随从在己方或敌方回合开始时被摧毁
                if (ownturn && m.destroyOnOwnTurnStart) this.minionGetDestroyed(m);
                if (!ownturn && m.destroyOnEnemyTurnStart) this.minionGetDestroyed(m);
            }

            // 处理敌方或己方随从
            List<Minion> enemm = (ownturn) ? this.enemyMinions : this.ownMinions;
            foreach (Minion m in enemm.ToArray())
            {
                m.frozen = false;
                m.justBuffed = 0;

                // 触发随从的回合开始效果（非沉默状态）
                if (!m.silenced)
                {
                    m.handcard.card.sim_card.onTurnStartTrigger(this, m, ownturn);
                }

                // 处理随从在己方或敌方回合开始时被摧毁
                if (ownturn && m.destroyOnOwnTurnStart) this.minionGetDestroyed(m);
                if (!ownturn && m.destroyOnEnemyTurnStart) this.minionGetDestroyed(m);

                // 处理随从在回合开始时改变控制权
                if (m.changeOwnerOnTurnStart)
                {
                    this.minionGetControlled(m, ownturn, true);
                }
            }

            // 处理英雄和英雄技能的状态
            Minion hero = ownturn ? this.ownHero : this.enemyHero;
            Handmanager.Handcard heroAblility = ownturn ? this.ownHeroAblility : this.enemyHeroAblility;

            // 取消英雄的潜行状态
            if (hero.conceal)
            {
                hero.conceal = false;
                hero.stealth = false;
            }

            // 触发英雄技能的回合开始效果

            heroAblility.card.sim_card.onTurnStartTrigger(this, heroAblility, ownturn);

            HandleStartTurnForHandcard(this.owncards, ownturn, true);

            // 处理回合开始的常规效果
            this.doDmgTriggers();
            this.drawACard(CardDB.cardNameEN.unknown, ownturn);
            this.doDmgTriggers();

            // 重置回合相关的计数器和标志位
            this.cardsPlayedThisTurn = 0;
            this.mobsplayedThisTurn = 0;
            this.nextSecretThisTurnCost0 = false;
            this.nextSpellThisTurnCost0 = false;
            this.nextMurlocThisTurnCostHealth = false;
            this.nextSpellThisTurnCostHealth = false;
            this.nextAnyCardThisTurnCostEnemyHealth = false;
            this.optionsPlayedThisTurn = 0;
            this.enemyOptionsDoneThisTurn = 0;
            this.anzUsedOwnHeroPower = 0;
            this.anzUsedEnemyHeroPower = 0;

            // 根据回合调整法力值和英雄状态
            if (ownturn)
            {
                this.ownMaxMana = Math.Min(10, this.ownMaxMana + 1);
                this.mana = this.ownMaxMana - this.ueberladung;
                this.lockedMana = this.ueberladung;
                this.ueberladung = 0;

                this.enemyHero.frozen = false;
                this.ownHero.Angr = this.ownWeapon.Angr;
                this.ownHero.numAttacksThisTurn = 0;
                this.ownAbilityReady = true;
                this.ownHero.updateReadyness();
                this.owncarddraw = 0;
            }
            else
            {
                this.enemyMaxMana = Math.Min(10, this.enemyMaxMana + 1);
                this.mana = this.enemyMaxMana;
                this.ownHero.frozen = false;
                this.enemyHero.Angr = this.enemyWeapon.Angr;
                this.enemyHero.numAttacksThisTurn = 0;
                this.enemyAbilityReady = true;
                this.enemyHero.updateReadyness();
            }

            // 重置回合状态
            this.complete = false;
            this.value = int.MinValue;
        }

        /// <summary>
        /// 当英雄获得护甲时触发的效果。
        /// </summary>
        /// <param name="ownHero">是否为己方英雄。</param>
        public void triggerAHeroGotArmor(bool ownHero, int armor)
        {
            // 获取当前操作的随从列表，根据是己方英雄还是敌方英雄选择相应的随从列表
            List<Minion> minions = ownHero ? this.ownMinions : this.enemyMinions;

            // 遍历随从列表，检查是否存在重型攻城战车，并触发相应效果
            foreach (Minion m in minions)
            {
                if (!m.silenced)
                    m.handcard.card.sim_card.onHeroGetArmor(this, m, ownHero, armor);
                // 如果随从是重型攻城战车并且未被沉默
                // if (m.name == CardDB.cardNameEN.siegeengine && !m.silenced)
                // {
                //     // 重型攻城战车获得+1攻击力
                //     this.minionGetBuffed(m, 1, 0);
                // }
            }
        }

        /// <summary>
        /// 触发卡牌数量变化的相关效果。
        /// </summary>
        /// <param name="own">是否为己方卡牌变化。</param>
        public void triggerCardsChanged(bool own)
        {
            // 定义当前玩家的随从列表和卡牌数量变量，根据是否为己方变化进行选择
            List<Minion> minions = own ? this.enemyMinions : this.ownMinions;
            int currentCards = own ? this.owncards.Count : this.enemyAnzCards;
            int previousCards = own ? this.tempanzOwnCards : this.tempanzEnemyCards;

            /*
            // 如果手牌从大于等于6张变为少于6张
            if (previousCards >= 6 && currentCards <= 5)
            {
                // 遍历敌方随从，检查是否存在地精工兵，并减少其攻击力
                foreach (Minion m in minions)
                {
                    if (m.name == CardDB.cardNameEN.goblinsapper && !m.silenced)
                    {
                        this.minionGetBuffed(m, -4, 0);
                    }
                }
            }
            // 如果手牌从少于6张变为大于等于6张
            else if (currentCards >= 6 && previousCards <= 5)
            {
                // 遍历敌方随从，检查是否存在地精工兵，并增加其攻击力
                foreach (Minion m in minions)
                {
                    if (m.name == CardDB.cardNameEN.goblinsapper && !m.silenced)
                    {
                        this.minionGetBuffed(m, 4, 0);
                    }
                }
            }
            */

            // 更新临时卡牌数量变量
            if (own)
            {
                this.tempanzOwnCards = currentCards;

                // 符文秘银杖效果：如果累计使用了4张卡牌，则降低所有手牌法力值消耗
                if (this.ownWeapon.card.nameCN == CardDB.cardNameCN.符文秘银杖 && this.ownWeapon.scriptNum1 >= 4)
                {
                    foreach (Handmanager.Handcard hc in this.owncards)
                    {
                        hc.manacost--;
                        this.evaluatePenality -= 3; // 降低惩罚值
                    }
                    this.ownWeapon.scriptNum1 = 0; // 重置计数器
                }
            }
            else
            {
                this.tempanzEnemyCards = currentCards;
            }
        }

        /// <summary>
        /// 触发随从的激励效果。
        /// </summary>
        /// <param name="ownturn">是否为己方回合。</param>
        public void triggerInspire(bool ownturn)
        {
            // 获取己方和敌方的随从列表
            List<Minion> ownMinions = this.ownMinions.ToArray().ToList();
            List<Minion> enemyMinions = this.enemyMinions.ToArray().ToList();

            // 触发己方随从的激励效果
            foreach (Minion m in ownMinions)
            {
                if (!m.silenced) // 如果随从未被沉默
                {
                    m.handcard.card.sim_card.onInspire(this, m, ownturn);
                }
            }

            // 触发敌方随从的激励效果
            foreach (Minion m in enemyMinions)
            {
                if (!m.silenced) // 如果随从未被沉默
                {
                    m.handcard.card.sim_card.onInspire(this, m, ownturn);
                }
            }
        }

        /// <summary>
        /// 合并多个 SecretItem 对象，返回一个包含所有可能性的 SecretItem 对象。
        /// </summary>
        /// <param name="esl">敌方秘密列表。</param>
        /// <returns>合并后的 SecretItem 对象，如果列表为空则返回 null。</returns>
        private SecretItem getMergedSecretItem(List<SecretItem> esl)
        {
            if (esl == null || esl.Count == 0)
            {
                return null; // 如果列表为空或为 null，则返回 null
            }

            if (esl.Count == 1)
            {
                return esl[0]; // 如果列表中只有一个秘密，直接返回它
            }

            // 创建一个新的 BitArray，大小为 60，初始值为 false
            BitArray mergedData = new BitArray(60, false);

            // 遍历所有 SecretItem，将它们的位数据合并到 mergedData 中
            foreach (SecretItem si in esl)
            {
                mergedData.Or(SecretItem.secretItemToData(si)); // 使用按位或运算符合并位数据
            }

            // 将合并后的位数据转换回 SecretItem 对象并返回
            return SecretItem.dataToSecretItem(mergedData);
        }

        /// <summary>
        /// 处理当角色被攻击时可能触发的敌方奥秘，返回新目标的实体 ID（如果奥秘改变了目标）。
        /// </summary>
        /// <param name="attacker">攻击者。</param>
        /// <param name="defender">防御者。</param>
        /// <returns>新的攻击目标实体 ID，如果没有变化则返回 0。</returns>
        public int secretTrigger_CharIsAttacked(Minion attacker, Minion defender)
        {
            int newTarget = 0; // 用于存储如果奥秘改变攻击目标时的新目标实体 ID
            int triggered = 0; // 记录触发的奥秘数量

            if (this.isOwnTurn && this.enemySecretCount >= 1)
            {
                if (this.enemySecretList.Count == 0)
                {
                    Helpfunctions.Instance.logg("错误：敌方奥秘列表为空，但敌方奥秘数量是" + this.enemySecretCount);
                    if (this.enemyHeroName == HeroEnum.mage)
                    {
                        this.enemySecretList.Add(new SecretItem()); // 添加一个默认的 SecretItem 防止出错
                    }
                }

                if (defender.isHero && !defender.own) // 当防御者是敌方英雄
                {
                    foreach (SecretItem si in this.enemySecretList)
                    {
                        this.evaluatePenality += Ai.Instance.botBase.getSecretPen_CharIsAttacked(this, si, attacker, defender);
                        bool needDamageTrigger = false;

                        if (si.canBe_explosive)  // 爆炸陷阱
                        {
                            triggered++;
                            si.canBe_explosive = false;
                            needDamageTrigger = true;
                        }

                        if (si.canBe_beartrap)  // 熊陷阱
                        {
                            triggered++;
                            si.canBe_beartrap = false;
                            CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_060).sim_card.onSecretPlay(this, false, 0);
                            needDamageTrigger = true;
                        }

                        if (attacker != null && !attacker.isHero && si.canBe_vaporize)  // 气化
                        {
                            triggered++;
                            si.canBe_vaporize = false;
                            CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_594).sim_card.onSecretPlay(this, false, attacker, 0);
                            needDamageTrigger = true;
                        }

                        if (si.canBe_missdirection)  // 误导
                        {
                            if (!(attacker.isHero && this.ownMinions.Count + this.enemyMinions.Count == 0))
                            {
                                triggered++;
                                si.canBe_missdirection = false;
                                CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_533).sim_card.onSecretPlay(this, false, attacker, defender, out newTarget);
                            }
                        }

                        if (si.canBe_icebarrier)  // 冰甲
                        {
                            triggered++;
                            si.canBe_icebarrier = false;
                            CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_289).sim_card.onSecretPlay(this, false, defender, 0);
                        }

                        if (needDamageTrigger)
                        {
                            this.doDmgTriggers(); // 触发伤害后的效果
                        }
                    }
                }

                if (!defender.isHero && !defender.own) // 当防御者是敌方随从
                {
                    foreach (SecretItem si in this.enemySecretList)
                    {
                        if (si.canBe_snaketrap)  // 毒蛇陷阱
                        {
                            triggered++;
                            si.canBe_snaketrap = false;
                            CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_554).sim_card.onSecretPlay(this, false, 0);
                            this.doDmgTriggers();
                        }
                    }
                }

                if (attacker != null && !attacker.isHero && attacker.own) // 当攻击者是我方随从
                {
                    foreach (SecretItem si in this.enemySecretList)
                    {
                        if (si.canBe_freezing)  // 冰冻陷阱
                        {
                            triggered++;
                            si.canBe_freezing = false;
                            CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_611).sim_card.onSecretPlay(this, false, attacker, 0);
                        }
                    }
                }

                foreach (SecretItem si in this.enemySecretList)
                {
                    if (si.canBe_noblesacrifice)  // 英勇牺牲
                    {
                        triggered++;
                        si.canBe_noblesacrifice = false;
                    }
                }
            }

            return newTarget; // 返回新的攻击目标实体 ID
        }

        /// <summary>
        /// 当英雄受到伤害时，触发敌方奥秘。
        /// </summary>
        /// <param name="own">是否是我方英雄。</param>
        /// <param name="dmg">受到的伤害值。</param>
        public void secretTrigger_HeroGotDmg(bool own, int dmg)
        {
            int triggered = 0; // 记录触发的奥秘数量

            // 检查是否是敌方回合且有敌方奥秘存在
            if (own != this.isOwnTurn)
            {
                if (this.isOwnTurn && this.enemySecretCount >= 1)
                {
                    SecretItem si = getMergedSecretItem(this.enemySecretList);

                    // 添加策略的惩罚值
                    this.evaluatePenality += Ai.Instance.botBase.getSecretPen_HeroGotDmg(this, si, own, dmg);

                    // 复仇之眼 - 当英雄受到伤害时，对攻击者造成等量伤害
                    if (si.canBe_eyeforaneye)
                    {
                        triggered++;
                        foreach (SecretItem sii in this.enemySecretList)
                        {
                            sii.canBe_eyeforaneye = false;
                        }
                        CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_132).sim_card.onSecretPlay(this, false, dmg);
                    }

                    // 寒冰屏障 - 当英雄的生命值降到0或以下时，触发免死效果
                    if (si.canBe_iceblock && this.enemyHero.Hp <= 0)
                    {
                        triggered++;
                        foreach (SecretItem sii in this.enemySecretList)
                        {
                            sii.canBe_iceblock = false;
                        }
                        // 这里没有实际调用奥秘效果，只是将其标记为已触发
                        //CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_295).sim_card.onSecretPlay(this, false, this.enemyHero, dmg);
                    }
                }
            }

            // 第一个回合时减少触发奥秘的惩罚值（具体数值根据实际策略而定，暂时不启用）
            if (turnCounter == 0)
            {
                //this.evaluatePenality -= triggered * 50; // Todo:不引入打分
            }
        }

        /// <summary>
        /// 当一个随从被打出时，触发敌方的奥秘。
        /// </summary>
        /// <param name="playedMinion">被打出的随从。</param>
        public void secretTrigger_MinionIsPlayed(Minion playedMinion)
        {
            int triggered = 0; // 记录触发的奥秘数量

            // 检查是否是我方回合并且敌方有奥秘
            if (this.isOwnTurn && playedMinion.own && this.enemySecretCount >= 1)
            {
                SecretItem si = getMergedSecretItem(enemySecretList);

                // 添加策略的惩罚值
                this.evaluatePenality += Ai.Instance.botBase.getSecretPen_MinionIsPlayed(this, si, playedMinion);

                bool needDamageTrigger = false;

                // 魔镜实体 - 复制打出的随从
                if (si.canBe_mirrorentity)
                {
                    triggered++;
                    foreach (SecretItem sii in this.enemySecretList)
                    {
                        sii.canBe_mirrorentity = false;
                    }
                    CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_294).sim_card.onSecretPlay(this, false, playedMinion, 0);
                    needDamageTrigger = true;
                }

                // 悔改 - 将打出的随从的生命值降为1
                if (si.canBe_repentance)
                {
                    triggered++;
                    foreach (SecretItem sii in this.enemySecretList)
                    {
                        sii.canBe_repentance = false;
                    }
                    CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_379).sim_card.onSecretPlay(this, false, playedMinion, 0);
                }

                // 神圣试炼 - 当场上有超过3个随从时，摧毁新打出的随从
                if (si.canBe_sacredtrial && this.ownMinions.Count > 3)
                {
                    triggered++;
                    foreach (SecretItem sii in this.enemySecretList)
                    {
                        sii.canBe_sacredtrial = false;
                        sii.canBe_snipe = false; // 防止和狙击重叠
                    }
                    CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOE_027).sim_card.onSecretPlay(this, false, playedMinion, 0);
                    needDamageTrigger = true;
                }

                // 如果需要触发伤害事件，调用触发伤害的方法
                if (needDamageTrigger) doDmgTriggers();
            }

            // 第一个回合时减少触发奥秘的惩罚值（具体数值根据实际策略而定，暂时不启用）
            if (turnCounter == 0)
            {
                //this.evaluatePenality -= triggered * 50; //Todo: 不引入打分
            }
        }

        /// <summary>
        /// 当一个法术被施放时，触发敌方的奥秘。
        /// </summary>
        /// <param name="target">法术的目标随从。</param>
        /// <param name="c">被施放的法术。</param>
        /// <returns>返回新的目标实体ID，如果没有则返回0。</returns>
        public int secretTrigger_SpellIsPlayed(Minion target, CardDB.Card c)
        {
            int triggered = 0; // 记录触发的奥秘数量
            int retval = 0; // 新的目标实体ID

            // 检查是否是我方回合、法术牌、敌方有奥秘
            if (this.isOwnTurn && c.type == CardDB.cardtype.SPELL && this.enemySecretCount > 0)
            {
                SecretItem si = getMergedSecretItem(enemySecretList);

                // 添加策略的惩罚值
                this.evaluatePenality += Ai.Instance.botBase.getSecretPen_SpellIsPlayed(this, si, target, c);

                // 猫戏法 - 召唤一只4/2的猎豹
                if (si.canBe_cattrick)
                {
                    triggered++;
                    foreach (SecretItem sii in this.enemySecretList)
                    {
                        sii.canBe_cattrick = false;
                    }
                    CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_004).sim_card.onSecretPlay(this, false, 0);
                    doDmgTriggers();
                }

                // 扰咒术 - 使目标转移到一个新的随从
                if (si.canBe_spellbender && target != null && !target.isHero)
                {
                    triggered++;
                    foreach (SecretItem sii in this.enemySecretList)
                    {
                        sii.canBe_spellbender = false;
                    }
                    if (!(target.own && prozis.penman.maycauseharmDatabase.ContainsKey(c.nameEN)))
                    {
                        CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.tt_010).sim_card.onSecretPlay(this, false, null, target, out retval);
                    }
                }
            }

            // 在第一个回合时减少触发奥秘的惩罚值（具体数值根据实际策略而定，暂时不启用）
            if (turnCounter == 0)
            {
                //this.evaluatePenality -= triggered * 50; //Todo: 不引入打分
            }

            return retval; // 返回新的目标实体ID，如果没有则返回0
        }

        /// <summary>
        /// 当一个随从死亡时，触发敌方的奥秘。
        /// </summary>
        /// <param name="own">表示随从是否属于己方。</param>
        public void secretTrigger_MinionDied(bool own)
        {
            int triggered = 0; // 记录触发的奥秘数量

            // 检查是否是我方回合，且敌方有奥秘
            if (this.isOwnTurn && !own && this.enemySecretCount >= 1)
            {
                SecretItem si = getMergedSecretItem(enemySecretList);

                // 添加策略的惩罚值
                this.evaluatePenality += Ai.Instance.botBase.getSecretPen_MinionDied(this, si, own);

                // 重生奥秘：复制随从卡牌到对方手牌
                if (si.canBe_duplicate)
                {
                    triggered++;
                    foreach (SecretItem sii in this.enemySecretList)
                    {
                        sii.canBe_duplicate = false;
                    }
                    CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.FP1_018).sim_card.onSecretPlay(this, false, 0);
                }

                // 复生奥秘：将随从复活为1点生命值
                if (si.canBe_redemption)
                {
                    triggered++;
                    foreach (SecretItem sii in this.enemySecretList)
                    {
                        sii.canBe_redemption = false;
                    }
                    CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_136).sim_card.onSecretPlay(this, false, 0);
                }

                // 复仇奥秘：随机为另一个随从+3/+2
                if (si.canBe_avenge)
                {
                    triggered++;
                    foreach (SecretItem sii in this.enemySecretList)
                    {
                        sii.canBe_avenge = false;
                    }
                    CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.FP1_020).sim_card.onSecretPlay(this, false, 0);
                }
            }

            // 在第一个回合时减少触发奥秘的惩罚值（具体数值根据实际策略而定，暂时不启用）
            if (turnCounter == 0)
            {
                //this.evaluatePenality -= triggered * 50; //触发奥秘惩罚值 50 //Todo: 不引入打分
            }
        }

        /// <summary>
        /// 当英雄技能被使用时，触发敌方的奥秘。
        /// </summary>
        public void secretTrigger_HeroPowerUsed()
        {
            int triggered = 0; // 记录触发的奥秘数量

            // 检查是否为己方回合且敌方有奥秘
            if (this.isOwnTurn && this.enemySecretCount >= 1)
            {
                // 合并敌方所有奥秘为一个对象，便于统一处理
                SecretItem si = getMergedSecretItem(enemySecretList);

                // 添加策略的惩罚值
                this.evaluatePenality += Ai.Instance.botBase.getSecretPen_HeroPowerUsed(this, si);

                // 检查并处理飞镖陷阱奥秘
                if (si.canBe_darttrap)
                {
                    triggered++;
                    foreach (SecretItem sii in this.enemySecretList)
                    {
                        sii.canBe_darttrap = false; // 标记奥秘为不可再触发
                    }
                    // 执行飞镖陷阱的效果
                    CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOE_021).sim_card.onSecretPlay(this, false, 0);
                    doDmgTriggers(); // 触发可能的伤害效果
                }
            }

            // 在第一个回合时减少触发奥秘的惩罚值（具体数值根据实际策略而定，暂时不启用）
            if (turnCounter == 0)
            {
                //this.evaluatePenality -= triggered * 50; //Todo: 不引入打分
            }
        }

        /// <summary>
        /// 根据事件类型检测并返回可能触发的敌方奥秘数量。
        /// </summary>
        /// <param name="type">事件类型，0-随从被打出，1-法术被使用，2-角色被攻击，3-英雄受伤，4-随从死亡，5-英雄技能被使用。</param>
        /// <param name="actedMinionOwn">行动的随从是否为己方。</param>
        /// <param name="actedMinionIsHero">行动的随从是否为英雄。</param>
        /// <param name="target">目标随从。</param>
        /// <returns>可能触发的奥秘数量。</returns>
        public int getSecretTriggersByType(int type, bool actedMinionOwn, bool actedMinionIsHero, Minion target)
        {
            int triggered = 0;
            bool isSpell = false; // 是否为法术类型的事件

            switch (type)
            {
                case 0: // 随从被打出
                    if (this.isOwnTurn && actedMinionOwn && this.enemySecretCount >= 1)
                    {
                        bool canBe_mirrorentity = false;
                        bool canBe_repentance = false;
                        bool canBe_sacredtrial = false;
                        bool canBe_snipe = false;
                        foreach (SecretItem si in this.enemySecretList.ToArray())
                        {
                            if (si.canBe_mirrorentity && !canBe_mirrorentity) { canBe_mirrorentity = true; triggered++; }
                            if (si.canBe_repentance && !canBe_repentance) { canBe_repentance = true; triggered++; }
                            if (si.canBe_sacredtrial && this.ownMinions.Count > 3 && !canBe_sacredtrial) { canBe_sacredtrial = true; canBe_snipe = true; triggered++; }
                            else if (si.canBe_snipe && !canBe_snipe) { canBe_snipe = true; triggered++; }
                        }
                    }
                    break;

                case 1: // 法术被使用
                    if (this.isOwnTurn && isSpell && this.enemySecretCount >= 1)
                    {
                        bool canBe_counterspell = false;
                        bool canBe_spellbender = false;
                        bool canBe_cattrick = false;
                        foreach (SecretItem si in this.enemySecretList)
                        {
                            if (si.canBe_counterspell && !canBe_counterspell) return 1; // 如果是反制法术，直接返回1
                            if (si.canBe_spellbender && target != null && !target.isHero && !canBe_spellbender) { canBe_spellbender = true; triggered++; }
                            if (si.canBe_cattrick && !canBe_cattrick) { canBe_cattrick = true; triggered++; }
                        }
                    }
                    break;

                case 2: // 角色被攻击
                    if (this.isOwnTurn && this.enemySecretCount >= 1)
                    {
                        if (target.isHero && !target.own)
                        {
                            bool canBe_explosive = false;
                            bool canBe_flameward = false;
                            bool canBe_beartrap = false;
                            bool canBe_vaporize = false;
                            bool canBe_missdirection = false;
                            bool canBe_icebarrier = false;
                            foreach (SecretItem si in this.enemySecretList)
                            {
                                if (si.canBe_explosive && !canBe_explosive) { canBe_explosive = true; triggered++; }
                                if (si.canBe_flameward && !canBe_flameward) { canBe_flameward = true; triggered++; }
                                if (si.canBe_beartrap && !canBe_beartrap) { canBe_beartrap = true; triggered++; }
                                if (!actedMinionIsHero && si.canBe_vaporize && !canBe_vaporize) { canBe_vaporize = true; triggered++; }
                                if (si.canBe_missdirection && !canBe_missdirection)
                                {
                                    if (!(actedMinionIsHero && this.ownMinions.Count + this.enemyMinions.Count == 0))
                                    {
                                        canBe_missdirection = true; triggered++;
                                    }
                                }
                                if (si.canBe_icebarrier && !canBe_icebarrier) { canBe_icebarrier = true; triggered++; }
                            }
                        }

                        if (!target.isHero && !target.own)
                        {
                            bool canBe_snaketrap = false;
                            foreach (SecretItem si in this.enemySecretList)
                            {
                                if (si.canBe_snaketrap && !canBe_snaketrap) { canBe_snaketrap = true; triggered++; }
                            }
                        }

                        if (!actedMinionIsHero && actedMinionOwn) // 随从攻击
                        {
                            bool canBe_freezing = false;
                            foreach (SecretItem si in this.enemySecretList)
                            {
                                if (si.canBe_freezing && !canBe_freezing) { canBe_freezing = true; triggered++; }
                            }
                        }

                        bool canBe_noblesacrifice = false;
                        foreach (SecretItem si in this.enemySecretList)
                        {
                            if (si.canBe_noblesacrifice && !canBe_noblesacrifice) { canBe_noblesacrifice = true; triggered++; }
                        }
                    }
                    break;

                case 3: // 英雄受伤
                    if (target.own != this.isOwnTurn)
                    {
                        if (this.isOwnTurn && this.enemySecretCount >= 1)
                        {
                            bool canBe_eyeforaneye = false;
                            bool canBe_iceblock = false;
                            foreach (SecretItem si in this.enemySecretList)
                            {
                                if (si.canBe_eyeforaneye && !canBe_eyeforaneye) { canBe_eyeforaneye = true; triggered++; }
                                if (si.canBe_iceblock && this.enemyHero.Hp <= 0 && !canBe_iceblock) { canBe_iceblock = true; triggered++; }
                            }
                        }
                    }
                    break;

                case 4: // 随从死亡
                    if (this.isOwnTurn && !target.own && this.enemySecretCount >= 1)
                    {
                        bool canBe_duplicate = false;
                        bool canBe_redemption = false;
                        bool canBe_avenge = false;
                        foreach (SecretItem si in this.enemySecretList)
                        {
                            if (si.canBe_duplicate && !canBe_duplicate) { canBe_duplicate = true; triggered++; }
                            if (si.canBe_redemption && !canBe_redemption) { canBe_redemption = true; triggered++; }
                            if (si.canBe_avenge && !canBe_avenge) { canBe_avenge = true; triggered++; }
                        }
                    }
                    break;

                case 5: // 英雄技能被使用
                    if (this.isOwnTurn && this.enemySecretCount >= 1)
                    {
                        bool canBe_darttrap = false;
                        foreach (SecretItem si in this.enemySecretList)
                        {
                            if (si.canBe_darttrap && !canBe_darttrap) { canBe_darttrap = true; triggered++; }
                        }
                    }
                    break;
            }

            return triggered;
        }

        /// <summary>
        /// 处理一组随从的亡语效果。
        /// </summary>
        /// <param name="deathrattleMinions">触发亡语效果的随从列表。</param>
        public void doDeathrattles(List<Minion> deathrattleMinions)
        {
            // 遍历所有触发亡语的随从
            foreach (Minion m in deathrattleMinions)
            {
                // 如果随从未被沉默且拥有亡语效果，触发亡语
                if (!m.silenced && m.handcard.card.deathrattle)
                {
                    m.handcard.card.sim_card.onDeathrattle(this, m);
                }

                // 探险帽效果，增加手牌中的探险帽数量
                if (m.explorershat > 0)
                {
                    for (int i = 0; i < m.explorershat; i++)
                    {
                        drawACard(CardDB.cardNameEN.explorershat, m.own, true);
                    }
                }

                // 返回手牌效果，将该随从卡牌返回手牌
                if (m.returnToHand > 0)
                {
                    drawACard(m.handcard.card.cardIDenum, m.own, true);
                }

                // 感染效果，增加一张河爪豺狼人到手牌
                if (m.infest > 0)
                {
                    for (int i = 0; i < m.infest; i++)
                    {
                        drawACard(CardDB.cardNameEN.rivercrocolisk, m.own, true);
                    }
                }

                // 先祖之魂效果，复活一个相同的随从
                if (m.ancestralspirit > 0)
                {
                    for (int i = 0; i < m.ancestralspirit; i++)
                    {
                        CardDB.Card kid = m.handcard.card;
                        int pos = m.own ? this.ownMinions.Count : this.enemyMinions.Count;
                        callKid(kid, pos, m.own, false, true);
                    }
                }

                // 绝望之声效果，复活随从，血量为1
                if (m.desperatestand > 0)
                {
                    for (int i = 0; i < m.desperatestand; i++)
                    {
                        CardDB.Card kid = m.handcard.card;
                        List<Minion> tmp = m.own ? this.ownMinions : this.enemyMinions;
                        int pos = tmp.Count;
                        callKid(kid, pos, m.own, false, true);

                        if (tmp.Count >= 1)
                        {
                            Minion summonedMinion = tmp[pos];
                            if (summonedMinion.handcard.card.cardIDenum == kid.cardIDenum)
                            {
                                summonedMinion.Hp = 1;
                                summonedMinion.wounded = false;
                                if (summonedMinion.Hp < summonedMinion.maxHp)
                                    summonedMinion.wounded = true;
                            }
                        }
                    }
                }

                // 森林之魂效果，召唤一个树人
                for (int i = 0; i < m.souloftheforest; i++)
                {
                    CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_158t); // 树人
                    int pos = m.own ? this.ownMinions.Count : this.enemyMinions.Count;
                    callKid(kid, pos, m.own, false, true);
                }

                // 钢铁战犀效果，召唤一个厚甲战马
                for (int i = 0; i < m.stegodon; i++)
                {
                    CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_810); // 厚甲战马
                    int pos = m.own ? this.ownMinions.Count : this.enemyMinions.Count;
                    callKid(kid, pos, m.own, false, true);
                }

                // 生命孢子效果，召唤两个植物
                for (int i = 0; i < m.livingspores; i++)
                {
                    CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_999t2t1); // 植物
                    int pos = m.own ? this.ownMinions.Count : this.enemyMinions.Count;
                    callKid(kid, pos, m.own, false, true);
                    callKid(kid, pos, m.own, false, true);
                }

                // 如果有额外的亡语效果，触发它
                if (m.deathrattle2 != null)
                {
                    m.deathrattle2.sim_card.onDeathrattle(this, m);
                }

                // 处理里文戴尔男爵效果，双倍触发亡语
                if ((m.own && this.ownBaronRivendare >= 1) || (!m.own && this.enemyBaronRivendare >= 1))
                {
                    int r = m.own ? this.ownBaronRivendare : this.enemyBaronRivendare;
                    for (int j = 0; j < r; j++)
                    {
                        if (!m.silenced && m.handcard.card.deathrattle)
                        {
                            m.handcard.card.sim_card.onDeathrattle(this, m);
                        }

                        // 再次执行上述所有效果以模拟双倍触发
                        if (m.explorershat > 0)
                        {
                            for (int i = 0; i < m.explorershat; i++)
                            {
                                drawACard(CardDB.cardNameEN.explorershat, m.own, true);
                            }
                        }

                        if (m.returnToHand > 0)
                        {
                            drawACard(m.handcard.card.cardIDenum, m.own, true);
                        }

                        if (m.infest > 0)
                        {
                            for (int i = 0; i < m.infest; i++)
                            {
                                drawACard(CardDB.cardNameEN.rivercrocolisk, m.own, true);
                            }
                        }

                        if (m.ancestralspirit > 0)
                        {
                            for (int i = 0; i < m.ancestralspirit; i++)
                            {
                                CardDB.Card kid = m.handcard.card;
                                int pos = m.own ? this.ownMinions.Count : this.enemyMinions.Count;
                                callKid(kid, pos, m.own);
                            }
                        }

                        if (m.desperatestand > 0)
                        {
                            for (int i = 0; i < m.desperatestand; i++)
                            {
                                CardDB.Card kid = m.handcard.card;
                                List<Minion> tmp = m.own ? this.ownMinions : this.enemyMinions;
                                int pos = tmp.Count;
                                callKid(kid, pos, m.own, false, true);

                                if (tmp.Count >= 1)
                                {
                                    Minion summonedMinion = tmp[pos];
                                    if (summonedMinion.handcard.card.cardIDenum == kid.cardIDenum)
                                    {
                                        summonedMinion.Hp = 1;
                                        summonedMinion.wounded = false;
                                        if (summonedMinion.Hp < summonedMinion.maxHp)
                                            summonedMinion.wounded = true;
                                    }
                                }
                            }
                        }

                        for (int i = 0; i < m.souloftheforest; i++)
                        {
                            CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_158t); // 树人
                            int pos = m.own ? this.ownMinions.Count : this.enemyMinions.Count;
                            callKid(kid, pos, m.own);
                        }

                        for (int i = 0; i < m.stegodon; i++)
                        {
                            CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_810); // 厚甲战马
                            int pos = m.own ? this.ownMinions.Count : this.enemyMinions.Count;
                            callKid(kid, pos, m.own);
                        }

                        for (int i = 0; i < m.livingspores; i++)
                        {
                            CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_999t2t1); // 植物
                            int pos = m.own ? this.ownMinions.Count : this.enemyMinions.Count;
                            callKid(kid, pos, m.own);
                            callKid(kid, pos, m.own);
                        }

                        if (m.deathrattle2 != null)
                        {
                            m.deathrattle2.sim_card.onDeathrattle(this, m);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 更新战场上的随从状态，包括处理死亡随从的亡语效果和相邻随从的增益效果。
        /// </summary>
        public void updateBoards()
        {
            // 如果没有随从状态变化，则直接返回
            if (!this.tempTrigger.ownMinionsChanged && !this.tempTrigger.enemyMininsChanged) return;

            // 用于存储需要触发亡语效果的随从
            List<Minion> deathrattleMinions = new List<Minion>();

            // 标记是否有复活的随从
            bool minionOwnReviving = false;
            bool minionEnemyReviving = false;

            // 如果己方随从发生变化
            if (this.tempTrigger.ownMinionsChanged)
            {
                this.tempTrigger.ownMinionsChanged = false;
                List<Minion> temp = new List<Minion>();
                int i = 1;
                foreach (Minion m in this.ownMinions)
                {
                    // 移除相邻的增益效果
                    this.minionGetAdjacentBuff(m, -m.AdjacentAngr, 0);
                    // m.cantBeTargetedBySpellsOrHeroPowers = false;

                    // 如果随从已死亡
                    if (m.Hp <= 0)
                    {
                        this.OwnLastDiedMinion = m.handcard.card.cardIDenum;

                        // 记录第一个复活的随从
                        if (this.revivingOwnMinion == CardDB.cardIDEnum.None)
                        {
                            this.revivingOwnMinion = m.handcard.card.cardIDenum;
                            minionOwnReviving = true;
                        }

                        // 检查随从是否有亡语或其他相关效果
                        if ((!m.silenced && m.handcard.card.deathrattle) || m.ancestralspirit >= 1 || m.desperatestand >= 1 ||
                            m.souloftheforest >= 1 || m.stegodon >= 1 || m.livingspores >= 1 || m.infest >= 1 ||
                            m.explorershat >= 1 || m.returnToHand >= 1 || m.deathrattle2 != null)
                        {
                            deathrattleMinions.Add(m);
                        }

                        // 移除随从的光环效果
                        if (!m.silenced)
                        {
                            m.handcard.card.sim_card.onAuraEnds(this, m);
                        }
                    }
                    else
                    {
                        m.zonepos = i;
                        temp.Add(m);
                        i++;
                    }
                }
                this.ownMinions = temp;
                this.updateAdjacentBuffs(true); // 更新己方随从的相邻增益效果
            }

            // 如果敌方随从发生变化
            if (this.tempTrigger.enemyMininsChanged)
            {
                this.tempTrigger.enemyMininsChanged = false;
                List<Minion> temp = new List<Minion>();
                int i = 1;
                foreach (Minion m in this.enemyMinions)
                {
                    // 移除相邻的增益效果
                    this.minionGetAdjacentBuff(m, -m.AdjacentAngr, 0);
                    // m.cantBeTargetedBySpellsOrHeroPowers = false;

                    // 如果随从已死亡
                    if (m.Hp <= 0)
                    {
                        if (this.revivingEnemyMinion == CardDB.cardIDEnum.None)
                        {
                            this.revivingEnemyMinion = m.handcard.card.cardIDenum;
                            minionEnemyReviving = true;
                        }

                        // 检查随从是否有亡语或其他相关效果
                        if ((!m.silenced && m.handcard.card.deathrattle) || m.ancestralspirit >= 1 || m.desperatestand >= 1 ||
                            m.souloftheforest >= 1 || m.stegodon >= 1 || m.livingspores >= 1 || m.infest >= 1 ||
                            m.explorershat >= 1 || m.returnToHand >= 1 || m.deathrattle2 != null)
                        {
                            deathrattleMinions.Add(m);
                        }

                        // 移除随从的光环效果
                        if (!m.silenced)
                        {
                            m.handcard.card.sim_card.onAuraEnds(this, m);
                        }
                    }
                    else
                    {
                        m.zonepos = i;
                        temp.Add(m);
                        i++;
                    }
                }
                this.enemyMinions = temp;
                this.updateAdjacentBuffs(false); // 更新敌方随从的相邻增益效果
            }

            // 处理武器"灵魂之爪"的效果，根据法术强度增加或减少攻击力
            handleSpiritClaws(this.ownWeapon, this.ownHero, this.spellpower, this.spellpowerStarted, ref this.ownSpiritclaws);
            handleSpiritClaws(this.enemyWeapon, this.enemyHero, this.enemyspellpower, this.enemyspellpowerStarted, ref this.enemySpiritclaws);

            // 触发所有亡语效果
            if (deathrattleMinions.Count >= 1)
            {
                this.doDeathrattles(deathrattleMinions);
            }

            // 如果有己方复活的随从，触发相关奥秘
            if (minionOwnReviving)
            {
                this.secretTrigger_MinionDied(true);
                this.revivingOwnMinion = CardDB.cardIDEnum.None;
            }

            // 如果有敌方复活的随从，触发相关奥秘
            if (minionEnemyReviving)
            {
                this.secretTrigger_MinionDied(false);
                this.revivingEnemyMinion = CardDB.cardIDEnum.None;
            }
        }

        /// <summary>
        /// 处理灵魂之爪武器的攻击力调整。
        /// </summary>
        /// <param name="weapon">武器对象</param>
        /// <param name="hero">英雄对象</param>
        /// <param name="currentSpellPower">当前法术强度</param>
        /// <param name="initialSpellPower">初始法术强度</param>
        /// <param name="spiritClawsActive">灵魂之爪激活状态</param>
        private void handleSpiritClaws(Weapon weapon, Minion hero, int currentSpellPower, int initialSpellPower, ref bool spiritClawsActive)
        {
            if (weapon.name == CardDB.cardNameEN.spiritclaws)
            {
                int dif = (currentSpellPower > 0 ? 2 : 0) - (initialSpellPower > 0 ? 2 : 0);
                if (dif > 0 && !spiritClawsActive)
                {
                    this.minionGetBuffed(hero, 2, 0);
                    weapon.Angr += 2;
                    spiritClawsActive = true;
                }
                else if (dif < 0 && spiritClawsActive)
                {
                    this.minionGetBuffed(hero, -2, 0);
                    weapon.Angr -= 2;
                    spiritClawsActive = false;
                }
            }
        }

        /// <summary>
        /// 根据光环效果为随从添加或移除属性增益。
        /// </summary>
        /// <param name="m">目标随从</param>
        /// <param name="get">是否为添加增益，如果为false则移除增益</param>
        public void minionGetOrEraseAllAreaBuffs(Minion m, bool get)
        {
            // 英雄不受影响
            if (m.isHero) return;

            int angr = 0;  // 攻击力增益
            int vert = 0;  // 生命值增益

            // 如果随从未被沉默
            if (!m.silenced)
            {
                switch (m.name)
                {
                    case CardDB.cardNameEN.raidleader:
                    case CardDB.cardNameEN.leokk:
                    case CardDB.cardNameEN.timberwolf:
                    case CardDB.cardNameEN.grimscaleoracle:
                        angr--;  // 减去这些随从带来的基础攻击力增益
                        break;

                    case CardDB.cardNameEN.vessina:
                        if (this.ueberladung > 0 || this.lockedMana > 0) angr--;  // 只有在过载时才减去Vessina的攻击力增益
                        break;

                    case CardDB.cardNameEN.stormwindchampion:
                    case CardDB.cardNameEN.southseacaptain:
                        angr--;
                        vert--;  // 减去这些随从带来的攻击力和生命值增益
                        break;

                    case CardDB.cardNameEN.murlocwarleader:
                        if (get) angr -= 2;  // Murloc Warleader 给予的攻击力增益为2
                        break;
                }
            }

            // 处理随从种族相关的增益效果
            if (m.handcard.card.race == CardDB.Race.MURLOC)
            {
                angr += m.own ? (2 * anzOwnMurlocWarleader + anzOwnGrimscaleOracle) :
                                (2 * anzEnemyMurlocWarleader + anzEnemyGrimscaleOracle);
            }

            if (m.own)
            {
                // 处理己方随从的增益效果
                angr += anzOwnRaidleader + anzOwnStormwindChamps + (this.ueberladung > 0 || this.lockedMana > 0 ? anzOwnVessina : 0);
                vert += anzOwnStormwindChamps;

                if (m.name == CardDB.cardNameEN.silverhandrecruit) angr += anzOwnWarhorseTrainer;

                handleRaceSpecificBuffs(m, get, true);
            }
            else
            {
                // 处理敌方随从的增益效果
                angr += anzEnemyRaidleader + anzEnemyStormwindChamps + (this.ueberladung > 0 || this.lockedMana > 0 ? anzEnemyVessina : 0);
                vert += anzEnemyStormwindChamps;

                if (m.name == CardDB.cardNameEN.silverhandrecruit) angr += anzEnemyWarhorseTrainer;

                handleRaceSpecificBuffs(m, get, false);
            }

            // 根据get参数决定是添加还是移除增益
            this.minionGetBuffed(m, get ? angr : -angr, get ? vert : -vert);
        }

        /// <summary>
        /// 根据随从种族处理种族相关的增益效果。
        /// </summary>
        /// <param name="m">目标随从</param>
        /// <param name="get">是否为添加增益，如果为false则移除增益</param>
        /// <param name="own">随从是否属于己方</param>
        private void handleRaceSpecificBuffs(Minion m, bool get, bool own)
        {
            int angr = 0;
            int vert = 0;

            if (m.handcard.card.race == CardDB.Race.PET)
            {
                angr += own ? anzOwnTimberWolfs : anzEnemyTimberWolfs;
                if (get) m.charge += own ? anzOwnTundrarhino : anzEnemyTundrarhino;
                else m.charge -= own ? anzOwnTundrarhino : anzEnemyTundrarhino;
            }
            if (m.handcard.card.race == CardDB.Race.PIRATE)
            {
                angr += own ? anzOwnSouthseacaptain : anzEnemySouthseacaptain;
                vert += own ? anzOwnSouthseacaptain : anzEnemySouthseacaptain;
                if (get) m.charge += own ? anzOwnMrSmite : anzEnemyMrSmite;
                else m.charge -= own ? anzOwnMrSmite : anzEnemyMrSmite;
            }
            if (m.handcard.card.race == CardDB.Race.DEMON)
            {
                angr += (own ? anzOwnMalGanis : anzEnemyMalGanis) * 2;
                vert += (own ? anzOwnMalGanis : anzEnemyMalGanis) * 2;
            }

            // 为随从添加或移除种族相关的增益
            this.minionGetBuffed(m, angr, vert);
        }

        /// <summary>
        /// 更新随从的相邻增益效果。仅在更新战场后调用。
        /// </summary>
        /// <param name="own">是否为己方随从</param>
        public void updateAdjacentBuffs(bool own)
        {
            // 获取目标随从列表
            List<Minion> temp = own ? this.ownMinions : this.enemyMinions;
            int anz = temp.Count;  // 获取随从数量

            // 遍历随从列表
            for (int i = 0; i < anz; i++)
            {
                Minion m = temp[i];

                // 如果随从未被沉默
                if (!m.silenced)
                {
                    // 根据随从名称应用特定的相邻增益效果
                    switch (m.name)
                    {
                        case CardDB.cardNameEN.weespellstopper:
                            // Weespellstopper会使相邻的随从无法被法术或英雄技能选定为目标
                            if (i > 0) temp[i - 1].Elusive = true;
                            if (i < anz - 1) temp[i + 1].Elusive = true;
                            continue;

                        case CardDB.cardNameEN.direwolfalpha:
                            // Dire Wolf Alpha为相邻的随从增加1点攻击力
                            if (i > 0) this.minionGetAdjacentBuff(temp[i - 1], 1, 0);
                            if (i < anz - 1) this.minionGetAdjacentBuff(temp[i + 1], 1, 0);
                            continue;

                        case CardDB.cardNameEN.flametonguetotem:
                            // Flametongue Totem为相邻的随从增加2点攻击力
                            if (i > 0) this.minionGetAdjacentBuff(temp[i - 1], 2, 0);
                            if (i < anz - 1) this.minionGetAdjacentBuff(temp[i + 1], 2, 0);
                            continue;
                    }
                }
            }
        }

        /// <summary>
        /// 创建一个新的随从实例，并应用相关的增益、效果和状态。
        /// </summary>
        /// <param name="hc">随从对应的手牌信息</param>
        /// <param name="zonepos">随从在场上的位置</param>
        /// <param name="own">是否为己方随从</param>
        /// <returns>新创建的随从对象</returns>
        public Minion createNewMinion(Handmanager.Handcard hc, int zonepos, bool own)
        {
            // 初始化随从对象并复制手牌信息
            Minion m = new Minion
            {
                handcard = new Handmanager.Handcard(hc),
                own = own,
                isHero = false,
                entitiyID = hc.entity,
                playedThisTurn = true,
                numAttacksThisTurn = 0,
                zonepos = zonepos,
                reborn = hc.card.reborn,
                windfury = hc.card.windfury,
                taunt = hc.card.tank,
                charge = hc.card.Charge ? 1 : 0,
                Spellburst = hc.card.Spellburst, // 法术迸发
                dormant = hc.card.dormant,
                untouchable = hc.card.dormant > 0 || hc.card.untouchable,
                rush = hc.card.Rush ? 1 : 0,
                divineshild = hc.card.Shield,
                poisonous = hc.card.poisonous,
                lifesteal = hc.card.lifesteal,
                stealth = hc.card.Stealth,
                Elusive = hc.card.Elusive,
                name = hc.card.nameEN,
                nameCN = hc.card.nameCN,
            };

            // 如果己方所有元素随从具有吸血效果
            if (this.prozis.ownElementalsHaveLifesteal > 0 && (TAG_RACE)m.handcard.card.race == TAG_RACE.ELEMENTAL)
            {
                m.lifesteal = true;
            }

            // 根据水晶核心状态设置随从攻击力和生命值
            if (this.ownCrystalCore > 0)
            {
                m.Angr = m.Hp = m.maxHp = ownCrystalCore;
            }
            else
            {
                m.Angr = hc.card.Attack + hc.addattack;
                m.Hp = hc.card.Health + hc.addHp;
                m.maxHp = hc.card.Health;
            }

            // 重置手牌的额外攻击力和生命值加成
            hc.addattack = 0;
            hc.addHp = 0;

            // 特殊随从效果处理
            // if (m.name == CardDB.cardNameEN.lightspawn)
            // {
            //     m.Angr = m.Hp;
            // }

            // 更新随从是否可以立即攻击
            m.updateReadyness();

            // 计算种族优先级，影响评分
            m.synergy = own ?
                prozis.penman.getClassRacePriorityPenality(this.ownHeroStartClass, (TAG_RACE)m.handcard.card.race) :
                prozis.penman.getClassRacePriorityPenality(this.enemyHeroStartClass, (TAG_RACE)m.handcard.card.race);

            if (m.synergy > 0 && hc.card.Stealth)
            {
                m.synergy++;
            }

            // 触发召唤时的效果
            this.triggerAMinionIsSummoned(m);

            // 激活光环效果
            m.handcard.card.sim_card.onAuraStarts(this, m);

            // 应用区域增益效果
            this.minionGetOrEraseAllAreaBuffs(m, true);

            return m;
        }

        /// <summary>
        /// 将随从放置到战场上的指定位置，并处理战吼、触发效果及其他相关逻辑。
        /// </summary>
        /// <param name="hc">手牌信息</param>
        /// <param name="choice">选择效果（如果有）</param>
        /// <param name="zonepos">随从放置位置</param>
        public void placeAmobSomewhere(Handmanager.Handcard hc, int choice, int zonepos)
        {
            // 创建一个新的随从并设置其为手牌中打出
            Minion m = createNewMinion(hc, zonepos, true);
            // m.playedFromHand = true;

            // 处理“空降歹徒”的效果（如果当前随从是海盗，则尝试召唤）
            CardDB.Card parachuteBrigand = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_056);
            if ((TAG_RACE)hc.card.race == TAG_RACE.PIRATE)
            {
                foreach (Handmanager.Handcard handcard in this.owncards.ToArray())
                {
                    if (handcard.card.cardIDenum == CardDB.cardIDEnum.DRG_056 && this.ownMinions.Count < 7)
                    {
                        this.callKid(parachuteBrigand, zonepos, true);
                        this.removeCard(handcard);
                        break;
                    }
                }
            }

            // 处理“海盗帕奇斯”的效果（如果当前随从是海盗且帕奇斯在牌库中，则召唤它）
            CardDB.Card patches = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_637);
            if ((TAG_RACE)hc.card.race == TAG_RACE.PIRATE && this.prozis.patchesInDeck && this.ownMinions.Count < 7)
            {
                this.callKid(patches, zonepos, true);
                this.prozis.patchesInDeck = false;

                // 从牌库中移除帕奇斯
                foreach (KeyValuePair<CardDB.cardIDEnum, int> dc in this.prozis.turnDeck.ToArray())
                {
                    if (dc.Key == CardDB.cardIDEnum.CFM_637)
                    {
                        this.prozis.turnDeck.Remove(dc.Key);
                        this.ownDeckSize--;
                        break;
                    }
                }
            }

            // 将随从添加到战场
            addMinionToBattlefield(m);

            // 触发随从的打出效果、抉择
            m.handcard.card.sim_card.onCardPlay(this, m, hc.target, choice);
            // 触发随从的战吼效果
            m.handcard.card.sim_card.getBattlecryEffect(this, m, hc.target, choice);

            // 如果随从处于流放位置（手牌的最左或最右），触发流放效果
            if (hc.position == 1 || hc.position == this.owncards.Count)
            {
                m.handcard.card.sim_card.onOutcast(this, m);
            }

            // 处理铜须的双倍战吼效果
            if (this.ownBrannBronzebeard > 0)
            {
                for (int i = 0; i < this.ownBrannBronzebeard; i++)
                {
                    m.handcard.card.sim_card.getBattlecryEffect(this, m, hc.target, choice);
                }
            }

            // 触发伤害效果
            doDmgTriggers();

            // 触发敌方奥秘
            secretTrigger_MinionIsPlayed(m);
            //TODO:随从卡牌打出后触发的效果,给术士游客用的
            foreach (Minion triggerEffectMinion in this.ownMinions)
            {
                // 如果随从没被沉默,则触发打出随从后的方法
                if (!triggerEffectMinion.silenced)
                {
                    // 调用随从卡牌的打出随从后触发方法
                    triggerEffectMinion.handcard.card.sim_card.onCardIsAfterToBePlayed(this, m, m.own, triggerEffectMinion);
                }
            }

            foreach (Minion triggerEffectMinion in this.enemyMinions)
            {
                // 如果随从没被沉默,则触发打出随从后的方法
                if (!triggerEffectMinion.silenced)
                {
                    // 调用随从卡牌的打出随从后触发方法
                    triggerEffectMinion.handcard.card.sim_card.onCardIsAfterToBePlayed(this, m, m.own, triggerEffectMinion);
                }
            }
            // 处理任务进度
            // if (this.ownQuest.Id != CardDB.cardIDEnum.None)
            // {
            //     ownQuest.trigger_MinionWasPlayed(m);
            //     // 如果任务完成，执行奖励效果
            //     if (ownQuest.maxProgress <= ownQuest.questProgress)
            //     {
            //         switch (this.ownQuest.Id)
            //         {
            //             case CardDB.cardIDEnum.SW_028:
            //                 // 寻找并抽取武器牌
            //                 foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in this.prozis.turnDeck)
            //                 {
            //                     CardDB.Card card = CardDB.Instance.getCardDataFromID(kvp.Key);
            //                     if (card.type == CardDB.cardtype.WEAPON)
            //                     {
            //                         this.drawACard(kvp.Key, true, true);
            //                         break;
            //                     }
            //                 }
            //                 // 更新任务为下一阶段
            //                 ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_028t, questProgress = 0, maxProgress = 2 };
            //                 break;

            //             case CardDB.cardIDEnum.SW_028t:
            //                 // 对敌方角色造成2点伤害
            //                 minionGetDamageOrHeal(getEnemyCharTargetForRandomSingleDamage(2), 2, true);
            //                 // 更新任务为下一阶段
            //                 ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_028t2, questProgress = 0, maxProgress = 2 };
            //                 break;

            //             case CardDB.cardIDEnum.SW_028t2:
            //                 // 抽取任务完成奖励牌
            //                 drawACard(CardDB.cardIDEnum.SW_028t5, true, true);
            //                 // 如果当前法力水晶为4，减少评估惩罚
            //                 if (this.ownMaxMana == 4) evaluatePenality -= 20;
            //                 // 重置任务
            //                 ownQuest.Reset();
            //                 break;
            //         }
            //     }
            // }

            // 记录日志信息
            if (logging) Helpfunctions.Instance.logg("added " + m.handcard.card.nameEN);
        }

        /// <summary>
        /// 将随从添加到战场，并处理相关触发效果。
        /// </summary>
        /// <param name="m">要添加的随从对象</param>
        /// <param name="isSummon">是否为召唤随从，默认为 true</param>
        public void addMinionToBattlefield(Minion m, bool isSummon = true)
        {
            // 根据随从所属，获取对应的随从列表
            List<Minion> temp = m.own ? this.ownMinions : this.enemyMinions;

            // 将随从插入到指定的位置，如果位置不合法则添加到列表末尾
            if (m.zonepos >= 1 && m.zonepos <= temp.Count)
            {
                temp.Insert(m.zonepos - 1, m);
            }
            else
            {
                temp.Add(m);
            }

            // 更新触发器，标记随从列表发生了变化
            if (m.own)
            {
                this.tempTrigger.ownMinionsChanged = true;
                if (m.handcard.card.race == CardDB.Race.PET || m.handcard.card.race == CardDB.Race.ALL)
                {
                    this.tempTrigger.ownBeastSummoned++;
                }

                if (m.handcard.card.race == CardDB.Race.DRAGON || m.handcard.card.race == CardDB.Race.ALL)
                {
                    this.tempTrigger.ownDragonSummoned++;

                }
                if (m.handcard.card.Treant)
                {
                    this.tempTrigger.ownTreantSummoned++;
                }
            }
            else
            {
                this.tempTrigger.enemyMininsChanged = true;
            }

            // 触发随从被召唤的事件和奥秘
            triggerAMinionWasSummoned(m);
            doDmgTriggers();

            // 更新随从的准备状态
            m.updateReadyness();
        }

        /// <summary>
        /// 为英雄装备武器，并处理相关的状态和触发效果。
        /// </summary>
        /// <param name="c">要装备的武器卡牌</param>
        /// <param name="own">是否为己方英雄</param>
        public void equipWeapon(CardDB.Card c, bool own)
        {
            // 获取对应的英雄
            Minion hero = own ? this.ownHero : this.enemyHero;

            // 处理己方英雄的武器装备逻辑
            if (own)
            {
                if (this.ownWeapon.Durability > 0)
                {
                    bool calcLostWeaponDamage = true;

                    // 处理特定武器的损失计算
                    switch (c.nameEN)
                    {
                        case CardDB.cardNameEN.rustyhook:
                        case CardDB.cardNameEN.poisoneddagger:
                        case CardDB.cardNameEN.wickedknife:
                            if (this.ownWeapon.Angr <= c.Attack && this.ownWeapon.Durability < this.ownWeapon.card.Durability)
                            {
                                calcLostWeaponDamage = false;
                            }
                            break;
                    }

                    // 检查是否存在“毁灭战舰”随从，如果存在则不计算武器损失
                    foreach (Minion m in this.ownMinions)
                    {
                        if (m.handcard.card.nameCN == CardDB.cardNameCN.毁灭战舰)
                        {
                            calcLostWeaponDamage = false;
                        }
                    }

                    // 计算丢失的武器伤害值
                    if (calcLostWeaponDamage)
                    {
                        if (this.ownWeapon.card.cardIDenum == c.cardIDenum) this.lostDamage += 100;
                        if (this.ownWeapon.card.nameCN == CardDB.cardNameCN.海盗之锚) this.lostWeaponDamage += 10;
                        if (this.ownWeapon.card.Durability > 0 && this.ownWeapon.Durability >= this.ownWeapon.card.Durability) this.lostWeaponDamage += 10;
                        if (this.ownWeapon.card.nameCN == CardDB.cardNameCN.逝者之剑) this.lostWeaponDamage += 10;
                        this.lostWeaponDamage += this.ownWeapon.Durability * this.ownWeapon.Angr;
                        if (this.ownWeapon.Angr >= c.Attack) this.lostWeaponDamage += 10;
                    }

                    // 破坏当前武器
                    this.lowerWeaponDurability(1000, true);
                }

                // 装备新武器
                this.ownWeapon.equip(c);

            }
            else
            {
                // 敌方英雄装备武器
                this.lowerWeaponDurability(1000, false);
                this.enemyWeapon.equip(c);
            }

            // 更新英雄的属性
            hero.Angr += c.Attack;
            hero.windfury = c.windfury;
            hero.updateReadyness();
            hero.immuneWhileAttacking = (c.nameEN == CardDB.cardNameEN.gladiatorslongbow);

            // 更新己方或敌方随从状态
            List<Minion> temp = own ? this.ownMinions : this.enemyMinions;
            foreach (Minion m in temp)
            {
                switch (m.name)
                {
                    case CardDB.cardNameEN.southseadeckhand:
                        if (m.playedThisTurn) minionGetCharge(m);
                        break;
                    case CardDB.cardNameEN.buccaneer:
                        if (own) this.ownWeapon.Angr++;
                        else this.enemyWeapon.Angr++;
                        break;
                    case CardDB.cardNameEN.smalltimebuccaneer:
                        this.minionGetBuffed(m, 2, 0);
                        break;
                }
            }
        }

        /// <summary>
        /// 在战场上召唤一个随从，如果空间允许的话。
        /// </summary>
        /// <param name="c">要召唤的随从卡牌</param>
        /// <param name="zonepos">召唤随从的位置</param>
        /// <param name="own">是否为己方</param>
        /// <param name="spawnKid">是否生成随从</param>
        /// <param name="oneMoreIsAllowed">是否允许额外的随从</param>
        public void callKid(CardDB.Card c, int zonepos, bool own, bool spawnKid = true, bool oneMoreIsAllowed = false)
        {
            // 默认允许的最大随从数量为7，如果允许额外的随从，则加1
            int allowed = 7 + (oneMoreIsAllowed ? 1 : 0);

            // 检查己方随从数量是否已达上限
            if (own)
            {
                if (this.ownMinions.Count >= allowed)
                {
                    // 如果随从数量已达上限，则不再召唤新的随从
                    return;
                }
            }
            else
            {
                // 检查敌方随从数量是否已达上限
                if (this.enemyMinions.Count >= allowed)
                {
                    // 如果随从数量已达上限，则不再召唤新的随从
                    return;
                }
            }

            // 确定随从的位置（位置索引从1开始）
            int mobplace = zonepos + 1;

            // 创建随从并触发相关效果
            Handmanager.Handcard hc = new Handmanager.Handcard(c) { entity = this.getNextEntity() };
            Minion m = createNewMinion(hc, mobplace, own);

            if (own && this.ownLegionInvasion && m.handcard.card.cardIDenum == CardDB.cardIDEnum.TTN_960t5)
            {
                m.Hp += 2;
                m.taunt = true;
            }
            else if (!own && this.enemyAbilityReady && m.handcard.card.cardIDenum == CardDB.cardIDEnum.TTN_960t5)
            {
                m.Hp += 2;
                m.taunt = true;
            }

            // 将随从放置到战场上并触发相关效果
            addMinionToBattlefield(m);
        }

        /// <summary>
        /// 冻结一个随从，如果场上有摩尔克，则抽取目标随从的复制牌。
        /// </summary>
        /// <param name="target">要冻结的目标随从</param>
        public void minionGetFrozen(Minion target)
        {
            // 将目标随从标记为冻结状态
            target.frozen = true;

            // 如果目标是英雄，则直接返回
            if (target.isHero) return;

            // 如果摩尔克的数量大于1，则为每个未被沉默的摩尔克触发抽牌效果
            if (this.anzMoorabi > 1)
            {
                // 遍历己方随从
                foreach (Minion m in this.ownMinions)
                {
                    // // 检查随从是否是摩尔克且未被沉默
                    // if (m.name == CardDB.cardNameEN.moorabi && !m.silenced)
                    // {
                    //     // 抽取目标随从的复制牌
                    //     this.drawACard(target.handcard.card.nameEN, m.own, true);
                    // }
                    m.handcard.card.sim_card.onMinionFrozen(this, m, target);
                }

                // 遍历敌方随从
                foreach (Minion m in this.enemyMinions)
                {
                    // // 检查随从是否是摩尔克且未被沉默
                    // if (m.name == CardDB.cardNameEN.moorabi && !m.silenced)
                    // {
                    //     // 抽取目标随从的复制牌
                    //     this.drawACard(target.handcard.card.nameEN, m.own, true);
                    // }
                    m.handcard.card.sim_card.onMinionFrozen(this, m, target);
                }
            }
        }

        /// <summary>
        /// 使指定随从沉默，移除其所有的能力和增益效果，但不会导致随从死亡。
        /// </summary>
        /// <param name="m">要被沉默的随从</param>
        public void minionGetSilenced(Minion m)
        {
            // 调用随从的 becomeSilence 方法，实现沉默效果
            // 该方法会移除随从的所有能力、增益效果以及任何附加效果（如嘲讽、风怒等）
            m.becomeSilence(this);

            // 注意：沉默不会导致随从死亡
            // 因此，尽管随从可能会失去某些关键效果，它仍然会保留最基本的生命值和攻击力
        }

        /// <summary>
        /// 使所有随从（己方或敌方）沉默，移除它们的所有能力和增益效果。
        /// </summary>
        /// <param name="own">如果为 true，则沉默己方随从；如果为 false，则沉默敌方随从。</param>
        public void allMinionsGetSilenced(bool own)
        {
            // 获取需要沉默的随从列表
            List<Minion> temp = (own) ? this.ownMinions : this.enemyMinions;

            // 遍历列表中的每个随从，并使其沉默
            foreach (Minion m in temp)
            {
                m.becomeSilence(this); // 调用随从的沉默方法，移除其所有能力和增益效果
            }
        }

        /// <summary>
        /// 抽取一张卡牌并添加到玩家手牌中。如果手牌已满或牌库为空，会触发相应的惩罚或疲劳伤害。
        /// </summary>
        /// <param name="ss">要抽取的卡牌名称。</param>
        /// <param name="own">如果为 true，则表示为己方玩家抽卡；否则为敌方玩家抽卡。</param>
        /// <param name="nopen">如果为 true，则不进行抽卡操作。</param>
        public void drawACard(CardDB.cardNameEN ss, bool own, bool nopen = false)
        {
            CardDB.cardNameEN s = ss;

            // 检查是否为己方玩家抽卡
            if (own)
            {
                // 处理未知卡牌（即从牌库顶抽取的卡牌）
                if (s == CardDB.cardNameEN.unknown && !nopen)
                {
                    // 牌库为空，触发疲劳伤害
                    if (ownDeckSize == 0)
                    {
                        this.ownHeroFatigue++;
                        this.ownHero.getDamageOrHeal(this.ownHeroFatigue, this, false, true);
                        return;
                    }
                    else
                    {
                        // 从牌库中抽卡
                        this.ownDeckSize--;
                        // 手牌已满（10张），无法再抽牌
                        if (this.owncards.Count >= 10)
                        {
                            return;
                        }
                        this.owncarddraw++;
                    }
                }
                else
                {
                    // 手牌已满（10张），无法再抽牌
                    if (this.owncards.Count >= 10)
                    {
                        return;
                    }
                    this.owncarddraw++;
                }
            }
            else // 处理敌方玩家抽卡
            {
                if (s == CardDB.cardNameEN.unknown && !nopen)
                {
                    // 牌库为空，触发疲劳伤害
                    if (enemyDeckSize == 0)
                    {
                        this.enemyHeroFatigue++;
                        this.enemyHero.getDamageOrHeal(this.enemyHeroFatigue, this, false, true);
                        return;
                    }
                    else
                    {
                        // 从牌库中抽卡
                        this.enemyDeckSize--;
                        // 手牌已满（10张），无法再抽牌
                        if (this.enemyAnzCards >= 10)
                        {
                            return;
                        }
                        this.enemycarddraw++;
                        this.enemyAnzCards++;
                    }
                }
                else
                {
                    // 手牌已满（10张），无法再抽牌
                    if (this.enemyAnzCards >= 10)
                    {
                        return;
                    }
                    this.enemycarddraw++;
                    this.enemyAnzCards++;
                }
                this.triggerCardsChanged(false);

                // 处理敌方的Chromaggus（克洛玛古斯）效果，额外抽卡
                if (anzEnemyChromaggus > 0 && s == CardDB.cardNameEN.unknown && !nopen)
                {
                    for (int i = 1; i <= anzEnemyChromaggus; i++)
                    {
                        if (this.enemyAnzCards >= 10)
                        {
                            return;
                        }
                        this.enemycarddraw++;
                        this.enemyAnzCards++;
                        this.triggerCardsChanged(false);
                    }
                }
                return;
            }

            // 处理未知卡牌的抽取和添加到手牌中
            if (s == CardDB.cardNameEN.unknown)
            {
                CardDB.Card c = CardDB.Instance.getCardData(s);
                Handmanager.Handcard hc = new Handmanager.Handcard
                {
                    card = c,
                    position = this.owncards.Count + 1,
                    manacost = 1000,
                    entity = this.getNextEntity()
                };
                this.owncards.Add(hc);
                this.triggerCardsChanged(true);
            }
            else // 处理指定卡牌的抽取
            {
                CardDB.Card c = CardDB.Instance.getCardData(s);
                Handmanager.Handcard hc = new Handmanager.Handcard
                {
                    card = c,
                    position = this.owncards.Count + 1,
                    manacost = c.calculateManaCost(this),
                    entity = this.getNextEntity()
                };
                this.owncards.Add(hc);
                this.triggerCardsChanged(true);
            }

            // 处理己方的Chromaggus（克洛玛古斯）效果，额外抽卡
            if (anzOwnChromaggus > 0 && s == CardDB.cardNameEN.unknown && !nopen)
            {
                CardDB.Card c = CardDB.Instance.getCardData(s);
                for (int i = 1; i <= anzOwnChromaggus; i++)
                {
                    if (this.owncards.Count >= 10)
                    {
                        return;
                    }
                    this.owncarddraw++;

                    Handmanager.Handcard hc = new Handmanager.Handcard
                    {
                        card = c,
                        position = this.owncards.Count + 1,
                        manacost = 1000,
                        entity = this.getNextEntity()
                    };
                    this.owncards.Add(hc);
                    this.triggerCardsChanged(true);
                }
            }
        }

        /// <summary>
        /// 抽取一张卡牌并添加到玩家手牌中。如果手牌已满或牌库为空，会触发相应的惩罚或疲劳伤害。
        /// </summary>
        /// <param name="ss">要抽取的卡牌的枚举ID。</param>
        /// <param name="own">如果为 true，则表示为己方玩家抽卡；否则为敌方玩家抽卡。</param>
        /// <param name="nopen">如果为 true，则不进行抽卡操作。</param>
        public void drawACard(CardDB.cardIDEnum ss, bool own, bool nopen = false)
        {
            CardDB.cardIDEnum s = ss;

            // 处理己方玩家的抽卡逻辑
            if (own)
            {
                // 处理从牌库顶抽取的未知卡牌
                if (s == CardDB.cardIDEnum.None && !nopen)
                {
                    if (ownDeckSize == 0) // 牌库为空，触发疲劳伤害
                    {
                        this.ownHeroFatigue++;
                        this.ownHero.getDamageOrHeal(this.ownHeroFatigue, this, false, true);
                        return;
                    }
                    else
                    {
                        // 从牌库中抽卡
                        this.ownDeckSize--;
                        if (this.owncards.Count >= 10) // 手牌已满（10张），无法再抽牌
                        {
                            return;
                        }
                        this.owncarddraw++;

                        // 符文秘银杖效果，每当抽一张牌时增加其计数
                        if (this.ownWeapon != null && this.ownWeapon.card.nameCN == CardDB.cardNameCN.符文秘银杖)
                        {
                            this.ownWeapon.scriptNum1++;
                        }
                    }
                }
                else
                {
                    if (this.owncards.Count >= 10) // 手牌已满（10张），无法再抽牌
                    {
                        return;
                    }
                    this.owncarddraw++;
                }
            }
            else // 处理敌方玩家的抽卡逻辑
            {
                if (s == CardDB.cardIDEnum.None && !nopen)
                {
                    if (enemyDeckSize == 0) // 牌库为空，触发疲劳伤害
                    {
                        this.enemyHeroFatigue++;
                        this.enemyHero.getDamageOrHeal(this.enemyHeroFatigue, this, false, true);
                        return;
                    }
                    else
                    {
                        // 从牌库中抽卡
                        this.enemyDeckSize--;
                        if (this.enemyAnzCards >= 10) // 手牌已满（10张），无法再抽牌
                        {
                            return;
                        }
                        this.enemycarddraw++;
                        this.enemyAnzCards++;
                    }
                }
                else
                {
                    if (this.enemyAnzCards >= 10) // 手牌已满（10张），无法再抽牌
                    {
                        return;
                    }
                    this.enemycarddraw++;
                    this.enemyAnzCards++;
                }
                this.triggerCardsChanged(false);

                // 处理敌方的Chromaggus（克洛玛古斯）效果，额外抽卡
                if (anzEnemyChromaggus > 0 && s == CardDB.cardIDEnum.None && !nopen)
                {
                    for (int i = 1; i <= anzEnemyChromaggus; i++)
                    {
                        if (this.enemyAnzCards >= 10) // 手牌已满（10张），无法再抽牌
                        {
                            return;
                        }
                        this.enemycarddraw++;
                        this.enemyAnzCards++;
                        this.triggerCardsChanged(false);
                    }
                }
                return;
            }

            // 处理未知卡牌的抽取和添加到手牌中
            if (s == CardDB.cardIDEnum.None)
            {
                CardDB.Card c = CardDB.Instance.getCardDataFromID(s);
                Handmanager.Handcard hc = new Handmanager.Handcard
                {
                    card = c,
                    position = this.owncards.Count + 1,
                    manacost = 1000,
                    entity = this.getNextEntity()
                };
                this.owncards.Add(hc);
                this.triggerCardsChanged(true);
            }
            else // 处理指定卡牌的抽取
            {
                CardDB.Card c = CardDB.Instance.getCardDataFromID(s);
                Handmanager.Handcard hc = new Handmanager.Handcard
                {
                    card = c,
                    position = this.owncards.Count + 1,
                    manacost = c.calculateManaCost(this),
                    entity = this.getNextEntity()
                };
                //TODO:抽到时释放，兄弟抽未知的牌时,不知道这牌是什么,不好做这个效果
                // if (c.CastsWhenDrawn == 1)
                // {
                //     c.sim_card.castsWhenDrawn(this, hc, own);
                // }
                this.owncards.Add(hc);
                this.triggerCardsChanged(true);
            }

            // 处理己方的Chromaggus（克洛玛古斯）效果，额外抽卡
            if (anzOwnChromaggus > 0 && s == CardDB.cardIDEnum.None && !nopen)
            {
                CardDB.Card c = CardDB.Instance.getCardDataFromID(s);
                for (int i = 1; i <= anzOwnChromaggus; i++)
                {
                    if (this.owncards.Count >= 10) // 手牌已满（10张），无法再抽牌
                    {
                        return;
                    }
                    this.owncarddraw++;

                    Handmanager.Handcard hc = new Handmanager.Handcard
                    {
                        card = c,
                        position = this.owncards.Count + 1,
                        manacost = 1000,
                        entity = this.getNextEntity()
                    };
                    this.owncards.Add(hc);
                    this.triggerCardsChanged(true);
                }
            }
        }

        /// <summary>
        /// 从手牌中移除一张指定的卡牌，并重新编号手牌位置。
        /// </summary>
        /// <param name="hcc">要移除的卡牌。</param>
        public void removeCard(Handmanager.Handcard hcc)
        {
            int cardPos = 1; // 用于更新卡牌位置的计数器
            Handmanager.Handcard hcToRemove = null;

            // 遍历手牌，查找要移除的卡牌，并重新编号其余卡牌的位置
            foreach (Handmanager.Handcard hc in this.owncards)
            {
                if (hc.entity == hcc.entity) // 找到要移除的卡牌
                {
                    hcToRemove = hc;
                    continue; // 跳过要移除的卡牌，不更新其位置
                }
                hc.position = cardPos; // 更新卡牌位置
                cardPos++;
            }

            // 如果找到了要移除的卡牌，从手牌中移除
            if (hcToRemove != null)
            {
                this.owncards.Remove(hcToRemove);
            }
        }

        /// <summary>
        /// 重新编号手牌中所有卡牌的位置，使它们的顺序与实际手牌中的顺序一致。
        /// </summary>
        /// <param name="list">要重新编号的手牌列表。</param>
        public void renumHandCards(List<Handmanager.Handcard> list)
        {
            int count = list.Count;

            // 重新为手牌中的每张卡牌分配位置
            for (int i = 0; i < count; i++)
            {
                list[i].position = i + 1;
            }
        }

        /// <summary>
        /// 对敌方英雄造成伤害，但确保其生命值不会低于1。
        /// </summary>
        /// <param name="dmg">要造成的伤害值。</param>
        public void attackEnemyHeroWithoutKill(int dmg)
        {
            this.enemyHero.cantLowerHPbelowONE = true; // 设置敌方英雄的HP不低于1的标志
            this.minionGetDamageOrHeal(this.enemyHero, dmg); // 对敌方英雄造成伤害
            this.enemyHero.cantLowerHPbelowONE = false; // 取消敌方英雄的HP保护标志
        }

        /// <summary>
        /// 销毁指定的随从。如果随从在本回合已出场且没有冲锋，则更新损失的潜在伤害值。
        /// </summary>
        /// <param name="m">要销毁的随从对象。</param>
        public void minionGetDestroyed(Minion m)
        {
            if (m.own)
            {
                // 如果随从本回合出场且没有冲锋，计算并记录潜在的损失伤害值
                if (m.playedThisTurn && m.charge == 0)
                {
                    this.lostDamage += m.Hp * 2 + m.Angr * 2 + (m.windfury ? m.Angr : 0) +
                                       ((m.handcard.card.isSpecialMinion && !m.taunt) ? 20 : 0);
                }
            }

            // 销毁随从
            if (m.Hp > 0)
            {
                m.Hp = 0;  // 设置随从的生命值为0
                m.minionDied(this);  // 触发随从死亡事件
            }
        }

        /// <summary>
        /// 移除指定的随从，并且触发onAuraEnds离场效果
        /// </summary>
        /// <param name="m">要移除的随从</param>
        public void RemoveMinionWithoutDeathrattle(Minion m)
        {
            // 触发onAuraEnds离场效果
            m.handcard.card.sim_card.onAuraEnds(this, m);

            // 移除随从
            this.ownMinions.Remove(m); // 将随从从当前战场移除

        }

        /// <summary>
        /// 销毁场上所有的随从，包括己方和敌方随从。
        /// </summary>
        public void allMinionsGetDestroyed()
        {
            // this.ownMinions.ToList().ForEach(minionGetDestroyed);
            // this.enemyMinions.ToList().ForEach(minionGetDestroyed);

            // List<Minion> owmminions = new List<Minion>(this.ownMinions);
            // List<Minion> enemyminions = new List<Minion>(this.enemyMinions);
            // 销毁己方所有随从
            foreach (Minion m in this.ownMinions.ToArray())
            {
                if (m.handcard.card.type != CardDB.cardtype.MOB || m.handcard.card.untouchable) continue;
                this.minionGetDestroyed(m);
            }

            // 销毁敌方所有随从
            foreach (Minion m in this.enemyMinions.ToArray())
            {
                if (m.handcard.card.type != CardDB.cardtype.MOB || m.handcard.card.untouchable) continue;
                this.minionGetDestroyed(m);
            }
        }



        /// <summary>
        /// 为指定随从增加护甲值，并更新手牌中的法术玉石进度。
        /// </summary>
        /// <param name="m">要增加护甲的随从对象。</param>
        /// <param name="armor">增加的护甲值。</param>
        public void minionGetArmor(Minion m, int armor)
        {
            // 剃刀沼泽摇滚明星
            if (this.anzOwnRazorfenRockstar > 0)
                armor = this.anzOwnRazorfenRockstar * 2;
            m.armor += armor;  // 增加随从的护甲值

            // 遍历己方手牌，处理与护甲相关的卡牌效果
            /* foreach (Handmanager.Handcard hc in this.owncards.ToArray())
            {
                // 检查是否持有 "小型法术玉石" 卡牌
                if (hc.card.nameCN == CardDB.cardNameCN.小型法术玉石)
                {
                    // 累积护甲值
                    hc.SCRIPT_DATA_NUM_1 += armor;

                    // 如果护甲值累积达到或超过 3 点，升级卡牌
                    if (hc.SCRIPT_DATA_NUM_1 >= 3)
                    {
                        // 重置护甲累积值
                        hc.SCRIPT_DATA_NUM_1 = 0;

                        // 将 "小型法术玉石" 升级为 "中型法术玉石"（假设 ID 为 LOOT_051t1）
                        hc.card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_051t1);
                    }
                }

                // 检查是否持有 "法术玉石" 卡牌
                if (hc.card.nameCN == CardDB.cardNameCN.法术玉石)
                {
                    // 累积护甲值
                    hc.SCRIPT_DATA_NUM_1 += armor;

                    // 如果护甲值累积达到或超过 3 点，升级卡牌
                    if (hc.SCRIPT_DATA_NUM_1 >= 3)
                    {
                        // 重置护甲累积值
                        hc.SCRIPT_DATA_NUM_1 = 0;

                        // 将 "法术玉石" 升级为 "大型法术玉石"（假设 ID 为 LOOT_051t2）
                        hc.card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_051t2);
                    }
                }
            } */

            // 触发英雄获得护甲的事件
            this.triggerAHeroGotArmor(m.own, armor);

            // 处理友方随从中处于冷却中的地标，ID为VAC_517（远足步道）
            // if (m.own && m.isHero)
            // {
            //     foreach (Minion ownMinion in this.ownMinions)
            //     {
            //         if (ownMinion.handcard.card.cardIDenum == CardDB.cardIDEnum.VAC_517 && ownMinion.CooldownTurn > 0)
            //         {
            //             CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_517);
            //             ownMinion.CooldownTurn = 0;
            //             ownMinion.handcard.card.CooldownTurn = 0;
            //             ownMinion.Ready = true;
            //             Helpfunctions.Instance.logg("卡牌名称 - " + card.nameCN.ToString() + " " + card.cardIDenum.ToString() + " 地标冷却回合 - 0");
            //         }
            //     }
            // }
        }

        /// <summary>
        /// 将随从返回到玩家的手牌中，考虑手牌数量和法力值变化。
        /// </summary>
        /// <param name="m">要返回手牌的随从对象。</param>
        /// <param name="own">是否是己方随从。</param>
        /// <param name="manachange">返回手牌后法力值的变化。</param>
        public void minionReturnToHand(Minion m, bool own, int manachange)
        {
            List<Minion> temp = (m.own) ? this.ownMinions : this.enemyMinions;

            // 移除随从的光环效果
            m.handcard.card.sim_card.onAuraEnds(this, m);
            temp.Remove(m);

            if (own)
            {
                CardDB.Card c = m.handcard.card;
                Handmanager.Handcard hc = new Handmanager.Handcard
                {
                    card = c,
                    position = this.owncards.Count + 1,
                    entity = m.entitiyID,
                    manacost = c.calculateManaCost(this) + manachange
                };

                if (this.owncards.Count < 10)
                {
                    this.owncards.Add(hc);
                    this.triggerCardsChanged(true); // 触发手牌变化事件
                }
                else
                {
                    this.drawACard(CardDB.cardNameEN.unknown, true); // 如果手牌已满，直接抽一张随机卡（疲劳伤害）
                }
            }
            else
            {
                this.drawACard(CardDB.cardNameEN.unknown, false); // 敌方随从返回时，抽一张随机卡
            }

            // 更新随从状态
            if (m.own)
            {
                this.tempTrigger.ownMinionsChanged = true;
            }
            else
            {
                this.tempTrigger.enemyMininsChanged = true;
            }
        }

        /// <summary>
        /// 将随从返回到玩家的牌库中，更新牌库大小。
        /// </summary>
        /// <param name="m">要返回牌库的随从对象。</param>
        /// <param name="own">是否是己方随从。</param>
        public void minionReturnToDeck(Minion m, bool own)
        {
            List<Minion> temp = (m.own) ? this.ownMinions : this.enemyMinions;

            // 移除随从的光环效果
            m.handcard.card.sim_card.onAuraEnds(this, m);
            temp.Remove(m);

            // 更新随从状态
            if (m.own)
            {
                this.tempTrigger.ownMinionsChanged = true;
                this.ownDeckSize++; // 增加己方牌库大小
            }
            else
            {
                this.tempTrigger.enemyMininsChanged = true;
                this.enemyDeckSize++; // 增加敌方牌库大小
            }
        }

        /// <summary>
        /// 将随从变形为指定的新随从，并处理相应的状态变化。
        /// </summary>
        /// <param name="m">要变形的随从对象。</param>
        /// <param name="c">变形后的新卡牌对象。</param>
        public void minionTransform(Minion m, CardDB.Card c)
        {
            // 移除当前随从的光环效果
            m.handcard.card.sim_card.onAuraEnds(this, m);

            Handmanager.Handcard hc = new Handmanager.Handcard(c) { entity = m.entitiyID };

            // 处理随从的嘲讽状态
            if (m.taunt)
            {
                if (m.own) this.anzOwnTaunt--;
                else this.anzEnemyTaunt--;
            }

            // 将当前随从变形为新随从
            m.setMinionToMinion(createNewMinion(hc, m.zonepos, m.own));

            // 如果变形后的随从具有嘲讽，更新嘲讽数量
            if (m.taunt)
            {
                if (m.own) this.anzOwnTaunt++;
                else this.anzEnemyTaunt++;
            }

            // 激活新随从的光环效果并应用区域性BUFF
            m.handcard.card.sim_card.onAuraStarts(this, m);
            this.minionGetOrEraseAllAreaBuffs(m, true);

            // 更新随从状态
            if (m.own)
            {
                this.tempTrigger.ownMinionsChanged = true;
            }
            else
            {
                this.tempTrigger.enemyMininsChanged = true;
            }

            if (logging)
            {
                Helpfunctions.Instance.logg("minion transformed: " + m.name + " " + m.Angr);
            }
        }

        /// <summary>
        /// 根据法力值生成一个随机随从卡牌，返回对应的卡牌对象。
        /// </summary>
        /// <param name="manaCost">法力值消耗。</param>
        /// <returns>随机生成的随从卡牌对象。</returns>
        public CardDB.Card getRandomCardForManaMinion(int manaCost)
        {
            CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_231); // 默认随从
            if (manaCost > 0)
            {
                // 将法力值上限设置为10
                if (manaCost > 10) manaCost = 10;

                // 根据法力值生成对应的随从卡牌
                switch (manaCost)
                {
                    case 1: kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_011); break; // 食腐土狼
                    case 2: kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_131); break; // 自然平衡
                    case 3: kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_134); break; // 收割机
                    case 4: kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GVG_074); break; // 拍卖大师
                    case 5: kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DS1_055); break; // 狂野怒火
                    case 6: kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_283); break; // 法力浮龙
                    case 7: kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_088); break; // 闪电风暴
                    case 8: kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NEW1_038); break; // 蓝龙
                    case 9: kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_573); break; // 塞纳留斯
                    case 10: kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_120); break; // 力量之斧
                }
            }
            return kid;
        }

        /// <summary>
        /// 随机选择一个敌方角色作为单次伤害的目标，优先选择合适的随从。
        /// </summary>
        /// <param name="damage">伤害值。</param>
        /// <param name="onlyMinions">是否只选择随从作为目标。</param>
        /// <returns>选择的目标随从。</returns>
        public Minion getEnemyCharTargetForRandomSingleDamage(int damage, bool onlyMinions = false)
        {
            Minion target = null;
            int tmp = this.guessingHeroHP; // 记录猜测的英雄血量
            this.guessHeroDamage(); // 重新计算可能的英雄伤害值

            if (this.guessingHeroHP < 0) // 如果猜测的英雄血量为负数，可能是受到严重威胁
            {
                target = this.searchRandomMinionByMaxHP(this.enemyMinions, searchmode.searchHighestAttack, damage); // 尝试寻找高攻击力的随从作为目标
                if ((target == null || this.enemyHero.Hp <= damage) && !onlyMinions)
                {
                    target = this.enemyHero; // 如果没有找到合适的随从且敌方英雄生命值低，则选择敌方英雄
                }
            }
            else
            {
                // 根据伤害值选择目标，伤害值高优先选择低血量目标，伤害值低优先选择高血量目标
                target = this.searchRandomMinion(this.enemyMinions, damage > 3 ? searchmode.searchLowestHP : searchmode.searchHighestHP);
                if (target == null && !onlyMinions)
                {
                    target = this.enemyHero; // 如果没有找到合适的随从则选择敌方英雄
                }
            }
            this.guessingHeroHP = tmp; // 恢复原先猜测的英雄血量
            return target;
        }

        /// <summary>
        /// 控制一个随从，改变其所有权并处理相关状态。
        /// </summary>
        /// <param name="m">要被控制的随从对象。</param>
        /// <param name="newOwner">新的拥有者是否为己方。</param>
        /// <param name="canAttack">被控制后是否能够攻击。</param>
        /// <param name="forced">是否强制控制，忽略随从数量上限。</param>
        public void minionGetControlled(Minion m, bool newOwner, bool canAttack, bool forced = false)
        {
            List<Minion> newOwnerList = newOwner ? this.ownMinions : this.enemyMinions;
            List<Minion> oldOwnerList = newOwner ? this.enemyMinions : this.ownMinions;
            bool isFreeSpace = true;

            if (newOwnerList.Count >= 7)
            {
                if (!forced) return; // 如果新拥有者随从已满且不强制，直接返回
                else isFreeSpace = false; // 强制控制时忽略随从数量限制
            }

            this.tempTrigger.ownMinionsChanged = true;
            this.tempTrigger.enemyMininsChanged = true;

            // 处理嘲讽状态的更新
            if (m.taunt)
            {
                if (newOwner)
                {
                    this.anzEnemyTaunt--;
                    if (isFreeSpace) this.anzOwnTaunt++;
                }
                else
                {
                    if (isFreeSpace) this.anzEnemyTaunt++;
                    this.anzOwnTaunt--;
                }
            }

            // 结束当前随从的光环效果和区域BUFF
            m.handcard.card.sim_card.onAuraEnds(this, m);
            this.minionGetOrEraseAllAreaBuffs(m, false);

            // 从原拥有者的随从列表中移除
            oldOwnerList.Remove(m);

            if (isFreeSpace)
            {
                // 更改随从所有权并标记为本回合被召唤
                m.playedThisTurn = true;
                m.own = !m.own;

                // 添加到新拥有者的随从列表中，并激活相关光环和BUFF
                newOwnerList.Add(m);
                m.handcard.card.sim_card.onAuraStarts(this, m);
                this.minionGetOrEraseAllAreaBuffs(m, true);

                // 如果随从具有冲锋或指定可以攻击，则设置为可攻击状态
                if (m.charge >= 1 || canAttack)
                {
                    this.minionGetCharge(m);
                }
                else
                {
                    m.updateReadyness();
                }
            }
        }

        /// <summary>
        /// 将磁力效果应用到一个机械随从上，将两个随从合并并传递相关属性。
        /// </summary>
        /// <param name="mOwn">执行磁力效果的随从。</param>
        public void Magnetic(Minion mOwn)
        {
            List<Minion> temp = mOwn.own ? this.ownMinions : this.enemyMinions;

            // 遍历随从列表，寻找目标随从进行磁力合并
            foreach (Minion m in temp)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MECHANICAL && m.zonepos == mOwn.zonepos + 1)
                {
                    // 将mOwn的属性传递给目标机械随从m
                    this.minionGetBuffed(m, mOwn.Angr, mOwn.Hp);
                    if (mOwn.taunt) m.taunt = true;
                    if (mOwn.divineshild) m.divineshild = true;
                    if (mOwn.lifesteal) m.lifesteal = true;
                    if (mOwn.poisonous) m.poisonous = true;
                    if (mOwn.rush != 0) this.minionGetRush(m);
                    m.updateReadyness();

                    // 消除被合并的随从mOwn
                    this.minionGetSilenced(mOwn);
                    this.minionGetDestroyed(mOwn);

                    // 处理磁力效果后的触发器
                    // if (m.Ready) this.evaluatePenality -= 35; //Todo: 不引入打分
                    break;
                }
            }
        }

        /// <summary>
        /// 给随从赋予风怒效果，使其能够在回合中进行两次攻击。
        /// </summary>
        /// <param name="m">目标随从。</param>
        public void minionGetWindfurry(Minion m)
        {
            if (m.windfury) return; // 如果已经有风怒效果，直接返回
            m.windfury = true;
            m.updateReadyness(); // 更新随从状态
        }

        /// <summary>
        /// 给随从赋予冲锋效果，使其能够在召唤的回合进行攻击。
        /// </summary>
        /// <param name="m">目标随从。</param>
        public void minionGetCharge(Minion m)
        {
            m.charge++;
            m.updateReadyness(); // 更新随从状态
        }

        /// <summary>
        /// 给随从赋予突袭效果，使其能够在召唤的回合攻击敌方随从。
        /// </summary>
        /// <param name="m">目标随从。</param>
        public void minionGetRush(Minion m)
        {
            if (m.cantAttack) return; // 如果随从无法攻击，直接返回
            m.rush = 1;
            m.updateReadyness(); // 更新随从状态

            // 如果随从没有冲锋且是本回合召唤的，限制其不能攻击英雄
            if (m.charge == 0 && m.playedThisTurn)
            {
                // Helpfunctions.Instance.ErrorLog("将赋予" + m.handcard.card.chnName + "突袭，因为不具备冲锋，本回合无法攻击！");
                m.cantAttackHeroes = true;
            }
        }

        /// <summary>
        /// 移除随从的冲锋效果。
        /// </summary>
        /// <param name="m">目标随从。</param>
        public void minionLostCharge(Minion m)
        {
            m.charge--;
            m.updateReadyness(); // 更新随从状态
        }

        /// <summary>
        /// 给随从临时增加攻击和生命值，如果该随从为英雄且处于德鲁伊任务线中，会触发相应任务进度。
        /// </summary>
        /// <param name="m">目标随从。</param>
        /// <param name="tempAttack">增加的临时攻击力。</param>
        /// <param name="tempHp">增加的临时生命值。</param>
        public void minionGetTempBuff(Minion m, int tempAttack, int tempHp)
        {
            // 如果随从没有被沉默且是光耀之子，则不进行buff处理
            // if (!m.silenced && m.name == CardDB.cardNameEN.lightspawn) return;

            // 防止攻击力减到负数
            if (tempAttack < 0 && -tempAttack > m.Angr)
            {
                tempAttack = -m.Angr;
            }
            m.tempAttack += tempAttack;
            m.Angr += tempAttack;

            // if (m.isHero)
            // {
            //     // 处理德鲁伊任务线的进度
            //     switch (this.ownQuest.Id)
            //     {
            //         case CardDB.cardIDEnum.SW_428:
            //             this.ownQuest.questProgress += tempAttack;
            //             if (this.ownQuest.questProgress >= this.ownQuest.maxProgress)
            //             {
            //                 this.evaluatePenality += (this.ownQuest.questProgress - this.ownQuest.maxProgress) * 5;
            //                 this.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_428t, questProgress = 0, maxProgress = 5 };
            //                 minionGetArmor(this.ownHero, 5);
            //             }
            //             break;
            //         case CardDB.cardIDEnum.SW_428t:
            //             this.ownQuest.questProgress += tempAttack;
            //             if (this.ownQuest.questProgress >= this.ownQuest.maxProgress)
            //             {
            //                 this.evaluatePenality += (this.ownQuest.questProgress - this.ownQuest.maxProgress) * 5;
            //                 this.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_428t2, questProgress = 0, maxProgress = 6 };
            //                 drawACard(CardDB.cardIDEnum.None, true, false);
            //                 minionGetArmor(this.ownHero, 5);
            //             }
            //             break;
            //         case CardDB.cardIDEnum.SW_428t2:
            //             this.ownQuest.questProgress += tempAttack;
            //             if (this.ownQuest.questProgress >= this.ownQuest.maxProgress)
            //             {
            //                 drawACard(CardDB.cardIDEnum.SW_428t4, true, true);
            //                 this.ownQuest.Reset();
            //             }
            //             break;
            //     }
            // }
            m.updateReadyness();
        }

        /// <summary>
        /// 给随从增加邻近buff的攻击力，更新其攻击力的值。
        /// </summary>
        /// <param name="m">目标随从。</param>
        /// <param name="angr">增加的攻击力。</param>
        /// <param name="vert">增加的生命值。</param>
        public void minionGetAdjacentBuff(Minion m, int angr, int vert)
        {
            // if (!m.silenced && m.name == CardDB.cardNameEN.lightspawn) return;
            m.Angr += angr;
            m.AdjacentAngr += angr;
        }

        /// <summary>
        /// 给一方所有随从增加攻击和生命值buff。
        /// </summary>
        /// <param name="own">true表示己方，false表示敌方。</param>
        /// <param name="attackbuff">增加的攻击力。</param>
        /// <param name="hpbuff">增加的生命值。</param>
        public void allMinionOfASideGetBuffed(bool own, int attackbuff, int hpbuff)
        {
            List<Minion> temp = own ? this.ownMinions : this.enemyMinions;
            foreach (Minion m in temp)
            {
                minionGetBuffed(m, attackbuff, hpbuff);
            }
        }

        /// <summary>
        /// 给指定随从增加攻击和生命值buff，处理特定随从的特殊效果。
        /// </summary>
        /// <param name="m">目标随从。</param>
        /// <param name="attackbuff">增加的攻击力。</param>
        /// <param name="hpbuff">增加的生命值。</param>
        public void minionGetBuffed(Minion m, int attackbuff, int hpbuff)
        {
            if (m.untouchable) return;

            // 处理攻击力buff
            if (attackbuff != 0)
            {
                m.Angr = Math.Max(0, m.Angr + attackbuff);
            }

            // 处理生命值buff
            if (hpbuff != 0)
            {
                if (hpbuff > 0)
                {
                    m.Hp += hpbuff;
                    m.maxHp += hpbuff;
                }
                else
                {
                    m.maxHp += hpbuff;
                    if (m.maxHp < m.Hp)
                    {
                        m.Hp = m.maxHp;
                    }
                }
                m.wounded = (m.maxHp != m.Hp);
            }

            if (m.Hp <= 0)
            {
                m.minionDied(this);
            }

            // 特殊随从：光耀之子
            // if (m.name == CardDB.cardNameEN.lightspawn && !m.silenced)
            // {
            //     m.Angr = m.Hp;
            // }

            // 特殊随从：血色骑士赛丹
            // if (m.name == CardDB.cardNameEN.saidanthescarlet && !m.silenced)
            // {
            //     m.Angr += attackbuff * 2;
            //     m.Hp += hpbuff * 2;
            // }
        }

        /// <summary>
        /// 给克苏恩增加攻击力、生命值和嘲讽buff，若克苏恩在场上，则应用buff。
        /// </summary>
        /// <param name="attackbuff">增加的攻击力。</param>
        /// <param name="hpbuff">增加的生命值。</param>
        /// <param name="tauntbuff">增加的嘲讽buff。</param>
        public void cthunGetBuffed(int attackbuff, int hpbuff, int tauntbuff)
        {
            this.anzOgOwnCThunAngrBonus += attackbuff;
            this.anzOgOwnCThunHpBonus += hpbuff;
            this.anzOgOwnCThunTaunt += tauntbuff;

            // 如果克苏恩在场，则应用buff
            foreach (Minion m in this.ownMinions)
            {
                if (m.name == CardDB.cardNameEN.cthun)
                {
                    this.minionGetBuffed(m, attackbuff, hpbuff);
                    if (tauntbuff > 0)
                    {
                        m.taunt = true;
                        this.anzOwnTaunt++;
                    }
                }
            }
        }

        /// <summary>
        /// 移除随从的圣盾效果，并触发相关触发器。
        /// </summary>
        /// <param name="m">目标随从。</param>
        public void minionLosesDivineShield(Minion m)
        {
            m.divineshild = false;
            if (m.own) this.tempTrigger.ownMinionLosesDivineShield++;
            else this.tempTrigger.enemyMinionLosesDivineShield++;
        }

        /// <summary>
        /// 处理弃牌逻辑，支持己方和敌方的弃牌行为。
        /// </summary>
        /// <param name="num">需要弃掉的牌的数量。</param>
        /// <param name="own">true 表示己方弃牌，false 表示敌方弃牌。</param>
        public void discardCards(int num, bool own)
        {
            if (own)
            {
                int anz = Math.Min(num, this.owncards.Count);
                if (anz < 1) return; // 如果没有需要弃掉的牌，直接返回

                int numDiscardedCards = anz;
                List<Handmanager.Handcard> discardedCardsBonusList = new List<Handmanager.Handcard>();
                Dictionary<int, int> cardsValDict = new Dictionary<int, int>();

                int bestCardValue = -1, bestCardPos = -1;
                int bestSecondCardValue = -1, bestSecondCardPos = -1;

                // 计算每张牌的价值并找出价值最高的两张牌
                for (int i = 0; i < this.owncards.Count; i++)
                {
                    Handmanager.Handcard hc = this.owncards[i];
                    CardDB.Card c = hc.card;
                    int cardValue = calculateCardValue(hc, c);
                    int ratio = getCardValueRatio(hc.manacost);

                    // 保存卡牌价值的最终计算值
                    cardsValDict.Add(hc.entity, cardValue * ratio / 100);

                    // 更新最有价值的两张牌的位置和价值
                    if (bestCardValue <= cardValue)
                    {
                        bestSecondCardValue = bestCardValue;
                        bestSecondCardPos = bestCardPos;
                        bestCardValue = cardValue;
                        bestCardPos = i;
                    }
                    else if (bestSecondCardValue <= cardValue)
                    {
                        bestSecondCardValue = cardValue;
                        bestSecondCardPos = i;
                    }
                }

                // 处理前两张最有价值的牌的弃牌逻辑
                handleCardDiscard(ref bestCardPos, ref bestCardValue, ref bestSecondCardPos, ref bestSecondCardValue, ref numDiscardedCards, discardedCardsBonusList);

                // 处理剩余的需要弃掉的牌
                handleRemainingCards(anz, ref numDiscardedCards, cardsValDict, discardedCardsBonusList);

                // 触发弃牌任务的进度
                if (this.ownQuest.Id != CardDB.cardIDEnum.None) this.ownQuest.trigger_WasDiscard(numDiscardedCards);

                // 处理玛克扎尔的小鬼等随从的弃牌触发效果
                handleMinionDiscardTriggers(numDiscardedCards, discardedCardsBonusList);

            }
            else
            {
                // 敌方弃牌逻辑
                int anz = Math.Min(num, this.enemyAnzCards);
                if (anz < 1) return;
                this.enemycarddraw -= anz;
                this.enemyAnzCards -= anz;
            }
            this.triggerCardsChanged(own);
        }

        /// <summary>
        /// 计算每张牌的价值，依据随从、武器、法术不同类型分别计算。
        /// </summary>
        /// <param name="hc">手牌。</param>
        /// <param name="c">卡牌信息。</param>
        /// <returns>返回卡牌的计算价值。</returns>
        private int calculateCardValue(Handmanager.Handcard hc, CardDB.Card c)
        {
            int cardValue = 0;
            switch (c.type)
            {
                case CardDB.cardtype.MOB:
                    cardValue = (c.Health + hc.addHp) * 2 + (c.Attack + hc.addattack) * 2 + c.rarity + hc.poweredUp * 2;
                    if (c.windfury) cardValue += c.Attack + hc.addattack;
                    if (c.tank) cardValue += 2;
                    if (c.Shield) cardValue += 2;
                    if (c.Charge) cardValue += 3;
                    if (c.Stealth) cardValue += 1;
                    if (c.isSpecialMinion) cardValue += 10;
                    if (c.nameEN == CardDB.cardNameEN.direwolfalpha && this.ownMinions.Count > 2) cardValue += 10;
                    if (c.nameEN == CardDB.cardNameEN.flametonguetotem && this.ownMinions.Count > 2) cardValue += 10;
                    if (c.nameEN == CardDB.cardNameEN.silverwaregolem || c.nameEN == CardDB.cardNameEN.clutchmotherzavas)
                        cardValue = (c.Health + hc.addHp) * 2 + c.rarity;
                    break;
                case CardDB.cardtype.WEAPON:
                    cardValue = c.Attack * c.Durability * 2;
                    if (c.battlecry || c.deathrattle) cardValue += 7;
                    break;
                case CardDB.cardtype.SPELL:
                    cardValue = 15;
                    break;
            }
            return cardValue;
        }

        /// <summary>
        /// 根据卡牌费用计算价值比率。
        /// </summary>
        /// <param name="manaCost">卡牌的法力消耗。</param>
        /// <returns>返回计算后的比率。</returns>
        private int getCardValueRatio(int manaCost)
        {
            if (manaCost > 1)
            {
                if (manaCost == this.mana) return 80;
                else return 60;
            }
            return 100;
        }

        /// <summary>
        /// 处理最有价值的两张卡牌的弃牌逻辑。
        /// </summary>
        /// <param name="bestCardPos">最有价值卡牌的位置。</param>
        /// <param name="bestCardValue">最有价值卡牌的价值。</param>
        /// <param name="bestSecondCardPos">第二有价值卡牌的位置。</param>
        /// <param name="bestSecondCardValue">第二有价值卡牌的价值。</param>
        /// <param name="numDiscardedCards">需要弃掉的卡牌数量。</param>
        /// <param name="discardedCardsBonusList">弃牌过程中获得奖励的卡牌列表。</param>
        private void handleCardDiscard(ref int bestCardPos, ref int bestCardValue, ref int bestSecondCardPos, ref int bestSecondCardValue, ref int numDiscardedCards, List<Handmanager.Handcard> discardedCardsBonusList)
        {
            Handmanager.Handcard removedhc;
            if (bestSecondCardPos > bestCardPos)
            {
                int tempPos = bestSecondCardPos;
                int tempVal = bestSecondCardValue;
                bestSecondCardPos = bestCardPos;
                bestSecondCardValue = bestCardValue;
                bestCardPos = tempPos;
                bestCardValue = tempVal;
            }

            for (int i = 0; i < numDiscardedCards; i++)
            {
                int cPos = i == 0 ? bestCardPos : bestSecondCardPos;
                int cVal = i == 0 ? bestCardValue : bestSecondCardValue;

                removedhc = this.owncards[cPos];
                this.owncards.RemoveAt(cPos);
                if (removedhc.card.sim_card != null && removedhc.card.sim_card.onCardDicscard(this, removedhc, null, 0, true))
                {
                    discardedCardsBonusList.Add(removedhc);
                    cVal = -6;
                }
                else this.owncarddraw--;
            }
        }

        /// <summary>
        /// 处理剩余需要弃掉的卡牌。
        /// </summary>
        /// <param name="anz">剩余需要弃掉的卡牌数量。</param>
        /// <param name="numDiscardedCards">实际弃掉的卡牌数量。</param>
        /// <param name="cardsValDict">卡牌价值字典。</param>
        /// <param name="discardedCardsBonusList">弃牌过程中获得奖励的卡牌列表。</param>
        private void handleRemainingCards(int anz, ref int numDiscardedCards, Dictionary<int, int> cardsValDict, List<Handmanager.Handcard> discardedCardsBonusList)
        {
            for (int i = 0; i < anz; i++)
            {
                Handmanager.Handcard removedhc = this.owncards[i];
                int bestCardValue = cardsValDict[this.owncards[i].entity];
                if (removedhc.card.sim_card.onCardDicscard(this, removedhc, null, 0, true))
                {
                    discardedCardsBonusList.Add(removedhc);
                    bestCardValue = 0;
                }
                else this.owncarddraw--;
            }
            this.owncards.RemoveRange(0, anz);
        }

        /// <summary>
        /// 处理弃牌相关的随从效果触发，例如玛克扎尔的小鬼。
        /// </summary>
        /// <param name="numDiscardedCards">实际弃掉的卡牌数量。</param>
        /// <param name="discardedCardsBonusList">弃牌过程中获得奖励的卡牌列表。</param>
        private void handleMinionDiscardTriggers(int numDiscardedCards, List<Handmanager.Handcard> discardedCardsBonusList)
        {
            int malchezaarsimpCount = 0;
            foreach (Minion m in this.ownMinions)
            {
                if (m.Hp > 0 && !m.silenced)
                {
                    if (m.name == CardDB.cardNameEN.malchezaarsimp) malchezaarsimpCount++;
                    m.handcard.card.sim_card.onCardDicscard(this, m.handcard, m, numDiscardedCards);
                }
            }

            if (malchezaarsimpCount > 0)
            {
                // 适当调整弃牌后的惩罚值（已删除打分逻辑）
            }

            foreach (Handmanager.Handcard dc in discardedCardsBonusList)
            {
                dc.card.sim_card.onCardDicscard(this, dc, null, 0);
            }
        }

        /// <summary>
        /// 计算己方缺少多少伤害可以达成致命一击（即击败敌方英雄）。
        /// </summary>
        /// <returns>返回缺少的伤害值，如果为负数或零表示可以达成致命一击。</returns>
        public int lethalMissing()
        {
            // 如果之前已经计算过缺少的伤害并且该值小于1000，直接返回
            if (this.lethlMissing < 1000) return lethlMissing;

            // 从AI实例中获取当前致命一击缺少的伤害值
            lethlMissing = Ai.Instance.lethalMissing;

            // 如果缺少的伤害值大于5，直接返回
            if (lethlMissing > 5) return lethlMissing;

            int dmg = 0;

            // 如果敌方没有嘲讽随从，计算所有己方随从的伤害
            if (this.anzEnemyTaunt == 0)
            {
                foreach (Minion m in this.ownMinions)
                {
                    if (!m.Ready || m.frozen) continue; // 跳过无法攻击或被冻结的随从
                    dmg += m.Angr; // 加上随从的攻击力
                    if (m.windfury) dmg += m.Angr; // 如果随从有风怒，额外加一次攻击力
                }
            }
            else
            {
                // 如果敌方有嘲讽随从，逐个考虑如何突破嘲讽
                List<Minion> om = new List<Minion>(this.ownMinions); // 己方随从列表
                List<Minion> omn = new List<Minion>(); // 用于暂时存储不能突破嘲讽的随从
                Minion bm = null; // 用于存储能够突破嘲讽的最佳随从
                int tmp = 0;

                foreach (Minion d in this.enemyMinions)
                {
                    if (!d.taunt) continue; // 跳过非嘲讽随从
                    bm = null;

                    // 找出能够突破当前嘲讽随从的己方随从
                    foreach (Minion m in om)
                    {
                        if (!m.Ready || m.frozen) continue;

                        if (m.Angr < d.Hp)
                        {
                            omn.Add(m); // 如果随从的攻击力不足以击败嘲讽随从，暂时存入omn列表
                        }
                        else
                        {
                            if (bm == null)
                            {
                                bm = m; // 如果没有最佳随从，当前随从为最佳选择
                            }
                            else
                            {
                                if (m.Angr < bm.Angr)
                                {
                                    omn.Add(bm); // 如果当前随从的攻击力比最佳随从低，交换
                                    bm = m;
                                }
                                else
                                {
                                    omn.Add(m); // 否则将当前随从加入到暂存列表
                                }
                            }
                        }
                    }

                    // 如果没有找到突破当前嘲讽随从的随从，退出循环
                    if (bm == null)
                    {
                        dmg = 0;
                        tmp = 0;
                        break;
                    }

                    tmp++;
                    om.Clear();
                    om.AddRange(omn);
                    omn.Clear();
                }

                // 如果能够突破所有嘲讽随从，计算剩余随从的总伤害
                if (tmp >= this.anzEnemyTaunt)
                {
                    foreach (Minion m in om)
                    {
                        dmg += m.Angr;
                        if (m.windfury) dmg += m.Angr; // 如果随从有风怒，额外加一次攻击力
                    }
                }
            }

            // 计算缺少的伤害值，敌方英雄的当前血量减去己方的总伤害
            lethlMissing = this.enemyHero.Hp - dmg;

            return lethlMissing;
        }

        /// <summary>
        /// 判断下一回合是否能够获胜。此方法考虑了己方随从、法术以及敌方嘲讽等因素。
        /// </summary>
        /// <returns>如果能够在下一回合获胜，则返回true；否则返回false。</returns>
        public bool nextTurnWin()
        {
            // 首先检查是否有敌方嘲讽随从存在
            if (this.anzEnemyTaunt > 0)
            {
                // 如果存在敌方嘲讽，检查是否能通过其他手段如法术或特殊随从效果击败敌方英雄
                int potentialDmg = CalculatePotentialDamage();
                if (this.enemyHero.Hp > potentialDmg)
                {
                    return false;
                }
            }
            else
            {
                // 如果没有嘲讽随从，计算己方随从的总伤害
                int dmg = 0;
                foreach (Minion m in this.ownMinions)
                {
                    if (m.frozen) continue; // 跳过被冻结的随从
                    dmg += m.Angr; // 加上随从的攻击力
                    if (m.windfury) dmg += m.Angr; // 如果随从有风怒，额外加一次攻击力
                }
                // 如果己方随从的伤害不足以击败敌方英雄，返回false
                if (this.enemyHero.Hp > dmg)
                {
                    return false;
                }
            }

            // 如果可以通过随从或法术等手段击败敌方英雄，返回true
            return true;
        }

        /// <summary>
        /// 计算潜在的总伤害，包括随从攻击和可能的法术伤害。
        /// </summary>
        /// <returns>返回可以造成的潜在总伤害值。</returns>
        private int CalculatePotentialDamage()
        {
            int totalDamage = 0;

            // 计算己方随从的伤害
            foreach (Minion m in this.ownMinions)
            {
                if (!m.frozen)
                {
                    totalDamage += m.Angr;
                    if (m.windfury) totalDamage += m.Angr; // 风怒随从可以攻击两次
                }
            }

            // 考虑己方手中的法术伤害
            foreach (Handmanager.Handcard hc in this.owncards)
            {
                if (hc.card.type == CardDB.cardtype.SPELL)
                {
                    // 根据法术ID判断其直接伤害值
                    int spellDamage = 0;
                    switch (hc.card.cardIDenum)
                    {
                        case CardDB.cardIDEnum.CS2_029: // 火球术（Fireball）
                            spellDamage = 6 + this.spellpower; // 基础伤害为6，加上法术强度
                            break;
                        case CardDB.cardIDEnum.EX1_238: // 闪电箭（Lightning Bolt）
                            spellDamage = 3 + this.spellpower; // 基础伤害为3，加上法术强度
                            break;
                        case CardDB.cardIDEnum.CS2_087: // 地狱烈焰（Hellfire）
                            spellDamage = 3 + this.spellpower; // 对所有角色造成3点伤害，加上法术强度
                            break;
                        case CardDB.cardIDEnum.CORE_CS2_024: // 寒冰箭（Frostbolt）
                            spellDamage = 3 + this.spellpower; // 基础伤害为3，加上法术强度
                            break;
                            // 在这里添加其他直接对敌方英雄造成伤害的法术
                    }

                    totalDamage += spellDamage;
                }
            }

            return totalDamage;
        }

        /// <summary>
        /// 计算直伤伤害
        /// </summary>
        /// <param name="mana"></param>
        /// <param name="force">计算当前回合不考虑对手有嘲讽的情况</param>
        /// <param name="calNextTurn">计算下回合斩杀</param>
        /// <param name="maxCal">出牌上限</param>
        /// <param name="calMax">最多考虑的可能的出牌数量</param>
        /// <returns></returns>
        public int calDirectDmg(int mana, bool force, bool calNextTurn = false, int maxCal = 15, int calMax = 15)
        {
            if (mana < 0) mana = 0;
            if (mana > 10) mana = 10;

            int flag = 0;
            // 手上的幸运币/激活
            foreach (Handmanager.Handcard hc in this.owncards)
            {
                switch (hc.card.nameCN)
                {
                    case CardDB.cardNameCN.幸运币: mana++; break;
                    case CardDB.cardNameCN.激活: { mana++; if (hc.card.cardIDenum == CardDB.cardIDEnum.VAN_EX1_169) { mana++; flag |= 8; } break; }
                    case CardDB.cardNameCN.雷霆绽放: mana += 2; break;
                    case CardDB.cardNameCN.自然之力:
                        flag |= 1;
                        break;
                    case CardDB.cardNameCN.野蛮咆哮:
                        if ((flag & 2) == 1) flag |= 4;
                        flag |= 2;
                        break;
                }
            }

            // 01背包
            int[] cost = new int[100];
            int[] dmg = new int[100];
            int[][] dp = new int[100][];
            for (int i = 0; i < maxCal; i++)
            {
                dp[i] = new int[100];
            }
            int cnt = 1;
            if (this.ownAbilityReady || calNextTurn)
                switch (this.ownHeroAblility.card.nameCN)
                {
                    case CardDB.cardNameCN.恶魔之爪:
                    case CardDB.cardNameCN.变形:
                        if (this.anzEnemyTaunt == 0 && this.ownHero.numAttacksThisTurn == 0)
                        {
                            cost[cnt] = this.ownHeroAblility.getManaCost(this);
                            dmg[cnt] = 1;
                            cnt++;
                        }
                        break;
                    case CardDB.cardNameCN.恶魔之咬:
                    case CardDB.cardNameCN.恐怖变形:
                        if (this.anzEnemyTaunt == 0 && this.ownHero.numAttacksThisTurn == 0)
                        {
                            cost[cnt] = this.ownHeroAblility.getManaCost(this);
                            dmg[cnt] = 2;
                            cnt++;
                        }
                        break;
                    case CardDB.cardNameCN.火焰冲击:
                        cost[cnt] = this.ownHeroAblility.getManaCost(this);
                        dmg[cnt] = 1 + this.ownHeroPowerExtraDamage;
                        cnt++;
                        break;
                    case CardDB.cardNameCN.二级火焰冲击:
                    case CardDB.cardNameCN.心灵尖刺:
                    case CardDB.cardNameCN.稳固射击:
                        cost[cnt] = this.ownHeroAblility.getManaCost(this);
                        dmg[cnt] = 2 + this.ownHeroPowerExtraDamage;
                        cnt++;
                        break;
                    case CardDB.cardNameCN.弩炮射击:
                        cost[cnt] = this.ownHeroAblility.getManaCost(this);
                        dmg[cnt] = 3 + this.ownHeroPowerExtraDamage;
                        cnt++;
                        break;
                    case CardDB.cardNameCN.生命分流:
                        if (this.anzTamsin)
                        {
                            cost[cnt] = this.ownHeroAblility.getManaCost(this);
                            dmg[cnt] = 2 + this.ownHeroPowerExtraDamage;
                            cnt++;
                        }
                        break;
                }
            bool canAttack = false;
            int extra = 0;
            foreach (Minion m in this.ownMinions)
            {
                if (this.anzTamsin && m.handcard.card.nameCN == CardDB.cardNameCN.无证药剂师) extra++;
                if (m.Ready && !m.cantAttackHeroes) canAttack = true;
            }
            foreach (Handmanager.Handcard hc in this.owncards)
            {
                // 冲锋
                if (((hc.card.Charge) || hc.card.Durability > 0 && this.ownWeapon.Durability == 0 || hc.card.nameCN == CardDB.cardNameCN.利爪德鲁伊) && (this.anzEnemyTaunt == 0 || force) && hc.addattack + hc.card.Attack > 0)
                {
                    cost[cnt] = hc.manacost;
                    dmg[cnt] = hc.addattack + hc.card.Attack;
                }
                // 法术直伤
                switch (hc.card.nameCN)
                {
                    case CardDB.cardNameCN.炎爆术:
                        dmg[cnt] += 10 + this.spellpower;
                        break;
                    case CardDB.cardNameCN.火球术:
                        dmg[cnt] += 6 + this.spellpower;
                        break;
                    case CardDB.cardNameCN.邪火药水:
                    case CardDB.cardNameCN.埃匹希斯冲击:
                    case CardDB.cardNameCN.心灵震爆:
                        dmg[cnt] += 5 + this.spellpower;
                        break;
                    case CardDB.cardNameCN.标记射击:
                    case CardDB.cardNameCN.废铁射击:
                    case CardDB.cardNameCN.深水炸弹:
                    case CardDB.cardNameCN.虚空碎片:
                    case CardDB.cardNameCN.冰枪术:
                    case CardDB.cardNameCN.横扫:
                    case CardDB.cardNameCN.灵魂之火:
                        dmg[cnt] += 4 + this.spellpower;
                        break;
                    case CardDB.cardNameCN.快速射击:
                    case CardDB.cardNameCN.影袭:
                    case CardDB.cardNameCN.诱饵射击:
                    case CardDB.cardNameCN.恶魔来袭:
                    case CardDB.cardNameCN.地狱烈焰:
                    case CardDB.cardNameCN.闪电箭:
                    case CardDB.cardNameCN.毒蛇神殿传送门:
                    case CardDB.cardNameCN.寒冰箭:
                    case CardDB.cardNameCN.杀戮命令:
                        dmg[cnt] += 3 + this.spellpower;
                        break;
                    case CardDB.cardNameCN.奉献:
                    case CardDB.cardNameCN.图腾重击:
                    case CardDB.cardNameCN.符文宝珠:
                    case CardDB.cardNameCN.末日灾祸:
                    case CardDB.cardNameCN.点燃:
                    case CardDB.cardNameCN.奥术射击:
                        dmg[cnt] += 2 + this.spellpower;
                        break;
                    case CardDB.cardNameCN.冰霜震击:
                    case CardDB.cardNameCN.火焰之雨:
                    case CardDB.cardNameCN.急速射击:
                    case CardDB.cardNameCN.击伤猎物:
                        dmg[cnt] += 1 + this.spellpower;
                        break;
                    case CardDB.cardNameCN.关门放狗:
                        dmg[cnt] += this.enemyMinions.Count;
                        break;
                    case CardDB.cardNameCN.瞄准射击:
                        dmg[cnt] += 3 + this.spellpower;
                        break;


                    // 战吼
                    case CardDB.cardNameCN.火眼莫德雷斯:
                        if (hc.poweredUp > 0)
                            dmg[cnt] += 10;
                        break;
                    case CardDB.cardNameCN.生命的缚誓者阿莱克丝塔萨:
                        dmg[cnt] += 8;
                        break;
                    case CardDB.cardNameCN.云雾王子:
                        if (hc.poweredUp > 0)
                            dmg[cnt] += 6;
                        break;
                    case CardDB.cardNameCN.遮天雨云:
                        if (hc.poweredUp > 0)
                            dmg[cnt] += 5;
                        break;
                    case CardDB.cardNameCN.小刀商贩:
                        if (this.ownHero.Hp > 4)
                            dmg[cnt] += 4;
                        break;
                    case CardDB.cardNameCN.马戏团医师:
                        if (hc.card.cardIDenum == CardDB.cardIDEnum.DMF_174t)
                            dmg[cnt] += 4;
                        break;
                    case CardDB.cardNameCN.旋岩虫:
                        if (hc.poweredUp > 0)
                            dmg[cnt] += 3;
                        break;
                    case CardDB.cardNameCN.渊狱惩击者:
                        dmg[cnt] += 3;
                        break;
                    case CardDB.cardNameCN.迦顿男爵:
                    case CardDB.cardNameCN.雾帆劫掠者:
                    case CardDB.cardNameCN.丛林守护者:
                        dmg[cnt] += 2;
                        break;
                    case CardDB.cardNameCN.南海岸酋长:
                        if (hc.poweredUp > 0)
                            dmg[cnt] += 2;
                        break;
                    case CardDB.cardNameCN.精灵弓箭手:
                        dmg[cnt] += 1;
                        break;
                    case CardDB.cardNameCN.暗影投弹手:
                        if (this.ownHero.Hp > 3)
                            dmg[cnt] += 3;
                        break;
                    case CardDB.cardNameCN.力量的代价:
                        if (canAttack)
                        {
                            dmg[cnt] += 4;
                            if (this.anzTamsinroame > 0 && hc.getManaCost(this) > 0)
                            {
                                dmg[cnt] += 4 * this.anzTamsinroame;
                            }
                        }
                        break;
                    case CardDB.cardNameCN.萌物来袭:
                        if (canAttack) dmg[cnt] += 1;
                        break;
                    case CardDB.cardNameCN.灵魂炸弹:
                        if (this.anzTamsin)
                        {
                            dmg[cnt] += 4;
                            if (this.anzTamsinroame > 0 && hc.getManaCost(this) > 0)
                            {
                                dmg[cnt] += 4 * this.anzTamsinroame;
                            }
                        }
                        break;
                    case CardDB.cardNameCN.亡者复生:
                        if (this.anzTamsin) dmg[cnt] += 3;
                        break;
                    case CardDB.cardNameCN.晶化师:
                        if (this.anzTamsin) dmg[cnt] += 5;
                        break;
                    case CardDB.cardNameCN.烈焰小鬼:
                        if (this.anzTamsin) dmg[cnt] += 3;
                        break;
                    case CardDB.cardNameCN.狗头人图书管理员:
                        if (this.anzTamsin) dmg[cnt] += 2;
                        break;
                    case CardDB.cardNameCN.粗俗的矮劣魔:
                        if (this.anzTamsin) dmg[cnt] += 2;
                        break;
                    default:
                        break;
                }
                // 走A模式
                // if (this.ownHero.enchs.IndexOf("CFM_020e") > 0)
                // {
                //     dmg[cnt] += 2;
                // }
                int ReadyCount = 0, murlocCount = 0;
                bool foundWind = false;
                foreach (Minion m in this.ownMinions)
                {
                    if ((m.Ready || calNextTurn) && !m.cantAttackHeroes && !m.frozen)
                    {
                        ReadyCount++;
                        if (m.handcard.card.race == CardDB.Race.MURLOC || m.handcard.card.race == CardDB.Race.ALL) murlocCount++;
                        if (m.windfury) foundWind = true;
                    }
                }
                // 加攻法术
                if (this.anzEnemyTaunt == 0 || force)
                {
                    switch (hc.card.nameCN)
                    {
                        case CardDB.cardNameCN.自然之力:
                            if (hc.card.cardIDenum == CardDB.cardIDEnum.VAN_EX1_571)
                            {
                                dmg[cnt] += 6;
                            }
                            break;
                        case CardDB.cardNameCN.铁肤古夫:
                            dmg[cnt] += 8;
                            break;
                        case CardDB.cardNameCN.爪击:
                        case CardDB.cardNameCN.飞扑:
                            dmg[cnt] += 2;
                            break;
                        case CardDB.cardNameCN.风暴打击:
                        case CardDB.cardNameCN.铁齿铜牙:
                            dmg[cnt] += 3;
                            break;
                        case CardDB.cardNameCN.月触项链:
                        case CardDB.cardNameCN.野性之怒:
                        case CardDB.cardNameCN.撕咬:
                            dmg[cnt] += 4;
                            break;
                        default:
                            break;
                    }
                    if (ReadyCount > 0)
                    {
                        switch (hc.card.nameCN)
                        {
                            case CardDB.cardNameCN.王者祝福:
                                dmg[cnt] += 4;
                                if (foundWind) dmg[cnt] += 4;
                                break;
                            case CardDB.cardNameCN.暗鳞先知:
                                dmg[cnt] += murlocCount;
                                break;
                            case CardDB.cardNameCN.鱼人领军:
                            case CardDB.cardNameCN.鱼勇可贾:
                            case CardDB.cardNameCN.鱼人恩典:
                                dmg[cnt] += murlocCount * 2;
                                break;
                            case CardDB.cardNameCN.塞纳留斯:
                                dmg[cnt] += ReadyCount * 2;
                                if (foundWind) dmg[cnt] += 2;
                                break;
                            case CardDB.cardNameCN.野蛮咆哮:
                                dmg[cnt] += (ReadyCount + 1) * 2;
                                if (foundWind) dmg[cnt] += 2;
                                break;
                            case CardDB.cardNameCN.玉莲印记:
                            case CardDB.cardNameCN.野性之力:
                                dmg[cnt] += ReadyCount * 1;
                                if (foundWind) dmg[cnt] += 1;
                                break;
                        }
                    }
                }
                if (extra > 0 && hc.card.type == CardDB.cardtype.MOB)
                {
                    dmg[cnt] += 5 * extra;
                }
                if (dmg[cnt] > 0)
                {
                    cost[cnt] = hc.getManaCost(this);
                    cnt++;
                }
            }
            int nextTurnMana = mana;
            // 虚触侍从
            if (this.anzOldWoman > 0 && !calNextTurn)
            {
                for (int i = 0; i < maxCal; i++)
                {
                    if (dmg[i] > 0) dmg[i] += this.anzOldWoman;
                }
            }

            // 计算对手最多使用 calMax 张牌时的斩杀线，需要用多维背包计算
            if (calMax != 15)
            {
                if (maxCal > 40) maxCal = 40;
                if (maxCal < cnt) maxCal = cnt + 1;

                int[][][] muitiDp = new int[45][][];
                for (int i = 0; i < maxCal; i++)
                {
                    muitiDp[i] = new int[45][];
                    for (int j = 0; j <= nextTurnMana + 5; j++)
                    {
                        muitiDp[i][j] = new int[45];
                    }
                }
                // i 张牌
                for (int i = 1; i <= cnt; i++)
                    // 费用 j
                    for (int j = 0; j <= nextTurnMana; j++)
                        // 总手牌数
                        for (int k = 0; k <= calMax; k++)
                        {
                            muitiDp[i][j][k] = muitiDp[i - 1][j][k];
                            if (j >= cost[i] && k >= 1)
                            {
                                var tmp = dmg[i] + muitiDp[i - 1][j - cost[i]][k - 1];
                                if (tmp > muitiDp[i][j][k]) muitiDp[i][j][k] = tmp;
                            }
                        }
                int enemyMaxDmg = muitiDp[cnt][nextTurnMana][calMax];
                // 自然之力咆哮
                if ((this.anzEnemyTaunt == 0 || force) && mana >= 9 && flag == 3 && enemyMaxDmg < 14 + this.ownMinions.Count * 2) enemyMaxDmg = 14 + this.ownMinions.Count * 2;
                // 自然之力双咆哮
                if ((this.anzEnemyTaunt == 0 || force) && mana >= 12 && flag == 15 && enemyMaxDmg < 20 + this.ownMinions.Count * 4) enemyMaxDmg = 20 + this.ownMinions.Count * 4;
                return enemyMaxDmg;
            }

            // 第 i 张牌
            for (int i = 1; i <= cnt; i++)
            {
                // 剩余费用
                for (int j = 1; j <= nextTurnMana; j++)
                {
                    // 打不出去
                    if (cost[i] > j)
                    {
                        dp[i][j] = dp[i - 1][j];
                    }
                    else
                    {
                        // 能出牌的情况取其中最大伤害
                        dp[i][j] = Math.Max(dp[i - 1][j - cost[i]] + dmg[i], dp[i - 1][j]);
                    }
                }
            }
            int maxDmg = dp[cnt][nextTurnMana];
            // 自然之力咆哮
            if ((this.anzEnemyTaunt == 0 || force) && mana >= 9 && flag == 3 && maxDmg < 14 + this.ownMinions.Count * 2) maxDmg = 14 + this.ownMinions.Count * 2;
            // 自然之力双咆哮
            if ((this.anzEnemyTaunt == 0 || force) && mana >= 12 && flag == 15 && maxDmg < 20 + this.ownMinions.Count * 4) maxDmg = 20 + this.ownMinions.Count * 4;
            return maxDmg;
        }

        /// <summary>
        /// 将随从的攻击力设置为指定的数值，并更新所有区域性增益或减益。
        /// </summary>
        /// <param name="m">目标随从</param>
        /// <param name="newAngr">新的攻击力值</param>
        public void minionSetAngrToX(Minion m, int newAngr)
        {
            // 如果随从未被沉默，并且是光耀之子（lightspawn），则不改变其攻击力
            // if (!m.silenced && m.name == CardDB.cardNameEN.lightspawn) return;

            // 设置随从的攻击力为新值，并重置临时攻击力增益
            m.Angr = newAngr;
            m.tempAttack = 0;

            // 重新计算并应用所有区域性增益或减益
            this.minionGetOrEraseAllAreaBuffs(m, true);
        }

        /// <summary>
        /// 将随从的生命值设置为指定的数值，并更新所有区域性增益或减益。
        /// </summary>
        /// <param name="m">目标随从</param>
        /// <param name="newHp">新的生命值</param>
        public void minionSetLifetoX(Minion m, int newHp)
        {
            // 移除当前的区域性增益或减益
            minionGetOrEraseAllAreaBuffs(m, false);

            // 设置随从的生命值和最大生命值为新值
            m.Hp = newHp;
            m.maxHp = newHp;

            // 如果随从曾经受伤且未被沉默，则停止激怒效果
            if (m.wounded && !m.silenced) m.handcard.card.sim_card.onEnrageStop(this, m);

            // 标记随从为未受伤状态
            m.wounded = false;

            // 重新计算并应用所有区域性增益或减益
            minionGetOrEraseAllAreaBuffs(m, true);
            if (m.Hp <= 0)
            {
                m.minionDied(this);
            }
        }

        /// <summary>
        /// 将随从的攻击力设置为与其生命值相同的数值。
        /// </summary>
        /// <param name="m">目标随从</param>
        public void minionSetAngrToHP(Minion m)
        {
            // 设置随从的攻击力为其当前的生命值，并重置临时攻击力增益
            m.Angr = m.Hp;
            m.tempAttack = 0;

            // 重新计算并应用所有区域性增益或减益
            this.minionGetOrEraseAllAreaBuffs(m, true);
        }

        /// <summary>
        /// 交换随从的攻击力和生命值，并处理相应的状态变化。
        /// </summary>
        /// <param name="m">目标随从</param>
        public void minionSwapAngrAndHP(Minion m)
        {
            // 记录随从在交换前是否受伤
            bool woundedbef = m.wounded;

            // 交换攻击力和生命值
            int temp = m.Angr;
            m.Angr = m.Hp;
            m.Hp = temp;
            m.maxHp = temp;

            // 将随从标记为未受伤状态，如果之前受伤，则停止激怒效果
            m.wounded = false;
            if (woundedbef) m.handcard.card.sim_card.onEnrageStop(this, m);

            // 如果交换后随从的生命值小于等于0，标记为死亡
            if (m.Hp <= 0)
            {
                if (m.own) this.tempTrigger.ownMinionsDied++;
                else this.tempTrigger.enemyMinionsDied++;
            }

            // 重新计算并应用所有区域性增益或减益
            this.minionGetOrEraseAllAreaBuffs(m, true);
        }

        /// <summary>
        /// 对指定的随从造成伤害或进行治疗。
        /// </summary>
        /// <param name="m">目标随从</param>
        /// <param name="dmgOrHeal">正数表示伤害，负数表示治疗</param>
        /// <param name="dontDmgLoss">是否计算失去的伤害值（默认为false）</param>
        public void minionGetDamageOrHeal(Minion m, int dmgOrHeal, bool dontDmgLoss = false)
        {
            // 如果随从还活着，则调用随从自身的受伤或治疗方法
            if (m.Hp > 0)
            {
                m.getDamageOrHeal(dmgOrHeal, this, false, dontDmgLoss);
            }
        }

        /// <summary>
        /// 对一方的所有随从造成伤害。
        /// </summary>
        /// <param name="own">是否为己方随从</param>
        /// <param name="damages">伤害值</param>
        /// <param name="frozen">是否同时冻结随从</param>
        public void allMinionOfASideGetDamage(bool own, int damages)
        {
            List<Minion> temp = (own) ? this.ownMinions : this.enemyMinions;
            foreach (Minion m in temp)
            {
                minionGetDamageOrHeal(m, damages, true); // 然后对随从造成伤害
            }
            this.updateBoards(); // 更新游戏板状态
        }

        /// <summary>
        /// 对一方的所有角色（英雄和随从）造成伤害。
        /// </summary>
        /// <param name="own">是否为己方角色</param>
        /// <param name="damages">伤害值</param>
        public void allCharsOfASideGetDamage(bool own, int damages)
        {
            List<Minion> temp = (own) ? this.ownMinions : this.enemyMinions;
            foreach (Minion m in temp)
            {
                minionGetDamageOrHeal(m, damages, true); // 对每个随从造成伤害
            }

            this.minionGetDamageOrHeal(own ? this.ownHero : this.enemyHero, damages); // 对英雄造成伤害
        }

        /// <summary>
        /// 对一方的所有角色（英雄和随从）随机造成多次伤害。
        /// </summary>
        /// <param name="ownSide">是否为己方角色</param>
        /// <param name="times">伤害次数</param>
        public void allCharsOfASideGetRandomDamage(bool ownSide, int times)
        {
            if ((!ownSide && this.enemyHero.Hp + this.enemyHero.armor <= times) || (ownSide && this.ownHero.Hp + this.ownHero.armor <= times))
            {
                if (!ownSide)
                {
                    int dmg = this.enemyHero.Hp + this.enemyHero.armor;  //假设情况下的伤害值
                    if (this.enemyMinions.Count > 2) dmg--;
                    times = times - dmg;
                    if (this.anzEnemyAnimatedArmor > 0)
                    {
                        for (; dmg > 0; dmg--)
                        {
                            this.minionGetDamageOrHeal(this.enemyHero, 1); // 若敌方有动画护甲，则逐点伤害
                        }
                    }
                    else
                    {
                        this.minionGetDamageOrHeal(this.enemyHero, dmg); // 一次性造成所有伤害
                    }
                }
                else
                {
                    int dmg = this.ownHero.Hp + this.ownHero.armor - 1;
                    times = times - dmg;
                    if (this.anzOwnAnimatedArmor > 0)
                    {
                        for (; dmg > 0; dmg--)
                        {
                            this.minionGetDamageOrHeal(this.ownHero, 1); // 若己方有动画护甲，则逐点伤害
                        }
                    }
                    else
                    {
                        this.minionGetDamageOrHeal(this.ownHero, dmg); // 一次性造成所有伤害
                    }
                }
            }

            List<Minion> temp = (ownSide) ? new List<Minion>(this.ownMinions) : new List<Minion>(this.enemyMinions);
            temp.Sort((a, b) => { int tmp = a.Hp.CompareTo(b.Hp); return tmp == 0 ? a.Angr - b.Angr : tmp; }); // 按生命值排序

            int border = 1;
            for (int pos = 0; pos < temp.Count; pos++)
            {
                Minion m = temp[pos];
                if (m.divineshild)
                {
                    m.divineshild = false; // 移除圣盾
                    times--;
                    if (times < 1) break;
                }
                if (m.Hp > border)
                {
                    int dmg = Math.Min(m.Hp - border, times); // 计算随从承受的伤害
                    times -= dmg;
                    this.minionGetDamageOrHeal(m, dmg);
                }
                if (times < 1) break;
            }
            if (times > 0)
            {
                int dmg = times;
                if (!ownSide)
                {
                    if (this.anzEnemyAnimatedArmor > 0)
                    {
                        for (; dmg > 0; dmg--)
                        {
                            this.minionGetDamageOrHeal(this.enemyHero, 1); // 若敌方有动画护甲，则逐点伤害
                        }
                    }
                    else
                    {
                        this.minionGetDamageOrHeal(this.enemyHero, dmg); // 一次性造成所有伤害
                    }
                }
                else
                {
                    if (this.anzOwnAnimatedArmor > 0)
                    {
                        for (; dmg > 0; dmg--)
                        {
                            this.minionGetDamageOrHeal(this.ownHero, 1); // 若己方有动画护甲，则逐点伤害
                        }
                    }
                    else
                    {
                        this.minionGetDamageOrHeal(this.ownHero, dmg); // 一次性造成所有伤害
                    }
                }
            }
        }

        /// <summary>
        /// 对所有角色（包括英雄和随从）造成伤害，可选择排除某个特定实体。
        /// </summary>
        /// <param name="damages">要造成的伤害值</param>
        /// <param name="exceptID">排除的实体ID（默认为-1，即不排除任何实体）</param>
        public void allCharsGetDamage(int damages, int exceptID = -1)
        {
            // 对己方所有随从造成伤害，排除exceptID的实体
            foreach (Minion m in this.ownMinions)
            {
                if (m.entitiyID != exceptID)
                {
                    minionGetDamageOrHeal(m, damages, true);
                }
            }
            // 对敌方所有随从造成伤害，排除exceptID的实体
            foreach (Minion m in this.enemyMinions)
            {
                if (m.entitiyID != exceptID)
                {
                    minionGetDamageOrHeal(m, damages, true);
                }
            }
            // 对己方英雄造成伤害
            minionGetDamageOrHeal(this.ownHero, damages);
            // 对敌方英雄造成伤害
            minionGetDamageOrHeal(this.enemyHero, damages);
        }

        /// <summary>
        /// 对所有随从造成伤害，可选择排除某个特定实体。
        /// </summary>
        /// <param name="damages">要造成的伤害值</param>
        /// <param name="exceptID">排除的实体ID（默认为-1，即不排除任何实体）</param>
        public void allMinionsGetDamage(int damages, int exceptID = -1)
        {
            // 对己方所有随从造成伤害，排除exceptID的实体
            foreach (Minion m in this.ownMinions.ToArray())
            {
                if (m.entitiyID != exceptID)
                {
                    minionGetDamageOrHeal(m, damages, true);
                }
            }
            // 对敌方所有随从造成伤害，排除exceptID的实体
            foreach (Minion m in this.enemyMinions.ToArray())
            {
                if (m.entitiyID != exceptID)
                {
                    minionGetDamageOrHeal(m, damages, true);
                }
            }
        }

        /// <summary>
        /// 对一方的随机角色造成指定入参的伤害
        /// </summary>
        /// <param name="isEnemy">如果为 true，则对敌方角色造成伤害；否则对己方角色造成伤害。</param>
        /// <param name="damage">要造成的伤害量。</param>
        public void DealDamageToRandomCharacter(bool isEnemy, int damage)
        {
            List<Minion> possibleTargets = isEnemy ? this.enemyMinions : this.ownMinions;

            // 将英雄加入到可能的目标中
            if (isEnemy)
            {
                possibleTargets.Add(this.enemyHero);
            }
            else
            {
                possibleTargets.Add(this.ownHero);
            }

            // 从可能的目标中随机选择一个
            Minion target = possibleTargets[getRandomNumber(0, possibleTargets.Count - 1)];

            // 对选定的目标造成伤害
            this.minionGetDamageOrHeal(target, damage);
        }

        /// <summary>
        /// 更换英雄技能（英雄技能在游戏中被称为Hero Power）。
        /// </summary>
        /// <param name="newHeroPower">新的英雄技能卡牌ID</param>
        /// <param name="own">是否为己方英雄</param>
        public void setNewHeroPower(CardDB.cardIDEnum newHeroPower, bool own)
        {
            if (own)
            {
                // 设置己方英雄的新技能
                this.ownHeroAblility.card = CardDB.Instance.getCardDataFromID(newHeroPower);
                this.ownAbilityReady = true; // 确保英雄技能可以使用
            }
            else
            {
                // 设置敌方英雄的新技能
                this.enemyHeroAblility.card = CardDB.Instance.getCardDataFromID(newHeroPower);
                this.enemyAbilityReady = true; // 确保英雄技能可以使用
            }
        }

        /// <summary>
        /// 根据卡牌类型或属性筛选手牌，并标记符合条件的卡牌。
        /// </summary>
        /// <param name="cards">需要筛选的手牌列表</param>
        /// <param name="tag">要筛选的卡牌属性或类型</param>
        /// <param name="race">当筛选条件为种族时的具体种族，默认为无效种族</param>
        private void getHandcardsByType(List<Handmanager.Handcard> cards, GAME_TAGs tag, TAG_RACE race = TAG_RACE.INVALID)
        {
            switch (tag)
            {
                case GAME_TAGs.None:
                    // 无条件筛选，标记所有卡牌
                    foreach (Handmanager.Handcard hc in cards)
                    {
                        hc.extraParam3 = true;
                    }
                    break;
                case GAME_TAGs.Spell:
                    // 筛选法术牌
                    foreach (Handmanager.Handcard hc in cards)
                    {
                        if (hc.card.type == CardDB.cardtype.SPELL)
                        {
                            hc.extraParam3 = true;
                        }
                    }
                    break;
                case GAME_TAGs.SECRET:
                    // 筛选奥秘牌
                    foreach (Handmanager.Handcard hc in cards)
                    {
                        if (hc.card.Secret)
                        {
                            hc.extraParam3 = true;
                        }
                    }
                    break;
                case GAME_TAGs.Mob:
                    // 筛选随从牌
                    foreach (Handmanager.Handcard hc in cards)
                    {
                        if (hc.card.type == CardDB.cardtype.MOB)
                        {
                            hc.extraParam3 = true;
                        }
                    }
                    break;
                case GAME_TAGs.CARDRACE:
                    // 筛选特定种族的随从牌
                    foreach (Handmanager.Handcard hc in cards)
                    {
                        if (hc.card.type == CardDB.cardtype.MOB)
                        {
                            if (race == TAG_RACE.INVALID)
                            {
                                hc.extraParam3 = true;
                            }
                            else if (hc.card.race == (CardDB.Race)race)
                            {
                                hc.extraParam3 = true;
                            }
                        }
                    }
                    break;
                case GAME_TAGs.TAUNT:
                    // 筛选具有嘲讽属性的卡牌
                    foreach (Handmanager.Handcard hc in cards)
                    {
                        if (hc.card.tank)
                        {
                            hc.extraParam3 = true;
                        }
                    }
                    break;
                case GAME_TAGs.COMBO:
                    // 筛选具有连击属性的卡牌
                    foreach (Handmanager.Handcard hc in cards)
                    {
                        if (hc.card.Combo)
                        {
                            hc.extraParam3 = true;
                        }
                    }
                    break;
                case GAME_TAGs.DIVINE_SHIELD:
                    // 筛选具有圣盾属性的卡牌
                    foreach (Handmanager.Handcard hc in cards)
                    {
                        if (hc.card.Shield)
                        {
                            hc.extraParam3 = true;
                        }
                    }
                    break;
                case GAME_TAGs.ENRAGED:
                    // 筛选具有激怒属性的卡牌
                    foreach (Handmanager.Handcard hc in cards)
                    {
                        if (hc.card.Enrage)
                        {
                            hc.extraParam3 = true;
                        }
                    }
                    break;
                case GAME_TAGs.LIFESTEAL:
                    // 筛选具有吸血属性的卡牌
                    foreach (Handmanager.Handcard hc in cards)
                    {
                        if (hc.card.lifesteal)
                        {
                            hc.extraParam3 = true;
                        }
                    }
                    break;
                case GAME_TAGs.OVERLOAD:
                    // 筛选具有过载属性的卡牌
                    foreach (Handmanager.Handcard hc in cards)
                    {
                        if (hc.card.overload > 0)
                        {
                            hc.extraParam3 = true;
                        }
                    }
                    break;
                case GAME_TAGs.CLASS:
                    // 筛选当前职业的卡牌
                    foreach (Handmanager.Handcard hc in cards)
                    {
                        if (hc.card.Class == (int)ownHeroStartClass)
                        {
                            hc.extraParam3 = true;
                        }
                    }
                    break;
                case GAME_TAGs.Weapon:
                    // 筛选武器牌
                    foreach (Handmanager.Handcard hc in cards)
                    {
                        if (hc.card.type == CardDB.cardtype.WEAPON)
                        {
                            hc.extraParam3 = true;
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// 计算己方所有可以攻击英雄的角色的总攻击力，包括随从和英雄自身。
        /// </summary>
        /// <returns>返回计算后的总攻击力</returns>
        public int calTotalAngr()
        {
            if (this.totalAngr == -1)
            {
                this.totalAngr = 0;

                // 计算己方随从的攻击力
                for (int i = 0; i < this.ownMinions.Count; i++)
                {
                    // 确保随从可以攻击并且可以攻击英雄
                    if (this.ownMinions[i].Ready && !this.ownMinions[i].cantAttackHeroes)
                    {
                        this.totalAngr += this.ownMinions[i].Angr;

                        // 判断随从是否具有风怒或受到战场军官的影响而获得额外攻击机会
                        if (this.ownMinions[i].windfury ||
                            (i > 0 && this.ownMinions[i - 1].handcard.card.nameCN == CardDB.cardNameCN.战场军官 && !this.ownMinions[i - 1].silenced) ||
                            (i < this.ownMinions.Count - 1 && this.ownMinions[i + 1].handcard.card.nameCN == CardDB.cardNameCN.战场军官 && !this.ownMinions[i + 1].silenced))
                        {
                            if (this.ownMinions[i].numAttacksThisTurn == 0)
                            {
                                this.totalAngr += this.ownMinions[i].Angr;
                            }
                        }
                        //判断虚触侍从对场攻的提升
                    }
                }

                // 计算己方英雄的攻击力
                if (this.ownHero.Ready)
                {
                    this.totalAngr += this.ownHero.Angr;
                }
            }
            return this.totalAngr;
        }

        /// <summary>
        /// 计算敌方所有可以攻击的角色（包括武器和随从）的总攻击力。
        /// 同时考虑敌方的军官风怒效果，并减去己方嘲讽随从的生命值。
        /// </summary>
        /// <returns>返回计算后的敌方总攻击力</returns>
        public int calEnemyTotalAngr()
        {
            if (this.enemyTotalAngr == -1)
            {
                this.enemyTotalAngr = this.enemyWeapon.Angr; // 从敌方武器开始计算攻击力
                for (int i = 0; i < this.enemyMinions.Count; i++)
                {
                    // 跳过无法攻击或被冻结的随从
                    if (this.enemyMinions[i].cantAttack || this.enemyMinions[i].frozen) continue;

                    // 增加当前随从的攻击力
                    this.enemyTotalAngr += this.enemyMinions[i].Angr;

                    // 检查是否有军官风怒效果
                    if (this.enemyMinions[i].windfury)
                    {
                        this.enemyTotalAngr += this.enemyMinions[i].Angr; // 如果满足风怒条件，额外计算一次攻击力
                    }
                    // if ((i > 0 && this.enemyMinions[i - 1].handcard.card.nameCN == CardDB.cardNameCN.战场军官 && !this.enemyMinions[i - 1].silenced) || (i < this.enemyMinions.Count - 1 && this.enemyMinions[i + 1].handcard.card.nameCN == CardDB.cardNameCN.战场军官 && !this.enemyMinions[i + 1].silenced))
                    // {
                    //     this.enemyTotalAngr += this.enemyMinions[i].Angr; // 如果满足风怒条件，额外计算一次攻击力
                    // }
                }

                // 减去己方嘲讽随从的生命值
                for (int i = 0; i < this.ownMinions.Count; i++)
                {
                    if (this.ownMinions[i].taunt)
                    {
                        this.enemyTotalAngr -= this.ownMinions[i].Hp;
                    }
                }

                // 确保最终的敌方总攻击力不为负数
                this.enemyTotalAngr = this.enemyTotalAngr < 0 ? 0 : this.enemyTotalAngr;
            }
            return this.enemyTotalAngr;
        }

        /// <summary>
        /// 根据指定的搜索模式和条件，从手牌中随机选择一个随从卡牌。
        /// </summary>
        /// <param name="cards">需要筛选的手牌列表</param>
        /// <param name="mode">搜索模式，如最低生命值、最高攻击力等</param>
        /// <param name="tag">要筛选的卡牌属性或类型（可选）</param>
        /// <param name="race">当筛选条件为种族时的具体种族，默认为无效种族（可选）</param>
        /// <returns>返回符合条件的手牌中的随从卡牌</returns>
        public Handmanager.Handcard searchRandomMinionInHand(List<Handmanager.Handcard> cards, searchmode mode, GAME_TAGs tag = GAME_TAGs.None, TAG_RACE race = TAG_RACE.INVALID)
        {
            Handmanager.Handcard ret = null;
            double value = 0;

            // 根据搜索模式设置初始值
            switch (mode)
            {
                case searchmode.searchLowestHP: value = 1000; break;
                case searchmode.searchHighestHP: value = -1; break;
                case searchmode.searchLowestAttack: value = 1000; break;
                case searchmode.searchHighestAttack: value = -1; break;
                case searchmode.searchHighAttackLowHP: value = -1; break;
                case searchmode.searchHighHPLowAttack: value = -1; break;
                case searchmode.searchLowestCost: value = 1000; break;
                case searchmode.searchHighesCost: value = -1; break;
            }

            // 筛选符合条件的卡牌
            getHandcardsByType(cards, tag, race);

            // 遍历筛选后的卡牌并根据搜索模式寻找最佳匹配
            foreach (Handmanager.Handcard hc in cards)
            {
                if (!hc.extraParam3) continue;
                hc.extraParam3 = false;

                switch (mode)
                {
                    case searchmode.searchLowestHP:
                        if ((hc.card.Health + hc.addHp) < value)
                        {
                            ret = hc;
                            value = (hc.card.Health + hc.addHp);
                        }
                        break;
                    case searchmode.searchHighestHP:
                        if ((hc.card.Health + hc.addHp) > value)
                        {
                            ret = hc;
                            value = (hc.card.Health + hc.addHp);
                        }
                        break;
                    case searchmode.searchLowestAttack:
                        if ((hc.card.Attack + hc.addattack) < value)
                        {
                            ret = hc;
                            value = (hc.card.Attack + hc.addattack);
                        }
                        break;
                    case searchmode.searchHighestAttack:
                        if ((hc.card.Attack + hc.addattack) > value)
                        {
                            ret = hc;
                            value = (hc.card.Attack + hc.addattack);
                        }
                        break;
                    case searchmode.searchHighAttackLowHP:
                        if ((hc.card.Attack + hc.addattack) / (hc.card.Health + hc.addHp) > value)
                        {
                            ret = hc;
                            value = (hc.card.Attack + hc.addattack) / (hc.card.Health + hc.addHp);
                        }
                        break;
                    case searchmode.searchHighHPLowAttack:
                        if ((hc.card.Health + hc.addHp) / (hc.card.Attack + hc.addattack) > value)
                        {
                            ret = hc;
                            value = (hc.card.Health + hc.addHp) / (hc.card.Attack + hc.addattack);
                        }
                        break;
                    case searchmode.searchLowestCost:
                        if (hc.manacost < value)
                        {
                            ret = hc;
                            value = hc.manacost;
                        }
                        break;
                    case searchmode.searchHighesCost:
                        if (hc.manacost > value)
                        {
                            ret = hc;
                            value = hc.manacost;
                        }
                        break;
                }
            }
            return ret;
        }

        /// <summary>
        /// 根据指定的搜索模式，从随从列表中随机选择一个符合条件的随从。
        /// </summary>
        /// <param name="minions">随从列表</param>
        /// <param name="mode">搜索模式，如最低生命值、最高攻击力等</param>
        /// <returns>返回符合条件的随从对象，如果列表为空则返回 null</returns>
        public Minion searchRandomMinion(List<Minion> minions, searchmode mode)
        {
            if (minions.Count == 0) return null;

            Minion ret = null; // 用于存储最终返回的随从
            double value;

            // 根据搜索模式初始化 value
            switch (mode)
            {
                case searchmode.searchLowestHP:
                case searchmode.searchLowestAttack:
                case searchmode.searchLowestCost:
                    value = 1000; // 初始化为较大值，用于寻找最小值
                    break;
                case searchmode.searchHighestHP:
                case searchmode.searchHighestAttack:
                case searchmode.searchHighesCost:
                case searchmode.searchHighAttackLowHP:
                case searchmode.searchHighHPLowAttack:
                    value = -1;  // 初始化为较小值，用于寻找最大值
                    break;
                default:
                    value = 0;  // 其他情况初始化为0（根据需要调整）
                    break;
            }

            // 遍历随从列表，根据不同的搜索模式更新目标随从
            foreach (Minion m in minions)
            {
                if (m.Hp <= 0) continue; // 忽略生命值小于等于0的随从

                switch (mode)
                {
                    case searchmode.searchLowestHP:
                        if (m.Hp < value) // 更新目标为生命值最低的随从
                        {
                            ret = m;
                            value = m.Hp;
                        }
                        break;
                    case searchmode.searchHighestHP:
                        if (m.Hp > value) // 更新目标为生命值最高的随从
                        {
                            ret = m;
                            value = m.Hp;
                        }
                        break;
                    case searchmode.searchLowestAttack:
                        if (m.Angr < value) // 更新目标为攻击力最低的随从
                        {
                            ret = m;
                            value = m.Angr;
                        }
                        break;
                    case searchmode.searchHighestAttack:
                        if (m.Angr > value) // 更新目标为攻击力最高的随从
                        {
                            ret = m;
                            value = m.Angr;
                        }
                        break;
                    case searchmode.searchHighAttackLowHP:
                        if ((double)m.Angr / m.Hp > value) // 更新目标为高攻低血比值最大的随从
                        {
                            ret = m;
                            value = (double)m.Angr / m.Hp;
                        }
                        break;
                    case searchmode.searchHighHPLowAttack:
                        if (m.Angr == 0) // 如果攻击力为0，直接选中这个随从
                        {
                            if (ret == null) ret = m;
                            continue;
                        }
                        if ((double)m.Hp / m.Angr > value) // 更新目标为高血低攻比值最大的随从
                        {
                            ret = m;
                            value = (double)m.Hp / m.Angr;
                        }
                        break;
                    case searchmode.searchLowestCost:
                        if (m.handcard.card.cost < value) // 更新目标为费用最低的随从
                        {
                            ret = m;
                            value = m.handcard.card.cost;
                        }
                        break;
                    case searchmode.searchHighesCost:
                        if (m.handcard.card.cost > value) // 更新目标为费用最高的随从
                        {
                            ret = m;
                            value = m.handcard.card.cost;
                        }
                        break;
                }
            }
            return ret; // 返回符合条件的随从
        }

        /// <summary>
        /// 在指定的随从列表中，根据最大生命值和搜索模式查找符合条件的随从。
        /// </summary>
        /// <param name="minions">随从列表</param>
        /// <param name="mode">搜索模式，如最高生命值、最低攻击力等</param>
        /// <param name="maxHP">随从的最大生命值限制</param>
        /// <returns>返回符合条件的随从对象，如果没有符合条件的随从则返回 null</returns>
        public Minion searchRandomMinionByMaxHP(List<Minion> minions, searchmode mode, int maxHP)
        {
            if (maxHP < 1 || minions.Count == 0) return null;

            Minion ret = null; // 用于存储最终返回的随从
            double value = 0;  // 用于存储当前比较值
            int retVal = 0;    // 用于存储次要比较值，如攻击力或生命值

            // 遍历随从列表，根据模式进行搜索
            foreach (Minion m in minions)
            {
                if (m.Hp > maxHP) continue; // 忽略生命值大于maxHP的随从

                switch (mode)
                {
                    case searchmode.searchHighestHP:
                        if (m.Hp > value)
                        {
                            ret = m;
                            value = m.Hp;
                            retVal = m.Angr;
                        }
                        else if (m.Hp == value && retVal < m.Angr)
                        {
                            ret = m;
                        }
                        break;

                    case searchmode.searchLowestAttack:
                        if (m.Angr < value)
                        {
                            ret = m;
                            value = m.Angr;
                            retVal = m.Hp;
                        }
                        else if (m.Angr == value && retVal < m.Hp)
                        {
                            ret = m;
                        }
                        break;

                    case searchmode.searchHighestAttack:
                        if (m.Angr > value)
                        {
                            ret = m;
                            value = m.Angr;
                            retVal = m.Hp;
                        }
                        else if (m.Angr == value && retVal < m.Hp)
                        {
                            ret = m;
                        }
                        break;

                    case searchmode.searchHighAttackLowHP:
                        if ((double)m.Angr / m.Hp > value)
                        {
                            ret = m;
                            value = (double)m.Angr / m.Hp;
                            retVal = m.Hp;
                        }
                        else if ((double)m.Angr / m.Hp == value && retVal < m.Hp)
                        {
                            ret = m;
                        }
                        break;

                    case searchmode.searchHighHPLowAttack:
                        if (m.Angr == 0)
                        {
                            if (ret == null) ret = m;
                            break;
                        }
                        if ((double)m.Hp / m.Angr > value)
                        {
                            ret = m;
                            value = (double)m.Hp / m.Angr;
                            retVal = m.Hp;
                        }
                        else if ((double)m.Angr / m.Hp == value && retVal < m.Hp)
                        {
                            ret = m;
                        }
                        break;

                    default: // searchHighestHP为默认情况
                        if (m.Hp > value)
                        {
                            ret = m;
                            value = m.Hp;
                            retVal = m.Angr;
                        }
                        else if (m.Hp == value && retVal < m.Angr)
                        {
                            ret = m;
                        }
                        break;
                }
            }

            // 如果找到的随从生命值小于等于0，则返回null
            return ret != null && ret.Hp > 0 ? ret : null;
        }

        /// <summary>
        /// 获取下一个玉莲帮魔像的卡牌，根据当前已召唤的玉莲帮魔像数量递增其攻击和生命值。
        /// </summary>
        /// <param name="own">布尔值，表示是否是自己的玉莲帮魔像</param>
        /// <returns>返回对应玉莲帮魔像的卡牌数据</returns>
        public CardDB.Card getNextJadeGolem(bool own)
        {
            int golemLevel = own ? ++anzOwnJadeGolem : ++anzEnemyJadeGolem;

            // 根据玉莲帮魔像等级返回相应的卡牌
            switch (golemLevel)
            {
                case 1: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t01);
                case 2: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t02);
                case 3: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t03);
                case 4: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t04);
                case 5: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t05);
                case 6: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t06);
                case 7: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t07);
                case 8: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t08);
                case 9: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t09);
                case 10: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t10);
                case 11: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t11);
                case 12: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t12);
                case 13: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t13);
                case 14: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t14);
                case 15: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t15);
                case 16: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t16);
                case 17: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t17);
                case 18: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t18);
                case 19: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t19);
                case 20: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t20);
                case 21: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t21);
                case 22: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t22);
                case 23: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t23);
                case 24: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t24);
                case 25: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t25);
                case 26: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t26);
                case 27: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t27);
                case 28: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t28);
                case 29: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t29);
                case 30: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t30);
                default: return CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_712_t30); // 如果超过30个，仍然返回最后一个等级的魔像
            }
        }

        /// <summary>
        /// 调试输出当前我方和敌方随从的状态信息，包括随从的名称、攻击力、当前生命值和最大生命值。
        /// </summary>
        public void debugMinions()
        {
            // 输出我方随从信息
            Helpfunctions.Instance.logg("我方随从################");
            foreach (Minion m in this.ownMinions)
            {
                // 打印随从的中文名称、攻击力、当前生命值和最大生命值
                Helpfunctions.Instance.logg(m.handcard.card.nameCN + " (" + m.Angr + "," + m.Hp + "/" + m.maxHp + ")");
            }

            // 输出敌方随从信息
            Helpfunctions.Instance.logg("敌方随从############");
            foreach (Minion m in this.enemyMinions)
            {
                // 打印随从的中文名称、攻击力、当前生命值和最大生命值
                Helpfunctions.Instance.logg(m.handcard.card.nameCN + " (" + m.Angr + "," + m.Hp + "/" + m.maxHp + ")");
            }
        }

        /// <summary>
        /// 打印当前场面上的状态信息
        /// </summary>
        public void printBoard()
        {
            Helpfunctions.Instance.logg("board/hash/turn: " + value + "  /  " + this.hashcode + "  /  " + this.turnCounter + " ++++++++++++++++++++++");
            Helpfunctions.Instance.logg("惩罚 " + this.evaluatePenality);
            Helpfunctions.Instance.logg("法力水晶 " + this.mana + "/" + this.ownMaxMana);
            Helpfunctions.Instance.logg("已使用手牌数: " + this.cardsPlayedThisTurn + " 剩余手牌: " + this.owncards.Count + " 敌方手牌: " + this.enemyAnzCards);

            Helpfunctions.Instance.logg("我方英雄: ");
            Helpfunctions.Instance.logg("血量: " + this.ownHero.Hp + " + " + this.ownHero.armor);
            Helpfunctions.Instance.logg("攻击力: " + this.ownHero.Angr);
            Helpfunctions.Instance.logg("武器: " + this.ownWeapon.Angr + " " + this.ownWeapon.Durability + " " + this.ownWeapon.card.nameCN.ToString() + " " + this.ownWeapon.card.cardIDenum + " " + (this.ownWeapon.poisonous ? "剧毒" : "无剧毒buff") + " " + (this.ownWeapon.lifesteal ? "吸血" : "无吸血buff"));
            Helpfunctions.Instance.logg("冻结状态: " + this.ownHero.frozen + " ");
            Helpfunctions.Instance.logg("敌方英雄血量: " + this.enemyHero.Hp + " + " + this.enemyHero.armor + ((this.enemyHero.immune) ? " immune" : ""));

            if (this.enemySecretCount >= 1) Helpfunctions.Instance.logg("enemySecrets: " + Probabilitymaker.Instance.getEnemySecretData(this.enemySecretList));
            foreach (Action a in this.playactions)
            {
                a.print();
            }
            Helpfunctions.Instance.logg("我方随从################");

            foreach (Minion m in this.ownMinions)
            {
                Helpfunctions.Instance.logg(m.handcard.card.nameCN.ToString() + "(" + m.Angr + "," + m.Hp + "/" + m.maxHp + ")" + m.zonepos + "号位 ID：" + m.entitiyID);
            }


            if (this.enemyMinions.Count > 0)
            {
                Helpfunctions.Instance.logg("敌方随从################");

                foreach (Minion m in this.enemyMinions)
                {
                    Helpfunctions.Instance.logg(m.handcard.card.nameCN.ToString() + "(" + m.Angr + "," + m.Hp + "/" + m.maxHp + ")" + m.zonepos + "号位 ID：" + m.entitiyID);
                }
            }

            if (this.diedMinions.Count > 0)
            {
                Helpfunctions.Instance.logg("死亡随从############");
                foreach (GraveYardItem m in this.diedMinions)
                {
                    Helpfunctions.Instance.logg("拥有者, entity, cardid: " + m.own + ", " + m.entityId + ", " + m.cardid);
                }
            }

            Helpfunctions.Instance.logg("我方手牌: ");
            foreach (Handmanager.Handcard hc in this.owncards)
            {
                Helpfunctions.Instance.logg("pos " + hc.position + " " + hc.card.nameCN.ToString() + "(费用：" + hc.manacost + "；" + hc.addattack + hc.card.Attack + "/" + +hc.addHp + hc.card.Health + ") elemPoweredUp" + hc.poweredUp + " " + hc.card.cardIDenum);
            }
            Helpfunctions.Instance.logg("+++++++ printBoard end +++++++++");

            Helpfunctions.Instance.logg("");
        }

        /// <summary>
        /// 打印当前场面上的状态信息
        /// </summary>
        /// <returns></returns>
        public string printBoardString()
        {
            string retval = "Turn : board\t" + this.turnCounter + ":" + ((this.value < -2000000) ? "." : this.value.ToString());
            retval += "\r\n" + "pIdHistory\t";
            foreach (int pId in this.pIdHistory) retval += pId + " ";
            retval += "\r\n" + ("pen\t" + this.evaluatePenality);
            retval += "\r\n" + ("mana\t" + this.mana + "/" + this.ownMaxMana);
            retval += "\r\n" + ("cardsplayed : handsize : enemyhand\t" + this.cardsPlayedThisTurn + ":" + this.owncards.Count + ":" + this.enemyAnzCards);
            retval += "\r\n" + ("Hp : armor : Atk ownhero\t" + this.ownHero.Hp + ":" + this.ownHero.armor + ":" + this.ownHero.Angr + ((this.ownHero.immune) ? ":immune" : ""));
            retval += "\r\n" + ("Atk : Dur : Name : IDe : poison ownWeapon\t" + this.ownWeapon.Angr + " " + this.ownWeapon.Durability + " " + this.ownWeapon.name + " " + this.ownWeapon.card.cardIDenum + " " + (this.ownWeapon.poisonous ? 1 : 0) + " " + (this.ownWeapon.lifesteal ? 1 : 0));
            retval += "\r\n" + ("ownHero.frozen\t" + this.ownHero.frozen);
            retval += "\r\n" + ("Hp : armor enemyhero\t" + this.enemyHero.Hp + ":" + this.enemyHero.armor + ((this.enemyHero.immune) ? ":immune" : ""));
            retval += "\r\n" + ("Atk : Dur : Name : IDe : poison enemyWeapon\t" + this.enemyWeapon.Angr + " " + this.enemyWeapon.Durability + " " + this.enemyWeapon.name + " " + this.enemyWeapon.card.cardIDenum + " " + (this.enemyWeapon.poisonous ? 1 : 0) + " " + (this.enemyWeapon.lifesteal ? 1 : 0));
            retval += "\r\n" + ("carddraw own:enemy\t" + this.owncarddraw + ":" + this.enemycarddraw);

            if (this.enemySecretCount > 0) retval += "\r\n" + ("enemySecrets\t" + Probabilitymaker.Instance.getEnemySecretData(this.enemySecretList));
            if (this.ownSecretsIDList.Count > 0)
            {
                retval += "\r\n" + ("ownSecrets\t");
                foreach (CardDB.cardIDEnum s in this.ownSecretsIDList)
                {
                    retval += " " + CardDB.Instance.getCardDataFromID(s).nameEN;
                }
            }

            for (int i = 0; i < this.playactions.Count; i++) retval += "\r\n" + i + " action\t" + this.playactions[i].printString();
            retval += "\r\n" + ("OWN MINIONS################\t" + this.ownMinions.Count);

            for (int i = 0; i < this.ownMinions.Count; i++)
            {
                Minion m = this.ownMinions[i];
                retval += "\r\n" + (i + 1) + " OWN MINION\t" + m.zonepos + " " + m.entitiyID + ":" + m.name + " " + m.Angr + " " + m.Hp;
            }

            if (this.enemyMinions.Count > 0)
            {
                retval += "\r\n" + ("ENEMY MINIONS############\t" + this.enemyMinions.Count);
                for (int i = 0; i < this.enemyMinions.Count; i++)
                {
                    Minion m = this.enemyMinions[i];
                    retval += "\r\n" + (i + 1) + " ENEMY MINION\t" + m.zonepos + " " + m.entitiyID + ":" + m.name + " " + m.Angr + " " + m.Hp;
                }
            }

            if (this.diedMinions.Count > 0)
            {
                retval += "\r\n" + ("DIED MINIONS############\t");
                for (int i = 0; i < this.diedMinions.Count; i++)
                {
                    GraveYardItem m = this.diedMinions[i];
                    retval += "\r\n" + i + (" own : entity : cardid\t" + (m.own ? "own" : "en") + " " + m.entityId + " " + m.cardid);
                }
            }

            retval += "\r\nOwn Handcards\t\r\n";
            for (int i = 0; i < this.owncards.Count; i++)
            {
                Handmanager.Handcard hc = this.owncards[i];
                retval += "\r\n" + (i + 1) + " CARD\t" + (hc.position + " " + hc.entity + ":" + hc.card.nameEN + " " + hc.manacost + " " + hc.card.cardIDenum + " " + hc.addattack + " " + hc.addHp + " " + hc.poweredUp + "\r\n");
            }
            retval += ("Enemy Handcards count\t" + this.enemyAnzCards + "\r\n");

            return retval;
        }

        /// <summary>
        /// 打印当前场面上的状态信息
        /// </summary>
        public void printBoardDebug()
        {
            Helpfunctions.Instance.logg("hero " + this.ownHero.Hp + " " + this.ownHero.armor + " " + this.ownHero.entitiyID);
            Helpfunctions.Instance.logg("ehero " + this.enemyHero.Hp + " " + this.enemyHero.armor + " " + this.enemyHero.entitiyID);
            foreach (Minion m in ownMinions)
            {
                Helpfunctions.Instance.logg(m.name + " " + m.entitiyID);
            }
            Helpfunctions.Instance.logg("-");
            foreach (Minion m in enemyMinions)
            {
                Helpfunctions.Instance.logg(m.name + " " + m.entitiyID);
            }
            Helpfunctions.Instance.logg("-");
            foreach (Handmanager.Handcard hc in this.owncards)
            {
                Helpfunctions.Instance.logg(hc.position + " " + hc.card.nameEN + " " + hc.entity);
            }
        }

        /// <summary>
        /// 获取下一个动作
        /// </summary>
        /// <returns>返回下一个动作，如果没有动作则返回 null</returns>
        public Action getNextAction()
        {
            // 返回第一个动作或 null
            return this.playactions.Count > 0 ? this.playactions[0] : null;
        }

        /// <summary>
        /// 检查当前回合的牌组中是否存在指定种族的随从卡片
        /// </summary>
        /// <param name="race">要检查的种族</param>
        /// <returns>返回找到的卡片 ID，如果没有找到则返回 None</returns>
        public CardDB.cardIDEnum CheckTurnDeckExists(TAG_RACE race)
        {
            foreach (var kvp in this.prozis.turnDeck)
            {
                // 获取卡片 ID 和卡片数据
                var deckCardId = kvp.Key;
                var deckCard = CardDB.Instance.getCardDataFromID(deckCardId);

                // 检查卡片是否属于指定种族
                if (deckCard.race == (CardDB.Race)race)
                {
                    return deckCardId;
                }
            }

            // 没有找到符合条件的卡片
            return CardDB.cardIDEnum.None;
        }

        /// <summary>
        /// 检查当前回合的牌组中是否存在指定类型的卡片，并返回符合条件的卡片 ID 列表
        /// </summary>
        /// <param name="type">要检查的卡片类型</param>
        /// <param name="num">需要的卡片数量</param>
        /// <returns>返回符合条件的卡片 ID 列表</returns>
        public List<CardDB.cardIDEnum> CheckTurnDeckForType(CardDB.cardtype type, int num)
        {
            var matchingCards = new List<CardDB.cardIDEnum>();
            int totalCount = 0;

            foreach (var kvp in this.prozis.turnDeck)
            {
                var cardId = kvp.Key;
                var card = CardDB.Instance.getCardDataFromID(cardId);

                if (card.type == type)
                {
                    int quantity = kvp.Value;
                    totalCount += quantity;

                    // Add the card ID to the list as many times as its quantity
                    matchingCards.AddRange(Enumerable.Repeat(cardId, quantity));
                }

                if (totalCount >= num)
                {
                    return matchingCards;
                }
            }

            return matchingCards;
        }

        /// <summary>
        /// 打印当前的动作列表
        /// </summary>
        /// <param name="toBuffer">是否将信息输出到缓冲区（当前实现未使用此参数）</param>
        public void printActions(bool toBuffer = false)
        {
            int index = 0;
            foreach (Action a in this.playactions)
            {
                index++;
                string tmp = index + ":  ";
                tmp += a.printString();
                Helpfunctions.Instance.logg(tmp);
            }
        }

        /// <summary>
        /// 打印行动信息，适用于调试或记录
        /// </summary>
        /// <param name="action">要打印的行动对象</param>
        public void printActionforDummies(Action a)
        {
            if (a.actionType == actionEnum.playcard)
            {
                Helpfunctions.Instance.ErrorLog("printActionforDummies - play " + a.card.card.nameEN);
                if (a.druidchoice >= 1)
                {
                    string choose = (a.druidchoice == 1) ? "left card" : "right card";
                    Helpfunctions.Instance.ErrorLog("choose the " + choose);
                }
                if (a.place >= 1)
                {
                    Helpfunctions.Instance.ErrorLog("on position " + a.place);
                }
                if (a.target != null)
                {
                    if (!a.target.own && !a.target.isHero)
                    {
                        string ename = "" + a.target.name;
                        Helpfunctions.Instance.ErrorLog("and target to the enemy " + ename);
                    }

                    if (a.target.own && !a.target.isHero)
                    {
                        string ename = "" + a.target.name;
                        Helpfunctions.Instance.ErrorLog("and target to your own" + ename);
                    }

                    if (a.target.own && a.target.isHero)
                    {
                        Helpfunctions.Instance.ErrorLog("and target your own hero");
                    }

                    if (!a.target.own && a.target.isHero)
                    {
                        Helpfunctions.Instance.ErrorLog("and target to the enemy hero");
                    }
                }

            }
            if (a.actionType == actionEnum.attackWithMinion)
            {
                string name = "" + a.own.name;
                if (a.target.isHero)
                {
                    Helpfunctions.Instance.ErrorLog("printActionforDummies - attack with: " + name + " the enemy hero");
                }
                else
                {
                    string ename = "" + a.target.name;
                    Helpfunctions.Instance.ErrorLog("printActionforDummies - attack with: " + name + " the enemy: " + ename);
                }

            }

            if (a.actionType == actionEnum.attackWithHero)
            {
                if (a.target.isHero)
                {
                    Helpfunctions.Instance.ErrorLog("printActionforDummies - attack with your hero the enemy hero!");
                }
                else
                {
                    string ename = "" + a.target.name;
                    Helpfunctions.Instance.ErrorLog("printActionforDummies - attack with the hero, and choose the enemy: " + ename);
                }
            }
            if (a.actionType == actionEnum.useHeroPower)
            {
                Helpfunctions.Instance.ErrorLog("printActionforDummies - use your Heropower ");
                if (a.target != null)
                {
                    if (!a.target.own && !a.target.isHero)
                    {
                        string ename = "" + a.target.name;
                        Helpfunctions.Instance.ErrorLog("on enemy: " + ename);
                    }

                    if (a.target.own && !a.target.isHero)
                    {
                        string ename = "" + a.target.name;
                        Helpfunctions.Instance.ErrorLog("on your own: " + ename);
                    }

                    if (a.target.own && a.target.isHero)
                    {
                        Helpfunctions.Instance.ErrorLog("on your own hero");
                    }

                    if (!a.target.own && a.target.isHero)
                    {
                        Helpfunctions.Instance.ErrorLog("on your the enemy hero");
                    }

                }
            }
            if (a.actionType == actionEnum.useLocation)
            {
                Helpfunctions.Instance.ErrorLog("printActionforDummies - use your Location ");
                if (a.target != null)
                {
                    if (!a.target.own && !a.target.isHero)
                    {
                        string ename = "" + a.target.name;
                        Helpfunctions.Instance.ErrorLog("on enemy: " + ename);
                    }

                    if (a.target.own && !a.target.isHero)
                    {
                        string ename = "" + a.target.name;
                        Helpfunctions.Instance.ErrorLog("on your own: " + ename);
                    }

                    if (a.target.own && a.target.isHero)
                    {
                        Helpfunctions.Instance.ErrorLog("on your own hero");
                    }

                    if (!a.target.own && a.target.isHero)
                    {
                        Helpfunctions.Instance.ErrorLog("on your the enemy hero");
                    }
                }
            }
            if (a.actionType == actionEnum.useTitanAbility)
            {
                StringBuilder retval = new StringBuilder();
                retval.Append("使用泰坦技能 ");
                string suffix = "";
                switch (a.own.handcard.card.cardIDenum.ToString())
                {
                    case "TTN_092":
                        if (a.titanAbilityNO == 1) suffix = "t1";
                        else if (a.titanAbilityNO == 2) suffix = "t2";
                        else if (a.titanAbilityNO == 3) suffix = "t3";
                        break;
                    case "TTN_858":
                        if (a.titanAbilityNO == 1) suffix = "t1";
                        else if (a.titanAbilityNO == 2) suffix = "t2";
                        else if (a.titanAbilityNO == 3) suffix = "t3";
                        break;
                    case "TTN_862":
                        if (a.titanAbilityNO == 1) suffix = "t1";
                        else if (a.titanAbilityNO == 2) suffix = "t2";
                        else if (a.titanAbilityNO == 3) suffix = "t3";
                        break;

                    case "TTN_075":
                        if (a.titanAbilityNO == 1) suffix = "t";
                        else if (a.titanAbilityNO == 2) suffix = "t2";
                        else if (a.titanAbilityNO == 3) suffix = "t3";
                        break;
                    case "TTN_800":
                        if (a.titanAbilityNO == 1) suffix = "t2";
                        else if (a.titanAbilityNO == 2) suffix = "t3";
                        else if (a.titanAbilityNO == 3) suffix = "t";
                        break;
                    case "TTN_415":
                        if (a.titanAbilityNO == 1) suffix = "t";
                        else if (a.titanAbilityNO == 2) suffix = "t2";
                        else if (a.titanAbilityNO == 3) suffix = "t3";
                        break;
                    case "TTN_429":
                        if (a.titanAbilityNO == 1) suffix = "t";
                        else if (a.titanAbilityNO == 2) suffix = "t2";
                        else if (a.titanAbilityNO == 3) suffix = "t3";
                        break;
                    case "YOG_516":
                        if (a.titanAbilityNO == 1) suffix = "t";
                        else if (a.titanAbilityNO == 2) suffix = "t2";
                        else if (a.titanAbilityNO == 3) suffix = "t3";
                        break;
                    case "TTN_903":
                        if (a.titanAbilityNO == 1) suffix = "t";
                        else if (a.titanAbilityNO == 2) suffix = "t2";
                        else if (a.titanAbilityNO == 3) suffix = "t3";
                        break;
                    case "TTN_721":
                        if (a.titanAbilityNO == 1) suffix = "t";
                        else if (a.titanAbilityNO == 2) suffix = "t1";
                        else if (a.titanAbilityNO == 3) suffix = "t2";
                        break;

                    case "TTN_737":
                        if (a.titanAbilityNO == 1) suffix = "t";
                        else if (a.titanAbilityNO == 2) suffix = "t3";
                        else if (a.titanAbilityNO == 3) suffix = "t1";
                        break;

                    case "TTN_960":
                        if (a.titanAbilityNO == 1) suffix = "t2";
                        else if (a.titanAbilityNO == 2) suffix = "t3";
                        else if (a.titanAbilityNO == 3) suffix = "t4";
                        break;

                    default:
                        if (a.titanAbilityNO == 1) suffix = "t";
                        else if (a.titanAbilityNO == 2) suffix = "t2";
                        else if (a.titanAbilityNO == 3) suffix = "t3";
                        break;
                }
                CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.Instance.cardIdstringToEnum(a.own.handcard.card.cardIDenum.ToString() + suffix));
                retval.Append(" 目标 " + (a.target != null && a.target.handcard != null ? a.target.handcard.card.nameCN.ToString() : "无"));
                Helpfunctions.Instance.ErrorLog("printActionforDummies - " + retval.ToString());
            }
            Helpfunctions.Instance.ErrorLog("");
        }

        private Random rng = new Random(); // 定义一个随机数生成器实例
        /// <summary>
        /// 生成指定范围内的随机数
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public int getRandomNumber(int minValue, int maxValue)
        {
            return rng.Next(minValue, maxValue + 1);
        }

        /// <summary>
        /// 用于处理发掘进度并返回对应品质的随机卡牌
        /// </summary>
        /// <returns></returns>
        public CardDB.Card handleExcavation()
        {
            this.excavationCount++;
            this.allExcavationCount++;

            CardDB.Card resultCard = null;

            if (this.excavationCount == 1)
            {
                // 普通宝藏池
                resultCard = getRandomCardFromPool("common");
            }
            else if (this.excavationCount == 2)
            {
                // 稀有宝藏池
                resultCard = getRandomCardFromPool("rare");
            }
            else if (this.excavationCount == 3)
            {
                // 史诗宝藏池
                resultCard = getRandomCardFromPool("epic");

                // 如果当前英雄没有专属传说级宝藏，则重置发掘进度
                if (!hasLegendaryTreasure())
                {
                    this.excavationCount = 0;
                }
            }
            else if (this.excavationCount == 4)
            {
                // 处理传说级宝藏
                resultCard = getLegendaryTreasure();

                // 重置发掘进度
                this.excavationCount = 0;
            }
            return resultCard;
        }

        /// <summary>
        /// 获取指定品质的宝藏池卡牌列表
        /// </summary>
        /// <param name="quality"></param>
        /// <returns></returns>
        public List<CardDB.cardIDEnum> getTreasurePool(string quality)
        {
            if (CardDB.Instance.treasurePools.ContainsKey(quality))
            {
                return CardDB.Instance.treasurePools[quality];
            }
            return new List<CardDB.cardIDEnum>();
        }

        /// <summary>
        /// 根据英雄类型返回特定的传说级宝藏卡牌
        /// </summary>
        /// <returns></returns>
        private CardDB.Card getLegendaryTreasure()
        {
            // 获取当前英雄的类型
            TAG_CLASS heroClass = this.ownHero.cardClass;

            // 根据英雄职业返回对应的传说级宝藏卡牌
            CardDB.cardIDEnum legendaryTreasureId = CardDB.cardIDEnum.None;

            switch (heroClass)
            {
                case TAG_CLASS.DEATHKNIGHT:
                    legendaryTreasureId = CardDB.cardIDEnum.WW_001t26; // 艾泽里特鼠
                    break;
                case TAG_CLASS.MAGE:
                    legendaryTreasureId = CardDB.cardIDEnum.WW_001t24; // 艾泽里特鹰
                    break;
                case TAG_CLASS.PALADIN:
                    legendaryTreasureId = CardDB.cardIDEnum.DEEP_999t4; // 艾泽里特龙
                    break;
                case TAG_CLASS.ROGUE:
                    legendaryTreasureId = CardDB.cardIDEnum.WW_001t23; // 艾泽里特蝎
                    break;
                case TAG_CLASS.SHAMAN:
                    legendaryTreasureId = CardDB.cardIDEnum.DEEP_999t5; // 艾泽里特鱼人
                    break;
                case TAG_CLASS.WARLOCK:
                    legendaryTreasureId = CardDB.cardIDEnum.WW_001t25; // 艾泽里特蛇
                    break;
                case TAG_CLASS.WARRIOR:
                    legendaryTreasureId = CardDB.cardIDEnum.WW_001t27; // 艾泽里特牛
                    break;
                default:
                    // 如果没有对应的职业宝藏卡牌，则保持为空（或根据需求处理）
                    break;
            }

            // 返回对应的卡牌对象
            return CardDB.Instance.getCardDataFromID(legendaryTreasureId);
        }

        /// <summary>
        /// 从指定品质的宝藏池中随机获取一张卡牌
        /// </summary>
        /// <param name="quality"></param>
        /// <returns></returns>
        private CardDB.Card getRandomCardFromPool(string quality)
        {
            // 假设有一个方法可以根据宝藏池的品质获取相应的卡牌池
            List<CardDB.cardIDEnum> pool = getTreasurePool(quality);
            if (pool.Count == 0) return null;

            int randomIndex = getRandomNumber(0, pool.Count - 1);
            return CardDB.Instance.getCardDataFromID(pool[randomIndex]);
        }

        /// <summary>
        /// 基于当前英雄的类型判断是否有专属传说级宝藏
        /// </summary>
        /// <returns></returns>
        private bool hasLegendaryTreasure()
        {
            // 获取当前英雄的类型
            TAG_CLASS heroClass = this.ownHero.cardClass;

            // 判断是否有专属的传说级宝藏
            switch (heroClass)
            {
                case TAG_CLASS.DEATHKNIGHT: // 艾泽里特鼠
                case TAG_CLASS.MAGE:        // 艾泽里特鹰
                case TAG_CLASS.PALADIN:     // 艾泽里特龙
                case TAG_CLASS.ROGUE:       // 艾泽里特蝎
                case TAG_CLASS.SHAMAN:      // 艾泽里特鱼人
                case TAG_CLASS.WARLOCK:     // 艾泽里特蛇
                case TAG_CLASS.WARRIOR:     // 艾泽里特牛
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// 移除手牌中所有快枪状态
        /// </summary>
        /// <param name="handcards"></param>
        private void RemoveQuickDrawStatus(List<Handmanager.Handcard> handcards)
        {
            foreach (var card in handcards)
            {
                card.card.Quickdraw = false; // 假设 quickDraw 是一个标志，用于表示快枪状态
            }
        }

        /// <summary>
        /// 使用地标卡牌
        /// </summary>
        /// <param name="own">地标卡牌所属的随从对象</param>
        /// <param name="target">目标随从或英雄</param>
        public void useLocation(Minion own, Minion target)
        {
            // 获取当前要使用的地标卡牌
            CardDB.Card locationCard = own.handcard.card;

            if (locationCard.CooldownTurn > 0) return;

            // 触发地标的使用效果
            locationCard.sim_card.useLocation(this, own, target);



            // 如果地标能冻结目标，进行冻结操作
            // if (target != null && locationCard.cardIDenum == CardDB.cardIDEnum.REV_602)
            // {
            //     minionGetFrozen(target);
            // }

            // 特殊处理对于 VAC_334 的逻辑
            if (own.handcard.card.cardIDenum == CardDB.cardIDEnum.VAC_334) // 检查是否为“小玩物小屋”卡牌
            {
                if (this.owncards.Count > 0)
                {
                    // 记录手牌中的最后一张牌的实体ID
                    int lastCardEntityID = this.owncards[this.owncards.Count - 1].entity;

                    // 假设你要记录这个实体ID，可以保存到一个新的属性
                    this.lastDrawnCardEntityID = lastCardEntityID; // 需要在类中定义 lastDrawnCardEntityID 变量
                }
            }

            if (own.Hp <= 0)
            {
                own.handcard.card.sim_card.onDeathrattle(this, own);
            }
        }

        /// <summary>
        /// 使用泰坦技能
        /// </summary>
        /// <param name="own">泰坦所属的随从对象</param>
        /// <param name="titanAbilityNO">泰坦的技能编号，1、2、3</param>
        /// <param name="target">目标随从</param>
        /// 
        public void useTitanAbility(Minion own, int titanAbilityNO, Minion target)
        {

            // 获取当前要使用技能的泰坦卡牌
            CardDB.Card useAbilityTitan = own.handcard.card;
            //是否继续执行
            bool flag = true;
            switch (titanAbilityNO)
            {
                case 1:
                    if (useAbilityTitan.TitanAbilityUsed1) flag = false;
                    break;
                case 2:
                    if (useAbilityTitan.TitanAbilityUsed2) flag = false;
                    break;
                case 3:
                    if (useAbilityTitan.TitanAbilityUsed3) flag = false;
                    break;
            }
            if (flag)
            {
                // 触发技能的使用效果
                useAbilityTitan.sim_card.useTitanAbility(this, own, titanAbilityNO, target);
            }
        }

        /// <summary>
        /// 抽一张临时卡牌
        /// </summary>
        /// <param name="ss">卡牌IdEnum</param>
        /// <param name="own">是否为我方抽牌</param>
        public void drawTemporaryCard(CardDB.cardIDEnum ss, bool own)
        {
            CardDB.cardIDEnum s = ss;

            // cant hold more than 10 cards
            if (own)
            {
                if (s == CardDB.cardIDEnum.None)
                {
                    if (ownDeckSize == 0)
                    {
                        this.ownHeroFatigue++;
                        this.ownHero.getDamageOrHeal(this.ownHeroFatigue, this, false, true);
                        return;
                    }
                    else
                    {
                        this.ownDeckSize--;
                        if (this.owncards.Count >= 10)
                        {
                            return;
                        }
                        this.owncarddraw++;
                    }

                    // 符文秘银杖
                    if (this.ownWeapon != null && this.ownWeapon.card.nameCN == CardDB.cardNameCN.符文秘银杖)
                    {
                        this.ownWeapon.scriptNum1++;
                    }
                }
                else
                {
                    if (this.owncards.Count >= 10)
                    {
                        return;
                    }
                    this.owncarddraw++;
                }
            }
            else
            {
                if (s == CardDB.cardIDEnum.None)
                {
                    if (enemyDeckSize == 0)
                    {
                        this.enemyHeroFatigue++;
                        this.enemyHero.getDamageOrHeal(this.enemyHeroFatigue, this, false, true);
                        return;
                    }
                    else
                    {
                        this.enemyDeckSize--;
                        if (this.enemyAnzCards >= 10)
                        {
                            return;
                        }
                        this.enemycarddraw++;
                        this.enemyAnzCards++;
                    }
                }
                else
                {
                    if (this.enemyAnzCards >= 10)
                    {
                        return;
                    }
                    this.enemycarddraw++;
                    this.enemyAnzCards++;
                }
                this.triggerCardsChanged(false);

                if (anzEnemyChromaggus > 0 && s == CardDB.cardIDEnum.None)
                {
                    for (int i = 1; i <= anzEnemyChromaggus; i++)
                    {
                        if (this.enemyAnzCards >= 10)
                        {
                            return;
                        }
                        this.enemycarddraw++;
                        this.enemyAnzCards++;
                        this.triggerCardsChanged(false);
                    }
                }
                return;
            }

            CardDB.Card c = CardDB.Instance.getCardDataFromID(s);
            Handmanager.Handcard hc = new Handmanager.Handcard
            {
                card = c,
                position = this.owncards.Count + 1,
                manacost = 0, // 临时卡牌的费用通常为0或特殊处理
                entity = this.getNextEntity(),
                temporary = true // 设置临时标志
            };
            this.owncards.Add(hc);
            this.triggerCardsChanged(true);

            if (anzOwnChromaggus > 0 && s == CardDB.cardIDEnum.None)
            {
                for (int i = 1; i <= anzOwnChromaggus; i++)
                {
                    if (this.owncards.Count >= 10)
                    {
                        return;
                    }
                    this.owncarddraw++;
                    hc = new Handmanager.Handcard
                    {
                        card = c,
                        position = this.owncards.Count + 1,
                        manacost = 0,
                        entity = this.getNextEntity(),
                        temporary = true // 设置临时标志
                    };
                    this.owncards.Add(hc);
                    this.triggerCardsChanged(true);
                }
            }
        }

        /// <summary>
        /// 移除临时卡牌
        /// </summary>
        /// <param name="own"></param>
        public void removeTemporaryCards(bool own)
        {
            if (own)
            {
                this.owncards = owncards.Where(hc => !hc.temporary).ToList();
            }
            this.triggerCardsChanged(own);
        }

        /// <summary>
        /// 计算并返回释放了几个派系的法术
        /// </summary>
        /// <returns></returns>
        public int CountSpellSchoolsPlayed()
        {
            int count = 0;

            foreach (int value in this.ownSpellSchoolCounts.Values)
            {
                if (value > 0)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// 所有随从受到随机伤害
        /// </summary>
        /// <param name="totalDamage"></param>
        public void allMinionsGetRandomDamage(int totalDamage)
        {
            Random rnd = new Random();  // 创建一个随机数生成器
            List<Minion> allMinions = new List<Minion>(this.ownMinions);
            allMinions.AddRange(this.enemyMinions);

            // 随机分配总伤害到所有随从身上
            while (totalDamage > 0 && allMinions.Count > 0)
            {
                // 随机选择一个随从
                Minion m = allMinions[rnd.Next(0, allMinions.Count)];

                // 计算本次伤害
                int dmg = rnd.Next(1, Math.Min(totalDamage, m.Hp) + 1);

                // 造成伤害
                this.minionGetDamageOrHeal(m, dmg);
                totalDamage -= dmg;

                // 如果随从死亡，从列表中移除
                if (m.Hp <= 0)
                {
                    allMinions.Remove(m);
                }
            }
        }

        /// <summary>
        /// 检查牌库中是否有随从牌
        /// </summary>
        /// <returns></returns>
        public bool hasMinionsInDeck()
        {
            foreach (var cardEntry in prozis.turnDeck)
            {
                CardDB.Card card = CardDB.Instance.getCardDataFromID(cardEntry.Key);
                if (card.type == CardDB.cardtype.MOB)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 让每个敌方随从随机攻击一个敌方随从
        /// </summary>
        public void RandomEnemyMinionsAttackEachOther()
        {
            // 获取敌方随从列表的副本，避免在遍历时修改原始列表
            List<Minion> enemyMinions = new List<Minion>(this.enemyMinions);

            // 遍历每个敌方随从
            foreach (Minion attacker in enemyMinions)
            {
                // 检查当前随从是否还能攻击
                if (attacker.Ready && !attacker.frozen)
                {
                    // 从敌方随从列表中移除当前随从以避免其攻击自己
                    List<Minion> possibleTargets = new List<Minion>(enemyMinions);
                    possibleTargets.Remove(attacker);

                    // 如果没有其他可攻击的目标，跳过此随从
                    if (possibleTargets.Count == 0) continue;

                    // 随机选择一个敌方随从作为目标
                    Minion target = possibleTargets[this.getRandomNumber(0, possibleTargets.Count - 1)];

                    // 检查目标随从是否仍然存在
                    if (this.enemyMinions.Contains(target))
                    {
                        // 执行攻击
                        this.minionAttacksMinion(attacker, target);
                    }
                }
            }
        }
    }

    /// <summary>
    /// 扳机触发计数器
    /// </summary>
    public struct triggerCounter
    {
        /// <summary>
        /// 随从受到治疗扳机
        /// </summary>
        public int minionsGotHealed;
        /// <summary>
        /// 角色受到治疗扳机
        /// </summary>
        public int charsGotHealed;
        /// <summary>
        /// 随从受到伤害扳机
        /// </summary>
        public int ownMinionsGotDmg;
        /// <summary>
        /// 敌方随从受到伤害扳机
        /// </summary>
        public int enemyMinionsGotDmg;
        /// <summary>
        /// 我方英雄受到伤害扳机
        /// </summary>
        public int ownHeroGotDmg;
        /// <summary>
        /// 敌方英雄受到伤害扳机
        /// </summary>
        public int enemyHeroGotDmg;
        /// <summary>
        /// 我方随从死亡扳机
        /// </summary>
        public int ownMinionsDied;
        /// <summary>
        /// 敌方随从死亡扳机
        /// </summary>
        public int enemyMinionsDied;
        /// <summary>
        /// 我方野兽随从召唤扳机
        /// </summary>
        public int ownBeastSummoned;
        /// <summary>
        /// 我方龙随从召唤扳机
        /// </summary>
        public int ownDragonSummoned;
        /// <summary>
        /// 我方野兽随从死亡扳机
        /// </summary>
        public int ownBeastDied;
        /// <summary>
        /// 敌方野兽随从死亡扳机
        /// </summary>
        public int enemyBeastDied;
        /// <summary>
        /// 我方机械随从死亡扳机
        /// </summary>
        public int ownMechanicDied;
        /// <summary>
        /// 敌方机械随从死亡扳机
        /// </summary>
        public int enemyMechanicDied;
        /// <summary>
        /// 我方鱼人随从死亡扳机
        /// </summary>
        public int ownMurlocDied;
        /// <summary>
        /// 敌方鱼人随从死亡扳机
        /// </summary>
        public int enemyMurlocDied;
        /// <summary>
        /// 我方随从失去圣盾扳机
        /// </summary>
        public int ownMinionLosesDivineShield;
        /// <summary>
        /// 敌方随从失去圣盾扳机
        /// </summary>
        public int enemyMinionLosesDivineShield;
        /// <summary>
        /// 我方随从变化扳机
        /// </summary>
        public bool ownMinionsChanged;
        /// <summary>
        /// 敌方随从变化扳机
        /// </summary>
        public bool enemyMininsChanged;
        /// <summary>
        /// 德莱尼扳机提示
        /// </summary>
        public bool draeneiTriggerHint;
        /// <summary>
        /// 星舰发射时扳机
        /// </summary>
        public bool starshipLaunchTrigger;
        /// <summary>
        /// 我方亡灵随从死亡扳机
        /// </summary>
        public int ownUndeadDied;
        /// <summary>
        /// 敌方亡灵随从死亡扳机
        /// </summary>
        public int enemyUndeadDied;
        /// <summary>
        /// 我方树人随从召唤扳机
        /// </summary>
        public int ownTreantSummoned;
        /// <summary>
        /// 我方树人随从死亡扳机
        /// </summary>
        public int ownTreantDied;
    }

    public struct IDEnumOwner
    {
        public CardDB.cardIDEnum IDEnum;
        public bool own;
    }

    public static class RaceUtils
    {
        /// <summary>
        /// 辅助方法，用于检查随从是否为指定的种族或融合怪
        /// </summary>
        /// <param name="race"></param>
        /// <param name="targetRace"></param>
        /// <returns></returns>
        public static bool IsRaceOrAll(CardDB.Race race, CardDB.Race targetRace)
        {
            return race == targetRace || race == CardDB.Race.ALL;
        }

        public static bool MinionBelongsToRace(List<CardDB.Race> races, CardDB.Race targetRace)
        {
            if (races.Count == 0) return false;

            if (targetRace == CardDB.Race.ALL)
            {
                return races.Count > 1;
            }

            foreach (CardDB.Race race in races)
            {
                if (race == targetRace || race == CardDB.Race.ALL)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
