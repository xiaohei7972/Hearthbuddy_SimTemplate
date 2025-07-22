using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_611 : SimTemplate //* 冰冻陷阱 Freezing Trap
	{
		//<b>Secret:</b> When an enemy minion attacks, return it to its owner's hand. It costs (2) more.
		//<b>奥秘：</b>当一个敌方随从攻击时，将其移回拥有者的手牌，并且法力值消耗增加（2）点。
		
        public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            p.minionReturnToHand(target, !ownplay, 2);
        }

    }
}