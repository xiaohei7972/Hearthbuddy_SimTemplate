using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_076 : SimTemplate //* 芬利·莫格顿爵士 Sir Finley Mrrgglton
//<b><b>Battlecry:</b> Discover</b> a new basic Hero Power.
//<b>战吼：发现</b>一个新的基础英雄技能。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, own.own, true);
		}
	}
}