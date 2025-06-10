using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_643 : SimTemplate //* 霍巴特·钩锤 Hobart Grapplehammer
//<b>Battlecry:</b> Give all weapons in your hand and deck +1 Attack.
//<b>战吼：</b>使你的手牌和牌库里的所有武器牌获得+1攻击力。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.WEAPON) hc.addattack++;
                }
            }
        }
    }
}