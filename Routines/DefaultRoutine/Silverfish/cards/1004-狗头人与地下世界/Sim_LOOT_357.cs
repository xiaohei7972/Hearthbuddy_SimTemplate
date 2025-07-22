using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_357 : SimTemplate //* “老狐狸”马林 Marin the Fox
//<b>Battlecry:</b> Summon a 0/8 Treasure Chest for your opponent. <i>(Break it for awesome loot!)</i>
//<b>战吼：</b>为你的对手召唤一个0/8的宝箱。<i>（打破宝箱可以获得惊人的战利品！）</i> 
	{
		
        		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_357l); 

		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            int pos = (m.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            p.callKid(kid, pos, !m.own);
			
			if (pos < 7)
			{
				if (m.own) p.evaluatePenality -= 40;
				else p.evaluatePenality += 40;
			}
        }
	}
}