using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：0
	//Ancient Knowledge
	//远古知识
	//Enemy cards cost(@) more next turn.
	//下个回合敌方卡牌的法力值消耗增加（@）点。
	class Sim_TTN_075t2 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.enemyMinions.ForEach(m => m.handcard.manacost += 1);
		}
	}
}
