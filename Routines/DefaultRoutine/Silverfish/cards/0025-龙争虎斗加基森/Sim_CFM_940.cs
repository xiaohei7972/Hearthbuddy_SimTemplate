using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_940 : SimTemplate //* 盛气凌人 I Know a Guy
//<b>Discover</b> a <b>Taunt</b> minion.
//<b>发现</b>一张具有<b>嘲讽</b>的随从牌。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.pompousthespian, ownplay, true);
        }
    }
}