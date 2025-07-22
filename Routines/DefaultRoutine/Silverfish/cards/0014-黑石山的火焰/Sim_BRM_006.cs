using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRM_006 : SimTemplate //* 小鬼首领 Imp Gang Boss
//Whenever this minion takes damage, summon a 1/1 Imp.
//每当该随从受到伤害，召唤一个1/1的小鬼。 
	{
		

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BRM_006t); 

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                int tmp = m.anzGotDmg;
                m.anzGotDmg = 0;
                for (int i = 0; i < tmp; i++)
                {
					int pos = m.zonepos;
					p.callKid(kid, pos, m.own);
                }
            }
        }
	}
}