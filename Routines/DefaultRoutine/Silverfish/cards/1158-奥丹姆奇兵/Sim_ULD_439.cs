using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_439 : SimTemplate //* 沙漠蜂后 Sandwasp Queen
//<b>Battlecry:</b> Add two 2/1 Sandwasps to your hand.
//<b>战吼：</b>将两张2/1的“沙漠胡蜂”置入你的手牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.sandwasp, own.own, true);
            p.drawACard(CardDB.cardNameEN.sandwasp, own.own, true);
		}
	}
}