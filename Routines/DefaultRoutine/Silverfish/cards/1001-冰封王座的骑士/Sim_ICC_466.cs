using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_466: SimTemplate //* 萨隆苦囚 Saronite Chain Gang
    {
		//[x]<b>Taunt</b><b>Battlecry:</b> Summon acopy of this minion.
		//<b>嘲讽</b><b>战吼：</b>召唤一个该随从的复制。
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            var minionsCnt = (m.own ? p.ownMinions : p.enemyMinions).Count;
            if (minionsCnt < 7) {
                p.callKid(m.handcard.card, m.zonepos, m.own);
                (m.own ? p.ownMinions : p.enemyMinions)[minionsCnt].setMinionToMinion(m);
            }
        }
    }
}
