using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：5 攻击力：4 生命值：4
	//Mawsworn Bailiff
	//渊誓者法警
	//<b><b>Taunt</b>.</b> <b>Battlecry:</b> If you have 4 or more Armor, gain +4/+4.
	//<b><b>嘲讽</b>。</b><b>战吼：</b>如果你的护甲值大于或等于4点，获得+4/+4。
	class Sim_MAW_028 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
			if (p.ownHero.armor >= 4)
            {
               p.minionGetBuffed(m, 4, 4);
            }
        }
		
	}
}
