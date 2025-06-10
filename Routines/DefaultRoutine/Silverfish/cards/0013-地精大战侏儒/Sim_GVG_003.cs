using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_003 : SimTemplate //* 不稳定的传送门 Unstable Portal
//Add a random minion to your hand. It costs (3) less.
//随机将一张随从牌置入你的手牌。该牌的法力值消耗减少（3）点。 
    {

        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
        }

    }

}