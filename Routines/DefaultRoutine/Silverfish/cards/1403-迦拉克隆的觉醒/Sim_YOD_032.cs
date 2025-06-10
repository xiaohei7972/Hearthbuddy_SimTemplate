using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：3 生命值：3
	//Frenzied Felwing
	//狂暴邪翼蝠
	//Costs (1) less for each damage dealt to your opponent this turn.
	//在本回合中，你的对手每受到1点伤害，本牌的法力值消耗便减少（1）点。
	class Sim_YOD_032 : SimTemplate
	{
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 检查是否是己方卡牌，并且卡牌ID是否为狂暴邪翼蝠
            if (wasOwnCard && hc.card.cardIDenum == CardDB.cardIDEnum.YOD_032)
            {
                int damageDealt = p.damageDealtToEnemyHeroThisTurn; // 获取本回合对敌方英雄造成的总伤害
                int newCost = hc.manacost - damageDealt; // 计算新的法力值消耗
                hc.manacost = Math.Max(0, newCost); // 确保法力值消耗不低于0
            }
        }
    }
}
