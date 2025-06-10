using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_409 : SimTemplate //* 升级 Upgrade!
	{
		//If you have a weapon, give it +1/+1. Otherwise equip a 1/3 weapon.
		//如果你装备一把武器，使它获得+1/+1。否则，装备一把1/3的武器。

        CardDB.Card wcard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_409t);//Heavy Axe

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                if (p.ownWeapon.Durability > 0)
                {
                    p.ownWeapon.Angr++;
                    p.ownWeapon.Durability++;
                    p.minionGetBuffed(p.ownHero, 1, 0);
                }
                else
                {
                    p.equipWeapon(wcard, true);
                }
            }
            else
            {
                if (p.enemyWeapon.Durability > 0)
                {
                    p.enemyWeapon.Angr++;
                    p.enemyWeapon.Durability++;
                    p.minionGetBuffed(p.enemyHero, 1, 0);
                }
                else
                {
                    p.equipWeapon(wcard, false);
                }
            }
		}
	}
}