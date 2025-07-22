using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_018 : SimTemplate //* 坑道穴居人 Tunnel Trogg
//Whenever you <b>Overload</b>, gain +1 Attack per locked Mana Crystal.
//每当你<b>过载</b>时，每一个被锁的法力水晶会使其获得+1攻击力。 
	{
		

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (wasOwnCard == triggerEffectMinion.own && hc.card.overload > 0)
            {
                p.minionGetBuffed(triggerEffectMinion, hc.card.overload, 0);
            }
        }

    }
}