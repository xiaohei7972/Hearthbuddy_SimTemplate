using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_EX1_016 : SimTemplate //* 希尔瓦娜斯·风行者 Sylvanas Windrunner
//<b>Deathrattle:</b> Takecontrol of a randomenemy minion.
//<b>亡语：</b>随机获得一个敌方随从的控制权。 
	{
        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            Minion target;
            if (m.own)
            {
                target = p.searchRandomMinion(p.enemyMinions, searchmode.searchLowestHP);
            }
            else
            {
                target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestHP);
                if (p.isOwnTurn && target != null && target.Ready) p.evaluatePenality += 5;
            }
            if (target != null) p.minionGetControlled(target, m.own, false);
        }
	}
}