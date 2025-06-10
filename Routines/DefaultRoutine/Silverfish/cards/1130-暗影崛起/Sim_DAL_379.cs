using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_379 : SimTemplate //* 温蕾萨·风行者 Vereesa Windrunner
//<b>Battlecry:</b> Equip Thori'dal, the Stars' Fury.
//<b>战吼：</b>装备索利达尔，群星之怒。
    {
        CardDB.Card wcard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DAL_379t);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.equipWeapon(wcard,own.own);

        }

    }
}
