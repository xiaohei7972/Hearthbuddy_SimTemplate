using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_912 : SimTemplate //* 宝石鹦鹉 Jeweled Macaw
//<b>Battlecry:</b> Add a random Beast to your hand.
//<b>战吼：</b>随机将一张野兽牌置入你的手牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.rivercrocolisk, own.own, true);
        }
}
}