using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_040 : SimTemplate //* 沙鳞灵魂行者 Siltfin Spiritwalker
//Whenever another friendly Murloc dies, draw a card. <b><b>Overload</b>:</b> (1)
//每当有其他友方鱼人死亡，便抽一张牌。<b>过载：</b>（1） 
    {


        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own) p.ueberladung++;
        }
		
        public override void onMinionDiedTrigger(Playfield p, Minion m, Minion diedMinion)
        {
            int diedMinions = (m.own) ? p.tempTrigger.ownMurlocDied : p.tempTrigger.enemyMurlocDied;
            if (diedMinions == 0) return;
            int residual = (p.pID == m.pID) ? diedMinions - m.extraParam2 : diedMinions;
            m.pID = p.pID;
            m.extraParam2 = diedMinions;
            for (int i = 0; i < residual; i++)
            {
                p.drawACard(CardDB.cardIDEnum.None, m.own);
            }
        }
    }
}