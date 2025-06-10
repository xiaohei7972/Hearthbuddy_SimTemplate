using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_517 : SimTemplate //* 赛场狂热者 Arena Fanatic
//<b>Battlecry:</b> Give all minions in your hand +1/+1.
//<b>战吼：</b>使你手牌中的所有随从牌获得+1/+1。 
	{
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.MOB)
                    {
                        hc.addattack++;
                        hc.addHp++;
                        p.anzOwnExtraAngrHp += 2;
                    }
                }
            }
        }
	}
}