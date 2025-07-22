using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA13_4 : SimTemplate //* Wild Magic
	{
		// Hero Power: Put a random spell from your opponent's class into your hand.
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            TAG_CLASS opponentHeroClass = ownplay ? p.enemyHeroStartClass : p.ownHeroStartClass;

            switch (opponentHeroClass)
            {
                case TAG_CLASS.WARRIOR:
					p.drawACard(CardDB.cardNameEN.shieldblock, ownplay, true);
					break;
                case TAG_CLASS.WARLOCK:
					p.drawACard(CardDB.cardNameEN.baneofdoom, ownplay, true);
                    break;
                case TAG_CLASS.ROGUE:
					p.drawACard(CardDB.cardNameEN.sprint, ownplay, true);
					break;
                case TAG_CLASS.SHAMAN:
					p.drawACard(CardDB.cardNameEN.farsight, ownplay, true);
					break;
                case TAG_CLASS.PRIEST:
					p.drawACard(CardDB.cardNameEN.thoughtsteal, ownplay, true);
					break;
                case TAG_CLASS.PALADIN:
					p.drawACard(CardDB.cardNameEN.hammerofwrath, ownplay, true);
					break;
                case TAG_CLASS.MAGE:
					p.drawACard(CardDB.cardNameEN.frostnova, ownplay, true);
					break;
                case TAG_CLASS.HUNTER:
					p.drawACard(CardDB.cardNameEN.cobrashot, ownplay, true);
					break;
                case TAG_CLASS.DRUID:
					p.drawACard(CardDB.cardNameEN.wildgrowth, ownplay, true);
                    break;
				//default:
			}
		}
	}
}