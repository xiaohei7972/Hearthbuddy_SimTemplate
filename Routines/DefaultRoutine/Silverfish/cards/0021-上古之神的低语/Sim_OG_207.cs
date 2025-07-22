using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_207 : SimTemplate //* 无面召唤者 Faceless Summoner
//<b>Battlecry:</b> Summon a random 3-Cost minion.
//<b>战吼：</b>随机召唤一个法力值消耗为（3）的随从。 
	{
		
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_106); 
				
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            List<Minion> list = (m.own) ? p.ownMinions : p.enemyMinions;
            int anz = list.Count;
            p.callKid(kid, m.zonepos, m.own);
            if (anz < 7 && !list[m.zonepos].taunt)
            {
                list[m.zonepos].taunt = true;
                if (m.own) p.anzOwnTaunt++;
                else p.anzEnemyTaunt++;
            }
        }
	}
}