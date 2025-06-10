using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_507 : SimTemplate //* 黏液喷射者 Gloop Sprayer
//<b>Battlecry:</b> Summon a copy of each adjacent minion.
//<b>战吼：</b>为相邻的随从各召唤一个复制。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
			foreach (Minion m in temp)
			{
				if (m.zonepos == own.zonepos - 1 || m.zonepos == own.zonepos + 1)
				{
					if (target != null && p.ownMinions.Count < 6)
					{
						p.callKid(own.handcard.card, own.zonepos, own.own);
						p.callKid(own.handcard.card, own.zonepos, own.own);
					}
				}
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}