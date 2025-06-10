using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_836 : SimTemplate //* 炽焰祈咒 Blazing Invocation
//<b>Discover</b> a <b>Battlecry</b> minion.
//<b>发现</b>一张具有<b>战吼</b>的随从牌。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.pompousthespian, ownplay, true);
        }
    }
}