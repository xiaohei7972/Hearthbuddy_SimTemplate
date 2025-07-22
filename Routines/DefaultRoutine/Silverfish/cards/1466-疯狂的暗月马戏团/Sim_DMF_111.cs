using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_111 : SimTemplate //* 摇滚堕落者 Man'ari Mosher
	{
		//<b>Battlecry:</b> Give a friendly Demon +3 Attack and <b>Lifesteal</b> this turn.
		//<b>战吼：</b>在本回合中，使一个友方恶魔获得+3攻击力和<b>吸血</b>。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null && own.own)
			{
				target.lifesteal = true;
				p.minionGetBuffed(target, 3, 0);
			}
			if (target == null && own.own)
			{
				p.evaluatePenality += 10;
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
