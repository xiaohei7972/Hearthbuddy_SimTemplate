using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_MAW_006 : SimTemplate //* 异议 Objection!
//奥秘：当你的对手使用一张随从牌时，反制该随从。
//Secret: When your opponent plays a minion, Counter it.
    {
        public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            p.minionGetDestroyed(target);
        }
    }
}
