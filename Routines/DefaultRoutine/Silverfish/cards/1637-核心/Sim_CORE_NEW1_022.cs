using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：3 生命值：3
	//Dread Corsair
	//恐怖海盗
	//<b>Taunt</b>Costs (1) less per Attack of_your weapon.
	//<b>嘲讽</b>你的武器每有1点攻击力，该牌的法力值消耗便减少（1）点。
	class Sim_CORE_NEW1_022 : SimTemplate
	{
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 如果玩家有装备武器
            if (p.ownWeapon.Angr > 0)
            {
                // 计算武器攻击力对该卡牌法力值消耗的减少
                int manaReduction = p.ownWeapon.Angr;
                hc.manacost = Math.Max(0, hc.card.cost - manaReduction);
            }
        }

    }
}
