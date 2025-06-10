using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_113t2 : SimTemplate //* 强化冰冻陷阱 improvedfreezingtrap
	{
		//<b>奥秘：</b>当一个敌方随从攻击时，将其移回拥有者的手牌，并且法力值消耗增加（4）点。
		public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
		{
			p.minionReturnToHand(target, !ownplay, 4);
			target.Hp = -100;
		}

	}
}
