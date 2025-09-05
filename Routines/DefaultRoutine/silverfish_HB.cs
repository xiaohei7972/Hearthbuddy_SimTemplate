using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using Buddy.Coroutines;
using Triton.Bot;
using Triton.Common;
using Triton.Game;
using Triton.Game.Mapping;

namespace HREngine.Bots
{
    public class Silverfish
    {
        public string versionnumber = "2021.09.13";
        private bool singleLog = false;
        private string botbehave = "noname";
        private bool needSleep = false;

        public Playfield lastpf;
        private Settings sttngs = Settings.Instance;

        private List<Minion> ownMinions = new List<Minion>();
        private List<Minion> enemyMinions = new List<Minion>();
        private List<Handmanager.Handcard> handCards = new List<Handmanager.Handcard>();
        private List<string> ownSecretList = new List<string>();
        private Dictionary<int, TAG_CLASS> enemySecretList = new Dictionary<int, TAG_CLASS>();
        private Dictionary<int, IDEnumOwner> LurkersDB = new Dictionary<int, IDEnumOwner>();
        public Dictionary<string, Behavior> BehaviorDB = new Dictionary<string, Behavior>();
        public Dictionary<string, string> BehaviorPath = new Dictionary<string, string>();
        Dictionary<CardDB.cardIDEnum, int> startDeck = new Dictionary<CardDB.cardIDEnum, int>();
        Dictionary<CardDB.cardIDEnum, int> tmpDeck = new Dictionary<CardDB.cardIDEnum, int>();
        Dictionary<CardDB.cardIDEnum, int> turnDeck = new Dictionary<CardDB.cardIDEnum, int>();
        List<GraveYardItem> graveYard = new List<GraveYardItem>();
        private delegate List<HSCard> getAllCardsDele();
        static getAllCardsDele getAllCards;

        int ownController = 1;
        int enemyController = 2;
        private int currentMana = 0;
        private int ownMaxMana = 0;
        private int numOptionPlayedThisTurn = 0;
        private int numMinionsPlayedThisTurn = 0;
        private int cardsPlayedThisTurn = 0;
        private int ueberladung = 0;//过载
        private int lockedMana = 0;//锁上

        private int enemyMaxMana = 0;

        private string heroname = "";
        private string enemyHeroname = "";

        private CardDB.Card heroAbility = new CardDB.Card();
        private int ownHeroPowerCost = 2;//?
        private bool ownAbilityisReady = false;
        private CardDB.Card enemyAbility = new CardDB.Card();
        private int enemyHeroPowerCost = 2;

        private Weapon ownWeapon;
        private Weapon enemyWeapon;

        private int anzcards = 0;//卡牌数量
        private int enemyAnzCards = 0;

        private int ownHeroFatigue = 0;//疲劳
        private int enemyHeroFatigue = 0;
        private int ownDecksize = 0;//牌库数量
        private int enemyDecksize = 0;

        private Minion ownHero;
        private Minion enemyHero;

        private int gTurn = 0;
        private int gTurnStep = 0;
        private int anzOgOwnCThunHpBonus = 0;//克苏恩血量
        private int anzOgOwnCThunAngrBonus = 0;//克苏恩攻击
        private int anzOgOwnCThunTaunt = 0;//克苏恩嘲讽

        private static Silverfish instance;

        public static Silverfish Instance
        {
            get { return instance ?? (instance = new Silverfish()); }
        }

        private Silverfish()
        {
            //设置文件路径
            this.singleLog = Settings.Instance.writeToSingleFile;
            Helpfunctions.Instance.ErrorLog("开始启动...");
            string p = "." + System.IO.Path.DirectorySeparatorChar + "Routines" + System.IO.Path.DirectorySeparatorChar + "DefaultRoutine" +
                       System.IO.Path.DirectorySeparatorChar + "Silverfish" + System.IO.Path.DirectorySeparatorChar;
            string path = p + "UltimateLogs" + Path.DirectorySeparatorChar;
            Directory.CreateDirectory(path);
            sttngs.setFilePath(p + "Data" + Path.DirectorySeparatorChar);

            if (!singleLog)
            {
                sttngs.setLoggPath(path);
            }
            else
            {
                sttngs.setLoggPath(p);
                sttngs.setLoggFile("UILogg.txt");
                Helpfunctions.Instance.createNewLoggfile();
            }
            setBehavior();
            getAllCards = Extensions.GetAllCards;
        }

        /// <summary>
        /// 设置行为
        /// </summary>
        /// <returns></returns>
        private bool setBehavior()
        {
            Type[] types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.BaseType == typeof(Behavior)).ToArray();
            foreach (var t in types)
            {
                string s = t.Name;
                if (s == "BehaviorMana") continue;
                if (s.Length > 8 && s.Substring(0, 8) == "Behavior")
                {
                    Behavior b = (Behavior)Activator.CreateInstance(t);
                    BehaviorDB.Add(b.BehaviorName(), b);
                }
            }

            string p = Path.Combine("Routines", "DefaultRoutine", "Silverfish", "behavior");//路径
            string[] files = Directory.GetFiles(p, "Behavior*.cs", SearchOption.AllDirectories);//获取文件
            int bCount = 0;
            foreach (string file in files)
            {
                bCount++;
                string bPath = Path.GetDirectoryName(file);//获取文件夹名字
                var fullPath = Path.GetFullPath(file);//获取完整路径
                var bNane = Path.GetFileNameWithoutExtension(file).Remove(0, 8);//获取除了Behavior之后的名字
                if (BehaviorDB.ContainsKey(bNane))
                {
                    if (!BehaviorPath.ContainsKey(bNane)) BehaviorPath.Add(bNane, bPath);//加入db
                }
            }

            if (BehaviorDB.Count != BehaviorPath.Count || BehaviorDB.Count != bCount)
            {
                Helpfunctions.Instance.ErrorLog("Behavior: 登记过 - " + BehaviorDB.Count + ", 文件夹 - " + bCount + ", 有路径 - "
                    + BehaviorPath.Count + ". 这些值应该相同. 或许你有其他文件在  'custom_behavior' 文件夹.");
            }

            if (BehaviorDB.ContainsKey("丨通用丨不设惩罚"))
            {//必须
                Ai.Instance.botBase = BehaviorDB["丨通用丨不设惩罚"];
                return true;
            }
            else
            {
                Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                Helpfunctions.Instance.ErrorLog("没有找到战场策略!");
                Helpfunctions.Instance.ErrorLog("请把战场策略放到指定的文件中.");
                Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                return false;
            }
        }
        public Behavior getBehaviorByName(string bName)
        {
            if (BehaviorDB.ContainsKey(bName))
            {
                sttngs.setSettings(bName);
                ComboBreaker.Instance.readCombos(bName);
                RulesEngine.Instance.readRules(bName);
                return BehaviorDB[bName];
            }
            else
            {
                if (BehaviorDB.ContainsKey("控场模式")) return BehaviorDB["控场模式"];//默认控场模式
                else
                {
                    Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                    Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                    Helpfunctions.Instance.ErrorLog("没有找到战场策略!");
                    Helpfunctions.Instance.ErrorLog("请把战场策略放到指定的文件中.");
                    Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                    Helpfunctions.Instance.ErrorLog("ERROR#################################################");
                }
            }
            return null;
        }


