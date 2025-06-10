using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_065 : SimTemplate //* 国王护卫者 King's Defender
//<b>Battlecry:</b> If you have a minion with <b>Taunt</b>, gain +1 Durability.
//<b>战吼：</b>如果你控制任何具有<b>嘲讽</b>的随从，便获得+1耐久度。 
	{
		

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_065);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.equipWeapon(weapon, ownplay);

            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.taunt)
                {
                    if (ownplay) p.ownWeapon.Durability++;
                    else p.enemyWeapon.Durability++;
                    break;
                }
            }
		}
	}
}