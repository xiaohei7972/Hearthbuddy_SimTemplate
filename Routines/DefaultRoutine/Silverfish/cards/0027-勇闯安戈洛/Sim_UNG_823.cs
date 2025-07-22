using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_823 : SimTemplate //* 浸毒武器 Envenom Weapon
//Give your weapon <b>Poisonous</b>.
//使你的武器获得<b>剧毒</b>。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			if (ownplay) p.ownWeapon.poisonous = true;
			else p.enemyWeapon.poisonous = true;
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_WEAPON_EQUIPPED),
            };
        }
    }
}