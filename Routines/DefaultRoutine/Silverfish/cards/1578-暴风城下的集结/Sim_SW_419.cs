using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_419 : SimTemplate //* 艾露恩神谕者 Oracle of Elune
	{
        //[x]After you play a minionthat costs (2) or less,summon a copy of it.
        //在你使用一张法力值消耗小于或等于（2）点的随从牌后，召唤一个它的复制。
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (hc.card.type == CardDB.cardtype.MOB && hc.manacost <= 2 && wasOwnCard == triggerEffectMinion.own)
            {
                p.callKid(hc.card, triggerEffectMinion.zonepos, triggerEffectMinion.own);
            }
        }
    }
}
