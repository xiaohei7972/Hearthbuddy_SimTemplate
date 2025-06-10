using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：6 攻击力：4 生命值：2
	//Gnomelia, S.A.F.E. Pilot
	//侏儒飞行员诺莉亚
	//[x]<b>Rush</b>. Also damages minionsnext to whomever this attacks.<b>Deathrattle:</b> Deal 2 damageto all enemies.
	//<b>突袭</b>。同时对其攻击目标相邻的随从造成伤害。<b>亡语：</b>对所有敌人造成2点伤害。
	class Sim_TOY_100 : SimTemplate
	{
		public override void onMinionAttack(Playfield p, Minion attacker, Minion target)
		{
			int dmg = attacker.Angr;
			p.minionGetDamageOrHeal(target, dmg);
			List<Minion> temp = (target.own) ? p.ownMinions : p.enemyMinions;
			foreach (Minion m in temp)
			{
				if (target.zonepos == m.zonepos + 1 || target.zonepos + 1 == m.zonepos)
				{
					p.minionGetDamageOrHeal(m, dmg);
					p.minionGetFrozen(m);
				}
			}
		}
		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.allCharsOfASideGetDamage(!m.own, 2);
		}

	}
}
