using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_DS1_188 : SimTemplate //* 角斗士的长弓 Gladiator's Longbow
	{
		//Your hero is <b>Immune</b> while attacking.
		//你的英雄在攻击时具有<b>免疫</b>。
        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_DS1_188);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.equipWeapon(c,ownplay);
		}

	}
}