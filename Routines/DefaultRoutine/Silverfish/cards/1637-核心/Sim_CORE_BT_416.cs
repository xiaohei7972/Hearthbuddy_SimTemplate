using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_BT_416 : SimTemplate //* 暴怒邪吼者 Raging Felscreamer
	{
        //<b>Battlecry:</b> The next Demon you play costs (2) less.
        //<b>战吼：</b>你的下一张恶魔牌的法力值消耗减少（2）点。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.ownDemonCostLessOnce += 2;
        }

    }
}
