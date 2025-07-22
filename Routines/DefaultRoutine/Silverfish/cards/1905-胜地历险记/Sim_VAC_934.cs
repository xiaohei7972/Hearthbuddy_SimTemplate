using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：7 攻击力：4 生命值：20
	//Beached Whale
	//搁浅巨鲸
	//<b>Taunt</b><b>Battlecry:</b> Deal 10 damage to this minion.
	//<b>嘲讽</b>。<b>战吼：</b>对本随从造成10点伤害。
	class Sim_VAC_934 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(own, 10); // 对该随从造成10点伤害
        }
    }
}
