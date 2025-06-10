using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：3 攻击力：4 生命值：2
	//Harmonica Soloist
	//口琴独演者
	//<b>Battlecry:</b> If you control no other minions, <b>Discover</b> and cast a <b>Secret</b>.
	//<b>战吼：</b>如果你没有控制其他随从，<b>发现</b>并施放一个<b>奥秘</b>。
	class Sim_ETC_028 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (p.ownMinions.Count == 1) {
				//fakeone 只是为了让AIi倾向于空场的时候打出来。
				p.minionGetDamageOrHeal(p.enemyHero, 5);
			}
		}		
		
	}
}
