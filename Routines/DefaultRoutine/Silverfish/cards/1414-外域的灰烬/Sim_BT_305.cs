using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_305 : SimTemplate //* 被禁锢的拾荒小鬼 Imprisoned Scrap Imp
	{
        //<b>Dormant</b> for 2 turns.When this awakens,give all minions in your hand +2/+1.
        //<b>休眠</b>两回合。唤醒时，使你手牌中的所有随从牌获得+2/+1。
        public override void onDormantEndsTrigger(Playfield p, Minion m)
        {
            if (m.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    hc.addattack += 2;
                    hc.addHp += 1;
                }
            }
        }


    }
}
