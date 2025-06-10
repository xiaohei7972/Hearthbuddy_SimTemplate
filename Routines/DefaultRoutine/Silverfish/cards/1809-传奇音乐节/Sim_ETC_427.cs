using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：3
	//Harmonic Metal
	//悦耳金属
	//[x]Give 4 random minionsin your hand +2/+2.<i>(Swaps each turn.)</i>
	//随机使你手牌中的4张随从牌获得+2/+2。<i>（每回合切换。）</i>
	class Sim_ETC_427 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			if (ownplay) {
				int i = 0;
				foreach (Handmanager.Handcard handCard in p.owncards) {
				if (handCard.card.type == CardDB.cardtype.MOB && i < 4) {
						i++;
	        	        handCard.addattack += 2;
    		            handCard.addHp += 2;
					}
				}
			}
         }		
		
	}
}
