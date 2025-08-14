namespace HREngine.Bots
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Questmanager
    {
        public class QuestItem
        {
            public Dictionary<CardDB.cardNameEN, int> mobsTurn = new Dictionary<CardDB.cardNameEN, int>();
            public Dictionary<int, bool> anrgPets = new Dictionary<int, bool>() { { 1, false }, { 3, false }, { 5, false }, { 7, false } };

            public Dictionary<CardDB.Race, bool> playedRaces = new Dictionary<CardDB.Race, bool>();
            public CardDB.cardIDEnum Id = CardDB.cardIDEnum.None;
            public int questProgress = 0;
            public int maxProgress = 1000;

            public QuestItem()
            {
            }

            public void Copy(QuestItem q)
            {
                this.Id = q.Id;
                this.questProgress = q.questProgress;
                this.maxProgress = q.maxProgress;
                if (Id == CardDB.cardIDEnum.UNG_067)
                {
                    this.mobsTurn.Clear();
                    foreach (var n in q.mobsTurn) this.mobsTurn.Add(n.Key, n.Value);
                }
                if (Id == CardDB.cardIDEnum.TLC_830)
                {
                    this.anrgPets.Clear();
                    this.anrgPets = new Dictionary<int, bool>(q.anrgPets);
                }
            }

            public void Reset()
            {
                this.Id = CardDB.cardIDEnum.None;
                this.questProgress = 0;
                this.maxProgress = 1000;
                this.mobsTurn.Clear();
                this.anrgPets.Clear();
            }

            public QuestItem(string s)
            {
                String[] q = s.Split(' ');
                this.Id = CardDB.Instance.cardIdstringToEnum(q[0]);
                this.questProgress = Convert.ToInt32(q[1]);
                this.maxProgress = Convert.ToInt32(q[2]);
            }

            //-!!!!set in code check if (this.enemyQuest.Id != CardDB.cardIDEnum.None)
            /// <summary>
            /// 随从使用时扳机
            /// 根据当前任务CardIdEnum触发对应case语句,增加任务进度
            /// </summary>
            /// <param name="m"></param>
            public void trigger_MinionWasPlayed(Minion m)
            {
                switch (Id)
                {
                    case CardDB.cardIDEnum.SW_028t2:
                    case CardDB.cardIDEnum.SW_028t:
                    case CardDB.cardIDEnum.SW_028: if (m.handcard.card.race == CardDB.Race.PIRATE) questProgress++; break;
                    case CardDB.cardIDEnum.UNG_934: if (m.taunt) questProgress++; break;
                    case CardDB.cardIDEnum.UNG_920: if (m.handcard.card.cost == 1) questProgress++; break;
                    case CardDB.cardIDEnum.UNG_067:
                        if (mobsTurn.ContainsKey(m.name)) mobsTurn[m.name]++;
                        else mobsTurn.Add(m.name, 1);
                        int total = mobsTurn[m.name] + Questmanager.Instance.getPlayedCardFromHand(m.name);
                        if (total > questProgress) questProgress++;
                        break;
                    case CardDB.cardIDEnum.TLC_830:
                        // 判断随从是否为野兽或全部
                        if (m.handcard.card.race == CardDB.Race.PET || m.handcard.card.race == CardDB.Race.ALL)
                        {
                            foreach (KeyValuePair<int, bool> kvp in anrgPets)
                            {
                                if (m.Angr == kvp.Key && kvp.Value)
                                {
                                    if (mobsTurn.ContainsKey(m.name))
                                        anrgPets[kvp.Key] = true;
                                    questProgress++;
                                    break;
                                }
                            }
                        }
                        break;

                }
            }

            /// <summary>
            /// 随从召唤时扳机
            /// 根据当前任务CardIdEnum触发对应case语句,增加任务进度
            /// </summary>
            /// <param name="m"></param>
            public void trigger_MinionWasSummoned(Minion m)
            {
                switch (Id)
                {
                    case CardDB.cardIDEnum.UNG_116: if (m.Angr >= 5) questProgress++; break;
                    case CardDB.cardIDEnum.UNG_940: if (m.handcard.card.deathrattle) questProgress++; break;
                    case CardDB.cardIDEnum.UNG_942: if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MURLOC) questProgress++; break;
                    // 骑士鱼人任务
                    case CardDB.cardIDEnum.TLC_426: if (m.handcard.card.race == CardDB.Race.MURLOC || m.handcard.card.race == CardDB.Race.ALL) questProgress++; break;
                }
            }

            /// <summary>
            /// 法术使用时扳机
            /// </summary>
            /// <param name="target"></param>
            /// <param name="qId"></param>
            public void trigger_SpellWasPlayed(Minion target, int qId)
            {
                switch (Id)
                {
                    case CardDB.cardIDEnum.UNG_954: if (target != null && target.own && !target.isHero) questProgress++; break;
                    case CardDB.cardIDEnum.UNG_028: if (qId > 67) questProgress++; break;
                    // 
                    case CardDB.cardIDEnum.TLC_817t: if (qId > 67) questProgress++; break;
                    case CardDB.cardIDEnum.TLC_817t2: if (qId > 67) questProgress++; break;

                }
            }

            /// <summary>
            /// 弃牌时扳机
            /// </summary>
            /// <param name="num"></param>
            public void trigger_WasDiscard(int num)
            {
                switch (Id)
                {
                    case CardDB.cardIDEnum.UNG_829: questProgress += num; break;
                }
            }
            /// <summary>
            /// 回合开始时扳机
            /// </summary>
            public void trigger_startTurn()
            {
                switch (Id)
                {
                    case CardDB.cardIDEnum.TLC_602: questProgress++; break;
                }
            }

            /// <summary>
            /// 任务奖励
            /// </summary>
            /// <returns></returns>
            public CardDB.cardIDEnum Reward()
            {
                switch (Id)
                {
                    case CardDB.cardIDEnum.UNG_028: return CardDB.cardIDEnum.UNG_028t; //-Quest: Cast 6 spells that didn't start in your deck. Reward: Time Warp.
                    case CardDB.cardIDEnum.UNG_067: return CardDB.cardIDEnum.UNG_067t1; //-Quest: Play four minions with the same name. Reward: Crystal Core.
                    case CardDB.cardIDEnum.UNG_116: return CardDB.cardIDEnum.UNG_116; //-Quest: Summon 5 minions with 5 or more Attack. Reward: Barnabus.
                    case CardDB.cardIDEnum.UNG_829: return CardDB.cardIDEnum.UNG_829t1; //-Quest: Discard 6 cards. Reward: Nether Portal.
                    case CardDB.cardIDEnum.UNG_920: return CardDB.cardIDEnum.UNG_920t1; //-Quest: Play seven 1-Cost minions. Reward: Queen Carnassa.
                    case CardDB.cardIDEnum.UNG_934: return CardDB.cardIDEnum.UNG_934t1; //-Quest: Play 7 Taunt minions. Reward: Sulfuras.
                    case CardDB.cardIDEnum.UNG_940: return CardDB.cardIDEnum.UNG_940t8; //-Quest: Summon 7 Deathrattle minions. Reward: Amara, Warden of Hope.
                    case CardDB.cardIDEnum.UNG_942: return CardDB.cardIDEnum.UNG_942t; //-Quest: Summon 10 Murlocs. Reward: Megafin.
                    case CardDB.cardIDEnum.UNG_954: return CardDB.cardIDEnum.UNG_954t1; //-Quest: Cast 6 spells on your minions. Reward: Galvadon.  
                    case CardDB.cardIDEnum.TLC_433: return CardDB.cardIDEnum.TLC_433t; //<b>任务：</b>消耗15份<b>残骸</b>。<b>奖励：</b>泰拉克斯，魔骸暴龙。
                    case CardDB.cardIDEnum.TLC_239: return CardDB.cardIDEnum.TLC_239t; //<b>任务：</b>填满你的面板，总计3回合。<b>奖励：</b>永茂之花。
                    case CardDB.cardIDEnum.TLC_830: return CardDB.cardIDEnum.TLC_830t; //<b>任务：</b>使用攻击力为1，3，5，7的野兽牌各一张。<b>奖励：</b>绍克。
                    case CardDB.cardIDEnum.TLC_460: return CardDB.cardIDEnum.TLC_460t; //<b>任务：</b><b>发现</b>8张牌。<b>奖励：</b>源生之石。
                    case CardDB.cardIDEnum.TLC_426: return CardDB.cardIDEnum.TLC_426t; //<b><b>可重复任务：</b>召唤5个鱼人。<b>奖励：</b>你召唤的鱼人获得+1/+1。
                    case CardDB.cardIDEnum.TLC_817t: return CardDB.cardIDEnum.TLC_817t3; //<b>任务：</b>施放4个神圣法术。<b>奖励：</b>生命之息。
                    case CardDB.cardIDEnum.TLC_817t2: return CardDB.cardIDEnum.TLC_817t4; //<b>任务：</b>施放4个暗影法术。<b>奖励：</b>死亡之触。
                    case CardDB.cardIDEnum.TLC_513: return CardDB.cardIDEnum.TLC_513t; //<b>任务：</b>将卡牌洗入你的牌库，总计5次。<b>奖励：</b>暮影大师。
                    case CardDB.cardIDEnum.TLC_229: return CardDB.cardIDEnum.TLC_229t14; //<b>任务：</b>使用6个不同类型的随从牌。<b>奖励：</b>阿沙隆。
                    case CardDB.cardIDEnum.TLC_446: return CardDB.cardIDEnum.TLC_446t; //<b>任务：</b>使用5张<b>临时</b>牌。<b>奖励：</b>邪能地窟裂隙。
                    case CardDB.cardIDEnum.TLC_602: return CardDB.cardIDEnum.TLC_602t; //<b>任务：</b>存活10个回合。<b>奖励：</b>拉特维厄斯，城市之眼。
                    case CardDB.cardIDEnum.TLC_631: return CardDB.cardIDEnum.TLC_631t; //<b>任务：</b>在你的回合对敌人造成刚好2点伤害，总计12次。<b>奖励：</b>格里什巨虫。
                }
                return CardDB.cardIDEnum.None;
            }
        }

        StringBuilder sb = new StringBuilder("", 500);
        public QuestItem ownQuest = new QuestItem();
        public QuestItem enemyQuest = new QuestItem();
        public QuestItem sideQuest = new QuestItem();

        public Dictionary<CardDB.cardNameEN, int> mobsGame = new Dictionary<CardDB.cardNameEN, int>();
        private CardDB.cardNameEN nextMobName = CardDB.cardNameEN.unknown;
        private int nextMobId = 0;
        private int prevMobId = 0;
        Helpfunctions help;

        private static Questmanager instance;

        public static Questmanager Instance
        {
            get
            {
                return instance ?? (instance = new Questmanager());
            }
        }

        private Questmanager()
        {
            this.help = Helpfunctions.Instance;
        }

        public void updateQuestStuff(string questID, int curProgr, int maxProgr, bool ownplay, bool isSideQuest = false)
        {
            QuestItem tmp = new QuestItem() { Id = CardDB.Instance.cardIdstringToEnum(questID), questProgress = curProgr, maxProgress = maxProgr };
            if (ownplay)
            {
                if (isSideQuest) this.sideQuest = tmp;
                else this.ownQuest = tmp;
            }
            else this.enemyQuest = tmp;
        }

        public void updatePlayedMobs(int step)
        {
            if (step != 0)
            {
                if (nextMobName != CardDB.cardNameEN.unknown && nextMobId != prevMobId)
                {
                    prevMobId = nextMobId;
                    nextMobId = 0;
                    if (mobsGame.ContainsKey(nextMobName))
                    {
                        if (ownQuest.questProgress > mobsGame[nextMobName]) mobsGame[nextMobName]++;
                        else mobsGame[nextMobName] = ownQuest.questProgress;
                    }
                    else mobsGame.Add(nextMobName, 1);
                }
            }
        }

        public void updatePlayedCardFromHand(Handmanager.Handcard hc)
        {
            nextMobName = CardDB.cardNameEN.unknown;
            nextMobId = 0;
            if (hc != null && hc.card.type == CardDB.cardtype.MOB)
            {
                nextMobName = hc.card.nameEN;
                nextMobId = hc.entity;
            }
        }

        public int getPlayedCardFromHand(CardDB.cardNameEN name)
        {
            if (mobsGame.ContainsKey(name)) return mobsGame[name];
            else return 0;
        }

        public void Reset()
        {
            sb.Clear();
            mobsGame.Clear();
            ownQuest = new QuestItem();
            enemyQuest = new QuestItem();
            sideQuest = new QuestItem();
            nextMobName = CardDB.cardNameEN.unknown;
            nextMobId = 0;
            prevMobId = 0;
        }

        public string getQuestsString()
        {
            sb.Clear();
            sb.Append("quests: ");
            sb.Append(ownQuest.Id).Append(" ").Append(ownQuest.questProgress).Append(" ").Append(ownQuest.maxProgress).Append(" ");
            sb.Append(enemyQuest.Id).Append(" ").Append(enemyQuest.questProgress).Append(" ").Append(enemyQuest.maxProgress);
            if (sideQuest.maxProgress != 1000)
            {
                sb.Append(" ");
                sb.Append(sideQuest.Id).Append(" ").Append(sideQuest.questProgress).Append(" ").Append(sideQuest.maxProgress);
            }
            return sb.ToString();
        }

        public string getQuestsString(Playfield p)
        {
            sb.Clear();
            sb.Append("quests: ");
            sb.Append(p.ownQuest.Id).Append(" ").Append(p.ownQuest.questProgress).Append(" ").Append(p.ownQuest.maxProgress).Append(" ");
            sb.Append(p.enemyQuest.Id).Append(" ").Append(p.enemyQuest.questProgress).Append(" ").Append(p.enemyQuest.maxProgress);
            if (p.sideQuest.maxProgress != 1000)
            {
                sb.Append(" ");
                sb.Append(p.sideQuest.Id).Append(" ").Append(p.sideQuest.questProgress).Append(" ").Append(p.sideQuest.maxProgress);
            }
            return sb.ToString();
        }


    }

}