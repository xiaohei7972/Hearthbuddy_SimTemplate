using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_119 : SimTemplate //* 布林顿3000型 Blingtron 3000
//<b>Battlecry:</b> Equip a random weapon for each player.
//<b>战吼：</b>为每个玩家装备一把武器。 
    {

        
        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_080);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.equipWeapon(w, true);
            p.equipWeapon(w, false);
        }


    }

}