using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_507 : SimTemplate //* 鲨鳍后援
	{
		// 在你的英雄攻击后,召唤一个1/1的海盗.
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_507t);
        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            p.callKid(kid, own.zonepos, own.own);
        }
	}
}