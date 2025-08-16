using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：2 攻击力：2 生命值：3
	//Felfused Battery
	//邪能动力源
	//After this attacks, give your other minions +1 Attack. <b>Starship Piece</b>
	//在本随从攻击后，使你的其他随从获得+1攻击力。<b>星舰组件</b>
	class Sim_GDB_110 : SimTemplate
	{
		public override void afterMinionAttack(Playfield p, Minion attacker, Minion defender, bool dontcount)
		{
			List<Minion> temp = attacker.own ? p.ownMinions : p.enemyMinions;
			temp.Remove(attacker);
			foreach (Minion m in temp)
			{
				p.minionGetBuffed(m, 1, 0);
			}
		}

	}
}
