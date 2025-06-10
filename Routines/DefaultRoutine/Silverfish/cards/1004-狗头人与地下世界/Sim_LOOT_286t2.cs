using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_286t2 : SimTemplate //* 神圣重槌 Sacred Maul
//<b>Battlecry:</b> Give your minions <b>Taunt</b>.
//<b>战吼：</b>使你的所有随从获得<b>嘲讽</b>。
	{

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_286t2);
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.equipWeapon(w, ownplay);
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
			foreach (Minion m in temp)
			{
			   if (!m.taunt)
			    {
					m.taunt = true;
					if (m.own) p.anzOwnTaunt++;
					else p.anzEnemyTaunt++;
				}							
			}
        }
	}
}