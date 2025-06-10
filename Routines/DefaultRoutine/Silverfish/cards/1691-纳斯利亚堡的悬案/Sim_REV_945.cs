using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_REV_945 : SimTemplate //* 模糊的陌生人 Sketchy Stranger
//[x]<b>Battlecry:</b>Discover a Secret from another class.
//<b>战吼：发现一张另一职业的奥秘牌
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.CORE_FP1_020, true, true);
        }
    }
}
