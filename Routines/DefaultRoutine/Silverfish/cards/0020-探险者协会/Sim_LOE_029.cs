using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_029 : SimTemplate //* 宝石甲虫 Jeweled Scarab
//<b>Battlecry: Discover</b> a3-Cost card.
//<b>战吼：发现</b>一张法力值消耗为（3）的卡牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.spidertank, own.own, true);
		}
	}
}