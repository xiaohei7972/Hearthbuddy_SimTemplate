using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_286t3 : SimTemplate //* 祝福重槌 Blessed Maul
//<b>Battlecry:</b> Give your minions +1 Attack.
//<b>战吼：</b>使你的所有随从获得+1攻击力。
	{

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_286t3);
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.equipWeapon(w, ownplay);
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
			foreach (Minion m in temp)
			{
			   p.minionGetBuffed(m, 1, 0);			    																		
			}
        }
	}
}