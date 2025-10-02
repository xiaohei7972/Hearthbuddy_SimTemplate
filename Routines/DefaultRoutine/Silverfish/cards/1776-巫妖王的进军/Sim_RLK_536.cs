using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：2
	//Shallow Grave
	//薄葬
	//Trigger a friendly minion's <b>Deathrattle</b>, then destroy it.
	//触发一个友方随从的<b>亡语</b>，然后将其消灭。
	class Sim_RLK_536 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.doDeathrattles(new List<Minion> { target });
				p.minionGetDestroyed(target);
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
