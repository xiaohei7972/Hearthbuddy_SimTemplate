using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_946 : SimTemplate //* 贪食软泥怪 Gluttonous Ooze
//<b>Battlecry:</b> Destroy your opponent's weapon and gain Armor equal to its Attack.
//<b>战吼：</b>摧毁对手的武器，并获得等同于其攻击力的护甲值。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int num = p.enemyWeapon.Angr;
            if (!own.own) num = p.ownWeapon.Angr;
            p.lowerWeaponDurability(1000, !own.own);
            p.minionGetArmor(own.own ? p.ownHero : p.enemyHero, num);	
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_DEATHRATTLE),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}