using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_058 : SimTemplate //* 刀瓣鞭笞者 Razorpetal Lasher
//[x]<b>Battlecry:</b> Add aRazorpetal to your handthat deals 1 damage.
//<b>战吼：</b>将一张可造成1点伤害的“刀瓣”置入你的手牌。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.UNG_057t1, own.own, true);
        }
	}
}