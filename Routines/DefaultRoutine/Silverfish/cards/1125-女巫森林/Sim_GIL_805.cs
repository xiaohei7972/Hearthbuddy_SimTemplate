using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_805 : SimTemplate //* 破棺者 Coffin Crasher
//<b>Deathrattle:</b> Summon a <b>Deathrattle</b> minion from your hand.
//<b>亡语：</b>从你的手牌中召唤一个<b>亡语</b>随从。 
	{
        
        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_335);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                List<Handmanager.Handcard> temp = new List<Handmanager.Handcard>();
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if ((TAG_RACE)hc.card.race == TAG_RACE.DEMON)
                    {
                        temp.Add(hc);
                    }
                }

                temp.Sort((x, y) => x.card.Attack.CompareTo(y.card.Attack));

                foreach (Handmanager.Handcard mnn in temp)
                {
                    p.callKid(mnn.card, p.ownMinions.Count, true, false);
                    p.removeCard(mnn);
                    break;
                }
            }
            else
            {
                if (p.enemyAnzCards >= 1)
                {
                    p.callKid(c, p.enemyMinions.Count, false, false);
                }
            }
        }
	}
}