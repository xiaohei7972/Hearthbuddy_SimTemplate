using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：7
	//Behemoth Mask
	//巨鳗面具
	//[x]Set a minion's stats to8/10 and give it <b>Lifesteal</b>.Force a random enemyminion to attack it.
	//将一个随从的属性值变为8/10并使其获得<b>吸血</b>。随机迫使一个敌方随从攻击该随从。
	class Sim_DINO_428 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionSetAngrToX(target, 8);
				p.minionSetLifetoX(target, 10);
				target.lifesteal = true;
				foreach (Minion minion in ownplay ? p.enemyMinions : p.ownMinions)
				{
					if (!minion.untouchable)
					{
						p.minionAttacksMinion(minion, target);
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
