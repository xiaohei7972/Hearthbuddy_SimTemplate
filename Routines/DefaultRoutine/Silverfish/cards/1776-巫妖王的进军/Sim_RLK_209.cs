using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：1
	//Unleash Fel
	//释放邪能
	//Deal $1 damageto all enemies. <b>Manathirst_(6):</b> With<b>Lifesteal</b>.
	//对所有敌人造成$1点伤害。<b>法力渴求（6）：</b><b>吸血</b>。
	class Sim_RLK_209 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			if (p.ownMaxMana >= hc.card.Manathirst)
			{
				hc.card.lifesteal = true;
			}
			int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
			p.allCharsOfASideGetDamage(!ownplay, dmg);
		}

	}
}
