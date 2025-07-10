using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：5 攻击力：4 生命值：4
	//Sol'etos, Life's Breath
	//索利托斯，生命之息
	//[x]<b>Taunt</b>. <b>Battlecry:</b> Summona copy of this.<i>If you're holding both halves_of Sol'etos, combine!</i>
	//<b>嘲讽</b>。<b>战吼：</b>召唤一个本随从的复制。<i>如果你手中有索利托斯的两部分，将其拼合！</i>
	class Sim_TLC_817t3 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			List<Minion> minions = own.own ? p.ownMinions : p.enemyMinions;
			int minionsCount = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
			if (minionsCount < 7)
			{
				p.callKid(own.handcard.card, own.zonepos, own.own);
				minions[own.zonepos].setMinionToMinion(own);
			}
			else
			{
				p.callKid(own.handcard.card, own.zonepos, own.own);
			}
		}

	}
}
