using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：10
	//The Galactic Projection Orb
	//星空投影球
	//Recast a random spell of each Cost you've cast this game <i>(targets enemies if possible)</i>.
	//再次施放你在本局对战中施放过的法术，每种法力值消耗各随机一个。<i>（尽可能以敌人为目标）</i>
	class Sim_TOY_378 : SimTemplate
	{
		private bool higherCostCardPlayed = false; // 用于跟踪是否在手牌中时打出了法力值消耗更高的牌

		public override void onCardWasPlayed(Playfield p, CardDB.Card card, bool wasOwnCard, Minion triggerEffectMinion) // 检查此随从是否在手牌中
        {
            // 检查此随从是否在手牌中
            if (wasOwnCard && triggerEffectMinion.own && triggerEffectMinion.handcard.card.cardIDenum == CardDB.cardIDEnum.TOY_341)
            {
                // 检查是否使用过法力值消耗更高的牌
                if (card.cost > triggerEffectMinion.handcard.card.cost)// 如果使用过法力值消耗更高的牌
                {
                    higherCostCardPlayed = true;// 标记为已经使用过更高法力值的牌
                    p.evaluatePenality -= 15;
                }
                else
                {
                    p.evaluatePenality += 15;
                }
            }
        }
	}
}		


		/*
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 获取最后一张职业牌的费用
            int lastCardCost = p.lastPlayedCardCost;

            if (lastCardCost >= 7)
            {
			   onCardPlay(p, ownplay, target, lastCardCost);
            }
        }

        
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.setNewHeroPower(CardDB.cardIDEnum.TRL_065h, ownplay); // 设置英雄技能
            if (ownplay) p.ownHero.armor += 5; // 为英雄增加护甲
            else p.enemyHero.armor += 5; // 为敌方英雄增加护甲
			
			int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count; // 获取场上随从数量
			
            if (ownplay) // 如果是我方
            {
                if (p.ownMinions.Count < p.enemyMinions.Count) p.evaluatePenality -= 15; // 如果我方随从数量小于敌方随从数量，则减少惩罚
                else p.evaluatePenality -= 5; // 如果我方随从数量大于等于敌方随从数量，则减少惩罚
                foreach (Minion m in p.ownMinions) m.Ready = false; // 我方随从不可攻击
                foreach (Minion m in p.enemyMinions) m.frozen = true; // 敌方随从冻结
                p.ownHero.Hp += 7; // 为英雄恢复生命值
            }
        }
        



		
	}
}

*/
