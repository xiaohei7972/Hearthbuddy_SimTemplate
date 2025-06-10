using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_142 : SimTemplate //* 影蹄杀手 Shadowhoof Slayer
	{
		//<b>Battlecry:</b> Give your hero +1_Attack this turn.
		//<b>战吼：</b>在本回合中，使你的英雄获得+1攻击力。
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
			Minion hero = (m.own)? p.ownHero : p.enemyHero;
			p.minionGetTempBuff(hero, 1, 0);
        }		
		
	}
}
