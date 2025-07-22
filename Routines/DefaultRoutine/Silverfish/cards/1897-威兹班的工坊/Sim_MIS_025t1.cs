using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：8 攻击力：8 生命值：8
	//The Replicator-inator
	//复制鬼才
	//[x]<b>Gigantic</b>After you play a minion withthe same Attack as this,summon a copy of it.
	//<b>大型</b>在你使用一张与本随从攻击力相同的随从牌后，召唤一个它的复制。
	class Sim_MIS_025t1 : SimTemplate
	{

        public override void onCardWasPlayed(Playfield p, CardDB.Card c, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 只在己方随从卡牌被打出后触发效果
            if (wasOwnCard && c.type == CardDB.cardtype.MOB)
            {
                // 检查触发效果的随从是否为“复制鬼才”
                if (triggerEffectMinion != null && triggerEffectMinion.name == CardDB.cardNameEN.thereplicatorinator)
                {
                    // 检查打出的随从攻击力是否与“复制鬼才”相同
                    if (c.Attack == triggerEffectMinion.Angr)
                    {
                        // 召唤一个它的复制
                        p.callKid(c, triggerEffectMinion.zonepos, true);
                    }
                }
            }
        }
    }
}
