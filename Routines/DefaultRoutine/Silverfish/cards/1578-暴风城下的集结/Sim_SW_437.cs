using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_437 : SimTemplate //* 施肥 Composting
	{
        //Give your minions"<b>Deathrattle:</b> Draw__a card."
        //使你的所有随从获得“<b>亡语：</b>抽一张牌。”
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;

            foreach (Minion m in temp)
            {
                m.enchs += " SW_437e";
            }
        }
    }
}
