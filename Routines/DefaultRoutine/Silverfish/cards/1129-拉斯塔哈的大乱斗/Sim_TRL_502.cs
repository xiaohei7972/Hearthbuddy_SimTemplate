using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_502 : SimTemplate //* 亡者之灵 Spirit of the Dead
//[x]<b>Stealth</b> for 1 turn.After a friendly minion dies,shuffle a 1-Cost copy of itinto your deck.
//<b>潜行</b>一回合。在一个友方随从死亡后，将它的一张复制洗入你的牌库，其法力值消耗为（1）。 
	{
        

        public override void onMinionDiedTrigger(Playfield p, Minion m, Minion diedMinion)
        {
            int diedMinions = (m.own) ? p.tempTrigger.ownMinionsDied : p.tempTrigger.enemyMinionsDied;
            if (diedMinions == 0) return;
            int residual = (p.pID == m.pID) ? diedMinions - m.extraParam2 : diedMinions;
            m.pID = p.pID;
            m.extraParam2 = diedMinions;
            for (int i = 0; i < residual; i++)
            {
                p.ownDeckSize++;
            }
        }
	}
}