using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_111 : SimTemplate //* 猎头者之斧 Headhunter's Hatchet
//[x]<b>Battlecry:</b> If youcontrol a Beast, gain+1 Durability.
//<b>战吼：</b>如果你控制一个野兽，便获得+1耐久度。 
	{
		
		
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