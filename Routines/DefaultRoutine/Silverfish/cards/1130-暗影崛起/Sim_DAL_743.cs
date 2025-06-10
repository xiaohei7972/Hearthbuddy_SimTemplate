using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_743 : SimTemplate //* 荆棘帮斗猪 Hench-Clan Hogsteed
//<b>Rush</b><b>Deathrattle:</b> Summon a 1/1 Murloc.
//<b>突袭，亡语：</b>召唤一个1/1的鱼人。 
	{
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DAL_743t);
		
		public override void onDeathrattle(Playfield p, Minion m)
		{
            p.callKid(kid, m.zonepos - 1, m.own);
		}

    }
}