using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：3
	//Fire Breath
	//喷吐火焰
	//Deal $4 damage.Give your Elementals +1/+1.
	//造成$4点伤害。使你的元素获得+1/+1。
	class Sim_DINO_406 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
				foreach (Minion minion in ownplay ? p.ownMinions : p.enemyMinions)
				{
					if (RaceUtils.MinionBelongsToRace(minion.handcard.card.races, CardDB.Race.ELEMENTAL))
					{
						p.minionGetBuffed(minion, 1, 1);
					}
				}
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
