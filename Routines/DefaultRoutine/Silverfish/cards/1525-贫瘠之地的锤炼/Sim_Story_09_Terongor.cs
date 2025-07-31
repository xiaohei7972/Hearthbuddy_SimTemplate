using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：3 生命值：4
	//Teron'gor
	//塔隆戈尔
	//[x]<b>Battlecry:</b> Destroy a minion.If drawn this turn, insteaddestroy all enemy minions.
	//<b>战吼：</b>消灭一个随从。如果在本回合被抽到，则改为消灭所有敌方随从。
	class Sim_Story_09_Terongor : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.handcard.card.Quickdraw)
			{
				List<Minion> minions = own.own ? p.enemyMinions : p.ownMinions;
				foreach (Minion minion in minions)
				{
					p.minionGetDestroyed(minion);
				}
				return;
			}
			if (target != null)
				p.minionGetDestroyed(target);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), //需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), //目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //目标只能是敌方
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), //需要一个目标
            };
		}

	}
}
