using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_162 : SimTemplate //* 克苏恩的信徒 Disciple of C'Thun
//<b>Battlecry:</b> Deal 2 damage. Give your C'Thun +2/+2 <i>(wherever it is)</i>.
//<b>战吼：</b>造成2点伤害。使你的克苏恩获得+2/+2<i>（无论它在哪里）。</i> 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.minionGetDamageOrHeal(target, 2);
            if (own.own) p.cthunGetBuffed(2, 2, 0);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}