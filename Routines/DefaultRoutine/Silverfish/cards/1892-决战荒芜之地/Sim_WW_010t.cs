using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 萨满祭司 费用：5 攻击力：2 耐久度：0
	//Staff of the Nine Frogs
	//九蛙魔杖
	//[x]After your hero attacks,summon a {0}/{1} Frogwith <b>Taunt</b>. <i>(Each Frog is_bigger than the last!)</i>
	//在你的英雄攻击后，召唤一只{0}/{1}并具有<b>嘲讽</b>的青蛙。<i>（每只青蛙都会比上一只更大！）</i>
	class Sim_WW_010t : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WW_010t);
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WW_010hexfrog);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“九蛙魔杖”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.TLC_478)
			{
				int pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, own.own);
			}
		}

	}
}
