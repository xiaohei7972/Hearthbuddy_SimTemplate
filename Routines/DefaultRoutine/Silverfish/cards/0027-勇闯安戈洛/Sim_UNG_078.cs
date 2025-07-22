using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_078 : SimTemplate //* 始祖龟劫掠者 Tortollan Forager
//<b>Battlecry:</b> Add a random minion with 5 or more Attack to your hand.
//<b>战吼：</b>随机将一张攻击力大于或等于5的随从牌置入你的手牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.bootybaybodyguard, own.own, true);
        }
}
}