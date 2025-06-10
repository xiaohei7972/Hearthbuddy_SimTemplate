using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA04_2 : SimTemplate //* 熔岩脉动 Magma Pulse
//<b>Hero Power</b>Deal 1 damage to all minions.
//<b>英雄技能</b>对所有随从造成1点伤害。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getHeroPowerDamage(1) : p.getEnemyHeroPowerDamage(1);
			p.allMinionsGetDamage(dmg);
		}
	}
}