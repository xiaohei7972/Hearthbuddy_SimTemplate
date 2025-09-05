namespace HREngine.Bots
{
    using System;
    using System.Collections.Generic;

    public enum HeroEnum
    {
        None,
        weizbang,//威兹班
        druid,		//德鲁伊
        hunter,		//猎人
        priest,		//牧师
        warlock,	//术士
        thief,		//贼
        pala,
        warrior,	//战士
        shaman,		//萨满
        mage,		//法师
        lordjaraxxus,//大王
        ragnarosthefirelord,//炎魔
        hogger,//霍格
        demonhunter,//恶魔猎手
        deathknight,//巫妖王
    }

    /// <summary>
    /// 对局信息
    /// </summary>    
    public class Hrtprozis  //Hrtprozis是兄弟中非常重要的一个类，记录着从兄弟内部数据中获取到的各种信息
    {
        public int pId = 0;//唯一id
        public int attackFaceHp = 15;//打脸血量
        public int ownHeroFatigue = 0;//我方疲劳
        public int ownDeckSize = 30;  //我方牌库数量
        public int enemyDeckSize = 30; // 敌方牌库数量
        public int enemyHeroFatigue = 0;  //敌方疲劳      
        public int gTurn = 0;           // 第几个回合，敌方双方都算 我方先手，则是1357....
        public int gTurnStep = 0;       // 同一个回合内，第几个操作

        public int ownHeroEntity = -1;   // 我方英雄Entity
        public int enemyHeroEntitiy = -1;
        public DateTime roundstart = DateTime.Now;//回合开始时间
        public int currentMana = 0;//当前法力值

        public int heroHp = 30, enemyHp = 30;          //血量
        public int heroAtk = 0, enemyAtk = 0;          // 攻击力
        public int heroDefence = 0, enemyDefence = 0;  // 护甲
        public bool ownheroisread = false;//我方英雄是否可以攻击
        public int ownHeroNumAttacksThisTurn = 0;//我方英雄此回合攻击了几次
        public bool ownHeroWindfury = false; //我方英雄是否风怒
        public bool herofrozen = false;//我方英雄是否冻结
        public bool enemyfrozen = false;//敌方英雄是否冻结

        public List<CardDB.cardIDEnum> ownSecretList = new List<CardDB.cardIDEnum>();//我方奥秘列表
        public int enemySecretCount = 0;//敌方奥秘数量
        public Dictionary<int, CardDB.cardIDEnum> DiscoverCards = new Dictionary<int, CardDB.cardIDEnum>();//发现的卡牌
        public Dictionary<CardDB.cardIDEnum, int> turnDeck = new Dictionary<CardDB.cardIDEnum, int>();//牌库的卡牌
        private Dictionary<int, CardDB.cardIDEnum> deckCardForCost = new Dictionary<int, CardDB.cardIDEnum>();//指定费用的卡牌
        public bool noDuplicates = false;//牌库无重复（宇宙）
        public bool patchesInDeck = false;

        private int numTauntCards = -1;//牌库有几张嘲讽卡
        private int numDivineShieldCards = -1;  // 牌库有几张圣盾卡
        private int numLifestealCards = -1;  // 牌库有几张吸血卡
        private int numWindfuryCards = -1;  //牌库有几张风怒卡
        private int numSecretCards = -1; //牌库有几张奥秘卡，用于远古谜团等判断

        public bool setGameRule = false;//设置Rule

        public HeroEnum heroname = HeroEnum.None, enemyHeroname = HeroEnum.None;//我方英雄职业，敌方英雄职业
        public string heronameingame = "", enemyHeronameingame = "";//我方英雄名称，敌方英雄名称
        public TAG_CLASS ownHeroStartClass = TAG_CLASS.INVALID;//我方英雄职业
        public TAG_CLASS enemyHeroStartClass = TAG_CLASS.INVALID;//敌方英雄职业
        public CardDB.Card heroAbility;//我方英雄技能
        public bool ownAbilityisReady = false;//我方英雄技能是否准备完成
        public int ownHeroPowerCost = 2;//我方英雄技能费用
        public CardDB.Card enemyAbility;//敌方英雄技能
        public int enemyHeroPowerCost = 2;//敌方英雄技能费用
        public int numOptionsPlayedThisTurn = 0;//此回合中的操作数
        public int numMinionsPlayedThisTurn = 0;//此回合中的随从数
        public CardDB.cardIDEnum OwnLastDiedMinion = CardDB.cardIDEnum.None;//我方最后死亡的随从

        public int cardsPlayedThisTurn = 0;//此回合中的出牌数，可以用于判定连击
        public int ueberladung = 0; //过载水晶
        public int lockedMana = 0;//锁定水晶

        public int ownMaxMana = 0;//我方最大法力值
        public int enemyMaxMana = 0;//敌方最大法力值

        public Minion ownHero = new Minion();//我方英雄
        public Minion enemyHero = new Minion();//敌方英雄
        public Weapon ownWeapon = new Weapon(); //我方武器
        public Weapon enemyWeapon = new Weapon();//敌方武器
        public List<Minion> ownMinions = new List<Minion>();//我方随从
        public List<Minion> enemyMinions = new List<Minion>();//敌方随从
        public Dictionary<int, IDEnumOwner> LurkersDB = new Dictionary<int, IDEnumOwner>(); //潜行随从

        public int anzOgOwnCThunHpBonus = 0;//克苏恩血量
        public int anzOgOwnCThunAngrBonus = 0;//克苏恩攻击力
        public int anzOgOwnCThunTaunt = 0; //克苏恩嘲讽
        public int anzOwnJadeGolem = 0;//我方魔像计数器
        public int anzEnemyJadeGolem = 0;//敌方魔像计数器
        public int ownCrystalCore = 0;//魔王的骑士：水晶核心，任务贼的任务奖励，在本局对战的剩余时间内，你的所有随从变为 4/4。
        public bool ownMinionsInDeckCost0 = false;//我方牌库中是否有0费随从
        public int anzOwnElementalsThisTurn = 0;//在此回合中使用元素牌
        public int anzOwnElementalsLastTurn = 0;//上一回合使用元素牌
        public int useNature = 0;//是否有自然使徒在手上的时候使用过自然法术
        public int ownElementalsHaveLifesteal = 0;//我方元素牌具有吸血
        private int ownPlayerController = 0;//我方玩家控制？
        public bool LothraxionsPower = false;//使白银之手新兵获得圣盾
        public bool anzTamsin = false;//术士任务线 SW_091

        public string enemyDeckName = ""; //猜测对手的套牌名称
        public string enemyDeckCode = ""; //猜测对手的套牌代码
        public Dictionary<string, int> guessEnemyDeck = new Dictionary<string, int>();//猜测对手剩余卡牌
        public int enemyDirectDmg = 0; //预计对手斩杀线
        public int similarity = 66;

        //连续使用元素牌的回合数
        public int ownConsecutiveElementalTurns = 0;
        //上个回合玩家使用的元素牌数量
        public int ownElementalsPlayedLastTurn = 0;

        public List<CardDB.cardIDEnum> enchs = new List<CardDB.cardIDEnum>();

        public PenalityManager penman;//惩罚管理
        public Settings settings;//设置管理
        Helpfunctions help;//调试输出
        CardDB cdb;//卡牌数据

        private static Hrtprozis instance;

        public static Hrtprozis Instance
        {
            get
            {
                return instance ?? (instance = new Hrtprozis());
            }
        }

        public void setInstances()
        {
            help = Helpfunctions.Instance;
            penman = PenalityManager.Instance;
            settings = Settings.Instance;
            cdb = CardDB.Instance;
        }

        private Hrtprozis()
        {
        }

        public void setAttackFaceHP(int hp)
        {
            this.attackFaceHp = hp;
        }

        public int getPid()
        {
            return pId++;
        }

        public void clearAllNewGame()
        {
            this.ownHeroStartClass = TAG_CLASS.INVALID;
            this.enemyHeroStartClass = TAG_CLASS.INVALID;
            this.setGameRule = false;
            enchs = new List<CardDB.cardIDEnum>();
            this.clearAllRecalc();
        }

        public void clearAllRecalc()
        {
            pId = 0;
            ownHeroEntity = -1;
            enemyHeroEntitiy = -1;
            numSecretCards = -1; //初始化
            currentMana = 0;
            heroHp = 30;
            enemyHp = 30;
            heroAtk = 0;
            enemyAtk = 0;
            heroDefence = 0; enemyDefence = 0;
            ownheroisread = false;
            ownAbilityisReady = false;
            ownHeroNumAttacksThisTurn = 0;
            ownHeroWindfury = false;
            ownSecretList.Clear();
            enemySecretCount = 0;
            heroname = HeroEnum.None;
            enemyHeroname = HeroEnum.None;
            heronameingame = "";
            enemyHeronameingame = "";
            heroAbility = new CardDB.Card();
            enemyAbility = new CardDB.Card();
            herofrozen = false;
            enemyfrozen = false;
            numMinionsPlayedThisTurn = 0;
            cardsPlayedThisTurn = 0;
            ueberladung = 0;
            lockedMana = 0;
            ownMaxMana = 0;
            enemyMaxMana = 0;
            ownWeapon = new Weapon();
            enemyWeapon = new Weapon();
            ownMinions.Clear();
            enemyMinions.Clear();
            noDuplicates = false;
            deckCardForCost.Clear();
            turnDeck.Clear();
            LothraxionsPower = false;
            patchesInDeck = false;
            anzTamsin = false;
            enemyDeckCode = "";
            enemyDirectDmg = 0;
            guessEnemyDeck = new Dictionary<string, int>();
            enemyDeckName = "";
            similarity = 50;
        }


        public void setOwnPlayer(int player)
        {
            this.ownPlayerController = player;
        }

        public int getOwnController()
        {
            return this.ownPlayerController;
        }
        //新兵圣盾
        public void updatePlayerAttachments(bool LothraxionsPower)
        {
            this.LothraxionsPower = LothraxionsPower;
        }

        public void updateJadeGolemsInfo(int anzOwnJG, int anzEmemyJG)
        {//更新青玉魔像
            anzOwnJadeGolem = anzOwnJG;
            anzEnemyJadeGolem = anzEmemyJG;
        }

        public void updateCrystalCore(int num)
        {//任务贼奖励
            ownCrystalCore = num;
        }

        public void updateOwnMinionsInDeckCost0(bool tmp)
        {
            ownMinionsInDeckCost0 = tmp;
        }

        public void updateElementals(int anzOwnElemTT, int anzOwnElemLT, int ownElementalsHaveLS)
        {//元素
            anzOwnElementalsThisTurn = anzOwnElemTT;
            anzOwnElementalsLastTurn = anzOwnElemLT;
            ownElementalsHaveLifesteal = ownElementalsHaveLS;
        }


        //英雄ID转到名称
        public string heroIDtoName(string s)
        {
            if (s.StartsWith("HERO_01")) return "warrior";
            else if (s.StartsWith("HERO_02")) return "shaman";
            else if (s.StartsWith("HERO_03")) return "thief";
            else if (s.StartsWith("HERO_04")) return "pala";
            else if (s.StartsWith("HERO_05")) return "hunter";
            else if (s.StartsWith("HERO_06")) return "druid";
            else if (s.StartsWith("HERO_07")) return "warlock";
            else if (s.StartsWith("HERO_08")) return "mage";
            else if (s.StartsWith("HERO_09")) return "priest";
            else if (s.StartsWith("HERO_10")) return "demonhunter";
            else if (s.StartsWith("HERO_11")) return "deathknight";

            switch (s)
            {//添加英雄sim编号到名字的转换
                case "HERO_01": return "warrior";
                case "HERO_01a": return "warrior";
                case "ICC_834": return "warrior";
                case "HERO_02": return "shaman";
                case "HERO_02a": return "shaman";
                case "ICC_481": return "shaman";

                case "HERO_03": return "thief";
                case "HERO_03a": return "thief";
                case "ICC_827": return "thief";
                case "HERO_04": return "pala";
                case "HERO_04a": return "pala";
                case "HERO_04b": return "pala";

                case "ICC_829": return "pala";
                case "HERO_05": return "hunter";
                case "HERO_05a": return "hunter";
                case "ICC_828": return "hunter";

                case "HERO_06": return "druid";
                case "ICC_832": return "druid";

                case "HERO_07": return "warlock";
                case "HERO_07a": return "warlock";
                case "ICC_831": return "warlock";

                case "HERO_08": return "mage";
                case "HERO_08a": return "mage";
                case "HERO_08b": return "mage";
                case "ICC_833": return "mage";

                case "HERO_09": return "priest";
                case "HERO_09a": return "priest";
                case "HERO_10": return "demonhunter";
                case "HERO_10a": return "demonhunter";
                case "ICC_830": return "priest";
                case "EX1_323h": return "lordjaraxxus";
                case "BRM_027h": return "ragnarosthefirelord";
                default:
                    string retval = cdb.getCardDataFromID(cdb.cardIdstringToEnum(s)).nameCN.ToString();
                    return retval;
            }
        }

        //英雄ID转到名称
        public string heroPowerToName(string s)
        {
            if (s.StartsWith("HERO_01")) return "warrior";
            else if (s.StartsWith("HERO_02")) return "shaman";
            else if (s.StartsWith("HERO_03")) return "thief";
            else if (s.StartsWith("HERO_04")) return "pala";
            else if (s.StartsWith("HERO_05")) return "hunter";
            else if (s.StartsWith("HERO_06")) return "druid";
            else if (s.StartsWith("HERO_07")) return "warlock";
            else if (s.StartsWith("HERO_08")) return "mage";
            else if (s.StartsWith("HERO_09")) return "perist";
            else if (s.StartsWith("HERO_10")) return "demonhunter";
            else if (s.StartsWith("HERO_11")) return "deathknight";

            switch (s)
            {//添加英雄sim编号到名字的转换
                case "HERO_01": return "warrior";
                case "HERO_01a": return "warrior";
                case "ICC_834": return "warrior";
                case "HERO_02": return "shaman";
                case "HERO_02a": return "shaman";
                case "ICC_481": return "shaman";
                case "HERO_03": return "thief";
                case "HERO_03a": return "thief";
                case "ICC_827": return "thief";
                case "HERO_04": return "pala";
                case "HERO_04a": return "pala";
                case "HERO_04b": return "pala";
                case "ICC_829": return "pala";
                case "HERO_05": return "hunter";
                case "HERO_05a": return "hunter";
                case "ICC_828": return "hunter";
                case "HERO_06": return "druid";
                case "ICC_832": return "druid";
                case "HERO_07": return "warlock";
                case "HERO_07a": return "warlock";
                case "ICC_831": return "warlock";
                case "HERO_08": return "mage";
                case "HERO_08a": return "mage";
                case "HERO_08b": return "mage";
                case "ICC_833": return "mage";
                case "HERO_09": return "priest";
                case "HERO_09a": return "priest";
                case "HERO_10": return "demonhunter";
                case "HERO_10a": return "demonhunter";
                case "ICC_830": return "priest";
                case "EX1_323h": return "lordjaraxxus";
                case "BRM_027h": return "ragnarosthefirelord";
                default:
                    string retval = cdb.getCardDataFromID(cdb.cardIdstringToEnum(s)).nameCN.ToString();
                    return retval;
            }
        }
        //英雄名称转到枚举，留牌文件就是用这个函数进行转换的，由此可见圣骑士的名称用pala和paladin是一样的
        public HeroEnum heroNametoEnum(string s)
        {
            switch (s)
            {
                case "weizbang": return HeroEnum.weizbang;
                case "druid": return HeroEnum.druid;
                case "hunter": return HeroEnum.hunter;
                case "mage": return HeroEnum.mage;
                case "法师": return HeroEnum.mage;
                case "pala": return HeroEnum.pala;
                case "paladin": return HeroEnum.pala;
                case "priest": return HeroEnum.priest;
                case "shaman": return HeroEnum.shaman;
                case "thief": return HeroEnum.thief;
                case "rogue": return HeroEnum.thief;
                case "maievshadowsong": return HeroEnum.thief;
                case "warlock": return HeroEnum.warlock;
                case "warrior": return HeroEnum.warrior;
                case "demonhunter": return HeroEnum.demonhunter;
                case "Illidanstormrage": return HeroEnum.demonhunter;
                case "lordjaraxxus": return HeroEnum.lordjaraxxus;
                case "ragnarosthefirelord": return HeroEnum.ragnarosthefirelord;
                case "deathknight": return HeroEnum.deathknight;
                default:
                    if (s.EndsWith("吉安娜"))
                        return HeroEnum.mage;
                    else if (s.EndsWith("雷克萨"))
                        return HeroEnum.hunter;
                    Helpfunctions.Instance.logg("异常，不认识敌方英雄:" + s);
                    return HeroEnum.None;
            }
        }
        //英雄枚举转到种类
        public TAG_CLASS heroEnumtoTagClass(HeroEnum he)
        {
            switch (he)
            {
                case HeroEnum.druid: return TAG_CLASS.DRUID;
                case HeroEnum.hunter: return TAG_CLASS.HUNTER;
                case HeroEnum.mage: return TAG_CLASS.MAGE;
                case HeroEnum.pala: return TAG_CLASS.PALADIN;
                case HeroEnum.priest: return TAG_CLASS.PRIEST;
                case HeroEnum.shaman: return TAG_CLASS.SHAMAN;
                case HeroEnum.thief: return TAG_CLASS.ROGUE;
                case HeroEnum.warlock: return TAG_CLASS.WARLOCK;
                case HeroEnum.warrior: return TAG_CLASS.WARRIOR;
                case HeroEnum.demonhunter: return TAG_CLASS.DEMONHUNTER;
                case HeroEnum.deathknight: return TAG_CLASS.DEATHKNIGHT;
                case HeroEnum.weizbang: return TAG_CLASS.WHIZBANG;
                default: return TAG_CLASS.INVALID;
            }
        }
        //英雄种类转到枚举
        public HeroEnum heroTAG_CLASSstringToEnum(string s)
        {
            switch (s)
            {
                case "DRUID": return HeroEnum.druid;
                case "HUNTER": return HeroEnum.hunter;
                case "MAGE": return HeroEnum.mage;
                case "PALADIN": return HeroEnum.pala;
                case "PRIEST": return HeroEnum.priest;
                case "SHAMAN": return HeroEnum.shaman;
                case "ROGUE": return HeroEnum.thief;
                case "WARLOCK": return HeroEnum.warlock;
                case "WARRIOR": return HeroEnum.warrior;
                default: return HeroEnum.None;
            }
        }

        public void updateMinions(List<Minion> om, List<Minion> em)
        {//更新随从信息
            this.ownMinions.Clear();
            this.enemyMinions.Clear();
            foreach (var item in om)
            {
                this.ownMinions.Add(new Minion(item));
            }
            //this.ownMinions.AddRange(om);
            foreach (var item in em)
            {
                this.enemyMinions.Add(new Minion(item));
            }
            //this.enemyMinions.AddRange(em);

            //sort them 
            updatePositions();
        }

        public void updateLurkersDB(Dictionary<int, IDEnumOwner> ldb)
        {//潜伏者
            this.LurkersDB.Clear();
            foreach (KeyValuePair<int, IDEnumOwner> lt in ldb)
            {
                this.LurkersDB.Add(lt.Key, lt.Value);
            }
        }

        public void updateSecretStuff(List<string> ownsecs, int numEnemSec)
        {//更新奥秘状态
            this.ownSecretList.Clear();
            foreach (string s in ownsecs)
            {
                this.ownSecretList.Add(cdb.cardIdstringToEnum(s));
            }
            this.enemySecretCount = numEnemSec;
        }

        public void updateTurnDeck(Dictionary<CardDB.cardIDEnum, int> deck)
        {
            this.turnDeck.Clear();
            var patchesidsk = false;
            var noDupl = true;
            foreach (KeyValuePair<CardDB.cardIDEnum, int> c in deck)
            {
                this.turnDeck.Add(c.Key, c.Value);
                if (!patchesidsk && c.Key == CardDB.cardIDEnum.CFM_637)
                    patchesidsk = true;
                if (c.Value > 1)
                    noDupl = false;
            }
            this.noDuplicates = noDupl;
            this.patchesInDeck = patchesidsk;
            deckCardForCost.Clear();
        }
        //读取牌库中X费的卡牌
        public CardDB.cardIDEnum getDeckCardsForCost(int cost)
        {
            if (deckCardForCost.Count == 0)
            {
                CardDB.Card c;
                foreach (KeyValuePair<CardDB.cardIDEnum, int> cn in turnDeck)
                {
                    c = CardDB.Instance.getCardDataFromID(cn.Key);
                    if (!deckCardForCost.ContainsKey(c.cost)) deckCardForCost.Add(c.cost, c.cardIDenum);
                }
            }
            if (deckCardForCost.ContainsKey(cost)) return deckCardForCost[cost];
            else return CardDB.cardIDEnum.None;
        }
        //读取牌库中指定特性的卡牌(GAME_TAGs.TAUNT,GAME_TAGs.DIVINE_SHIELD,GAME_TAGs.LIFESTEAL,GAME_TAGs.WINDFURY)
        public int numDeckCardsByTag(GAME_TAGs tag)
        {
            switch (tag)
            {
                case GAME_TAGs.TAUNT: if (numTauntCards > -1) return numTauntCards; break;
                case GAME_TAGs.DIVINE_SHIELD: if (numDivineShieldCards > -1) return numDivineShieldCards; break;
                case GAME_TAGs.LIFESTEAL: if (numLifestealCards > -1) return numLifestealCards; break;
                case GAME_TAGs.WINDFURY: if (numWindfuryCards > -1) return numWindfuryCards; break;
                case GAME_TAGs.SECRET: if (numSecretCards > -1) return numSecretCards; break;
            }
            numTauntCards = 0;
            numDivineShieldCards = 0;
            numLifestealCards = 0;
            numWindfuryCards = 0;
            numSecretCards = 0;

            CardDB.Card c;
            foreach (KeyValuePair<CardDB.cardIDEnum, int> cn in turnDeck)
            {
                c = CardDB.Instance.getCardDataFromID(cn.Key);
                if (c.tank) numTauntCards += cn.Value;
                if (c.Shield) numDivineShieldCards += cn.Value;
                if (c.lifesteal) numLifestealCards += cn.Value;
                if (c.windfury) numWindfuryCards += cn.Value;
                if (c.Secret) numSecretCards += cn.Value;
            }

            switch (tag)
            {
                case GAME_TAGs.TAUNT: return numTauntCards;
                case GAME_TAGs.DIVINE_SHIELD: return numDivineShieldCards;
                case GAME_TAGs.LIFESTEAL: return numLifestealCards;
                case GAME_TAGs.WINDFURY: return numWindfuryCards;
                case GAME_TAGs.SECRET: return numSecretCards;
            }
            return -1;
        }

        public void updatePlayer(int maxmana, int currentmana, int cardsplayedthisturn, int numMinionsplayed, int optionsPlayedThisTurn, int overload, int lockedmana, int heroentity, int enemyentity)
        {
            this.currentMana = currentmana;
            this.ownMaxMana = maxmana;
            this.cardsPlayedThisTurn = cardsplayedthisturn;
            this.numMinionsPlayedThisTurn = numMinionsplayed;
            this.ueberladung = overload;
            this.lockedMana = lockedmana;
            this.ownHeroEntity = heroentity;
            this.enemyHeroEntitiy = enemyentity;
            this.numOptionsPlayedThisTurn = optionsPlayedThisTurn;
        }

        public void updateHeroStartClass(TAG_CLASS ownHSClass, TAG_CLASS enemyHSClass)
        {
            this.ownHeroStartClass = ownHSClass;
            this.enemyHeroStartClass = enemyHSClass;
        }


        public void updateHero(Weapon w, string heron, CardDB.Card ability, bool abrdy, int abCost, Minion hero, int enMaxMana = 10)
        {
            if (w.name == CardDB.cardNameEN.foolsbane) w.cantAttackHeroes = true;

            if (hero.own)
            {
                this.ownWeapon = new Weapon(w);

                this.ownHero = new Minion(hero);
                this.heroname = this.heroNametoEnum(heron);
                this.heronameingame = heron;
                if (this.ownHeroStartClass == TAG_CLASS.INVALID) this.ownHeroStartClass = hero.cardClass;
                this.ownHero.poisonous = this.ownWeapon.poisonous;
                this.ownHero.lifesteal = this.ownWeapon.lifesteal;
                if (this.ownWeapon.name == CardDB.cardNameEN.gladiatorslongbow) this.ownHero.immuneWhileAttacking = true;

                this.heroAbility = ability;
                this.ownHeroPowerCost = abCost;
                this.ownAbilityisReady = abrdy;
            }
            else
            {
                this.enemyWeapon = new Weapon(w);
                this.enemyHero = new Minion(hero); ;

                this.enemyHeroname = this.heroNametoEnum(heron);
                this.enemyHeronameingame = heron;
                if (this.enemyHeroStartClass == TAG_CLASS.INVALID) this.enemyHeroStartClass = enemyHero.cardClass;
                this.enemyHero.poisonous = this.enemyWeapon.poisonous;
                this.enemyHero.lifesteal = this.enemyWeapon.lifesteal;
                if (this.enemyWeapon.name == CardDB.cardNameEN.gladiatorslongbow) this.enemyHero.immuneWhileAttacking = true;

                this.enemyAbility = ability;
                this.enemyHeroPowerCost = abCost;

                this.enemyMaxMana = enMaxMana;
            }
        }

        public void updateTurnInfo(int turn, int step)
        {
            this.gTurn = turn;
            this.gTurnStep = step;
        }

        public void updateCThunInfo(int OgOwnCThunAngrBonus, int OgOwnCThunHpBonus, int OgOwnCThunTaunt)
        {
            this.anzOgOwnCThunAngrBonus = OgOwnCThunAngrBonus;
            this.anzOgOwnCThunHpBonus = OgOwnCThunHpBonus;
            this.anzOgOwnCThunTaunt = OgOwnCThunTaunt;
        }

        public void updateFatigueStats(int ods, int ohf, int eds, int ehf)
        {
            this.ownDeckSize = ods;
            this.ownHeroFatigue = ohf;
            this.enemyDeckSize = eds;
            this.enemyHeroFatigue = ehf;
        }

        public void updatePositions()
        {
            this.ownMinions.Sort((a, b) => a.zonepos.CompareTo(b.zonepos));
            this.enemyMinions.Sort((a, b) => a.zonepos.CompareTo(b.zonepos));
            int i = 0;
            foreach (Minion m in this.ownMinions)
            {
                i++;
                m.zonepos = i;

            }
            i = 0;
            foreach (Minion m in this.enemyMinions)
            {
                i++;
                m.zonepos = i;
            }

        }

        public void updateDiscoverCards(List<string> discoverCardsList)
        {
            if (discoverCardsList.Count == 4)
            {
                this.DiscoverCards.Clear();
                for (int i = 0; i < 3; i++)
                {
                    this.DiscoverCards.Add(i, cdb.cardIdstringToEnum(discoverCardsList[i + 1]));
                }
            }
        }

        public void updateOwnLastDiedMinion(CardDB.cardIDEnum cid)
        {
            this.OwnLastDiedMinion = cid;
        }

        private Minion createNewMinion(Handmanager.Handcard hc, int id)
        {
            Minion m = new Minion
            {
                handcard = new Handmanager.Handcard(hc),
                zonepos = id + 1,
                entitiyID = hc.entity,
                Angr = hc.card.Attack,
                Hp = hc.card.Health,
                maxHp = hc.card.Health,
                name = hc.card.nameEN,
                nameCN = hc.card.nameCN,
                playedThisTurn = true,
                numAttacksThisTurn = 0,
                CooldownTurn = hc.card.CooldownTurn
            };


            if (hc.card.windfury) m.windfury = true;
            if (hc.card.tank) m.taunt = true;
            if (hc.card.Charge)
            {
                m.Ready = true;
                m.charge = 1;
            }
            if (hc.card.Shield) m.divineshild = true;
            if (hc.card.poisonous) m.poisonous = true;
            if (hc.card.lifesteal) m.lifesteal = true;
            if (hc.card.reborn) m.reborn = true;
            if (hc.card.Rush) m.rush = 1;

            if (hc.card.Stealth) m.stealth = true;

            if (m.name == CardDB.cardNameEN.lightspawn && !m.silenced)
            {
                m.Angr = m.Hp;
            }


            return m;
        }
        //输出当前场面上的信息到日志
        public void printHero()
        {
            help.logg("player:");
            help.logg(this.numMinionsPlayedThisTurn + " " + this.cardsPlayedThisTurn + " " + this.ueberladung + " " + this.lockedMana + " " + this.ownPlayerController);

            help.logg("ownhero:");
            help.logg((this.heroname == HeroEnum.None ? this.heronameingame : this.heroname.ToString()) + " " + this.ownHero.Hp + " " + this.ownHero.maxHp + " " + this.ownHero.armor + " " + this.ownHero.immuneWhileAttacking + " " + this.ownHero.immune + " " + this.ownHero.entitiyID + " " + this.ownHero.Ready + " " + this.ownHero.numAttacksThisTurn + " " + this.ownHero.frozen + " " + this.ownHero.Angr + " " + this.ownHero.tempAttack + " " + this.enemyHero.stealth
                + (this.ownHero.enchs.Length > 0 ? " 附魔:" + this.ownHero.enchs : "")
                );
            help.logg("weapon: " + ownWeapon.Angr + " " + ownWeapon.Durability + " " + this.ownWeapon.card.nameCN + " " + this.ownWeapon.card.cardIDenum + " " + (this.ownWeapon.poisonous ? 1 : 0) + " " + (this.ownWeapon.lifesteal ? 1 : 0) + " " + this.ownWeapon.scriptNum1);
            help.logg("ability: " + this.ownAbilityisReady + " " + this.heroAbility.cardIDenum);
            string secs = "";
            foreach (CardDB.cardIDEnum sec in this.ownSecretList)
            {
                secs += sec + " ";
            }
            help.logg("osecrets: " + secs);
            help.logg("cthunbonus: " + this.anzOgOwnCThunAngrBonus + " " + this.anzOgOwnCThunHpBonus + " " + this.anzOgOwnCThunTaunt);
            help.logg("jadegolems: " + this.anzOwnJadeGolem + " " + this.anzEnemyJadeGolem);
            help.logg("elementals: " + this.anzOwnElementalsThisTurn + " " + this.anzOwnElementalsLastTurn + " " + this.ownElementalsHaveLifesteal);
            help.logg(Questmanager.Instance.getQuestsString());
            help.logg("advanced: " + this.ownCrystalCore + " " + (this.ownMinionsInDeckCost0 ? 1 : 0));
            help.logg("enemyhero:");
            help.logg((this.enemyHeroname == HeroEnum.None ? this.enemyHeronameingame : this.enemyHeroname.ToString()) + " " + this.enemyHero.Hp + " " + this.enemyHero.maxHp + " " + this.enemyHero.armor + " " + this.enemyHero.frozen + " " + this.enemyHero.immune + " " + this.enemyHero.entitiyID + " " + this.enemyHero.stealth + (this.enemyHero.enchs.Length > 0 ? " 附魔:" + this.enemyHero.enchs : ""));
            help.logg("weapon: " + this.enemyWeapon.Angr + " " + this.enemyWeapon.Durability + " " + this.enemyWeapon.card.nameCN + " " + this.enemyWeapon.card.cardIDenum + " " + (this.enemyWeapon.poisonous ? 1 : 0) + " " + (this.enemyWeapon.lifesteal ? 1 : 0) + " " + this.enemyWeapon.scriptNum1);
            help.logg("ability: " + "True" + " " + this.enemyAbility.cardIDenum);
            help.logg("fatigue: " + this.ownDeckSize + " " + this.ownHeroFatigue + " " + this.enemyDeckSize + " " + this.enemyHeroFatigue);
        }

        //输出我方随从信息到日志
        public void printOwnMinions()
        {
            help.logg("OwnMinions:");
            foreach (Minion m in this.ownMinions)
            {
                string mini = m.handcard.card.nameCN + "(" + m.Angr + "/" + m.Hp + ")" + " " + m.handcard.card.cardIDenum + " zp:" + m.zonepos + " e:" + m.entitiyID + " A:" + m.Angr + " H:" + m.Hp + " mH:" + m.maxHp + " rdy:" + m.Ready + " natt:" + m.numAttacksThisTurn;
                if (m.exhausted) mini += " ex";
                if (m.taunt) mini += " tnt";
                if (m.frozen) mini += " frz";
                if (m.silenced) mini += " silenced";
                if (m.divineshild) mini += " divshield";
                if (m.Spellburst) mini += " 法术迸发";
                if (m.Frenzy) mini += " 暴怒";
                if (m.playedThisTurn) mini += " ptt";
                if (m.windfury) mini += " wndfr";
                if (m.stealth) mini += " stlth";
                if (m.poisonous) mini += " poi";
                if (m.lifesteal) mini += " lfst";
                if (m.immune) mini += " imm";
                if (m.untouchable) mini += " untch";
                if (m.conceal) mini += " cncdl";
                if (m.destroyOnOwnTurnStart) mini += " dstrOwnTrnStrt";
                if (m.destroyOnOwnTurnEnd) mini += " dstrOwnTrnnd";
                if (m.destroyOnEnemyTurnStart) mini += " dstrEnmTrnStrt";
                if (m.destroyOnEnemyTurnEnd) mini += " dstrEnmTrnnd";
                if (m.shadowmadnessed) mini += " shdwmdnssd";
                if (m.cantLowerHPbelowONE) mini += " cantLowerHpBelowOne";
                // if (m.cantBeTargetedBySpellsOrHeroPowers) mini += " cbtBySpells";
                if (m.Elusive) mini += "elus";
                if (m.charge >= 1) mini += " chrg(" + m.charge + ")";
                if (m.hChoice >= 1) mini += " hChoice(" + m.hChoice + ")";
                if (m.AdjacentAngr >= 1) mini += " adjaattk(" + m.AdjacentAngr + ")";
                if (m.tempAttack != 0) mini += " tmpattck(" + m.tempAttack + ")";
                if (m.spellpower != 0) mini += " spllpwr(" + m.spellpower + ")";

                if (m.ancestralspirit >= 1) mini += " ancstrl(" + m.ancestralspirit + ")";
                if (m.desperatestand >= 1) mini += " despStand(" + m.desperatestand + ")";
                if (m.ownBlessingOfWisdom >= 1) mini += " ownBlssng(" + m.ownBlessingOfWisdom + ")";
                if (m.enemyBlessingOfWisdom >= 1) mini += " enemyBlssng(" + m.enemyBlessingOfWisdom + ")";
                if (m.ownPowerWordGlory >= 1) mini += " ownGlory(" + m.ownPowerWordGlory + ")";
                if (m.enemyPowerWordGlory >= 1) mini += " enemyGlory(" + m.enemyPowerWordGlory + ")";
                if (m.souloftheforest >= 1) mini += " souloffrst(" + m.souloftheforest + ")";
                if (m.stegodon >= 1) mini += " stegodon(" + m.stegodon + ")";
                if (m.livingspores >= 1) mini += " lspores(" + m.livingspores + ")";
                if (m.explorershat >= 1) mini += " explHat(" + m.explorershat + ")";
                if (m.returnToHand >= 1) mini += " retHand(" + m.returnToHand + ")";
                if (m.infest >= 1) mini += " infest(" + m.infest + ")";
                if (m.deathrattle2 != null) mini += " dethrl(" + m.deathrattle2.cardIDenum + ")";
                if (m.name == CardDB.cardNameEN.moatlurker && this.LurkersDB.ContainsKey(m.entitiyID))
                {
                    mini += " respawn:" + this.LurkersDB[m.entitiyID].IDEnum + ":" + this.LurkersDB[m.entitiyID].own;
                }

                if (m.enchs.Length > 0) mini += " 附魔:" + m.enchs;

                help.logg(mini);
            }

        }
        //输出敌方随从信息到日志
        public void printEnemyMinions()
        {
            help.logg("EnemyMinions:");
            foreach (Minion m in this.enemyMinions)
            {
                string mini = m.handcard.card.nameCN + "(" + m.Angr + "/" + m.Hp + ")" + " " + m.handcard.card.cardIDenum + " zp:" + m.zonepos + " e:" + m.entitiyID + " A:" + m.Angr + " H:" + m.Hp + " mH:" + m.maxHp + " rdy:" + m.Ready;// +" natt:" + m.numAttacksThisTurn;
                if (m.exhausted) mini += " ex";
                if (m.taunt) mini += " tnt";
                if (m.frozen) mini += " frz";
                if (m.silenced) mini += " silenced";
                if (m.divineshild) mini += " divshield";
                if (m.Spellburst) mini += " 法术迸发";
                if (m.Frenzy) mini += " 暴怒";
                if (m.playedThisTurn) mini += " ptt";
                if (m.windfury) mini += " wndfr";
                if (m.stealth) mini += " stlth";
                if (m.poisonous) mini += " poi";
                if (m.lifesteal) mini += " lfst";
                if (m.immune) mini += " imm";
                if (m.untouchable) mini += " untch";
                if (m.conceal) mini += " cncdl";
                if (m.destroyOnOwnTurnStart) mini += " dstrOwnTrnStrt";
                if (m.destroyOnOwnTurnEnd) mini += " dstrOwnTrnnd";
                if (m.destroyOnEnemyTurnStart) mini += " dstrEnmTrnStrt";
                if (m.destroyOnEnemyTurnEnd) mini += " dstrEnmTrnnd";
                if (m.shadowmadnessed) mini += " shdwmdnssd";
                if (m.cantLowerHPbelowONE) mini += " cantLowerHpBelowOne";
                // if (m.cantBeTargetedBySpellsOrHeroPowers) mini += " cbtBySpells";
                if (m.Elusive) mini += "elus";

                if (m.charge >= 1) mini += " chrg(" + m.charge + ")";
                if (m.hChoice >= 1) mini += " hChoice(" + m.hChoice + ")";
                if (m.AdjacentAngr >= 1) mini += " adjaattk(" + m.AdjacentAngr + ")";
                if (m.tempAttack != 0) mini += " tmpattck(" + m.tempAttack + ")";
                if (m.spellpower != 0) mini += " spllpwr(" + m.spellpower + ")";

                if (m.ancestralspirit >= 1) mini += " ancstrl(" + m.ancestralspirit + ")";
                if (m.desperatestand >= 1) mini += " despStand(" + m.desperatestand + ")";
                if (m.ownBlessingOfWisdom >= 1) mini += " ownBlssng(" + m.ownBlessingOfWisdom + ")";
                if (m.enemyBlessingOfWisdom >= 1) mini += " enemyBlssng(" + m.enemyBlessingOfWisdom + ")";
                if (m.ownPowerWordGlory >= 1) mini += " ownGlory(" + m.ownPowerWordGlory + ")";
                if (m.enemyPowerWordGlory >= 1) mini += " enemyGlory(" + m.enemyPowerWordGlory + ")";
                if (m.souloftheforest >= 1) mini += " souloffrst(" + m.souloftheforest + ")";
                if (m.stegodon >= 1) mini += " stegodon(" + m.stegodon + ")";
                if (m.livingspores >= 1) mini += " lspores(" + m.livingspores + ")";
                if (m.explorershat >= 1) mini += " explHat(" + m.explorershat + ")";
                if (m.returnToHand >= 1) mini += " retHand(" + m.returnToHand + ")";
                if (m.infest >= 1) mini += " infest(" + m.infest + ")";
                if (m.deathrattle2 != null) mini += " dethrl(" + m.deathrattle2.cardIDenum + ")";
                if (m.name == CardDB.cardNameEN.moatlurker && this.LurkersDB.ContainsKey(m.entitiyID))
                {
                    mini += " respawn:" + this.LurkersDB[m.entitiyID].IDEnum + ":" + this.LurkersDB[m.entitiyID].own;
                }

                if (m.enchs.Length > 0) mini += " 附魔:" + m.enchs;

                help.logg(mini);
            }

        }
        //输出我方牌库信息(兄弟的牌库读取时好时坏)
        public void printOwnDeck()
        {
            string od = "od: ";
            foreach (KeyValuePair<CardDB.cardIDEnum, int> e in this.turnDeck)
            {
                od += e.Key + "," + e.Value + ";";
            }
            Helpfunctions.Instance.logg(od);
        }

    }

}