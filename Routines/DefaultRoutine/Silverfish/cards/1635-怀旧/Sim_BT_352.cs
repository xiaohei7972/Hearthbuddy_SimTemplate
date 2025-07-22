using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_352 : SimTemplate //* 萨特监工
	{
		// 在你的英雄攻击后,召唤一个2/2的海盗.
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_352t);
        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            p.callKid(kid, own.zonepos, own.own);
        }
		
		

        
		
	}
}