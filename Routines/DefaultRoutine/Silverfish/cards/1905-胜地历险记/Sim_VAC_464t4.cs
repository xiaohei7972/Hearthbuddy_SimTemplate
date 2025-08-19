using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 中立 费用：1 攻击力：3 耐久度：0
	//The Exorcisor
	//驱魔者
	//<b>Silence</b> any minion attacked by this weapon.
	//<b>沉默</b>此武器攻击的任何随从。
	class Sim_VAC_464t4 : SimTemplate
	{
		// CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_464t4);
		// public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		// {
		// 	p.equipWeapon(weapon, ownplay);
		// }
		
		 public override void afterHeroattack(Playfield p, Minion own, Minion target)
        {
			// 检查英雄是否为持有者，并且该武器是驱魔者
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.VAC_464t4)
			{
				if (target != null)
				{
					p.minionGetSilenced(target);
				}
            }

        }
		
	}
}
