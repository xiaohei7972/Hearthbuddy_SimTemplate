using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_132 : SimTemplate //* Justicar Trueheart
	{
		//Battlecry: Replace your starting Hero Power with a better one.
		
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
            TAG_CLASS HeroStartClass = (m.own) ? p.ownHeroStartClass : p.enemyHeroStartClass;
			CardDB.cardIDEnum tmp = CardDB.cardIDEnum.None;

            switch (HeroStartClass)
            {
                case TAG_CLASS.WARRIOR:
					tmp = CardDB.cardIDEnum.HERO_01bp2; //Tank Up!
					break;
                case TAG_CLASS.WARLOCK:
					tmp = CardDB.cardIDEnum.HERO_07bp2; //Soul Tap
                    break;
                case TAG_CLASS.ROGUE:
					tmp = CardDB.cardIDEnum.HERO_03bp2; //Poisoned Daggers
					break;
                case TAG_CLASS.SHAMAN:
					tmp = CardDB.cardIDEnum.HERO_02bp2; //Totemic Slam
					break;
                case TAG_CLASS.PRIEST:
					tmp = CardDB.cardIDEnum.HERO_09bp2; //Heal
					break;
                case TAG_CLASS.PALADIN:
					tmp = CardDB.cardIDEnum.HERO_04bp2; //The Silver Hand
					break;
                case TAG_CLASS.MAGE:
					tmp = CardDB.cardIDEnum.HERO_08bp2; //Fireblast Rank 2
					break;
                case TAG_CLASS.HUNTER:
					tmp = CardDB.cardIDEnum.HERO_05bp2; //Ballista Shot
					break;
                case TAG_CLASS.DRUID:
					tmp = CardDB.cardIDEnum.HERO_06bp2; //Dire Shapeshift
                    break;
				//default:
			}

            if (tmp != CardDB.cardIDEnum.None) p.setNewHeroPower(tmp, m.own);
		}
	}
}