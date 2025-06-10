using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_235 : SimTemplate //* 气球商人 Balloon Merchant
	{
        //<b>Battlecry:</b> Give your Silver Hand Recruits +1 Attack and <b>Divine Shield</b>.
        //<b>战吼：</b>使你的白银之手新兵获得+1攻击力和<b>圣盾</b>。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.name == CardDB.cardNameEN.silverhandrecruit)
                {
                    p.minionGetBuffed(m, 1, 0);
                    m.divineshild = true;
                }
            }
        }
    }
}
