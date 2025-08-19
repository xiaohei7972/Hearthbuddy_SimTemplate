using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：10 攻击力：7 生命值：7
	//Neptulon the Tidehunter
	//猎潮者耐普图隆
	//[x]<b>Colossal +2</b>, <b>Rush</b>, <b>Windfury</b>Whenever Neptulon attacks,if you control any Hands,they attack instead.
	//<b>巨型+2</b><b>突袭</b>，<b>风怒</b>，每当耐普图隆攻击时，如果你控制着任意耐普图隆之手，改为由手攻击。
	class Sim_TID_712 : SimTemplate
	{
		public override void onMinionAttack(Playfield p, Minion attacker, Minion target)
		{
			foreach (Minion minion in attacker.own ? p.ownMinions : p.enemyMinions)
			{
				if (minion.name == CardDB.cardNameEN.neptulonshand || minion.name == CardDB.cardNameEN.neptulonshand_TID_712t2)
				{
					p.minionAttacksMinion(minion, target);
				}
			}
			return;
        }
		
	}
}
