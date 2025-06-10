using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_286t4 : SimTemplate //* 净化重槌 Purifier's Maul
//<b>Battlecry:</b> Give your minions <b>Divine Shield</b>.
//<b>战吼：</b>使你的所有随从获得<b>圣盾</b>。
	{

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_286t4);
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.equipWeapon(w, ownplay);
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
			foreach (Minion m in temp)
			{
			   if (!m.divineshild) 	
				{	     
			        m.divineshild =true;
			    }  
			}
        }
	}
}