using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_809 : SimTemplate //* 野猪骑士塔纳利 Tanaris Hogchopper
//[x]<b>Battlecry:</b> If your opponent'shand is empty, gain <b>Charge</b>.
//<b>战吼：</b>如果你的对手没有手牌，便获得<b>冲锋</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            int anz = (m.own) ? p.enemyAnzCards : p.owncards.Count;
            if (anz < 1) p.minionGetCharge(m);
        }
    }
}