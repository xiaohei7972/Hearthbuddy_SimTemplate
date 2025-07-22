using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：8 攻击力：8 生命值：8
	//Star Grazer
	//吞星兽
	//<b>Elusive, Taunt</b><b>Spellburst:</b> Give yourhero +8 Attack this turn and gain 8 Armor.
	//<b>扰魔。嘲讽</b><b>法术迸发：</b>在本回合中，使你的英雄获得+8攻击力并获得8点护甲值。
	class Sim_GDB_855 : SimTemplate
	{
		public override void OnSpellburst(Playfield p, Minion m, Handmanager.Handcard hc)
		{
			if (hc.manacost == 0) p.evaluatePenality += 10; // 法力值消耗为0时，惩罚值增加10

			p.minionGetBuffed(p.ownHero, 8, 0); 
			p.minionGetArmor(p.ownHero, 8); // 使英雄获得8点护甲值
		}
		
	}
}
