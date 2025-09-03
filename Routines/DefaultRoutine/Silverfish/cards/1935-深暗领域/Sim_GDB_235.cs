using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//随从 战士 费用：5 攻击力：3 生命值：6
	//Exarch Akama
	//大主教阿卡玛
	//[x]After this attacks,all other friendly minionscan attack again <i>(exceptExarch Akama)</i>.
	//在本随从攻击后，所有其他友方随从可再次攻击<i>（大主教阿卡玛除外）</i>。
	class Sim_GDB_235 : SimTemplate
	{
		public override void afterMinionAttack(Playfield p, Minion attacker, Minion defender, bool dontcount)
		{
			if (attacker.own)
			{
				List<Minion> ownMinions = p.ownMinions.ToList();
				ownMinions.Remove(attacker);
				ownMinions.ForEach((m) =>
				{
					m.numAttacksThisTurn--;
					m.updateReadyness();
				});
			}
		}

	}
}
