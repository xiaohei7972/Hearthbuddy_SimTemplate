using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOD_020 : SimTemplate //* 惊爆异变 Explosive Evolution
	{
		//Transform a minion into a random one that costs (3) more.
		//将一个随从随机变形成为一个法力值消耗增加（3）点的随从。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionTransform(target, p.getRandomCardForManaMinion(target.handcard.card.cost + 3));
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
