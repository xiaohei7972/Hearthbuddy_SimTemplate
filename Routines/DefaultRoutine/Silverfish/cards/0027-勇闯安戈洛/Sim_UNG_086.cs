using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_086 : SimTemplate //* 巨型蟒蛇 Giant Anaconda
//<b>Deathrattle:</b> Summon a minion from your hand with 5 or more Attack.
//<b>亡语：</b>从你手牌中召唤一个攻击力大于或等于5的随从。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
					if (hc.card.Attack + hc.addattack >= 5)
                    {
                        p.callKid(hc.card, p.owncards.Count, m.own);
						p.removeCard(hc);
                        break;
                    }
                }
            }
            else p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_586), p.enemyMinions.Count, m.own);
        }
	}
}