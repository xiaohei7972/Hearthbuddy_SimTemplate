using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：5
	//Emotional Rhapsody
	//动情狂想曲
	//[x]Deal $3 damage to allminions. Give your hero+5 Attack this turn.<i>(Changes each turn.)</i>
	//对所有随从造成$3点伤害。在本回合中，使你的英雄获得+5攻击力。<i>（每回合都会改变。）</i>
	class Sim_JAM_018t3 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			Minion hero = ownplay ? p.ownHero : p.enemyHero;
			int damage = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
			p.allMinionsGetDamage(damage);
			p.minionGetTempBuff(hero, 5, 0);
            hero.updateReadyness();

		}
		
	}
}
