using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_BT_921 : SimTemplate //* 奥达奇战刃 Aldrachi Warblades
	{
		//<b>Lifesteal</b>
		//<b>吸血</b>
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_672);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}
	}
}
