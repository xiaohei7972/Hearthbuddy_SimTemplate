using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_363 : SimTemplate //* 旱谷狱卒 Drygulch Jailor
//<b>Deathrattle:</b> Add 3 Silver_Hand Recruits to_your_hand.
//<b>亡语：</b>将三张“白银之手新兵”置入你的手牌。 
	{
		
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t);
		
		public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.CS2_101t, m.own, true);
            p.drawACard(CardDB.cardIDEnum.CS2_101t, m.own, true);
            p.drawACard(CardDB.cardIDEnum.CS2_101t, m.own, true);
        }
	}
}