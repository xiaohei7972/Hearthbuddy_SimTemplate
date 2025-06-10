using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_REV_313 : SimTemplate //* 安插证据 Planted Evidence
                                    //发现一张法术牌。在本回合中，其法力值消耗减少（2）点。
                                    //Discover a spell.It costs (2) less this turn.
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.activate, ownplay, true);
        }
    }
}
