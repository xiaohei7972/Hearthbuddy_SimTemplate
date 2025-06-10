using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_496 : SimTemplate //* 暴怒的邪鳍 Furious Felfin
	{
        //[x]<b>Battlecry:</b> If your heroattacked this turn, gain+1 Attack and <b>Rush</b>.
        //<b>战吼：</b>在本回合中，如果你的英雄进行过攻击，则获得+1攻击力和<b>突袭</b>。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if(p.ownHero.Angr > 0 && !p.ownHero.Ready)
            {
                p.minionGetBuffed(own, 1, 0);
                p.minionGetRush(own);
                //own.updateReadyness();
            }
        }

    }
}
