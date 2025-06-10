using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_028 : SimTemplate //* 愚者之灾 Fool's Bane
//Unlimited attacks each turn. Can't attack heroes.
//每个回合攻击次数不限，但无法攻击英雄。 
	{
        
        

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_028);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }
	}
}