using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_835: SimTemplate //* 哈多诺克斯 Hadronox
//<b>Deathrattle:</b> Summon your <b>Taunt</b> minions thatdied this game.
//<b>亡语：</b>召唤所有你在本局对战中死亡的，并具有<b>嘲讽</b>的随从。 
    {
        

        CardDB cdb = CardDB.Instance;
        CardDB.Card kid = null;

        public override void onDeathrattle(Playfield p, Minion m)
        {
            int pos = m.own ? p.ownMinions.Count : p.enemyMinions.Count;
            int kids = 7 - pos;
            if (kids > 0)
            {
                foreach (KeyValuePair<CardDB.cardIDEnum, int> e in Probabilitymaker.Instance.ownGraveyard)
                {
                    kid = cdb.getCardDataFromID(e.Key);
                    if (kid.tank)
                    {
                        for (int i = 0; i < e.Value; i++)
                        {
                            p.callKid(kid, pos, m.own);
                            kids--;
                            if (kids < 1) break;
                        }
                        if (kids < 1) break;
                    }
                }
            }
        }
    }
}