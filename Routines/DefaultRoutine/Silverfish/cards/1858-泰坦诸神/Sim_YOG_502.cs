using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：6
	//Sanitize
	//清理污染
	//[x]Deal damage equal toyour Armor to all minions.<b>Forge:</b> Gain 4 Armor first.
	//对所有随从造成等同于你的护甲值的伤害。<b>锻造：</b>先获得4点护甲值。
	class Sim_YOG_502 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice) 
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(p.ownHero.armor) : p.getEnemySpellDamageDamage(p.enemyHero.armor); // 获取伤害
            p.allMinionsGetDamage(dmg); 
        }
		
	}
}
