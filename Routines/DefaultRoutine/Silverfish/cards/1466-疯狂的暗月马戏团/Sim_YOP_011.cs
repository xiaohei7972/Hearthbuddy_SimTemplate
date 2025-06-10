using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_011 : SimTemplate //* 审判圣契 Libram of Judgment
	{
		//<b>Corrupt:</b> Gain <b>Lifesteal</b>.
		//<b>腐蚀：</b>获得<b>吸血</b>。
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.YOP_011);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}
		
	}
}
