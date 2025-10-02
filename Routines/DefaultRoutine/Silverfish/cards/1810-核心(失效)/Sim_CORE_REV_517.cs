using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：8
	//Criminal Lineup
	//罪犯列队
	//[x]Choose a friendly minion.Summon 3 copies of it.<b>Overload:</b> (2)
	//选择一个友方随从。召唤3个它的复制。<b>过载：</b>（2）
	class Sim_CORE_REV_517 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
				int pos = temp.Count;
				if (pos < 6)
				{
					p.callKid(target.handcard.card, pos, ownplay);
					p.callKid(target.handcard.card, pos, ownplay);
					p.callKid(target.handcard.card, pos, ownplay);
					temp[pos].setMinionToMinion(target);
				}
			}
			if (ownplay) p.lockedMana += 2;

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
