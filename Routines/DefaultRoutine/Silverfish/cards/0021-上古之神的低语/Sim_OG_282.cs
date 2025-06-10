using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_282 : SimTemplate //* 克苏恩之刃 Blade of C'Thun
//<b>Battlecry:</b> Destroy a minion. Add its Attack and Health to_your C'Thun's <i>(wherever it is).</i>
//<b>战吼：</b>消灭一个随从。你的克苏恩会获得其攻击力和生命值<i>（无论它在哪里）。</i> 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(target != null)
			{
                if (own.own) p.cthunGetBuffed(target.Angr, target.Hp, 0);
				p.minionGetDestroyed(target);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}