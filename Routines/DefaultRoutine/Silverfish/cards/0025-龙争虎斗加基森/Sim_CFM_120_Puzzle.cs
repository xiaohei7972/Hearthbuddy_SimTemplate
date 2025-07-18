using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：1 攻击力：2 生命值：2
	//Mistress of Mixtures
	//亡灵药剂师
	//<b>Deathrattle:</b> Restore #4 Health to each hero.
	//<b>亡语：</b>为每个英雄恢复#4点生命值。
	class Sim_CFM_120_Puzzle : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
		{
			int heal = p.getMinionHeal(4);
			p.minionGetDamageOrHeal(p.ownHero, heal);
			p.minionGetDamageOrHeal(p.enemyHero, heal);
        }
		
	}
}
