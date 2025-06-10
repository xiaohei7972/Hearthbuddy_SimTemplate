using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_066 : SimTemplate //* 暗金教侍从 Kabal Lackey
//[x]<b>Battlecry:</b> The next <b>Secret</b>you play this turn costs (0).
//<b>战吼：</b>在本回合中，你使用的下一个<b>奥秘</b>的法力值消耗为（0）点。 
	{
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own) p.nextSecretThisTurnCost0 = true;
        }
    }
}
