using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_596 : SimTemplate //* 银剑 Silver Sword
//After your hero attacks, give your minions +1/+1.
//在你的英雄攻击后，你的所有随从获得+1/+1。 
	{
		

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_596);
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
			p.allMinionOfASideGetBuffed(ownplay, 1, 1);
        }
    }
}