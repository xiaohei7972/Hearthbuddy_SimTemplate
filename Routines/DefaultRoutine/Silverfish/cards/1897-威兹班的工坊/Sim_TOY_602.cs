using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：5
	//Chemical Spill
	//化工泄漏
	//Summon the highest Cost minionfrom your hand, thendeal $5 damage to it.
	//从你的手牌中召唤法力值消耗最高的随从，然后对其造成$5点伤害。
	class Sim_TOY_602 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 找到手牌中法力值消耗最高的随从
            Handmanager.Handcard highestCostMinion = null;
            int highestCost = -1;

            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if (hc.card.type == CardDB.cardtype.MOB && hc.manacost > highestCost)
                {
                    highestCost = hc.manacost;
                    highestCostMinion = hc;
                }
            }

            // 如果找到法力值消耗最高的随从，则召唤它并对其造成5点伤害
            if (highestCostMinion != null)
            {
                int position = p.ownMinions.Count; // 召唤随从的位置
                p.callKid(highestCostMinion.card, position, ownplay); // 召唤该随从

                Minion summonedMinion = p.ownMinions[position]; // 获取刚召唤的随从
                p.minionGetDamageOrHeal(summonedMinion, 5); // 对该随从造成5点伤害

                p.removeCard(highestCostMinion); // 从手牌中移除该随从
            }
        }
    }
}
