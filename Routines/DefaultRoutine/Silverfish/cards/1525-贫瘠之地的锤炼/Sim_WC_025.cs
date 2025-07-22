using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_025 : SimTemplate //* 砥石战斧 Whetstone Hatchet
	{
        //After your hero attacks, give a minion in your hand +1 Attack.
        //在你的英雄攻击后，使你手牌中的一张随从牌获得+1攻击力。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WC_025), true);
        }

        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            foreach(Handmanager.Handcard hc in p.owncards)
            {
                if(hc.card.type == CardDB.cardtype.MOB)
                {
                    hc.addattack++;
                    break;
                }
            }
        }

    }
}
