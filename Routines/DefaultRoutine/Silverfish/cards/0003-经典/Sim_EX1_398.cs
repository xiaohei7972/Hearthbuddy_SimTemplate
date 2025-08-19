using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_398 : SimTemplate //* 阿拉希武器匠 Arathi Weaponsmith
	{
		//<b>Battlecry:</b> Equip a 2/2_weapon.
		//<b>战吼：</b>装备一把2/2的武器。
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_398t);//battleaxe

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.equipWeapon(weapon,own.own);

        }

    }
}
