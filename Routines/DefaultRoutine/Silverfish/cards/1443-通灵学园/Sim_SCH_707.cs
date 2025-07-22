using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_707 : SimTemplate //* 鱼人飞骑 Fishy Flyer
	{
        //<b>Rush</b>. <b>Deathrattle:</b> Add a_4/3 Ghost with <b>Rush</b> to_your hand.
        //<b>突袭，亡语：</b>将一个4/3并具有<b>突袭</b>的幽灵置入你的手牌。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.SCH_707t, m.own, true);
        }

    }
}
