using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_202 : SimTemplate //* 勇猛战将洛卡拉 rokarathevalorous
	{
		//<b>战吼：</b>装备一把5/2的无坚不摧之力。
		CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_202t2);
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
            p.equipWeapon(w, m.own);
		}

	}
}
