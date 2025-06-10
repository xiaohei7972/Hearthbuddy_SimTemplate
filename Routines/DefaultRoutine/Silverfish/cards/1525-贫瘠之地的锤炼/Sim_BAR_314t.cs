using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_314t : SimTemplate //* 罪罚（等级2） Condemn (Rank 2)
	{
		//[x]Deal $2 damage toall enemy minions.<i>(Upgrades when youhave 10 Mana.)</i>
		//对所有敌方随从造成$2点伤害。<i>（当你有10点法力值时升级。）</i>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.allMinionOfASideGetDamage(!ownplay, dmg);
        }		
		
	}
}
