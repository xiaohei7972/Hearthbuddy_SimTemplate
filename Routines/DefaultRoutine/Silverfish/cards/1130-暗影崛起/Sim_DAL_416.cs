using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_416 : SimTemplate //* 荆棘帮蟊贼 Hench-Clan Burglar
//<b>Battlecry:</b> <b>Discover</b> a spell from another class.
//<b>战吼：</b><b>发现</b>一张其他职业的法术牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.frostbolt, m.own, true);
        }
    }
}