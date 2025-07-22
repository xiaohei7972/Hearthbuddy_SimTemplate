using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRM_030 : SimTemplate //* Nefarian
	{
		// Battlecry: Add 2 random spells to your hand (from your opponent's class).
		
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
            TAG_CLASS opponentHeroClass = (m.own) ? p.enemyHeroStartClass : p.ownHeroStartClass;

            switch (opponentHeroClass)
            {
                case TAG_CLASS.WARRIOR:
					p.drawACard(CardDB.cardNameEN.shieldblock, m.own, true);
					p.drawACard(CardDB.cardNameEN.shieldblock, m.own, true);
					break;
                case TAG_CLASS.WARLOCK:
					p.drawACard(CardDB.cardNameEN.baneofdoom, m.own, true);
					p.drawACard(CardDB.cardNameEN.baneofdoom, m.own, true);
                    break;
                case TAG_CLASS.ROGUE:
					p.drawACard(CardDB.cardNameEN.sprint, m.own, true);
					p.drawACard(CardDB.cardNameEN.sprint, m.own, true);
					break;
                case TAG_CLASS.SHAMAN:
					p.drawACard(CardDB.cardNameEN.farsight, m.own, true);
					p.drawACard(CardDB.cardNameEN.farsight, m.own, true);
					break;
                case TAG_CLASS.PRIEST:
					p.drawACard(CardDB.cardNameEN.thoughtsteal, m.own, true);
					p.drawACard(CardDB.cardNameEN.thoughtsteal, m.own, true);
					break;
                case TAG_CLASS.PALADIN:
					p.drawACard(CardDB.cardNameEN.hammerofwrath, m.own, true);
					p.drawACard(CardDB.cardNameEN.hammerofwrath, m.own, true);
					break;
                case TAG_CLASS.MAGE:
					p.drawACard(CardDB.cardNameEN.frostnova, m.own, true);
					p.drawACard(CardDB.cardNameEN.frostnova, m.own, true);
					break;
                case TAG_CLASS.HUNTER:
					p.drawACard(CardDB.cardNameEN.cobrashot, m.own, true);
					p.drawACard(CardDB.cardNameEN.cobrashot, m.own, true);
					break;
                case TAG_CLASS.DRUID:
					p.drawACard(CardDB.cardNameEN.wildgrowth, m.own, true);
					p.drawACard(CardDB.cardNameEN.wildgrowth, m.own, true);
                    break;
				//default:
			}
		}
	}
}