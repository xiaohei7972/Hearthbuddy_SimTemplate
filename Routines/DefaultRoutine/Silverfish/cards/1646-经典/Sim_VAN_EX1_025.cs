using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_025 : SimTemplate //* 机械幼龙技工 Dragonling Mechanic
	{
		//<b>Battlecry:</b> Summon a 2/1 Mechanical Dragonling.
		//<b>战吼：</b>召唤一个2/1的机械幼龙。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_025t);//mechanicaldragonling

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.callKid(kid, own.zonepos, own.own);
        }

    }
}
