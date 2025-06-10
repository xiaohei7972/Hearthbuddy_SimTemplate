using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_809 : SimTemplate //* 火羽精灵 Fire Fly
//<b>Battlecry</b>: Add a 1/2 Elemental to your hand.
//<b>战吼：</b>将一张1/2的元素牌置入你的手牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.UNG_809t1, own.own, true);
        }
	}
}