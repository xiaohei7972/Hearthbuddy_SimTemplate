using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_030 : SimTemplate //* 电镀机械熊仔 Anodized Robo Cub
//<b>Taunt</b>. <b>Choose One -</b>+1 Attack; or +1 Health.
//<b>嘲讽，抉择：</b>+1攻击力；或者+1生命值。 
    {
        

           public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (choice == 1 || (p.ownFandralStaghelm > 0 && own.own))
            {
                p.minionGetBuffed(own, 1, 0);
            }
            if (choice == 2 || (p.ownFandralStaghelm > 0 && own.own))
            {
                p.minionGetBuffed(own, 0, 1);
            }
		}
    }

}