using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_337 : SimTemplate //* 食人鱼喷枪 Piranha Launcher
//[x]After your hero attacks,summon a 1/1 Piranha.
//在你的英雄攻击后，召唤一个1/1的食人鱼。 
	{
		

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_337);
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }
    }
}