using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_950 : SimTemplate //* 斩棘刀 Vinecleaver
//[x]After your hero attacks,summon two 1/1 SilverHand Recruits.
//在你的英雄攻击后，召唤两个1/1的白银之手新兵。 
	{
		

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t);
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }
    }
}