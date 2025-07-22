using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Eruption
	//爆发
	//[x]<b>Casts When Drawn</b>Deal $@ damage toall enemies.
	//<b>抽到时施放</b>对所有敌人造成$@点伤害。
	class Sim_VAC_321t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			int damage = ownplay ? p.getSpellDamageDamage(1) : p.getSpellDamageDamage(1);
			p.allCharsOfASideGetDamage(!ownplay, damage);
        }
		
	}
}
