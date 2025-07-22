using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_001 : SimTemplate //* 伊利达雷研习 Illidari Studies
	{
        //<b>Discover</b> an <b>Outcast</b> card. Your next one costs (1) less.
        //<b>发现</b>一张<b>流放</b>牌。你的下一张<b>流放</b>牌法力值消耗减少（1）点。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, true, true);
        }

    }
}
