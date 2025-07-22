using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_313 : SimTemplate //* 先到先得 Finders Keepers
//<b>Discover</b> a card with_<b>Overload</b>. <b>Overload:</b> (1)
//<b>发现</b>一张具有<b>过载</b>的牌。<b>过载：</b> （1） 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.lightningbolt, ownplay);
            if (ownplay) p.ueberladung++;
        }
    }
}