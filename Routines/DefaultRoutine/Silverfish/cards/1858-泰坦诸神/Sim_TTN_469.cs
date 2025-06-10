using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：2 攻击力：2 生命值：2
	//Stoneskin Armorer
	//岩肤护甲商
	//<b>Battlecry:</b> If your Armor changed this turn,draw 2 cards.
	//<b>战吼：</b>在本回合中，如果你的护甲值发生变化，抽两张牌。
	class Sim_TTN_469 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{

            int dmg = (own.own) ? p.getSpellDamageDamage(p.ownHero.armor) : p.getEnemySpellDamageDamage(p.enemyHero.armor); // 获取护甲变化值
			if (dmg >= 1)
			{
				p.drawACard(CardDB.cardIDEnum.None, own.own);
				p.drawACard(CardDB.cardIDEnum.None, own.own);
			}
			
		}
		
	}
}
