using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_649 : SimTemplate //* 暗金教信使 Kabal Courier
//<b>Battlecry:</b> <b>Discover</b> a Mage, Priest, or Warlock card.
//<b>战吼：</b><b>发现</b>一张法师、牧师或术士卡牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.shieldbearer, m.own, true);
        }
    }
}