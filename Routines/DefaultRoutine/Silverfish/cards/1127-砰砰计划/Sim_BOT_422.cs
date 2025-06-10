using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_422 : SimTemplate //* 牛头人园丁 Tending Tauren
//[x]<b>Choose One -</b> Give yourother minions +1/+1;or Summon two2/2 Treants.
//<b>抉择：</b>使你的所有其他随从获得+1/+1；或者召唤两个2/2的树人。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_158t);

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (choice == 1 || (p.ownFandralStaghelm > 0 && own.own))
            {
                List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
                foreach (Minion m in temp)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 1, 1);
                }
            }
            if (choice == 2 || (p.ownFandralStaghelm > 0 && own.own))
            {
                p.callKid(kid, own.zonepos, own.own, false);
                p.callKid(kid, own.zonepos - 1, own.own);
            }
		}
	}
}