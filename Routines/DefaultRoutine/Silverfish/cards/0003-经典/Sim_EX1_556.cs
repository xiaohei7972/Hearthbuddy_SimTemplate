using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_556 : SimTemplate //* 麦田傀儡 Harvest Golem
	{
		//<b>Deathrattle:</b> Summon a 2/1 Damaged Golem.
		//<b>亡语：</b>召唤一个2/1的损坏的傀儡。

        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.skele21);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(card, m.zonepos - 1, m.own);
        }
	}
}