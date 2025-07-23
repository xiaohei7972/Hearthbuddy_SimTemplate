using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：3 攻击力：5 生命值：5
	//Knight of the Dead
	//亡者骑士
	//[x]<b>Battlecry:</b> Deal 5 damageto your hero. <b>Manathirst (7):</b>Restore 5 Health to yourhero instead.
	//<b>战吼：</b>对你的英雄造成5点伤害。<b>法力渴求（7）：</b>改为为你的英雄恢复5点生命值。
	class Sim_NX2_021 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			// 我也不确定法力渴求是不是这么写
			if (p.ownMaxMana >= own.handcard.card.Manathirst)
			{
				int haal = own.own ? p.getMinionHeal(5) : p.getEnemyMinionHeal(5);
				p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, -haal);
			}
			else
			{
				p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, 5);
			}
		}

	}
}
