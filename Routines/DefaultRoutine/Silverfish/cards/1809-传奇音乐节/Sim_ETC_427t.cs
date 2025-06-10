using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：3
	//Dissonant Metal
	//刺耳金属
	//[x]Give 2 random minionsin your hand +4/+4.<i>(Swaps each turn.)</i>
	//随机使你手牌中的2张随从牌获得+4/+4。<i>（每回合切换。）</i>
	class Sim_ETC_427t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			if (ownplay) {
				int i = 0;
				foreach (Handmanager.Handcard handCard in p.owncards) {
				if (handCard.card.type == CardDB.cardtype.MOB && i < 2) {
						i++;
	        	        handCard.addattack += 4;
    		            handCard.addHp += 4;
					}
				}
			}
        }				
		
	}
}
