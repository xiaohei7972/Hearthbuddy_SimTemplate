using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_900 : SimTemplate //* 无证药剂师 Unlicensed Apothecary
//After you summon a minion, deal 5 damage to_your hero.
//在你召唤一个随从后，对你的英雄造成5点伤害。 
	{
		

        public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (triggerEffectMinion.own == summonedMinion.own)
            {
                if(summonedMinion.handcard.card.nameCN == CardDB.cardNameCN.枯萎化身塔姆辛)
                {
                    p.minionGetDamageOrHeal(p.enemyHero, 5);
                }
                else
                {
                    if (summonedMinion.handcard.card.nameCN == CardDB.cardNameCN.黑眼)
                    {
                        p.mana++;
                        p.evaluatePenality -= 10;
                        if (p.owncarddraw > 0) p.evaluatePenality -= 15;
                    }
                    p.minionGetDamageOrHeal(triggerEffectMinion.own ? p.ownHero : p.enemyHero, 5);
                    if (p.anzTamsin )
                    {
                        p.evaluatePenality -= 10;
                    }else 
                    {
                        // 按理说是战吼先触发效果才对，因此任务节算需要把多余的进度删除
                        if (summonedMinion.handcard.card.nameCN == CardDB.cardNameCN.烈焰小鬼)
                        {
                            if (p.ownQuest.maxProgress - p.ownQuest.questProgress <= 8)
                            {
                                p.evaluatePenality += (p.ownQuest.maxProgress - p.ownQuest.questProgress) * 20;
                                p.ownQuest.questProgress -= 3;
                                if (p.ownQuest.maxProgress - p.ownQuest.questProgress >= 7) p.evaluatePenality -= 50;
                            }
                        }
                        // 按理说是战吼先触发效果才对，因此任务节算需要把多余的进度删除
                        if (summonedMinion.handcard.card.nameCN == CardDB.cardNameCN.狗头人图书管理员)
                        {
                            if (p.ownQuest.maxProgress - p.ownQuest.questProgress <= 7)
                            {
                                p.evaluatePenality += (p.ownQuest.maxProgress - p.ownQuest.questProgress) * 20;
                                p.ownQuest.questProgress -= 2;
                                if (p.ownQuest.maxProgress - p.ownQuest.questProgress >= 6) p.evaluatePenality -= 60;
                            }
                        }
                        p.evaluatePenality += 5;
                    }
                }
            }
        }
    }
}