using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOD_024 : SimTemplate //* 炸弹牛仔 Bomb Wrangler
	{
		//Whenever this minion takes damage, summon a_1/1 Boom Bot.
		//每当该随从受到伤害，召唤一个1/1的砰砰机器人。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GVG_110t); //砰砰机器人

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
