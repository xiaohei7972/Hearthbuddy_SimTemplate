using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：1 生命值：4
	//Petal Peddler
	//鲜花商贩
	//[x]At the end of your turn,give another random_friendly Dragon +1/+1.
	//在你的回合结束时，随机使另一条友方的龙获得+1/+1。
	class Sim_EDR_889 : SimTemplate
	{
		public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
		{
			// 只在随从所有者的回合结束时触发
			if (turnEndOfOwner == m.own && p.ownMinions.Count != 0)
			{
				foreach (Minion minion in p.ownMinions)
				{
					if ((TAG_RACE)minion.handcard.card.race == TAG_RACE.DRAGON)
					{
						p.minionGetBuffed(minion, 1, 1);
						break;
					}
				}

			}
		}
		
				public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), //有目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), //无目标时也可以用
			};
		}

	}
}
