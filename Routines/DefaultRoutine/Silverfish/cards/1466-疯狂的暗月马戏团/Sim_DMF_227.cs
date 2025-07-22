using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_227 : SimTemplate //* 恐惧魔王之咬 Dreadlord's Bite
	{
		//[x]<b>Outcast:</b> Deal 1 damageto all enemies.
		//<b>流放：</b>对所有敌人造成1点伤害。
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DMF_227);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, bool outcast)
		{
			p.equipWeapon(weapon, ownplay);
			if (outcast)
			{
				int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
				p.allCharsOfASideGetDamage(!ownplay, dmg);
				p.evaluatePenality -= 6;
			}
			else p.evaluatePenality += 8;
		}
	}
}
