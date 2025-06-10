using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_011 : SimTemplate //* 正义圣契 Libram of Justice
	{
		//Equip a 1/4 weapon. Change the Health of all enemy minions to 1.
		//装备一把1/4的武器。将所有敌方随从的生命值变为1。
        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_091);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			foreach (Minion m in p.enemyMinions)
            {
                p.minionSetLifetoX(m, 1);
            }
            p.equipWeapon(w, ownplay);
        }
		
		
	}
}
