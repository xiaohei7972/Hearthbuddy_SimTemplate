using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_280 : SimTemplate //* 全息术士 Holomancer
//After your opponent plays a minion, summon a 1/1_copy of it.
//在你的对手使用一张随从牌后，召唤一个该随从的1/1复制。 
	{
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (hc.card.type == CardDB.cardtype.MOB && wasOwnCard != triggerEffectMinion.own)
            {
                p.callKid(hc.card, triggerEffectMinion.zonepos, triggerEffectMinion.own);
                if(triggerEffectMinion.own)
                {
                    p.ownMinions[triggerEffectMinion.zonepos].Angr = 1;
                    p.ownMinions[triggerEffectMinion.zonepos].Hp = 1;
                    p.ownMinions[triggerEffectMinion.zonepos].maxHp = 1;
                }
                else
                {
                    p.enemyMinions[triggerEffectMinion.zonepos].Angr = 1;
                    p.enemyMinions[triggerEffectMinion.zonepos].Hp = 1;
                    p.enemyMinions[triggerEffectMinion.zonepos].maxHp = 1;
                }
            }
        }
    }
}
