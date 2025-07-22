using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_338 : SimTemplate //* 坚守桥梁 holdthebridge
	{
		//使一个随从获得+2/+1和<b>圣盾</b>。直到回合结束，使其获得<b>吸血</b>。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionGetBuffed(target, 2, 1);
			if (target.divineshild == false) target.divineshild = true;
			target.lifesteal = true;
			
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            m.lifesteal = false;
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
