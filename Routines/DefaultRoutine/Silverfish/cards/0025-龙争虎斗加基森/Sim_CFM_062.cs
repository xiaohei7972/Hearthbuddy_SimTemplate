using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_062 : SimTemplate //* 污手街守护者 Grimestreet Protector
//[x]<b>Taunt</b><b>Battlecry:</b> Give adjacent_minions <b>Divine Shield</b>.
//<b>嘲讽，战吼：</b>使相邻的随从获得<b>圣盾</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion mnn in temp)
            {
                if (mnn.zonepos == m.zonepos - 1 || mnn.zonepos == m.zonepos + 1)
                {
                    mnn.divineshild = true;
                }
            }
        }
    }
}