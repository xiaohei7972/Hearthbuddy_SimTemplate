using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_054 : SimTemplate //* 食人魔战槌 Ogre Warmaul
//50% chance to attack the wrong enemy.
//50%几率攻击错误的敌人。 
    {

        
        
        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GVG_054);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(w, ownplay);
        }



    }

}