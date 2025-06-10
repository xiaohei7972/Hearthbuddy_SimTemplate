using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_211 : SimTemplate //* 被禁锢的魔喉 Imprisoned Felmaw
	{
		//[x]<b>Dormant</b> for 2 turns.When this awakens,__attack a random enemy.
		//<b>休眠</b>两回合。唤醒时，随机攻击一个敌人。
		public override void onDormantEndsTrigger(Playfield p, Minion m)
		{
			Minion sm = p.searchRandomMinion(m.own ? p.enemyMinions : p.ownMinions, searchmode.searchHighestAttack);
			if (sm == null) sm = (m.own) ? p.enemyHero : p.ownHero;
			p.minionAttacksMinion(m, sm);
		}

	}
}
