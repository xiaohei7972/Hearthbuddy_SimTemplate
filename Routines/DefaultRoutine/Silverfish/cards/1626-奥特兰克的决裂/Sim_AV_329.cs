using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_329 : SimTemplate //* 祝福 bless
	{
		//使一个随从获得+2生命值，然后使其攻击力等同于其生命值。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(target, 2, 0);
				p.minionSetAngrToHP(target);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
