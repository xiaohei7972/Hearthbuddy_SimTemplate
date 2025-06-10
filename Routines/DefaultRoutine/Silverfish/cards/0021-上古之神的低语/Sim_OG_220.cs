using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_220 : SimTemplate //* 马尔考罗克 Malkorok
//<b>Battlecry:</b> Equip a random weapon.
//<b>战吼：</b>随机装备一把武器。 
	{
		
		
        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_080);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.equipWeapon(w, own.own);
        }
    }
}