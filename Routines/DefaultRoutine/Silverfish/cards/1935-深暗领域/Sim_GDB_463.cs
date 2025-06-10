using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GDB_463 : SimTemplate //* 困窘的机械师 
	{
        //[x]<b>Divine Shield</b> <b><b>Spellburst</b>:</b> Draw a Draenei.
        //<b>圣盾</b>。<b><b>法术迸发</b>：</b>抽一张德莱尼牌。

        public override void OnSpellburst(Playfield p, Minion m, Handmanager.Handcard hc)
        {
            if (m.own)
            {
                CardDB.Card c;
                foreach (KeyValuePair<CardDB.cardIDEnum, int> cid in p.prozis.turnDeck)
                {
                    c = CardDB.Instance.getCardDataFromID(cid.Key);
                    if ((TAG_RACE)c.race == TAG_RACE.DRAENEI)
                    {
                        for (int i = 0; i < cid.Value; i++)
                        {
                            p.drawACard(cid.Key, true);
                        }
                    }
                }
            }
        }

    }
}
