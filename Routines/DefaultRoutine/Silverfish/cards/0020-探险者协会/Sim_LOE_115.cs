using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_115 : SimTemplate //* 乌鸦神像 Raven Idol
//<b>Choose One -</b><b>Discover</b> a minion; or <b>Discover</b> a spell.
//<b>抉择：</b><b>发现</b>一张随从牌；或者<b>发现</b>一张法术牌。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                p.drawACard(CardDB.cardNameEN.lepergnome, ownplay, true);
            }
            if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                p.drawACard(CardDB.cardNameEN.thecoin, ownplay, true);
            }
		}
	}
}