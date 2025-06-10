using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_133 : SimTemplate //* 恩佐斯 N'Zoth, the Corruptor
//<b>Battlecry:</b> Summon your <b>Deathrattle</b> minions that died this game.
//<b>战吼：</b>召唤所有你在本局对战中死亡的，并具有<b>亡语</b>的随从。 
    {
        

        CardDB CardDBI = CardDB.Instance;
        CardDB.Card kid = null;

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int kids = 7 - p.ownMinions.Count;

            if (kids > 0)
            {
                foreach (KeyValuePair<CardDB.cardIDEnum, int> e in Probabilitymaker.Instance.ownGraveyard)
                {
                    kid = CardDBI.getCardDataFromID(e.Key);
                    if (kid.deathrattle)
                    {
                        for (int i = 0; i < e.Value; i++)
                        {
                            p.callKid(kid, own.zonepos, own.own);
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