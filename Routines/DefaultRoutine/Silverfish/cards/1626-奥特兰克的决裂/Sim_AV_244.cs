using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 觅血者 bloodseeker
	// //<b>荣誉消灭：</b>获得+1/+1。
	class Sim_AV_244 : SimTemplate
	{
		// CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_244);
		// public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		// {
		// 	p.equipWeapon(weapon, ownplay);
		// }

		public override void OnHonorableKill(Playfield p, Weapon w, Minion target)
		{
			w.Angr++;
			w.Durability++;
		}

	}
}
