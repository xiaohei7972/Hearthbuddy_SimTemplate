using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_333 : SimTemplate //* 自然研习 Nature Studies
	{
        //<b>Discover</b> a spell. Your next one costs (1) less.
        //<b>发现</b>一张法术牌。你的下一张法术牌法力值消耗减少（1）点。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, true, true);
            p.ownHero.enchs += " SCH_333e";
        }

    }
}
