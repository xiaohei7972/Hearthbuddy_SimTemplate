using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_233 : SimTemplate //* 沙尘吐息 Sand Breath
	{
		//[x]Give a minion +1/+2.Give it <b>Divine Shield</b> ifyou're holding a Dragon.
		//使一个随从获得+1/+2。如果你的手牌中有龙牌，使其获得<b>圣盾</b>。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			
			if (ownplay && target != null)
			{
				p.minionGetBuffed(target, 1, 2);
				bool dragonInHand = false;
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if ((TAG_RACE)hc.card.race == TAG_RACE.DRAGON)
					{
						dragonInHand = true;
						break;
					}
				}
				if (dragonInHand)
				{
					target.divineshild = true;
				}
			}
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}