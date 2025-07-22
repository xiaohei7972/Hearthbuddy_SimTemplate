using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_014 : SimTemplate //* 斯塔拉格 Stalagg
//<b>Deathrattle:</b> If Feugen also died this game, summon Thaddius.
//<b>亡语：</b>如果费尔根也在本局对战中死亡，召唤塔迪乌斯。 
	{
        

        CardDB.Card thaddius = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.FP1_014t);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (p.feugenDead)
            {
                p.callKid(thaddius, m.zonepos - 1, m.own);
            }
        }
	}
}