using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_132_ROGUE_H1 : SimTemplate //* 浸毒匕首 Poisoned Daggers
//<b>Hero Power</b>Equip a 2/2 Weapon.
//<b>英雄技能</b>装备一把2/2的匕首。 
	{
				CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_132_ROGUEt);
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }
		
		
		
	}
}
