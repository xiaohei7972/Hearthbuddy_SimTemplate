using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：5 攻击力：5 生命值：6
	//Aranna, Thrill Seeker
	//极限追逐者阿兰娜
	//[x]<b>Priest Tourist</b>Damage your hero takeson your turn is redirectedto a random enemy.
	//<b>牧师游客</b>你的英雄在你的回合中受到的伤害会转移给一个随机敌人。
	class Sim_VAC_501 : SimTemplate
	{
		public override void onAuraStarts(Playfield p, Minion m)
		{
			if (m.own && p.isOwnTurn)
			{
				Minion hero = m.own ? p.ownHero : p.enemyHero;
				if (hero.anzGotDmg > 0)
				{
					hero.anzGotDmg = 0;
					int transferDamage = hero.GotDmgValue;
					hero.GotDmgValue = 0;
					p.DealDamageToRandomCharacter(m.own, transferDamage);

				}
			}

		}


	}
}
