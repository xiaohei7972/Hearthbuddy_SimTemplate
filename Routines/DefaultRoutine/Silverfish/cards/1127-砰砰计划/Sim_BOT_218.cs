using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_218 : SimTemplate //* 安保巡游者 Security Rover
//[x]Whenever this miniontakes damage, summon a2/3 Mech with <b>Taunt</b>.
//每当该随从受到伤害，召唤一个2/3并具有<b>嘲讽</b>的机械。 
	{
		

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_218t); 

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