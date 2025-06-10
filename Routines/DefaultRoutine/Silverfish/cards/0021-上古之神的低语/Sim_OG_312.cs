using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_312 : SimTemplate //* 恩佐斯的副官 N'Zoth's First Mate
//<b>Battlecry:</b> Equip a 1/3 Rusty Hook.
//<b>战吼：</b>装备一把1/3的锈蚀铁钩。 
	{
		

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_058);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.equipWeapon(w, own.own);
        }
    }
}
