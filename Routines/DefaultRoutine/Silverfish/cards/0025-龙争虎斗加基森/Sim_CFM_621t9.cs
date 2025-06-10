using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_621t9 : SimTemplate //* 暗影之油 Shadow Oil
//Add a random Demon to your hand.
//随机将一张恶魔牌置入你的手牌。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
		    p.drawACard(CardDB.cardIDEnum.CFM_621_m4, ownplay, true);
		}
	}
}