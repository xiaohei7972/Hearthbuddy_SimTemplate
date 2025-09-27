using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：4
	//Drown
	//淹没
	//Put an enemy minion on the bottom of your deck.
	//将一个敌方随从置于你的牌库底。
	class Sim_TID_920 : SimTemplate
	{
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionReturnToDeck(target, ownplay);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
			};
        }
	}
}
