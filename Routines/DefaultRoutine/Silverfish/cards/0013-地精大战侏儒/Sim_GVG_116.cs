using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_116 : SimTemplate //* 瑟玛普拉格 Mekgineer Thermaplugg
//Whenever an enemy minion dies, summon a Leper Gnome.
//每当一个敌方随从死亡，召唤一个麻风侏儒。 
    {
        
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_029);
		
        public override void onMinionDiedTrigger(Playfield p, Minion m, Minion diedMinion)
        {
            int diedMinions = (m.own) ? p.tempTrigger.enemyMinionsDied : p.tempTrigger.ownMinionsDied;
            if (diedMinions == 0) return;
            int residual = (p.pID == m.pID) ? diedMinions - m.extraParam2 : diedMinions;
            m.pID = p.pID;
            m.extraParam2 = diedMinions;
            for (int i = 0; i < residual; i++)
			{
				p.callKid(kid, m.zonepos, m.own);
			}
        }
    }
}