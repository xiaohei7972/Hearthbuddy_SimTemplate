using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_085 : SimTemplate //* 癫狂的唤冰者 Demented Frostcaller
//After you cast a spell, <b>Freeze</b> a random enemy.
//在你施放一个法术后，随机<b>冻结</b>一个敌人。 
	{
		
		
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {
            if (m.own == ownplay && hc.card.type == CardDB.cardtype.SPELL)
            {
                Minion target = null;
                List<Minion> temp = (ownplay) ? p.enemyMinions : p.ownMinions;
                if (temp.Count > 0) target = p.searchRandomMinion(temp, searchmode.searchLowestHP);
                if (target == null) target = (ownplay) ? p.enemyHero : p.ownHero;
                p.minionGetFrozen(target);
            }
        }
    }
}