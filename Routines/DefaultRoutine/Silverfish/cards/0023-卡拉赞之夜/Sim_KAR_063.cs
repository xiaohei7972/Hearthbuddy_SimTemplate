using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_063 : SimTemplate //* 幽灵之爪 Spirit Claws
//[x]Has +2 Attack while youhave <b>Spell Damage</b>.
//当你拥有<b>法术伤害</b>时，获得+2攻击力。 
	{
		

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_063);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
            if (ownplay)
            {
                if (p.spellpower > 0)
                {
                    p.minionGetBuffed(p.ownHero, 2, 0);
                    p.ownWeapon.Angr += 2;
                    p.ownSpiritclaws = true;
                }
            }
            else
            {
                if (p.enemyspellpower > 0)
                {
                    p.minionGetBuffed(p.enemyHero, 2, 0);
                    p.enemyWeapon.Angr += 2;
                    p.enemySpiritclaws = true;
                }
            }
        }
	}
}