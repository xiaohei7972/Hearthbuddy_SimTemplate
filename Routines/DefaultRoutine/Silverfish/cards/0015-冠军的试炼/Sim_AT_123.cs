using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_123 : SimTemplate //* 冰喉 Chillmaw
//[x]<b>Taunt</b><b>Deathrattle:</b> If you're holdinga Dragon, deal 3 damageto all minions.
//<b>嘲讽，亡语：</b>如果你的手牌中有龙牌，则对所有随从造成3点伤害。 
	{
		

		public override void onDeathrattle(Playfield p, Minion m)
        {
			if(m.own)
			{
				bool dragonInHand = false;
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if ((TAG_RACE)hc.card.race == TAG_RACE.DRAGON)
					{
						dragonInHand = true;
						break;
					}
				}
				if(dragonInHand) p.allMinionsGetDamage(3);
			}
			else
			{
				if (p.enemyAnzCards >= 1) p.allMinionsGetDamage(3);
			}
        }
    }
}