using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 德鲁伊 费用：3 攻击力：2 耐久度：0
	//The Everbloom
	//永茂之花
	//[x]After your hero attacks,give your minions +2/+2.
	//在你的英雄攻击后，使你的随从获得+2/+2。
	class Sim_TLC_239t : SimTemplate
	{
		public override void afterHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“九蛙魔杖”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.WW_010t)
			{
				p.allMinionOfASideGetBuffed(own.own, 2, 2);
			}
		}
		
	}
}
