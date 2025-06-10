using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：3 生命值：3
	//Bumbling Bellhop
	//笨拙的搬运工
	//[x]<b>Taunt</b><b>Battlecry:</b> If you're holding aspell that costs (5) or more,__summon a copy of this.
	//<b>嘲讽</b>。<b>战吼：</b>如果你的手牌中有法力值消耗大于或等于（5）点的法术牌，召唤一个本随从的复制。
	class Sim_VAC_521 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            bool hasHighCostSpell = false;

            // 检查手牌中是否有法力值消耗大于或等于5点的法术牌
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if (hc.card.type == CardDB.cardtype.SPELL && hc.manacost >= 5)
                {
                    hasHighCostSpell = true;
                    break;
                }
            }

            // 如果条件满足，召唤一个本随从的复制
            if (hasHighCostSpell && p.ownMinions.Count < 7)
            {
                p.callKid(own.handcard.card, own.zonepos + 1, own.own); // 召唤一个本随从的复制
            }
        }
    }
}
