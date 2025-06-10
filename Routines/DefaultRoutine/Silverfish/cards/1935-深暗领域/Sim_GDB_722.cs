using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GDB_722 : SimTemplate //* 红衣指挥官 
	{
        //<b>Battlecry and Deathrattle:</b> Give all Draenei in your hand +1/+1.
        //<b>战吼，亡语：</b>使你手牌中的所有德莱尼获得+1/+1。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if ((TAG_RACE)hc.card.race == TAG_RACE.DRAENEI)
                    {
                        hc.addattack += 1;
                        hc.addHp += 1;
                        p.anzOwnExtraAngrHp += 2;
                    }
                }
            }
        }

    }
}
