using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_510 : SimTemplate //* 艾德温，迪菲亚首脑 Edwin, Defias Kingpin
    {
        //战吼：抽一张牌。如果你在本回合中使用抽到的牌，则获得+2/+2并重复此效果。
        //Battlecry: Draw a card. If you play it this turn, gain +2/+2 and repeat this effect.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

        }
    }
}
