using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_057 : SimTemplate //* 刀瓣齐射 Razorpetal Volley
//Add two Razorpetals to_your hand that deal_1 damage.
//将两张可造成1点伤害的“刀瓣”置入你的手牌。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.UNG_057t1,ownplay, true);
            p.drawACard(CardDB.cardIDEnum.UNG_057t1, ownplay, true);
        }
    }
}