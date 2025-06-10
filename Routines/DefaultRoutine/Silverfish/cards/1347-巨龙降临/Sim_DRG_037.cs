using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_037 : SimTemplate //* 菲里克·飞刺 Flik Skyshiv
	{
		//[x]<b>Battlecry:</b> Destroy aminion and all copies of it<i>(wherever they are)</i>.
		//<b>战吼：</b>消灭一个随从及其所有的复制<i>（无论它们在哪）</i>。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				//消灭场上的选定相同随从，由于Playfield无法知道对方手牌与牌库，故不涉及
				p.minionGetDestroyed(target);
				List<Minion> temp2 = (own.own) ? new List<Minion>(p.enemyMinions) : new List<Minion>(p.ownMinions);
				foreach (Minion enemy in temp2)
				{
					if (enemy.name == target.name)
					{
						p.minionGetDestroyed(enemy);
					}
				}
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}