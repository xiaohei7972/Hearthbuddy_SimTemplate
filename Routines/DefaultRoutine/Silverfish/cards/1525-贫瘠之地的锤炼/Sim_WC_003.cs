using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_003 : SimTemplate //* 召唤咒符 Sigil of Summoning
	{
        //At the start of your next turn, summon two 2/2 Demons with <b>Taunt</b>.
        //在你的下个回合开始时，召唤两个2/2并具有<b>嘲讽</b>的恶魔。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.evaluatePenality -= 10;
        }

    }
}
