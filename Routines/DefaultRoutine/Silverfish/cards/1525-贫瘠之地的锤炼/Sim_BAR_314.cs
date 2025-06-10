using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_314 : SimTemplate //* 罪罚（等级1） Condemn (Rank 1)
	{
		//[x]Deal $1 damage toall enemy minions.<i>(Upgrades when youhave 5 Mana.)</i>
		//对所有敌方随从造成$1点伤害。<i>（当你有5点法力值时升级。）</i>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            p.allMinionOfASideGetDamage(!ownplay, dmg);
        }
		
	}
}
