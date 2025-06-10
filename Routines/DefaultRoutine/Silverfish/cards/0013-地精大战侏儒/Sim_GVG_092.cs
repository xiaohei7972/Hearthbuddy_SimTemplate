using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_092 : SimTemplate //* 侏儒实验技师 Gnomish Experimenter
//<b>Battlecry:</b> Draw a card. If it's a minion, transform it into a Chicken.
//<b>战吼：</b>抽一张牌，如果该牌是随从牌，则将其变形成为一只小鸡。 
    {

        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, own.own);
        }

    }

}