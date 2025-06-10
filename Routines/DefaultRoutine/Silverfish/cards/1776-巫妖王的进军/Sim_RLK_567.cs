using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：0
	//Shadow of Demise
	//殒命暗影
	//Each time you cast a spell, transform this into a copy of it.
	//每当你施放一个法术，变形成为该法术的复制。
	class Sim_RLK_567 : SimTemplate
	{
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 如果打出的牌是法术
            if (hc.card.type == CardDB.cardtype.SPELL)
            {
                // 将 "殒命暗影" 变形为当前打出的法术的复制
                Handmanager.Handcard shadowOfDemise = p.owncards.Find(c => c.card.cardIDenum == CardDB.cardIDEnum.RLK_567);
                if (shadowOfDemise != null)
                {
                    shadowOfDemise.card = hc.card;
                }
            }
        }
    }
}
