using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_229 : SimTemplate //* 高跷艺人 Stiltstepper
	{
		//[x]<b>Battlecry:</b> Draw a card. If youplay it this turn, give yourhero +4 Attack this turn.
		//<b>战吼：</b>抽一张牌。如果你在本回合中使用抽到的牌，使你的英雄在本回合中获得+4攻击力。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.DMF_229, own.own);
			var newHc = p.owncards[p.owncards.Count - 1];
		}

	}
}
