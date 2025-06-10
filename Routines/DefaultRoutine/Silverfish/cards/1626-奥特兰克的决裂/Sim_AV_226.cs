using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_226 : SimTemplate //* 冰霜陷阱 icetrap
	{
		//<b>奥秘：</b>当你的对手施放一个法术时，改为将其移回拥有者的手牌，并且法力值消耗增加（1）点。
        public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            if (target.handcard.card.type == CardDB.cardtype.SPELL)
            {
                p.minionReturnToHand(target, !ownplay, 1);
            }
        }
		
	}
}
