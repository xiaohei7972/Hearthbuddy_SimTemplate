using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_720: SimTemplate //* 摇摆矿锄 Waggle Pick
//[x]<b>Deathrattle:</b> Returna random friendlyminion to your hand.It costs (2) less.
//<b>亡语：</b>随机将一个友方随从移回你的手牌。它的法力值消耗减少（2）点。 
    {
        

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DAL_720);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            List<Minion> temp = new List<Minion>();

            if (m.own)
            {
                List<Minion> temp2 = new List<Minion>(p.ownMinions);
                temp2.Sort((a, b) => -a.Angr.CompareTo(b.Angr));
                temp.AddRange(temp2);
            }
            else
            {
                List<Minion> temp2 = new List<Minion>(p.enemyMinions);
                temp2.Sort((a, b) => a.Angr.CompareTo(b.Angr));
                temp.AddRange(temp2);
            }

            if (temp.Count >= 1)
            {
                if (m.own)
                {
                    Minion target = new Minion();
                    target = temp[0];
                    if (temp.Count >= 2 && !target.taunt && temp[1].taunt) target = temp[1];
                    p.minionReturnToHand(target, m.own, 0);
                }
                else
                {
                    Minion target = new Minion();

                    target = temp[0];
                    if (temp.Count >= 2 && target.taunt && !temp[1].taunt) target = temp[1];
                    p.minionReturnToHand(target, m.own, 0);
                }
            }
        }
    }
}