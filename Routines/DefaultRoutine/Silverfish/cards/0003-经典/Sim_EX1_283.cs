using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_283 : SimTemplate //* 冰霜元素 Frost Elemental
	{
		//<b>Battlecry:</b> <b>Freeze</b> a_character.
		//<b>战吼：</b><b>冻结</b>一个角色。

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetFrozen(target);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}