using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_020 : SimTemplate //* 大漠沙驼 Desert Camel
//<b>Battlecry:</b> Put a 1-Cost minion from each deck into the battlefield.
//<b>战吼：</b>从双方的牌库中各将一个法力值消耗为（1）的随从置入战场。 
	{
        
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BRM_004); 

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.callKid(kid, p.ownMinions.Count, true);
			p.callKid(kid, p.enemyMinions.Count, false);
		}
	}
}