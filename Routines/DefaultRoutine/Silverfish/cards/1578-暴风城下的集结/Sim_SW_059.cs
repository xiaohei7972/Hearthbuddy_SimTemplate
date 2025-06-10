using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_059 : SimTemplate //* 矿道工程师 Deeprun Engineer
	{
        //<b>Battlecry:</b> <b>Discover</b> a Mech. It costs (1) less.
        //<b>战吼：</b><b>发现</b>一张机械牌，并使其法力值消耗减少（1）点。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.SW_059, true, true);
            p.evaluatePenality -= 8;
        }

    }
}
