using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_781 : SimTemplate //* 埃辛诺斯壁垒 Bulwark of Azzinoth
	{
		//[x]Whenever your hero wouldtake damage, this loses_1 Durability instead.
		//每当你的英雄即将受到伤害，改为埃辛诺斯壁垒失去1点耐久度。
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_781);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, bool outcast)
		{
			p.equipWeapon(weapon, ownplay);
			if (ownplay) p.anzOwnAnimatedArmor++;
			else p.anzEnemyAnimatedArmor++;
		}
	}
}
