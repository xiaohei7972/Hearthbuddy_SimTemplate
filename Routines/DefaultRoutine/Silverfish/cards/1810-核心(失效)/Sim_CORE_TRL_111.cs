using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_TRL_111 : SimTemplate //* Headhunter's Hatchet
	{
		//Battlecry: If you control a Beast, gain +1 Durability.
		
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_111);
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.equipWeapon(weapon, ownplay);
			
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PET)
                {
					if (ownplay) p.ownWeapon.Durability++;
                    else p.enemyWeapon.Durability++;
                    break;
                }
            }
        }
    }
}