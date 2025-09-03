using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：8 攻击力：5 生命值：10
	//Hulking Overfiend
	//巨型大恶魔
	//<b>Rush</b>. After this attacks and kills a minion, it may_attack again.
	//<b>突袭</b>在本随从攻击并消灭一个随从后，可再次攻击。
	class Sim_BT_487 : SimTemplate
	{
		public override void afterMinionAttack(Playfield p, Minion attacker, Minion defender, bool dontcount)
		{
			if (!defender.isHero && defender.Hp < 1 && attacker.Hp > 0)
			{
				attacker.numAttacksThisTurn--;
				attacker.updateReadyness();
			}
		}

	}
}
