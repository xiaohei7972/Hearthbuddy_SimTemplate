using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_124 : SimTemplate //* 海盗藏品 Corsair Cache
	{
		//Draw a weapon.Give it +1 Durability.
		//抽一张武器牌。使其获得+1耐久度。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			 p.drawACard(CardDB.cardIDEnum.DRG_025, ownplay);
		}
		
		
	}
}
