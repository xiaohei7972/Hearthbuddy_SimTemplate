using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_182 : SimTemplate //* 魔法蓝蛙 Magic Dart Frog
//After you cast a spell, deal 1 damage to a random enemy minion.
//在你施放一个法术后，随机对一个敌方随从造成1点伤害。 
    {
        

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {
            if (m.own == ownplay && hc.card.type == CardDB.cardtype.SPELL)
            {
                Minion target = (ownplay) ? p.enemyHero : p.ownHero;

                List<Minion> temp = (ownplay) ? p.enemyMinions : p.ownMinions;
                if (temp.Count > 0) target = p.searchRandomMinion(temp, searchmode.searchLowestHP);
                if (target == null) p.minionGetDamageOrHeal(target, 1);
            }
        }
    }
}