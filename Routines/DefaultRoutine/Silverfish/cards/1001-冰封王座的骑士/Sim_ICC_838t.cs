using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_838t : SimTemplate //* 被冰封的勇士 Frozen Champion
//[x]<b>Deathrattle:</b> Add arandom <b>Legendary</b> minionto your hand.
//<b>亡语：</b>随机将一个<b>传说</b>随从置入你的手牌。 
    {
        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.None, m.own, true);
            p.drawACard(CardDB.cardIDEnum.None, m.own, true);
        }
    }
}