        public void setnewLoggFile()
        {
            gTurn = 0;
            gTurnStep = 0;
            anzOgOwnCThunHpBonus = 0;
            anzOgOwnCThunAngrBonus = 0;
            anzOgOwnCThunTaunt = 0;
            Questmanager.Instance.Reset();
            if (!singleLog)
            {
                sttngs.setLoggFile("UILogg" + DateTime.Now.ToString("_yyyy-MM-dd_HH-mm-ss") + ".txt");
                Helpfunctions.Instance.createNewLoggfile();
                Helpfunctions.Instance.ErrorLog("#######################################################");
                Helpfunctions.Instance.ErrorLog("对局日志保持在: " + sttngs.logpath + sttngs.logfile);
                Helpfunctions.Instance.ErrorLog("#######################################################");
            }
            else
            {
                sttngs.setLoggFile("UILogg.txt");
            }
        }

        internal void updateStartDeck()
        {
            //读取信息加入卡组
            startDeck.Clear();
            long DeckId = Triton.Bot.Logic.Bots.DefaultBot.DefaultBotSettings.Instance.LastDeckId;
            foreach (var deck in Triton.Bot.Settings.MainSettings.Instance.CustomDecks)
            {
                if (deck.DeckId == DeckId)
                {
                    foreach (string s in deck.CardIds)
                    {
                        var id = CardDB.Instance.cardIdstringToEnum(s);
                        if (startDeck.ContainsKey(id)) startDeck[id]++;
                        else startDeck.Add(id, 1);
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// 更新所有信息
        /// </summary>
        /// <param name="botbase"></param>
        /// <param name="numcal"></param>
        /// <param name="sleepRetry"></param>
        /// <returns></returns>
        public bool updateEverything(Behavior botbase, int numcal, out bool sleepRetry)
        {
            this.needSleep = false;
            this.updateBehaveString(botbase);

            Hrtprozis.Instance.clearAllRecalc();
            Handmanager.Instance.clearAllRecalc();

            updateRealTimeInfo();//获取实时场面信息 

            Hrtprozis.Instance.updateTurnDeck(turnDeck);//对局信息更新卡组
            Hrtprozis.Instance.setOwnPlayer(ownController);//对局信息设置我方玩家                
            Handmanager.Instance.setOwnPlayer(ownController);//手牌管理 设置我方玩家

            this.numOptionPlayedThisTurn = 0;//本回合选项数量
            this.numOptionPlayedThisTurn += this.cardsPlayedThisTurn + this.ownHero.numAttacksThisTurn;//打出的卡片数量+攻击数量
            foreach (Minion m in this.ownMinions)
            {
                if (m.Hp >= 1) this.numOptionPlayedThisTurn += m.numAttacksThisTurn;//随从血量大于1 
            }

            Hrtprozis.Instance.updatePlayer(this.ownMaxMana, this.currentMana, this.cardsPlayedThisTurn,
                this.numMinionsPlayedThisTurn, this.numOptionPlayedThisTurn, this.ueberladung, this.lockedMana, TritonHs.OurHero.EntityId,
                TritonHs.EnemyHero.EntityId);//更新玩家
            Hrtprozis.Instance.updateSecretStuff(this.ownSecretList, this.enemySecretList.Count);//更新奥秘

            Hrtprozis.Instance.updateHero(this.ownWeapon, this.heroname, this.heroAbility, this.ownAbilityisReady, this.ownHeroPowerCost, this.ownHero);//更新我方英雄
            Hrtprozis.Instance.updateHero(this.enemyWeapon, this.enemyHeroname, this.enemyAbility, false, this.enemyHeroPowerCost, this.enemyHero, this.enemyMaxMana);//更新敌方英雄

            Questmanager.Instance.updatePlayedMobs(this.gTurnStep);//任务管理
            Hrtprozis.Instance.updateMinions(this.ownMinions, this.enemyMinions);//更新随从
            Hrtprozis.Instance.updateLurkersDB(this.LurkersDB);//潜伏者?
            Handmanager.Instance.setHandcards(this.handCards, this.anzcards, this.enemyAnzCards);//手牌
            Hrtprozis.Instance.updateFatigueStats(this.ownDecksize, this.ownHeroFatigue, this.enemyDecksize, this.enemyHeroFatigue);//疲劳
            Hrtprozis.Instance.updateJadeGolemsInfo(GameState.Get().GetFriendlySidePlayer().GetTag(GAME_TAG.JADE_GOLEM), GameState.Get().GetOpposingSidePlayer().GetTag(GAME_TAG.JADE_GOLEM));//青玉

            Hrtprozis.Instance.updateTurnInfo(this.gTurn, this.gTurnStep);//回合
            updateCThunInfobyCThun();//克苏恩
            Hrtprozis.Instance.updateCThunInfo(this.anzOgOwnCThunAngrBonus, this.anzOgOwnCThunHpBonus, this.anzOgOwnCThunTaunt);
            Probabilitymaker.Instance.setEnemySecretGuesses(this.enemySecretList);//猜测对手奥秘

            bool isTurnStart = false;
            if (Ai.Instance.nextMoveGuess.mana == -100)
            {
                isTurnStart = true;
                Ai.Instance.updateTwoTurnSim();
            }
            Probabilitymaker.Instance.setGraveYard(graveYard, isTurnStart);

            List<HSCard> list = TritonHs.GetCards(CardZone.Graveyard, true);//本回合选项数量增加
            foreach (GraveYardItem gi in Probabilitymaker.Instance.turngraveyard)//墓地
            {
                if (gi.own)
                {
                    foreach (HSCard entiti in list)
                    {
                        if (gi.entityId == entiti.EntityId)
                        {
                            this.numOptionPlayedThisTurn += entiti.NumAttackThisTurn;
                            break;
                        }
                    }
                }
            }

            sleepRetry = this.needSleep;
            if (sleepRetry && numcal == 0) return false;

            //不设置游戏规则
            if (!Hrtprozis.Instance.setGameRule)
            {
                RulesEngine.Instance.setCardIdRulesGame(this.ownHero.cardClass, this.enemyHero.cardClass);
                Hrtprozis.Instance.setGameRule = true;
            }

            Playfield p = new Playfield();
            p.enemyCardsOut = new Dictionary<CardDB.cardIDEnum, int>(Probabilitymaker.Instance.enemyGraveyard);//敌方出牌

            if (lastpf != null)
            {
                if (lastpf.isEqualf(p))
                {
                    return false;
                }
                else
                {
                    if (p.gTurnStep > 0 && Ai.Instance.nextMoveGuess.ownMinions.Count == p.ownMinions.Count)
                    {
                        if (Ai.Instance.nextMoveGuess.ownHero.Ready != p.ownHero.Ready && !p.ownHero.Ready)
                        {
                            sleepRetry = true;
                            Helpfunctions.Instance.ErrorLog("[AI] 英雄的准备状态 = " + p.ownHero.Ready + ". 再次尝试....");
                            Ai.Instance.nextMoveGuess = new Playfield { mana = -100 };
                            return false;
                        }
                        for (int i = 0; i < p.ownMinions.Count; i++)
                        {
                            if (Ai.Instance.nextMoveGuess.ownMinions[i].Ready != p.ownMinions[i].Ready && !p.ownMinions[i].Ready)
                            {
                                sleepRetry = true;
                                Helpfunctions.Instance.ErrorLog("[AI] 随从的准备状态 = " + p.ownMinions[i].Ready + " (" + p.ownMinions[i].entitiyID + " " + p.ownMinions[i].handcard.card.cardIDenum + " " + p.ownMinions[i].name + "). 再次尝试....");
                                Ai.Instance.nextMoveGuess = new Playfield { mana = -100 };
                                return false;
                            }
                        }
                    }
                }

                Probabilitymaker.Instance.updateSecretList(p, lastpf);
                lastpf = p;//存储上一次场面信息
            }
            else
            {
                lastpf = p;
            }

            printUtils.printNowVal();

            Helpfunctions.Instance.ErrorLog("AI计算中，请稍候... " + DateTime.Now.ToString("HH:mm:ss.ffff"));


            using (TritonHs.Memory.ReleaseFrame(true))
            {
                printstuff();  //打印牌面细节到logg
                Ai.Instance.dosomethingclever(botbase);    //核心Ai计算
            }

            Helpfunctions.Instance.ErrorLog("计算完成! " + DateTime.Now.ToString("HH:mm:ss.ffff"));
            if (sttngs.printRules > 0)
            {
                String[] rulesStr = Ai.Instance.bestplay.rulesUsed.Split('@');
                if (rulesStr.Count() > 0 && rulesStr[0] != "")
                {
                    Helpfunctions.Instance.ErrorLog("规则权重 " + Ai.Instance.bestplay.ruleWeight * -1);
                    foreach (string rs in rulesStr)
                    {
                        if (rs == "") continue;
                        Helpfunctions.Instance.ErrorLog("规则: " + rs);
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 实时更新游戏数据
        /// </summary>
        private void updateRealTimeInfo()
        {
            List<HSCard> allcards = getAllCards();

            //turn
            int currTurn = TritonHs.GameState.GetTurn();
            if (gTurn == currTurn)
                gTurnStep++;
            else
                gTurnStep = 0;
            gTurn = currTurn;
            //hero
            this.ownController = TritonHs.OurHero.ControllerId;
            this.enemyController = TritonHs.EnemyHero.ControllerId;
            this.ownHero = new Minion();
            this.enemyHero = new Minion();
            this.currentMana = TritonHs.CurrentMana;
            this.ownMaxMana = TritonHs.Resources;
            // 后手
            if (gTurn % 2 == 0)
            {
                this.enemyMaxMana = ownMaxMana;
            }
            else
            {
                this.enemyMaxMana = ownMaxMana - 1;
            }
            //deck
            this.ownDecksize = 0;
            this.enemyDecksize = 0;
            this.turnDeck = new Dictionary<CardDB.cardIDEnum, int>();
            this.tmpDeck = new Dictionary<CardDB.cardIDEnum, int>(startDeck);
            this.graveYard.Clear();
            //secret
            ownSecretList.Clear();
            enemySecretList.Clear();
            //minion
            ownMinions.Clear();
            enemyMinions.Clear();
            LurkersDB.Clear();
            //hand
            handCards.Clear();
            anzcards = 0;
            enemyAnzCards = 0;

            // 初始化任务
            Questmanager.Instance.updateQuestStuff("None", 0, 1000, true);
            Questmanager.Instance.updateQuestStuff("None", 0, 1000, false);

            foreach (HSCard card in allcards)
            {
                //基础信息，不需要重复读取
                var rawCard = card.Card;
                if (rawCard == null)
                    continue;
                var entity = rawCard.GetEntity();
                var eid = entity.GetEntityId();
                string cardId = entity.GetCardId();
                if (string.IsNullOrEmpty(cardId))
                    cardId = entity.GetEntityDef().GetCardId();
                var zone = (TAG_ZONE)card.GetTag(GAME_TAG.ZONE);
                var controllerId = entity.GetControllerId();
                var cardType = entity.GetCardType();
                var rtCost = card.Cost;//real time cost
                updateDeck(card, entity, controllerId, cardId, eid, rtCost);
                //处理不同区域的entity
                switch (zone)
                {
                    case TAG_ZONE.PLAY:
                        {
                            if (cardType == Triton.Game.Mapping.TAG_CARDTYPE.HERO)//英雄职业
                            {
                                updateHero(card, entity, controllerId, eid, cardId);
                            }
                            else if (cardType == Triton.Game.Mapping.TAG_CARDTYPE.HERO_POWER)//英雄技能
                            {
                                updateHeroPower(card, controllerId, cardId, rtCost);
                            }
                            else if (card.IsMinion)//随从
                            {
                                updateMinion(card, entity, controllerId, cardId);
                            }
                            else if ((TAG_CARDTYPE)cardType == TAG_CARDTYPE.LOCATION)//地标
                            {
                                updateMinion(card, entity, controllerId, cardId);
                            }
                        }
                        break;
                    case TAG_ZONE.HAND:
                        {
                            updateHandcard(card, controllerId, cardId, eid, rtCost, entity);
                        }
                        break;
                    case TAG_ZONE.SECRET:
                        {
                            updateSecret(card, entity, controllerId, cardId, eid);
                        }
                        break;
                    case TAG_ZONE.GRAVEYARD:
                        {
                            updateGraveyard(card, entity, controllerId, cardId, eid);
                        }
                        break;
                    case TAG_ZONE.REMOVEDFROMGAME:
                    case TAG_ZONE.SETASIDE:
                    case TAG_ZONE.DECK:
                    default:
                        break;
                }
            }

            foreach (var c in tmpDeck)
            {
                if (c.Value < 1) continue;
                if (c.Key == CardDB.cardIDEnum.None) continue;
                if (turnDeck.ContainsKey(c.Key))
                    turnDeck[c.Key] += c.Value;
                else
                    turnDeck.Add(c.Key, c.Value);
            }

            numMinionsPlayedThisTurn = TritonHs.NumMinionsPlayedThisTurn;
            cardsPlayedThisTurn = TritonHs.NumCardsPlayedThisTurn;
            ueberladung = TritonHs.OverloadOwed;
            lockedMana = TritonHs.OverloadLocked;



            ownWeapon = new Weapon();
            if (TritonHs.DoWeHaveWeapon)//如果我们有武器
            {
                HSCard weapon = TritonHs.OurWeaponCard;

                ownWeapon.equip(CardDB.Instance.getCardDataFromID(CardDB.Instance.cardIdstringToEnum(weapon.Id)));
                ownWeapon.Angr = weapon.GetTag(GAME_TAG.ATK);
                ownWeapon.Durability = weapon.GetTag(GAME_TAG.DURABILITY) - weapon.GetTag(GAME_TAG.DAMAGE);
                ownWeapon.poisonous = (weapon.GetTag(GAME_TAG.POISONOUS) == 1) ? true : false;
                ownWeapon.lifesteal = (weapon.GetTag(GAME_TAG.LIFESTEAL) == 1) ? true : false;
                //武器法术迸发
                ownWeapon.Spellburst = (weapon.GetTag(GAME_TAG.SPELLBURST) == 1) ? true : false;
                // 武器计数器
                var scriptNum1 = weapon.GetTag(GAME_TAG.TAG_SCRIPT_DATA_NUM_1);
                ownWeapon.scriptNum1 = scriptNum1;
                Helpfunctions.Instance.ErrorLog("武器计数器" + scriptNum1);
                if (!this.ownHero.windfury) this.ownHero.windfury = ownWeapon.windfury;
            }

            enemyWeapon = new Weapon();
            if (TritonHs.DoesEnemyHasWeapon)//对手有武器
            {
                HSCard weapon = TritonHs.EnemyWeaponCard;

                enemyWeapon.equip(CardDB.Instance.getCardDataFromID(CardDB.Instance.cardIdstringToEnum(weapon.Id)));
                enemyWeapon.Angr = weapon.GetTag(GAME_TAG.ATK);
                enemyWeapon.Durability = weapon.GetTag(GAME_TAG.DURABILITY) - weapon.GetTag(GAME_TAG.DAMAGE);
                enemyWeapon.poisonous = (weapon.GetTag(GAME_TAG.POISONOUS) == 1) ? true : false;
                enemyWeapon.lifesteal = (weapon.GetTag(GAME_TAG.LIFESTEAL) == 1) ? true : false;
                enemyWeapon.Spellburst = (weapon.GetTag(GAME_TAG.SPELLBURST) == 1) ? true : false;
                ownWeapon.Spellburst = (weapon.GetTag(GAME_TAG.SPELLBURST) == 1) ? true : false;
                if (!this.enemyHero.windfury) this.enemyHero.windfury = enemyWeapon.windfury;
            }


        }

        private void updateGraveyard(HSCard card, Entity entity, int controller, string cardId, int eid)
        {
            var cardType = entity.GetCardType();
            if (cardType == Triton.Game.Mapping.TAG_CARDTYPE.ENCHANTMENT)//附魔牌不加入坟场数据库，是否合理？
                return;
            var idEnum = CardDB.Instance.cardIdstringToEnum(cardId);
            GraveYardItem gyi = new GraveYardItem(idEnum, eid, controller == ownController, GraveYardItem.EnumGraveyardStatus.Unknown);
            var prevZone = card.Card.GetPrevZone();
            if (prevZone != null)
            {
                var prevZoneName = prevZone.name;
                if (prevZoneName.Contains("Deck"))//牌库->坟场, 爆牌
                {
                    gyi.status = GraveYardItem.EnumGraveyardStatus.Burnt;
                }
                else if (prevZoneName.Contains("Play") || prevZoneName.Contains("Weapon") || prevZoneName.Contains("Secret"))//场面->坟场, 随从:死亡,武器任务奥秘:使用过
                {
                    if (cardType == Triton.Game.Mapping.TAG_CARDTYPE.MINION)
                    {
                        gyi.status = GraveYardItem.EnumGraveyardStatus.Died;
                    }
                    else
                    {
                        gyi.status = GraveYardItem.EnumGraveyardStatus.Used;
                    }
                }
                else if (prevZoneName.Contains("Hand"))//手牌->坟场，弃牌
                {
                    gyi.status = GraveYardItem.EnumGraveyardStatus.Discard;
                }
            }
            else
            {
                if (cardType == Triton.Game.Mapping.TAG_CARDTYPE.SPELL)//使用法术prevZone为空
                {
                    gyi.status = GraveYardItem.EnumGraveyardStatus.Used;
                }
            }
            graveYard.Add(gyi);
        }

        private void updateDeck(HSCard card, Entity entity, int controller, string cardId, int entityId, int rtCost)
        {

            if (controller == ownController)
                ownDecksize++;
            else
                enemyDecksize++;
            if (string.IsNullOrEmpty(cardId))
                return;
            var zone = card.GetZone();
            CardDB.cardIDEnum idEnum = CardDB.Instance.cardIdstringToEnum(cardId);

            if (ownController == 1 && entityId < 34 ||
                ownController == 2 && entityId >= 34 && entityId < 64) //4~33为player1初始卡组  34~63为player2初始卡组
            {
                if (zone != Triton.Game.Mapping.TAG_ZONE.DECK && tmpDeck.ContainsKey(idEnum))
                    tmpDeck[idEnum]--;
            }
            else if (entityId >= 64) //63之后是双方衍生卡
            {
                if (controller == ownController && zone == Triton.Game.Mapping.TAG_ZONE.DECK)
                {
                    if (turnDeck.ContainsKey(idEnum))
                        turnDeck[idEnum]++;
                    else turnDeck.Add(idEnum, 1);
                }
            }
        }

        private void updateSecret(HSCard card, Entity entity, int controller, string cardId, int entityId)
        {
            if (card.IsSecret)
            {
                if (controller == ownController)
                    ownSecretList.Add(cardId);
                else
                    enemySecretList.Add(entityId, (TAG_CLASS)card.Class);
            }
            else if (entity.IsQuest() || entity.GetTag(1725) > 0)
            {
                if (controller == ownController)
                {
                    int currentQuestProgress = entity.GetTag(GAME_TAG.QUEST_PROGRESS);
                    int questProgressTotal = entity.GetTag(GAME_TAG.QUEST_PROGRESS_TOTAL);
                    Questmanager.Instance.updateQuestStuff(cardId, currentQuestProgress, questProgressTotal, true);
                }
                else if (controller == enemyController)
                {
                    int currentQuestProgress = entity.GetTag(GAME_TAG.QUEST_PROGRESS);
                    int questProgressTotal = entity.GetTag(GAME_TAG.QUEST_PROGRESS_TOTAL);
                    Questmanager.Instance.updateQuestStuff(cardId, currentQuestProgress, questProgressTotal, false);
                }
            }
            // 支线任务
            else if (entity.GetTag(1192) > 0)
            {
                if (controller == ownController)
                {
                    int currentQuestProgress = entity.GetTag(GAME_TAG.QUEST_PROGRESS);
                    int questProgressTotal = entity.GetTag(GAME_TAG.QUEST_PROGRESS_TOTAL);
                    Questmanager.Instance.updateQuestStuff(cardId, currentQuestProgress, questProgressTotal, true, true);
                }
            }
        }

        private void updateHero(HSCard card, Entity entity, int controller, int entityId, string cardId)
        {
            if (controller == ownController)
            {
                this.ownHero.entitiyID = entityId;
                this.ownHero.own = true;
                this.ownHero.isHero = true;
                this.ownHero.Ready = card.CanBeUsed;
                this.ownHero.cardClass = (TAG_CLASS)card.Class;
                this.ownHeroFatigue = card.GetTag(GAME_TAG.FATIGUE);
                this.heroname = GameState.Get().GetFriendlySidePlayer().GetHero().GetClass().ToString().ToLower();
                this.ownHero.Angr = card.GetTag(GAME_TAG.ATK);
                this.ownHero.maxHp = card.GetTag(GAME_TAG.HEALTH);
                this.ownHero.Hp = this.ownHero.maxHp - card.GetTag(GAME_TAG.DAMAGE);
                this.ownHero.armor = card.GetTag(GAME_TAG.ARMOR);
                this.ownHero.frozen = card.GetTag(GAME_TAG.FROZEN) != 0;
                this.ownHero.stealth = card.GetTag(GAME_TAG.STEALTH) != 0;
                this.ownHero.numAttacksThisTurn = card.GetTag(GAME_TAG.NUM_ATTACKS_THIS_TURN);
                this.ownHero.windfury = card.GetTag(GAME_TAG.WINDFURY) != 0;
                this.ownHero.immune = card.GetTag(GAME_TAG.IMMUNE) != 0;
                if (!ownHero.immune) this.ownHero.immuneWhileAttacking = card.GetTag(GAME_TAG.IMMUNE_WHILE_ATTACKING) != 0;
                this.ownHero.handcard.card.Elusive = card.GetTag(GAME_TAG.ELUSIVE) != 0;
                this.ownHero.nameCN = CardDB.Instance.cardNameCNstringToEnum(card.Name);
            }
            else if (controller == enemyController)
            {
                this.enemyHero.entitiyID = entityId;
                this.enemyHero.own = false;
                this.enemyHero.isHero = true;
                this.enemyHero.Ready = false;
                this.enemyHero.cardClass = (TAG_CLASS)card.Class;
                this.enemyHeroFatigue = card.GetTag(GAME_TAG.FATIGUE);
                this.enemyHeroname = GameState.Get().GetOpposingSidePlayer().GetHero().GetClass().ToString().ToLower();
                this.enemyHero.Angr = card.GetTag(GAME_TAG.ATK);
                this.enemyHero.maxHp = card.GetTag(GAME_TAG.HEALTH);
                this.enemyHero.Hp = this.enemyHero.maxHp - card.GetTag(GAME_TAG.DAMAGE);
                this.enemyHero.armor = card.GetTag(GAME_TAG.ARMOR);
                this.enemyHero.frozen = card.GetTag(GAME_TAG.FROZEN) != 0;
                this.enemyHero.stealth = (card.GetTag(GAME_TAG.STEALTH) == 0) ? false : true;
                this.enemyHero.windfury = card.GetTag(GAME_TAG.WINDFURY) != 0;
                this.enemyHero.immune = card.GetTag(GAME_TAG.IMMUNE) != 0; //don't use turn immune
                this.enemyHero.handcard.card.Elusive = card.GetTag(GAME_TAG.ELUSIVE) != 0;
                this.enemyHero.nameCN = CardDB.Instance.cardNameCNstringToEnum(card.Name);
            }

            var attaches = entity.GetAttachments();//附魔
            if (attaches != null && attaches.Count > 0)
            {
                var enchs = new List<miniEnch>();
                foreach (var attEnt in attaches)
                {
                    var cid = attEnt.GetCardId();
                    if (string.IsNullOrEmpty(cid))
                    {
                        cid = attEnt.GetEntityDef().GetCardId();
                    }
                    var creator = attEnt.GetTag(GAME_TAG.CREATOR);
                    var cpyDeath = attEnt.GetTag(GAME_TAG.COPY_DEATHRATTLE);
                    var ctrlId = attEnt.GetTag(GAME_TAG.CONTROLLER);
                    enchs.Add(new miniEnch(CardDB.Instance.cardIdstringToEnum(cid), creator, ctrlId, cpyDeath, attEnt));
                }
                if (controller == ownController)
                {
                    this.ownHero.loadEnchantments(enchs, ownController);
                }
                else if (controller == enemyController)
                {
                    this.enemyHero.loadEnchantments(enchs, enemyController);
                }
            }
        }

        private void updateHeroPower(HSCard card, int controller, string cardId, int rtCost)
        {
            if (controller == ownController)
            {
                this.heroAbility = CardDB.Instance.getCardDataFromID(CardDB.Instance.cardIdstringToEnum(cardId));
                this.ownAbilityisReady = card.GetTag(GAME_TAG.EXHAUSTED) == 0 ? true : false;
                this.ownHeroPowerCost = rtCost;
            }
            else if (controller == enemyController)
            {
                this.enemyAbility = CardDB.Instance.getCardDataFromID(CardDB.Instance.cardIdstringToEnum(cardId));
                this.enemyHeroPowerCost = rtCost;
            }
        }

        private void updateMinion(HSCard card, Entity entity, int controller, string cardId)//随从效果
        {

            int zp = card.GetTag(GAME_TAG.ZONE_POSITION);

            if (zp >= 1)
            {
                CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.Instance.cardIdstringToEnum(card.Id));
                Minion m = new Minion();
                m.name = c.nameEN;
                m.nameCN = c.nameCN;
                m.handcard.card = c;

                m.Angr = card.GetTag(GAME_TAG.ATK);
                m.maxHp = card.GetTag(GAME_TAG.HEALTH);
                m.Hp = m.maxHp - card.GetTag(GAME_TAG.DAMAGE);
                if (m.Hp <= 0)
                    return;
                m.wounded = m.maxHp > m.Hp;

                m.own = controller == ownController;

                m.exhausted = (card.GetTag(GAME_TAG.EXHAUSTED) == 0) ? false : true;//枯竭的

                m.taunt = (card.GetTag(GAME_TAG.TAUNT) == 0) ? false : true;//嘲讽

                m.numAttacksThisTurn = card.GetTag(GAME_TAG.NUM_ATTACKS_THIS_TURN);//数字攻击当回合

                int temp = card.GetTag(GAME_TAG.NUM_TURNS_IN_PLAY);
                m.playedThisTurn = (temp == 0) ? true : false;

                m.Spellburst = card.GetTag(GAME_TAG.SPELLBURST) != 0;//法力迸发

                m.windfury = (card.GetTag(GAME_TAG.WINDFURY) == 0) ? false : true;//风怒

                m.frozen = (card.GetTag(GAME_TAG.FROZEN) == 0) ? false : true;//冰冻

                m.divineshild = (card.GetTag(GAME_TAG.DIVINE_SHIELD) == 0) ? false : true;//圣盾

                m.stealth = (card.GetTag(GAME_TAG.STEALTH) == 0) ? false : true;//潜行

                m.poisonous = (card.GetTag(GAME_TAG.POISONOUS) == 0) ? false : true;//剧毒

                m.lifesteal = (card.GetTag(GAME_TAG.LIFESTEAL) == 0) ? false : true;//吸血

                m.immune = (card.GetTag(GAME_TAG.IMMUNE) == 0) ? false : true;//免疫
                if (!m.immune) m.immune = (card.GetTag(GAME_TAG.IMMUNE_WHILE_ATTACKING) == 0) ? false : true;

                m.untouchable = (card.GetTag(GAME_TAG.UNTOUCHABLE) == 0) ? false : true;//无法选择

                m.silenced = (card.GetTag(GAME_TAG.SILENCED) == 0) ? false : true;//沉默的

                m.cantAttackHeroes = (card.GetTag(GAME_TAG.CANNOT_ATTACK_HEROES) == 0) ? false : true;//无法攻击英雄

                m.cantAttack = (card.GetTag(GAME_TAG.CANT_ATTACK) == 0) ? false : true;//无法攻击

                // m.cantBeTargetedBySpellsOrHeroPowers = (card.GetTag(GAME_TAG.CANT_BE_TARGETED_BY_HERO_POWERS) == 0) ? false : true;//无法被法术和英雄技能选中
                m.Elusive = (card.GetTag(GAME_TAG.ELUSIVE) == 0) ? false : true;//扰魔

                m.charge = card.HasCharge ? 1 : 0;//冲锋

                m.rush = card.HasRush ? 1 : 0;//突袭

                m.zonepos = zp;//棋盘上的位置

                m.entitiyID = card.EntityId;//实体id

                m.hChoice = card.GetTag(GAME_TAG.HIDDEN_CHOICE);

                var attaches = entity.GetAttachments();//附魔
                if (attaches != null && attaches.Count > 0)
                {
                    var enchs = new List<miniEnch>();
                    foreach (var attEnt in attaches)
                    {
                        var cid = attEnt.GetCardId();
                        if (string.IsNullOrEmpty(cid))
                        {
                            cid = attEnt.GetEntityDef().GetCardId();
                        }
                        var creator = attEnt.GetTag(GAME_TAG.CREATOR);
                        var cpyDeath = attEnt.GetTag(GAME_TAG.COPY_DEATHRATTLE);
                        var ctrlId = attEnt.GetTag(GAME_TAG.CONTROLLER);
                        enchs.Add(new miniEnch(CardDB.Instance.cardIdstringToEnum(cid), creator, ctrlId, cpyDeath, attEnt));
                    }
                    m.loadEnchantments(enchs, m.own ? ownController : enemyController);
                }

                m.dormant = card.GetTag(GAME_TAG.DORMANT);//休眠
                m.untouchable = m.untouchable || m.dormant > 0;

                m.Ready = card.CanBeUsed;
                if (m.rush > 0 && !m.untouchable && m.charge == 0 && (m.numAttacksThisTurn == 0 || (m.numAttacksThisTurn == 1 && m.windfury)))
                {
                    m.Ready = true;
                    if (m.playedThisTurn) m.cantAttackHeroes = true;
                    else m.cantAttackHeroes = false;

                }

                m.handcard.card.TAG_SCRIPT_DATA_NUM_1 = c.TAG_SCRIPT_DATA_NUM_1;//标签脚本数据编号1，用于记录伤害、召唤数量、衍生物攻击力、衍生物血量、注能数量、法力渴求
                m.handcard.card.TAG_SCRIPT_DATA_NUM_2 = c.TAG_SCRIPT_DATA_NUM_2;//标签脚本数据编号2，用于记录伤害、召唤数量、衍生物攻击力、衍生物血量、注能数量、法力渴求
                m.handcard.card.TAG_SCRIPT_DATA_NUM_3 = c.TAG_SCRIPT_DATA_NUM_3;//标签脚本数据编号3，用于记录伤害、召唤数量、衍生物攻击力、衍生物血量、注能数量、法力渴求
                m.handcard.card.TAG_SCRIPT_DATA_NUM_4 = c.TAG_SCRIPT_DATA_NUM_4;//标签脚本数据编号4，用于记录伤害、召唤数量、衍生物攻击力、衍生物血量、注能数量、法力渴求

                m.handcard.card.DECK_ACTION_COST = c.DECK_ACTION_COST;//卡组操作消耗法力值

                m.handcard.card.Dredge = c.Dredge;//探底
                m.CooldownTurn = c.CooldownTurn;//地标冷却回合
                m.handcard.card.Infuse = c.Infuse;//注能
                m.handcard.card.Infused = c.Infused;//已注能
                m.handcard.card.InfuseNum = c.InfuseNum;//注能数量
                m.handcard.card.Manathirst = c.Manathirst;//法力渴求
                m.handcard.card.Finale = c.Finale;//压轴
                m.handcard.card.Overheal = c.Overheal;//过量治疗
                m.handcard.card.Titan = c.Titan;//泰坦
                m.handcard.card.TitanAbilityUsed1 = c.TitanAbilityUsed1;//泰坦第一技能
                m.handcard.card.TitanAbilityUsed2 = c.TitanAbilityUsed2;//泰坦第二技能
                m.handcard.card.TitanAbilityUsed3 = c.TitanAbilityUsed3;//泰坦第三技能
                m.handcard.card.TitanAbility = c.TitanAbility;//泰坦技能列表
                m.handcard.card.Forge = c.Forge;//锻造
                m.handcard.card.ForgeCost = c.ForgeCost;//锻造消耗法力值
                m.handcard.card.Forged = c.Forged;//已锻造
                m.handcard.card.Quickdraw = c.Quickdraw;//快枪
                m.handcard.card.Excavate = c.Excavate;//发掘
                m.handcard.card.Elusive = c.Elusive;//扰魔

                if (m.charge > 0 && m.playedThisTurn && !m.Ready && m.numAttacksThisTurn == 0)
                {
                    needSleep = true;
                    Helpfunctions.Instance.ErrorLog("[AI] 冲锋的随从还没有准备好");
                }

                if (controller == ownController)
                {
                    m.synergy = PenalityManager.Instance.getClassRacePriorityPenality(this.ownHero.cardClass, (TAG_RACE)c.race);
                    this.ownMinions.Add(m);
                }
                else
                {
                    m.synergy = PenalityManager.Instance.getClassRacePriorityPenality(this.enemyHero.cardClass, (TAG_RACE)c.race);
                    this.enemyMinions.Add(m);
                }
            }
        }

        /// <summary>
        /// 更新手牌/附魔
        /// </summary>
        /// <param name="card"></param>
        /// <param name="controller"></param>
        /// <param name="cardId"></param>
        /// <param name="entityId"></param>
        /// <param name="cost"></param>
        /// <param name="entity"></param>
        private void updateHandcard(HSCard card, int controller, string cardId, int entityId, int cost, Entity entity)
        {
            var zp = card.ZonePosition;
            if (zp >= 1)
            {
                if (controller == ownController)
                {
                    CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.Instance.cardIdstringToEnum(cardId));

                    var scriptNum1 = card.GetTag(GAME_TAG.TAG_SCRIPT_DATA_NUM_1);
                    Handmanager.Handcard hc = new Handmanager.Handcard();
                    hc.card = c;
                    hc.position = zp;
                    hc.entity = entityId;
                    hc.manacost = cost;
                    hc.poweredUp = card.GetTag(GAME_TAG.POWERED_UP);
                    hc.darkmoon_num = scriptNum1; //得到暗月先知抽牌数
                    hc.SCRIPT_DATA_NUM_1 = scriptNum1;

                    hc.addattack = card.Attack - card.DefATK;
                    if (card.IsWeapon) hc.addHp = card.Durability - card.DefDurability;
                    else hc.addHp = card.Health - card.DefHealth;
                    if (c.cardIDenum == CardDB.cardIDEnum.DAL_007 ||
                        c.cardIDenum == CardDB.cardIDEnum.DAL_008 ||
                        c.cardIDenum == CardDB.cardIDEnum.DAL_009 ||
                        c.cardIDenum == CardDB.cardIDEnum.DAL_010 ||
                        c.cardIDenum == CardDB.cardIDEnum.DAL_011)
                        hc.scheme = scriptNum1;
                    var attaches = entity.GetAttachments();//附魔
                    if (attaches != null && attaches.Count > 0)
                    {
                        hc.enchs = new List<CardDB.cardIDEnum>();
                        foreach (var attEnt in attaches)
                        {
                            var cid = attEnt.GetCardId();
                            if (string.IsNullOrEmpty(cid))
                            {
                                cid = attEnt.GetEntityDef().GetCardId();
                            }
                            hc.enchs.Add(CardDB.Instance.cardIdstringToEnum(cid));
                        }
                    }
                    if (hc.card.nameCN == CardDB.cardNameCN.大型魔像 || hc.card.nameCN == CardDB.cardNameCN.小型魔像 || hc.card.nameCN == CardDB.cardNameCN.超级魔像)
                    {
                        int ench1 = entity.GetTag(GAME_TAG.MODULAR_ENTITY_PART_1);
                        int ench2 = entity.GetTag(GAME_TAG.MODULAR_ENTITY_PART_2);
                        CardDB.Card card1 = CardDB.Instance.getCardDataFromDbfID("" + ench1);
                        CardDB.Card card2 = CardDB.Instance.getCardDataFromDbfID("" + ench2);
                        hc.enchs.Add(card1.cardIDenum);
                        hc.enchs.Add(card2.cardIDenum);
                    }
                    handCards.Add(hc);
                    anzcards++;
                }
                else
                {
                    enemyAnzCards++;
                }
            }
        }

        private void updateBehaveString(Behavior botbase)
        {
            this.botbehave = botbase.BehaviorName();
            this.botbehave += " " + Ai.Instance.maxwide + " maxCal " + Ai.Instance.maxCal + " maxWide " + Ai.Instance.maxwide;
            this.botbehave += " face " + ComboBreaker.Instance.attackFaceHP;
            if (Settings.Instance.berserkIfCanFinishNextTour > 0) this.botbehave += " berserk:" + Settings.Instance.berserkIfCanFinishNextTour;
            if (Settings.Instance.weaponOnlyAttackMobsUntilEnfacehp > 0) this.botbehave += " womob:" + Settings.Instance.weaponOnlyAttackMobsUntilEnfacehp;
            if (Settings.Instance.secondTurnAmount > 0)
            {
                if (Ai.Instance.nextMoveGuess.mana == -100)
                {
                    Ai.Instance.updateTwoTurnSim();
                }
                this.botbehave += " twoturnsim " + Settings.Instance.secondTurnAmount + " ntss " +
                                  Settings.Instance.nextTurnDeep + " " + Settings.Instance.nextTurnMaxWide + " " +
                                  Settings.Instance.nextTurnTotalBoards;
            }

            if (Settings.Instance.playaround)
            {
                this.botbehave += " playaround";
                this.botbehave += " " + Settings.Instance.playaroundprob + " " + Settings.Instance.playaroundprob2;
            }

            this.botbehave += " ets " + Settings.Instance.enemyTurnMaxWide;

            if (Settings.Instance.twotsamount > 0)
            {
                this.botbehave += " ets2 " + Settings.Instance.enemyTurnMaxWideSecondStep;
            }

            if (Settings.Instance.useSecretsPlayAround)
            {
                this.botbehave += " secret";
            }

            if (Settings.Instance.secondweight != 0.5f)
            {
                this.botbehave += " weight " + (int)(Settings.Instance.secondweight * 100f);
            }

            if (Settings.Instance.placement != 0)
            {
                this.botbehave += " plcmnt:" + Settings.Instance.placement;
            }

            this.botbehave += " aA " + Settings.Instance.adjustActions;
            if (Settings.Instance.concedeMode != 0) this.botbehave += " cede:" + Settings.Instance.concedeMode;

        }

        public void updateCThunInfo(int OgOwnCThunAngrBonus, int OgOwnCThunHpBonus, int OgOwnCThunTaunt)
        {
            this.anzOgOwnCThunAngrBonus = OgOwnCThunAngrBonus;
            this.anzOgOwnCThunHpBonus = OgOwnCThunHpBonus;
            this.anzOgOwnCThunTaunt = OgOwnCThunTaunt;
            Hrtprozis.Instance.updateCThunInfo(this.anzOgOwnCThunAngrBonus, this.anzOgOwnCThunHpBonus, this.anzOgOwnCThunTaunt);
        }

        public void updateCThunInfobyCThun()
        {
            bool found = false;
            foreach (Handmanager.Handcard hc in this.handCards)
            {
                if (hc.card.nameEN == CardDB.cardNameEN.cthun)
                {
                    this.anzOgOwnCThunAngrBonus = hc.addattack;
                    this.anzOgOwnCThunHpBonus = hc.addHp;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                foreach (Minion m in this.ownMinions)
                {
                    if (m.name == CardDB.cardNameEN.cthun)
                    {
                        if (this.anzOgOwnCThunAngrBonus < m.Angr - 6) this.anzOgOwnCThunAngrBonus = m.Angr - 6;
                        if (this.anzOgOwnCThunHpBonus < m.Hp - 6) this.anzOgOwnCThunHpBonus = m.Angr - 6;
                        if (m.taunt && this.anzOgOwnCThunTaunt < 1) this.anzOgOwnCThunTaunt++;
                        found = true;
                        break;
                    }
                }
            }
        }

        //public static int getLastAffected(int entityid)
        //{

        //    List<HSCard> allEntitys = getAllCards();

        //    foreach (HSCard ent in allEntitys)
        //    {
        //        if (ent.GetTag(GAME_TAG.LAST_AFFECTED_BY) == entityid) return ent.GetTag(GAME_TAG.ENTITY_ID);
        //    }

        //    return 0;
        //}

        //public static int getCardTarget(int entityid)
        //{

        //    List<HSCard> allEntitys = getAllCards();

        //    foreach (HSCard ent in allEntitys)
        //    {
        //        if (ent.GetTag(GAME_TAG.ENTITY_ID) == entityid) return ent.GetTag(GAME_TAG.CARD_TARGET);
        //    }

        //    return 0;

        //}


        private void printstuff()  //会输出到文件夹UltimateLogs里面
        {
            Playfield p = this.lastpf;
            string dtimes = DateTime.Now.ToString("HH:mm:ss:ffff");
            // 记录对局信息
            printUtils.printRecord = true;
            printUtils.recordRounds = string.Format("{0}法力水晶 第{1}回合 第{2}步操作.txt", p.ownMaxMana, gTurn, gTurnStep);
            string enemysecretIds = "";
            enemysecretIds = Probabilitymaker.Instance.getEnemySecretData();
            Helpfunctions.Instance.logg("#######################################################################");
            Helpfunctions.Instance.logg("#######################################################################");
            Helpfunctions.Instance.logg("开始计算, 已花费时间: " + DateTime.Now.ToString("HH:mm:ss") + " V" +
                                        this.versionnumber + " " + this.botbehave);
            if (!Helpfunctions.Instance.writelogg) return;
            // 输出当前场面价值判定
            string normalInfo = "";
            String enemyVal = "[敌方场面] ";
            String myVal = "[我方场面] ";
            String handCard = "[我方手牌] ";
            String enemyGuessHandCard = "[敌方剩余卡牌预测] ";

            normalInfo += "水晶： " + p.mana + " / " + p.ownMaxMana
    + " [我方英雄] " + p.ownHeroName + " （生命: " + p.ownHero.Hp + " + " + p.ownHero.armor
    + (p.ownWeapon != null ? " 武器: " + p.ownWeapon.card.nameCN + " ( " + p.ownWeapon.Angr + " / " + p.ownWeapon.Durability + " ) " : "")
    + (p.ownSecretsIDList.Count > 0 ? " 奥秘数: " + p.ownSecretsIDList.Count : "") + ") "
    + "[敌方英雄] " + p.enemyHeroName + " （生命: " + p.enemyHero.Hp + " + " + p.enemyHero.armor
    + (p.enemyWeapon != null ? " 武器: " + p.enemyWeapon.card.nameCN + " ( " + p.enemyWeapon.Angr + " / " + p.enemyWeapon.Durability + " ) " : "")
    + (p.enemySecretCount > 0 ? " 奥秘数: " + p.enemySecretCount : "") + (p.enemyHero.immune ? " 免疫" : "") + ") ";
            foreach (Minion m in p.enemyMinions)
            {
                enemyVal += m.handcard.card.nameCN + " ( " + m.Angr + " / " + m.Hp + " )" + (m.frozen ? "[冻结]" : "") + (m.cantAttack ? "[无法攻击]" : "") + (m.windfury ? "[风怒]" : "") + (m.taunt ? "[嘲讽]" : "");
                enemyVal += (m.Elusive ? "[扰魔]" : "");
            }
            foreach (Minion m in p.ownMinions)
            {
                myVal += m.handcard.card.nameCN + " ( " + m.Angr + " / " + m.Hp + " )" + (m.frozen ? "[冻结]" : "") + (!m.Ready || m.cantAttack ? "[无法攻击]" : "") + (m.windfury ? "[风怒]" : "") + (m.taunt ? "[嘲讽]" : "");
                myVal += (m.Elusive ? "[扰魔]" : "");
                // myVal += (m.handcard.card.Titan ? ("[泰坦]"+ m.handcard.card.TitanAbilityUsed1.ToString()+ m.handcard.card.TitanAbilityUsed2.ToString()+ m.handcard.card.TitanAbilityUsed3.ToString()) :"[不是泰坦]");
            }
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                handCard += hc.card.nameCN + "(费用： " + hc.manacost + " ； " + (hc.addattack + hc.card.Attack) + " / " + (hc.addHp + hc.card.Health) + " ) ";
            }
            foreach (var item in Hrtprozis.Instance.guessEnemyDeck)
            {
                CardDB.Card card = CardDB.Instance.getCardDataFromDbfID(item.Key);
                enemyGuessHandCard += card.nameCN + (item.Value > 1 ? "(" + item.Value + ")" : "") + ";";
            }

            Helpfunctions.Instance.logg(normalInfo);
            Helpfunctions.Instance.logg("(猜测对手构筑为:" + p.enemyGuessDeck + " 套牌代码：" + Hrtprozis.Instance.enemyDeckCode);
            Helpfunctions.Instance.logg("预计直伤： " + Hrtprozis.Instance.enemyDirectDmg + "， 加上场攻一共 " + (Hrtprozis.Instance.enemyDirectDmg + p.calEnemyTotalAngr()) + " )");
            Helpfunctions.Instance.logg(enemyVal);
            Helpfunctions.Instance.logg(myVal);
            Helpfunctions.Instance.logg(handCard);
            Helpfunctions.Instance.logg(enemyGuessHandCard);

            Helpfunctions.Instance.logg("#######################################################################");
            Helpfunctions.Instance.logg("#######################################################################");
            Helpfunctions.Instance.logg("turn " + gTurn + "/" + gTurnStep);// gTurn：如果先手，则1357... 如果后手 2468
            //gTurnStep是该回合，多次出牌/动作的每一步
            Helpfunctions.Instance.logg("mana " + currentMana + "/" + ownMaxMana);
            Helpfunctions.Instance.logg("emana " + enemyMaxMana);
            if (p.anzTamsin)
            {
                Helpfunctions.Instance.logg("anzTamsin " + p.anzTamsin);
            }
            Helpfunctions.Instance.logg("own secretsCount: " + ownSecretList.Count);
            Helpfunctions.Instance.logg("enemy secretsCount: " + enemySecretList.Count + " ;" + enemysecretIds);

            Ai.Instance.currentCalculatedBoard = dtimes;

            Hrtprozis.Instance.printHero();
            Hrtprozis.Instance.printOwnMinions();
            Hrtprozis.Instance.printEnemyMinions();
            Handmanager.Instance.printcards();
            Probabilitymaker.Instance.printTurnGraveYard();
            Probabilitymaker.Instance.printGraveyards();
            p.prozis.printOwnDeck();
            printUtils.printRecord = false;
        }

    }
}


