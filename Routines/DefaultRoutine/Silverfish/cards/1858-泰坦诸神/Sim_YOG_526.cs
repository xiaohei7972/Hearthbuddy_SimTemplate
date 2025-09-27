using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：2
	//Tentacle Grip
	//触须缠握
	//Deal $3 damage.<b>Combo:</b> Get a 1/1 Chaotic Tendril.
	//造成$3点伤害。<b>连击：</b>获取一张1/1的混乱触须。
	class Sim_YOG_526 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				p.minionGetDamageOrHeal(target, dmg);
				if (true)
				{
					p.drawACard(CardDB.cardIDEnum.YOG_514, ownplay, true);

				}
			}
		}


		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
			};
		}

	}
}
