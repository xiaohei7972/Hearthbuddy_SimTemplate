using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_147 : SimTemplate //龙语者
	{
        //战吼：使你手牌中的所有龙牌获得+3/+3.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if ((TAG_RACE)hc.card.race == TAG_RACE.DRAGON)
                    {
                        hc.addattack += 3;
                        hc.addHp += 3;
                        p.anzOwnExtraAngrHp += 6;
                    }
                }
            }
        }
    }
}