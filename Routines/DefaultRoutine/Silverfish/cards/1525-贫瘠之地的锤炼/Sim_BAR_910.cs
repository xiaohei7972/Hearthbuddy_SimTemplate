using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：1
	//Grimoire of Sacrifice
	//牺牲魔典
	//Destroy a friendly minion. Deal $2 damage to all enemy minions.
	//消灭一个友方随从。对所有敌方随从造成$2点伤害。
	class Sim_BAR_910 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
				p.minionGetDestroyed(target);
				p.allMinionOfASideGetDamage(!ownplay, damage);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
			};
        }
		
	}
}
