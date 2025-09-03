using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：2
	//Glowing Glyph
	//辐光雕文
	//Give a minion and its neighbors +1/+2.
	//使一个随从及其相邻随从获得+1/+2。
	class Sim_WW_001t8 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 1, 2);
				foreach (Minion minion in target.own ? p.ownMinions : p.enemyMinions)
				{
					if (minion.zonepos == target.zonepos - 1 | minion.zonepos == target.zonepos + 1)
					{
						p.minionGetBuffed(minion, 1, 2);
					}
				}
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2. REQ_TARGET_TO_PLAY),
			};
		}
	}
}
