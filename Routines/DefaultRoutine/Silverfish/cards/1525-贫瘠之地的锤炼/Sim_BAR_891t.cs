using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_891t : SimTemplate //* 怒火（等级2） Fury (Rank 2)
	{
		//[x]Give your hero +3 Attackthis turn. <i>(Upgrades whenyou have 10 Mana.)</i>
		//在本回合中，使你的英雄获得+3攻击力。<i>（当你有10点法力值时升级。）</i>
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionGetTempBuff(p.ownHero, 3, 0);
			p.ownHero.updateReadyness();
		}

	}
}
