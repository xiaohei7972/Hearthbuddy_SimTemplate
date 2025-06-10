using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_402 : SimTemplate //* 奥秘图纸 Secret Plan
//<b>Discover</b> a <b>Secret</b>.
//<b>发现</b>一张<b>奥秘</b>牌。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
        }
    }
}