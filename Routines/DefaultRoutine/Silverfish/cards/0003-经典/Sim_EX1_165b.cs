using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_165b : SimTemplate //* 熊形态 Bear Form
	{
		//<b>Taunt</b>
		//<b>嘲讽</b>
        CardDB.Card bear = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_165t2);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionTransform(target, bear);
        }
	}
}