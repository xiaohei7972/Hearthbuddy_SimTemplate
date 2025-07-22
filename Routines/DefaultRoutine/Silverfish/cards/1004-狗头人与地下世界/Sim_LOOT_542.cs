using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_542 : SimTemplate //* 弑君 Kingsbane
//[x]Always keepsenchantments.<b>Deathrattle:</b> Shuffle thisinto your deck.
//<b>亡语：</b>将这把武器洗入你的牌库。保留所有额外效果。 
	{
		

		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_950);
		        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.ownDeckSize++;
            }
            else
            {
                p.enemyDeckSize++;
            }
        }		
    }
}