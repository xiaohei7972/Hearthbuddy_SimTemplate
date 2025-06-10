using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TID_004 : SimTemplate //* 小丑鱼 Clownfish
//战吼：你的下两张鱼人牌的法力值消耗减少（2）点。
//Battlecry: Your next two Murlocs cost(2) less.
	{
		

		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
            if (m.own) p.anzOwnMurlocConsort++;
		}
	}
}