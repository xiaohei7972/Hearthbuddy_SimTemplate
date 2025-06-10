using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_747 : SimTemplate //* 飞行管理员 Flight Master
//<b>Battlecry:</b> Summon a 2/2 Gryphon for each player.
//<b>战吼：</b>为每个玩家召唤一只2/2的狮鹫。 
	{
        
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DAL_747t); 

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.callKid(kid, p.ownMinions.Count, true);
			p.callKid(kid, p.enemyMinions.Count, false);
		}
	}
}