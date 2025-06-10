using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_219 : SimTemplate //* 闪电吐息 Lightning Breath
	{
		//[x]Deal $4 damage to aminion. If you're holdinga Dragon, also damageits neighbors.
		//对一个随从造成$4点伤害。如果你的手牌中有龙牌，则同样对其相邻随从造成伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				bool dragonInHand = false;
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if ((TAG_RACE)hc.card.race == TAG_RACE.DRAGON)
					{
						dragonInHand = true;
						break;
					}
				}
				if (dragonInHand)
				{
					int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
					p.minionGetDamageOrHeal(target, dmg);
					List<Minion> temp = (target.own) ? p.ownMinions : p.enemyMinions;
					foreach (Minion m in temp)
					{
						if (target.zonepos == m.zonepos + 1 || target.zonepos + 1 == m.zonepos)
						{
							p.minionGetDamageOrHeal(m, dmg);
						}
					}
				}
				else
				{
					int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
					p.minionGetDamageOrHeal(target, dmg);
				}
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}