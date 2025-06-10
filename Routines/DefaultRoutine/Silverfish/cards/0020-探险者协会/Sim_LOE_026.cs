using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_026 : SimTemplate //* 亡者归来 Anyfin Can Happen
//Summon 7 Murlocs that died this game.
//召唤七个在本局对战中死亡的鱼人。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            var temp = (ownplay) ? Probabilitymaker.Instance.ownGraveyard : Probabilitymaker.Instance.enemyGraveyard;
            if (place > 6) return;

            CardDB.Card c;
            foreach (var gi in temp)
            {
                c = CardDB.Instance.getCardDataFromID(gi.Key);
                if ((TAG_RACE)c.race == TAG_RACE.MURLOC)
                {
                    p.callKid(c, place, ownplay, false);
                    place++;
                    if (place > 6) break;
                    if (gi.Value > 1)
                    {
                        p.callKid(c, place, ownplay, false);
                        place++;
                        if (place > 6) break;
                    }
                }
            }
            if (place > 6) return;
            foreach (var gi in p.diedMinions)
            {
                if (gi.own == ownplay)
                {
                    c = CardDB.Instance.getCardDataFromID(gi.cardid);
                    if ((TAG_RACE)c.race == TAG_RACE.MURLOC)
                    {
                        p.callKid(c, place, ownplay, false);
                        place++;
                        if (place > 6) break;
                    }
                }
            }
        }
    }
}