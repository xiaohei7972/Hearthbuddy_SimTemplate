using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：6
	//Sanitize
	//清理污染
	//<b>Forged</b>Gain 4 Armor, then deal damage equal to your Armor to all minions.
	//<b>已锻造</b>获得4点护甲值，然后对所有随从造成等同于你的护甲值的伤害。
	class Sim_YOG_502t : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice) 
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(p.ownHero.armor) : p.getEnemySpellDamageDamage(p.enemyHero.armor);
            p.allMinionsGetDamage(dmg); 
        }

		
	}
}
