using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_573 : SimTemplate //* 塞纳留斯 Cenarius
	{
		//<b>Choose One -</b> Give your other minions +2/+2; or Summon two 2/2 Treants with <b>Taunt</b>.
		//<b>抉择：</b>使你的所有其他随从获得+2/+2；或者召唤两个2/2并具有<b>嘲讽</b>的树人。
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_573t); //special treant

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (choice == 1 || (p.ownFandralStaghelm > 0 && own.own))
            {
                List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
                foreach (Minion m in temp)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 2, 2);
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