using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_653 : SimTemplate //* 樵夫之斧 Woodcutter's Axe
//<b>Deathrattle:</b> Give +2/+1 to a random friendly <b>Rush</b> minion.
//<b>亡语：</b>随机使一个友方<b>突袭</b>随从获得+2/+1。 
    {
        

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_653);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
            if (temp.Count >= 1)
            {
                int sum = 1000;
                Minion t = null;

                foreach (Minion mnn in temp)
                {
                    if ((TAG_RACE)mnn.handcard.card.race == TAG_RACE.MECHANICAL)
                    {
                        int s = mnn.maxHp + mnn.Angr;
                        if (s < sum)
                        {
                            t = mnn;
                            sum = s;
                        }
                    }
                }

                if (t != null && sum < 999)
                {
                    p.minionGetBuffed(t, 2, 1);
                }
            }
        }
    }
}