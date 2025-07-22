using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRM_026 : SimTemplate //* 饥饿的巨龙 Hungry Dragon
//<b>Battlecry:</b> Summon a random 1-Cost minion for_your opponent.
//<b>战吼：</b>为你的对手随机召唤一个法力值消耗为（1）的随从。 
	{
		
        		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_614t); 

		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            int zonepos = (m.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            p.callKid(kid, zonepos, !m.own);
        }
	}
}