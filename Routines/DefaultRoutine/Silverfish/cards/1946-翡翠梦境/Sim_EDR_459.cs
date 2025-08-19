using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：4 攻击力：6 生命值：6
	//Afflicted Devastator
	//受难的毁灭者
	//[x]<b>Battlecry:</b> Deal 3 damageto all other friendly minions.<b>Deathrattle:</b> Deal 3 damageto all enemy minions.
	//<b>战吼：</b>对所有其他友方随从造成3点伤害。<b>亡语：</b>对所有敌方随从造成3点伤害。
	class Sim_EDR_459 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int damages = 3;
			foreach (Minion m in own.own ? p.ownMinions.ToArray() : p.enemyMinions.ToArray())
			{
				if (own.entitiyID == m.entitiyID) continue;
				p.minionGetDamageOrHeal(m, damages, true); // 然后对随从造成伤害
			}
			p.updateBoards(); // 更新游戏板状态
		}

		public override void onDeathrattle(Playfield p, Minion m)
		{
			int damages = 3;
			foreach (Minion minion in !m.own ? p.ownMinions.ToArray() : p.enemyMinions.ToArray())
			{
				p.minionGetDamageOrHeal(minion, damages, true); // 然后对随从造成伤害
			}
			p.updateBoards(); // 更新游戏板状态
		}

	}
}
