using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_043 : SimTemplate //* 重型刃弩 Glaivezooka
//<b>Battlecry:</b> Give a random friendly minion +1 Attack.
//<b>战吼：</b>随机使一个友方随从获得+1攻击力。 
    {

        

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GVG_043);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(w, ownplay);
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            if (temp.Count <= 0) return;
            
            var found = p.searchRandomMinion(temp, searchmode.searchLowestAttack);
            if (found != null)
            {
                p.minionGetBuffed(found, 1, 0);
            }

        }

    }

}