using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_605 : SimTemplate //* 小鬼狱火 Impferno
//Give your Demons +1 Attack. Deal $1 damage to all enemy minions.
//使你的恶魔获得+1攻击力。对所有敌方随从造成$1点伤害。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion m, int choice)
        {
            List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion mnn in temp)
            {
                if ((TAG_RACE)mnn.handcard.card.race == TAG_RACE.DEMON && mnn.entitiyID != m.entitiyID) p.minionGetBuffed(mnn, 1, 0);
            }
			int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);;
			p.allMinionOfASideGetDamage(!ownplay, dmg);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 15),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}