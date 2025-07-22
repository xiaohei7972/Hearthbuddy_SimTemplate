using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_017 : SimTemplate //* 召唤宠物 Call Pet
//Draw a card.If it's a Beast, it costs (4) less.
//抽一张牌。如果该牌是野兽牌，则其法力值消耗减少（4）点。 
    {

        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
        }
    }
}