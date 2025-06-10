using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_523 : SimTemplate //* 火树巫医 Firetree Witchdoctor
//[x]<b>Battlecry:</b> If you're holdinga Dragon, <b>Discover</b> a spell.
//<b>战吼：</b>如果你的手牌中有龙牌，便<b>发现</b>一张法术牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
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
				if(dragonInHand) p.drawACard(CardDB.cardNameEN.frostbolt, m.own, true);
			}
        }
    }
}