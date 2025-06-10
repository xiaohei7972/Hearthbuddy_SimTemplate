using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX12_03H : SimTemplate //* 巨颚 Jaws
//Whenever a minion with <b>Deathrattle</b> dies, gain +2 Attack.
//每当一个具有<b>亡语</b>的随从死亡，便获得+2攻击力。 
	{
		
		
		
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NAX12_03H);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }
    }
}