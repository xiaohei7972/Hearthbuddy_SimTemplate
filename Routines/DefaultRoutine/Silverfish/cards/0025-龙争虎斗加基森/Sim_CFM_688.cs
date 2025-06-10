using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_688 : SimTemplate //* 野猪骑士斯派克 Spiked Hogrider
//<b>Battlecry:</b> If an enemy minion has <b>Taunt</b>, gain_<b>Charge</b>.
//<b>战吼：</b>如果一个敌方随从具有<b>嘲讽</b>，便获得<b>冲锋</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            int anz = m.own ? p.anzEnemyTaunt : p.anzOwnTaunt;
            if (anz > 0) p.minionGetCharge(m);
        }
    }
}