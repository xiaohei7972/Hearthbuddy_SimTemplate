using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：2 攻击力：1 生命值：3
	//Spirit of the Kaldorei
	//卡多雷精魂
	//<b>Taunt</b>, <b>Lifesteal</b><b>Battlecry:</b> If you usedyour Hero Power thisturn, gain +3/+3.
	//<b>嘲讽</b>。<b>吸血</b>。<b>战吼：</b>如果你在本回合中使用过英雄技能，获得+3/+3。
	class Sim_FIR_777 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (p.anzUsedOwnHeroPower > 0) p.minionGetBuffed(own, 3, 3);
		}

	}
}
