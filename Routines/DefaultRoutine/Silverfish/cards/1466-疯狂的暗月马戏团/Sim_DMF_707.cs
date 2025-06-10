using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_707 : SimTemplate //* 鱼人魔术师 Magicfin
	{
        //After a friendly Murloc dies, add a random Legendary minion to your hand.
        //在一个友方鱼人死亡后，随机将一张传说随从牌置入你的手牌。
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
