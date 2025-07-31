using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：4
	//Sharp Shipment
	//快刀快递
	//Give your weapon +2/+2.
	//使你的武器获得+2/+2。
	class Sim_WORK_005 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				if (p.ownWeapon.Durability >= 1)
				{
					p.ownWeapon.Angr += 2;
					p.ownWeapon.Durability += 2;
					p.minionGetBuffed(p.ownHero, 2, 0);
				}
			}
			else
			{
				if (p.enemyWeapon.Durability >= 1)
				{
					p.enemyWeapon.Angr += 2;
					p.enemyWeapon.Durability += 2;
					p.minionGetBuffed(p.enemyHero, 2, 0);
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
