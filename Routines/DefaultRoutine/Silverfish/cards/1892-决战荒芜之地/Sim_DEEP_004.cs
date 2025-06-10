using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：5 攻击力：5 生命值：5
	//Mantle Shaper
	//地幔塑型者
	//Costs (1) less foreach spell you've cast while holding this.
	//本牌在你手中时，你每施放一个法术，本牌的法力值消耗便减少（1）点。
	class Sim_DEEP_004 : SimTemplate
	{
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 检查是否是己方卡牌，并且卡牌ID是否为狂暴邪翼蝠
            if (wasOwnCard && hc.card.cardIDenum == CardDB.cardIDEnum.DEEP_004)
            {
                int damageDealt = p.cardsPlayedThisTurn; // 获取本回合施放的法术数量
                int newCost = hc.manacost - damageDealt; // 计算新的法力值消耗
                hc.manacost = Math.Max(0, newCost); // 确保法力值消耗不低于0
            }
        }
		
	}
}
