using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_258t : SimTemplate //* 大地祈咒 earthinvocation
	{
		//召唤两个2/3并具有<b>嘲讽</b>的元素。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_258t6);//spiritwolf

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

			p.callKid(kid, pos, ownplay, false);
			p.callKid(kid, pos, ownplay);
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
			};
		}
	}
}
