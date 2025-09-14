using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 战士 费用：3 攻击力：3 耐久度：0
	//Sunken Trident
	//沉没的三叉戟
	//After your hero attacks, deal 2 damage to all enemy minions.
	//在你的英雄攻击后，对所有敌方随从造成2点伤害。
	class Sim_TSC_913t : SimTemplate
	{
		// CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TSC_913t);

        // public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        // {
        //     p.equipWeapon(weapon, ownplay);
        // }
        //英雄攻击
        public override void afterHeroattack(Playfield p, Minion own, Minion target)
        {
			// 检查己方英雄是否装备了“沉没的三叉戟”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.TSC_913t)
			{
				//对敌方随从造成aoe
				p.allMinionOfASideGetDamage(!own.own, 2);
            }
        }
		
	}
}
