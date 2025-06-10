using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_047 : SimTemplate //* 暗中破坏 Sabotage
//Destroy a random enemy minion. <b>Combo:</b> And your opponent's weapon.
//随机消灭一个敌方随从，<b>连击：</b>并且摧毁你对手的武器。 
    {

        


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay)? p.enemyMinions : p.ownMinions;
            if (temp.Count >= 1)
            {
                
                var found = p.searchRandomMinion(temp, searchmode.searchLowestHP);
                if (found != null)
                {
                    p.minionGetDestroyed(found);
                }
            }
            if (p.cardsPlayedThisTurn >= 1) p.lowerWeaponDurability(1000, !ownplay);
        }



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }

}