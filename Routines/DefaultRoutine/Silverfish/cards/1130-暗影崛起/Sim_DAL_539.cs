using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_539 : SimTemplate //* 夺日者战斗法师 Sunreaver Warmage
//<b>Battlecry:</b> If you're holding a spell that costs (5) or more, deal 4 damage.
//<b>战吼：</b>如果你的手牌中有法力值消耗大于或等于（5）点的法术牌，则造成4点伤害。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                int dmg = 4;
				p.minionGetDamageOrHeal(target, dmg);
            }
        }
    }
}