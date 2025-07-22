using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：1 生命值：3
	//Messmaker
	//捣蛋林精
	//<b>Lifesteal</b>, <b>Taunt</b><b>Deathrattle:</b> Deal 1 damageto all enemies.
	//<b>吸血</b>。<b>嘲讽</b><b>亡语：</b>对所有敌人造成1点伤害。
	class Sim_TOY_646 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
        {
			p.allCharsOfASideGetDamage(!m.own, 1);
        }
    }
}
