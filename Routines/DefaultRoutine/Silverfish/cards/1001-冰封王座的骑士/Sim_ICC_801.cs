using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_801: SimTemplate //* 咆哮的指挥官 Howling Commander
//<b>Battlecry:</b> Draw a <b>Divine_Shield</b> minion from your deck.
//<b>战吼：</b>从你的牌库中抽一张具有<b>圣盾</b>的随从牌。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, m.own);
        }
    }
}