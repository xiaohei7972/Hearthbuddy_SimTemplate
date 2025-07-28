using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 无效的 费用：2
	//Spawning Pool
	//孵化池
	//[x]Get a 1/1 Zergling.<b>Deathrattle:</b> Your Zergminions have <b>Rush</b>this turn.
	//获取一张1/1的跳虫。<b>亡语：</b>在本回合中，你的异虫随从拥有<b>突袭</b>。
	class Sim_SC_000 : SimTemplate
	{
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
		{
			if (triggerMinion.handcard.card.CooldownTurn == 0)
				p.drawACard(CardDB.cardIDEnum.SC_010, triggerMinion.own, true);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_CAP,1), // 需要一个空位
			};
		}

	}
}
