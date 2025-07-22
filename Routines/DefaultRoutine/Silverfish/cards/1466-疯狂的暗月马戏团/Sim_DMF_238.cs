using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_238 : SimTemplate //* 纳鲁之锤 Hammer of the Naaru
	{
		//<b>Battlecry:</b> Summon a 6/6 Holy Elemental with <b>Taunt</b>.
		//<b>战吼：</b>召唤一个6/6并具有<b>嘲讽</b>的神圣元素。
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DMF_238);
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DMF_238t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
			int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, place, ownplay);
        }		
	}
}
