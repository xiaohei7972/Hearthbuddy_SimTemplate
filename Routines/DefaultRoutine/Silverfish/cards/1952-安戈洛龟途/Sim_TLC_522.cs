using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：6 攻击力：6 生命值：4
	//Opu the Unseen
	//潜踪大师奥普
	//<b>Battlecry, Combo,and Deathrattle:</b> Cast'Fan of Knives'.
	//<b>战吼，连击，亡语：</b>施放刀扇。
	class Sim_TLC_522 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int damage = (own.own) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
			p.allMinionOfASideGetDamage(!own.own, damage);
			p.drawACard(CardDB.cardIDEnum.None, own.own);
		}

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (p.cardsPlayedThisTurn > 0)
			{
				int damage = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
				p.allMinionOfASideGetDamage(!ownplay, damage);
				p.drawACard(CardDB.cardIDEnum.None, ownplay);
			}
		}

		public override void onDeathrattle(Playfield p, Minion m)
		{
			int damage = (m.own) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
			p.allMinionOfASideGetDamage(!m.own, damage);
			p.drawACard(CardDB.cardIDEnum.None, m.own);
		}

	}
}
