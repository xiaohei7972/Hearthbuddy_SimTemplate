using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_941 : SimTemplate //* 远古雕文 Primordial Glyph
//<b>Discover</b> a spell. Reduce its Cost by (2).
//<b>发现</b>一张法术牌，使其法力值消耗减少（2）点。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.frostbolt, ownplay, true);
        }
    }
}