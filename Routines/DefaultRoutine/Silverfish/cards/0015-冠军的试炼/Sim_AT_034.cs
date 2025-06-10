using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_034 : SimTemplate //* 淬毒利刃 Poisoned Blade
//Your Hero Power gives this weapon +1 Attack instead of replacing it.
//你的英雄技能不会取代该武器，改为+1攻击力。 
	{
		
		
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_034);
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
				if(own) p.ownWeapon.Angr++;
				else p.enemyWeapon.Angr++; 
			}
        }		
	}
}