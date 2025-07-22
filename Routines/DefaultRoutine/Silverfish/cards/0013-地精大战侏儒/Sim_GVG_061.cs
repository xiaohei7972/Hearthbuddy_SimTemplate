using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_061 : SimTemplate //* 作战动员 Muster for Battle
//Summon three 1/1 Silver Hand Recruits. Equip a 1/4 Weapon.
//召唤三个1/1的白银之手新兵，装备一把1/4的武器。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t);
        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_091);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            for (int i = 0; i < 2; i++) p.callKid(kid, pos, ownplay);

            p.equipWeapon(w, ownplay);
        }
    }
}