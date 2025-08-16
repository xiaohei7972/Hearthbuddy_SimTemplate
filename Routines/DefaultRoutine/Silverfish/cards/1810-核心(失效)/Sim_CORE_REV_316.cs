using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：7 攻击力：5 生命值：10
	//Remornia, Living Blade
	//活体利刃蕾茉妮雅
	//<b>Rush</b>After this attacks, equip it.
	//<b>突袭</b>在本随从攻击后，装备它。
	class Sim_CORE_REV_316 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_316t);
		public override void afterMinionAttack(Playfield p, Minion attacker, Minion defender, bool dontcount)
		{
			if (attacker.own && attacker.Hp > 0)
				p.equipWeapon(weapon, attacker.own);

		}
		
	}
}
