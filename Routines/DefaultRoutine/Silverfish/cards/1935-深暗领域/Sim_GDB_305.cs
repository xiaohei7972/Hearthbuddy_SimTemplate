using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：5
	//SolarFlare
	//阳炎耀斑
	//Deal 2 damage to all enemies. Costs (1) less for each Elemental you control.
	//对所有敌人造成2点伤害。你每控制一个元素，本牌的法力值消耗便减少（1）点。
	class Sim_GDB_305 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2); // 伤害
            p.allCharsOfASideGetDamage(!ownplay, dmg); // 对所有敌人造成伤害
        }
    
	}
}