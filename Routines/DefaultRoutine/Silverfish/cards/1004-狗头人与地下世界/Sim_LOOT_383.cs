using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_383 : SimTemplate //* 饥饿的双头怪 Hungry Ettin
//<b>Taunt</b><b>Battlecry:</b> Summon a random 2-Cost minion for your opponent.
//<b>嘲讽，战吼：</b>为你的对手随机召唤一个法力值消耗为（2）的随从。 
	{
		
        		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_120); 

		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            int zonepos = (m.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            p.callKid(kid, zonepos, !m.own);
        }
	}
}