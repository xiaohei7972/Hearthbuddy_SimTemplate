using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_671 : SimTemplate //* 凛风巫师 Cryomancer
//<b>Battlecry:</b> If an enemy is <b>Frozen</b>, gain +2/+2.
//<b>战吼：</b>如果有敌人被<b>冻结</b>，便获得+2/+2。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            List<Minion> temp = (m.own) ? p.enemyMinions : p.ownMinions;
            foreach (Minion mnn in temp)
            {
                if (mnn.frozen)
                {
                    p.minionGetBuffed(m, 2, 2);
                    break;
                }
            }
        }
    }
}