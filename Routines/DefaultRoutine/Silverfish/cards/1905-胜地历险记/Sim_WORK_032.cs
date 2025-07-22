using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：3 攻击力：4 生命值：3
	//Job Shadower
	//影随员工
	//<b>Battlecry:</b> If your hero took damage this turn, summon a copy of this.
	//<b>战吼：</b>如果你的英雄在本回合受到过伤害，召唤一个本随从的复制。
	class Sim_WORK_032 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if ((own.own && p.ownHero.anzGotDmg > 0 && p.ownMinions.Count < 7) || (!own.own && p.enemyHero.anzGotDmg > 0 && p.enemyMinions.Count < 7))
			{
				p.callKid(own.handcard.card, own.zonepos, own.own);
				List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
				temp[own.zonepos].setMinionToMinion(own);
			}
		}

	}
}
