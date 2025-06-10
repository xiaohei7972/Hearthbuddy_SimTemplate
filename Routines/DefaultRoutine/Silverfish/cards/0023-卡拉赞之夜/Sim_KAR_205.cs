using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_205 : SimTemplate //* 镀银魔像 Silverware Golem
//If you discard this minion, summon it.
//如果你弃掉了这张随从牌，则会召唤它。 
	{
		

        public override bool onCardDicscard(Playfield p, Handmanager.Handcard hc, Minion own, int num, bool checkBonus)
        {
            if (checkBonus) return true;
			if (own != null) return false;
			
            bool ownplay = true;
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            p.callKid(hc.card, temp.Count, ownplay, false);
            Minion m = temp[temp.Count - 1];
            if (m.name == hc.card.nameEN && m.playedThisTurn)
            {
                m.entitiyID = hc.entity;
                m.Angr += hc.addattack;
                m.Hp += hc.addHp;
            }
            return true;
        }
    }
}