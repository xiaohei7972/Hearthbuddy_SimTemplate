using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_819 : SimTemplate //* 女巫的坩埚 Witch's Cauldron
//After a friendly minion dies, add a random Shaman spell to your hand.
//在一个友方随从死亡后，随机将一张萨满祭司法术牌置入你的手牌。 
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
                p.drawACard(CardDB.cardNameEN.unknown, m.own);
            }
        }
	}
}