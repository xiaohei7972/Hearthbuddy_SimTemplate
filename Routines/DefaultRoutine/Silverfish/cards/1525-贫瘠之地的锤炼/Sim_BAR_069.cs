using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：5 生命值：10
	//Injured Marauder
	//受伤的掠夺者
	//<b>Taunt</b><b>Battlecry:</b> Deal 6 damage to this minion.
	//<b>嘲讽</b>。<b>战吼：</b>对本随从造成6点伤害。
	class Sim_BAR_069 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(own, 6); // 对该随从造成10点伤害
        }
		
	}
}
