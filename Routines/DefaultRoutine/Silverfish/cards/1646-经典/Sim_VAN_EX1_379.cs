using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_379 : SimTemplate //* 忏悔 Repentance
	{
		//<b>Secret:</b> After your opponent plays a minion, reduce its Health to 1.
		//<b>奥秘：</b>在你的对手使用一张随从牌后，使该随从的生命值降为1。
        public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            target.Hp = 1;
            target.maxHp = 1;
            target.wounded = false;

        }

	}

}