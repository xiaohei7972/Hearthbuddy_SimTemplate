using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_013 : SimTemplate //* 尖刺轮盘 Spiked Wheel
	{
		//Has +3 Attack while your hero has Armor.
		//当你的英雄拥有护甲值时，获得+3攻击力。
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.YOP_013);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
			if (ownplay && p.ownHero.armor > 0)
			{
				p.ownWeapon.Angr = 3; 
			}
		}
	}
}
