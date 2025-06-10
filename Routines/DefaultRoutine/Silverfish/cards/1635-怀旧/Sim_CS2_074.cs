using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_074 : SimTemplate //* 致命药膏 Deadly Poison
	{
		//Give your weapon +2_Attack.
		//使你的武器获得+2攻击力。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                if (p.ownWeapon.Durability >= 1)
                {
                    p.ownWeapon.Angr += 2;
                    p.ownHero.Angr += 2;
                }
            }
            else
            {
                if (p.enemyWeapon.Durability >= 1)
                {
                    p.enemyWeapon.Angr += 2;
                    p.enemyHero.Angr += 2;
                }
            }
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_WEAPON_EQUIPPED),
            };
        }
	}
}