using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 战士 费用：3 攻击力：2 耐久度：0
	//Axe of the Forefathers
	//远祖之斧
	//After your hero attacks, deal 1 damage to all minions.
	//在你的英雄攻击后，对所有随从造成1点伤害。
	class Sim_TLC_478 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_478);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

        public override void onMinionAttack(Playfield p, Minion attacker, Minion target)
        {
			p.allMinionsGetDamage(1);
        }
		
	}
}
