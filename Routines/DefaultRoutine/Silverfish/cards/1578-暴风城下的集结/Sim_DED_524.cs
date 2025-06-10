using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_524 : SimTemplate //* 多系施法者 Multicaster
    {
        //战吼：在本局对战中，你每施放过一个不同派系的法术，抽一张牌。
        //Battlecry: Draw a card for each different spell school you've cast this game.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

        }
    }
}
