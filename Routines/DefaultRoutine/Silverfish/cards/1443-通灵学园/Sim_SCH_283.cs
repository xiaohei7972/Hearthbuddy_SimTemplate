using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_283 : SimTemplate //* 食魔影豹
	{
		//战吼：在本回合中，如果你使用过你的英雄技能，抽一张牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(p.anzUsedOwnHeroPower >= 1 && own.own)
		    {
				p.drawACard(CardDB.cardNameEN.unknown, own.own);				
			}
			p.evaluatePenality -= 4;
		}		
	}
}
