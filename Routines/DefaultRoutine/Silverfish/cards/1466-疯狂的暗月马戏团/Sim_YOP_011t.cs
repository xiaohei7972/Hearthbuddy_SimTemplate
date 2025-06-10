using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_011t : SimTemplate //* 审判圣契 Libram of Judgment
	{
		//<b>Corrupted</b><b>Lifesteal</b>
		//<b>已腐蚀</b><b>吸血</b>
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.YOP_011t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}
	}
}
