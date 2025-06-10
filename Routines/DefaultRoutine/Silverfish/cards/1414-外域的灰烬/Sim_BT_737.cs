using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_737 : SimTemplate //* 玛维·影歌 Maiev Shadowsong
	{
		//<b>Battlecry:</b> Choose a minion.It goes <b>Dormant</b> for 2 turns.
		//<b>战吼：</b>选择一个随从。使其<b>休眠</b>两回合。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null && own.own)
			{
				p.minionGetDestroyed(target);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
