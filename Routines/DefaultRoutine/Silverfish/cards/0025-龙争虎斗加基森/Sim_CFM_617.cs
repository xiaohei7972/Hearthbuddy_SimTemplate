using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_617 : SimTemplate //* 天神唤梦者 Celestial Dreamer
//[x]<b>Battlecry:</b> If you control aminion with 5 or moreAttack, gain +2/+2.
//<b>战吼：</b>如果你控制一个攻击力大于或等于5的随从，便获得+2/+2。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion mnn in temp)
            {
                if (mnn.Angr > 4)
                {
                    p.minionGetBuffed(m, 2, 2);
                    break;
                }
            }
        }
    }
}