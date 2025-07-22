using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_810 : SimTemplate //* 野猪骑士蕾瑟兰 Leatherclad Hogleader
//<b>Battlecry:</b> If your opponent has 6 or more cards in hand, gain <b>Charge</b>.
//<b>战吼：</b>如果你的对手拥有6张或者更多手牌，便获得<b>冲锋</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            int anz = (m.own) ? p.enemyAnzCards : p.owncards.Count;
            if (anz >= 6) p.minionGetCharge(m);
        }
    }
}