using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_097 : SimTemplate //* 守护者麦迪文 Medivh, the Guardian
//<b>Battlecry:</b> Equip Atiesh, Greatstaff of the Guardian.
//<b>战吼：</b>装备埃提耶什，守护者的传说之杖。 
	{
		
		
        CardDB.Card wcard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_097t);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.equipWeapon(wcard, own.own);
        }
    }
}
