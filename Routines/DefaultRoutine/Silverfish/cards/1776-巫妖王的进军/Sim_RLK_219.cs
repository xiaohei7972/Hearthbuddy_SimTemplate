using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：2 生命值：4
	//Sunfury Clergy
	//日怒教士
	//[x]<b>Battlecry:</b> Restore 3 Healthto all friendly characters.<b>Manathirst (6):</b> Restore6 Health instead.
	//<b>战吼：</b>为所有友方角色恢复3点生命值。<b>法力渴求（6）：</b>改为恢复6点。
	class Sim_RLK_219 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int heal = own.own ? p.getMinionHeal(3) : p.getEnemyMinionHeal(3);
			if (p.ownMaxMana >= own.handcard.card.Manathirst)
				heal = own.own ? p.getMinionHeal(6) : p.getEnemyMinionHeal(6);

			p.allCharsOfASideGetDamage(own.own, -heal);
		}

	}
}
