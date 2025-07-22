using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：3 生命值：3
	//Grimmer Patron
	//残暴的奴隶主
	//At the end of your turn, summon a copy of this minion.
	//在你的回合结束时，召唤一个本随从的复制。
	class Sim_VAC_464t26 : SimTemplate
	{

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own && p.ownMinions.Count < 7)
            {
                p.callKid(triggerEffectMinion.handcard.card, triggerEffectMinion.zonepos + 1, triggerEffectMinion.own); // 召唤本随从的复制
            }
        }
    }
}
