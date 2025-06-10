using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_286t1 : SimTemplate //* 勇士重槌 Champion's Maul
//<b>Battlecry:</b> Summon two 1/1 Silver Hand Recruits.
//<b>战吼：</b>召唤两个1/1的白银之手新兵。
	{

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_286t1);
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t);        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
		   p.equipWeapon(weapon, ownplay);
           int pos = (ownplay)? p.ownMinions.Count : p.enemyMinions.Count;
			
			
		   p.callKid(kid, pos, ownplay, false);
			
		   p.callKid(kid, pos, ownplay);
        }
	}
}