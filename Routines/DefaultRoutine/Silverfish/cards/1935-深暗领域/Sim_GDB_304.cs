using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：6 攻击力：7 生命值：6
	//Saruun
	//恒星之火萨鲁恩
	//[x]<b>Battlecry:</b> Give allElementals in your deck <b>Fire Spell Damage +1</b>.
	//<b>战吼：</b>使你牌库中的所有元素获得<b>火焰法术伤害+1</b>。
	class Sim_GDB_304 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.spellpower++; // 火焰法术伤害+1
		}
		
	}
}
